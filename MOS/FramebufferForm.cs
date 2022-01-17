using System.Runtime.InteropServices;

namespace MOS.OpenGL
{
    public class FramebufferForm : Form
    {
        #region Win32
        private struct PIXELFORMATDESCRIPTOR
        {
            public short nSize;
            public short nVersion;
            public int dwFlags;
            public byte iPixelType;
            public byte cColorBits;
            public byte cRedBits;
            public byte cRedShift;
            public byte cGreenBits;
            public byte cGreenShift;
            public byte cBlueBits;
            public byte cBlueShift;
            public byte cAlphaBits;
            public byte cAlphaShift;
            public byte cAccumBits;
            public byte cAccumRedBits;
            public byte cAccumGreenBits;
            public byte cAccumBlueBits;
            public byte cAccumAlphaBits;
            public byte cDepthBits;
            public byte cStencilBits;
            public byte cAuxBuffers;
            public byte iLayerType;
            public byte bReserved;
            public int dwLayerMask;
            public int dwVisibleMask;
            public int dwDamageMask;
        }

        private const int PFD_SUPPORT_OPENGL = 0x00000020;
        private const int PFD_DOUBLEBUFFER = 0x00000001;
        private const int PFD_DRAW_TO_WINDOW = 4;
        public const uint GL_FRAGMENT_SHADER = 0x8B30;

        [DllImport("gdi32.dll")]
        private static extern int ChoosePixelFormat(IntPtr hdc, [In] ref PIXELFORMATDESCRIPTOR ppfd);
        [DllImport("gdi32.dll")]
        private static extern bool SetPixelFormat(IntPtr hdc, int iPixelFormat, ref PIXELFORMATDESCRIPTOR ppfd);
        [DllImport("gdi32.dll")]
        private static extern bool SwapBuffers(IntPtr hdc);
        #endregion

        #region OpenGL
        [DllImport("opengl32.dll")] private static extern IntPtr wglCreateContext(IntPtr hdc);

        [DllImport("opengl32.dll")] private static extern bool wglDeleteContext(IntPtr hglrc);

        [DllImport("opengl32.dll")] private static extern bool wglMakeCurrent(IntPtr hdc, IntPtr hglrc);

        [DllImport("dwmapi.dll")]
        private static extern void DwmFlush();


        public delegate bool del_wglSwapIntervalEXT(int interval);
        public del_wglSwapIntervalEXT _wglSwapIntervalEXT;

        private delegate IntPtr del_wglCreateContextAttribsARB(IntPtr hDC, IntPtr hshareContext, uint[] attribList);

        private del_wglCreateContextAttribsARB _wglCreateContextAttribsARB;

        private static Delegate GetPointer<T>(string name)
        {
            return Marshal.GetDelegateForFunctionPointer(GL.wglGetProcAddress(name), typeof(T));
        }

        #endregion

        private Graphics _graphics;
        private IntPtr _hdc;
        private IntPtr _context;

        private double _prevSecs = DateTime.Now.TimeOfDay.TotalSeconds;
        private float _aspect;
        private Texture _framebufferTexture;
        private Quad _quad;
        private bool _initialized;

        public int MouseX, MouseY;
        public float DeltaTime;

