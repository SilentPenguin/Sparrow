using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid CreateShader(GLenum type);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ShaderSource(GLuint shader, GLsizei count, GLchar** @string, GLint* length);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CompileShader(GLuint shader);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DeleteShader(GLuint shader);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CreateProgram();
    [DllImport(DllName)]
    public static extern unsafe GLvoid AttachShader(GLuint program, GLuint shader);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DetachShader(GLuint program, GLuint shader);
    [DllImport(DllName)]
    public static extern unsafe GLvoid LinkProgram(GLuint program);
    [DllImport(DllName)]
    public static extern unsafe GLvoid UseProgram(GLuint program);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DeleteProgram(GLuint program);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetActiveAttrib(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, GLchar* name);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetAttribLocation(GLuint program, GLchar* name);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BindAttribLocation(GLuint program, GLuint index, GLchar* name);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetUniformLocation(GLuint program, GLchar* name);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetUniformBlockIndex(GLuint program, GLchar* uniformBlockName);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetActiveUniformBlock(GLuint program, GLuint uniformBlockIndex, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetActiveUniformName(GLuint program, GLuint uniformIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformName);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetActiveUniforms(GLuint program, GLsizei uniformCount, GLuint* uniformIndices, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform1(GLint location, GLfloat v0);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform1(GLint location, GLsizei count, GLfloat* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform1(GLint location, GLint v0);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform1(GLint location, GLsizei count, GLint* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform1(GLint location, GLuint v0);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform1(GLint location, GLsizei count, GLuint* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform2(GLint location, GLfloat v0, GLfloat v1);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform2(GLint location, GLsizei count, GLfloat* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform2(GLint location, GLint v0, GLint v1);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform2(GLint location, GLsizei count, GLint* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform2(GLint location, GLuint v0, GLuint v1);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform2(GLint location, GLsizei count, GLuint* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform3(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform3(GLint location, GLsizei count, GLfloat* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform3(GLint location, GLint v0, GLint v1, GLint v2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform3(GLint location, GLsizei count, GLint* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform3(GLint location, GLuint v0, GLuint v1, GLuint v2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform3(GLint location, GLsizei count, GLuint* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform4(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform4(GLint location, GLsizei count, GLfloat* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform4(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform4(GLint location, GLsizei count, GLint* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform4(GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Uniform4(GLint location, GLsizei count, GLuint* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid UniformMatrix2(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid UniformMatrix3(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid UniformMatrix4(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid UniformBlockBinding(GLuint program, GLuint uniformBlockIndex, GLuint uniformBlockBinding);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TransformFeedbackVaryings(GLuint program, GLsizei count, GLchar** varyings, GLenum bufferMode);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetTransformFeedbackVarying(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ValidateProgram(GLuint program);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetProgram(GLuint program, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BindFragDataLocation(GLuint program, GLuint color, GLchar* name);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetFragDataLocation(GLuint program, GLchar* name);
    [DllImport(DllName)]
    public static extern unsafe GLvoid IsShader(GLuint shader);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetShader(GLuint shader, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetAttachedShaders(GLuint program, GLsizei maxCount, GLsizei* count, GLuint* shaders);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetShaderInfoLog(GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* infoLog);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetShaderSource(GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* source);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetVertexAttribPointer(GLuint index, GLenum pname, GLvoid** pointer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetUniform(GLuint program, GLint location, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetUniform(GLuint program, GLint location, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetUniform(GLuint program, GLint location, GLuint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid IsProgram(GLuint program);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetProgram(GLuint program, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetProgramInfoLog(GLuint program, GLsizei bufSize, GLsizei* length, GLchar* infoLog);
}