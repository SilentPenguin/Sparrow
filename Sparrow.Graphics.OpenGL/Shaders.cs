using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glCreateShader")]
    public static extern unsafe void CreateShader(uint type);
    [DllImport(DllName, EntryPoint = "glShaderSource")]
    public static extern unsafe void ShaderSource(uint shader, int count, char** @string, int* length);
    [DllImport(DllName, EntryPoint = "glCompileShader")]
    public static extern unsafe void CompileShader(uint shader);
    [DllImport(DllName, EntryPoint = "glDeleteShader")]
    public static extern unsafe void DeleteShader(uint shader);
    [DllImport(DllName, EntryPoint = "glCreateProgram")]
    public static extern unsafe void CreateProgram();
    [DllImport(DllName, EntryPoint = "glAttachShader")]
    public static extern unsafe void AttachShader(uint program, uint shader);
    [DllImport(DllName, EntryPoint = "glDetachShader")]
    public static extern unsafe void DetachShader(uint program, uint shader);
    [DllImport(DllName, EntryPoint = "glLinkProgram")]
    public static extern unsafe void LinkProgram(uint program);
    [DllImport(DllName, EntryPoint = "glUseProgram")]
    public static extern unsafe void UseProgram(uint program);
    [DllImport(DllName, EntryPoint = "glDeleteProgram")]
    public static extern unsafe void DeleteProgram(uint program);
    [DllImport(DllName, EntryPoint = "glGetActiveAttrib")]
    public static extern unsafe void GetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
    [DllImport(DllName, EntryPoint = "glGetAttribLocation")]
    public static extern unsafe void GetAttribLocation(uint program, char* name);
    [DllImport(DllName, EntryPoint = "glBindAttribLocation")]
    public static extern unsafe void BindAttribLocation(uint program, uint index, char* name);
    [DllImport(DllName, EntryPoint = "glGetUniformLocation")]
    public static extern unsafe void GetUniformLocation(uint program, char* name);
    [DllImport(DllName, EntryPoint = "glGetUniformBlockIndex")]
    public static extern unsafe void GetUniformBlockIndex(uint program, char* uniformBlockName);
    [DllImport(DllName, EntryPoint = "glGetActiveUniformBlockiv")]
    public static extern unsafe void GetActiveUniformBlock(uint program, uint uniformBlockIndex, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glGetActiveUniformName")]
    public static extern unsafe void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, int* length, char* uniformName);
    [DllImport(DllName, EntryPoint = "glGetActiveUniformsiv")]
    public static extern unsafe void GetActiveUniforms(uint program, int uniformCount, uint* uniformIndices, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glUniform1f")]
    public static extern unsafe void Uniform1(int location, float v0);
    [DllImport(DllName, EntryPoint = "glUniform1fv")]
    public static extern unsafe void Uniform1(int location, int count, float* value);
    [DllImport(DllName, EntryPoint = "glUniform1i")]
    public static extern unsafe void Uniform1(int location, int v0);
    [DllImport(DllName, EntryPoint = "glUniform1iv")]
    public static extern unsafe void Uniform1(int location, int count, int* value);
    [DllImport(DllName, EntryPoint = "glUniform1ui")]
    public static extern unsafe void Uniform1(int location, uint v0);
    [DllImport(DllName, EntryPoint = "glUniform1uiv")]
    public static extern unsafe void Uniform1(int location, int count, uint* value);
    [DllImport(DllName, EntryPoint = "glUniform2f")]
    public static extern unsafe void Uniform2(int location, float v0, float v1);
    [DllImport(DllName, EntryPoint = "glUniform2fv")]
    public static extern unsafe void Uniform2(int location, int count, float* value);
    [DllImport(DllName, EntryPoint = "glUniform2i")]
    public static extern unsafe void Uniform2(int location, int v0, int v1);
    [DllImport(DllName, EntryPoint = "glUniform2iv")]
    public static extern unsafe void Uniform2(int location, int count, int* value);
    [DllImport(DllName, EntryPoint = "glUniform2ui")]
    public static extern unsafe void Uniform2(int location, uint v0, uint v1);
    [DllImport(DllName, EntryPoint = "glUniform2uiv")]
    public static extern unsafe void Uniform2(int location, int count, uint* value);
    [DllImport(DllName, EntryPoint = "glUniform3f")]
    public static extern unsafe void Uniform3(int location, float v0, float v1, float v2);
    [DllImport(DllName, EntryPoint = "glUniform3fv")]
    public static extern unsafe void Uniform3(int location, int count, float* value);
    [DllImport(DllName, EntryPoint = "glUniform3i")]
    public static extern unsafe void Uniform3(int location, int v0, int v1, int v2);
    [DllImport(DllName, EntryPoint = "glUniform3iv")]
    public static extern unsafe void Uniform3(int location, int count, int* value);
    [DllImport(DllName, EntryPoint = "glUniform3ui")]
    public static extern unsafe void Uniform3(int location, uint v0, uint v1, uint v2);
    [DllImport(DllName, EntryPoint = "glUniform3uiv")]
    public static extern unsafe void Uniform3(int location, int count, uint* value);
    [DllImport(DllName, EntryPoint = "glUniform4f")]
    public static extern unsafe void Uniform4(int location, float v0, float v1, float v2, float v3);
    [DllImport(DllName, EntryPoint = "glUniform4fv")]
    public static extern unsafe void Uniform4(int location, int count, float* value);
    [DllImport(DllName, EntryPoint = "glUniform4i")]
    public static extern unsafe void Uniform4(int location, int v0, int v1, int v2, int v3);
    [DllImport(DllName, EntryPoint = "glUniform4iv")]
    public static extern unsafe void Uniform4(int location, int count, int* value);
    [DllImport(DllName, EntryPoint = "glUniform4ui")]
    public static extern unsafe void Uniform4(int location, uint v0, uint v1, uint v2, uint v3);
    [DllImport(DllName, EntryPoint = "glUniform4uiv")]
    public static extern unsafe void Uniform4(int location, int count, uint* value);
    [DllImport(DllName, EntryPoint = "glUniformMatrix2fv")]
    public static extern unsafe void UniformMatrix2(int location, int count, bool transpose, float* value);
    [DllImport(DllName, EntryPoint = "glUniformMatrix3fv")]
    public static extern unsafe void UniformMatrix3(int location, int count, bool transpose, float* value);
    [DllImport(DllName, EntryPoint = "glUniformMatrix4fv")]
    public static extern unsafe void UniformMatrix4(int location, int count, bool transpose, float* value);
    [DllImport(DllName, EntryPoint = "glUniformBlockBinding")]
    public static extern unsafe void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
    [DllImport(DllName, EntryPoint = "glTransformFeedbackVaryings")]
    public static extern unsafe void TransformFeedbackVaryings(uint program, int count, char** varyings, uint bufferMode);
    [DllImport(DllName, EntryPoint = "glGetTransformFeedbackVarying")]
    public static extern unsafe void GetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
    [DllImport(DllName, EntryPoint = "glValidateProgram")]
    public static extern unsafe void ValidateProgram(uint program);
    [DllImport(DllName, EntryPoint = "glGetProgramiv")]
    public static extern unsafe void GetProgram(uint program, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glBindFragDataLocation")]
    public static extern unsafe void BindFragDataLocation(uint program, uint color, char* name);
    [DllImport(DllName, EntryPoint = "glGetFragDataLocation")]
    public static extern unsafe void GetFragDataLocation(uint program, char* name);
    [DllImport(DllName, EntryPoint = "glIsShader")]
    public static extern unsafe void IsShader(uint shader);
    [DllImport(DllName, EntryPoint = "glGetShaderiv")]
    public static extern unsafe void GetShader(uint shader, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glGetAttachedShaders")]
    public static extern unsafe void GetAttachedShaders(uint program, int maxCount, int* count, uint* shaders);
    [DllImport(DllName, EntryPoint = "glGetShaderInfoLog")]
    public static extern unsafe void GetShaderInfoLog(uint shader, int bufSize, int* length, char* infoLog);
    [DllImport(DllName, EntryPoint = "glGetShaderSource")]
    public static extern unsafe void GetShaderSource(uint shader, int bufSize, int* length, char* source);
    [DllImport(DllName, EntryPoint = "glGetVertexAttribPointerv")]
    public static extern unsafe void GetVertexAttribPointer(uint index, uint pname, void** pointer);
    [DllImport(DllName, EntryPoint = "glGetUniformfv")]
    public static extern unsafe void GetUniform(uint program, int location, float* @params);
    [DllImport(DllName, EntryPoint = "glGetUniformiv")]
    public static extern unsafe void GetUniform(uint program, int location, int* @params);
    [DllImport(DllName, EntryPoint = "glGetUniformuiv")]
    public static extern unsafe void GetUniform(uint program, int location, uint* @params);
    [DllImport(DllName, EntryPoint = "glIsProgram")]
    public static extern unsafe void IsProgram(uint program);
    [DllImport(DllName, EntryPoint = "glGetProgramiv")]
    public static extern unsafe void GetProgram(uint program, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glGetProgramInfoLog")]
    public static extern unsafe void GetProgramInfoLog(uint program, int bufSize, int* length, char* infoLog);
}