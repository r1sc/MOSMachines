using System.Text;
using static MOS.OpenGL.GL;

namespace MOS.OpenGL;
public class Shader
{
    private readonly uint _program;

    public Shader(string source)
    {
        _program = glCreateProgram();
        if (_program == 0)
            throw new Exception("Could not create shader program");

        var vertex_shader = LoadShader(ShaderType.GL_VERTEX_SHADER, source);
        var fragment_shader = LoadShader(ShaderType.GL_FRAGMENT_SHADER, source);

        glAttachShader(_program, vertex_shader);
        glAttachShader(_program, fragment_shader);
        glLinkProgram(_program);

        int[] compileStatus = new int[1];
        glGetProgramiv(_program, ProgramPropertyARB.GL_LINK_STATUS, compileStatus);
        if (compileStatus[0] == 0)
        {
            var infoLog = new StringBuilder(512);
            glGetProgramInfoLog(_program, 512, null, infoLog);
            glDeleteProgram(_program);
            throw new Exception("Shader error: " + infoLog.ToString());
        }

        glDeleteShader(vertex_shader);
        glDeleteShader(fragment_shader);
    }

    private uint LoadShader(ShaderType shaderType, string shaderSource)
    {
        var shader = glCreateShader(shaderType);
        if (shader == 0)
            throw new Exception("Could not create shader");

        string define = shaderType == ShaderType.GL_VERTEX_SHADER
            ? "#define VERTEX  \n"
            : "#define FRAGMENT\n";

        var shaderStrings = new[] { "#version 330 core\n", define, shaderSource };
        glShaderSource(shader, 3, shaderStrings, new[] {
                shaderStrings[0].Length,
                shaderStrings[1].Length,
                shaderStrings[2].Length
            });
        glCompileShader(shader);

        int[] compileStatus = new int[1];
        glGetShaderiv(shader, ShaderParameterName.GL_COMPILE_STATUS, compileStatus);

        if (compileStatus[0] == 0)
        {
            var infoLog = new StringBuilder(512);
            glGetShaderInfoLog(shader, infoLog.Capacity, null, infoLog);
            glDeleteShader(shader);
            throw new Exception("Shader error: " + infoLog.ToString());
        }

        return shader;
    }

    public void Use()
    {
        glUseProgram(_program);
    }

    public void SetUniformDirect(string name, float value)
    {
        var loc = glGetUniformLocation(_program, new StringBuilder(name));
        glUniform1f(loc, value);
    }
}
