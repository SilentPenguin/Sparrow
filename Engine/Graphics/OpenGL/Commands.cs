using System;
using System.Runtime.InteropServices;
namespace Sparrow.Graphics.OpenGL
{
    public unsafe delegate void GLDEBUGPROC (uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);
    public static partial class Raw
    {
        [DllImport(DllName)]
        public static extern unsafe void glAccum (uint op, float value);
        [DllImport(DllName)]
        public static extern unsafe void glAccumxOES (uint op, int value);
        [DllImport(DllName)]
        public static extern unsafe void glActiveProgramEXT (uint program);
        [DllImport(DllName)]
        public static extern unsafe void glActiveShaderProgram (uint pipeline, uint program);
        [DllImport(DllName)]
        public static extern unsafe void glActiveShaderProgramEXT (uint pipeline, uint program);
        [DllImport(DllName)]
        public static extern unsafe void glActiveStencilFaceEXT (uint face);
        [DllImport(DllName)]
        public static extern unsafe void glActiveTexture (uint texture);
        [DllImport(DllName)]
        public static extern unsafe void glActiveTextureARB (uint texture);
        [DllImport(DllName)]
        public static extern unsafe void glActiveVaryingNV (uint program, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glAlphaFragmentOp1ATI (uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod);
        [DllImport(DllName)]
        public static extern unsafe void glAlphaFragmentOp2ATI (uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod);
        [DllImport(DllName)]
        public static extern unsafe void glAlphaFragmentOp3ATI (uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod);
        [DllImport(DllName)]
        public static extern unsafe void glAlphaFunc (uint func, float @ref);
        [DllImport(DllName)]
        public static extern unsafe void glAlphaFuncQCOM (uint func, float @ref);
        [DllImport(DllName)]
        public static extern unsafe void glAlphaFuncx (uint func, int @ref);
        [DllImport(DllName)]
        public static extern unsafe void glAlphaFuncxOES (uint func, int @ref);
        [DllImport(DllName)]
        public static extern unsafe void glApplyFramebufferAttachmentCMAAINTEL ();
        [DllImport(DllName)]
        public static extern unsafe void glApplyTextureEXT (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glAreProgramsResidentNV (int n, uint* programs, bool* residences);
        [DllImport(DllName)]
        public static extern unsafe void glAreTexturesResident (int n, uint* textures, bool* residences);
        [DllImport(DllName)]
        public static extern unsafe void glAreTexturesResidentEXT (int n, uint* textures, bool* residences);
        [DllImport(DllName)]
        public static extern unsafe void glArrayElement (int i);
        [DllImport(DllName)]
        public static extern unsafe void glArrayElementEXT (int i);
        [DllImport(DllName)]
        public static extern unsafe void glArrayObjectATI (uint array, int size, uint type, int stride, uint buffer, uint offset);
        [DllImport(DllName)]
        public static extern unsafe void glAsyncMarkerSGIX (uint marker);
        [DllImport(DllName)]
        public static extern unsafe void glAttachObjectARB (void* containerObj, void* obj);
        [DllImport(DllName)]
        public static extern unsafe void glAttachShader (uint program, uint shader);
        [DllImport(DllName)]
        public static extern unsafe void glBegin (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glBeginConditionalRender (uint id, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glBeginConditionalRenderNV (uint id, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glBeginConditionalRenderNVX (uint id);
        [DllImport(DllName)]
        public static extern unsafe void glBeginFragmentShaderATI ();
        [DllImport(DllName)]
        public static extern unsafe void glBeginOcclusionQueryNV (uint id);
        [DllImport(DllName)]
        public static extern unsafe void glBeginPerfMonitorAMD (uint monitor);
        [DllImport(DllName)]
        public static extern unsafe void glBeginPerfQueryINTEL (uint queryHandle);
        [DllImport(DllName)]
        public static extern unsafe void glBeginQuery (uint target, uint id);
        [DllImport(DllName)]
        public static extern unsafe void glBeginQueryARB (uint target, uint id);
        [DllImport(DllName)]
        public static extern unsafe void glBeginQueryEXT (uint target, uint id);
        [DllImport(DllName)]
        public static extern unsafe void glBeginQueryIndexed (uint target, uint index, uint id);
        [DllImport(DllName)]
        public static extern unsafe void glBeginTransformFeedback (uint primitiveMode);
        [DllImport(DllName)]
        public static extern unsafe void glBeginTransformFeedbackEXT (uint primitiveMode);
        [DllImport(DllName)]
        public static extern unsafe void glBeginTransformFeedbackNV (uint primitiveMode);
        [DllImport(DllName)]
        public static extern unsafe void glBeginVertexShaderEXT ();
        [DllImport(DllName)]
        public static extern unsafe void glBeginVideoCaptureNV (uint video_capture_slot);
        [DllImport(DllName)]
        public static extern unsafe void glBindAttribLocation (uint program, uint index, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glBindAttribLocationARB (void* programObj, uint index, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glBindBuffer (uint target, uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glBindBufferARB (uint target, uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glBindBufferBase (uint target, uint index, uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glBindBufferBaseEXT (uint target, uint index, uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glBindBufferBaseNV (uint target, uint index, uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glBindBufferOffsetEXT (uint target, uint index, uint buffer, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glBindBufferOffsetNV (uint target, uint index, uint buffer, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glBindBufferRange (uint target, uint index, uint buffer, int* offset, int* size);
        [DllImport(DllName)]
        public static extern unsafe void glBindBufferRangeEXT (uint target, uint index, uint buffer, int* offset, int* size);
        [DllImport(DllName)]
        public static extern unsafe void glBindBufferRangeNV (uint target, uint index, uint buffer, int* offset, int* size);
        [DllImport(DllName)]
        public static extern unsafe void glBindBuffersBase (uint target, uint first, int count, uint* buffers);
        [DllImport(DllName)]
        public static extern unsafe void glBindBuffersRange (uint target, uint first, int count, uint* buffers, int** offsets, int** sizes);
        [DllImport(DllName)]
        public static extern unsafe void glBindFragDataLocation (uint program, uint color, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glBindFragDataLocationEXT (uint program, uint color, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glBindFragDataLocationIndexed (uint program, uint colorNumber, uint index, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glBindFragDataLocationIndexedEXT (uint program, uint colorNumber, uint index, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glBindFragmentShaderATI (uint id);
        [DllImport(DllName)]
        public static extern unsafe void glBindFramebuffer (uint target, uint framebuffer);
        [DllImport(DllName)]
        public static extern unsafe void glBindFramebufferEXT (uint target, uint framebuffer);
        [DllImport(DllName)]
        public static extern unsafe void glBindFramebufferOES (uint target, uint framebuffer);
        [DllImport(DllName)]
        public static extern unsafe void glBindImageTexture (uint unit, uint texture, int level, bool layered, int layer, uint access, uint format);
        [DllImport(DllName)]
        public static extern unsafe void glBindImageTextureEXT (uint index, uint texture, int level, bool layered, int layer, uint access, int format);
        [DllImport(DllName)]
        public static extern unsafe void glBindImageTextures (uint first, int count, uint* textures);
        [DllImport(DllName)]
        public static extern unsafe void glBindLightParameterEXT (uint light, uint value);
        [DllImport(DllName)]
        public static extern unsafe void glBindMaterialParameterEXT (uint face, uint value);
        [DllImport(DllName)]
        public static extern unsafe void glBindMultiTextureEXT (uint texunit, uint target, uint texture);
        [DllImport(DllName)]
        public static extern unsafe void glBindParameterEXT (uint value);
        [DllImport(DllName)]
        public static extern unsafe void glBindProgramARB (uint target, uint program);
        [DllImport(DllName)]
        public static extern unsafe void glBindProgramNV (uint target, uint id);
        [DllImport(DllName)]
        public static extern unsafe void glBindProgramPipeline (uint pipeline);
        [DllImport(DllName)]
        public static extern unsafe void glBindProgramPipelineEXT (uint pipeline);
        [DllImport(DllName)]
        public static extern unsafe void glBindRenderbuffer (uint target, uint renderbuffer);
        [DllImport(DllName)]
        public static extern unsafe void glBindRenderbufferEXT (uint target, uint renderbuffer);
        [DllImport(DllName)]
        public static extern unsafe void glBindRenderbufferOES (uint target, uint renderbuffer);
        [DllImport(DllName)]
        public static extern unsafe void glBindSampler (uint unit, uint sampler);
        [DllImport(DllName)]
        public static extern unsafe void glBindSamplers (uint first, int count, uint* samplers);
        [DllImport(DllName)]
        public static extern unsafe void glBindTexGenParameterEXT (uint unit, uint coord, uint value);
        [DllImport(DllName)]
        public static extern unsafe void glBindTexture (uint target, uint texture);
        [DllImport(DllName)]
        public static extern unsafe void glBindTextureEXT (uint target, uint texture);
        [DllImport(DllName)]
        public static extern unsafe void glBindTextureUnit (uint unit, uint texture);
        [DllImport(DllName)]
        public static extern unsafe void glBindTextureUnitParameterEXT (uint unit, uint value);
        [DllImport(DllName)]
        public static extern unsafe void glBindTextures (uint first, int count, uint* textures);
        [DllImport(DllName)]
        public static extern unsafe void glBindTransformFeedback (uint target, uint id);
        [DllImport(DllName)]
        public static extern unsafe void glBindTransformFeedbackNV (uint target, uint id);
        [DllImport(DllName)]
        public static extern unsafe void glBindVertexArray (uint array);
        [DllImport(DllName)]
        public static extern unsafe void glBindVertexArrayAPPLE (uint array);
        [DllImport(DllName)]
        public static extern unsafe void glBindVertexArrayOES (uint array);
        [DllImport(DllName)]
        public static extern unsafe void glBindVertexBuffer (uint bindingindex, uint buffer, int* offset, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glBindVertexBuffers (uint first, int count, uint* buffers, int** offsets, int* strides);
        [DllImport(DllName)]
        public static extern unsafe void glBindVertexShaderEXT (uint id);
        [DllImport(DllName)]
        public static extern unsafe void glBindVideoCaptureStreamBufferNV (uint video_capture_slot, uint stream, uint frame_region, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glBindVideoCaptureStreamTextureNV (uint video_capture_slot, uint stream, uint frame_region, uint target, uint texture);
        [DllImport(DllName)]
        public static extern unsafe void glBinormal3bEXT (sbyte bx, sbyte by, sbyte bz);
        [DllImport(DllName)]
        public static extern unsafe void glBinormal3bvEXT (sbyte* v);
        [DllImport(DllName)]
        public static extern unsafe void glBinormal3dEXT (double bx, double by, double bz);
        [DllImport(DllName)]
        public static extern unsafe void glBinormal3dvEXT (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glBinormal3fEXT (float bx, float by, float bz);
        [DllImport(DllName)]
        public static extern unsafe void glBinormal3fvEXT (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glBinormal3iEXT (int bx, int by, int bz);
        [DllImport(DllName)]
        public static extern unsafe void glBinormal3ivEXT (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glBinormal3sEXT (short bx, short by, short bz);
        [DllImport(DllName)]
        public static extern unsafe void glBinormal3svEXT (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glBinormalPointerEXT (uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glBitmap (int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);
        [DllImport(DllName)]
        public static extern unsafe void glBitmapxOES (int width, int height, int xorig, int yorig, int xmove, int ymove, byte* bitmap);
        [DllImport(DllName)]
        public static extern unsafe void glBlendBarrier ();
        [DllImport(DllName)]
        public static extern unsafe void glBlendBarrierKHR ();
        [DllImport(DllName)]
        public static extern unsafe void glBlendBarrierNV ();
        [DllImport(DllName)]
        public static extern unsafe void glBlendColor (float red, float green, float blue, float alpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendColorEXT (float red, float green, float blue, float alpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendColorxOES (int red, int green, int blue, int alpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendEquation (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glBlendEquationEXT (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glBlendEquationIndexedAMD (uint buf, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glBlendEquationOES (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glBlendEquationSeparate (uint modeRGB, uint modeAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendEquationSeparateEXT (uint modeRGB, uint modeAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendEquationSeparateIndexedAMD (uint buf, uint modeRGB, uint modeAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendEquationSeparateOES (uint modeRGB, uint modeAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendEquationSeparatei (uint buf, uint modeRGB, uint modeAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendEquationSeparateiARB (uint buf, uint modeRGB, uint modeAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendEquationSeparateiEXT (uint buf, uint modeRGB, uint modeAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendEquationSeparateiOES (uint buf, uint modeRGB, uint modeAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendEquationi (uint buf, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glBlendEquationiARB (uint buf, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glBlendEquationiEXT (uint buf, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glBlendEquationiOES (uint buf, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glBlendFunc (uint sfactor, uint dfactor);
        [DllImport(DllName)]
        public static extern unsafe void glBlendFuncIndexedAMD (uint buf, uint src, uint dst);
        [DllImport(DllName)]
        public static extern unsafe void glBlendFuncSeparate (uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendFuncSeparateEXT (uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendFuncSeparateINGR (uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendFuncSeparateIndexedAMD (uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendFuncSeparateOES (uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendFuncSeparatei (uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendFuncSeparateiARB (uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendFuncSeparateiEXT (uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendFuncSeparateiOES (uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);
        [DllImport(DllName)]
        public static extern unsafe void glBlendFunci (uint buf, uint src, uint dst);
        [DllImport(DllName)]
        public static extern unsafe void glBlendFunciARB (uint buf, uint src, uint dst);
        [DllImport(DllName)]
        public static extern unsafe void glBlendFunciEXT (uint buf, uint src, uint dst);
        [DllImport(DllName)]
        public static extern unsafe void glBlendFunciOES (uint buf, uint src, uint dst);
        [DllImport(DllName)]
        public static extern unsafe void glBlendParameteriNV (uint pname, int value);
        [DllImport(DllName)]
        public static extern unsafe void glBlitFramebuffer (int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
        [DllImport(DllName)]
        public static extern unsafe void glBlitFramebufferANGLE (int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
        [DllImport(DllName)]
        public static extern unsafe void glBlitFramebufferEXT (int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
        [DllImport(DllName)]
        public static extern unsafe void glBlitFramebufferNV (int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
        [DllImport(DllName)]
        public static extern unsafe void glBlitNamedFramebuffer (uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
        [DllImport(DllName)]
        public static extern unsafe void glBufferAddressRangeNV (uint pname, uint index, ulong address, int* length);
        [DllImport(DllName)]
        public static extern unsafe void glBufferData (uint target, int* size, void* data, uint usage);
        [DllImport(DllName)]
        public static extern unsafe void glBufferDataARB (uint target, int* size, void* data, uint usage);
        [DllImport(DllName)]
        public static extern unsafe void glBufferPageCommitmentARB (uint target, int* offset, int* size, bool commit);
        [DllImport(DllName)]
        public static extern unsafe void glBufferParameteriAPPLE (uint target, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glBufferStorage (uint target, int* size, void* data, uint flags);
        [DllImport(DllName)]
        public static extern unsafe void glBufferStorageEXT (uint target, int* size, void* data, uint flags);
        [DllImport(DllName)]
        public static extern unsafe void glBufferSubData (uint target, int* offset, int* size, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glBufferSubDataARB (uint target, int* offset, int* size, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCallCommandListNV (uint list);
        [DllImport(DllName)]
        public static extern unsafe void glCallList (uint list);
        [DllImport(DllName)]
        public static extern unsafe void glCallLists (int n, uint type, void* lists);
        [DllImport(DllName)]
        public static extern unsafe void glCheckFramebufferStatus (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glCheckFramebufferStatusEXT (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glCheckFramebufferStatusOES (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glCheckNamedFramebufferStatus (uint framebuffer, uint target);
        [DllImport(DllName)]
        public static extern unsafe void glCheckNamedFramebufferStatusEXT (uint framebuffer, uint target);
        [DllImport(DllName)]
        public static extern unsafe void glClampColor (uint target, uint clamp);
        [DllImport(DllName)]
        public static extern unsafe void glClampColorARB (uint target, uint clamp);
        [DllImport(DllName)]
        public static extern unsafe void glClear (uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glClearAccum (float red, float green, float blue, float alpha);
        [DllImport(DllName)]
        public static extern unsafe void glClearAccumxOES (int red, int green, int blue, int alpha);
        [DllImport(DllName)]
        public static extern unsafe void glClearBufferData (uint target, uint internalformat, uint format, uint type, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glClearBufferSubData (uint target, uint internalformat, int* offset, int* size, uint format, uint type, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glClearBufferfi (uint buffer, int drawbuffer, float depth, int stencil);
        [DllImport(DllName)]
        public static extern unsafe void glClearBufferfv (uint buffer, int drawbuffer, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glClearBufferiv (uint buffer, int drawbuffer, int* value);
        [DllImport(DllName)]
        public static extern unsafe void glClearBufferuiv (uint buffer, int drawbuffer, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glClearColor (float red, float green, float blue, float alpha);
        [DllImport(DllName)]
        public static extern unsafe void glClearColorIiEXT (int red, int green, int blue, int alpha);
        [DllImport(DllName)]
        public static extern unsafe void glClearColorIuiEXT (uint red, uint green, uint blue, uint alpha);
        [DllImport(DllName)]
        public static extern unsafe void glClearColorx (int red, int green, int blue, int alpha);
        [DllImport(DllName)]
        public static extern unsafe void glClearColorxOES (int red, int green, int blue, int alpha);
        [DllImport(DllName)]
        public static extern unsafe void glClearDepth (double depth);
        [DllImport(DllName)]
        public static extern unsafe void glClearDepthdNV (double depth);
        [DllImport(DllName)]
        public static extern unsafe void glClearDepthf (float d);
        [DllImport(DllName)]
        public static extern unsafe void glClearDepthfOES (float depth);
        [DllImport(DllName)]
        public static extern unsafe void glClearDepthx (int depth);
        [DllImport(DllName)]
        public static extern unsafe void glClearDepthxOES (int depth);
        [DllImport(DllName)]
        public static extern unsafe void glClearIndex (float c);
        [DllImport(DllName)]
        public static extern unsafe void glClearNamedBufferData (uint buffer, uint internalformat, uint format, uint type, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glClearNamedBufferDataEXT (uint buffer, uint internalformat, uint format, uint type, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glClearNamedBufferSubData (uint buffer, uint internalformat, int* offset, int* size, uint format, uint type, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glClearNamedBufferSubDataEXT (uint buffer, uint internalformat, int* offset, int* size, uint format, uint type, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glClearNamedFramebufferfi (uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil);
        [DllImport(DllName)]
        public static extern unsafe void glClearNamedFramebufferfv (uint framebuffer, uint buffer, int drawbuffer, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glClearNamedFramebufferiv (uint framebuffer, uint buffer, int drawbuffer, int* value);
        [DllImport(DllName)]
        public static extern unsafe void glClearNamedFramebufferuiv (uint framebuffer, uint buffer, int drawbuffer, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glClearPixelLocalStorageuiEXT (int offset, int n, uint* values);
        [DllImport(DllName)]
        public static extern unsafe void glClearStencil (int s);
        [DllImport(DllName)]
        public static extern unsafe void glClearTexImage (uint texture, int level, uint format, uint type, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glClearTexSubImage (uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glClientActiveTexture (uint texture);
        [DllImport(DllName)]
        public static extern unsafe void glClientActiveTextureARB (uint texture);
        [DllImport(DllName)]
        public static extern unsafe void glClientActiveVertexStreamATI (uint stream);
        [DllImport(DllName)]
        public static extern unsafe void glClientAttribDefaultEXT (uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glClientWaitSync (void* sync, uint flags, ulong timeout);
        [DllImport(DllName)]
        public static extern unsafe void glClientWaitSyncAPPLE (void* sync, uint flags, ulong timeout);
        [DllImport(DllName)]
        public static extern unsafe void glClipControl (uint origin, uint depth);
        [DllImport(DllName)]
        public static extern unsafe void glClipPlane (uint plane, double* equation);
        [DllImport(DllName)]
        public static extern unsafe void glClipPlanef (uint p, float* eqn);
        [DllImport(DllName)]
        public static extern unsafe void glClipPlanefIMG (uint p, float* eqn);
        [DllImport(DllName)]
        public static extern unsafe void glClipPlanefOES (uint plane, float* equation);
        [DllImport(DllName)]
        public static extern unsafe void glClipPlanex (uint plane, int* equation);
        [DllImport(DllName)]
        public static extern unsafe void glClipPlanexIMG (uint p, int* eqn);
        [DllImport(DllName)]
        public static extern unsafe void glClipPlanexOES (uint plane, int* equation);
        [DllImport(DllName)]
        public static extern unsafe void glColor3b (sbyte red, sbyte green, sbyte blue);
        [DllImport(DllName)]
        public static extern unsafe void glColor3bv (sbyte* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor3d (double red, double green, double blue);
        [DllImport(DllName)]
        public static extern unsafe void glColor3dv (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor3f (float red, float green, float blue);
        [DllImport(DllName)]
        public static extern unsafe void glColor3fVertex3fSUN (float r, float g, float b, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glColor3fVertex3fvSUN (float* c, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor3fv (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor3hNV (ushort red, ushort green, ushort blue);
        [DllImport(DllName)]
        public static extern unsafe void glColor3hvNV (ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor3i (int red, int green, int blue);
        [DllImport(DllName)]
        public static extern unsafe void glColor3iv (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor3s (short red, short green, short blue);
        [DllImport(DllName)]
        public static extern unsafe void glColor3sv (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor3ub (byte red, byte green, byte blue);
        [DllImport(DllName)]
        public static extern unsafe void glColor3ubv (byte* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor3ui (uint red, uint green, uint blue);
        [DllImport(DllName)]
        public static extern unsafe void glColor3uiv (uint* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor3us (ushort red, ushort green, ushort blue);
        [DllImport(DllName)]
        public static extern unsafe void glColor3usv (ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor3xOES (int red, int green, int blue);
        [DllImport(DllName)]
        public static extern unsafe void glColor3xvOES (int* components);
        [DllImport(DllName)]
        public static extern unsafe void glColor4b (sbyte red, sbyte green, sbyte blue, sbyte alpha);
        [DllImport(DllName)]
        public static extern unsafe void glColor4bv (sbyte* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor4d (double red, double green, double blue, double alpha);
        [DllImport(DllName)]
        public static extern unsafe void glColor4dv (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor4f (float red, float green, float blue, float alpha);
        [DllImport(DllName)]
        public static extern unsafe void glColor4fNormal3fVertex3fSUN (float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glColor4fNormal3fVertex3fvSUN (float* c, float* n, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor4fv (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor4hNV (ushort red, ushort green, ushort blue, ushort alpha);
        [DllImport(DllName)]
        public static extern unsafe void glColor4hvNV (ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor4i (int red, int green, int blue, int alpha);
        [DllImport(DllName)]
        public static extern unsafe void glColor4iv (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor4s (short red, short green, short blue, short alpha);
        [DllImport(DllName)]
        public static extern unsafe void glColor4sv (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor4ub (byte red, byte green, byte blue, byte alpha);
        [DllImport(DllName)]
        public static extern unsafe void glColor4ubVertex2fSUN (byte r, byte g, byte b, byte a, float x, float y);
        [DllImport(DllName)]
        public static extern unsafe void glColor4ubVertex2fvSUN (byte* c, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor4ubVertex3fSUN (byte r, byte g, byte b, byte a, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glColor4ubVertex3fvSUN (byte* c, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor4ubv (byte* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor4ui (uint red, uint green, uint blue, uint alpha);
        [DllImport(DllName)]
        public static extern unsafe void glColor4uiv (uint* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor4us (ushort red, ushort green, ushort blue, ushort alpha);
        [DllImport(DllName)]
        public static extern unsafe void glColor4usv (ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glColor4x (int red, int green, int blue, int alpha);
        [DllImport(DllName)]
        public static extern unsafe void glColor4xOES (int red, int green, int blue, int alpha);
        [DllImport(DllName)]
        public static extern unsafe void glColor4xvOES (int* components);
        [DllImport(DllName)]
        public static extern unsafe void glColorFormatNV (int size, uint type, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glColorFragmentOp1ATI (uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod);
        [DllImport(DllName)]
        public static extern unsafe void glColorFragmentOp2ATI (uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod);
        [DllImport(DllName)]
        public static extern unsafe void glColorFragmentOp3ATI (uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod);
        [DllImport(DllName)]
        public static extern unsafe void glColorMask (bool red, bool green, bool blue, bool alpha);
        [DllImport(DllName)]
        public static extern unsafe void glColorMaskIndexedEXT (uint index, bool r, bool g, bool b, bool a);
        [DllImport(DllName)]
        public static extern unsafe void glColorMaski (uint index, bool r, bool g, bool b, bool a);
        [DllImport(DllName)]
        public static extern unsafe void glColorMaskiEXT (uint index, bool r, bool g, bool b, bool a);
        [DllImport(DllName)]
        public static extern unsafe void glColorMaskiOES (uint index, bool r, bool g, bool b, bool a);
        [DllImport(DllName)]
        public static extern unsafe void glColorMaterial (uint face, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glColorP3ui (uint type, uint color);
        [DllImport(DllName)]
        public static extern unsafe void glColorP3uiv (uint type, uint* color);
        [DllImport(DllName)]
        public static extern unsafe void glColorP4ui (uint type, uint color);
        [DllImport(DllName)]
        public static extern unsafe void glColorP4uiv (uint type, uint* color);
        [DllImport(DllName)]
        public static extern unsafe void glColorPointer (int size, uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glColorPointerEXT (int size, uint type, int stride, int count, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glColorPointerListIBM (int size, uint type, int stride, void* pointer, int ptrstride);
        [DllImport(DllName)]
        public static extern unsafe void glColorPointervINTEL (int size, uint type, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glColorSubTable (uint target, int start, int count, uint format, uint type, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glColorSubTableEXT (uint target, int start, int count, uint format, uint type, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glColorTable (uint target, uint internalformat, int width, uint format, uint type, void* table);
        [DllImport(DllName)]
        public static extern unsafe void glColorTableEXT (uint target, uint internalFormat, int width, uint format, uint type, void* table);
        [DllImport(DllName)]
        public static extern unsafe void glColorTableParameterfv (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glColorTableParameterfvSGI (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glColorTableParameteriv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glColorTableParameterivSGI (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glColorTableSGI (uint target, uint internalformat, int width, uint format, uint type, void* table);
        [DllImport(DllName)]
        public static extern unsafe void glCombinerInputNV (uint stage, uint portion, uint variable, uint input, uint mapping, uint componentUsage);
        [DllImport(DllName)]
        public static extern unsafe void glCombinerOutputNV (uint stage, uint portion, uint abOutput, uint cdOutput, uint sumOutput, uint scale, uint bias, bool abDotProduct, bool cdDotProduct, bool muxSum);
        [DllImport(DllName)]
        public static extern unsafe void glCombinerParameterfNV (uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glCombinerParameterfvNV (uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glCombinerParameteriNV (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glCombinerParameterivNV (uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glCombinerStageParameterfvNV (uint stage, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glCommandListSegmentsNV (uint list, uint segments);
        [DllImport(DllName)]
        public static extern unsafe void glCompileCommandListNV (uint list);
        [DllImport(DllName)]
        public static extern unsafe void glCompileShader (uint shader);
        [DllImport(DllName)]
        public static extern unsafe void glCompileShaderARB (void* shaderObj);
        [DllImport(DllName)]
        public static extern unsafe void glCompileShaderIncludeARB (uint shader, int count, char* path, int* length);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedMultiTexImage1DEXT (uint texunit, uint target, int level, uint internalformat, int width, int border, int imageSize, void* bits);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedMultiTexImage2DEXT (uint texunit, uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* bits);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedMultiTexImage3DEXT (uint texunit, uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* bits);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedMultiTexSubImage1DEXT (uint texunit, uint target, int level, int xoffset, int width, uint format, int imageSize, void* bits);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedMultiTexSubImage2DEXT (uint texunit, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* bits);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedMultiTexSubImage3DEXT (uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* bits);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTexImage1D (uint target, int level, uint internalformat, int width, int border, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTexImage1DARB (uint target, int level, uint internalformat, int width, int border, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTexImage2D (uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTexImage2DARB (uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTexImage3D (uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTexImage3DARB (uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTexImage3DOES (uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTexSubImage1D (uint target, int level, int xoffset, int width, uint format, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTexSubImage1DARB (uint target, int level, int xoffset, int width, uint format, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTexSubImage2D (uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTexSubImage2DARB (uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTexSubImage3D (uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTexSubImage3DARB (uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTexSubImage3DOES (uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTextureImage1DEXT (uint texture, uint target, int level, uint internalformat, int width, int border, int imageSize, void* bits);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTextureImage2DEXT (uint texture, uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* bits);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTextureImage3DEXT (uint texture, uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* bits);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTextureSubImage1D (uint texture, int level, int xoffset, int width, uint format, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTextureSubImage1DEXT (uint texture, uint target, int level, int xoffset, int width, uint format, int imageSize, void* bits);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTextureSubImage2D (uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTextureSubImage2DEXT (uint texture, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* bits);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTextureSubImage3D (uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glCompressedTextureSubImage3DEXT (uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* bits);
        [DllImport(DllName)]
        public static extern unsafe void glConservativeRasterParameterfNV (uint pname, float value);
        [DllImport(DllName)]
        public static extern unsafe void glConvolutionFilter1D (uint target, uint internalformat, int width, uint format, uint type, void* image);
        [DllImport(DllName)]
        public static extern unsafe void glConvolutionFilter1DEXT (uint target, uint internalformat, int width, uint format, uint type, void* image);
        [DllImport(DllName)]
        public static extern unsafe void glConvolutionFilter2D (uint target, uint internalformat, int width, int height, uint format, uint type, void* image);
        [DllImport(DllName)]
        public static extern unsafe void glConvolutionFilter2DEXT (uint target, uint internalformat, int width, int height, uint format, uint type, void* image);
        [DllImport(DllName)]
        public static extern unsafe void glConvolutionParameterf (uint target, uint pname, float @params);
        [DllImport(DllName)]
        public static extern unsafe void glConvolutionParameterfEXT (uint target, uint pname, float @params);
        [DllImport(DllName)]
        public static extern unsafe void glConvolutionParameterfv (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glConvolutionParameterfvEXT (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glConvolutionParameteri (uint target, uint pname, int @params);
        [DllImport(DllName)]
        public static extern unsafe void glConvolutionParameteriEXT (uint target, uint pname, int @params);
        [DllImport(DllName)]
        public static extern unsafe void glConvolutionParameteriv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glConvolutionParameterivEXT (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glConvolutionParameterxOES (uint target, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glConvolutionParameterxvOES (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glCopyBufferSubData (uint readTarget, uint writeTarget, int* readOffset, int* writeOffset, int* size);
        [DllImport(DllName)]
        public static extern unsafe void glCopyBufferSubDataNV (uint readTarget, uint writeTarget, int* readOffset, int* writeOffset, int* size);
        [DllImport(DllName)]
        public static extern unsafe void glCopyColorSubTable (uint target, int start, int x, int y, int width);
        [DllImport(DllName)]
        public static extern unsafe void glCopyColorSubTableEXT (uint target, int start, int x, int y, int width);
        [DllImport(DllName)]
        public static extern unsafe void glCopyColorTable (uint target, uint internalformat, int x, int y, int width);
        [DllImport(DllName)]
        public static extern unsafe void glCopyColorTableSGI (uint target, uint internalformat, int x, int y, int width);
        [DllImport(DllName)]
        public static extern unsafe void glCopyConvolutionFilter1D (uint target, uint internalformat, int x, int y, int width);
        [DllImport(DllName)]
        public static extern unsafe void glCopyConvolutionFilter1DEXT (uint target, uint internalformat, int x, int y, int width);
        [DllImport(DllName)]
        public static extern unsafe void glCopyConvolutionFilter2D (uint target, uint internalformat, int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glCopyConvolutionFilter2DEXT (uint target, uint internalformat, int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glCopyImageSubData (uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
        [DllImport(DllName)]
        public static extern unsafe void glCopyImageSubDataEXT (uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
        [DllImport(DllName)]
        public static extern unsafe void glCopyImageSubDataNV (uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth);
        [DllImport(DllName)]
        public static extern unsafe void glCopyImageSubDataOES (uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);
        [DllImport(DllName)]
        public static extern unsafe void glCopyMultiTexImage1DEXT (uint texunit, uint target, int level, uint internalformat, int x, int y, int width, int border);
        [DllImport(DllName)]
        public static extern unsafe void glCopyMultiTexImage2DEXT (uint texunit, uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
        [DllImport(DllName)]
        public static extern unsafe void glCopyMultiTexSubImage1DEXT (uint texunit, uint target, int level, int xoffset, int x, int y, int width);
        [DllImport(DllName)]
        public static extern unsafe void glCopyMultiTexSubImage2DEXT (uint texunit, uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glCopyMultiTexSubImage3DEXT (uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glCopyNamedBufferSubData (uint readBuffer, uint writeBuffer, int* readOffset, int* writeOffset, int* size);
        [DllImport(DllName)]
        public static extern unsafe void glCopyPathNV (uint resultPath, uint srcPath);
        [DllImport(DllName)]
        public static extern unsafe void glCopyPixels (int x, int y, int width, int height, uint type);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTexImage1D (uint target, int level, uint internalformat, int x, int y, int width, int border);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTexImage1DEXT (uint target, int level, uint internalformat, int x, int y, int width, int border);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTexImage2D (uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTexImage2DEXT (uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTexSubImage1D (uint target, int level, int xoffset, int x, int y, int width);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTexSubImage1DEXT (uint target, int level, int xoffset, int x, int y, int width);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTexSubImage2D (uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTexSubImage2DEXT (uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTexSubImage3D (uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTexSubImage3DEXT (uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTexSubImage3DOES (uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTextureImage1DEXT (uint texture, uint target, int level, uint internalformat, int x, int y, int width, int border);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTextureImage2DEXT (uint texture, uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTextureLevelsAPPLE (uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTextureSubImage1D (uint texture, int level, int xoffset, int x, int y, int width);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTextureSubImage1DEXT (uint texture, uint target, int level, int xoffset, int x, int y, int width);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTextureSubImage2D (uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTextureSubImage2DEXT (uint texture, uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTextureSubImage3D (uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glCopyTextureSubImage3DEXT (uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glCoverFillPathInstancedNV (int numPaths, uint pathNameType, void* paths, uint pathBase, uint coverMode, uint transformType, float* transformValues);
        [DllImport(DllName)]
        public static extern unsafe void glCoverFillPathNV (uint path, uint coverMode);
        [DllImport(DllName)]
        public static extern unsafe void glCoverStrokePathInstancedNV (int numPaths, uint pathNameType, void* paths, uint pathBase, uint coverMode, uint transformType, float* transformValues);
        [DllImport(DllName)]
        public static extern unsafe void glCoverStrokePathNV (uint path, uint coverMode);
        [DllImport(DllName)]
        public static extern unsafe void glCoverageMaskNV (bool mask);
        [DllImport(DllName)]
        public static extern unsafe void glCoverageModulationNV (uint components);
        [DllImport(DllName)]
        public static extern unsafe void glCoverageModulationTableNV (int n, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glCoverageOperationNV (uint operation);
        [DllImport(DllName)]
        public static extern unsafe void glCreateBuffers (int n, uint* buffers);
        [DllImport(DllName)]
        public static extern unsafe void glCreateCommandListsNV (int n, uint* lists);
        [DllImport(DllName)]
        public static extern unsafe void glCreateFramebuffers (int n, uint* framebuffers);
        [DllImport(DllName)]
        public static extern unsafe void glCreatePerfQueryINTEL (uint queryId, uint* queryHandle);
        [DllImport(DllName)]
        public static extern unsafe void glCreateProgram ();
        [DllImport(DllName)]
        public static extern unsafe void glCreateProgramObjectARB ();
        [DllImport(DllName)]
        public static extern unsafe void glCreateProgramPipelines (int n, uint* pipelines);
        [DllImport(DllName)]
        public static extern unsafe void glCreateQueries (uint target, int n, uint* ids);
        [DllImport(DllName)]
        public static extern unsafe void glCreateRenderbuffers (int n, uint* renderbuffers);
        [DllImport(DllName)]
        public static extern unsafe void glCreateSamplers (int n, uint* samplers);
        [DllImport(DllName)]
        public static extern unsafe void glCreateShader (uint type);
        [DllImport(DllName)]
        public static extern unsafe void glCreateShaderObjectARB (uint shaderType);
        [DllImport(DllName)]
        public static extern unsafe void glCreateShaderProgramEXT (uint type, char* @string);
        [DllImport(DllName)]
        public static extern unsafe void glCreateShaderProgramv (uint type, int count, char* strings);
        [DllImport(DllName)]
        public static extern unsafe void glCreateShaderProgramvEXT (uint type, int count, char* strings);
        [DllImport(DllName)]
        public static extern unsafe void glCreateStatesNV (int n, uint* states);
        [DllImport(DllName)]
        public static extern unsafe void glCreateSyncFromCLeventARB (void** context, void** @event, uint flags);
        [DllImport(DllName)]
        public static extern unsafe void glCreateTextures (uint target, int n, uint* textures);
        [DllImport(DllName)]
        public static extern unsafe void glCreateTransformFeedbacks (int n, uint* ids);
        [DllImport(DllName)]
        public static extern unsafe void glCreateVertexArrays (int n, uint* arrays);
        [DllImport(DllName)]
        public static extern unsafe void glCullFace (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glCullParameterdvEXT (uint pname, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glCullParameterfvEXT (uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glCurrentPaletteMatrixARB (int index);
        [DllImport(DllName)]
        public static extern unsafe void glCurrentPaletteMatrixOES (uint matrixpaletteindex);
        [DllImport(DllName)]
        public static extern unsafe void glDebugMessageCallback (GLDEBUGPROC callback, void* userParam);
        [DllImport(DllName)]
        public static extern unsafe void glDebugMessageCallbackAMD (GLDEBUGPROC callback, void* userParam);
        [DllImport(DllName)]
        public static extern unsafe void glDebugMessageCallbackARB (GLDEBUGPROC callback, void* userParam);
        [DllImport(DllName)]
        public static extern unsafe void glDebugMessageCallbackKHR (GLDEBUGPROC callback, void* userParam);
        [DllImport(DllName)]
        public static extern unsafe void glDebugMessageControl (uint source, uint type, uint severity, int count, uint* ids, bool enabled);
        [DllImport(DllName)]
        public static extern unsafe void glDebugMessageControlARB (uint source, uint type, uint severity, int count, uint* ids, bool enabled);
        [DllImport(DllName)]
        public static extern unsafe void glDebugMessageControlKHR (uint source, uint type, uint severity, int count, uint* ids, bool enabled);
        [DllImport(DllName)]
        public static extern unsafe void glDebugMessageEnableAMD (uint category, uint severity, int count, uint* ids, bool enabled);
        [DllImport(DllName)]
        public static extern unsafe void glDebugMessageInsert (uint source, uint type, uint id, uint severity, int length, char* buf);
        [DllImport(DllName)]
        public static extern unsafe void glDebugMessageInsertAMD (uint category, uint severity, uint id, int length, char* buf);
        [DllImport(DllName)]
        public static extern unsafe void glDebugMessageInsertARB (uint source, uint type, uint id, uint severity, int length, char* buf);
        [DllImport(DllName)]
        public static extern unsafe void glDebugMessageInsertKHR (uint source, uint type, uint id, uint severity, int length, char* buf);
        [DllImport(DllName)]
        public static extern unsafe void glDeformSGIX (uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glDeformationMap3dSGIX (uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double* points);
        [DllImport(DllName)]
        public static extern unsafe void glDeformationMap3fSGIX (uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float* points);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteAsyncMarkersSGIX (uint marker, int range);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteBuffers (int n, uint* buffers);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteBuffersARB (int n, uint* buffers);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteCommandListsNV (int n, uint* lists);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteFencesAPPLE (int n, uint* fences);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteFencesNV (int n, uint* fences);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteFragmentShaderATI (uint id);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteFramebuffers (int n, uint* framebuffers);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteFramebuffersEXT (int n, uint* framebuffers);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteFramebuffersOES (int n, uint* framebuffers);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteLists (uint list, int range);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteNamedStringARB (int namelen, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteNamesAMD (uint identifier, uint num, uint* names);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteObjectARB (void* obj);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteOcclusionQueriesNV (int n, uint* ids);
        [DllImport(DllName)]
        public static extern unsafe void glDeletePathsNV (uint path, int range);
        [DllImport(DllName)]
        public static extern unsafe void glDeletePerfMonitorsAMD (int n, uint* monitors);
        [DllImport(DllName)]
        public static extern unsafe void glDeletePerfQueryINTEL (uint queryHandle);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteProgram (uint program);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteProgramPipelines (int n, uint* pipelines);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteProgramPipelinesEXT (int n, uint* pipelines);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteProgramsARB (int n, uint* programs);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteProgramsNV (int n, uint* programs);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteQueries (int n, uint* ids);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteQueriesARB (int n, uint* ids);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteQueriesEXT (int n, uint* ids);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteRenderbuffers (int n, uint* renderbuffers);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteRenderbuffersEXT (int n, uint* renderbuffers);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteRenderbuffersOES (int n, uint* renderbuffers);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteSamplers (int count, uint* samplers);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteShader (uint shader);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteStatesNV (int n, uint* states);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteSync (void* sync);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteSyncAPPLE (void* sync);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteTextures (int n, uint* textures);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteTexturesEXT (int n, uint* textures);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteTransformFeedbacks (int n, uint* ids);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteTransformFeedbacksNV (int n, uint* ids);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteVertexArrays (int n, uint* arrays);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteVertexArraysAPPLE (int n, uint* arrays);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteVertexArraysOES (int n, uint* arrays);
        [DllImport(DllName)]
        public static extern unsafe void glDeleteVertexShaderEXT (uint id);
        [DllImport(DllName)]
        public static extern unsafe void glDepthBoundsEXT (double zmin, double zmax);
        [DllImport(DllName)]
        public static extern unsafe void glDepthBoundsdNV (double zmin, double zmax);
        [DllImport(DllName)]
        public static extern unsafe void glDepthFunc (uint func);
        [DllImport(DllName)]
        public static extern unsafe void glDepthMask (bool flag);
        [DllImport(DllName)]
        public static extern unsafe void glDepthRange (double near, double far);
        [DllImport(DllName)]
        public static extern unsafe void glDepthRangeArrayfvNV (uint first, int count, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glDepthRangeArrayv (uint first, int count, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glDepthRangeIndexed (uint index, double n, double f);
        [DllImport(DllName)]
        public static extern unsafe void glDepthRangeIndexedfNV (uint index, float n, float f);
        [DllImport(DllName)]
        public static extern unsafe void glDepthRangedNV (double zNear, double zFar);
        [DllImport(DllName)]
        public static extern unsafe void glDepthRangef (float n, float f);
        [DllImport(DllName)]
        public static extern unsafe void glDepthRangefOES (float n, float f);
        [DllImport(DllName)]
        public static extern unsafe void glDepthRangex (int n, int f);
        [DllImport(DllName)]
        public static extern unsafe void glDepthRangexOES (int n, int f);
        [DllImport(DllName)]
        public static extern unsafe void glDetachObjectARB (void* containerObj, void* attachedObj);
        [DllImport(DllName)]
        public static extern unsafe void glDetachShader (uint program, uint shader);
        [DllImport(DllName)]
        public static extern unsafe void glDetailTexFuncSGIS (uint target, int n, float* points);
        [DllImport(DllName)]
        public static extern unsafe void glDisable (uint cap);
        [DllImport(DllName)]
        public static extern unsafe void glDisableClientState (uint array);
        [DllImport(DllName)]
        public static extern unsafe void glDisableClientStateIndexedEXT (uint array, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glDisableClientStateiEXT (uint array, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glDisableDriverControlQCOM (uint driverControl);
        [DllImport(DllName)]
        public static extern unsafe void glDisableIndexedEXT (uint target, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glDisableVariantClientStateEXT (uint id);
        [DllImport(DllName)]
        public static extern unsafe void glDisableVertexArrayAttrib (uint vaobj, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glDisableVertexArrayAttribEXT (uint vaobj, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glDisableVertexArrayEXT (uint vaobj, uint array);
        [DllImport(DllName)]
        public static extern unsafe void glDisableVertexAttribAPPLE (uint index, uint pname);
        [DllImport(DllName)]
        public static extern unsafe void glDisableVertexAttribArray (uint index);
        [DllImport(DllName)]
        public static extern unsafe void glDisableVertexAttribArrayARB (uint index);
        [DllImport(DllName)]
        public static extern unsafe void glDisablei (uint target, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glDisableiEXT (uint target, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glDisableiNV (uint target, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glDisableiOES (uint target, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glDiscardFramebufferEXT (uint target, int numAttachments, uint* attachments);
        [DllImport(DllName)]
        public static extern unsafe void glDispatchCompute (uint num_groups_x, uint num_groups_y, uint num_groups_z);
        [DllImport(DllName)]
        public static extern unsafe void glDispatchComputeGroupSizeARB (uint num_groups_x, uint num_groups_y, uint num_groups_z, uint group_size_x, uint group_size_y, uint group_size_z);
        [DllImport(DllName)]
        public static extern unsafe void glDispatchComputeIndirect (int* indirect);
        [DllImport(DllName)]
        public static extern unsafe void glDrawArrays (uint mode, int first, int count);
        [DllImport(DllName)]
        public static extern unsafe void glDrawArraysEXT (uint mode, int first, int count);
        [DllImport(DllName)]
        public static extern unsafe void glDrawArraysIndirect (uint mode, void* indirect);
        [DllImport(DllName)]
        public static extern unsafe void glDrawArraysInstanced (uint mode, int first, int count, int instancecount);
        [DllImport(DllName)]
        public static extern unsafe void glDrawArraysInstancedANGLE (uint mode, int first, int count, int primcount);
        [DllImport(DllName)]
        public static extern unsafe void glDrawArraysInstancedARB (uint mode, int first, int count, int primcount);
        [DllImport(DllName)]
        public static extern unsafe void glDrawArraysInstancedBaseInstance (uint mode, int first, int count, int instancecount, uint baseinstance);
        [DllImport(DllName)]
        public static extern unsafe void glDrawArraysInstancedBaseInstanceEXT (uint mode, int first, int count, int instancecount, uint baseinstance);
        [DllImport(DllName)]
        public static extern unsafe void glDrawArraysInstancedEXT (uint mode, int start, int count, int primcount);
        [DllImport(DllName)]
        public static extern unsafe void glDrawArraysInstancedNV (uint mode, int first, int count, int primcount);
        [DllImport(DllName)]
        public static extern unsafe void glDrawBuffer (uint buf);
        [DllImport(DllName)]
        public static extern unsafe void glDrawBuffers (int n, uint* bufs);
        [DllImport(DllName)]
        public static extern unsafe void glDrawBuffersARB (int n, uint* bufs);
        [DllImport(DllName)]
        public static extern unsafe void glDrawBuffersATI (int n, uint* bufs);
        [DllImport(DllName)]
        public static extern unsafe void glDrawBuffersEXT (int n, uint* bufs);
        [DllImport(DllName)]
        public static extern unsafe void glDrawBuffersIndexedEXT (int n, uint* location, int* indices);
        [DllImport(DllName)]
        public static extern unsafe void glDrawBuffersNV (int n, uint* bufs);
        [DllImport(DllName)]
        public static extern unsafe void glDrawCommandsAddressNV (uint primitiveMode, ulong* indirects, int* sizes, uint count);
        [DllImport(DllName)]
        public static extern unsafe void glDrawCommandsNV (uint primitiveMode, uint buffer, int** indirects, int* sizes, uint count);
        [DllImport(DllName)]
        public static extern unsafe void glDrawCommandsStatesAddressNV (ulong* indirects, int* sizes, uint* states, uint* fbos, uint count);
        [DllImport(DllName)]
        public static extern unsafe void glDrawCommandsStatesNV (uint buffer, int** indirects, int* sizes, uint* states, uint* fbos, uint count);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementArrayAPPLE (uint mode, int first, int count);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementArrayATI (uint mode, int count);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElements (uint mode, int count, uint type, void* indices);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementsBaseVertex (uint mode, int count, uint type, void* indices, int basevertex);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementsBaseVertexEXT (uint mode, int count, uint type, void* indices, int basevertex);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementsBaseVertexOES (uint mode, int count, uint type, void* indices, int basevertex);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementsIndirect (uint mode, uint type, void* indirect);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementsInstanced (uint mode, int count, uint type, void* indices, int instancecount);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementsInstancedANGLE (uint mode, int count, uint type, void* indices, int primcount);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementsInstancedARB (uint mode, int count, uint type, void* indices, int primcount);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementsInstancedBaseInstance (uint mode, int count, uint type, void* indices, int instancecount, uint baseinstance);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementsInstancedBaseInstanceEXT (uint mode, int count, uint type, void* indices, int instancecount, uint baseinstance);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementsInstancedBaseVertex (uint mode, int count, uint type, void* indices, int instancecount, int basevertex);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementsInstancedBaseVertexBaseInstance (uint mode, int count, uint type, void* indices, int instancecount, int basevertex, uint baseinstance);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementsInstancedBaseVertexBaseInstanceEXT (uint mode, int count, uint type, void* indices, int instancecount, int basevertex, uint baseinstance);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementsInstancedBaseVertexEXT (uint mode, int count, uint type, void* indices, int instancecount, int basevertex);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementsInstancedBaseVertexOES (uint mode, int count, uint type, void* indices, int instancecount, int basevertex);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementsInstancedEXT (uint mode, int count, uint type, void* indices, int primcount);
        [DllImport(DllName)]
        public static extern unsafe void glDrawElementsInstancedNV (uint mode, int count, uint type, void* indices, int primcount);
        [DllImport(DllName)]
        public static extern unsafe void glDrawMeshArraysSUN (uint mode, int first, int count, int width);
        [DllImport(DllName)]
        public static extern unsafe void glDrawPixels (int width, int height, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glDrawRangeElementArrayAPPLE (uint mode, uint start, uint end, int first, int count);
        [DllImport(DllName)]
        public static extern unsafe void glDrawRangeElementArrayATI (uint mode, uint start, uint end, int count);
        [DllImport(DllName)]
        public static extern unsafe void glDrawRangeElements (uint mode, uint start, uint end, int count, uint type, void* indices);
        [DllImport(DllName)]
        public static extern unsafe void glDrawRangeElementsBaseVertex (uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex);
        [DllImport(DllName)]
        public static extern unsafe void glDrawRangeElementsBaseVertexEXT (uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex);
        [DllImport(DllName)]
        public static extern unsafe void glDrawRangeElementsBaseVertexOES (uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex);
        [DllImport(DllName)]
        public static extern unsafe void glDrawRangeElementsEXT (uint mode, uint start, uint end, int count, uint type, void* indices);
        [DllImport(DllName)]
        public static extern unsafe void glDrawTexfOES (float x, float y, float z, float width, float height);
        [DllImport(DllName)]
        public static extern unsafe void glDrawTexfvOES (float* coords);
        [DllImport(DllName)]
        public static extern unsafe void glDrawTexiOES (int x, int y, int z, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glDrawTexivOES (int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glDrawTexsOES (short x, short y, short z, short width, short height);
        [DllImport(DllName)]
        public static extern unsafe void glDrawTexsvOES (short* coords);
        [DllImport(DllName)]
        public static extern unsafe void glDrawTextureNV (uint texture, uint sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);
        [DllImport(DllName)]
        public static extern unsafe void glDrawTexxOES (int x, int y, int z, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glDrawTexxvOES (int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glDrawTransformFeedback (uint mode, uint id);
        [DllImport(DllName)]
        public static extern unsafe void glDrawTransformFeedbackInstanced (uint mode, uint id, int instancecount);
        [DllImport(DllName)]
        public static extern unsafe void glDrawTransformFeedbackNV (uint mode, uint id);
        [DllImport(DllName)]
        public static extern unsafe void glDrawTransformFeedbackStream (uint mode, uint id, uint stream);
        [DllImport(DllName)]
        public static extern unsafe void glDrawTransformFeedbackStreamInstanced (uint mode, uint id, uint stream, int instancecount);
        [DllImport(DllName)]
        public static extern unsafe void glEGLImageTargetRenderbufferStorageOES (uint target, void* image);
        [DllImport(DllName)]
        public static extern unsafe void glEGLImageTargetTexture2DOES (uint target, void* image);
        [DllImport(DllName)]
        public static extern unsafe void glEdgeFlag (bool flag);
        [DllImport(DllName)]
        public static extern unsafe void glEdgeFlagFormatNV (int stride);
        [DllImport(DllName)]
        public static extern unsafe void glEdgeFlagPointer (int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glEdgeFlagPointerEXT (int stride, int count, bool* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glEdgeFlagPointerListIBM (int stride, bool* pointer, int ptrstride);
        [DllImport(DllName)]
        public static extern unsafe void glEdgeFlagv (bool* flag);
        [DllImport(DllName)]
        public static extern unsafe void glElementPointerAPPLE (uint type, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glElementPointerATI (uint type, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glEnable (uint cap);
        [DllImport(DllName)]
        public static extern unsafe void glEnableClientState (uint array);
        [DllImport(DllName)]
        public static extern unsafe void glEnableClientStateIndexedEXT (uint array, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glEnableClientStateiEXT (uint array, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glEnableDriverControlQCOM (uint driverControl);
        [DllImport(DllName)]
        public static extern unsafe void glEnableIndexedEXT (uint target, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glEnableVariantClientStateEXT (uint id);
        [DllImport(DllName)]
        public static extern unsafe void glEnableVertexArrayAttrib (uint vaobj, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glEnableVertexArrayAttribEXT (uint vaobj, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glEnableVertexArrayEXT (uint vaobj, uint array);
        [DllImport(DllName)]
        public static extern unsafe void glEnableVertexAttribAPPLE (uint index, uint pname);
        [DllImport(DllName)]
        public static extern unsafe void glEnableVertexAttribArray (uint index);
        [DllImport(DllName)]
        public static extern unsafe void glEnableVertexAttribArrayARB (uint index);
        [DllImport(DllName)]
        public static extern unsafe void glEnablei (uint target, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glEnableiEXT (uint target, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glEnableiNV (uint target, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glEnableiOES (uint target, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glEnd ();
        [DllImport(DllName)]
        public static extern unsafe void glEndConditionalRender ();
        [DllImport(DllName)]
        public static extern unsafe void glEndConditionalRenderNV ();
        [DllImport(DllName)]
        public static extern unsafe void glEndConditionalRenderNVX ();
        [DllImport(DllName)]
        public static extern unsafe void glEndFragmentShaderATI ();
        [DllImport(DllName)]
        public static extern unsafe void glEndList ();
        [DllImport(DllName)]
        public static extern unsafe void glEndOcclusionQueryNV ();
        [DllImport(DllName)]
        public static extern unsafe void glEndPerfMonitorAMD (uint monitor);
        [DllImport(DllName)]
        public static extern unsafe void glEndPerfQueryINTEL (uint queryHandle);
        [DllImport(DllName)]
        public static extern unsafe void glEndQuery (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glEndQueryARB (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glEndQueryEXT (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glEndQueryIndexed (uint target, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glEndTilingQCOM (uint preserveMask);
        [DllImport(DllName)]
        public static extern unsafe void glEndTransformFeedback ();
        [DllImport(DllName)]
        public static extern unsafe void glEndTransformFeedbackEXT ();
        [DllImport(DllName)]
        public static extern unsafe void glEndTransformFeedbackNV ();
        [DllImport(DllName)]
        public static extern unsafe void glEndVertexShaderEXT ();
        [DllImport(DllName)]
        public static extern unsafe void glEndVideoCaptureNV (uint video_capture_slot);
        [DllImport(DllName)]
        public static extern unsafe void glEvalCoord1d (double u);
        [DllImport(DllName)]
        public static extern unsafe void glEvalCoord1dv (double* u);
        [DllImport(DllName)]
        public static extern unsafe void glEvalCoord1f (float u);
        [DllImport(DllName)]
        public static extern unsafe void glEvalCoord1fv (float* u);
        [DllImport(DllName)]
        public static extern unsafe void glEvalCoord1xOES (int u);
        [DllImport(DllName)]
        public static extern unsafe void glEvalCoord1xvOES (int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glEvalCoord2d (double u, double v);
        [DllImport(DllName)]
        public static extern unsafe void glEvalCoord2dv (double* u);
        [DllImport(DllName)]
        public static extern unsafe void glEvalCoord2f (float u, float v);
        [DllImport(DllName)]
        public static extern unsafe void glEvalCoord2fv (float* u);
        [DllImport(DllName)]
        public static extern unsafe void glEvalCoord2xOES (int u, int v);
        [DllImport(DllName)]
        public static extern unsafe void glEvalCoord2xvOES (int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glEvalMapsNV (uint target, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glEvalMesh1 (uint mode, int i1, int i2);
        [DllImport(DllName)]
        public static extern unsafe void glEvalMesh2 (uint mode, int i1, int i2, int j1, int j2);
        [DllImport(DllName)]
        public static extern unsafe void glEvalPoint1 (int i);
        [DllImport(DllName)]
        public static extern unsafe void glEvalPoint2 (int i, int j);
        [DllImport(DllName)]
        public static extern unsafe void glEvaluateDepthValuesARB ();
        [DllImport(DllName)]
        public static extern unsafe void glExecuteProgramNV (uint target, uint id, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glExtGetBufferPointervQCOM (uint target, void* @params);
        [DllImport(DllName)]
        public static extern unsafe void glExtGetBuffersQCOM (uint* buffers, int maxBuffers, int* numBuffers);
        [DllImport(DllName)]
        public static extern unsafe void glExtGetFramebuffersQCOM (uint* framebuffers, int maxFramebuffers, int* numFramebuffers);
        [DllImport(DllName)]
        public static extern unsafe void glExtGetProgramBinarySourceQCOM (uint program, uint shadertype, char* source, int* length);
        [DllImport(DllName)]
        public static extern unsafe void glExtGetProgramsQCOM (uint* programs, int maxPrograms, int* numPrograms);
        [DllImport(DllName)]
        public static extern unsafe void glExtGetRenderbuffersQCOM (uint* renderbuffers, int maxRenderbuffers, int* numRenderbuffers);
        [DllImport(DllName)]
        public static extern unsafe void glExtGetShadersQCOM (uint* shaders, int maxShaders, int* numShaders);
        [DllImport(DllName)]
        public static extern unsafe void glExtGetTexLevelParameterivQCOM (uint texture, uint face, int level, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glExtGetTexSubImageQCOM (uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* texels);
        [DllImport(DllName)]
        public static extern unsafe void glExtGetTexturesQCOM (uint* textures, int maxTextures, int* numTextures);
        [DllImport(DllName)]
        public static extern unsafe void glExtIsProgramBinaryQCOM (uint program);
        [DllImport(DllName)]
        public static extern unsafe void glExtTexObjectStateOverrideiQCOM (uint target, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glExtractComponentEXT (uint res, uint src, uint num);
        [DllImport(DllName)]
        public static extern unsafe void glFeedbackBuffer (int size, uint type, float* buffer);
        [DllImport(DllName)]
        public static extern unsafe void glFeedbackBufferxOES (int n, uint type, int* buffer);
        [DllImport(DllName)]
        public static extern unsafe void glFenceSync (uint condition, uint flags);
        [DllImport(DllName)]
        public static extern unsafe void glFenceSyncAPPLE (uint condition, uint flags);
        [DllImport(DllName)]
        public static extern unsafe void glFinalCombinerInputNV (uint variable, uint input, uint mapping, uint componentUsage);
        [DllImport(DllName)]
        public static extern unsafe void glFinish ();
        [DllImport(DllName)]
        public static extern unsafe void glFinishAsyncSGIX (uint* markerp);
        [DllImport(DllName)]
        public static extern unsafe void glFinishFenceAPPLE (uint fence);
        [DllImport(DllName)]
        public static extern unsafe void glFinishFenceNV (uint fence);
        [DllImport(DllName)]
        public static extern unsafe void glFinishObjectAPPLE (uint @object, int name);
        [DllImport(DllName)]
        public static extern unsafe void glFinishTextureSUNX ();
        [DllImport(DllName)]
        public static extern unsafe void glFlush ();
        [DllImport(DllName)]
        public static extern unsafe void glFlushMappedBufferRange (uint target, int* offset, int* length);
        [DllImport(DllName)]
        public static extern unsafe void glFlushMappedBufferRangeAPPLE (uint target, int* offset, int* size);
        [DllImport(DllName)]
        public static extern unsafe void glFlushMappedBufferRangeEXT (uint target, int* offset, int* length);
        [DllImport(DllName)]
        public static extern unsafe void glFlushMappedNamedBufferRange (uint buffer, int* offset, int* length);
        [DllImport(DllName)]
        public static extern unsafe void glFlushMappedNamedBufferRangeEXT (uint buffer, int* offset, int* length);
        [DllImport(DllName)]
        public static extern unsafe void glFlushPixelDataRangeNV (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glFlushRasterSGIX ();
        [DllImport(DllName)]
        public static extern unsafe void glFlushStaticDataIBM (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glFlushVertexArrayRangeAPPLE (int length, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glFlushVertexArrayRangeNV ();
        [DllImport(DllName)]
        public static extern unsafe void glFogCoordFormatNV (uint type, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glFogCoordPointer (uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glFogCoordPointerEXT (uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glFogCoordPointerListIBM (uint type, int stride, void* pointer, int ptrstride);
        [DllImport(DllName)]
        public static extern unsafe void glFogCoordd (double coord);
        [DllImport(DllName)]
        public static extern unsafe void glFogCoorddEXT (double coord);
        [DllImport(DllName)]
        public static extern unsafe void glFogCoorddv (double* coord);
        [DllImport(DllName)]
        public static extern unsafe void glFogCoorddvEXT (double* coord);
        [DllImport(DllName)]
        public static extern unsafe void glFogCoordf (float coord);
        [DllImport(DllName)]
        public static extern unsafe void glFogCoordfEXT (float coord);
        [DllImport(DllName)]
        public static extern unsafe void glFogCoordfv (float* coord);
        [DllImport(DllName)]
        public static extern unsafe void glFogCoordfvEXT (float* coord);
        [DllImport(DllName)]
        public static extern unsafe void glFogCoordhNV (ushort fog);
        [DllImport(DllName)]
        public static extern unsafe void glFogCoordhvNV (ushort* fog);
        [DllImport(DllName)]
        public static extern unsafe void glFogFuncSGIS (int n, float* points);
        [DllImport(DllName)]
        public static extern unsafe void glFogf (uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glFogfv (uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glFogi (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glFogiv (uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glFogx (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glFogxOES (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glFogxv (uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glFogxvOES (uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glFragmentColorMaterialSGIX (uint face, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glFragmentCoverageColorNV (uint color);
        [DllImport(DllName)]
        public static extern unsafe void glFragmentLightModelfSGIX (uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glFragmentLightModelfvSGIX (uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glFragmentLightModeliSGIX (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glFragmentLightModelivSGIX (uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glFragmentLightfSGIX (uint light, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glFragmentLightfvSGIX (uint light, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glFragmentLightiSGIX (uint light, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glFragmentLightivSGIX (uint light, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glFragmentMaterialfSGIX (uint face, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glFragmentMaterialfvSGIX (uint face, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glFragmentMaterialiSGIX (uint face, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glFragmentMaterialivSGIX (uint face, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glFrameTerminatorGREMEDY ();
        [DllImport(DllName)]
        public static extern unsafe void glFrameZoomSGIX (int factor);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferDrawBufferEXT (uint framebuffer, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferDrawBuffersEXT (uint framebuffer, int n, uint* bufs);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferParameteri (uint target, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferPixelLocalStorageSizeEXT (uint target, int size);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferReadBufferEXT (uint framebuffer, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferRenderbuffer (uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferRenderbufferEXT (uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferRenderbufferOES (uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferSampleLocationsfvARB (uint target, uint start, int count, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferSampleLocationsfvNV (uint target, uint start, int count, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTexture (uint target, uint attachment, uint texture, int level);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTexture1D (uint target, uint attachment, uint textarget, uint texture, int level);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTexture1DEXT (uint target, uint attachment, uint textarget, uint texture, int level);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTexture2D (uint target, uint attachment, uint textarget, uint texture, int level);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTexture2DEXT (uint target, uint attachment, uint textarget, uint texture, int level);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTexture2DDownsampleIMG (uint target, uint attachment, uint textarget, uint texture, int level, int xscale, int yscale);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTexture2DMultisampleEXT (uint target, uint attachment, uint textarget, uint texture, int level, int samples);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTexture2DMultisampleIMG (uint target, uint attachment, uint textarget, uint texture, int level, int samples);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTexture2DOES (uint target, uint attachment, uint textarget, uint texture, int level);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTexture3D (uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTexture3DEXT (uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTexture3DOES (uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTextureARB (uint target, uint attachment, uint texture, int level);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTextureEXT (uint target, uint attachment, uint texture, int level);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTextureFaceARB (uint target, uint attachment, uint texture, int level, uint face);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTextureFaceEXT (uint target, uint attachment, uint texture, int level, uint face);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTextureLayer (uint target, uint attachment, uint texture, int level, int layer);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTextureLayerARB (uint target, uint attachment, uint texture, int level, int layer);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTextureLayerEXT (uint target, uint attachment, uint texture, int level, int layer);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTextureLayerDownsampleIMG (uint target, uint attachment, uint texture, int level, int layer, int xscale, int yscale);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTextureMultisampleMultiviewOVR (uint target, uint attachment, uint texture, int level, int samples, int baseViewIndex, int numViews);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTextureMultiviewOVR (uint target, uint attachment, uint texture, int level, int baseViewIndex, int numViews);
        [DllImport(DllName)]
        public static extern unsafe void glFramebufferTextureOES (uint target, uint attachment, uint texture, int level);
        [DllImport(DllName)]
        public static extern unsafe void glFreeObjectBufferATI (uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glFrontFace (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glFrustum (double left, double right, double bottom, double top, double zNear, double zFar);
        [DllImport(DllName)]
        public static extern unsafe void glFrustumf (float l, float r, float b, float t, float n, float f);
        [DllImport(DllName)]
        public static extern unsafe void glFrustumfOES (float l, float r, float b, float t, float n, float f);
        [DllImport(DllName)]
        public static extern unsafe void glFrustumx (int l, int r, int b, int t, int n, int f);
        [DllImport(DllName)]
        public static extern unsafe void glFrustumxOES (int l, int r, int b, int t, int n, int f);
        [DllImport(DllName)]
        public static extern unsafe void glGenAsyncMarkersSGIX (int range);
        [DllImport(DllName)]
        public static extern unsafe void glGenBuffers (int n, uint* buffers);
        [DllImport(DllName)]
        public static extern unsafe void glGenBuffersARB (int n, uint* buffers);
        [DllImport(DllName)]
        public static extern unsafe void glGenFencesAPPLE (int n, uint* fences);
        [DllImport(DllName)]
        public static extern unsafe void glGenFencesNV (int n, uint* fences);
        [DllImport(DllName)]
        public static extern unsafe void glGenFragmentShadersATI (uint range);
        [DllImport(DllName)]
        public static extern unsafe void glGenFramebuffers (int n, uint* framebuffers);
        [DllImport(DllName)]
        public static extern unsafe void glGenFramebuffersEXT (int n, uint* framebuffers);
        [DllImport(DllName)]
        public static extern unsafe void glGenFramebuffersOES (int n, uint* framebuffers);
        [DllImport(DllName)]
        public static extern unsafe void glGenLists (int range);
        [DllImport(DllName)]
        public static extern unsafe void glGenNamesAMD (uint identifier, uint num, uint* names);
        [DllImport(DllName)]
        public static extern unsafe void glGenOcclusionQueriesNV (int n, uint* ids);
        [DllImport(DllName)]
        public static extern unsafe void glGenPathsNV (int range);
        [DllImport(DllName)]
        public static extern unsafe void glGenPerfMonitorsAMD (int n, uint* monitors);
        [DllImport(DllName)]
        public static extern unsafe void glGenProgramPipelines (int n, uint* pipelines);
        [DllImport(DllName)]
        public static extern unsafe void glGenProgramPipelinesEXT (int n, uint* pipelines);
        [DllImport(DllName)]
        public static extern unsafe void glGenProgramsARB (int n, uint* programs);
        [DllImport(DllName)]
        public static extern unsafe void glGenProgramsNV (int n, uint* programs);
        [DllImport(DllName)]
        public static extern unsafe void glGenQueries (int n, uint* ids);
        [DllImport(DllName)]
        public static extern unsafe void glGenQueriesARB (int n, uint* ids);
        [DllImport(DllName)]
        public static extern unsafe void glGenQueriesEXT (int n, uint* ids);
        [DllImport(DllName)]
        public static extern unsafe void glGenRenderbuffers (int n, uint* renderbuffers);
        [DllImport(DllName)]
        public static extern unsafe void glGenRenderbuffersEXT (int n, uint* renderbuffers);
        [DllImport(DllName)]
        public static extern unsafe void glGenRenderbuffersOES (int n, uint* renderbuffers);
        [DllImport(DllName)]
        public static extern unsafe void glGenSamplers (int count, uint* samplers);
        [DllImport(DllName)]
        public static extern unsafe void glGenSymbolsEXT (uint datatype, uint storagetype, uint range, uint components);
        [DllImport(DllName)]
        public static extern unsafe void glGenTextures (int n, uint* textures);
        [DllImport(DllName)]
        public static extern unsafe void glGenTexturesEXT (int n, uint* textures);
        [DllImport(DllName)]
        public static extern unsafe void glGenTransformFeedbacks (int n, uint* ids);
        [DllImport(DllName)]
        public static extern unsafe void glGenTransformFeedbacksNV (int n, uint* ids);
        [DllImport(DllName)]
        public static extern unsafe void glGenVertexArrays (int n, uint* arrays);
        [DllImport(DllName)]
        public static extern unsafe void glGenVertexArraysAPPLE (int n, uint* arrays);
        [DllImport(DllName)]
        public static extern unsafe void glGenVertexArraysOES (int n, uint* arrays);
        [DllImport(DllName)]
        public static extern unsafe void glGenVertexShadersEXT (uint range);
        [DllImport(DllName)]
        public static extern unsafe void glGenerateMipmap (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glGenerateMipmapEXT (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glGenerateMipmapOES (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glGenerateMultiTexMipmapEXT (uint texunit, uint target);
        [DllImport(DllName)]
        public static extern unsafe void glGenerateTextureMipmap (uint texture);
        [DllImport(DllName)]
        public static extern unsafe void glGenerateTextureMipmapEXT (uint texture, uint target);
        [DllImport(DllName)]
        public static extern unsafe void glGetActiveAtomicCounterBufferiv (uint program, uint bufferIndex, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetActiveAttrib (uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetActiveAttribARB (void* programObj, uint index, int maxLength, int* length, int* size, uint* type, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetActiveSubroutineName (uint program, uint shadertype, uint index, int bufsize, int* length, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetActiveSubroutineUniformName (uint program, uint shadertype, uint index, int bufsize, int* length, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetActiveSubroutineUniformiv (uint program, uint shadertype, uint index, uint pname, int* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetActiveUniform (uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetActiveUniformARB (void* programObj, uint index, int maxLength, int* length, int* size, uint* type, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetActiveUniformBlockName (uint program, uint uniformBlockIndex, int bufSize, int* length, char* uniformBlockName);
        [DllImport(DllName)]
        public static extern unsafe void glGetActiveUniformBlockiv (uint program, uint uniformBlockIndex, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetActiveUniformName (uint program, uint uniformIndex, int bufSize, int* length, char* uniformName);
        [DllImport(DllName)]
        public static extern unsafe void glGetActiveUniformsiv (uint program, int uniformCount, uint* uniformIndices, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetActiveVaryingNV (uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetArrayObjectfvATI (uint array, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetArrayObjectivATI (uint array, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetAttachedObjectsARB (void* containerObj, int maxCount, int* count, void** obj);
        [DllImport(DllName)]
        public static extern unsafe void glGetAttachedShaders (uint program, int maxCount, int* count, uint* shaders);
        [DllImport(DllName)]
        public static extern unsafe void glGetAttribLocation (uint program, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetAttribLocationARB (void* programObj, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetBooleanIndexedvEXT (uint target, uint index, bool* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetBooleani_v (uint target, uint index, bool* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetBooleanv (uint pname, bool* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetBufferParameteri64v (uint target, uint pname, long* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetBufferParameteriv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetBufferParameterivARB (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetBufferParameterui64vNV (uint target, uint pname, ulong* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetBufferPointerv (uint target, uint pname, void* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetBufferPointervARB (uint target, uint pname, void* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetBufferPointervOES (uint target, uint pname, void* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetBufferSubData (uint target, int* offset, int* size, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetBufferSubDataARB (uint target, int* offset, int* size, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetClipPlane (uint plane, double* equation);
        [DllImport(DllName)]
        public static extern unsafe void glGetClipPlanef (uint plane, float* equation);
        [DllImport(DllName)]
        public static extern unsafe void glGetClipPlanefOES (uint plane, float* equation);
        [DllImport(DllName)]
        public static extern unsafe void glGetClipPlanex (uint plane, int* equation);
        [DllImport(DllName)]
        public static extern unsafe void glGetClipPlanexOES (uint plane, int* equation);
        [DllImport(DllName)]
        public static extern unsafe void glGetColorTable (uint target, uint format, uint type, void* table);
        [DllImport(DllName)]
        public static extern unsafe void glGetColorTableEXT (uint target, uint format, uint type, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetColorTableParameterfv (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetColorTableParameterfvEXT (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetColorTableParameterfvSGI (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetColorTableParameteriv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetColorTableParameterivEXT (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetColorTableParameterivSGI (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetColorTableSGI (uint target, uint format, uint type, void* table);
        [DllImport(DllName)]
        public static extern unsafe void glGetCombinerInputParameterfvNV (uint stage, uint portion, uint variable, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetCombinerInputParameterivNV (uint stage, uint portion, uint variable, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetCombinerOutputParameterfvNV (uint stage, uint portion, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetCombinerOutputParameterivNV (uint stage, uint portion, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetCombinerStageParameterfvNV (uint stage, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetCommandHeaderNV (uint tokenID, uint size);
        [DllImport(DllName)]
        public static extern unsafe void glGetCompressedMultiTexImageEXT (uint texunit, uint target, int lod, void* img);
        [DllImport(DllName)]
        public static extern unsafe void glGetCompressedTexImage (uint target, int level, void* img);
        [DllImport(DllName)]
        public static extern unsafe void glGetCompressedTexImageARB (uint target, int level, void* img);
        [DllImport(DllName)]
        public static extern unsafe void glGetCompressedTextureImage (uint texture, int level, int bufSize, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glGetCompressedTextureImageEXT (uint texture, uint target, int lod, void* img);
        [DllImport(DllName)]
        public static extern unsafe void glGetCompressedTextureSubImage (uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glGetConvolutionFilter (uint target, uint format, uint type, void* image);
        [DllImport(DllName)]
        public static extern unsafe void glGetConvolutionFilterEXT (uint target, uint format, uint type, void* image);
        [DllImport(DllName)]
        public static extern unsafe void glGetConvolutionParameterfv (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetConvolutionParameterfvEXT (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetConvolutionParameteriv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetConvolutionParameterivEXT (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetConvolutionParameterxvOES (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetCoverageModulationTableNV (int bufsize, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glGetDebugMessageLog (uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, char* messageLog);
        [DllImport(DllName)]
        public static extern unsafe void glGetDebugMessageLogAMD (uint count, int bufsize, uint* categories, uint* severities, uint* ids, int* lengths, char* message);
        [DllImport(DllName)]
        public static extern unsafe void glGetDebugMessageLogARB (uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, char* messageLog);
        [DllImport(DllName)]
        public static extern unsafe void glGetDebugMessageLogKHR (uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, char* messageLog);
        [DllImport(DllName)]
        public static extern unsafe void glGetDetailTexFuncSGIS (uint target, float* points);
        [DllImport(DllName)]
        public static extern unsafe void glGetDoubleIndexedvEXT (uint target, uint index, double* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetDoublei_v (uint target, uint index, double* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetDoublei_vEXT (uint pname, uint index, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetDoublev (uint pname, double* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetDriverControlStringQCOM (uint driverControl, int bufSize, int* length, char* driverControlString);
        [DllImport(DllName)]
        public static extern unsafe void glGetDriverControlsQCOM (int* num, int size, uint* driverControls);
        [DllImport(DllName)]
        public static extern unsafe void glGetError ();
        [DllImport(DllName)]
        public static extern unsafe void glGetFenceivNV (uint fence, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetFinalCombinerInputParameterfvNV (uint variable, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetFinalCombinerInputParameterivNV (uint variable, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetFirstPerfQueryIdINTEL (uint* queryId);
        [DllImport(DllName)]
        public static extern unsafe void glGetFixedv (uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetFixedvOES (uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetFloatIndexedvEXT (uint target, uint index, float* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetFloati_v (uint target, uint index, float* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetFloati_vEXT (uint pname, uint index, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetFloati_vNV (uint target, uint index, float* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetFloatv (uint pname, float* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetFogFuncSGIS (float* points);
        [DllImport(DllName)]
        public static extern unsafe void glGetFragDataIndex (uint program, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetFragDataIndexEXT (uint program, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetFragDataLocation (uint program, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetFragDataLocationEXT (uint program, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetFragmentLightfvSGIX (uint light, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetFragmentLightivSGIX (uint light, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetFragmentMaterialfvSGIX (uint face, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetFragmentMaterialivSGIX (uint face, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetFramebufferAttachmentParameteriv (uint target, uint attachment, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetFramebufferAttachmentParameterivEXT (uint target, uint attachment, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetFramebufferAttachmentParameterivOES (uint target, uint attachment, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetFramebufferParameteriv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetFramebufferParameterivEXT (uint framebuffer, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetFramebufferPixelLocalStorageSizeEXT (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glGetGraphicsResetStatus ();
        [DllImport(DllName)]
        public static extern unsafe void glGetGraphicsResetStatusARB ();
        [DllImport(DllName)]
        public static extern unsafe void glGetGraphicsResetStatusEXT ();
        [DllImport(DllName)]
        public static extern unsafe void glGetGraphicsResetStatusKHR ();
        [DllImport(DllName)]
        public static extern unsafe void glGetHandleARB (uint pname);
        [DllImport(DllName)]
        public static extern unsafe void glGetHistogram (uint target, bool reset, uint format, uint type, void* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetHistogramEXT (uint target, bool reset, uint format, uint type, void* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetHistogramParameterfv (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetHistogramParameterfvEXT (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetHistogramParameteriv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetHistogramParameterivEXT (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetHistogramParameterxvOES (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetImageHandleARB (uint texture, int level, bool layered, int layer, uint format);
        [DllImport(DllName)]
        public static extern unsafe void glGetImageHandleNV (uint texture, int level, bool layered, int layer, uint format);
        [DllImport(DllName)]
        public static extern unsafe void glGetImageTransformParameterfvHP (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetImageTransformParameterivHP (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetInfoLogARB (void* obj, int maxLength, int* length, char* infoLog);
        [DllImport(DllName)]
        public static extern unsafe void glGetInstrumentsSGIX ();
        [DllImport(DllName)]
        public static extern unsafe void glGetInteger64i_v (uint target, uint index, long* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetInteger64v (uint pname, long* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetInteger64vAPPLE (uint pname, long* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetIntegerIndexedvEXT (uint target, uint index, int* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetIntegeri_v (uint target, uint index, int* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetIntegeri_vEXT (uint target, uint index, int* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetIntegerui64i_vNV (uint value, uint index, ulong* result);
        [DllImport(DllName)]
        public static extern unsafe void glGetIntegerui64vNV (uint value, ulong* result);
        [DllImport(DllName)]
        public static extern unsafe void glGetIntegerv (uint pname, int* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetInternalformatSampleivNV (uint target, uint internalformat, int samples, uint pname, int bufSize, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetInternalformati64v (uint target, uint internalformat, uint pname, int bufSize, long* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetInternalformativ (uint target, uint internalformat, uint pname, int bufSize, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetInvariantBooleanvEXT (uint id, uint value, bool* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetInvariantFloatvEXT (uint id, uint value, float* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetInvariantIntegervEXT (uint id, uint value, int* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetLightfv (uint light, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetLightiv (uint light, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetLightxOES (uint light, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetLightxv (uint light, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetLightxvOES (uint light, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetListParameterfvSGIX (uint list, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetListParameterivSGIX (uint list, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetLocalConstantBooleanvEXT (uint id, uint value, bool* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetLocalConstantFloatvEXT (uint id, uint value, float* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetLocalConstantIntegervEXT (uint id, uint value, int* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetMapAttribParameterfvNV (uint target, uint index, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMapAttribParameterivNV (uint target, uint index, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMapControlPointsNV (uint target, uint index, uint type, int ustride, int vstride, bool packed, void* points);
        [DllImport(DllName)]
        public static extern unsafe void glGetMapParameterfvNV (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMapParameterivNV (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMapdv (uint target, uint query, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glGetMapfv (uint target, uint query, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glGetMapiv (uint target, uint query, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glGetMapxvOES (uint target, uint query, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glGetMaterialfv (uint face, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMaterialiv (uint face, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMaterialxOES (uint face, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glGetMaterialxv (uint face, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMaterialxvOES (uint face, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMinmax (uint target, bool reset, uint format, uint type, void* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetMinmaxEXT (uint target, bool reset, uint format, uint type, void* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetMinmaxParameterfv (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMinmaxParameterfvEXT (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMinmaxParameteriv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMinmaxParameterivEXT (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMultiTexEnvfvEXT (uint texunit, uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMultiTexEnvivEXT (uint texunit, uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMultiTexGendvEXT (uint texunit, uint coord, uint pname, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMultiTexGenfvEXT (uint texunit, uint coord, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMultiTexGenivEXT (uint texunit, uint coord, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMultiTexImageEXT (uint texunit, uint target, int level, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glGetMultiTexLevelParameterfvEXT (uint texunit, uint target, int level, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMultiTexLevelParameterivEXT (uint texunit, uint target, int level, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMultiTexParameterIivEXT (uint texunit, uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMultiTexParameterIuivEXT (uint texunit, uint target, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMultiTexParameterfvEXT (uint texunit, uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMultiTexParameterivEXT (uint texunit, uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetMultisamplefv (uint pname, uint index, float* val);
        [DllImport(DllName)]
        public static extern unsafe void glGetMultisamplefvNV (uint pname, uint index, float* val);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedBufferParameteri64v (uint buffer, uint pname, long* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedBufferParameteriv (uint buffer, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedBufferParameterivEXT (uint buffer, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedBufferParameterui64vNV (uint buffer, uint pname, ulong* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedBufferPointerv (uint buffer, uint pname, void* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedBufferPointervEXT (uint buffer, uint pname, void* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedBufferSubData (uint buffer, int* offset, int* size, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedBufferSubDataEXT (uint buffer, int* offset, int* size, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedFramebufferAttachmentParameteriv (uint framebuffer, uint attachment, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedFramebufferAttachmentParameterivEXT (uint framebuffer, uint attachment, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedFramebufferParameteriv (uint framebuffer, uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedFramebufferParameterivEXT (uint framebuffer, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedProgramLocalParameterIivEXT (uint program, uint target, uint index, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedProgramLocalParameterIuivEXT (uint program, uint target, uint index, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedProgramLocalParameterdvEXT (uint program, uint target, uint index, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedProgramLocalParameterfvEXT (uint program, uint target, uint index, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedProgramStringEXT (uint program, uint target, uint pname, void* @string);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedProgramivEXT (uint program, uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedRenderbufferParameteriv (uint renderbuffer, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedRenderbufferParameterivEXT (uint renderbuffer, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedStringARB (int namelen, char* name, int bufSize, int* stringlen, char* @string);
        [DllImport(DllName)]
        public static extern unsafe void glGetNamedStringivARB (int namelen, char* name, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetNextPerfQueryIdINTEL (uint queryId, uint* nextQueryId);
        [DllImport(DllName)]
        public static extern unsafe void glGetObjectBufferfvATI (uint buffer, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetObjectBufferivATI (uint buffer, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetObjectLabel (uint identifier, uint name, int bufSize, int* length, char* label);
        [DllImport(DllName)]
        public static extern unsafe void glGetObjectLabelEXT (uint type, uint @object, int bufSize, int* length, char* label);
        [DllImport(DllName)]
        public static extern unsafe void glGetObjectLabelKHR (uint identifier, uint name, int bufSize, int* length, char* label);
        [DllImport(DllName)]
        public static extern unsafe void glGetObjectParameterfvARB (void* obj, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetObjectParameterivAPPLE (uint objectType, uint name, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetObjectParameterivARB (void* obj, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetObjectPtrLabel (void* ptr, int bufSize, int* length, char* label);
        [DllImport(DllName)]
        public static extern unsafe void glGetObjectPtrLabelKHR (void* ptr, int bufSize, int* length, char* label);
        [DllImport(DllName)]
        public static extern unsafe void glGetOcclusionQueryivNV (uint id, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetOcclusionQueryuivNV (uint id, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetPathColorGenfvNV (uint color, uint pname, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glGetPathColorGenivNV (uint color, uint pname, int* value);
        [DllImport(DllName)]
        public static extern unsafe void glGetPathCommandsNV (uint path, byte* commands);
        [DllImport(DllName)]
        public static extern unsafe void glGetPathCoordsNV (uint path, float* coords);
        [DllImport(DllName)]
        public static extern unsafe void glGetPathDashArrayNV (uint path, float* dashArray);
        [DllImport(DllName)]
        public static extern unsafe void glGetPathLengthNV (uint path, int startSegment, int numSegments);
        [DllImport(DllName)]
        public static extern unsafe void glGetPathMetricRangeNV (uint metricQueryMask, uint firstPathName, int numPaths, int stride, float* metrics);
        [DllImport(DllName)]
        public static extern unsafe void glGetPathMetricsNV (uint metricQueryMask, int numPaths, uint pathNameType, void* paths, uint pathBase, int stride, float* metrics);
        [DllImport(DllName)]
        public static extern unsafe void glGetPathParameterfvNV (uint path, uint pname, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glGetPathParameterivNV (uint path, uint pname, int* value);
        [DllImport(DllName)]
        public static extern unsafe void glGetPathSpacingNV (uint pathListMode, int numPaths, uint pathNameType, void* paths, uint pathBase, float advanceScale, float kerningScale, uint transformType, float* returnedSpacing);
        [DllImport(DllName)]
        public static extern unsafe void glGetPathTexGenfvNV (uint texCoordSet, uint pname, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glGetPathTexGenivNV (uint texCoordSet, uint pname, int* value);
        [DllImport(DllName)]
        public static extern unsafe void glGetPerfCounterInfoINTEL (uint queryId, uint counterId, uint counterNameLength, char* counterName, uint counterDescLength, char* counterDesc, uint* counterOffset, uint* counterDataSize, uint* counterTypeEnum, uint* counterDataTypeEnum, ulong* rawCounterMaxValue);
        [DllImport(DllName)]
        public static extern unsafe void glGetPerfMonitorCounterDataAMD (uint monitor, uint pname, int dataSize, uint* data, int* bytesWritten);
        [DllImport(DllName)]
        public static extern unsafe void glGetPerfMonitorCounterInfoAMD (uint group, uint counter, uint pname, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetPerfMonitorCounterStringAMD (uint group, uint counter, int bufSize, int* length, char* counterString);
        [DllImport(DllName)]
        public static extern unsafe void glGetPerfMonitorCountersAMD (uint group, int* numCounters, int* maxActiveCounters, int counterSize, uint* counters);
        [DllImport(DllName)]
        public static extern unsafe void glGetPerfMonitorGroupStringAMD (uint group, int bufSize, int* length, char* groupString);
        [DllImport(DllName)]
        public static extern unsafe void glGetPerfMonitorGroupsAMD (int* numGroups, int groupsSize, uint* groups);
        [DllImport(DllName)]
        public static extern unsafe void glGetPerfQueryDataINTEL (uint queryHandle, uint flags, int dataSize, void* data, uint* bytesWritten);
        [DllImport(DllName)]
        public static extern unsafe void glGetPerfQueryIdByNameINTEL (char* queryName, uint* queryId);
        [DllImport(DllName)]
        public static extern unsafe void glGetPerfQueryInfoINTEL (uint queryId, uint queryNameLength, char* queryName, uint* dataSize, uint* noCounters, uint* noInstances, uint* capsMask);
        [DllImport(DllName)]
        public static extern unsafe void glGetPixelMapfv (uint map, float* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetPixelMapuiv (uint map, uint* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetPixelMapusv (uint map, ushort* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetPixelMapxv (uint map, int size, int* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetPixelTexGenParameterfvSGIS (uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetPixelTexGenParameterivSGIS (uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetPixelTransformParameterfvEXT (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetPixelTransformParameterivEXT (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetPointerIndexedvEXT (uint target, uint index, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetPointeri_vEXT (uint pname, uint index, void* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetPointerv (uint pname, void* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetPointervEXT (uint pname, void* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetPointervKHR (uint pname, void* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetPolygonStipple (byte* mask);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramBinary (uint program, int bufSize, int* length, uint* binaryFormat, void* binary);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramBinaryOES (uint program, int bufSize, int* length, uint* binaryFormat, void* binary);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramEnvParameterIivNV (uint target, uint index, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramEnvParameterIuivNV (uint target, uint index, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramEnvParameterdvARB (uint target, uint index, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramEnvParameterfvARB (uint target, uint index, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramInfoLog (uint program, int bufSize, int* length, char* infoLog);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramInterfaceiv (uint program, uint programInterface, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramLocalParameterIivNV (uint target, uint index, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramLocalParameterIuivNV (uint target, uint index, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramLocalParameterdvARB (uint target, uint index, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramLocalParameterfvARB (uint target, uint index, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramNamedParameterdvNV (uint id, int len, byte* name, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramNamedParameterfvNV (uint id, int len, byte* name, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramParameterdvNV (uint target, uint index, uint pname, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramParameterfvNV (uint target, uint index, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramPipelineInfoLog (uint pipeline, int bufSize, int* length, char* infoLog);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramPipelineInfoLogEXT (uint pipeline, int bufSize, int* length, char* infoLog);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramPipelineiv (uint pipeline, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramPipelineivEXT (uint pipeline, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramResourceIndex (uint program, uint programInterface, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramResourceLocation (uint program, uint programInterface, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramResourceLocationIndex (uint program, uint programInterface, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramResourceLocationIndexEXT (uint program, uint programInterface, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramResourceName (uint program, uint programInterface, uint index, int bufSize, int* length, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramResourcefvNV (uint program, uint programInterface, uint index, int propCount, uint* props, int bufSize, int* length, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramResourceiv (uint program, uint programInterface, uint index, int propCount, uint* props, int bufSize, int* length, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramStageiv (uint program, uint shadertype, uint pname, int* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramStringARB (uint target, uint pname, void* @string);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramStringNV (uint id, uint pname, byte* program);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramSubroutineParameteruivNV (uint target, uint index, uint* param);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramiv (uint program, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramivARB (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetProgramivNV (uint id, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryBufferObjecti64v (uint id, uint buffer, uint pname, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryBufferObjectiv (uint id, uint buffer, uint pname, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryBufferObjectui64v (uint id, uint buffer, uint pname, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryBufferObjectuiv (uint id, uint buffer, uint pname, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryIndexediv (uint target, uint index, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryObjecti64v (uint id, uint pname, long* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryObjecti64vEXT (uint id, uint pname, long* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryObjectiv (uint id, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryObjectivARB (uint id, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryObjectivEXT (uint id, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryObjectui64v (uint id, uint pname, ulong* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryObjectui64vEXT (uint id, uint pname, ulong* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryObjectuiv (uint id, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryObjectuivARB (uint id, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryObjectuivEXT (uint id, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryiv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryivARB (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetQueryivEXT (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetRenderbufferParameteriv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetRenderbufferParameterivEXT (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetRenderbufferParameterivOES (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetSamplerParameterIiv (uint sampler, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetSamplerParameterIivEXT (uint sampler, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetSamplerParameterIivOES (uint sampler, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetSamplerParameterIuiv (uint sampler, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetSamplerParameterIuivEXT (uint sampler, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetSamplerParameterIuivOES (uint sampler, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetSamplerParameterfv (uint sampler, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetSamplerParameteriv (uint sampler, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetSeparableFilter (uint target, uint format, uint type, void* row, void* column, void* span);
        [DllImport(DllName)]
        public static extern unsafe void glGetSeparableFilterEXT (uint target, uint format, uint type, void* row, void* column, void* span);
        [DllImport(DllName)]
        public static extern unsafe void glGetShaderInfoLog (uint shader, int bufSize, int* length, char* infoLog);
        [DllImport(DllName)]
        public static extern unsafe void glGetShaderPrecisionFormat (uint shadertype, uint precisiontype, int* range, int* precision);
        [DllImport(DllName)]
        public static extern unsafe void glGetShaderSource (uint shader, int bufSize, int* length, char* source);
        [DllImport(DllName)]
        public static extern unsafe void glGetShaderSourceARB (void* obj, int maxLength, int* length, char* source);
        [DllImport(DllName)]
        public static extern unsafe void glGetShaderiv (uint shader, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetSharpenTexFuncSGIS (uint target, float* points);
        [DllImport(DllName)]
        public static extern unsafe void glGetStageIndexNV (uint shadertype);
        [DllImport(DllName)]
        public static extern unsafe void glGetString (uint name);
        [DllImport(DllName)]
        public static extern unsafe void glGetStringi (uint name, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glGetSubroutineIndex (uint program, uint shadertype, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetSubroutineUniformLocation (uint program, uint shadertype, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetSynciv (void* sync, uint pname, int bufSize, int* length, int* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetSyncivAPPLE (void* sync, uint pname, int bufSize, int* length, int* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexBumpParameterfvATI (uint pname, float* param);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexBumpParameterivATI (uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexEnvfv (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexEnviv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexEnvxv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexEnvxvOES (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexFilterFuncSGIS (uint target, uint filter, float* weights);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexGendv (uint coord, uint pname, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexGenfv (uint coord, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexGenfvOES (uint coord, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexGeniv (uint coord, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexGenivOES (uint coord, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexGenxvOES (uint coord, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexImage (uint target, int level, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexLevelParameterfv (uint target, int level, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexLevelParameteriv (uint target, int level, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexLevelParameterxvOES (uint target, int level, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexParameterIiv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexParameterIivEXT (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexParameterIivOES (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexParameterIuiv (uint target, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexParameterIuivEXT (uint target, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexParameterIuivOES (uint target, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexParameterPointervAPPLE (uint target, uint pname, void* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexParameterfv (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexParameteriv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexParameterxv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTexParameterxvOES (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureHandleARB (uint texture);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureHandleNV (uint texture);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureImage (uint texture, int level, uint format, uint type, int bufSize, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureImageEXT (uint texture, uint target, int level, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureLevelParameterfv (uint texture, int level, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureLevelParameterfvEXT (uint texture, uint target, int level, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureLevelParameteriv (uint texture, int level, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureLevelParameterivEXT (uint texture, uint target, int level, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureParameterIiv (uint texture, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureParameterIivEXT (uint texture, uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureParameterIuiv (uint texture, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureParameterIuivEXT (uint texture, uint target, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureParameterfv (uint texture, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureParameterfvEXT (uint texture, uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureParameteriv (uint texture, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureParameterivEXT (uint texture, uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureSamplerHandleARB (uint texture, uint sampler);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureSamplerHandleNV (uint texture, uint sampler);
        [DllImport(DllName)]
        public static extern unsafe void glGetTextureSubImage (uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glGetTrackMatrixivNV (uint target, uint address, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetTransformFeedbackVarying (uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetTransformFeedbackVaryingEXT (uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetTransformFeedbackVaryingNV (uint program, uint index, int* location);
        [DllImport(DllName)]
        public static extern unsafe void glGetTransformFeedbacki64_v (uint xfb, uint pname, uint index, long* param);
        [DllImport(DllName)]
        public static extern unsafe void glGetTransformFeedbacki_v (uint xfb, uint pname, uint index, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glGetTransformFeedbackiv (uint xfb, uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glGetTranslatedShaderSourceANGLE (uint shader, int bufsize, int* length, char* source);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformBlockIndex (uint program, char* uniformBlockName);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformBufferSizeEXT (uint program, int location);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformIndices (uint program, int uniformCount, char* uniformNames, uint* uniformIndices);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformLocation (uint program, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformLocationARB (void* programObj, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformOffsetEXT (uint program, int location);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformSubroutineuiv (uint shadertype, int location, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformdv (uint program, int location, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformfv (uint program, int location, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformfvARB (void* programObj, int location, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformi64vARB (uint program, int location, long* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformi64vNV (uint program, int location, long* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformiv (uint program, int location, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformivARB (void* programObj, int location, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformui64vARB (uint program, int location, ulong* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformui64vNV (uint program, int location, ulong* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformuiv (uint program, int location, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetUniformuivEXT (uint program, int location, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVariantArrayObjectfvATI (uint id, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVariantArrayObjectivATI (uint id, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVariantBooleanvEXT (uint id, uint value, bool* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetVariantFloatvEXT (uint id, uint value, float* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetVariantIntegervEXT (uint id, uint value, int* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetVariantPointervEXT (uint id, uint value, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glGetVaryingLocationNV (uint program, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexArrayIndexed64iv (uint vaobj, uint index, uint pname, long* param);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexArrayIndexediv (uint vaobj, uint index, uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexArrayIntegeri_vEXT (uint vaobj, uint index, uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexArrayIntegervEXT (uint vaobj, uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexArrayPointeri_vEXT (uint vaobj, uint index, uint pname, void* param);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexArrayPointervEXT (uint vaobj, uint pname, void* param);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexArrayiv (uint vaobj, uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribArrayObjectfvATI (uint index, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribArrayObjectivATI (uint index, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribIiv (uint index, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribIivEXT (uint index, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribIuiv (uint index, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribIuivEXT (uint index, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribLdv (uint index, uint pname, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribLdvEXT (uint index, uint pname, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribLi64vNV (uint index, uint pname, long* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribLui64vARB (uint index, uint pname, ulong* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribLui64vNV (uint index, uint pname, ulong* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribPointerv (uint index, uint pname, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribPointervARB (uint index, uint pname, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribPointervNV (uint index, uint pname, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribdv (uint index, uint pname, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribdvARB (uint index, uint pname, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribdvNV (uint index, uint pname, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribfv (uint index, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribfvARB (uint index, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribfvNV (uint index, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribiv (uint index, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribivARB (uint index, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVertexAttribivNV (uint index, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVideoCaptureStreamdvNV (uint video_capture_slot, uint stream, uint pname, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVideoCaptureStreamfvNV (uint video_capture_slot, uint stream, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVideoCaptureStreamivNV (uint video_capture_slot, uint stream, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVideoCaptureivNV (uint video_capture_slot, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVideoi64vNV (uint video_slot, uint pname, long* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVideoivNV (uint video_slot, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVideoui64vNV (uint video_slot, uint pname, ulong* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetVideouivNV (uint video_slot, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetnColorTable (uint target, uint format, uint type, int bufSize, void* table);
        [DllImport(DllName)]
        public static extern unsafe void glGetnColorTableARB (uint target, uint format, uint type, int bufSize, void* table);
        [DllImport(DllName)]
        public static extern unsafe void glGetnCompressedTexImage (uint target, int lod, int bufSize, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glGetnCompressedTexImageARB (uint target, int lod, int bufSize, void* img);
        [DllImport(DllName)]
        public static extern unsafe void glGetnConvolutionFilter (uint target, uint format, uint type, int bufSize, void* image);
        [DllImport(DllName)]
        public static extern unsafe void glGetnConvolutionFilterARB (uint target, uint format, uint type, int bufSize, void* image);
        [DllImport(DllName)]
        public static extern unsafe void glGetnHistogram (uint target, bool reset, uint format, uint type, int bufSize, void* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetnHistogramARB (uint target, bool reset, uint format, uint type, int bufSize, void* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetnMapdv (uint target, uint query, int bufSize, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glGetnMapdvARB (uint target, uint query, int bufSize, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glGetnMapfv (uint target, uint query, int bufSize, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glGetnMapfvARB (uint target, uint query, int bufSize, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glGetnMapiv (uint target, uint query, int bufSize, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glGetnMapivARB (uint target, uint query, int bufSize, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glGetnMinmax (uint target, bool reset, uint format, uint type, int bufSize, void* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetnMinmaxARB (uint target, bool reset, uint format, uint type, int bufSize, void* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetnPixelMapfv (uint map, int bufSize, float* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetnPixelMapfvARB (uint map, int bufSize, float* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetnPixelMapuiv (uint map, int bufSize, uint* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetnPixelMapuivARB (uint map, int bufSize, uint* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetnPixelMapusv (uint map, int bufSize, ushort* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetnPixelMapusvARB (uint map, int bufSize, ushort* values);
        [DllImport(DllName)]
        public static extern unsafe void glGetnPolygonStipple (int bufSize, byte* pattern);
        [DllImport(DllName)]
        public static extern unsafe void glGetnPolygonStippleARB (int bufSize, byte* pattern);
        [DllImport(DllName)]
        public static extern unsafe void glGetnSeparableFilter (uint target, uint format, uint type, int rowBufSize, void* row, int columnBufSize, void* column, void* span);
        [DllImport(DllName)]
        public static extern unsafe void glGetnSeparableFilterARB (uint target, uint format, uint type, int rowBufSize, void* row, int columnBufSize, void* column, void* span);
        [DllImport(DllName)]
        public static extern unsafe void glGetnTexImage (uint target, int level, uint format, uint type, int bufSize, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glGetnTexImageARB (uint target, int level, uint format, uint type, int bufSize, void* img);
        [DllImport(DllName)]
        public static extern unsafe void glGetnUniformdv (uint program, int location, int bufSize, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetnUniformdvARB (uint program, int location, int bufSize, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetnUniformfv (uint program, int location, int bufSize, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetnUniformfvARB (uint program, int location, int bufSize, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetnUniformfvEXT (uint program, int location, int bufSize, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetnUniformfvKHR (uint program, int location, int bufSize, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetnUniformi64vARB (uint program, int location, int bufSize, long* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetnUniformiv (uint program, int location, int bufSize, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetnUniformivARB (uint program, int location, int bufSize, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetnUniformivEXT (uint program, int location, int bufSize, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetnUniformivKHR (uint program, int location, int bufSize, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetnUniformui64vARB (uint program, int location, int bufSize, ulong* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetnUniformuiv (uint program, int location, int bufSize, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetnUniformuivARB (uint program, int location, int bufSize, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGetnUniformuivKHR (uint program, int location, int bufSize, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glGlobalAlphaFactorbSUN (sbyte factor);
        [DllImport(DllName)]
        public static extern unsafe void glGlobalAlphaFactordSUN (double factor);
        [DllImport(DllName)]
        public static extern unsafe void glGlobalAlphaFactorfSUN (float factor);
        [DllImport(DllName)]
        public static extern unsafe void glGlobalAlphaFactoriSUN (int factor);
        [DllImport(DllName)]
        public static extern unsafe void glGlobalAlphaFactorsSUN (short factor);
        [DllImport(DllName)]
        public static extern unsafe void glGlobalAlphaFactorubSUN (byte factor);
        [DllImport(DllName)]
        public static extern unsafe void glGlobalAlphaFactoruiSUN (uint factor);
        [DllImport(DllName)]
        public static extern unsafe void glGlobalAlphaFactorusSUN (ushort factor);
        [DllImport(DllName)]
        public static extern unsafe void glHint (uint target, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glHintPGI (uint target, int mode);
        [DllImport(DllName)]
        public static extern unsafe void glHistogram (uint target, int width, uint internalformat, bool sink);
        [DllImport(DllName)]
        public static extern unsafe void glHistogramEXT (uint target, int width, uint internalformat, bool sink);
        [DllImport(DllName)]
        public static extern unsafe void glIglooInterfaceSGIX (uint pname, void* @params);
        [DllImport(DllName)]
        public static extern unsafe void glImageTransformParameterfHP (uint target, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glImageTransformParameterfvHP (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glImageTransformParameteriHP (uint target, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glImageTransformParameterivHP (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glImportSyncEXT (uint external_sync_type, int* external_sync, uint flags);
        [DllImport(DllName)]
        public static extern unsafe void glIndexFormatNV (uint type, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glIndexFuncEXT (uint func, float @ref);
        [DllImport(DllName)]
        public static extern unsafe void glIndexMask (uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glIndexMaterialEXT (uint face, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glIndexPointer (uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glIndexPointerEXT (uint type, int stride, int count, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glIndexPointerListIBM (uint type, int stride, void* pointer, int ptrstride);
        [DllImport(DllName)]
        public static extern unsafe void glIndexd (double c);
        [DllImport(DllName)]
        public static extern unsafe void glIndexdv (double* c);
        [DllImport(DllName)]
        public static extern unsafe void glIndexf (float c);
        [DllImport(DllName)]
        public static extern unsafe void glIndexfv (float* c);
        [DllImport(DllName)]
        public static extern unsafe void glIndexi (int c);
        [DllImport(DllName)]
        public static extern unsafe void glIndexiv (int* c);
        [DllImport(DllName)]
        public static extern unsafe void glIndexs (short c);
        [DllImport(DllName)]
        public static extern unsafe void glIndexsv (short* c);
        [DllImport(DllName)]
        public static extern unsafe void glIndexub (byte c);
        [DllImport(DllName)]
        public static extern unsafe void glIndexubv (byte* c);
        [DllImport(DllName)]
        public static extern unsafe void glIndexxOES (int component);
        [DllImport(DllName)]
        public static extern unsafe void glIndexxvOES (int* component);
        [DllImport(DllName)]
        public static extern unsafe void glInitNames ();
        [DllImport(DllName)]
        public static extern unsafe void glInsertComponentEXT (uint res, uint src, uint num);
        [DllImport(DllName)]
        public static extern unsafe void glInsertEventMarkerEXT (int length, char* marker);
        [DllImport(DllName)]
        public static extern unsafe void glInstrumentsBufferSGIX (int size, int* buffer);
        [DllImport(DllName)]
        public static extern unsafe void glInterleavedArrays (uint format, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glInterpolatePathsNV (uint resultPath, uint pathA, uint pathB, float weight);
        [DllImport(DllName)]
        public static extern unsafe void glInvalidateBufferData (uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glInvalidateBufferSubData (uint buffer, int* offset, int* length);
        [DllImport(DllName)]
        public static extern unsafe void glInvalidateFramebuffer (uint target, int numAttachments, uint* attachments);
        [DllImport(DllName)]
        public static extern unsafe void glInvalidateNamedFramebufferData (uint framebuffer, int numAttachments, uint* attachments);
        [DllImport(DllName)]
        public static extern unsafe void glInvalidateNamedFramebufferSubData (uint framebuffer, int numAttachments, uint* attachments, int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glInvalidateSubFramebuffer (uint target, int numAttachments, uint* attachments, int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glInvalidateTexImage (uint texture, int level);
        [DllImport(DllName)]
        public static extern unsafe void glInvalidateTexSubImage (uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);
        [DllImport(DllName)]
        public static extern unsafe void glIsAsyncMarkerSGIX (uint marker);
        [DllImport(DllName)]
        public static extern unsafe void glIsBuffer (uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glIsBufferARB (uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glIsBufferResidentNV (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glIsCommandListNV (uint list);
        [DllImport(DllName)]
        public static extern unsafe void glIsEnabled (uint cap);
        [DllImport(DllName)]
        public static extern unsafe void glIsEnabledIndexedEXT (uint target, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glIsEnabledi (uint target, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glIsEnablediEXT (uint target, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glIsEnablediNV (uint target, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glIsEnablediOES (uint target, uint index);
        [DllImport(DllName)]
        public static extern unsafe void glIsFenceAPPLE (uint fence);
        [DllImport(DllName)]
        public static extern unsafe void glIsFenceNV (uint fence);
        [DllImport(DllName)]
        public static extern unsafe void glIsFramebuffer (uint framebuffer);
        [DllImport(DllName)]
        public static extern unsafe void glIsFramebufferEXT (uint framebuffer);
        [DllImport(DllName)]
        public static extern unsafe void glIsFramebufferOES (uint framebuffer);
        [DllImport(DllName)]
        public static extern unsafe void glIsImageHandleResidentARB (ulong handle);
        [DllImport(DllName)]
        public static extern unsafe void glIsImageHandleResidentNV (ulong handle);
        [DllImport(DllName)]
        public static extern unsafe void glIsList (uint list);
        [DllImport(DllName)]
        public static extern unsafe void glIsNameAMD (uint identifier, uint name);
        [DllImport(DllName)]
        public static extern unsafe void glIsNamedBufferResidentNV (uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glIsNamedStringARB (int namelen, char* name);
        [DllImport(DllName)]
        public static extern unsafe void glIsObjectBufferATI (uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glIsOcclusionQueryNV (uint id);
        [DllImport(DllName)]
        public static extern unsafe void glIsPathNV (uint path);
        [DllImport(DllName)]
        public static extern unsafe void glIsPointInFillPathNV (uint path, uint mask, float x, float y);
        [DllImport(DllName)]
        public static extern unsafe void glIsPointInStrokePathNV (uint path, float x, float y);
        [DllImport(DllName)]
        public static extern unsafe void glIsProgram (uint program);
        [DllImport(DllName)]
        public static extern unsafe void glIsProgramARB (uint program);
        [DllImport(DllName)]
        public static extern unsafe void glIsProgramNV (uint id);
        [DllImport(DllName)]
        public static extern unsafe void glIsProgramPipeline (uint pipeline);
        [DllImport(DllName)]
        public static extern unsafe void glIsProgramPipelineEXT (uint pipeline);
        [DllImport(DllName)]
        public static extern unsafe void glIsQuery (uint id);
        [DllImport(DllName)]
        public static extern unsafe void glIsQueryARB (uint id);
        [DllImport(DllName)]
        public static extern unsafe void glIsQueryEXT (uint id);
        [DllImport(DllName)]
        public static extern unsafe void glIsRenderbuffer (uint renderbuffer);
        [DllImport(DllName)]
        public static extern unsafe void glIsRenderbufferEXT (uint renderbuffer);
        [DllImport(DllName)]
        public static extern unsafe void glIsRenderbufferOES (uint renderbuffer);
        [DllImport(DllName)]
        public static extern unsafe void glIsSampler (uint sampler);
        [DllImport(DllName)]
        public static extern unsafe void glIsShader (uint shader);
        [DllImport(DllName)]
        public static extern unsafe void glIsStateNV (uint state);
        [DllImport(DllName)]
        public static extern unsafe void glIsSync (void* sync);
        [DllImport(DllName)]
        public static extern unsafe void glIsSyncAPPLE (void* sync);
        [DllImport(DllName)]
        public static extern unsafe void glIsTexture (uint texture);
        [DllImport(DllName)]
        public static extern unsafe void glIsTextureEXT (uint texture);
        [DllImport(DllName)]
        public static extern unsafe void glIsTextureHandleResidentARB (ulong handle);
        [DllImport(DllName)]
        public static extern unsafe void glIsTextureHandleResidentNV (ulong handle);
        [DllImport(DllName)]
        public static extern unsafe void glIsTransformFeedback (uint id);
        [DllImport(DllName)]
        public static extern unsafe void glIsTransformFeedbackNV (uint id);
        [DllImport(DllName)]
        public static extern unsafe void glIsVariantEnabledEXT (uint id, uint cap);
        [DllImport(DllName)]
        public static extern unsafe void glIsVertexArray (uint array);
        [DllImport(DllName)]
        public static extern unsafe void glIsVertexArrayAPPLE (uint array);
        [DllImport(DllName)]
        public static extern unsafe void glIsVertexArrayOES (uint array);
        [DllImport(DllName)]
        public static extern unsafe void glIsVertexAttribEnabledAPPLE (uint index, uint pname);
        [DllImport(DllName)]
        public static extern unsafe void glLabelObjectEXT (uint type, uint @object, int length, char* label);
        [DllImport(DllName)]
        public static extern unsafe void glLightEnviSGIX (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glLightModelf (uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glLightModelfv (uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glLightModeli (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glLightModeliv (uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glLightModelx (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glLightModelxOES (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glLightModelxv (uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glLightModelxvOES (uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glLightf (uint light, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glLightfv (uint light, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glLighti (uint light, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glLightiv (uint light, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glLightx (uint light, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glLightxOES (uint light, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glLightxv (uint light, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glLightxvOES (uint light, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glLineStipple (int factor, ushort pattern);
        [DllImport(DllName)]
        public static extern unsafe void glLineWidth (float width);
        [DllImport(DllName)]
        public static extern unsafe void glLineWidthx (int width);
        [DllImport(DllName)]
        public static extern unsafe void glLineWidthxOES (int width);
        [DllImport(DllName)]
        public static extern unsafe void glLinkProgram (uint program);
        [DllImport(DllName)]
        public static extern unsafe void glLinkProgramARB (void* programObj);
        [DllImport(DllName)]
        public static extern unsafe void glListBase (uint @base);
        [DllImport(DllName)]
        public static extern unsafe void glListDrawCommandsStatesClientNV (uint list, uint segment, void* indirects, int* sizes, uint* states, uint* fbos, uint count);
        [DllImport(DllName)]
        public static extern unsafe void glListParameterfSGIX (uint list, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glListParameterfvSGIX (uint list, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glListParameteriSGIX (uint list, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glListParameterivSGIX (uint list, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glLoadIdentity ();
        [DllImport(DllName)]
        public static extern unsafe void glLoadIdentityDeformationMapSGIX (uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glLoadMatrixd (double* m);
        [DllImport(DllName)]
        public static extern unsafe void glLoadMatrixf (float* m);
        [DllImport(DllName)]
        public static extern unsafe void glLoadMatrixx (int* m);
        [DllImport(DllName)]
        public static extern unsafe void glLoadMatrixxOES (int* m);
        [DllImport(DllName)]
        public static extern unsafe void glLoadName (uint name);
        [DllImport(DllName)]
        public static extern unsafe void glLoadPaletteFromModelViewMatrixOES ();
        [DllImport(DllName)]
        public static extern unsafe void glLoadProgramNV (uint target, uint id, int len, byte* program);
        [DllImport(DllName)]
        public static extern unsafe void glLoadTransposeMatrixd (double* m);
        [DllImport(DllName)]
        public static extern unsafe void glLoadTransposeMatrixdARB (double* m);
        [DllImport(DllName)]
        public static extern unsafe void glLoadTransposeMatrixf (float* m);
        [DllImport(DllName)]
        public static extern unsafe void glLoadTransposeMatrixfARB (float* m);
        [DllImport(DllName)]
        public static extern unsafe void glLoadTransposeMatrixxOES (int* m);
        [DllImport(DllName)]
        public static extern unsafe void glLockArraysEXT (int first, int count);
        [DllImport(DllName)]
        public static extern unsafe void glLogicOp (uint opcode);
        [DllImport(DllName)]
        public static extern unsafe void glMakeBufferNonResidentNV (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glMakeBufferResidentNV (uint target, uint access);
        [DllImport(DllName)]
        public static extern unsafe void glMakeImageHandleNonResidentARB (ulong handle);
        [DllImport(DllName)]
        public static extern unsafe void glMakeImageHandleNonResidentNV (ulong handle);
        [DllImport(DllName)]
        public static extern unsafe void glMakeImageHandleResidentARB (ulong handle, uint access);
        [DllImport(DllName)]
        public static extern unsafe void glMakeImageHandleResidentNV (ulong handle, uint access);
        [DllImport(DllName)]
        public static extern unsafe void glMakeNamedBufferNonResidentNV (uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glMakeNamedBufferResidentNV (uint buffer, uint access);
        [DllImport(DllName)]
        public static extern unsafe void glMakeTextureHandleNonResidentARB (ulong handle);
        [DllImport(DllName)]
        public static extern unsafe void glMakeTextureHandleNonResidentNV (ulong handle);
        [DllImport(DllName)]
        public static extern unsafe void glMakeTextureHandleResidentARB (ulong handle);
        [DllImport(DllName)]
        public static extern unsafe void glMakeTextureHandleResidentNV (ulong handle);
        [DllImport(DllName)]
        public static extern unsafe void glMap1d (uint target, double u1, double u2, int stride, int order, double* points);
        [DllImport(DllName)]
        public static extern unsafe void glMap1f (uint target, float u1, float u2, int stride, int order, float* points);
        [DllImport(DllName)]
        public static extern unsafe void glMap1xOES (uint target, int u1, int u2, int stride, int order, int points);
        [DllImport(DllName)]
        public static extern unsafe void glMap2d (uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);
        [DllImport(DllName)]
        public static extern unsafe void glMap2f (uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);
        [DllImport(DllName)]
        public static extern unsafe void glMap2xOES (uint target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points);
        [DllImport(DllName)]
        public static extern unsafe void glMapBuffer (uint target, uint access);
        [DllImport(DllName)]
        public static extern unsafe void glMapBufferARB (uint target, uint access);
        [DllImport(DllName)]
        public static extern unsafe void glMapBufferOES (uint target, uint access);
        [DllImport(DllName)]
        public static extern unsafe void glMapBufferRange (uint target, int* offset, int* length, uint access);
        [DllImport(DllName)]
        public static extern unsafe void glMapBufferRangeEXT (uint target, int* offset, int* length, uint access);
        [DllImport(DllName)]
        public static extern unsafe void glMapControlPointsNV (uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, bool packed, void* points);
        [DllImport(DllName)]
        public static extern unsafe void glMapGrid1d (int un, double u1, double u2);
        [DllImport(DllName)]
        public static extern unsafe void glMapGrid1f (int un, float u1, float u2);
        [DllImport(DllName)]
        public static extern unsafe void glMapGrid1xOES (int n, int u1, int u2);
        [DllImport(DllName)]
        public static extern unsafe void glMapGrid2d (int un, double u1, double u2, int vn, double v1, double v2);
        [DllImport(DllName)]
        public static extern unsafe void glMapGrid2f (int un, float u1, float u2, int vn, float v1, float v2);
        [DllImport(DllName)]
        public static extern unsafe void glMapGrid2xOES (int n, int u1, int u2, int v1, int v2);
        [DllImport(DllName)]
        public static extern unsafe void glMapNamedBuffer (uint buffer, uint access);
        [DllImport(DllName)]
        public static extern unsafe void glMapNamedBufferEXT (uint buffer, uint access);
        [DllImport(DllName)]
        public static extern unsafe void glMapNamedBufferRange (uint buffer, int* offset, int* length, uint access);
        [DllImport(DllName)]
        public static extern unsafe void glMapNamedBufferRangeEXT (uint buffer, int* offset, int* length, uint access);
        [DllImport(DllName)]
        public static extern unsafe void glMapObjectBufferATI (uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glMapParameterfvNV (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glMapParameterivNV (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glMapTexture2DINTEL (uint texture, int level, uint access, int* stride, uint* layout);
        [DllImport(DllName)]
        public static extern unsafe void glMapVertexAttrib1dAPPLE (uint index, uint size, double u1, double u2, int stride, int order, double* points);
        [DllImport(DllName)]
        public static extern unsafe void glMapVertexAttrib1fAPPLE (uint index, uint size, float u1, float u2, int stride, int order, float* points);
        [DllImport(DllName)]
        public static extern unsafe void glMapVertexAttrib2dAPPLE (uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);
        [DllImport(DllName)]
        public static extern unsafe void glMapVertexAttrib2fAPPLE (uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);
        [DllImport(DllName)]
        public static extern unsafe void glMaterialf (uint face, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glMaterialfv (uint face, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glMateriali (uint face, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glMaterialiv (uint face, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glMaterialx (uint face, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glMaterialxOES (uint face, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glMaterialxv (uint face, uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glMaterialxvOES (uint face, uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixFrustumEXT (uint mode, double left, double right, double bottom, double top, double zNear, double zFar);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixIndexPointerARB (int size, uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixIndexPointerOES (int size, uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixIndexubvARB (int size, byte* indices);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixIndexuivARB (int size, uint* indices);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixIndexusvARB (int size, ushort* indices);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixLoad3x2fNV (uint matrixMode, float* m);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixLoad3x3fNV (uint matrixMode, float* m);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixLoadIdentityEXT (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixLoadTranspose3x3fNV (uint matrixMode, float* m);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixLoadTransposedEXT (uint mode, double* m);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixLoadTransposefEXT (uint mode, float* m);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixLoaddEXT (uint mode, double* m);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixLoadfEXT (uint mode, float* m);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixMode (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixMult3x2fNV (uint matrixMode, float* m);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixMult3x3fNV (uint matrixMode, float* m);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixMultTranspose3x3fNV (uint matrixMode, float* m);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixMultTransposedEXT (uint mode, double* m);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixMultTransposefEXT (uint mode, float* m);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixMultdEXT (uint mode, double* m);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixMultfEXT (uint mode, float* m);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixOrthoEXT (uint mode, double left, double right, double bottom, double top, double zNear, double zFar);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixPopEXT (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixPushEXT (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixRotatedEXT (uint mode, double angle, double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixRotatefEXT (uint mode, float angle, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixScaledEXT (uint mode, double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixScalefEXT (uint mode, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixTranslatedEXT (uint mode, double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glMatrixTranslatefEXT (uint mode, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glMaxShaderCompilerThreadsARB (uint count);
        [DllImport(DllName)]
        public static extern unsafe void glMemoryBarrier (uint barriers);
        [DllImport(DllName)]
        public static extern unsafe void glMemoryBarrierByRegion (uint barriers);
        [DllImport(DllName)]
        public static extern unsafe void glMemoryBarrierEXT (uint barriers);
        [DllImport(DllName)]
        public static extern unsafe void glMinSampleShading (float value);
        [DllImport(DllName)]
        public static extern unsafe void glMinSampleShadingARB (float value);
        [DllImport(DllName)]
        public static extern unsafe void glMinSampleShadingOES (float value);
        [DllImport(DllName)]
        public static extern unsafe void glMinmax (uint target, uint internalformat, bool sink);
        [DllImport(DllName)]
        public static extern unsafe void glMinmaxEXT (uint target, uint internalformat, bool sink);
        [DllImport(DllName)]
        public static extern unsafe void glMultMatrixd (double* m);
        [DllImport(DllName)]
        public static extern unsafe void glMultMatrixf (float* m);
        [DllImport(DllName)]
        public static extern unsafe void glMultMatrixx (int* m);
        [DllImport(DllName)]
        public static extern unsafe void glMultMatrixxOES (int* m);
        [DllImport(DllName)]
        public static extern unsafe void glMultTransposeMatrixd (double* m);
        [DllImport(DllName)]
        public static extern unsafe void glMultTransposeMatrixdARB (double* m);
        [DllImport(DllName)]
        public static extern unsafe void glMultTransposeMatrixf (float* m);
        [DllImport(DllName)]
        public static extern unsafe void glMultTransposeMatrixfARB (float* m);
        [DllImport(DllName)]
        public static extern unsafe void glMultTransposeMatrixxOES (int* m);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawArrays (uint mode, int* first, int* count, int drawcount);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawArraysEXT (uint mode, int* first, int* count, int primcount);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawArraysIndirect (uint mode, void* indirect, int drawcount, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawArraysIndirectAMD (uint mode, void* indirect, int primcount, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawArraysIndirectBindlessCountNV (uint mode, void* indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawArraysIndirectBindlessNV (uint mode, void* indirect, int drawCount, int stride, int vertexBufferCount);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawArraysIndirectCountARB (uint mode, int* indirect, int* drawcount, int maxdrawcount, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawArraysIndirectEXT (uint mode, void* indirect, int drawcount, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawElementArrayAPPLE (uint mode, int* first, int* count, int primcount);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawElements (uint mode, int* count, uint type, void* indices, int drawcount);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawElementsBaseVertex (uint mode, int* count, uint type, void* indices, int drawcount, int* basevertex);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawElementsBaseVertexEXT (uint mode, int* count, uint type, void* indices, int primcount, int* basevertex);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawElementsBaseVertexOES (uint mode, int* count, uint type, void* indices, int primcount, int* basevertex);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawElementsEXT (uint mode, int* count, uint type, void* indices, int primcount);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawElementsIndirect (uint mode, uint type, void* indirect, int drawcount, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawElementsIndirectAMD (uint mode, uint type, void* indirect, int primcount, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawElementsIndirectBindlessCountNV (uint mode, uint type, void* indirect, int drawCount, int maxDrawCount, int stride, int vertexBufferCount);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawElementsIndirectBindlessNV (uint mode, uint type, void* indirect, int drawCount, int stride, int vertexBufferCount);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawElementsIndirectCountARB (uint mode, uint type, int* indirect, int* drawcount, int maxdrawcount, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawElementsIndirectEXT (uint mode, uint type, void* indirect, int drawcount, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glMultiDrawRangeElementArrayAPPLE (uint mode, uint start, uint end, int* first, int* count, int primcount);
        [DllImport(DllName)]
        public static extern unsafe void glMultiModeDrawArraysIBM (uint* mode, int* first, int* count, int primcount, int modestride);
        [DllImport(DllName)]
        public static extern unsafe void glMultiModeDrawElementsIBM (uint* mode, int* count, uint type, void* indices, int primcount, int modestride);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexBufferEXT (uint texunit, uint target, uint internalformat, uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1bOES (uint texture, sbyte s);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1bvOES (uint texture, sbyte* coords);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1d (uint target, double s);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1dARB (uint target, double s);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1dv (uint target, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1dvARB (uint target, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1f (uint target, float s);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1fARB (uint target, float s);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1fv (uint target, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1fvARB (uint target, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1hNV (uint target, ushort s);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1hvNV (uint target, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1i (uint target, int s);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1iARB (uint target, int s);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1iv (uint target, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1ivARB (uint target, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1s (uint target, short s);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1sARB (uint target, short s);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1sv (uint target, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1svARB (uint target, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1xOES (uint texture, int s);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord1xvOES (uint texture, int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2bOES (uint texture, sbyte s, sbyte t);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2bvOES (uint texture, sbyte* coords);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2d (uint target, double s, double t);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2dARB (uint target, double s, double t);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2dv (uint target, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2dvARB (uint target, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2f (uint target, float s, float t);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2fARB (uint target, float s, float t);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2fv (uint target, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2fvARB (uint target, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2hNV (uint target, ushort s, ushort t);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2hvNV (uint target, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2i (uint target, int s, int t);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2iARB (uint target, int s, int t);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2iv (uint target, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2ivARB (uint target, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2s (uint target, short s, short t);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2sARB (uint target, short s, short t);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2sv (uint target, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2svARB (uint target, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2xOES (uint texture, int s, int t);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord2xvOES (uint texture, int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3bOES (uint texture, sbyte s, sbyte t, sbyte r);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3bvOES (uint texture, sbyte* coords);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3d (uint target, double s, double t, double r);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3dARB (uint target, double s, double t, double r);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3dv (uint target, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3dvARB (uint target, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3f (uint target, float s, float t, float r);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3fARB (uint target, float s, float t, float r);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3fv (uint target, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3fvARB (uint target, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3hNV (uint target, ushort s, ushort t, ushort r);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3hvNV (uint target, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3i (uint target, int s, int t, int r);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3iARB (uint target, int s, int t, int r);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3iv (uint target, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3ivARB (uint target, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3s (uint target, short s, short t, short r);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3sARB (uint target, short s, short t, short r);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3sv (uint target, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3svARB (uint target, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3xOES (uint texture, int s, int t, int r);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord3xvOES (uint texture, int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4bOES (uint texture, sbyte s, sbyte t, sbyte r, sbyte q);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4bvOES (uint texture, sbyte* coords);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4d (uint target, double s, double t, double r, double q);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4dARB (uint target, double s, double t, double r, double q);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4dv (uint target, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4dvARB (uint target, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4f (uint target, float s, float t, float r, float q);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4fARB (uint target, float s, float t, float r, float q);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4fv (uint target, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4fvARB (uint target, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4hNV (uint target, ushort s, ushort t, ushort r, ushort q);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4hvNV (uint target, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4i (uint target, int s, int t, int r, int q);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4iARB (uint target, int s, int t, int r, int q);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4iv (uint target, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4ivARB (uint target, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4s (uint target, short s, short t, short r, short q);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4sARB (uint target, short s, short t, short r, short q);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4sv (uint target, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4svARB (uint target, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4x (uint texture, int s, int t, int r, int q);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4xOES (uint texture, int s, int t, int r, int q);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoord4xvOES (uint texture, int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoordP1ui (uint texture, uint type, uint coords);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoordP1uiv (uint texture, uint type, uint* coords);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoordP2ui (uint texture, uint type, uint coords);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoordP2uiv (uint texture, uint type, uint* coords);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoordP3ui (uint texture, uint type, uint coords);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoordP3uiv (uint texture, uint type, uint* coords);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoordP4ui (uint texture, uint type, uint coords);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoordP4uiv (uint texture, uint type, uint* coords);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexCoordPointerEXT (uint texunit, int size, uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexEnvfEXT (uint texunit, uint target, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexEnvfvEXT (uint texunit, uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexEnviEXT (uint texunit, uint target, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexEnvivEXT (uint texunit, uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexGendEXT (uint texunit, uint coord, uint pname, double param);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexGendvEXT (uint texunit, uint coord, uint pname, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexGenfEXT (uint texunit, uint coord, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexGenfvEXT (uint texunit, uint coord, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexGeniEXT (uint texunit, uint coord, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexGenivEXT (uint texunit, uint coord, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexImage1DEXT (uint texunit, uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexImage2DEXT (uint texunit, uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexImage3DEXT (uint texunit, uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexParameterIivEXT (uint texunit, uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexParameterIuivEXT (uint texunit, uint target, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexParameterfEXT (uint texunit, uint target, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexParameterfvEXT (uint texunit, uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexParameteriEXT (uint texunit, uint target, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexParameterivEXT (uint texunit, uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexRenderbufferEXT (uint texunit, uint target, uint renderbuffer);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexSubImage1DEXT (uint texunit, uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexSubImage2DEXT (uint texunit, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glMultiTexSubImage3DEXT (uint texunit, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glNamedBufferData (uint buffer, int* size, void* data, uint usage);
        [DllImport(DllName)]
        public static extern unsafe void glNamedBufferDataEXT (uint buffer, int* size, void* data, uint usage);
        [DllImport(DllName)]
        public static extern unsafe void glNamedBufferPageCommitmentARB (uint buffer, int* offset, int* size, bool commit);
        [DllImport(DllName)]
        public static extern unsafe void glNamedBufferPageCommitmentEXT (uint buffer, int* offset, int* size, bool commit);
        [DllImport(DllName)]
        public static extern unsafe void glNamedBufferStorage (uint buffer, int* size, void* data, uint flags);
        [DllImport(DllName)]
        public static extern unsafe void glNamedBufferStorageEXT (uint buffer, int* size, void* data, uint flags);
        [DllImport(DllName)]
        public static extern unsafe void glNamedBufferSubData (uint buffer, int* offset, int* size, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glNamedBufferSubDataEXT (uint buffer, int* offset, int* size, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glNamedCopyBufferSubDataEXT (uint readBuffer, uint writeBuffer, int* readOffset, int* writeOffset, int* size);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferDrawBuffer (uint framebuffer, uint buf);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferDrawBuffers (uint framebuffer, int n, uint* bufs);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferParameteri (uint framebuffer, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferParameteriEXT (uint framebuffer, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferReadBuffer (uint framebuffer, uint src);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferRenderbuffer (uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferRenderbufferEXT (uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferSampleLocationsfvARB (uint framebuffer, uint start, int count, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferSampleLocationsfvNV (uint framebuffer, uint start, int count, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferTexture (uint framebuffer, uint attachment, uint texture, int level);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferTexture1DEXT (uint framebuffer, uint attachment, uint textarget, uint texture, int level);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferTexture2DEXT (uint framebuffer, uint attachment, uint textarget, uint texture, int level);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferTexture3DEXT (uint framebuffer, uint attachment, uint textarget, uint texture, int level, int zoffset);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferTextureEXT (uint framebuffer, uint attachment, uint texture, int level);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferTextureFaceEXT (uint framebuffer, uint attachment, uint texture, int level, uint face);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferTextureLayer (uint framebuffer, uint attachment, uint texture, int level, int layer);
        [DllImport(DllName)]
        public static extern unsafe void glNamedFramebufferTextureLayerEXT (uint framebuffer, uint attachment, uint texture, int level, int layer);
        [DllImport(DllName)]
        public static extern unsafe void glNamedProgramLocalParameter4dEXT (uint program, uint target, uint index, double x, double y, double z, double w);
        [DllImport(DllName)]
        public static extern unsafe void glNamedProgramLocalParameter4dvEXT (uint program, uint target, uint index, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glNamedProgramLocalParameter4fEXT (uint program, uint target, uint index, float x, float y, float z, float w);
        [DllImport(DllName)]
        public static extern unsafe void glNamedProgramLocalParameter4fvEXT (uint program, uint target, uint index, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glNamedProgramLocalParameterI4iEXT (uint program, uint target, uint index, int x, int y, int z, int w);
        [DllImport(DllName)]
        public static extern unsafe void glNamedProgramLocalParameterI4ivEXT (uint program, uint target, uint index, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glNamedProgramLocalParameterI4uiEXT (uint program, uint target, uint index, uint x, uint y, uint z, uint w);
        [DllImport(DllName)]
        public static extern unsafe void glNamedProgramLocalParameterI4uivEXT (uint program, uint target, uint index, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glNamedProgramLocalParameters4fvEXT (uint program, uint target, uint index, int count, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glNamedProgramLocalParametersI4ivEXT (uint program, uint target, uint index, int count, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glNamedProgramLocalParametersI4uivEXT (uint program, uint target, uint index, int count, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glNamedProgramStringEXT (uint program, uint target, uint format, int len, void* @string);
        [DllImport(DllName)]
        public static extern unsafe void glNamedRenderbufferStorage (uint renderbuffer, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glNamedRenderbufferStorageEXT (uint renderbuffer, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glNamedRenderbufferStorageMultisample (uint renderbuffer, int samples, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glNamedRenderbufferStorageMultisampleCoverageEXT (uint renderbuffer, int coverageSamples, int colorSamples, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glNamedRenderbufferStorageMultisampleEXT (uint renderbuffer, int samples, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glNamedStringARB (uint type, int namelen, char* name, int stringlen, char* @string);
        [DllImport(DllName)]
        public static extern unsafe void glNewList (uint list, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glNewObjectBufferATI (int size, void* pointer, uint usage);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3b (sbyte nx, sbyte ny, sbyte nz);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3bv (sbyte* v);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3d (double nx, double ny, double nz);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3dv (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3f (float nx, float ny, float nz);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3fVertex3fSUN (float nx, float ny, float nz, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3fVertex3fvSUN (float* n, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3fv (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3hNV (ushort nx, ushort ny, ushort nz);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3hvNV (ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3i (int nx, int ny, int nz);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3iv (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3s (short nx, short ny, short nz);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3sv (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3x (int nx, int ny, int nz);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3xOES (int nx, int ny, int nz);
        [DllImport(DllName)]
        public static extern unsafe void glNormal3xvOES (int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glNormalFormatNV (uint type, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glNormalP3ui (uint type, uint coords);
        [DllImport(DllName)]
        public static extern unsafe void glNormalP3uiv (uint type, uint* coords);
        [DllImport(DllName)]
        public static extern unsafe void glNormalPointer (uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glNormalPointerEXT (uint type, int stride, int count, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glNormalPointerListIBM (uint type, int stride, void* pointer, int ptrstride);
        [DllImport(DllName)]
        public static extern unsafe void glNormalPointervINTEL (uint type, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glNormalStream3bATI (uint stream, sbyte nx, sbyte ny, sbyte nz);
        [DllImport(DllName)]
        public static extern unsafe void glNormalStream3bvATI (uint stream, sbyte* coords);
        [DllImport(DllName)]
        public static extern unsafe void glNormalStream3dATI (uint stream, double nx, double ny, double nz);
        [DllImport(DllName)]
        public static extern unsafe void glNormalStream3dvATI (uint stream, double* coords);
        [DllImport(DllName)]
        public static extern unsafe void glNormalStream3fATI (uint stream, float nx, float ny, float nz);
        [DllImport(DllName)]
        public static extern unsafe void glNormalStream3fvATI (uint stream, float* coords);
        [DllImport(DllName)]
        public static extern unsafe void glNormalStream3iATI (uint stream, int nx, int ny, int nz);
        [DllImport(DllName)]
        public static extern unsafe void glNormalStream3ivATI (uint stream, int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glNormalStream3sATI (uint stream, short nx, short ny, short nz);
        [DllImport(DllName)]
        public static extern unsafe void glNormalStream3svATI (uint stream, short* coords);
        [DllImport(DllName)]
        public static extern unsafe void glObjectLabel (uint identifier, uint name, int length, char* label);
        [DllImport(DllName)]
        public static extern unsafe void glObjectLabelKHR (uint identifier, uint name, int length, char* label);
        [DllImport(DllName)]
        public static extern unsafe void glObjectPtrLabel (void* ptr, int length, char* label);
        [DllImport(DllName)]
        public static extern unsafe void glObjectPtrLabelKHR (void* ptr, int length, char* label);
        [DllImport(DllName)]
        public static extern unsafe void glObjectPurgeableAPPLE (uint objectType, uint name, uint option);
        [DllImport(DllName)]
        public static extern unsafe void glObjectUnpurgeableAPPLE (uint objectType, uint name, uint option);
        [DllImport(DllName)]
        public static extern unsafe void glOrtho (double left, double right, double bottom, double top, double zNear, double zFar);
        [DllImport(DllName)]
        public static extern unsafe void glOrthof (float l, float r, float b, float t, float n, float f);
        [DllImport(DllName)]
        public static extern unsafe void glOrthofOES (float l, float r, float b, float t, float n, float f);
        [DllImport(DllName)]
        public static extern unsafe void glOrthox (int l, int r, int b, int t, int n, int f);
        [DllImport(DllName)]
        public static extern unsafe void glOrthoxOES (int l, int r, int b, int t, int n, int f);
        [DllImport(DllName)]
        public static extern unsafe void glPNTrianglesfATI (uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glPNTrianglesiATI (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glPassTexCoordATI (uint dst, uint coord, uint swizzle);
        [DllImport(DllName)]
        public static extern unsafe void glPassThrough (float token);
        [DllImport(DllName)]
        public static extern unsafe void glPassThroughxOES (int token);
        [DllImport(DllName)]
        public static extern unsafe void glPatchParameterfv (uint pname, float* values);
        [DllImport(DllName)]
        public static extern unsafe void glPatchParameteri (uint pname, int value);
        [DllImport(DllName)]
        public static extern unsafe void glPatchParameteriEXT (uint pname, int value);
        [DllImport(DllName)]
        public static extern unsafe void glPatchParameteriOES (uint pname, int value);
        [DllImport(DllName)]
        public static extern unsafe void glPathColorGenNV (uint color, uint genMode, uint colorFormat, float* coeffs);
        [DllImport(DllName)]
        public static extern unsafe void glPathCommandsNV (uint path, int numCommands, byte* commands, int numCoords, uint coordType, void* coords);
        [DllImport(DllName)]
        public static extern unsafe void glPathCoordsNV (uint path, int numCoords, uint coordType, void* coords);
        [DllImport(DllName)]
        public static extern unsafe void glPathCoverDepthFuncNV (uint func);
        [DllImport(DllName)]
        public static extern unsafe void glPathDashArrayNV (uint path, int dashCount, float* dashArray);
        [DllImport(DllName)]
        public static extern unsafe void glPathFogGenNV (uint genMode);
        [DllImport(DllName)]
        public static extern unsafe void glPathGlyphIndexArrayNV (uint firstPathName, uint fontTarget, void* fontName, uint fontStyle, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale);
        [DllImport(DllName)]
        public static extern unsafe void glPathGlyphIndexRangeNV (uint fontTarget, void* fontName, uint fontStyle, uint pathParameterTemplate, float emScale, uint baseAndCount);
        [DllImport(DllName)]
        public static extern unsafe void glPathGlyphRangeNV (uint firstPathName, uint fontTarget, void* fontName, uint fontStyle, uint firstGlyph, int numGlyphs, uint handleMissingGlyphs, uint pathParameterTemplate, float emScale);
        [DllImport(DllName)]
        public static extern unsafe void glPathGlyphsNV (uint firstPathName, uint fontTarget, void* fontName, uint fontStyle, int numGlyphs, uint type, void* charcodes, uint handleMissingGlyphs, uint pathParameterTemplate, float emScale);
        [DllImport(DllName)]
        public static extern unsafe void glPathMemoryGlyphIndexArrayNV (uint firstPathName, uint fontTarget, int* fontSize, void* fontData, int faceIndex, uint firstGlyphIndex, int numGlyphs, uint pathParameterTemplate, float emScale);
        [DllImport(DllName)]
        public static extern unsafe void glPathParameterfNV (uint path, uint pname, float value);
        [DllImport(DllName)]
        public static extern unsafe void glPathParameterfvNV (uint path, uint pname, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glPathParameteriNV (uint path, uint pname, int value);
        [DllImport(DllName)]
        public static extern unsafe void glPathParameterivNV (uint path, uint pname, int* value);
        [DllImport(DllName)]
        public static extern unsafe void glPathStencilDepthOffsetNV (float factor, float units);
        [DllImport(DllName)]
        public static extern unsafe void glPathStencilFuncNV (uint func, int @ref, uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glPathStringNV (uint path, uint format, int length, void* pathString);
        [DllImport(DllName)]
        public static extern unsafe void glPathSubCommandsNV (uint path, int commandStart, int commandsToDelete, int numCommands, byte* commands, int numCoords, uint coordType, void* coords);
        [DllImport(DllName)]
        public static extern unsafe void glPathSubCoordsNV (uint path, int coordStart, int numCoords, uint coordType, void* coords);
        [DllImport(DllName)]
        public static extern unsafe void glPathTexGenNV (uint texCoordSet, uint genMode, int components, float* coeffs);
        [DllImport(DllName)]
        public static extern unsafe void glPauseTransformFeedback ();
        [DllImport(DllName)]
        public static extern unsafe void glPauseTransformFeedbackNV ();
        [DllImport(DllName)]
        public static extern unsafe void glPixelDataRangeNV (uint target, int length, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glPixelMapfv (uint map, int mapsize, float* values);
        [DllImport(DllName)]
        public static extern unsafe void glPixelMapuiv (uint map, int mapsize, uint* values);
        [DllImport(DllName)]
        public static extern unsafe void glPixelMapusv (uint map, int mapsize, ushort* values);
        [DllImport(DllName)]
        public static extern unsafe void glPixelMapx (uint map, int size, int* values);
        [DllImport(DllName)]
        public static extern unsafe void glPixelStoref (uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glPixelStorei (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glPixelStorex (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glPixelTexGenParameterfSGIS (uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glPixelTexGenParameterfvSGIS (uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glPixelTexGenParameteriSGIS (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glPixelTexGenParameterivSGIS (uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glPixelTexGenSGIX (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glPixelTransferf (uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glPixelTransferi (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glPixelTransferxOES (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glPixelTransformParameterfEXT (uint target, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glPixelTransformParameterfvEXT (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glPixelTransformParameteriEXT (uint target, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glPixelTransformParameterivEXT (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glPixelZoom (float xfactor, float yfactor);
        [DllImport(DllName)]
        public static extern unsafe void glPixelZoomxOES (int xfactor, int yfactor);
        [DllImport(DllName)]
        public static extern unsafe void glPointAlongPathNV (uint path, int startSegment, int numSegments, float distance, float* x, float* y, float* tangentX, float* tangentY);
        [DllImport(DllName)]
        public static extern unsafe void glPointParameterf (uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glPointParameterfARB (uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glPointParameterfEXT (uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glPointParameterfSGIS (uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glPointParameterfv (uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glPointParameterfvARB (uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glPointParameterfvEXT (uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glPointParameterfvSGIS (uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glPointParameteri (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glPointParameteriNV (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glPointParameteriv (uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glPointParameterivNV (uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glPointParameterx (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glPointParameterxOES (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glPointParameterxv (uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glPointParameterxvOES (uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glPointSize (float size);
        [DllImport(DllName)]
        public static extern unsafe void glPointSizePointerOES (uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glPointSizex (int size);
        [DllImport(DllName)]
        public static extern unsafe void glPointSizexOES (int size);
        [DllImport(DllName)]
        public static extern unsafe void glPollAsyncSGIX (uint* markerp);
        [DllImport(DllName)]
        public static extern unsafe void glPollInstrumentsSGIX (int* marker_p);
        [DllImport(DllName)]
        public static extern unsafe void glPolygonMode (uint face, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glPolygonModeNV (uint face, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glPolygonOffset (float factor, float units);
        [DllImport(DllName)]
        public static extern unsafe void glPolygonOffsetClampEXT (float factor, float units, float clamp);
        [DllImport(DllName)]
        public static extern unsafe void glPolygonOffsetEXT (float factor, float bias);
        [DllImport(DllName)]
        public static extern unsafe void glPolygonOffsetx (int factor, int units);
        [DllImport(DllName)]
        public static extern unsafe void glPolygonOffsetxOES (int factor, int units);
        [DllImport(DllName)]
        public static extern unsafe void glPolygonStipple (byte* mask);
        [DllImport(DllName)]
        public static extern unsafe void glPopAttrib ();
        [DllImport(DllName)]
        public static extern unsafe void glPopClientAttrib ();
        [DllImport(DllName)]
        public static extern unsafe void glPopDebugGroup ();
        [DllImport(DllName)]
        public static extern unsafe void glPopDebugGroupKHR ();
        [DllImport(DllName)]
        public static extern unsafe void glPopGroupMarkerEXT ();
        [DllImport(DllName)]
        public static extern unsafe void glPopMatrix ();
        [DllImport(DllName)]
        public static extern unsafe void glPopName ();
        [DllImport(DllName)]
        public static extern unsafe void glPresentFrameDualFillNV (uint video_slot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, uint type, uint target0, uint fill0, uint target1, uint fill1, uint target2, uint fill2, uint target3, uint fill3);
        [DllImport(DllName)]
        public static extern unsafe void glPresentFrameKeyedNV (uint video_slot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, uint type, uint target0, uint fill0, uint key0, uint target1, uint fill1, uint key1);
        [DllImport(DllName)]
        public static extern unsafe void glPrimitiveBoundingBox (float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
        [DllImport(DllName)]
        public static extern unsafe void glPrimitiveBoundingBoxARB (float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
        [DllImport(DllName)]
        public static extern unsafe void glPrimitiveBoundingBoxEXT (float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
        [DllImport(DllName)]
        public static extern unsafe void glPrimitiveBoundingBoxOES (float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW);
        [DllImport(DllName)]
        public static extern unsafe void glPrimitiveRestartIndex (uint index);
        [DllImport(DllName)]
        public static extern unsafe void glPrimitiveRestartIndexNV (uint index);
        [DllImport(DllName)]
        public static extern unsafe void glPrimitiveRestartNV ();
        [DllImport(DllName)]
        public static extern unsafe void glPrioritizeTextures (int n, uint* textures, float* priorities);
        [DllImport(DllName)]
        public static extern unsafe void glPrioritizeTexturesEXT (int n, uint* textures, float* priorities);
        [DllImport(DllName)]
        public static extern unsafe void glPrioritizeTexturesxOES (int n, uint* textures, int* priorities);
        [DllImport(DllName)]
        public static extern unsafe void glProgramBinary (uint program, uint binaryFormat, void* binary, int length);
        [DllImport(DllName)]
        public static extern unsafe void glProgramBinaryOES (uint program, uint binaryFormat, void* binary, int length);
        [DllImport(DllName)]
        public static extern unsafe void glProgramBufferParametersIivNV (uint target, uint bindingIndex, uint wordIndex, int count, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramBufferParametersIuivNV (uint target, uint bindingIndex, uint wordIndex, int count, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramBufferParametersfvNV (uint target, uint bindingIndex, uint wordIndex, int count, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramEnvParameter4dARB (uint target, uint index, double x, double y, double z, double w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramEnvParameter4dvARB (uint target, uint index, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramEnvParameter4fARB (uint target, uint index, float x, float y, float z, float w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramEnvParameter4fvARB (uint target, uint index, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramEnvParameterI4iNV (uint target, uint index, int x, int y, int z, int w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramEnvParameterI4ivNV (uint target, uint index, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramEnvParameterI4uiNV (uint target, uint index, uint x, uint y, uint z, uint w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramEnvParameterI4uivNV (uint target, uint index, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramEnvParameters4fvEXT (uint target, uint index, int count, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramEnvParametersI4ivNV (uint target, uint index, int count, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramEnvParametersI4uivNV (uint target, uint index, int count, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramLocalParameter4dARB (uint target, uint index, double x, double y, double z, double w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramLocalParameter4dvARB (uint target, uint index, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramLocalParameter4fARB (uint target, uint index, float x, float y, float z, float w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramLocalParameter4fvARB (uint target, uint index, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramLocalParameterI4iNV (uint target, uint index, int x, int y, int z, int w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramLocalParameterI4ivNV (uint target, uint index, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramLocalParameterI4uiNV (uint target, uint index, uint x, uint y, uint z, uint w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramLocalParameterI4uivNV (uint target, uint index, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramLocalParameters4fvEXT (uint target, uint index, int count, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramLocalParametersI4ivNV (uint target, uint index, int count, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramLocalParametersI4uivNV (uint target, uint index, int count, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramNamedParameter4dNV (uint id, int len, byte* name, double x, double y, double z, double w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramNamedParameter4dvNV (uint id, int len, byte* name, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glProgramNamedParameter4fNV (uint id, int len, byte* name, float x, float y, float z, float w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramNamedParameter4fvNV (uint id, int len, byte* name, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glProgramParameter4dNV (uint target, uint index, double x, double y, double z, double w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramParameter4dvNV (uint target, uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glProgramParameter4fNV (uint target, uint index, float x, float y, float z, float w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramParameter4fvNV (uint target, uint index, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glProgramParameteri (uint program, uint pname, int value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramParameteriARB (uint program, uint pname, int value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramParameteriEXT (uint program, uint pname, int value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramParameters4dvNV (uint target, uint index, int count, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glProgramParameters4fvNV (uint target, uint index, int count, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glProgramPathFragmentInputGenNV (uint program, int location, uint genMode, int components, float* coeffs);
        [DllImport(DllName)]
        public static extern unsafe void glProgramStringARB (uint target, uint format, int len, void* @string);
        [DllImport(DllName)]
        public static extern unsafe void glProgramSubroutineParametersuivNV (uint target, int count, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1d (uint program, int location, double v0);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1dEXT (uint program, int location, double x);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1dv (uint program, int location, int count, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1dvEXT (uint program, int location, int count, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1f (uint program, int location, float v0);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1fEXT (uint program, int location, float v0);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1fv (uint program, int location, int count, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1fvEXT (uint program, int location, int count, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1i (uint program, int location, int v0);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1i64ARB (uint program, int location, long x);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1i64NV (uint program, int location, long x);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1i64vARB (uint program, int location, int count, long* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1i64vNV (uint program, int location, int count, long* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1iEXT (uint program, int location, int v0);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1iv (uint program, int location, int count, int* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1ivEXT (uint program, int location, int count, int* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1ui (uint program, int location, uint v0);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1ui64ARB (uint program, int location, ulong x);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1ui64NV (uint program, int location, ulong x);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1ui64vARB (uint program, int location, int count, ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1ui64vNV (uint program, int location, int count, ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1uiEXT (uint program, int location, uint v0);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1uiv (uint program, int location, int count, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform1uivEXT (uint program, int location, int count, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2d (uint program, int location, double v0, double v1);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2dEXT (uint program, int location, double x, double y);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2dv (uint program, int location, int count, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2dvEXT (uint program, int location, int count, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2f (uint program, int location, float v0, float v1);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2fEXT (uint program, int location, float v0, float v1);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2fv (uint program, int location, int count, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2fvEXT (uint program, int location, int count, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2i (uint program, int location, int v0, int v1);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2i64ARB (uint program, int location, long x, long y);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2i64NV (uint program, int location, long x, long y);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2i64vARB (uint program, int location, int count, long* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2i64vNV (uint program, int location, int count, long* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2iEXT (uint program, int location, int v0, int v1);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2iv (uint program, int location, int count, int* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2ivEXT (uint program, int location, int count, int* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2ui (uint program, int location, uint v0, uint v1);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2ui64ARB (uint program, int location, ulong x, ulong y);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2ui64NV (uint program, int location, ulong x, ulong y);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2ui64vARB (uint program, int location, int count, ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2ui64vNV (uint program, int location, int count, ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2uiEXT (uint program, int location, uint v0, uint v1);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2uiv (uint program, int location, int count, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform2uivEXT (uint program, int location, int count, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3d (uint program, int location, double v0, double v1, double v2);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3dEXT (uint program, int location, double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3dv (uint program, int location, int count, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3dvEXT (uint program, int location, int count, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3f (uint program, int location, float v0, float v1, float v2);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3fEXT (uint program, int location, float v0, float v1, float v2);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3fv (uint program, int location, int count, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3fvEXT (uint program, int location, int count, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3i (uint program, int location, int v0, int v1, int v2);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3i64ARB (uint program, int location, long x, long y, long z);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3i64NV (uint program, int location, long x, long y, long z);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3i64vARB (uint program, int location, int count, long* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3i64vNV (uint program, int location, int count, long* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3iEXT (uint program, int location, int v0, int v1, int v2);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3iv (uint program, int location, int count, int* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3ivEXT (uint program, int location, int count, int* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3ui (uint program, int location, uint v0, uint v1, uint v2);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3ui64ARB (uint program, int location, ulong x, ulong y, ulong z);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3ui64NV (uint program, int location, ulong x, ulong y, ulong z);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3ui64vARB (uint program, int location, int count, ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3ui64vNV (uint program, int location, int count, ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3uiEXT (uint program, int location, uint v0, uint v1, uint v2);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3uiv (uint program, int location, int count, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform3uivEXT (uint program, int location, int count, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4d (uint program, int location, double v0, double v1, double v2, double v3);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4dEXT (uint program, int location, double x, double y, double z, double w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4dv (uint program, int location, int count, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4dvEXT (uint program, int location, int count, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4f (uint program, int location, float v0, float v1, float v2, float v3);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4fEXT (uint program, int location, float v0, float v1, float v2, float v3);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4fv (uint program, int location, int count, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4fvEXT (uint program, int location, int count, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4i (uint program, int location, int v0, int v1, int v2, int v3);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4i64ARB (uint program, int location, long x, long y, long z, long w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4i64NV (uint program, int location, long x, long y, long z, long w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4i64vARB (uint program, int location, int count, long* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4i64vNV (uint program, int location, int count, long* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4iEXT (uint program, int location, int v0, int v1, int v2, int v3);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4iv (uint program, int location, int count, int* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4ivEXT (uint program, int location, int count, int* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4ui (uint program, int location, uint v0, uint v1, uint v2, uint v3);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4ui64ARB (uint program, int location, ulong x, ulong y, ulong z, ulong w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4ui64NV (uint program, int location, ulong x, ulong y, ulong z, ulong w);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4ui64vARB (uint program, int location, int count, ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4ui64vNV (uint program, int location, int count, ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4uiEXT (uint program, int location, uint v0, uint v1, uint v2, uint v3);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4uiv (uint program, int location, int count, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniform4uivEXT (uint program, int location, int count, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformHandleui64ARB (uint program, int location, ulong value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformHandleui64NV (uint program, int location, ulong value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformHandleui64vARB (uint program, int location, int count, ulong* values);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformHandleui64vNV (uint program, int location, int count, ulong* values);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix2dv (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix2dvEXT (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix2fv (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix2fvEXT (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix2x3dv (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix2x3dvEXT (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix2x3fv (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix2x3fvEXT (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix2x4dv (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix2x4dvEXT (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix2x4fv (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix2x4fvEXT (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix3dv (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix3dvEXT (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix3fv (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix3fvEXT (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix3x2dv (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix3x2dvEXT (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix3x2fv (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix3x2fvEXT (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix3x4dv (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix3x4dvEXT (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix3x4fv (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix3x4fvEXT (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix4dv (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix4dvEXT (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix4fv (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix4fvEXT (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix4x2dv (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix4x2dvEXT (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix4x2fv (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix4x2fvEXT (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix4x3dv (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix4x3dvEXT (uint program, int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix4x3fv (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformMatrix4x3fvEXT (uint program, int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformui64NV (uint program, int location, ulong value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramUniformui64vNV (uint program, int location, int count, ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glProgramVertexLimitNV (uint target, int limit);
        [DllImport(DllName)]
        public static extern unsafe void glProvokingVertex (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glProvokingVertexEXT (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glPushAttrib (uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glPushClientAttrib (uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glPushClientAttribDefaultEXT (uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glPushDebugGroup (uint source, uint id, int length, char* message);
        [DllImport(DllName)]
        public static extern unsafe void glPushDebugGroupKHR (uint source, uint id, int length, char* message);
        [DllImport(DllName)]
        public static extern unsafe void glPushGroupMarkerEXT (int length, char* marker);
        [DllImport(DllName)]
        public static extern unsafe void glPushMatrix ();
        [DllImport(DllName)]
        public static extern unsafe void glPushName (uint name);
        [DllImport(DllName)]
        public static extern unsafe void glQueryCounter (uint id, uint target);
        [DllImport(DllName)]
        public static extern unsafe void glQueryCounterEXT (uint id, uint target);
        [DllImport(DllName)]
        public static extern unsafe void glQueryMatrixxOES (int* mantissa, int* exponent);
        [DllImport(DllName)]
        public static extern unsafe void glQueryObjectParameteruiAMD (uint target, uint id, uint pname, uint param);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos2d (double x, double y);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos2dv (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos2f (float x, float y);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos2fv (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos2i (int x, int y);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos2iv (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos2s (short x, short y);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos2sv (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos2xOES (int x, int y);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos2xvOES (int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos3d (double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos3dv (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos3f (float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos3fv (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos3i (int x, int y, int z);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos3iv (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos3s (short x, short y, short z);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos3sv (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos3xOES (int x, int y, int z);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos3xvOES (int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos4d (double x, double y, double z, double w);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos4dv (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos4f (float x, float y, float z, float w);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos4fv (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos4i (int x, int y, int z, int w);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos4iv (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos4s (short x, short y, short z, short w);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos4sv (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos4xOES (int x, int y, int z, int w);
        [DllImport(DllName)]
        public static extern unsafe void glRasterPos4xvOES (int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glRasterSamplesEXT (uint samples, bool fixedsamplelocations);
        [DllImport(DllName)]
        public static extern unsafe void glReadBuffer (uint src);
        [DllImport(DllName)]
        public static extern unsafe void glReadBufferIndexedEXT (uint src, int index);
        [DllImport(DllName)]
        public static extern unsafe void glReadBufferNV (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glReadInstrumentsSGIX (int marker);
        [DllImport(DllName)]
        public static extern unsafe void glReadPixels (int x, int y, int width, int height, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glReadnPixels (int x, int y, int width, int height, uint format, uint type, int bufSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glReadnPixelsARB (int x, int y, int width, int height, uint format, uint type, int bufSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glReadnPixelsEXT (int x, int y, int width, int height, uint format, uint type, int bufSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glReadnPixelsKHR (int x, int y, int width, int height, uint format, uint type, int bufSize, void* data);
        [DllImport(DllName)]
        public static extern unsafe void glRectd (double x1, double y1, double x2, double y2);
        [DllImport(DllName)]
        public static extern unsafe void glRectdv (double* v1, double* v2);
        [DllImport(DllName)]
        public static extern unsafe void glRectf (float x1, float y1, float x2, float y2);
        [DllImport(DllName)]
        public static extern unsafe void glRectfv (float* v1, float* v2);
        [DllImport(DllName)]
        public static extern unsafe void glRecti (int x1, int y1, int x2, int y2);
        [DllImport(DllName)]
        public static extern unsafe void glRectiv (int* v1, int* v2);
        [DllImport(DllName)]
        public static extern unsafe void glRects (short x1, short y1, short x2, short y2);
        [DllImport(DllName)]
        public static extern unsafe void glRectsv (short* v1, short* v2);
        [DllImport(DllName)]
        public static extern unsafe void glRectxOES (int x1, int y1, int x2, int y2);
        [DllImport(DllName)]
        public static extern unsafe void glRectxvOES (int* v1, int* v2);
        [DllImport(DllName)]
        public static extern unsafe void glReferencePlaneSGIX (double* equation);
        [DllImport(DllName)]
        public static extern unsafe void glReleaseShaderCompiler ();
        [DllImport(DllName)]
        public static extern unsafe void glRenderMode (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glRenderbufferStorage (uint target, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glRenderbufferStorageEXT (uint target, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glRenderbufferStorageMultisample (uint target, int samples, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glRenderbufferStorageMultisampleANGLE (uint target, int samples, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glRenderbufferStorageMultisampleAPPLE (uint target, int samples, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glRenderbufferStorageMultisampleCoverageNV (uint target, int coverageSamples, int colorSamples, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glRenderbufferStorageMultisampleEXT (uint target, int samples, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glRenderbufferStorageMultisampleIMG (uint target, int samples, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glRenderbufferStorageMultisampleNV (uint target, int samples, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glRenderbufferStorageOES (uint target, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodePointerSUN (uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeubSUN (byte code);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeubvSUN (byte* code);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiColor3fVertex3fSUN (uint rc, float r, float g, float b, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiColor3fVertex3fvSUN (uint* rc, float* c, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiColor4fNormal3fVertex3fSUN (uint rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiColor4fNormal3fVertex3fvSUN (uint* rc, float* c, float* n, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiColor4ubVertex3fSUN (uint rc, byte r, byte g, byte b, byte a, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiColor4ubVertex3fvSUN (uint* rc, byte* c, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiNormal3fVertex3fSUN (uint rc, float nx, float ny, float nz, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiNormal3fVertex3fvSUN (uint* rc, float* n, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiSUN (uint code);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN (uint rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN (uint* rc, float* tc, float* c, float* n, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN (uint rc, float s, float t, float nx, float ny, float nz, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN (uint* rc, float* tc, float* n, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiTexCoord2fVertex3fSUN (uint rc, float s, float t, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiTexCoord2fVertex3fvSUN (uint* rc, float* tc, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiVertex3fSUN (uint rc, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuiVertex3fvSUN (uint* rc, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeuivSUN (uint* code);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeusSUN (ushort code);
        [DllImport(DllName)]
        public static extern unsafe void glReplacementCodeusvSUN (ushort* code);
        [DllImport(DllName)]
        public static extern unsafe void glRequestResidentProgramsNV (int n, uint* programs);
        [DllImport(DllName)]
        public static extern unsafe void glResetHistogram (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glResetHistogramEXT (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glResetMinmax (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glResetMinmaxEXT (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glResizeBuffersMESA ();
        [DllImport(DllName)]
        public static extern unsafe void glResolveDepthValuesNV ();
        [DllImport(DllName)]
        public static extern unsafe void glResolveMultisampleFramebufferAPPLE ();
        [DllImport(DllName)]
        public static extern unsafe void glResumeTransformFeedback ();
        [DllImport(DllName)]
        public static extern unsafe void glResumeTransformFeedbackNV ();
        [DllImport(DllName)]
        public static extern unsafe void glRotated (double angle, double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glRotatef (float angle, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glRotatex (int angle, int x, int y, int z);
        [DllImport(DllName)]
        public static extern unsafe void glRotatexOES (int angle, int x, int y, int z);
        [DllImport(DllName)]
        public static extern unsafe void glSampleCoverage (float value, bool invert);
        [DllImport(DllName)]
        public static extern unsafe void glSampleCoverageARB (float value, bool invert);
        [DllImport(DllName)]
        public static extern unsafe void glSampleCoveragex (int value, bool invert);
        [DllImport(DllName)]
        public static extern unsafe void glSampleCoveragexOES (int value, bool invert);
        [DllImport(DllName)]
        public static extern unsafe void glSampleMapATI (uint dst, uint interp, uint swizzle);
        [DllImport(DllName)]
        public static extern unsafe void glSampleMaskEXT (float value, bool invert);
        [DllImport(DllName)]
        public static extern unsafe void glSampleMaskIndexedNV (uint index, uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glSampleMaskSGIS (float value, bool invert);
        [DllImport(DllName)]
        public static extern unsafe void glSampleMaski (uint maskNumber, uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glSamplePatternEXT (uint pattern);
        [DllImport(DllName)]
        public static extern unsafe void glSamplePatternSGIS (uint pattern);
        [DllImport(DllName)]
        public static extern unsafe void glSamplerParameterIiv (uint sampler, uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glSamplerParameterIivEXT (uint sampler, uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glSamplerParameterIivOES (uint sampler, uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glSamplerParameterIuiv (uint sampler, uint pname, uint* param);
        [DllImport(DllName)]
        public static extern unsafe void glSamplerParameterIuivEXT (uint sampler, uint pname, uint* param);
        [DllImport(DllName)]
        public static extern unsafe void glSamplerParameterIuivOES (uint sampler, uint pname, uint* param);
        [DllImport(DllName)]
        public static extern unsafe void glSamplerParameterf (uint sampler, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glSamplerParameterfv (uint sampler, uint pname, float* param);
        [DllImport(DllName)]
        public static extern unsafe void glSamplerParameteri (uint sampler, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glSamplerParameteriv (uint sampler, uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glScaled (double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glScalef (float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glScalex (int x, int y, int z);
        [DllImport(DllName)]
        public static extern unsafe void glScalexOES (int x, int y, int z);
        [DllImport(DllName)]
        public static extern unsafe void glScissor (int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glScissorArrayv (uint first, int count, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glScissorArrayvNV (uint first, int count, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glScissorIndexed (uint index, int left, int bottom, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glScissorIndexedNV (uint index, int left, int bottom, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glScissorIndexedv (uint index, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glScissorIndexedvNV (uint index, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3b (sbyte red, sbyte green, sbyte blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3bEXT (sbyte red, sbyte green, sbyte blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3bv (sbyte* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3bvEXT (sbyte* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3d (double red, double green, double blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3dEXT (double red, double green, double blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3dv (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3dvEXT (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3f (float red, float green, float blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3fEXT (float red, float green, float blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3fv (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3fvEXT (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3hNV (ushort red, ushort green, ushort blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3hvNV (ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3i (int red, int green, int blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3iEXT (int red, int green, int blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3iv (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3ivEXT (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3s (short red, short green, short blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3sEXT (short red, short green, short blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3sv (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3svEXT (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3ub (byte red, byte green, byte blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3ubEXT (byte red, byte green, byte blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3ubv (byte* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3ubvEXT (byte* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3ui (uint red, uint green, uint blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3uiEXT (uint red, uint green, uint blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3uiv (uint* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3uivEXT (uint* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3us (ushort red, ushort green, ushort blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3usEXT (ushort red, ushort green, ushort blue);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3usv (ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColor3usvEXT (ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColorFormatNV (int size, uint type, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColorP3ui (uint type, uint color);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColorP3uiv (uint type, uint* color);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColorPointer (int size, uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColorPointerEXT (int size, uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glSecondaryColorPointerListIBM (int size, uint type, int stride, void* pointer, int ptrstride);
        [DllImport(DllName)]
        public static extern unsafe void glSelectBuffer (int size, uint* buffer);
        [DllImport(DllName)]
        public static extern unsafe void glSelectPerfMonitorCountersAMD (uint monitor, bool enable, uint group, int numCounters, uint* counterList);
        [DllImport(DllName)]
        public static extern unsafe void glSeparableFilter2D (uint target, uint internalformat, int width, int height, uint format, uint type, void* row, void* column);
        [DllImport(DllName)]
        public static extern unsafe void glSeparableFilter2DEXT (uint target, uint internalformat, int width, int height, uint format, uint type, void* row, void* column);
        [DllImport(DllName)]
        public static extern unsafe void glSetFenceAPPLE (uint fence);
        [DllImport(DllName)]
        public static extern unsafe void glSetFenceNV (uint fence, uint condition);
        [DllImport(DllName)]
        public static extern unsafe void glSetFragmentShaderConstantATI (uint dst, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glSetInvariantEXT (uint id, uint type, void* addr);
        [DllImport(DllName)]
        public static extern unsafe void glSetLocalConstantEXT (uint id, uint type, void* addr);
        [DllImport(DllName)]
        public static extern unsafe void glSetMultisamplefvAMD (uint pname, uint index, float* val);
        [DllImport(DllName)]
        public static extern unsafe void glShadeModel (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glShaderBinary (int count, uint* shaders, uint binaryformat, void* binary, int length);
        [DllImport(DllName)]
        public static extern unsafe void glShaderOp1EXT (uint op, uint res, uint arg1);
        [DllImport(DllName)]
        public static extern unsafe void glShaderOp2EXT (uint op, uint res, uint arg1, uint arg2);
        [DllImport(DllName)]
        public static extern unsafe void glShaderOp3EXT (uint op, uint res, uint arg1, uint arg2, uint arg3);
        [DllImport(DllName)]
        public static extern unsafe void glShaderSource (uint shader, int count, char* @string, int* length);
        [DllImport(DllName)]
        public static extern unsafe void glShaderSourceARB (void* shaderObj, int count, char* @string, int* length);
        [DllImport(DllName)]
        public static extern unsafe void glShaderStorageBlockBinding (uint program, uint storageBlockIndex, uint storageBlockBinding);
        [DllImport(DllName)]
        public static extern unsafe void glSharpenTexFuncSGIS (uint target, int n, float* points);
        [DllImport(DllName)]
        public static extern unsafe void glSpriteParameterfSGIX (uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glSpriteParameterfvSGIX (uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glSpriteParameteriSGIX (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glSpriteParameterivSGIX (uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glStartInstrumentsSGIX ();
        [DllImport(DllName)]
        public static extern unsafe void glStartTilingQCOM (uint x, uint y, uint width, uint height, uint preserveMask);
        [DllImport(DllName)]
        public static extern unsafe void glStateCaptureNV (uint state, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glStencilClearTagEXT (int stencilTagBits, uint stencilClearTag);
        [DllImport(DllName)]
        public static extern unsafe void glStencilFillPathInstancedNV (int numPaths, uint pathNameType, void* paths, uint pathBase, uint fillMode, uint mask, uint transformType, float* transformValues);
        [DllImport(DllName)]
        public static extern unsafe void glStencilFillPathNV (uint path, uint fillMode, uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glStencilFunc (uint func, int @ref, uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glStencilFuncSeparate (uint face, uint func, int @ref, uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glStencilFuncSeparateATI (uint frontfunc, uint backfunc, int @ref, uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glStencilMask (uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glStencilMaskSeparate (uint face, uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glStencilOp (uint fail, uint zfail, uint zpass);
        [DllImport(DllName)]
        public static extern unsafe void glStencilOpSeparate (uint face, uint sfail, uint dpfail, uint dppass);
        [DllImport(DllName)]
        public static extern unsafe void glStencilOpSeparateATI (uint face, uint sfail, uint dpfail, uint dppass);
        [DllImport(DllName)]
        public static extern unsafe void glStencilOpValueAMD (uint face, uint value);
        [DllImport(DllName)]
        public static extern unsafe void glStencilStrokePathInstancedNV (int numPaths, uint pathNameType, void* paths, uint pathBase, int reference, uint mask, uint transformType, float* transformValues);
        [DllImport(DllName)]
        public static extern unsafe void glStencilStrokePathNV (uint path, int reference, uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glStencilThenCoverFillPathInstancedNV (int numPaths, uint pathNameType, void* paths, uint pathBase, uint fillMode, uint mask, uint coverMode, uint transformType, float* transformValues);
        [DllImport(DllName)]
        public static extern unsafe void glStencilThenCoverFillPathNV (uint path, uint fillMode, uint mask, uint coverMode);
        [DllImport(DllName)]
        public static extern unsafe void glStencilThenCoverStrokePathInstancedNV (int numPaths, uint pathNameType, void* paths, uint pathBase, int reference, uint mask, uint coverMode, uint transformType, float* transformValues);
        [DllImport(DllName)]
        public static extern unsafe void glStencilThenCoverStrokePathNV (uint path, int reference, uint mask, uint coverMode);
        [DllImport(DllName)]
        public static extern unsafe void glStopInstrumentsSGIX (int marker);
        [DllImport(DllName)]
        public static extern unsafe void glStringMarkerGREMEDY (int len, void* @string);
        [DllImport(DllName)]
        public static extern unsafe void glSubpixelPrecisionBiasNV (uint xbits, uint ybits);
        [DllImport(DllName)]
        public static extern unsafe void glSwizzleEXT (uint res, uint @in, uint outX, uint outY, uint outZ, uint outW);
        [DllImport(DllName)]
        public static extern unsafe void glSyncTextureINTEL (uint texture);
        [DllImport(DllName)]
        public static extern unsafe void glTagSampleBufferSGIX ();
        [DllImport(DllName)]
        public static extern unsafe void glTangent3bEXT (sbyte tx, sbyte ty, sbyte tz);
        [DllImport(DllName)]
        public static extern unsafe void glTangent3bvEXT (sbyte* v);
        [DllImport(DllName)]
        public static extern unsafe void glTangent3dEXT (double tx, double ty, double tz);
        [DllImport(DllName)]
        public static extern unsafe void glTangent3dvEXT (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glTangent3fEXT (float tx, float ty, float tz);
        [DllImport(DllName)]
        public static extern unsafe void glTangent3fvEXT (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glTangent3iEXT (int tx, int ty, int tz);
        [DllImport(DllName)]
        public static extern unsafe void glTangent3ivEXT (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glTangent3sEXT (short tx, short ty, short tz);
        [DllImport(DllName)]
        public static extern unsafe void glTangent3svEXT (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glTangentPointerEXT (uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glTbufferMask3DFX (uint mask);
        [DllImport(DllName)]
        public static extern unsafe void glTessellationFactorAMD (float factor);
        [DllImport(DllName)]
        public static extern unsafe void glTessellationModeAMD (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glTestFenceAPPLE (uint fence);
        [DllImport(DllName)]
        public static extern unsafe void glTestFenceNV (uint fence);
        [DllImport(DllName)]
        public static extern unsafe void glTestObjectAPPLE (uint @object, uint name);
        [DllImport(DllName)]
        public static extern unsafe void glTexBuffer (uint target, uint internalformat, uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glTexBufferARB (uint target, uint internalformat, uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glTexBufferEXT (uint target, uint internalformat, uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glTexBufferOES (uint target, uint internalformat, uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glTexBufferRange (uint target, uint internalformat, uint buffer, int* offset, int* size);
        [DllImport(DllName)]
        public static extern unsafe void glTexBufferRangeEXT (uint target, uint internalformat, uint buffer, int* offset, int* size);
        [DllImport(DllName)]
        public static extern unsafe void glTexBufferRangeOES (uint target, uint internalformat, uint buffer, int* offset, int* size);
        [DllImport(DllName)]
        public static extern unsafe void glTexBumpParameterfvATI (uint pname, float* param);
        [DllImport(DllName)]
        public static extern unsafe void glTexBumpParameterivATI (uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord1bOES (sbyte s);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord1bvOES (sbyte* coords);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord1d (double s);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord1dv (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord1f (float s);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord1fv (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord1hNV (ushort s);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord1hvNV (ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord1i (int s);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord1iv (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord1s (short s);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord1sv (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord1xOES (int s);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord1xvOES (int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2bOES (sbyte s, sbyte t);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2bvOES (sbyte* coords);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2d (double s, double t);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2dv (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2f (float s, float t);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2fColor3fVertex3fSUN (float s, float t, float r, float g, float b, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2fColor3fVertex3fvSUN (float* tc, float* c, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2fColor4fNormal3fVertex3fSUN (float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2fColor4fNormal3fVertex3fvSUN (float* tc, float* c, float* n, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2fColor4ubVertex3fSUN (float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2fColor4ubVertex3fvSUN (float* tc, byte* c, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2fNormal3fVertex3fSUN (float s, float t, float nx, float ny, float nz, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2fNormal3fVertex3fvSUN (float* tc, float* n, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2fVertex3fSUN (float s, float t, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2fVertex3fvSUN (float* tc, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2fv (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2hNV (ushort s, ushort t);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2hvNV (ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2i (int s, int t);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2iv (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2s (short s, short t);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2sv (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2xOES (int s, int t);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord2xvOES (int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord3bOES (sbyte s, sbyte t, sbyte r);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord3bvOES (sbyte* coords);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord3d (double s, double t, double r);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord3dv (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord3f (float s, float t, float r);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord3fv (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord3hNV (ushort s, ushort t, ushort r);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord3hvNV (ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord3i (int s, int t, int r);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord3iv (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord3s (short s, short t, short r);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord3sv (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord3xOES (int s, int t, int r);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord3xvOES (int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4bOES (sbyte s, sbyte t, sbyte r, sbyte q);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4bvOES (sbyte* coords);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4d (double s, double t, double r, double q);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4dv (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4f (float s, float t, float r, float q);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4fColor4fNormal3fVertex4fSUN (float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4fColor4fNormal3fVertex4fvSUN (float* tc, float* c, float* n, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4fVertex4fSUN (float s, float t, float p, float q, float x, float y, float z, float w);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4fVertex4fvSUN (float* tc, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4fv (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4hNV (ushort s, ushort t, ushort r, ushort q);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4hvNV (ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4i (int s, int t, int r, int q);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4iv (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4s (short s, short t, short r, short q);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4sv (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4xOES (int s, int t, int r, int q);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoord4xvOES (int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoordFormatNV (int size, uint type, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoordP1ui (uint type, uint coords);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoordP1uiv (uint type, uint* coords);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoordP2ui (uint type, uint coords);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoordP2uiv (uint type, uint* coords);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoordP3ui (uint type, uint coords);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoordP3uiv (uint type, uint* coords);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoordP4ui (uint type, uint coords);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoordP4uiv (uint type, uint* coords);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoordPointer (int size, uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoordPointerEXT (int size, uint type, int stride, int count, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoordPointerListIBM (int size, uint type, int stride, void* pointer, int ptrstride);
        [DllImport(DllName)]
        public static extern unsafe void glTexCoordPointervINTEL (int size, uint type, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glTexEnvf (uint target, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glTexEnvfv (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexEnvi (uint target, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glTexEnviv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexEnvx (uint target, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glTexEnvxOES (uint target, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glTexEnvxv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexEnvxvOES (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexFilterFuncSGIS (uint target, uint filter, int n, float* weights);
        [DllImport(DllName)]
        public static extern unsafe void glTexGend (uint coord, uint pname, double param);
        [DllImport(DllName)]
        public static extern unsafe void glTexGendv (uint coord, uint pname, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexGenf (uint coord, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glTexGenfOES (uint coord, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glTexGenfv (uint coord, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexGenfvOES (uint coord, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexGeni (uint coord, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glTexGeniOES (uint coord, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glTexGeniv (uint coord, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexGenivOES (uint coord, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexGenxOES (uint coord, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glTexGenxvOES (uint coord, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexImage1D (uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTexImage2D (uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTexImage2DMultisample (uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
        [DllImport(DllName)]
        public static extern unsafe void glTexImage2DMultisampleCoverageNV (uint target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, bool fixedSampleLocations);
        [DllImport(DllName)]
        public static extern unsafe void glTexImage3D (uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTexImage3DEXT (uint target, int level, uint internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTexImage3DMultisample (uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
        [DllImport(DllName)]
        public static extern unsafe void glTexImage3DMultisampleCoverageNV (uint target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, int depth, bool fixedSampleLocations);
        [DllImport(DllName)]
        public static extern unsafe void glTexImage3DOES (uint target, int level, uint internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTexImage4DSGIS (uint target, int level, uint internalformat, int width, int height, int depth, int size4d, int border, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTexPageCommitmentARB (uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit);
        [DllImport(DllName)]
        public static extern unsafe void glTexPageCommitmentEXT (uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit);
        [DllImport(DllName)]
        public static extern unsafe void glTexParameterIiv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexParameterIivEXT (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexParameterIivOES (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexParameterIuiv (uint target, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexParameterIuivEXT (uint target, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexParameterIuivOES (uint target, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexParameterf (uint target, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glTexParameterfv (uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexParameteri (uint target, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glTexParameteriv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexParameterx (uint target, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glTexParameterxOES (uint target, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glTexParameterxv (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexParameterxvOES (uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTexRenderbufferNV (uint target, uint renderbuffer);
        [DllImport(DllName)]
        public static extern unsafe void glTexStorage1D (uint target, int levels, uint internalformat, int width);
        [DllImport(DllName)]
        public static extern unsafe void glTexStorage1DEXT (uint target, int levels, uint internalformat, int width);
        [DllImport(DllName)]
        public static extern unsafe void glTexStorage2D (uint target, int levels, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glTexStorage2DEXT (uint target, int levels, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glTexStorage2DMultisample (uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
        [DllImport(DllName)]
        public static extern unsafe void glTexStorage3D (uint target, int levels, uint internalformat, int width, int height, int depth);
        [DllImport(DllName)]
        public static extern unsafe void glTexStorage3DEXT (uint target, int levels, uint internalformat, int width, int height, int depth);
        [DllImport(DllName)]
        public static extern unsafe void glTexStorage3DMultisample (uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
        [DllImport(DllName)]
        public static extern unsafe void glTexStorage3DMultisampleOES (uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
        [DllImport(DllName)]
        public static extern unsafe void glTexStorageSparseAMD (uint target, uint internalFormat, int width, int height, int depth, int layers, uint flags);
        [DllImport(DllName)]
        public static extern unsafe void glTexSubImage1D (uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTexSubImage1DEXT (uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTexSubImage2D (uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTexSubImage2DEXT (uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTexSubImage3D (uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTexSubImage3DEXT (uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTexSubImage3DOES (uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTexSubImage4DSGIS (uint target, int level, int xoffset, int yoffset, int zoffset, int woffset, int width, int height, int depth, int size4d, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTextureBarrier ();
        [DllImport(DllName)]
        public static extern unsafe void glTextureBarrierNV ();
        [DllImport(DllName)]
        public static extern unsafe void glTextureBuffer (uint texture, uint internalformat, uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glTextureBufferEXT (uint texture, uint target, uint internalformat, uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glTextureBufferRange (uint texture, uint internalformat, uint buffer, int* offset, int* size);
        [DllImport(DllName)]
        public static extern unsafe void glTextureBufferRangeEXT (uint texture, uint target, uint internalformat, uint buffer, int* offset, int* size);
        [DllImport(DllName)]
        public static extern unsafe void glTextureColorMaskSGIS (bool red, bool green, bool blue, bool alpha);
        [DllImport(DllName)]
        public static extern unsafe void glTextureImage1DEXT (uint texture, uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTextureImage2DEXT (uint texture, uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTextureImage2DMultisampleCoverageNV (uint texture, uint target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, bool fixedSampleLocations);
        [DllImport(DllName)]
        public static extern unsafe void glTextureImage2DMultisampleNV (uint texture, uint target, int samples, int internalFormat, int width, int height, bool fixedSampleLocations);
        [DllImport(DllName)]
        public static extern unsafe void glTextureImage3DEXT (uint texture, uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTextureImage3DMultisampleCoverageNV (uint texture, uint target, int coverageSamples, int colorSamples, int internalFormat, int width, int height, int depth, bool fixedSampleLocations);
        [DllImport(DllName)]
        public static extern unsafe void glTextureImage3DMultisampleNV (uint texture, uint target, int samples, int internalFormat, int width, int height, int depth, bool fixedSampleLocations);
        [DllImport(DllName)]
        public static extern unsafe void glTextureLightEXT (uint pname);
        [DllImport(DllName)]
        public static extern unsafe void glTextureMaterialEXT (uint face, uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glTextureNormalEXT (uint mode);
        [DllImport(DllName)]
        public static extern unsafe void glTexturePageCommitmentEXT (uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, bool commit);
        [DllImport(DllName)]
        public static extern unsafe void glTextureParameterIiv (uint texture, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTextureParameterIivEXT (uint texture, uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTextureParameterIuiv (uint texture, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTextureParameterIuivEXT (uint texture, uint target, uint pname, uint* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTextureParameterf (uint texture, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glTextureParameterfEXT (uint texture, uint target, uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glTextureParameterfv (uint texture, uint pname, float* param);
        [DllImport(DllName)]
        public static extern unsafe void glTextureParameterfvEXT (uint texture, uint target, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTextureParameteri (uint texture, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glTextureParameteriEXT (uint texture, uint target, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glTextureParameteriv (uint texture, uint pname, int* param);
        [DllImport(DllName)]
        public static extern unsafe void glTextureParameterivEXT (uint texture, uint target, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glTextureRangeAPPLE (uint target, int length, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glTextureRenderbufferEXT (uint texture, uint target, uint renderbuffer);
        [DllImport(DllName)]
        public static extern unsafe void glTextureStorage1D (uint texture, int levels, uint internalformat, int width);
        [DllImport(DllName)]
        public static extern unsafe void glTextureStorage1DEXT (uint texture, uint target, int levels, uint internalformat, int width);
        [DllImport(DllName)]
        public static extern unsafe void glTextureStorage2D (uint texture, int levels, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glTextureStorage2DEXT (uint texture, uint target, int levels, uint internalformat, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glTextureStorage2DMultisample (uint texture, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
        [DllImport(DllName)]
        public static extern unsafe void glTextureStorage2DMultisampleEXT (uint texture, uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
        [DllImport(DllName)]
        public static extern unsafe void glTextureStorage3D (uint texture, int levels, uint internalformat, int width, int height, int depth);
        [DllImport(DllName)]
        public static extern unsafe void glTextureStorage3DEXT (uint texture, uint target, int levels, uint internalformat, int width, int height, int depth);
        [DllImport(DllName)]
        public static extern unsafe void glTextureStorage3DMultisample (uint texture, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
        [DllImport(DllName)]
        public static extern unsafe void glTextureStorage3DMultisampleEXT (uint texture, uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
        [DllImport(DllName)]
        public static extern unsafe void glTextureStorageSparseAMD (uint texture, uint target, uint internalFormat, int width, int height, int depth, int layers, uint flags);
        [DllImport(DllName)]
        public static extern unsafe void glTextureSubImage1D (uint texture, int level, int xoffset, int width, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTextureSubImage1DEXT (uint texture, uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTextureSubImage2D (uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTextureSubImage2DEXT (uint texture, uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTextureSubImage3D (uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTextureSubImage3DEXT (uint texture, uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);
        [DllImport(DllName)]
        public static extern unsafe void glTextureView (uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
        [DllImport(DllName)]
        public static extern unsafe void glTextureViewEXT (uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
        [DllImport(DllName)]
        public static extern unsafe void glTextureViewOES (uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
        [DllImport(DllName)]
        public static extern unsafe void glTrackMatrixNV (uint target, uint address, uint matrix, uint transform);
        [DllImport(DllName)]
        public static extern unsafe void glTransformFeedbackAttribsNV (int count, int* attribs, uint bufferMode);
        [DllImport(DllName)]
        public static extern unsafe void glTransformFeedbackBufferBase (uint xfb, uint index, uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glTransformFeedbackBufferRange (uint xfb, uint index, uint buffer, int* offset, int* size);
        [DllImport(DllName)]
        public static extern unsafe void glTransformFeedbackStreamAttribsNV (int count, int* attribs, int nbuffers, int* bufstreams, uint bufferMode);
        [DllImport(DllName)]
        public static extern unsafe void glTransformFeedbackVaryings (uint program, int count, char* varyings, uint bufferMode);
        [DllImport(DllName)]
        public static extern unsafe void glTransformFeedbackVaryingsEXT (uint program, int count, char* varyings, uint bufferMode);
        [DllImport(DllName)]
        public static extern unsafe void glTransformFeedbackVaryingsNV (uint program, int count, int* locations, uint bufferMode);
        [DllImport(DllName)]
        public static extern unsafe void glTransformPathNV (uint resultPath, uint srcPath, uint transformType, float* transformValues);
        [DllImport(DllName)]
        public static extern unsafe void glTranslated (double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glTranslatef (float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glTranslatex (int x, int y, int z);
        [DllImport(DllName)]
        public static extern unsafe void glTranslatexOES (int x, int y, int z);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1d (int location, double x);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1dv (int location, int count, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1f (int location, float v0);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1fARB (int location, float v0);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1fv (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1fvARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)]  float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1i (int location, int v0);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1i64ARB (int location, long x);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1i64NV (int location, long x);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1i64vARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] long* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1i64vNV (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] long* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1iARB (int location, int v0);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1iv (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] int* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1ivARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] int* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1ui (int location, uint v0);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1ui64ARB (int location, ulong x);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1ui64NV (int location, ulong x);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1ui64vARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1ui64vNV (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1uiEXT (int location, uint v0);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1uiv (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform1uivEXT (int location, int count, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2d (int location, double x, double y);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2dv (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] double* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2f (int location, float v0, float v1);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2fARB (int location, float v0, float v1);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2fv (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2fvARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2i (int location, int v0, int v1);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2i64ARB (int location, long x, long y);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2i64NV (int location, long x, long y);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2i64vARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] long* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2i64vNV (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] long* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2iARB (int location, int v0, int v1);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2iv (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] int* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2ivARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] int* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2ui (int location, uint v0, uint v1);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2ui64ARB (int location, ulong x, ulong y);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2ui64NV (int location, ulong x, ulong y);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2ui64vARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2ui64vNV (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2uiEXT (int location, uint v0, uint v1);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2uiv (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform2uivEXT (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3d (int location, double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3dv (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] double* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3f (int location, float v0, float v1, float v2);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3fARB (int location, float v0, float v1, float v2);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3fv (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3fvARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3i (int location, int v0, int v1, int v2);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3i64ARB (int location, long x, long y, long z);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3i64NV (int location, long x, long y, long z);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3i64vARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] long* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3i64vNV (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] long* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3iARB (int location, int v0, int v1, int v2);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3iv (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] int* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3ivARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] int* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3ui (int location, uint v0, uint v1, uint v2);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3ui64ARB (int location, ulong x, ulong y, ulong z);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3ui64NV (int location, ulong x, ulong y, ulong z);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3ui64vARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3ui64vNV (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3uiEXT (int location, uint v0, uint v1, uint v2);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3uiv (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform3uivEXT (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4d (int location, double x, double y, double z, double w);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4dv (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] double* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4f (int location, float v0, float v1, float v2, float v3);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4fARB (int location, float v0, float v1, float v2, float v3);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4fv (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4fvARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4i (int location, int v0, int v1, int v2, int v3);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4i64ARB (int location, long x, long y, long z, long w);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4i64NV (int location, long x, long y, long z, long w);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4i64vARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] long* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4i64vNV (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] long* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4iARB (int location, int v0, int v1, int v2, int v3);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4iv (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] int* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4ivARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] int* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4ui (int location, uint v0, uint v1, uint v2, uint v3);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4ui64ARB (int location, ulong x, ulong y, ulong z, ulong w);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4ui64NV (int location, ulong x, ulong y, ulong z, ulong w);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4ui64vARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4ui64vNV (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4uiEXT (int location, uint v0, uint v1, uint v2, uint v3);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4uiv (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniform4uivEXT (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformBlockBinding (uint program, uint uniformBlockIndex, uint uniformBlockBinding);
        [DllImport(DllName)]
        public static extern unsafe void glUniformBufferEXT (uint program, int location, uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glUniformHandleui64ARB (int location, ulong value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformHandleui64NV (int location, ulong value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformHandleui64vARB (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformHandleui64vNV (int location, int count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix2dv (int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix2fv (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix2fvARB (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix2x3dv (int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix2x3fv (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix2x3fvNV (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix2x4dv (int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix2x4fv (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix2x4fvNV (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix3dv (int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix3fv (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix3fvARB (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix3x2dv (int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix3x2fv (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix3x2fvNV (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix3x4dv (int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix3x4fv (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix3x4fvNV (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix4dv (int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix4fv (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix4fvARB (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix4x2dv (int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix4x2fv (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix4x2fvNV (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix4x3dv (int location, int count, bool transpose, double* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix4x3fv (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformMatrix4x3fvNV (int location, int count, bool transpose, float* value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformSubroutinesuiv (uint shadertype, int count, uint* indices);
        [DllImport(DllName)]
        public static extern unsafe void glUniformui64NV (int location, ulong value);
        [DllImport(DllName)]
        public static extern unsafe void glUniformui64vNV (int location, int count, ulong* value);
        [DllImport(DllName)]
        public static extern unsafe void glUnlockArraysEXT ();
        [DllImport(DllName)]
        public static extern unsafe void glUnmapBuffer (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glUnmapBufferARB (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glUnmapBufferOES (uint target);
        [DllImport(DllName)]
        public static extern unsafe void glUnmapNamedBuffer (uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glUnmapNamedBufferEXT (uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glUnmapObjectBufferATI (uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glUnmapTexture2DINTEL (uint texture, int level);
        [DllImport(DllName)]
        public static extern unsafe void glUpdateObjectBufferATI (uint buffer, uint offset, int size, void* pointer, uint preserve);
        [DllImport(DllName)]
        public static extern unsafe void glUseProgram (uint program);
        [DllImport(DllName)]
        public static extern unsafe void glUseProgramObjectARB (void* programObj);
        [DllImport(DllName)]
        public static extern unsafe void glUseProgramStages (uint pipeline, uint stages, uint program);
        [DllImport(DllName)]
        public static extern unsafe void glUseProgramStagesEXT (uint pipeline, uint stages, uint program);
        [DllImport(DllName)]
        public static extern unsafe void glUseShaderProgramEXT (uint type, uint program);
        [DllImport(DllName)]
        public static extern unsafe void glVDPAUFiniNV ();
        [DllImport(DllName)]
        public static extern unsafe void glVDPAUGetSurfaceivNV (int* surface, uint pname, int bufSize, int* length, int* values);
        [DllImport(DllName)]
        public static extern unsafe void glVDPAUInitNV (void* vdpDevice, void* getProcAddress);
        [DllImport(DllName)]
        public static extern unsafe void glVDPAUIsSurfaceNV (int* surface);
        [DllImport(DllName)]
        public static extern unsafe void glVDPAUMapSurfacesNV (int numSurfaces, int** surfaces);
        [DllImport(DllName)]
        public static extern unsafe void glVDPAURegisterOutputSurfaceNV (void* vdpSurface, uint target, int numTextureNames, uint* textureNames);
        [DllImport(DllName)]
        public static extern unsafe void glVDPAURegisterVideoSurfaceNV (void* vdpSurface, uint target, int numTextureNames, uint* textureNames);
        [DllImport(DllName)]
        public static extern unsafe void glVDPAUSurfaceAccessNV (int* surface, uint access);
        [DllImport(DllName)]
        public static extern unsafe void glVDPAUUnmapSurfacesNV (int numSurface, int** surfaces);
        [DllImport(DllName)]
        public static extern unsafe void glVDPAUUnregisterSurfaceNV (int* surface);
        [DllImport(DllName)]
        public static extern unsafe void glValidateProgram (uint program);
        [DllImport(DllName)]
        public static extern unsafe void glValidateProgramARB (void* programObj);
        [DllImport(DllName)]
        public static extern unsafe void glValidateProgramPipeline (uint pipeline);
        [DllImport(DllName)]
        public static extern unsafe void glValidateProgramPipelineEXT (uint pipeline);
        [DllImport(DllName)]
        public static extern unsafe void glVariantArrayObjectATI (uint id, uint type, int stride, uint buffer, uint offset);
        [DllImport(DllName)]
        public static extern unsafe void glVariantPointerEXT (uint id, uint type, uint stride, void* addr);
        [DllImport(DllName)]
        public static extern unsafe void glVariantbvEXT (uint id, sbyte* addr);
        [DllImport(DllName)]
        public static extern unsafe void glVariantdvEXT (uint id, double* addr);
        [DllImport(DllName)]
        public static extern unsafe void glVariantfvEXT (uint id, float* addr);
        [DllImport(DllName)]
        public static extern unsafe void glVariantivEXT (uint id, int* addr);
        [DllImport(DllName)]
        public static extern unsafe void glVariantsvEXT (uint id, short* addr);
        [DllImport(DllName)]
        public static extern unsafe void glVariantubvEXT (uint id, byte* addr);
        [DllImport(DllName)]
        public static extern unsafe void glVariantuivEXT (uint id, uint* addr);
        [DllImport(DllName)]
        public static extern unsafe void glVariantusvEXT (uint id, ushort* addr);
        [DllImport(DllName)]
        public static extern unsafe void glVertex2bOES (sbyte x, sbyte y);
        [DllImport(DllName)]
        public static extern unsafe void glVertex2bvOES (sbyte* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertex2d (double x, double y);
        [DllImport(DllName)]
        public static extern unsafe void glVertex2dv (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertex2f (float x, float y);
        [DllImport(DllName)]
        public static extern unsafe void glVertex2fv (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertex2hNV (ushort x, ushort y);
        [DllImport(DllName)]
        public static extern unsafe void glVertex2hvNV (ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertex2i (int x, int y);
        [DllImport(DllName)]
        public static extern unsafe void glVertex2iv (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertex2s (short x, short y);
        [DllImport(DllName)]
        public static extern unsafe void glVertex2sv (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertex2xOES (int x);
        [DllImport(DllName)]
        public static extern unsafe void glVertex2xvOES (int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertex3bOES (sbyte x, sbyte y, sbyte z);
        [DllImport(DllName)]
        public static extern unsafe void glVertex3bvOES (sbyte* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertex3d (double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glVertex3dv (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertex3f (float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glVertex3fv (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertex3hNV (ushort x, ushort y, ushort z);
        [DllImport(DllName)]
        public static extern unsafe void glVertex3hvNV (ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertex3i (int x, int y, int z);
        [DllImport(DllName)]
        public static extern unsafe void glVertex3iv (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertex3s (short x, short y, short z);
        [DllImport(DllName)]
        public static extern unsafe void glVertex3sv (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertex3xOES (int x, int y);
        [DllImport(DllName)]
        public static extern unsafe void glVertex3xvOES (int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertex4bOES (sbyte x, sbyte y, sbyte z, sbyte w);
        [DllImport(DllName)]
        public static extern unsafe void glVertex4bvOES (sbyte* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertex4d (double x, double y, double z, double w);
        [DllImport(DllName)]
        public static extern unsafe void glVertex4dv (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertex4f (float x, float y, float z, float w);
        [DllImport(DllName)]
        public static extern unsafe void glVertex4fv (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertex4hNV (ushort x, ushort y, ushort z, ushort w);
        [DllImport(DllName)]
        public static extern unsafe void glVertex4hvNV (ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertex4i (int x, int y, int z, int w);
        [DllImport(DllName)]
        public static extern unsafe void glVertex4iv (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertex4s (short x, short y, short z, short w);
        [DllImport(DllName)]
        public static extern unsafe void glVertex4sv (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertex4xOES (int x, int y, int z);
        [DllImport(DllName)]
        public static extern unsafe void glVertex4xvOES (int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayAttribBinding (uint vaobj, uint attribindex, uint bindingindex);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayAttribFormat (uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayAttribIFormat (uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayAttribLFormat (uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayBindVertexBufferEXT (uint vaobj, uint bindingindex, uint buffer, int* offset, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayBindingDivisor (uint vaobj, uint bindingindex, uint divisor);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayColorOffsetEXT (uint vaobj, uint buffer, int size, uint type, int stride, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayEdgeFlagOffsetEXT (uint vaobj, uint buffer, int stride, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayElementBuffer (uint vaobj, uint buffer);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayFogCoordOffsetEXT (uint vaobj, uint buffer, uint type, int stride, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayIndexOffsetEXT (uint vaobj, uint buffer, uint type, int stride, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayMultiTexCoordOffsetEXT (uint vaobj, uint buffer, uint texunit, int size, uint type, int stride, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayNormalOffsetEXT (uint vaobj, uint buffer, uint type, int stride, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayParameteriAPPLE (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayRangeAPPLE (int length, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayRangeNV (int length, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArraySecondaryColorOffsetEXT (uint vaobj, uint buffer, int size, uint type, int stride, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayTexCoordOffsetEXT (uint vaobj, uint buffer, int size, uint type, int stride, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayVertexAttribBindingEXT (uint vaobj, uint attribindex, uint bindingindex);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayVertexAttribDivisorEXT (uint vaobj, uint index, uint divisor);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayVertexAttribFormatEXT (uint vaobj, uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayVertexAttribIFormatEXT (uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayVertexAttribIOffsetEXT (uint vaobj, uint buffer, uint index, int size, uint type, int stride, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayVertexAttribLFormatEXT (uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayVertexAttribLOffsetEXT (uint vaobj, uint buffer, uint index, int size, uint type, int stride, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayVertexAttribOffsetEXT (uint vaobj, uint buffer, uint index, int size, uint type, bool normalized, int stride, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayVertexBindingDivisorEXT (uint vaobj, uint bindingindex, uint divisor);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayVertexBuffer (uint vaobj, uint bindingindex, uint buffer, int* offset, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayVertexBuffers (uint vaobj, uint first, int count, uint* buffers, int** offsets, int* strides);
        [DllImport(DllName)]
        public static extern unsafe void glVertexArrayVertexOffsetEXT (uint vaobj, uint buffer, int size, uint type, int stride, int* offset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1d (uint index, double x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1dARB (uint index, double x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1dNV (uint index, double x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1dv (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1dvARB (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1dvNV (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1f (uint index, float x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1fARB (uint index, float x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1fNV (uint index, float x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1fv (uint index, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1fvARB (uint index, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1fvNV (uint index, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1hNV (uint index, ushort x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1hvNV (uint index, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1s (uint index, short x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1sARB (uint index, short x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1sNV (uint index, short x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1sv (uint index, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1svARB (uint index, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib1svNV (uint index, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2d (uint index, double x, double y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2dARB (uint index, double x, double y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2dNV (uint index, double x, double y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2dv (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2dvARB (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2dvNV (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2f (uint index, float x, float y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2fARB (uint index, float x, float y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2fNV (uint index, float x, float y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2fv (uint index, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2fvARB (uint index, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2fvNV (uint index, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2hNV (uint index, ushort x, ushort y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2hvNV (uint index, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2s (uint index, short x, short y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2sARB (uint index, short x, short y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2sNV (uint index, short x, short y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2sv (uint index, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2svARB (uint index, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib2svNV (uint index, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3d (uint index, double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3dARB (uint index, double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3dNV (uint index, double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3dv (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3dvARB (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3dvNV (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3f (uint index, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3fARB (uint index, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3fNV (uint index, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3fv (uint index, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3fvARB (uint index, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3fvNV (uint index, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3hNV (uint index, ushort x, ushort y, ushort z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3hvNV (uint index, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3s (uint index, short x, short y, short z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3sARB (uint index, short x, short y, short z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3sNV (uint index, short x, short y, short z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3sv (uint index, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3svARB (uint index, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib3svNV (uint index, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4Nbv (uint index, sbyte* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4NbvARB (uint index, sbyte* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4Niv (uint index, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4NivARB (uint index, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4Nsv (uint index, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4NsvARB (uint index, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4Nub (uint index, byte x, byte y, byte z, byte w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4NubARB (uint index, byte x, byte y, byte z, byte w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4Nubv (uint index, byte* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4NubvARB (uint index, byte* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4Nuiv (uint index, uint* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4NuivARB (uint index, uint* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4Nusv (uint index, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4NusvARB (uint index, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4bv (uint index, sbyte* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4bvARB (uint index, sbyte* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4d (uint index, double x, double y, double z, double w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4dARB (uint index, double x, double y, double z, double w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4dNV (uint index, double x, double y, double z, double w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4dv (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4dvARB (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4dvNV (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4f (uint index, float x, float y, float z, float w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4fARB (uint index, float x, float y, float z, float w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4fNV (uint index, float x, float y, float z, float w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4fv (uint index, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4fvARB (uint index, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4fvNV (uint index, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4hNV (uint index, ushort x, ushort y, ushort z, ushort w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4hvNV (uint index, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4iv (uint index, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4ivARB (uint index, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4s (uint index, short x, short y, short z, short w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4sARB (uint index, short x, short y, short z, short w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4sNV (uint index, short x, short y, short z, short w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4sv (uint index, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4svARB (uint index, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4svNV (uint index, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4ubNV (uint index, byte x, byte y, byte z, byte w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4ubv (uint index, byte* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4ubvARB (uint index, byte* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4ubvNV (uint index, byte* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4uiv (uint index, uint* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4uivARB (uint index, uint* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4usv (uint index, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttrib4usvARB (uint index, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribArrayObjectATI (uint index, int size, uint type, bool normalized, int stride, uint buffer, uint offset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribBinding (uint attribindex, uint bindingindex);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribDivisor (uint index, uint divisor);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribDivisorANGLE (uint index, uint divisor);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribDivisorARB (uint index, uint divisor);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribDivisorEXT (uint index, uint divisor);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribDivisorNV (uint index, uint divisor);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribFormat (uint attribindex, int size, uint type, bool normalized, uint relativeoffset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribFormatNV (uint index, int size, uint type, bool normalized, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI1i (uint index, int x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI1iEXT (uint index, int x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI1iv (uint index, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI1ivEXT (uint index, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI1ui (uint index, uint x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI1uiEXT (uint index, uint x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI1uiv (uint index, uint* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI1uivEXT (uint index, uint* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI2i (uint index, int x, int y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI2iEXT (uint index, int x, int y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI2iv (uint index, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI2ivEXT (uint index, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI2ui (uint index, uint x, uint y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI2uiEXT (uint index, uint x, uint y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI2uiv (uint index, uint* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI2uivEXT (uint index, uint* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI3i (uint index, int x, int y, int z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI3iEXT (uint index, int x, int y, int z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI3iv (uint index, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI3ivEXT (uint index, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI3ui (uint index, uint x, uint y, uint z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI3uiEXT (uint index, uint x, uint y, uint z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI3uiv (uint index, uint* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI3uivEXT (uint index, uint* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI4bv (uint index, sbyte* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI4bvEXT (uint index, sbyte* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI4i (uint index, int x, int y, int z, int w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI4iEXT (uint index, int x, int y, int z, int w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI4iv (uint index, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI4ivEXT (uint index, int* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI4sv (uint index, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI4svEXT (uint index, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI4ubv (uint index, byte* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI4ubvEXT (uint index, byte* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI4ui (uint index, uint x, uint y, uint z, uint w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI4uiEXT (uint index, uint x, uint y, uint z, uint w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI4uiv (uint index, uint* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI4uivEXT (uint index, uint* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI4usv (uint index, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribI4usvEXT (uint index, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribIFormat (uint attribindex, int size, uint type, uint relativeoffset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribIFormatNV (uint index, int size, uint type, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribIPointer (uint index, int size, uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribIPointerEXT (uint index, int size, uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL1d (uint index, double x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL1dEXT (uint index, double x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL1dv (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL1dvEXT (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL1i64NV (uint index, long x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL1i64vNV (uint index, long* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL1ui64ARB (uint index, ulong x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL1ui64NV (uint index, ulong x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL1ui64vARB (uint index, ulong* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL1ui64vNV (uint index, ulong* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL2d (uint index, double x, double y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL2dEXT (uint index, double x, double y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL2dv (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL2dvEXT (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL2i64NV (uint index, long x, long y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL2i64vNV (uint index, long* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL2ui64NV (uint index, ulong x, ulong y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL2ui64vNV (uint index, ulong* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL3d (uint index, double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL3dEXT (uint index, double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL3dv (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL3dvEXT (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL3i64NV (uint index, long x, long y, long z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL3i64vNV (uint index, long* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL3ui64NV (uint index, ulong x, ulong y, ulong z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL3ui64vNV (uint index, ulong* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL4d (uint index, double x, double y, double z, double w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL4dEXT (uint index, double x, double y, double z, double w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL4dv (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL4dvEXT (uint index, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL4i64NV (uint index, long x, long y, long z, long w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL4i64vNV (uint index, long* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL4ui64NV (uint index, ulong x, ulong y, ulong z, ulong w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribL4ui64vNV (uint index, ulong* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribLFormat (uint attribindex, int size, uint type, uint relativeoffset);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribLFormatNV (uint index, int size, uint type, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribLPointer (uint index, int size, uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribLPointerEXT (uint index, int size, uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribP1ui (uint index, uint type, bool normalized, uint value);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribP1uiv (uint index, uint type, bool normalized, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribP2ui (uint index, uint type, bool normalized, uint value);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribP2uiv (uint index, uint type, bool normalized, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribP3ui (uint index, uint type, bool normalized, uint value);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribP3uiv (uint index, uint type, bool normalized, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribP4ui (uint index, uint type, bool normalized, uint value);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribP4uiv (uint index, uint type, bool normalized, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribParameteriAMD (uint index, uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribPointer (uint index, int size, uint type, bool normalized, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribPointerARB (uint index, int size, uint type, bool normalized, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribPointerNV (uint index, int fsize, uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs1dvNV (uint index, int count, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs1fvNV (uint index, int count, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs1hvNV (uint index, int n, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs1svNV (uint index, int count, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs2dvNV (uint index, int count, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs2fvNV (uint index, int count, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs2hvNV (uint index, int n, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs2svNV (uint index, int count, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs3dvNV (uint index, int count, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs3fvNV (uint index, int count, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs3hvNV (uint index, int n, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs3svNV (uint index, int count, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs4dvNV (uint index, int count, double* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs4fvNV (uint index, int count, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs4hvNV (uint index, int n, ushort* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs4svNV (uint index, int count, short* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexAttribs4ubvNV (uint index, int count, byte* v);
        [DllImport(DllName)]
        public static extern unsafe void glVertexBindingDivisor (uint bindingindex, uint divisor);
        [DllImport(DllName)]
        public static extern unsafe void glVertexBlendARB (int count);
        [DllImport(DllName)]
        public static extern unsafe void glVertexBlendEnvfATI (uint pname, float param);
        [DllImport(DllName)]
        public static extern unsafe void glVertexBlendEnviATI (uint pname, int param);
        [DllImport(DllName)]
        public static extern unsafe void glVertexFormatNV (int size, uint type, int stride);
        [DllImport(DllName)]
        public static extern unsafe void glVertexP2ui (uint type, uint value);
        [DllImport(DllName)]
        public static extern unsafe void glVertexP2uiv (uint type, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glVertexP3ui (uint type, uint value);
        [DllImport(DllName)]
        public static extern unsafe void glVertexP3uiv (uint type, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glVertexP4ui (uint type, uint value);
        [DllImport(DllName)]
        public static extern unsafe void glVertexP4uiv (uint type, uint* value);
        [DllImport(DllName)]
        public static extern unsafe void glVertexPointer (int size, uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glVertexPointerEXT (int size, uint type, int stride, int count, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glVertexPointerListIBM (int size, uint type, int stride, void* pointer, int ptrstride);
        [DllImport(DllName)]
        public static extern unsafe void glVertexPointervINTEL (int size, uint type, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream1dATI (uint stream, double x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream1dvATI (uint stream, double* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream1fATI (uint stream, float x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream1fvATI (uint stream, float* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream1iATI (uint stream, int x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream1ivATI (uint stream, int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream1sATI (uint stream, short x);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream1svATI (uint stream, short* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream2dATI (uint stream, double x, double y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream2dvATI (uint stream, double* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream2fATI (uint stream, float x, float y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream2fvATI (uint stream, float* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream2iATI (uint stream, int x, int y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream2ivATI (uint stream, int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream2sATI (uint stream, short x, short y);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream2svATI (uint stream, short* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream3dATI (uint stream, double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream3dvATI (uint stream, double* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream3fATI (uint stream, float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream3fvATI (uint stream, float* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream3iATI (uint stream, int x, int y, int z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream3ivATI (uint stream, int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream3sATI (uint stream, short x, short y, short z);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream3svATI (uint stream, short* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream4dATI (uint stream, double x, double y, double z, double w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream4dvATI (uint stream, double* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream4fATI (uint stream, float x, float y, float z, float w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream4fvATI (uint stream, float* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream4iATI (uint stream, int x, int y, int z, int w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream4ivATI (uint stream, int* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream4sATI (uint stream, short x, short y, short z, short w);
        [DllImport(DllName)]
        public static extern unsafe void glVertexStream4svATI (uint stream, short* coords);
        [DllImport(DllName)]
        public static extern unsafe void glVertexWeightPointerEXT (int size, uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glVertexWeightfEXT (float weight);
        [DllImport(DllName)]
        public static extern unsafe void glVertexWeightfvEXT (float* weight);
        [DllImport(DllName)]
        public static extern unsafe void glVertexWeighthNV (ushort weight);
        [DllImport(DllName)]
        public static extern unsafe void glVertexWeighthvNV (ushort* weight);
        [DllImport(DllName)]
        public static extern unsafe void glVideoCaptureNV (uint video_capture_slot, uint* sequence_num, ulong* capture_time);
        [DllImport(DllName)]
        public static extern unsafe void glVideoCaptureStreamParameterdvNV (uint video_capture_slot, uint stream, uint pname, double* @params);
        [DllImport(DllName)]
        public static extern unsafe void glVideoCaptureStreamParameterfvNV (uint video_capture_slot, uint stream, uint pname, float* @params);
        [DllImport(DllName)]
        public static extern unsafe void glVideoCaptureStreamParameterivNV (uint video_capture_slot, uint stream, uint pname, int* @params);
        [DllImport(DllName)]
        public static extern unsafe void glViewport (int x, int y, int width, int height);
        [DllImport(DllName)]
        public static extern unsafe void glViewportArrayv (uint first, int count, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glViewportArrayvNV (uint first, int count, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glViewportIndexedf (uint index, float x, float y, float w, float h);
        [DllImport(DllName)]
        public static extern unsafe void glViewportIndexedfNV (uint index, float x, float y, float w, float h);
        [DllImport(DllName)]
        public static extern unsafe void glViewportIndexedfv (uint index, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glViewportIndexedfvNV (uint index, float* v);
        [DllImport(DllName)]
        public static extern unsafe void glWaitSync (void* sync, uint flags, ulong timeout);
        [DllImport(DllName)]
        public static extern unsafe void glWaitSyncAPPLE (void* sync, uint flags, ulong timeout);
        [DllImport(DllName)]
        public static extern unsafe void glWeightPathsNV (uint resultPath, int numPaths, uint* paths, float* weights);
        [DllImport(DllName)]
        public static extern unsafe void glWeightPointerARB (int size, uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glWeightPointerOES (int size, uint type, int stride, void* pointer);
        [DllImport(DllName)]
        public static extern unsafe void glWeightbvARB (int size, sbyte* weights);
        [DllImport(DllName)]
        public static extern unsafe void glWeightdvARB (int size, double* weights);
        [DllImport(DllName)]
        public static extern unsafe void glWeightfvARB (int size, float* weights);
        [DllImport(DllName)]
        public static extern unsafe void glWeightivARB (int size, int* weights);
        [DllImport(DllName)]
        public static extern unsafe void glWeightsvARB (int size, short* weights);
        [DllImport(DllName)]
        public static extern unsafe void glWeightubvARB (int size, byte* weights);
        [DllImport(DllName)]
        public static extern unsafe void glWeightuivARB (int size, uint* weights);
        [DllImport(DllName)]
        public static extern unsafe void glWeightusvARB (int size, ushort* weights);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2d (double x, double y);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2dARB (double x, double y);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2dMESA (double x, double y);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2dv (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2dvARB (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2dvMESA (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2f (float x, float y);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2fARB (float x, float y);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2fMESA (float x, float y);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2fv (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2fvARB (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2fvMESA (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2i (int x, int y);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2iARB (int x, int y);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2iMESA (int x, int y);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2iv (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2ivARB (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2ivMESA (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2s (short x, short y);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2sARB (short x, short y);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2sMESA (short x, short y);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2sv (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2svARB (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos2svMESA (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3d (double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3dARB (double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3dMESA (double x, double y, double z);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3dv (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3dvARB (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3dvMESA (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3f (float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3fARB (float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3fMESA (float x, float y, float z);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3fv (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3fvARB (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3fvMESA (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3i (int x, int y, int z);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3iARB (int x, int y, int z);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3iMESA (int x, int y, int z);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3iv (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3ivARB (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3ivMESA (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3s (short x, short y, short z);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3sARB (short x, short y, short z);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3sMESA (short x, short y, short z);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3sv (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3svARB (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos3svMESA (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos4dMESA (double x, double y, double z, double w);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos4dvMESA (double* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos4fMESA (float x, float y, float z, float w);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos4fvMESA (float* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos4iMESA (int x, int y, int z, int w);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos4ivMESA (int* v);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos4sMESA (short x, short y, short z, short w);
        [DllImport(DllName)]
        public static extern unsafe void glWindowPos4svMESA (short* v);
        [DllImport(DllName)]
        public static extern unsafe void glWriteMaskEXT (uint res, uint @in, uint outX, uint outY, uint outZ, uint outW);
    }
}
