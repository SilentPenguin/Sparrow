using System.Runtime.InteropServices;
using System;
using System.Linq;
using System.IO;

namespace Sparrow.Graphics.OpenGL
{
    public partial class Gl
    {
        public static unsafe void BindBuffer(uint target, uint buffer) { Raw.glBindBuffer(target, buffer); }

        public static void BufferData(uint target, byte[] data, uint usage) { BufferData(target, data.Length, data, usage); }
        public static unsafe void BufferData(uint target, int size, byte[] data, uint usage) { fixed(void* p = data) Raw.glBufferData(target, &size, p, usage); }
        public static void BufferData<T>(uint target, T[] data, uint usage) where T : struct { BufferData<T>(target, data.Length, data, usage); }
        public static unsafe void BufferData<T>(uint target, int size, T[] data, uint usage) where T : struct
        {
            var marshalSize = Marshal.SizeOf<T>();
            var ptr = Marshal.AllocHGlobal(size * marshalSize);

            for (int i = 0; i < size; i++)
                Marshal.StructureToPtr(data[i], ptr + i * marshalSize, true);

            size *= marshalSize;
            
            Raw.glBufferData(target, &size, ptr.ToPointer(), usage);
            Marshal.FreeHGlobal(ptr);
        }

        public static unsafe void CreateBuffers(int n, uint[] buffers) { fixed(uint* p = buffers) Raw.glCreateBuffers(n, p); }

        public static unsafe void GenBuffers(int n, uint[] buffers) { fixed(uint* p = buffers) Raw.glGenBuffers(n, p); }

        public static unsafe void GetUniform(uint program, int location, float[] v) { fixed(float* p = v) Raw.glGetUniformfv(program, location, p); }
        public static unsafe void GetUniform(uint program, int location, double[] v) { fixed(double* p = v) Raw.glGetUniformdv(program, location, p); }
        public static unsafe void GetUniform(uint program, int location, int[] v) { fixed(int* p = v) Raw.glGetUniformiv(program, location, p); }
        public static unsafe void GetUniform(uint program, int location, uint[] v) { fixed(uint* p = &v[0]) Raw.glGetUniformuiv(program, location, p); }
        public static unsafe void GetUniform(uint program, int location, int count, float[] v) { fixed(float* p = &v[0]) Raw.glGetnUniformfv(program, location, count, p); }
        public static unsafe void GetUniform(uint program, int location, int count, double[] v) { fixed(double* p = &v[0]) Raw.glGetnUniformdv(program, location, count, p); }
        public static unsafe void GetUniform(uint program, int location, int count, int[] v) { fixed(int* p = &v[0]) Raw.glGetnUniformiv(program, location, count, p); }
        public static unsafe void GetUniform(uint program, int location, int count, uint[] v) { fixed(uint* p = &v[0]) Raw.glGetnUniformuiv(program, location, count, p); }

