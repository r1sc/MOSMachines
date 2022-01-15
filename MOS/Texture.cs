using static MOS.OpenGL.GL;

namespace MOS.OpenGL
{
    internal class Texture
    {
        private readonly uint _texture;

        public Texture(int width, int height)
        {
            Width = width;
            Height = height;

            var textures = new uint[1];
            glGenTextures(1, textures);
            _texture = textures[0];

            glBindTexture(TextureTarget.GL_TEXTURE_2D, _texture);
            glTexParameteri(TextureTarget.GL_TEXTURE_2D, TextureParameterName.GL_TEXTURE_WRAP_S, (int)TextureWrapMode.GL_CLAMP_TO_EDGE);
            glTexParameteri(TextureTarget.GL_TEXTURE_2D, TextureParameterName.GL_TEXTURE_WRAP_T, (int)TextureWrapMode.GL_CLAMP_TO_EDGE);
            glTexParameteri(TextureTarget.GL_TEXTURE_2D, TextureParameterName.GL_TEXTURE_MIN_FILTER, (int)TextureMinFilter.GL_NEAREST);
            glTexParameteri(TextureTarget.GL_TEXTURE_2D, TextureParameterName.GL_TEXTURE_MAG_FILTER, (int)TextureMagFilter.GL_LINEAR);
            glTexImage2D(TextureTarget.GL_TEXTURE_2D, 0, InternalFormat.GL_RGBA, width, height, 0, PixelFormat.GL_RGBA, PixelType.GL_UNSIGNED_INT_8_8_8_8, null);
        }

        public int Width { get; }
        public int Height { get; }

        public void UploadPixels(uint[] pixels)
        {
            glBindTexture(TextureTarget.GL_TEXTURE_2D, _texture);
            glTexSubImage2D(TextureTarget.GL_TEXTURE_2D, 0, 0, 0, Width, Height, PixelFormat.GL_RGBA, PixelType.GL_UNSIGNED_INT_8_8_8_8, pixels);
        }
    }
}