using cs64;
using MOS.OpenGL;
using static MOS.OpenGL.GL;

FramebufferForm framebuffer = new()
{
    Text = "cs64"
};
framebuffer.InitializeOpenGL(new Size(340, 220));

glViewport(0, 0, framebuffer.ClientSize.Width, framebuffer.ClientSize.Height);

var shader = new Shader(File.ReadAllText(@"Shaders\output.glsl"));
shader.Use();
shader.SetUniformDirect("bending_factor", 0.5f);
shader.SetUniformDirect("num_lines", 220);

var c64 = new C64();

framebuffer.Show();
framebuffer.ResizeViewport();

var targetDt = 1000.0 / 50.0;
var accumDt = 0.0;
var last_time = DateTime.Now;

while (!framebuffer.IsDisposed)
{
    var now = DateTime.Now;
    var deltaMs = (now - last_time).TotalMilliseconds;
    last_time = now;
    accumDt += deltaMs;

    var needRerender = accumDt >= targetDt;
    while (accumDt > targetDt)
    {
        c64.RunFrame();
        accumDt -= targetDt;
    }

    if (needRerender)
    {
        c64.DrawFrame();
        framebuffer.UpdateFramebuffer(c64.VideoBuffer);
        framebuffer.Flip();
    }

    Application.DoEvents();
    Thread.Sleep(1);
}