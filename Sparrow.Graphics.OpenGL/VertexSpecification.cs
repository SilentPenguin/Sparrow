using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid Begin(GLenum mode);
    [DllImport(DllName)]
    public static extern unsafe GLvoid End();
    [DllImport(DllName)]
    public static extern unsafe GLvoid EdgeFlag(GLboolean flag);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EdgeFlag(GLboolean* flag);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex2(GLdouble x, GLdouble y);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex2(GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex2(GLfloat x, GLfloat y);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex2(GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex2(GLint x, GLint y);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex2(GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex2(GLshort x, GLshort y);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex2(GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex3(GLdouble x, GLdouble y, GLdouble z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex3(GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex3(GLfloat x, GLfloat y, GLfloat z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex3(GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex3(GLint x, GLint y, GLint z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex3(GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex3(GLshort x, GLshort y, GLshort z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex3(GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex4(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex4(GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex4(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex4(GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex4(GLint x, GLint y, GLint z, GLint w);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex4(GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex4(GLshort x, GLshort y, GLshort z, GLshort w);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Vertex4(GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord1(GLdouble s);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord1(GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord1(GLfloat s);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord1(GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord1(GLint s);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord1(GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord1(GLshort s);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord1(GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord2(GLdouble s, GLdouble t);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord2(GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord2(GLfloat s, GLfloat t);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord2(GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord2(GLint s, GLint t);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord2(GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord2(GLshort s, GLshort t);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord2(GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord3(GLdouble s, GLdouble t, GLdouble r);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord3(GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord3(GLfloat s, GLfloat t, GLfloat r);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord3(GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord3(GLint s, GLint t, GLint r);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord3(GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord3(GLshort s, GLshort t, GLshort r);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord3(GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord4(GLdouble s, GLdouble t, GLdouble r, GLdouble q);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord4(GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord4(GLfloat s, GLfloat t, GLfloat r, GLfloat q);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord4(GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord4(GLint s, GLint t, GLint r, GLint q);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord4(GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord4(GLshort s, GLshort t, GLshort r, GLshort q);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexCoord4(GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord1(GLenum target, GLdouble s);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord1(GLenum target, GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord1(GLenum target, GLfloat s);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord1(GLenum target, GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord1(GLenum target, GLint s);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord1(GLenum target, GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord1(GLenum target, GLshort s);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord1(GLenum target, GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord2(GLenum target, GLdouble s, GLdouble t);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord2(GLenum target, GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord2(GLenum target, GLfloat s, GLfloat t);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord2(GLenum target, GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord2(GLenum target, GLint s, GLint t);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord2(GLenum target, GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord2(GLenum target, GLshort s, GLshort t);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord2(GLenum target, GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord3(GLenum target, GLdouble s, GLdouble t, GLdouble r);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord3(GLenum target, GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord3(GLenum target, GLfloat s, GLfloat t, GLfloat r);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord3(GLenum target, GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord3(GLenum target, GLint s, GLint t, GLint r);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord3(GLenum target, GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord3(GLenum target, GLshort s, GLshort t, GLshort r);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord3(GLenum target, GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord4(GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord4(GLenum target, GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord4(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord4(GLenum target, GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord4(GLenum target, GLint s, GLint t, GLint r, GLint q);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord4(GLenum target, GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord4(GLenum target, GLshort s, GLshort t, GLshort r, GLshort q);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MultiTexCoord4(GLenum target, GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Normal3(GLbyte nx, GLbyte ny, GLbyte nz);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Normal3(GLbyte* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Normal3(GLdouble nx, GLdouble ny, GLdouble nz);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Normal3(GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Normal3(GLfloat nx, GLfloat ny, GLfloat nz);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Normal3(GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Normal3(GLint nx, GLint ny, GLint nz);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Normal3(GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Normal3(GLshort nx, GLshort ny, GLshort nz);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Normal3(GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid FogCoord(GLdouble coord);
    [DllImport(DllName)]
    public static extern unsafe GLvoid FogCoord(GLdouble* coord);
    [DllImport(DllName)]
    public static extern unsafe GLvoid FogCoord(GLfloat coord);
    [DllImport(DllName)]
    public static extern unsafe GLvoid FogCoord(GLfloat* coord);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color3(GLbyte red, GLbyte green, GLbyte blue);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color3(GLbyte* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color3(GLdouble red, GLdouble green, GLdouble blue);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color3(GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color3(GLfloat red, GLfloat green, GLfloat blue);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color3(GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color3(GLint red, GLint green, GLint blue);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color3(GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color3(GLshort red, GLshort green, GLshort blue);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color3(GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color3(GLubyte red, GLubyte green, GLubyte blue);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color3(GLubyte* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color3(GLuint red, GLuint green, GLuint blue);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color3(GLuint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color3(GLushort red, GLushort green, GLushort blue);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color3(GLushort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color4(GLbyte red, GLbyte green, GLbyte blue, GLbyte alpha);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color4(GLbyte* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color4(GLdouble red, GLdouble green, GLdouble blue, GLdouble alpha);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color4(GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color4(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color4(GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color4(GLint red, GLint green, GLint blue, GLint alpha);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color4(GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color4(GLshort red, GLshort green, GLshort blue, GLshort alpha);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color4(GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color4(GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color4(GLubyte* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color4(GLuint red, GLuint green, GLuint blue, GLuint alpha);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color4(GLuint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color4(GLushort red, GLushort green, GLushort blue, GLushort alpha);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Color4(GLushort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SecondaryColor3(GLbyte red, GLbyte green, GLbyte blue);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SecondaryColor3(GLbyte* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SecondaryColor3(GLdouble red, GLdouble green, GLdouble blue);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SecondaryColor3(GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SecondaryColor3(GLfloat red, GLfloat green, GLfloat blue);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SecondaryColor3(GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SecondaryColor3(GLint red, GLint green, GLint blue);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SecondaryColor3(GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SecondaryColor3(GLshort red, GLshort green, GLshort blue);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SecondaryColor3(GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SecondaryColor3(GLubyte red, GLubyte green, GLubyte blue);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SecondaryColor3(GLubyte* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SecondaryColor3(GLuint red, GLuint green, GLuint blue);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SecondaryColor3(GLuint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SecondaryColor3(GLushort red, GLushort green, GLushort blue);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SecondaryColor3(GLushort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Index(GLdouble c);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Index(GLdouble* c);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Index(GLfloat c);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Index(GLfloat* c);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Index(GLint c);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Index(GLint* c);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Index(GLshort c);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Index(GLshort* c);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib1(GLuint index, GLdouble x);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib1(GLuint index, GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib1(GLuint index, GLfloat x);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib1(GLuint index, GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib1(GLuint index, GLshort x);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib1(GLuint index, GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib2(GLuint index, GLdouble x, GLdouble y);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib2(GLuint index, GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib2(GLuint index, GLfloat x, GLfloat y);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib2(GLuint index, GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib2(GLuint index, GLshort x, GLshort y);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib2(GLuint index, GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib3(GLuint index, GLdouble x, GLdouble y, GLdouble z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib3(GLuint index, GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib3(GLuint index, GLfloat x, GLfloat y, GLfloat z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib3(GLuint index, GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib3(GLuint index, GLshort x, GLshort y, GLshort z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib3(GLuint index, GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib4(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib4(GLuint index, GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib4(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib4(GLuint index, GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib4(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
    [DllImport(DllName)]
    public static extern unsafe GLvoid VertexAttrib4(GLuint index, GLshort* v);
}