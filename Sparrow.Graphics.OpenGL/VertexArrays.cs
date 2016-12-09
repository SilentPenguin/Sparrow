using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glVertexPointer")]
    public static extern unsafe void VertexPointer(int size, uint type, int stride, void* pointer);
    [DllImport(DllName, EntryPoint = "glNormalPointer")]
    public static extern unsafe void NormalPointer(uint type, int stride, void* pointer);
    [DllImport(DllName, EntryPoint = "glColorPointer")]
    public static extern unsafe void ColorPointer(int size, uint type, int stride, void* pointer);
    [DllImport(DllName, EntryPoint = "glIndexPointer")]
    public static extern unsafe void IndexPointer(uint type, int stride, void* pointer);
    [DllImport(DllName, EntryPoint = "glEdgeFlagPointer")]
    public static extern unsafe void EdgeFlagPointer(int stride, void* pointer);
    [DllImport(DllName, EntryPoint = "glFogCoordPointer")]
    public static extern unsafe void FogCoordPointer(uint type, int stride, void* pointer);
    [DllImport(DllName, EntryPoint = "glVertexAttribPointer")]
    public static extern unsafe void VertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, void* pointer);
    [DllImport(DllName, EntryPoint = "glVertexAttribIPointer")]
    public static extern unsafe void VertexAttribIPointer(uint index, int size, uint type, int stride, void* pointer);
    [DllImport(DllName, EntryPoint = "glEnableClientState")]
    public static extern unsafe void EnableClientState(uint array);
    [DllImport(DllName, EntryPoint = "glDisableClientState")]
    public static extern unsafe void DisableClientState(uint array);
    [DllImport(DllName, EntryPoint = "glEnableVertexAttribArray")]
    public static extern unsafe void EnableVertexAttribArray(uint index);
    [DllImport(DllName, EntryPoint = "glDisableVertexAttribArray")]
    public static extern unsafe void DisableVertexAttribArray(uint index);
    [DllImport(DllName, EntryPoint = "glClientActiveTexture")]
    public static extern unsafe void ClientActiveTexture(uint texture);
    [DllImport(DllName, EntryPoint = "glArrayElement")]
    public static extern unsafe void ArrayElement(int i);
    [DllImport(DllName, EntryPoint = "glDrawArrays")]
    public static extern unsafe void DrawArrays(uint mode, int first, int count);
    [DllImport(DllName, EntryPoint = "glMultiDrawArrays")]
    public static extern unsafe void MultiDrawArrays(uint mode, int* first, int* count, int drawcount);
    [DllImport(DllName, EntryPoint = "glDrawElements")]
    public static extern unsafe void DrawElements(uint mode, int count, uint type, void* indices);
    [DllImport(DllName, EntryPoint = "glMultiDrawElements")]
    public static extern unsafe void MultiDrawElements(uint mode, int* count, uint type, void** indices, int drawcount);
    [DllImport(DllName, EntryPoint = "glDrawRangeElements")]
    public static extern unsafe void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices);
    [DllImport(DllName, EntryPoint = "glDrawArraysInstanced")]
    public static extern unsafe void DrawArraysInstanced(uint mode, int first, int count, int instancecount);
    [DllImport(DllName, EntryPoint = "glDrawElementsInstanced")]
    public static extern unsafe void DrawElementsInstanced(uint mode, int count, uint type, void* indices, int instancecount);
    [DllImport(DllName, EntryPoint = "glDrawElementsBaseVertex")]
    public static extern unsafe void DrawElementsBaseVertex(uint mode, int count, uint type, void* indices, int basevertex);
    [DllImport(DllName, EntryPoint = "glDrawRangeElementsBaseVertex")]
    public static extern unsafe void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex);
    [DllImport(DllName, EntryPoint = "glDrawElementsInstancedBaseVertex")]
    public static extern unsafe void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, void* indices, int instancecount, int basevertex);
    [DllImport(DllName, EntryPoint = "glMultiDrawElementsBaseVertex")]
    public static extern unsafe void MultiDrawElementsBaseVertex(uint mode, int* count, uint type, void** indices, int drawcount, int* basevertex);
    [DllImport(DllName, EntryPoint = "glInterleavedArrays")]
    public static extern unsafe void InterleavedArrays(uint format, int stride, void* pointer);
}