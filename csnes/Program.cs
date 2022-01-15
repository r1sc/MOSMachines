using MOS.OpenGL;
using static MOS.OpenGL.GL;

FramebufferForm form = new FramebufferForm(new System.Drawing.Size(256, 256))
{
    Text = "csnes"
};

glViewport(0, 0, form.ClientSize.Width, form.ClientSize.Height);

var shader = new Shader(File.ReadAllText(@"Shaders\output.glsl"));
shader.Use();
shader.SetUniformDirect("bending_factor", 0f);
shader.SetUniformDirect("num_lines", 220);

while (!form.IsDisposed)
{
    // run frame

    //form.UpdateFramebuffer(c64.VideoBuffer);
    form.Flip();
}