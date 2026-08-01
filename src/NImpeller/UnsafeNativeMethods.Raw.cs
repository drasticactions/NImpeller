using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NImpeller;

// Raw IntPtr entry points for callers that must not allocate on a hot path:
// the SafeHandle-typed imports in Bindings.g.cs allocate a fresh handle
// wrapper for every object a native call returns, which rules them out for
// per-frame use (e.g. a compositor building one display list per output per
// frame). These bind the same exports with raw pointers and leave lifetime
// entirely to the caller — pair every *New with the matching *Release(IntPtr)
// from the generated imports, and never mix a raw pointer into the SafeHandle
// wrappers.
static unsafe partial class UnsafeNativeMethods
{
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    [LibraryImport("impeller", EntryPoint = "ImpellerDisplayListBuilderNew")]
    public static partial IntPtr ImpellerDisplayListBuilderNewRaw(ImpellerRect* cull_rect);

    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    [LibraryImport("impeller", EntryPoint = "ImpellerDisplayListBuilderCreateDisplayListNew")]
    public static partial IntPtr ImpellerDisplayListBuilderCreateDisplayListNewRaw(IntPtr builder);

    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    [LibraryImport("impeller", EntryPoint = "ImpellerDisplayListBuilderSave")]
    public static partial void ImpellerDisplayListBuilderSaveRaw(IntPtr builder);

    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    [LibraryImport("impeller", EntryPoint = "ImpellerDisplayListBuilderRestore")]
    public static partial void ImpellerDisplayListBuilderRestoreRaw(IntPtr builder);

    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    [LibraryImport("impeller", EntryPoint = "ImpellerDisplayListBuilderTranslate")]
    public static partial void ImpellerDisplayListBuilderTranslateRaw(IntPtr builder, float x_translation, float y_translation);

    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    [LibraryImport("impeller", EntryPoint = "ImpellerDisplayListBuilderScale")]
    public static partial void ImpellerDisplayListBuilderScaleRaw(IntPtr builder, float x_scale, float y_scale);

    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    [LibraryImport("impeller", EntryPoint = "ImpellerDisplayListBuilderClipRect")]
    public static partial void ImpellerDisplayListBuilderClipRectRaw(IntPtr builder, ImpellerRect* rect, ImpellerClipOperation op);

    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    [LibraryImport("impeller", EntryPoint = "ImpellerDisplayListBuilderDrawRect")]
    public static partial void ImpellerDisplayListBuilderDrawRectRaw(IntPtr builder, ImpellerRect* rect, IntPtr paint);

    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    [LibraryImport("impeller", EntryPoint = "ImpellerDisplayListBuilderDrawTextureRect")]
    public static partial void ImpellerDisplayListBuilderDrawTextureRectRaw(IntPtr builder, IntPtr texture, ImpellerRect* src_rect, ImpellerRect* dst_rect, ImpellerTextureSampling sampling, IntPtr paint);

    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    [LibraryImport("impeller", EntryPoint = "ImpellerPaintNew")]
    public static partial IntPtr ImpellerPaintNewRaw();

    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    [LibraryImport("impeller", EntryPoint = "ImpellerPaintSetColor")]
    public static partial void ImpellerPaintSetColorRaw(IntPtr paint, ImpellerColor* color);

    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    [LibraryImport("impeller", EntryPoint = "ImpellerPaintSetBlendMode")]
    public static partial void ImpellerPaintSetBlendModeRaw(IntPtr paint, ImpellerBlendMode mode);

    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    [LibraryImport("impeller", EntryPoint = "ImpellerSurfaceCreateWrappedFBONew")]
    public static partial IntPtr ImpellerSurfaceCreateWrappedFBONewRaw(IntPtr context, ulong fbo, ImpellerPixelFormat format, ImpellerISize* size);

    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    [LibraryImport("impeller", EntryPoint = "ImpellerSurfaceDrawDisplayList")]
    public static partial int ImpellerSurfaceDrawDisplayListRaw(IntPtr surface, IntPtr display_list);

    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    [LibraryImport("impeller", EntryPoint = "ImpellerTextureCreateWithOpenGLTextureHandleNew")]
    public static partial IntPtr ImpellerTextureCreateWithOpenGLTextureHandleNewRaw(IntPtr context, ImpellerTextureDescriptor* descriptor, ulong handle);
}