        public static void Uniform1(int location, float v0) { Raw.glUniform1f(location, v0); }
        public static void Uniform1(int location, double v0) { Raw.glUniform1d(location, v0); }
        public static void Uniform1(int location, int v0) { Raw.glUniform1i(location, v0); }
        public static void Uniform1(int location, uint v0) { Raw.glUniform1ui(location, v0); }
        public static void Uniform2(int location, float v0, float v1) { Raw.glUniform2f(location, v0, v1); }
        public static void Uniform2(int location, double v0, double v1) { Raw.glUniform2d(location, v0, v1); }
        public static void Uniform2(int location, int v0, int v1) { Raw.glUniform2i(location, v0, v1); }
        public static void Uniform2(int location, uint v0, uint v1) { Raw.glUniform2ui(location, v0, v1); }
        public static void Uniform3(int location, float v0, float v1, float v2) { Raw.glUniform3f(location, v0, v1, v2); }
        public static void Uniform3(int location, double v0, double v1, double v2) { Raw.glUniform3d(location, v0, v1, v2); }
        public static void Uniform3(int location, int v0, int v1, int v2) { Raw.glUniform3i(location, v0, v1, v2); }
        public static void Uniform3(int location, uint v0, uint v1, uint v2) { Raw.glUniform3ui(location, v0, v1, v2); }
        public static void Uniform4(int location, float v0, float v1, float v2, float v3) { Raw.glUniform4f(location, v0, v1, v2, v3); }
        public static void Uniform4(int location, double v0, double v1, double v2, double v3) { Raw.glUniform4d(location, v0, v1, v2, v3); }
        public static void Uniform4(int location, int v0, int v1, int v2, int v3) { Raw.glUniform4i(location, v0, v1, v2, v3); }
        public static void Uniform4(int location, uint v0, uint v1, uint v2, uint v3) { Raw.glUniform4ui(location, v0, v1, v2, v3); }
        public static unsafe void Uniform1(int location, int count, float[] v) { fixed(float* p = &v[0]) Raw.glUniform1fv(location, count, p); }
        public static unsafe void Uniform1(int location, int count, double[] v) { fixed(double* p = &v[0]) Raw.glUniform1dv(location, count, p); }
        public static unsafe void Uniform1(int location, int count, int[] v) { fixed(int* p = &v[0]) Raw.glUniform1iv(location, count, p); }
        public static unsafe void Uniform1(int location, int count, uint[] v) { fixed(uint* p = &v[0]) Raw.glUniform1uiv(location, count, p); }
        public static unsafe void Uniform2(int location, int count, float[] v) { fixed(float* p = &v[0]) Raw.glUniform2fv(location, count, p); }
        public static unsafe void Uniform2(int location, int count, double[] v) { fixed(double* p = &v[0]) Raw.glUniform2dv(location, count, p); }
        public static unsafe void Uniform2(int location, int count, int[] v) { fixed(int* p = &v[0]) Raw.glUniform2iv(location, count, p); }
        public static unsafe void Uniform2(int location, int count, uint[] v) { fixed(uint* p = &v[0]) Raw.glUniform2uiv(location, count, p); }
        public static unsafe void Uniform3(int location, int count, float[] v) { fixed(float* p = &v[0]) Raw.glUniform3fv(location, count, p); }
        public static unsafe void Uniform3(int location, int count, double[] v) { fixed(double* p = &v[0]) Raw.glUniform3dv(location, count, p); }
        public static unsafe void Uniform3(int location, int count, int[] v) { fixed(int* p = &v[0]) Raw.glUniform3iv(location, count, p); }
        public static unsafe void Uniform3(int location, int count, uint[] v) { fixed(uint* p = &v[0]) Raw.glUniform3uiv(location, count, p); }
        public static unsafe void Uniform4(int location, int count, float[] v) { fixed(float* p = &v[0]) Raw.glUniform4fv(location, count, p); }
        public static unsafe void Uniform4(int location, int count, double[] v) { fixed(double* p = &v[0]) Raw.glUniform4dv(location, count, p); }
        public static unsafe void Uniform4(int location, int count, int[] v) { fixed(int* p = &v[0]) Raw.glUniform4iv(location, count, p); }
        public static unsafe void Uniform4(int location, int count, uint[] v) { fixed(uint* p = &v[0]) Raw.glUniform4uiv(location, count, p); }
        public static unsafe void UniformMatrix2(int location, int count, bool transpose, float[] v) { fixed(float* p = &v[0]) Raw.glUniformMatrix2fv(location, count, transpose, p); }
        public static unsafe void UniformMatrix3(int location, int count, bool transpose, float[] v) { fixed(float* p = &v[0]) Raw.glUniformMatrix3fv(location, count, transpose, p); }
        public static unsafe void UniformMatrix4(int location, int count, bool transpose, float[] v) { fixed(float* p = &v[0]) Raw.glUniformMatrix4fv(location, count, transpose, p); }
        public static unsafe void UniformMatrix2x3(int location, int count, bool transpose, float[] v) { fixed(float* p = &v[0]) Raw.glUniformMatrix2x3fv(location, count, transpose, p); }
        public static unsafe void UniformMatrix3x2(int location, int count, bool transpose, float[] v) { fixed(float* p = &v[0]) Raw.glUniformMatrix3x2fv(location, count, transpose, p); }
        public static unsafe void UniformMatrix2x4(int location, int count, bool transpose, float[] v) { fixed(float* p = &v[0]) Raw.glUniformMatrix2x4fv(location, count, transpose, p); }
        public static unsafe void UniformMatrix4x2(int location, int count, bool transpose, float[] v) { fixed(float* p = &v[0]) Raw.glUniformMatrix4x2fv(location, count, transpose, p); }
        public static unsafe void UniformMatrix3x4(int location, int count, bool transpose, float[] v) { fixed(float* p = &v[0]) Raw.glUniformMatrix3x4fv(location, count, transpose, p); }
        public static unsafe void UniformMatrix4x3(int location, int count, bool transpose, float[] v) { fixed(float* p = &v[0]) Raw.glUniformMatrix4x3fv(location, count, transpose, p); }
        public static void Uniform(int location, float v0) { Uniform1(location, v0); }
        public static void Uniform(int location, double v0) { Uniform1(location, v0); }
        public static void Uniform(int location, int v0) { Uniform1(location, v0); }
        public static void Uniform(int location, uint v0) { Uniform1(location, v0); }
        public static void Uniform(int location, float v0, float v1) { Uniform2(location, v0, v1); }
        public static void Uniform(int location, double v0, double v1) { Uniform2(location, v0, v1); }
        public static void Uniform(int location, float v0, float v1, float v2) { Uniform3(location, v0, v1, v2); }
        public static void Uniform(int location, float v0, float v1, float v2, float v3) { Uniform4(location, v0, v1, v2, v3); }
        public static void Uniform(int location, double v0, double v1, double v2) { Uniform3(location, v0, v1, v2); }
        public static void Uniform(int location, double v0, double v1, double v2, double v3) { Uniform4(location, v0, v1, v2, v3); }
        public static void Uniform(int location, int v0, int v1, int v2) { Uniform3(location, v0, v1, v2); }
        public static void Uniform(int location, int v0, int v1, int v2, int v3) { Uniform4(location, v0, v1, v2, v3); }
        public static void Uniform(int location, uint v0, uint v1) { Uniform2(location, v0, v1); }
        public static void Uniform(int location, uint v0, uint v1, uint v2) { Uniform3(location, v0, v1, v2); }
        public static void Uniform(int location, uint v0, uint v1, uint v2, uint v3) { Uniform4(location, v0, v1, v2, v3); }
        public static void Uniform(int location, float[] v) { Uniform(location, v.Length, v); }
        public static void Uniform(int location, double[] v) { Uniform(location, v.Length, v); }
        public static void Uniform(int location, int[] v) { Uniform(location, v.Length, v); }
        public static void Uniform(int location, uint[] v) { Uniform(location, v.Length, v); }
        public static void UniformMatrix(int location, float[,] v) { UniformMatrix(location, v.Length, v); }
        public static void Uniform(int location, int count, float[] v)
        {
            if (count == 1) Uniform1(location, count, v);
            else if (count == 2) Uniform2(location, count, v);
            else if (count == 3) Uniform3(location, count, v);
            else if (count == 4) Uniform4(location, count, v);
        }
        public static void Uniform(int location, int count, double[] v)
        {
            if (count == 1) Uniform1(location, count, v);
            else if (count == 2) Uniform2(location, count, v);
            else if (count == 3) Uniform3(location, count, v);
            else if (count == 4) Uniform4(location, count, v);
        }
        public static void Uniform(int location, int count, int[] v)
        {
            if (count == 1) Uniform1(location, count, v);
            else if (count == 2) Uniform2(location, count, v);
            else if (count == 3) Uniform3(location, count, v);
            else if (count == 4) Uniform4(location, count, v);
        }
        public static void Uniform(int location, int count, uint[] v)
        {
            if (count == 1) Uniform1(location, count, v);
            else if (count == 2) Uniform2(location, count, v);
            else if (count == 3) Uniform3(location, count, v);
            else if (count == 4) Uniform4(location, count, v);
        }
        public static void UniformMatrix(int location, int count, float[,] v)
        {
            var x = v.GetLength(0);
            var y = v.GetLength(1);
            var a = v.Cast<float>().ToArray();
            if (x == 2)
            {
                if (y == 2) UniformMatrix2(location, count, false, a);
                else if (y == 3) UniformMatrix2x3(location, count, false, a);
                else if (y == 4) UniformMatrix2x4(location, count, false, a);
            }
            else if (x == 3)
            {
                if (y == 2) UniformMatrix3x2(location, count, false, a);
                else if (y == 3) UniformMatrix3(location, count, false, a);
                else if (y == 4) UniformMatrix3x4(location, count, false, a);
            }
            else if (x == 4)
            {
                if (y == 2) UniformMatrix4x2(location, count, false, a);
                else if (y == 3) UniformMatrix4x3(location, count, false, a);
                else if (y == 4) UniformMatrix4(location, count, false, a);
            }
        }
    }
}