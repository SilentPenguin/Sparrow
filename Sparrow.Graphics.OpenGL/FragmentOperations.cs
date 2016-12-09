using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glScissor")]
    public static extern unsafe void Scissor(int x, int y, int width, int height);
    [DllImport(DllName, EntryPoint = "glSampleCoverage")]
    public static extern unsafe void SampleCoverage(float value, bool invert);
    [DllImport(DllName, EntryPoint = "glSampleMaski")]
    public static extern unsafe void SampleMask(uint maskNumber, uint mask);
    [DllImport(DllName, EntryPoint = "glAlphaFunc")]
    public static extern unsafe void AlphaFunc(uint func, float @ref);
    [DllImport(DllName, EntryPoint = "glStencilFunc")]
    public static extern unsafe void StencilFunc(uint func, int @ref, uint mask);
    [DllImport(DllName, EntryPoint = "glStencilFuncSeparate")]
    public static extern unsafe void StencilFuncSeparate(uint face, uint func, int @ref, uint mask);
    [DllImport(DllName, EntryPoint = "glStencilOp")]
    public static extern unsafe void StencilOp(uint fail, uint zfail, uint zpass);
    [DllImport(DllName, EntryPoint = "glStencilOpSeparate")]
    public static extern unsafe void StencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass);
    [DllImport(DllName, EntryPoint = "glDepthFunc")]
    public static extern unsafe void DepthFunc(uint func);
    [DllImport(DllName, EntryPoint = "glBeginQuery")]
    public static extern unsafe void BeginQuery(uint target, uint id);
    [DllImport(DllName, EntryPoint = "glEndQuery")]
    public static extern unsafe void EndQuery(uint target);
    [DllImport(DllName, EntryPoint = "glBlendEquation")]
    public static extern unsafe void BlendEquation(uint mode);
    [DllImport(DllName, EntryPoint = "glBlendEquationSeparate")]
    public static extern unsafe void BlendEquationSeparate(uint modeRGB, uint modeAlpha);
    [DllImport(DllName, EntryPoint = "glBlendFunc")]
    public static extern unsafe void BlendFunc(uint sfactor, uint dfactor);
    [DllImport(DllName, EntryPoint = "glBlendFuncSeparate")]
    public static extern unsafe void BlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);
    [DllImport(DllName, EntryPoint = "glBlendColor")]
    public static extern unsafe void BlendColor(float red, float green, float blue, float alpha);
    [DllImport(DllName, EntryPoint = "glLogicOp")]
    public static extern unsafe void LogicOp(uint opcode);
    [DllImport(DllName, EntryPoint = "glDrawBuffer")]
    public static extern unsafe void DrawBuffer(uint buf);
    [DllImport(DllName, EntryPoint = "glDrawBuffers")]
    public static extern unsafe void DrawBuffers(int n, uint* bufs);
    [DllImport(DllName, EntryPoint = "glIndexMask")]
    public static extern unsafe void IndexMask(uint mask);
    [DllImport(DllName, EntryPoint = "glColorMask")]
    public static extern unsafe void ColorMask(bool red, bool green, bool blue, bool alpha);
    [DllImport(DllName, EntryPoint = "glColorMaski")]
    public static extern unsafe void ColorMask(uint index, bool r, bool g, bool b, bool a);
    [DllImport(DllName, EntryPoint = "glDepthMask")]
    public static extern unsafe void DepthMask(bool flag);
    [DllImport(DllName, EntryPoint = "glStencilMask")]
    public static extern unsafe void StencilMask(uint mask);
    [DllImport(DllName, EntryPoint = "glStencilMaskSeparate")]
    public static extern unsafe void StencilMaskSeparate(uint face, uint mask);
    [DllImport(DllName, EntryPoint = "glClear")]
    public static extern unsafe void Clear(uint mask);
    [DllImport(DllName, EntryPoint = "glClearColor")]
    public static extern unsafe void ClearColor(float red, float green, float blue, float alpha);
    [DllImport(DllName, EntryPoint = "glClearDepth")]
    public static extern unsafe void ClearDepth(double depth);
    [DllImport(DllName, EntryPoint = "glClearStencil")]
    public static extern unsafe void ClearStencil(int s);
    [DllImport(DllName, EntryPoint = "glClearAccum")]
    public static extern unsafe void ClearAccum(float red, float green, float blue, float alpha);
    [DllImport(DllName, EntryPoint = "glClearBufferfv")]
    public static extern unsafe void ClearBuffer(uint buffer, int drawbuffer, float* value);
    [DllImport(DllName, EntryPoint = "glClearBufferiv")]
    public static extern unsafe void ClearBuffer(uint buffer, int drawbuffer, int* value);
    [DllImport(DllName, EntryPoint = "glClearBufferuiv")]
    public static extern unsafe void ClearBuffer(uint buffer, int drawbuffer, uint* value);
    [DllImport(DllName, EntryPoint = "glClearBufferfi")]
    public static extern unsafe void ClearBuffer(uint buffer, int drawbuffer, float depth, int stencil);
    [DllImport(DllName, EntryPoint = "glAccum")]
    public static extern unsafe void Accum(uint op, float value);
}