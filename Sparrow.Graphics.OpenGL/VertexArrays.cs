using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexPointer(GLint size, GLenum type, GLsizei stride, GLvoid* pointer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid NormalPointer(GLenum type, GLsizei stride, GLvoid* pointer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ColorPointer(GLint size, GLenum type, GLsizei stride, GLvoid* pointer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid IndexPointer(GLenum type, GLsizei stride, GLvoid* pointer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EdgeFlagPointer(GLsizei stride, GLvoid* pointer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid FogCoordPointer(GLenum type, GLsizei stride, GLvoid* pointer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttribPointer(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, GLvoid* pointer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttribIPointer(GLuint index, GLint size, GLenum type, GLsizei stride, GLvoid* pointer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EnableClientState(GLenum array);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DisableClientState(GLenum array);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EnableVertexAttribArray(GLuint index);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DisableVertexAttribArray(GLuint index);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ClientActiveTexture(GLenum texture);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ArrayElement(GLint i);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DrawArrays(GLenum mode, GLint first, GLsizei count);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiDrawArrays(GLenum mode, GLint* first, GLsizei* count, GLsizei drawcount);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DrawElements(GLenum mode, GLsizei count, GLenum type, GLvoid* indices);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiDrawElements(GLenum mode, GLsizei* count, GLenum type, GLvoid** indices, GLsizei drawcount);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DrawRangeElements(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, GLvoid* indices);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DrawArraysInstanced(GLenum mode, GLint first, GLsizei count, GLsizei instancecount);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DrawElementsInstanced(GLenum mode, GLsizei count, GLenum type, GLvoid* indices, GLsizei instancecount);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DrawElementsBaseVertex(GLenum mode, GLsizei count, GLenum type, GLvoid* indices, GLint basevertex);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DrawRangeElementsBaseVertex(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, GLvoid* indices, GLint basevertex);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DrawElementsInstancedBaseVertex(GLenum mode, GLsizei count, GLenum type, GLvoid* indices, GLsizei instancecount, GLint basevertex);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiDrawElementsBaseVertex(GLenum mode, GLsizei* count, GLenum type, GLvoid** indices, GLsizei drawcount, GLint* basevertex);
    [DllImport(DllName)]
    public static extern unsafe GLvoid InterleavedArrays(GLenum format, GLsizei stride, GLvoid* pointer);
}