        public FramebufferForm()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        public void InitializeOpenGL(Size framebufferSize)
        {
            _initialized = true;
            _graphics = CreateGraphics();
            _hdc = _graphics.GetHdc();

            var pfd = new PIXELFORMATDESCRIPTOR
            {
                dwFlags = PFD_SUPPORT_OPENGL | PFD_DOUBLEBUFFER | PFD_DRAW_TO_WINDOW,
                cColorBits = 32,
                cDepthBits = 24,
                cStencilBits = 8
            };
            var pf = ChoosePixelFormat(_hdc, ref pfd);
            SetPixelFormat(_hdc, pf, ref pfd);
            var fakeContext = wglCreateContext(_hdc);
            if (!wglMakeCurrent(_hdc, fakeContext))
                throw new Exception("Failed to make fake context");

            _wglCreateContextAttribsARB =
                (del_wglCreateContextAttribsARB)GetPointer<del_wglCreateContextAttribsARB>(
                    "wglCreateContextAttribsARB");

            const uint WGL_CONTEXT_MAJOR_VERSION_ARB = 0x2091;
            const uint WGL_CONTEXT_MINOR_VERSION_ARB = 0x2092;
            const uint WGL_CONTEXT_PROFILE_MASK_ARB = 0x9126;
            const uint WGL_CONTEXT_CORE_PROFILE_BIT_ARB = 0x00000001;

            var options = new uint[]
            {
                WGL_CONTEXT_MAJOR_VERSION_ARB, 3,
                WGL_CONTEXT_MINOR_VERSION_ARB, 3,
                WGL_CONTEXT_PROFILE_MASK_ARB, WGL_CONTEXT_CORE_PROFILE_BIT_ARB,
                0
            };
            wglDeleteContext(fakeContext);

            _context = _wglCreateContextAttribsARB(_hdc, IntPtr.Zero, options);

            if (!wglMakeCurrent(_hdc, _context))
                throw new Exception("Failed to make GLES2 context");

            GL.LoadGLFuncs();

            _wglSwapIntervalEXT = (del_wglSwapIntervalEXT)GetPointer<del_wglSwapIntervalEXT>("wglSwapIntervalEXT");
            _wglSwapIntervalEXT(1); // 1 = vsync on, 0 = vsync off

            _quad = new Quad();

            _aspect = framebufferSize.Width / (float)framebufferSize.Height;

            if (_framebufferTexture != null)
                _framebufferTexture.Dispose();
            _framebufferTexture = new Texture(framebufferSize.Width, framebufferSize.Height);
        }

        private static readonly bool[] KeysDown = new bool[256];
        private static readonly bool[] KeysDownPrevFrame = new bool[256];

        public static bool IsKeyDown(Keys key)
        {
            return KeysDown[(byte)key];
        }

        public static bool IsKeyHit(Keys key)
        {
            return KeysDown[(byte)key] && KeysDownPrevFrame[(byte)key] == false;
        }

        private void GLForm_KeyUp(object sender, KeyEventArgs e)
        {
            KeysDown[(byte)e.KeyCode] = false;
        }

        private void GLForm_KeyDown(object sender, KeyEventArgs e)
        {
            KeysDown[(byte)e.KeyCode] = true;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            ResizeViewport();
        }

        public void ResizeViewport()
        {
            if (!_initialized)
                return;

            var width = (float)ClientSize.Width;
            var height = width / _aspect;

            if (height > ClientSize.Height)
            {
                height = ClientSize.Height;
                width = height * _aspect;
            }

            //canvas_rect = new DOMRect((canvas.width - width) / 2, (canvas.height - height) / 2, width, height);
            var left = (ClientSize.Width - width) / 2.0f;
            var top = (ClientSize.Height - height) / 2.0f;
            GL.glViewport((int)left, (int)top, (int)width, (int)height);
        }

        public void UpdateFramebuffer(uint[] pixeldata)
        {
            _framebufferTexture.UploadPixels(pixeldata);
            _quad.Draw();
        }

        public void Flip()
        {
            //DwmFlush();
            SwapBuffers(_hdc);
            Array.Copy(KeysDown, KeysDownPrevFrame, KeysDownPrevFrame.Length);

            //if (!IsDisposed)
            //{
            //    var relativePoint = PointToClient(Cursor.Position);

            //    MouseX = (int)((relativePoint.X / (float)ClientSize.Width) * 320);
            //    MouseY = (int)((relativePoint.Y / (float)ClientSize.Height) * 200);

            //}
            var nowSecs = DateTime.Now.TimeOfDay.TotalSeconds;
            DeltaTime = (float)(nowSecs - _prevSecs);
            _prevSecs = nowSecs;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            wglDeleteContext(_context);
            _graphics.ReleaseHdc(_hdc);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_initialized)
                return;

            e.Graphics.FillRectangle(Brushes.Black, e.ClipRectangle);
        }
    }
}