using cs64;
using MOS.OpenGL;
using static MOS.OpenGL.GL;

FramebufferForm form = new FramebufferForm(new Size(340, 220))
{
    Text = "cs64"
};

glViewport(0, 0, form.ClientSize.Width, form.ClientSize.Height);

var shader = new Shader(File.ReadAllText(@"Shaders\output.glsl"));
shader.Use();
shader.SetUniformDirect("bending_factor", 0.2f);
shader.SetUniformDirect("num_lines", 220);

var c64 = new C64();

while (!form.IsDisposed)
{
    c64.RunFrame();

    form.UpdateFramebuffer(c64.VideoBuffer);
    form.Flip();
}