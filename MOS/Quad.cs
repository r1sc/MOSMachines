using static MOS.OpenGL.GL;

namespace MOS.OpenGL;

internal class Quad : IDisposable
{
    private readonly uint _vao;
    private readonly uint _vertexbuffer;
    private static readonly float[] points = new float[]{
            -1,  1,     0, 0,
            -1, -1,     0, 1,
            1, 1,       1, 0,
            1, -1,      1, 1
        };

    public bool IsDisposed { get; private set; }

    public Quad()
    {
        var vaos = new uint[1];
        glGenVertexArrays(1, vaos);
        _vao = vaos[0];
        glBindVertexArray(_vao);
        glEnableVertexAttribArray(0);
        glEnableVertexAttribArray(1);

        var genVertexbuffer = new uint[1];
        glGenBuffers(1, genVertexbuffer);
        _vertexbuffer = genVertexbuffer[0];
        glBindBuffer(BufferTargetARB.GL_ARRAY_BUFFER, _vertexbuffer);
        glBufferData(
            BufferTargetARB.GL_ARRAY_BUFFER,
            16 * 4,
            points,
            BufferUsageARB.GL_STATIC_DRAW);

        glVertexAttribPointer(0, 2, VertexAttribPointerType.GL_FLOAT, GL.Boolean.GL_FALSE, sizeof(float) * 4, 0);
        glVertexAttribPointer(1, 2, VertexAttribPointerType.GL_FLOAT, GL.Boolean.GL_FALSE, sizeof(float) * 4, 8);
    }

    public void Draw()
    {
        glBindVertexArray(_vao);
        glDrawArrays(PrimitiveType.GL_TRIANGLE_STRIP, 0, 4);
    }

    public void Dispose()
    {
        if (IsDisposed)
            return;

        IsDisposed = true;
        glDeleteVertexArrays(1, new[] { _vao });
        glDeleteBuffers(1, new[] { _vertexbuffer });
    }
}
