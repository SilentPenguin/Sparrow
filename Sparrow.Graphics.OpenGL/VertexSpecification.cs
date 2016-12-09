using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glBegin")]
    public static extern unsafe GLvoid Begin(GLenum mode);
    [DllImport(DllName, EntryPoint = "glEnd")]
    public static extern unsafe GLvoid End();
    [DllImport(DllName, EntryPoint = "glEdgeFlag")]
    public static extern unsafe GLvoid EdgeFlag(GLboolean flag);
    [DllImport(DllName, EntryPoint = "glEdgeFlagv")]
    public static extern unsafe GLvoid EdgeFlag(GLboolean* flag);
    [DllImport(DllName, EntryPoint = "glVertex2d")]
    public static extern unsafe GLvoid Vertex2(GLdouble x, GLdouble y);
    [DllImport(DllName, EntryPoint = "glVertex2dv")]
    public static extern unsafe GLvoid Vertex2(GLdouble* v);
    [DllImport(DllName, EntryPoint = "glVertex2f")]
    public static extern unsafe GLvoid Vertex2(GLfloat x, GLfloat y);
    [DllImport(DllName, EntryPoint = "glVertex2fv")]
    public static extern unsafe GLvoid Vertex2(GLfloat* v);
    [DllImport(DllName, EntryPoint = "glVertex2i")]
    public static extern unsafe GLvoid Vertex2(GLint x, GLint y);
    [DllImport(DllName, EntryPoint = "glVertex2iv")]
    public static extern unsafe GLvoid Vertex2(GLint* v);
    [DllImport(DllName, EntryPoint = "glVertex2s")]
    public static extern unsafe GLvoid Vertex2(GLshort x, GLshort y);
    [DllImport(DllName, EntryPoint = "glVertex2sv")]
    public static extern unsafe GLvoid Vertex2(GLshort* v);
    [DllImport(DllName, EntryPoint = "glVertex3d")]
    public static extern unsafe GLvoid Vertex3(GLdouble x, GLdouble y, GLdouble z);
    [DllImport(DllName, EntryPoint = "glVertex3dv")]
    public static extern unsafe GLvoid Vertex3(GLdouble* v);
    [DllImport(DllName, EntryPoint = "glVertex3f")]
    public static extern unsafe GLvoid Vertex3(GLfloat x, GLfloat y, GLfloat z);
    [DllImport(DllName, EntryPoint = "glVertex3fv")]
    public static extern unsafe GLvoid Vertex3(GLfloat* v);
    [DllImport(DllName, EntryPoint = "glVertex3i")]
    public static extern unsafe GLvoid Vertex3(GLint x, GLint y, GLint z);
    [DllImport(DllName, EntryPoint = "glVertex3iv")]
    public static extern unsafe GLvoid Vertex3(GLint* v);
    [DllImport(DllName, EntryPoint = "glVertex3s")]
    public static extern unsafe GLvoid Vertex3(GLshort x, GLshort y, GLshort z);
    [DllImport(DllName, EntryPoint = "glVertex3sv")]
    public static extern unsafe GLvoid Vertex3(GLshort* v);
    [DllImport(DllName, EntryPoint = "glVertex4d")]
    public static extern unsafe GLvoid Vertex4(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
    [DllImport(DllName, EntryPoint = "glVertex4dv")]
    public static extern unsafe GLvoid Vertex4(GLdouble* v);
    [DllImport(DllName, EntryPoint = "glVertex4f")]
    public static extern unsafe GLvoid Vertex4(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
    [DllImport(DllName, EntryPoint = "glVertex4fv")]
    public static extern unsafe GLvoid Vertex4(GLfloat* v);
    [DllImport(DllName, EntryPoint = "glVertex4i")]
    public static extern unsafe GLvoid Vertex4(GLint x, GLint y, GLint z, GLint w);
    [DllImport(DllName, EntryPoint = "glVertex4iv")]
    public static extern unsafe GLvoid Vertex4(GLint* v);
    [DllImport(DllName, EntryPoint = "glVertex4s")]
    public static extern unsafe GLvoid Vertex4(GLshort x, GLshort y, GLshort z, GLshort w);
    [DllImport(DllName, EntryPoint = "glVertex4sv")]
    public static extern unsafe GLvoid Vertex4(GLshort* v);
    [DllImport(DllName, EntryPoint = "glTexCoord1d")]
    public static extern unsafe GLvoid TexCoord1(GLdouble s);
    [DllImport(DllName, EntryPoint = "glTexCoord1dv")]
    public static extern unsafe GLvoid TexCoord1(GLdouble* v);
    [DllImport(DllName, EntryPoint = "glTexCoord1f")]
    public static extern unsafe GLvoid TexCoord1(GLfloat s);
    [DllImport(DllName, EntryPoint = "glTexCoord1fv")]
    public static extern unsafe GLvoid TexCoord1(GLfloat* v);
    [DllImport(DllName, EntryPoint = "glTexCoord1i")]
    public static extern unsafe GLvoid TexCoord1(GLint s);
    [DllImport(DllName, EntryPoint = "glTexCoord1iv")]
    public static extern unsafe GLvoid TexCoord1(GLint* v);
    [DllImport(DllName, EntryPoint = "glTexCoord1s")]
    public static extern unsafe GLvoid TexCoord1(GLshort s);
    [DllImport(DllName, EntryPoint = "glTexCoord1sv")]
    public static extern unsafe GLvoid TexCoord1(GLshort* v);
    [DllImport(DllName, EntryPoint = "glTexCoord2d")]
    public static extern unsafe GLvoid TexCoord2(GLdouble s, GLdouble t);
    [DllImport(DllName, EntryPoint = "glTexCoord2dv")]
    public static extern unsafe GLvoid TexCoord2(GLdouble* v);
    [DllImport(DllName, EntryPoint = "glTexCoord2f")]
    public static extern unsafe GLvoid TexCoord2(GLfloat s, GLfloat t);
    [DllImport(DllName, EntryPoint = "glTexCoord2fv")]
    public static extern unsafe GLvoid TexCoord2(GLfloat* v);
    [DllImport(DllName, EntryPoint = "glTexCoord2i")]
    public static extern unsafe GLvoid TexCoord2(GLint s, GLint t);
    [DllImport(DllName, EntryPoint = "glTexCoord2iv")]
    public static extern unsafe GLvoid TexCoord2(GLint* v);
    [DllImport(DllName, EntryPoint = "glTexCoord2s")]
    public static extern unsafe GLvoid TexCoord2(GLshort s, GLshort t);
    [DllImport(DllName, EntryPoint = "glTexCoord2sv")]
    public static extern unsafe GLvoid TexCoord2(GLshort* v);
    [DllImport(DllName, EntryPoint = "glTexCoord3d")]
    public static extern unsafe GLvoid TexCoord3(GLdouble s, GLdouble t, GLdouble r);
    [DllImport(DllName, EntryPoint = "glTexCoord3dv")]
    public static extern unsafe GLvoid TexCoord3(GLdouble* v);
    [DllImport(DllName, EntryPoint = "glTexCoord3f")]
    public static extern unsafe GLvoid TexCoord3(GLfloat s, GLfloat t, GLfloat r);
    [DllImport(DllName, EntryPoint = "glTexCoord3fv")]
    public static extern unsafe GLvoid TexCoord3(GLfloat* v);
    [DllImport(DllName, EntryPoint = "glTexCoord3i")]
    public static extern unsafe GLvoid TexCoord3(GLint s, GLint t, GLint r);
    [DllImport(DllName, EntryPoint = "glTexCoord3iv")]
    public static extern unsafe GLvoid TexCoord3(GLint* v);
    [DllImport(DllName, EntryPoint = "glTexCoord3s")]
    public static extern unsafe GLvoid TexCoord3(GLshort s, GLshort t, GLshort r);
    [DllImport(DllName, EntryPoint = "glTexCoord3sv")]
    public static extern unsafe GLvoid TexCoord3(GLshort* v);
    [DllImport(DllName, EntryPoint = "glTexCoord4d")]
    public static extern unsafe GLvoid TexCoord4(GLdouble s, GLdouble t, GLdouble r, GLdouble q);
    [DllImport(DllName, EntryPoint = "glTexCoord4dv")]
    public static extern unsafe GLvoid TexCoord4(GLdouble* v);
    [DllImport(DllName, EntryPoint = "glTexCoord4f")]
    public static extern unsafe GLvoid TexCoord4(GLfloat s, GLfloat t, GLfloat r, GLfloat q);
    [DllImport(DllName, EntryPoint = "glTexCoord4fv")]
    public static extern unsafe GLvoid TexCoord4(GLfloat* v);
    [DllImport(DllName, EntryPoint = "glTexCoord4i")]
    public static extern unsafe GLvoid TexCoord4(GLint s, GLint t, GLint r, GLint q);
    [DllImport(DllName, EntryPoint = "glTexCoord4iv")]
    public static extern unsafe GLvoid TexCoord4(GLint* v);
    [DllImport(DllName, EntryPoint = "glTexCoord4s")]
    public static extern unsafe GLvoid TexCoord4(GLshort s, GLshort t, GLshort r, GLshort q);
    [DllImport(DllName, EntryPoint = "glTexCoord4sv")]
    public static extern unsafe GLvoid TexCoord4(GLshort* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord1d")]
    public static extern unsafe GLvoid MultiTexCoord1(GLenum target, GLdouble s);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord1dv")]
    public static extern unsafe GLvoid MultiTexCoord1(GLenum target, GLdouble* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord1f")]
    public static extern unsafe GLvoid MultiTexCoord1(GLenum target, GLfloat s);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord1fv")]
    public static extern unsafe GLvoid MultiTexCoord1(GLenum target, GLfloat* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord1i")]
    public static extern unsafe GLvoid MultiTexCoord1(GLenum target, GLint s);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord1iv")]
    public static extern unsafe GLvoid MultiTexCoord1(GLenum target, GLint* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord1s")]
    public static extern unsafe GLvoid MultiTexCoord1(GLenum target, GLshort s);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord1sv")]
    public static extern unsafe GLvoid MultiTexCoord1(GLenum target, GLshort* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord2d")]
    public static extern unsafe GLvoid MultiTexCoord2(GLenum target, GLdouble s, GLdouble t);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord2dv")]
    public static extern unsafe GLvoid MultiTexCoord2(GLenum target, GLdouble* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord2f")]
    public static extern unsafe GLvoid MultiTexCoord2(GLenum target, GLfloat s, GLfloat t);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord2fv")]
    public static extern unsafe GLvoid MultiTexCoord2(GLenum target, GLfloat* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord2i")]
    public static extern unsafe GLvoid MultiTexCoord2(GLenum target, GLint s, GLint t);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord2iv")]
    public static extern unsafe GLvoid MultiTexCoord2(GLenum target, GLint* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord2s")]
    public static extern unsafe GLvoid MultiTexCoord2(GLenum target, GLshort s, GLshort t);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord2sv")]
    public static extern unsafe GLvoid MultiTexCoord2(GLenum target, GLshort* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord3d")]
    public static extern unsafe GLvoid MultiTexCoord3(GLenum target, GLdouble s, GLdouble t, GLdouble r);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord3dv")]
    public static extern unsafe GLvoid MultiTexCoord3(GLenum target, GLdouble* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord3f")]
    public static extern unsafe GLvoid MultiTexCoord3(GLenum target, GLfloat s, GLfloat t, GLfloat r);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord3fv")]
    public static extern unsafe GLvoid MultiTexCoord3(GLenum target, GLfloat* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord3i")]
    public static extern unsafe GLvoid MultiTexCoord3(GLenum target, GLint s, GLint t, GLint r);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord3iv")]
    public static extern unsafe GLvoid MultiTexCoord3(GLenum target, GLint* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord3s")]
    public static extern unsafe GLvoid MultiTexCoord3(GLenum target, GLshort s, GLshort t, GLshort r);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord3sv")]
    public static extern unsafe GLvoid MultiTexCoord3(GLenum target, GLshort* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord4d")]
    public static extern unsafe GLvoid MultiTexCoord4(GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord4dv")]
    public static extern unsafe GLvoid MultiTexCoord4(GLenum target, GLdouble* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord4f")]
    public static extern unsafe GLvoid MultiTexCoord4(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord4fv")]
    public static extern unsafe GLvoid MultiTexCoord4(GLenum target, GLfloat* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord4i")]
    public static extern unsafe GLvoid MultiTexCoord4(GLenum target, GLint s, GLint t, GLint r, GLint q);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord4iv")]
    public static extern unsafe GLvoid MultiTexCoord4(GLenum target, GLint* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord4s")]
    public static extern unsafe GLvoid MultiTexCoord4(GLenum target, GLshort s, GLshort t, GLshort r, GLshort q);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord4sv")]
    public static extern unsafe GLvoid MultiTexCoord4(GLenum target, GLshort* v);
    [DllImport(DllName, EntryPoint = "glNormal3b")]
    public static extern unsafe GLvoid Normal3(GLbyte nx, GLbyte ny, GLbyte nz);
    [DllImport(DllName, EntryPoint = "glNormal3bv")]
    public static extern unsafe GLvoid Normal3(GLbyte* v);
    [DllImport(DllName, EntryPoint = "glNormal3d")]
    public static extern unsafe GLvoid Normal3(GLdouble nx, GLdouble ny, GLdouble nz);
    [DllImport(DllName, EntryPoint = "glNormal3dv")]
    public static extern unsafe GLvoid Normal3(GLdouble* v);
    [DllImport(DllName, EntryPoint = "glNormal3f")]
    public static extern unsafe GLvoid Normal3(GLfloat nx, GLfloat ny, GLfloat nz);
    [DllImport(DllName, EntryPoint = "glNormal3fv")]
    public static extern unsafe GLvoid Normal3(GLfloat* v);
    [DllImport(DllName, EntryPoint = "glNormal3i")]
    public static extern unsafe GLvoid Normal3(GLint nx, GLint ny, GLint nz);
    [DllImport(DllName, EntryPoint = "glNormal3iv")]
    public static extern unsafe GLvoid Normal3(GLint* v);
    [DllImport(DllName, EntryPoint = "glNormal3s")]
    public static extern unsafe GLvoid Normal3(GLshort nx, GLshort ny, GLshort nz);
    [DllImport(DllName, EntryPoint = "glNormal3sv")]
    public static extern unsafe GLvoid Normal3(GLshort* v);
    [DllImport(DllName, EntryPoint = "glFogCoordd")]
    public static extern unsafe GLvoid FogCoord(GLdouble coord);
    [DllImport(DllName, EntryPoint = "glFogCoorddv")]
    public static extern unsafe GLvoid FogCoord(GLdouble* coord);
    [DllImport(DllName, EntryPoint = "glFogCoordf")]
    public static extern unsafe GLvoid FogCoord(GLfloat coord);
    [DllImport(DllName, EntryPoint = "glFogCoordfv")]
    public static extern unsafe GLvoid FogCoord(GLfloat* coord);
    [DllImport(DllName, EntryPoint = "glColor3b")]
    public static extern unsafe GLvoid Color3(GLbyte red, GLbyte green, GLbyte blue);
    [DllImport(DllName, EntryPoint = "glColor3bv")]
    public static extern unsafe GLvoid Color3(GLbyte* v);
    [DllImport(DllName, EntryPoint = "glColor3d")]
    public static extern unsafe GLvoid Color3(GLdouble red, GLdouble green, GLdouble blue);
    [DllImport(DllName, EntryPoint = "glColor3dv")]
    public static extern unsafe GLvoid Color3(GLdouble* v);
    [DllImport(DllName, EntryPoint = "glColor3f")]
    public static extern unsafe GLvoid Color3(GLfloat red, GLfloat green, GLfloat blue);
    [DllImport(DllName, EntryPoint = "glColor3fv")]
    public static extern unsafe GLvoid Color3(GLfloat* v);
    [DllImport(DllName, EntryPoint = "glColor3i")]
    public static extern unsafe GLvoid Color3(GLint red, GLint green, GLint blue);
    [DllImport(DllName, EntryPoint = "glColor3iv")]
    public static extern unsafe GLvoid Color3(GLint* v);
    [DllImport(DllName, EntryPoint = "glColor3s")]
    public static extern unsafe GLvoid Color3(GLshort red, GLshort green, GLshort blue);
    [DllImport(DllName, EntryPoint = "glColor3sv")]
    public static extern unsafe GLvoid Color3(GLshort* v);
    [DllImport(DllName, EntryPoint = "glColor3ub")]
    public static extern unsafe GLvoid Color3(GLubyte red, GLubyte green, GLubyte blue);
    [DllImport(DllName, EntryPoint = "glColor3ubv")]
    public static extern unsafe GLvoid Color3(GLubyte* v);
    [DllImport(DllName, EntryPoint = "glColor3ui")]
    public static extern unsafe GLvoid Color3(GLuint red, GLuint green, GLuint blue);
    [DllImport(DllName, EntryPoint = "glColor3uiv")]
    public static extern unsafe GLvoid Color3(GLuint* v);
    [DllImport(DllName, EntryPoint = "glColor3us")]
    public static extern unsafe GLvoid Color3(GLushort red, GLushort green, GLushort blue);
    [DllImport(DllName, EntryPoint = "glColor3usv")]
    public static extern unsafe GLvoid Color3(GLushort* v);
    [DllImport(DllName, EntryPoint = "glColor4b")]
    public static extern unsafe GLvoid Color4(GLbyte red, GLbyte green, GLbyte blue, GLbyte alpha);
    [DllImport(DllName, EntryPoint = "glColor4bv")]
    public static extern unsafe GLvoid Color4(GLbyte* v);
    [DllImport(DllName, EntryPoint = "glColor4d")]
    public static extern unsafe GLvoid Color4(GLdouble red, GLdouble green, GLdouble blue, GLdouble alpha);
    [DllImport(DllName, EntryPoint = "glColor4dv")]
    public static extern unsafe GLvoid Color4(GLdouble* v);
    [DllImport(DllName, EntryPoint = "glColor4f")]
    public static extern unsafe GLvoid Color4(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
    [DllImport(DllName, EntryPoint = "glColor4fv")]
    public static extern unsafe GLvoid Color4(GLfloat* v);
    [DllImport(DllName, EntryPoint = "glColor4i")]
    public static extern unsafe GLvoid Color4(GLint red, GLint green, GLint blue, GLint alpha);
    [DllImport(DllName, EntryPoint = "glColor4iv")]
    public static extern unsafe GLvoid Color4(GLint* v);
    [DllImport(DllName, EntryPoint = "glColor4s")]
    public static extern unsafe GLvoid Color4(GLshort red, GLshort green, GLshort blue, GLshort alpha);
    [DllImport(DllName, EntryPoint = "glColor4sv")]
    public static extern unsafe GLvoid Color4(GLshort* v);
    [DllImport(DllName, EntryPoint = "glColor4ub")]
    public static extern unsafe GLvoid Color4(GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha);
    [DllImport(DllName, EntryPoint = "glColor4ubv")]
    public static extern unsafe GLvoid Color4(GLubyte* v);
    [DllImport(DllName, EntryPoint = "glColor4ui")]
    public static extern unsafe GLvoid Color4(GLuint red, GLuint green, GLuint blue, GLuint alpha);
    [DllImport(DllName, EntryPoint = "glColor4uiv")]
    public static extern unsafe GLvoid Color4(GLuint* v);
    [DllImport(DllName, EntryPoint = "glColor4us")]
    public static extern unsafe GLvoid Color4(GLushort red, GLushort green, GLushort blue, GLushort alpha);
    [DllImport(DllName, EntryPoint = "glColor4usv")]
    public static extern unsafe GLvoid Color4(GLushort* v);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3b")]
    public static extern unsafe GLvoid SecondaryColor3(GLbyte red, GLbyte green, GLbyte blue);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3bv")]
    public static extern unsafe GLvoid SecondaryColor3(GLbyte* v);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3d")]
    public static extern unsafe GLvoid SecondaryColor3(GLdouble red, GLdouble green, GLdouble blue);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3dv")]
    public static extern unsafe GLvoid SecondaryColor3(GLdouble* v);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3f")]
    public static extern unsafe GLvoid SecondaryColor3(GLfloat red, GLfloat green, GLfloat blue);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3fv")]
    public static extern unsafe GLvoid SecondaryColor3(GLfloat* v);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3i")]
    public static extern unsafe GLvoid SecondaryColor3(GLint red, GLint green, GLint blue);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3iv")]
    public static extern unsafe GLvoid SecondaryColor3(GLint* v);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3s")]
    public static extern unsafe GLvoid SecondaryColor3(GLshort red, GLshort green, GLshort blue);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3sv")]
    public static extern unsafe GLvoid SecondaryColor3(GLshort* v);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3ub")]
    public static extern unsafe GLvoid SecondaryColor3(GLubyte red, GLubyte green, GLubyte blue);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3ubv")]
    public static extern unsafe GLvoid SecondaryColor3(GLubyte* v);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3ui")]
    public static extern unsafe GLvoid SecondaryColor3(GLuint red, GLuint green, GLuint blue);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3uiv")]
    public static extern unsafe GLvoid SecondaryColor3(GLuint* v);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3us")]
    public static extern unsafe GLvoid SecondaryColor3(GLushort red, GLushort green, GLushort blue);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3usv")]
    public static extern unsafe GLvoid SecondaryColor3(GLushort* v);
    [DllImport(DllName, EntryPoint = "glIndexd")]
    public static extern unsafe GLvoid Index(GLdouble c);
    [DllImport(DllName, EntryPoint = "glIndexdv")]
    public static extern unsafe GLvoid Index(GLdouble* c);
    [DllImport(DllName, EntryPoint = "glIndexf")]
    public static extern unsafe GLvoid Index(GLfloat c);
    [DllImport(DllName, EntryPoint = "glIndexfv")]
    public static extern unsafe GLvoid Index(GLfloat* c);
    [DllImport(DllName, EntryPoint = "glIndexi")]
    public static extern unsafe GLvoid Index(GLint c);
    [DllImport(DllName, EntryPoint = "glIndexiv")]
    public static extern unsafe GLvoid Index(GLint* c);
    [DllImport(DllName, EntryPoint = "glIndexs")]
    public static extern unsafe GLvoid Index(GLshort c);
    [DllImport(DllName, EntryPoint = "glIndexsv")]
    public static extern unsafe GLvoid Index(GLshort* c);
    [DllImport(DllName, EntryPoint = "glVertexAttrib1d")]
    public static extern unsafe GLvoid VertexAttrib1(GLuint index, GLdouble x);
    [DllImport(DllName, EntryPoint = "glVertexAttrib1dv")]
    public static extern unsafe GLvoid VertexAttrib1(GLuint index, GLdouble* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib1f")]
    public static extern unsafe GLvoid VertexAttrib1(GLuint index, GLfloat x);
    [DllImport(DllName, EntryPoint = "glVertexAttrib1fv")]
    public static extern unsafe GLvoid VertexAttrib1(GLuint index, GLfloat* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib1s")]
    public static extern unsafe GLvoid VertexAttrib1(GLuint index, GLshort x);
    [DllImport(DllName, EntryPoint = "glVertexAttrib1sv")]
    public static extern unsafe GLvoid VertexAttrib1(GLuint index, GLshort* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib2d")]
    public static extern unsafe GLvoid VertexAttrib2(GLuint index, GLdouble x, GLdouble y);
    [DllImport(DllName, EntryPoint = "glVertexAttrib2dv")]
    public static extern unsafe GLvoid VertexAttrib2(GLuint index, GLdouble* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib2f")]
    public static extern unsafe GLvoid VertexAttrib2(GLuint index, GLfloat x, GLfloat y);
    [DllImport(DllName, EntryPoint = "glVertexAttrib2fv")]
    public static extern unsafe GLvoid VertexAttrib2(GLuint index, GLfloat* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib2s")]
    public static extern unsafe GLvoid VertexAttrib2(GLuint index, GLshort x, GLshort y);
    [DllImport(DllName, EntryPoint = "glVertexAttrib2sv")]
    public static extern unsafe GLvoid VertexAttrib2(GLuint index, GLshort* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib3d")]
    public static extern unsafe GLvoid VertexAttrib3(GLuint index, GLdouble x, GLdouble y, GLdouble z);
    [DllImport(DllName, EntryPoint = "glVertexAttrib3dv")]
    public static extern unsafe GLvoid VertexAttrib3(GLuint index, GLdouble* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib3f")]
    public static extern unsafe GLvoid VertexAttrib3(GLuint index, GLfloat x, GLfloat y, GLfloat z);
    [DllImport(DllName, EntryPoint = "glVertexAttrib3fv")]
    public static extern unsafe GLvoid VertexAttrib3(GLuint index, GLfloat* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib3s")]
    public static extern unsafe GLvoid VertexAttrib3(GLuint index, GLshort x, GLshort y, GLshort z);
    [DllImport(DllName, EntryPoint = "glVertexAttrib3sv")]
    public static extern unsafe GLvoid VertexAttrib3(GLuint index, GLshort* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib4d")]
    public static extern unsafe GLvoid VertexAttrib4(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
    [DllImport(DllName, EntryPoint = "glVertexAttrib4dv")]
    public static extern unsafe GLvoid VertexAttrib4(GLuint index, GLdouble* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib4f")]
    public static extern unsafe GLvoid VertexAttrib4(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
    [DllImport(DllName, EntryPoint = "glVertexAttrib4fv")]
    public static extern unsafe GLvoid VertexAttrib4(GLuint index, GLfloat* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib4s")]
    public static extern unsafe GLvoid VertexAttrib4(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
    [DllImport(DllName, EntryPoint = "glVertexAttrib4sv")]
    public static extern unsafe GLvoid VertexAttrib4(GLuint index, GLshort* v);
}