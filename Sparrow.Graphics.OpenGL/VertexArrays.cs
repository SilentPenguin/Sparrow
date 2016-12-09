using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glVertexPointer")]
    public static extern unsafe GLvoid VertexPointer(GLint size, GLenum type, GLsizei stride, GLvoid* pointer);
    [DllImport(DllName, EntryPoint = "glNormalPointer")]
    public static extern unsafe GLvoid NormalPointer(GLenum type, GLsizei stride, GLvoid* pointer);
    [DllImport(DllName, EntryPoint = "glColorPointer")]
    public static extern unsafe GLvoid ColorPointer(GLint size, GLenum type, GLsizei stride, GLvoid* pointer);
    [DllImport(DllName, EntryPoint = "glIndexPointer")]
    public static extern unsafe GLvoid IndexPointer(GLenum type, GLsizei stride, GLvoid* pointer);
    [DllImport(DllName, EntryPoint = "glEdgeFlagPointer")]
    public static extern unsafe GLvoid EdgeFlagPointer(GLsizei stride, GLvoid* pointer);
    [DllImport(DllName, EntryPoint = "glFogCoordPointer")]
    public static extern unsafe GLvoid FogCoordPointer(GLenum type, GLsizei stride, GLvoid* pointer);
    [DllImport(DllName, EntryPoint = "glVertexAttribPointer")]
    public static extern unsafe GLvoid VertexAttribPointer(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, GLvoid* pointer);
    [DllImport(DllName, EntryPoint = "glVertexAttribIPointer")]
    public static extern unsafe GLvoid VertexAttribIPointer(GLuint index, GLint size, GLenum type, GLsizei stride, GLvoid* pointer);
    [DllImport(DllName, EntryPoint = "glEnableClientState")]
    public static extern unsafe GLvoid EnableClientState(GLenum array);
    [DllImport(DllName, EntryPoint = "glDisableClientState")]
    public static extern unsafe GLvoid DisableClientState(GLenum array);
    [DllImport(DllName, EntryPoint = "glEnableVertexAttribArray")]
    public static extern unsafe GLvoid EnableVertexAttribArray(GLuint index);
    [DllImport(DllName, EntryPoint = "glDisableVertexAttribArray")]
    public static extern unsafe GLvoid DisableVertexAttribArray(GLuint index);
    [DllImport(DllName, EntryPoint = "glClientActiveTexture")]
    public static extern unsafe GLvoid ClientActiveTexture(GLenum texture);
    [DllImport(DllName, EntryPoint = "glArrayElement")]
    public static extern unsafe GLvoid ArrayElement(GLint i);
    [DllImport(DllName, EntryPoint = "glDrawArrays")]
    public static extern unsafe GLvoid DrawArrays(GLenum mode, GLint first, GLsizei count);
    [DllImport(DllName, EntryPoint = "glMultiDrawArrays")]
    public static extern unsafe GLvoid MultiDrawArrays(GLenum mode, GLint* first, GLsizei* count, GLsizei drawcount);
    [DllImport(DllName, EntryPoint = "glDrawElements")]
    public static extern unsafe GLvoid DrawElements(GLenum mode, GLsizei count, GLenum type, GLvoid* indices);
    [DllImport(DllName, EntryPoint = "glMultiDrawElements")]
    public static extern unsafe GLvoid MultiDrawElements(GLenum mode, GLsizei* count, GLenum type, GLvoid** indices, GLsizei drawcount);
    [DllImport(DllName, EntryPoint = "glDrawRangeElements")]
    public static extern unsafe GLvoid DrawRangeElements(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, GLvoid* indices);
    [DllImport(DllName, EntryPoint = "glDrawArraysInstanced")]
    public static extern unsafe GLvoid DrawArraysInstanced(GLenum mode, GLint first, GLsizei count, GLsizei instancecount);
    [DllImport(DllName, EntryPoint = "glDrawElementsInstanced")]
    public static extern unsafe GLvoid DrawElementsInstanced(GLenum mode, GLsizei count, GLenum type, GLvoid* indices, GLsizei instancecount);
    [DllImport(DllName, EntryPoint = "glDrawElementsBaseVertex")]
    public static extern unsafe GLvoid DrawElementsBaseVertex(GLenum mode, GLsizei count, GLenum type, GLvoid* indices, GLint basevertex);
    [DllImport(DllName, EntryPoint = "glDrawRangeElementsBaseVertex")]
    public static extern unsafe GLvoid DrawRangeElementsBaseVertex(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, GLvoid* indices, GLint basevertex);
    [DllImport(DllName, EntryPoint = "glDrawElementsInstancedBaseVertex")]
    public static extern unsafe GLvoid DrawElementsInstancedBaseVertex(GLenum mode, GLsizei count, GLenum type, GLvoid* indices, GLsizei instancecount, GLint basevertex);
    [DllImport(DllName, EntryPoint = "glMultiDrawElementsBaseVertex")]
    public static extern unsafe GLvoid MultiDrawElementsBaseVertex(GLenum mode, GLsizei* count, GLenum type, GLvoid** indices, GLsizei drawcount, GLint* basevertex);
    [DllImport(DllName, EntryPoint = "glInterleavedArrays")]
    public static extern unsafe GLvoid InterleavedArrays(GLenum format, GLsizei stride, GLvoid* pointer);
}