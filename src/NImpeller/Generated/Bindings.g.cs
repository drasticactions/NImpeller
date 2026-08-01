using System;
#nullable enable
namespace NImpeller
{
    public enum ImpellerFillType
    {
        kImpellerFillTypeNonZero = 0,
        kImpellerFillTypeOdd = 1,
    }

    public enum ImpellerClipOperation
    {
        kImpellerClipOperationDifference = 0,
        kImpellerClipOperationIntersect = 1,
    }

    public enum ImpellerBlendMode
    {
        kImpellerBlendModeClear = 0,
        kImpellerBlendModeSource = 1,
        kImpellerBlendModeDestination = 2,
        kImpellerBlendModeSourceOver = 3,
        kImpellerBlendModeDestinationOver = 4,
        kImpellerBlendModeSourceIn = 5,
        kImpellerBlendModeDestinationIn = 6,
        kImpellerBlendModeSourceOut = 7,
        kImpellerBlendModeDestinationOut = 8,
        kImpellerBlendModeSourceATop = 9,
        kImpellerBlendModeDestinationATop = 10,
        kImpellerBlendModeXor = 11,
        kImpellerBlendModePlus = 12,
        kImpellerBlendModeModulate = 13,
        kImpellerBlendModeScreen = 14,
        kImpellerBlendModeOverlay = 15,
        kImpellerBlendModeDarken = 16,
        kImpellerBlendModeLighten = 17,
        kImpellerBlendModeColorDodge = 18,
        kImpellerBlendModeColorBurn = 19,
        kImpellerBlendModeHardLight = 20,
        kImpellerBlendModeSoftLight = 21,
        kImpellerBlendModeDifference = 22,
        kImpellerBlendModeExclusion = 23,
        kImpellerBlendModeMultiply = 24,
        kImpellerBlendModeHue = 25,
        kImpellerBlendModeSaturation = 26,
        kImpellerBlendModeColor = 27,
        kImpellerBlendModeLuminosity = 28,
    }

    public enum ImpellerDrawStyle
    {
        kImpellerDrawStyleFill = 0,
        kImpellerDrawStyleStroke = 1,
        kImpellerDrawStyleStrokeAndFill = 2,
    }

    public enum ImpellerStrokeCap
    {
        kImpellerStrokeCapButt = 0,
        kImpellerStrokeCapRound = 1,
        kImpellerStrokeCapSquare = 2,
    }

    public enum ImpellerStrokeJoin
    {
        kImpellerStrokeJoinMiter = 0,
        kImpellerStrokeJoinRound = 1,
        kImpellerStrokeJoinBevel = 2,
    }

    public enum ImpellerPixelFormat
    {
        kImpellerPixelFormatRGBA8888 = 0,
    }

    public enum ImpellerTextureSampling
    {
        kImpellerTextureSamplingNearestNeighbor = 0,
        kImpellerTextureSamplingLinear = 1,
    }

    public enum ImpellerTileMode
    {
        kImpellerTileModeClamp = 0,
        kImpellerTileModeRepeat = 1,
        kImpellerTileModeMirror = 2,
        kImpellerTileModeDecal = 3,
    }

    public enum ImpellerBlurStyle
    {
        kImpellerBlurStyleNormal = 0,
        kImpellerBlurStyleSolid = 1,
        kImpellerBlurStyleOuter = 2,
        kImpellerBlurStyleInner = 3,
    }

    public enum ImpellerColorSpace
    {
        kImpellerColorSpaceSRGB = 0,
        kImpellerColorSpaceExtendedSRGB = 1,
        kImpellerColorSpaceDisplayP3 = 2,
    }

    public enum ImpellerFontWeight
    {
        kImpellerFontWeight100 = 0,
        kImpellerFontWeight200 = 1,
        kImpellerFontWeight300 = 2,
        kImpellerFontWeight400 = 3,
        kImpellerFontWeight500 = 4,
        kImpellerFontWeight600 = 5,
        kImpellerFontWeight700 = 6,
        kImpellerFontWeight800 = 7,
        kImpellerFontWeight900 = 8,
    }

    public enum ImpellerFontStyle
    {
        kImpellerFontStyleNormal = 0,
        kImpellerFontStyleItalic = 1,
    }

    public enum ImpellerTextAlignment
    {
        kImpellerTextAlignmentLeft = 0,
        kImpellerTextAlignmentRight = 1,
        kImpellerTextAlignmentCenter = 2,
        kImpellerTextAlignmentJustify = 3,
        kImpellerTextAlignmentStart = 4,
        kImpellerTextAlignmentEnd = 5,
    }

    public enum ImpellerTextDirection
    {
        kImpellerTextDirectionRTL = 0,
        kImpellerTextDirectionLTR = 1,
    }

    public enum ImpellerTextDecorationType
    {
        kImpellerTextDecorationTypeNone = 0,
        kImpellerTextDecorationTypeUnderline = 1,
        kImpellerTextDecorationTypeOverline = 2,
        kImpellerTextDecorationTypeLineThrough = 4,
    }

    public enum ImpellerTextDecorationStyle
    {
        kImpellerTextDecorationStyleSolid = 0,
        kImpellerTextDecorationStyleDouble = 1,
        kImpellerTextDecorationStyleDotted = 2,
        kImpellerTextDecorationStyleDashed = 3,
        kImpellerTextDecorationStyleWavy = 4,
    }

    internal class ImpellerContextHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerContextRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerContextRelease(handle);
        }

    }

    internal class ImpellerDisplayListHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerDisplayListRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerDisplayListRelease(handle);
        }

    }

    internal class ImpellerDisplayListBuilderHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerDisplayListBuilderRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerDisplayListBuilderRelease(handle);
        }

    }

    internal class ImpellerPaintHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerPaintRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerPaintRelease(handle);
        }

    }

    internal class ImpellerColorFilterHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerColorFilterRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerColorFilterRelease(handle);
        }

    }

    internal class ImpellerColorSourceHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerColorSourceRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerColorSourceRelease(handle);
        }

    }

    internal class ImpellerImageFilterHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerImageFilterRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerImageFilterRelease(handle);
        }

    }

    internal class ImpellerMaskFilterHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerMaskFilterRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerMaskFilterRelease(handle);
        }

    }

    internal class ImpellerTypographyContextHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerTypographyContextRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerTypographyContextRelease(handle);
        }

    }

    internal class ImpellerParagraphHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerParagraphRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerParagraphRelease(handle);
        }

    }

    internal class ImpellerParagraphBuilderHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerParagraphBuilderRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerParagraphBuilderRelease(handle);
        }

    }

    internal class ImpellerParagraphStyleHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerParagraphStyleRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerParagraphStyleRelease(handle);
        }

    }

    internal class ImpellerLineMetricsHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerLineMetricsRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerLineMetricsRelease(handle);
        }

    }

    internal class ImpellerGlyphInfoHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerGlyphInfoRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerGlyphInfoRelease(handle);
        }

    }

    internal class ImpellerPathHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerPathRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerPathRelease(handle);
        }

    }

    internal class ImpellerPathBuilderHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerPathBuilderRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerPathBuilderRelease(handle);
        }

    }

    internal class ImpellerSurfaceHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerSurfaceRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerSurfaceRelease(handle);
        }

    }

    internal class ImpellerTextureHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerTextureRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerTextureRelease(handle);
        }

    }

    internal class ImpellerVulkanSwapchainHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerVulkanSwapchainRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerVulkanSwapchainRelease(handle);
        }

    }

    internal class ImpellerFragmentProgramHandle : ImpellerHandle
    {
        private protected override void UnsafeRetain()
        {
            UnsafeNativeMethods.ImpellerFragmentProgramRetain(handle);
        }

        private protected override void UnsafeRelease()
        {
            UnsafeNativeMethods.ImpellerFragmentProgramRelease(handle);
        }

    }

    public unsafe partial record  struct ImpellerRect
    {
        private float _x;
        public float X
        {
            readonly get => _x;
            set => _x = value;
        }

        private float _y;
        public float Y
        {
            readonly get => _y;
            set => _y = value;
        }

        private float _width;
        public float Width
        {
            readonly get => _width;
            set => _width = value;
        }

        private float _height;
        public float Height
        {
            readonly get => _height;
            set => _height = value;
        }

    }

    public unsafe partial  struct ImpellerPoint
    {
        private float _x;
        public float X
        {
            readonly get => _x;
            set => _x = value;
        }

        private float _y;
        public float Y
        {
            readonly get => _y;
            set => _y = value;
        }

    }

    public unsafe partial  struct ImpellerSize
    {
        private float _width;
        public float Width
        {
            readonly get => _width;
            set => _width = value;
        }

        private float _height;
        public float Height
        {
            readonly get => _height;
            set => _height = value;
        }

    }

    public unsafe partial record  struct ImpellerISize
    {
        private long _width;
        public long Width
        {
            readonly get => _width;
            set => _width = value;
        }

        private long _height;
        public long Height
        {
            readonly get => _height;
            set => _height = value;
        }

    }

    public unsafe partial  struct ImpellerRange
    {
        private ulong _start;
        public ulong Start
        {
            readonly get => _start;
            set => _start = value;
        }

        private ulong _end;
        public ulong End
        {
            readonly get => _end;
            set => _end = value;
        }

    }

    public unsafe partial  struct ImpellerColorMatrix
    {
        public fixed float m[20];
    }

    public unsafe partial  struct ImpellerRoundingRadii
    {
        private global::NImpeller.ImpellerPoint _top_left;
        public global::NImpeller.ImpellerPoint Top_left
        {
            readonly get => _top_left;
            set => _top_left = value;
        }

        private global::NImpeller.ImpellerPoint _bottom_left;
        public global::NImpeller.ImpellerPoint Bottom_left
        {
            readonly get => _bottom_left;
            set => _bottom_left = value;
        }

        private global::NImpeller.ImpellerPoint _top_right;
        public global::NImpeller.ImpellerPoint Top_right
        {
            readonly get => _top_right;
            set => _top_right = value;
        }

        private global::NImpeller.ImpellerPoint _bottom_right;
        public global::NImpeller.ImpellerPoint Bottom_right
        {
            readonly get => _bottom_right;
            set => _bottom_right = value;
        }

    }

    public unsafe partial record  struct ImpellerColor
    {
        private float _red;
        public float Red
        {
            readonly get => _red;
            set => _red = value;
        }

        private float _green;
        public float Green
        {
            readonly get => _green;
            set => _green = value;
        }

        private float _blue;
        public float Blue
        {
            readonly get => _blue;
            set => _blue = value;
        }

        private float _alpha;
        public float Alpha
        {
            readonly get => _alpha;
            set => _alpha = value;
        }

        private global::NImpeller.ImpellerColorSpace _color_space;
        public global::NImpeller.ImpellerColorSpace Color_space
        {
            readonly get => _color_space;
            set => _color_space = value;
        }

    }

    public unsafe partial  struct ImpellerTextureDescriptor
    {
        private global::NImpeller.ImpellerPixelFormat _pixel_format;
        public global::NImpeller.ImpellerPixelFormat Pixel_format
        {
            readonly get => _pixel_format;
            set => _pixel_format = value;
        }

        private global::NImpeller.ImpellerISize _size;
        public global::NImpeller.ImpellerISize Size
        {
            readonly get => _size;
            set => _size = value;
        }

        private uint _mip_count;
        public uint Mip_count
        {
            readonly get => _mip_count;
            set => _mip_count = value;
        }

    }

    internal unsafe partial  struct ImpellerMapping
    {
        private byte* _data;
        public byte* Data
        {
            readonly get => _data;
            set => _data = value;
        }

        private ulong _length;
        public ulong Length
        {
            readonly get => _length;
            set => _length = value;
        }

        private IntPtr _on_release;
        public IntPtr On_release
        {
            readonly get => _on_release;
            set => _on_release = value;
        }

    }

    public unsafe partial  struct ImpellerContextVulkanSettings
    {
        private System.IntPtr _user_data;
        public System.IntPtr User_data
        {
            readonly get => _user_data;
            set => _user_data = value;
        }

        private IntPtr _proc_address_callback;
        public IntPtr Proc_address_callback
        {
            readonly get => _proc_address_callback;
            set => _proc_address_callback = value;
        }

        private int _enable_vulkan_validation;
        public int Enable_vulkan_validation
        {
            readonly get => _enable_vulkan_validation;
            set => _enable_vulkan_validation = value;
        }

    }

    public unsafe partial  struct ImpellerContextVulkanInfo
    {
        private System.IntPtr _vk_instance;
        public System.IntPtr Vk_instance
        {
            readonly get => _vk_instance;
            set => _vk_instance = value;
        }

        private System.IntPtr _vk_physical_device;
        public System.IntPtr Vk_physical_device
        {
            readonly get => _vk_physical_device;
            set => _vk_physical_device = value;
        }

        private System.IntPtr _vk_logical_device;
        public System.IntPtr Vk_logical_device
        {
            readonly get => _vk_logical_device;
            set => _vk_logical_device = value;
        }

        private uint _graphics_queue_family_index;
        public uint Graphics_queue_family_index
        {
            readonly get => _graphics_queue_family_index;
            set => _graphics_queue_family_index = value;
        }

        private uint _graphics_queue_index;
        public uint Graphics_queue_index
        {
            readonly get => _graphics_queue_index;
            set => _graphics_queue_index = value;
        }

    }

    public unsafe partial  struct ImpellerTextDecoration
    {
        private int _types;
        public int Types
        {
            readonly get => _types;
            set => _types = value;
        }

        private global::NImpeller.ImpellerColor _color;
        public global::NImpeller.ImpellerColor Color
        {
            readonly get => _color;
            set => _color = value;
        }

        private global::NImpeller.ImpellerTextDecorationStyle _style;
        public global::NImpeller.ImpellerTextDecorationStyle Style
        {
            readonly get => _style;
            set => _style = value;
        }

        private float _thickness_multiplier;
        public float Thickness_multiplier
        {
            readonly get => _thickness_multiplier;
            set => _thickness_multiplier = value;
        }

    }

    static unsafe partial class UnsafeNativeMethods
    {
        public const uint ImpellerVersion = 541081600;

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial uint ImpellerGetVersion();

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerContextHandle ImpellerContextCreateOpenGLESNew(uint version, IntPtr gl_proc_address_callback, System.IntPtr gl_proc_address_callback_user_data);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerContextHandle ImpellerContextCreateMetalNew(uint version);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerContextHandle ImpellerContextCreateVulkanNew(uint version, global::NImpeller.ImpellerContextVulkanSettings* settings);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerContextRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerContextRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial int ImpellerContextGetVulkanInfo(global::NImpeller.ImpellerContextHandle context, global::NImpeller.ImpellerContextVulkanInfo* out_vulkan_info);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerVulkanSwapchainHandle ImpellerVulkanSwapchainCreateNew(global::NImpeller.ImpellerContextHandle context, System.IntPtr vulkan_surface_khr);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerVulkanSwapchainRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerVulkanSwapchainRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerSurfaceHandle ImpellerVulkanSwapchainAcquireNextSurfaceNew(global::NImpeller.ImpellerVulkanSwapchainHandle swapchain);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerSurfaceHandle ImpellerSurfaceCreateWrappedFBONew(global::NImpeller.ImpellerContextHandle context, ulong fbo, global::NImpeller.ImpellerPixelFormat format, global::NImpeller.ImpellerISize* size);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerSurfaceHandle ImpellerSurfaceCreateWrappedMetalDrawableNew(global::NImpeller.ImpellerContextHandle context, System.IntPtr metal_drawable);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerSurfaceRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerSurfaceRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial int ImpellerSurfaceDrawDisplayList(global::NImpeller.ImpellerSurfaceHandle surface, global::NImpeller.ImpellerDisplayListHandle display_list);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial int ImpellerSurfacePresent(global::NImpeller.ImpellerSurfaceHandle surface);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerPathRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerPathRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerPathGetBounds(global::NImpeller.ImpellerPathHandle path, global::NImpeller.ImpellerRect* out_bounds);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial global::NImpeller.ImpellerPathBuilderHandle ImpellerPathBuilderNew();

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerPathBuilderRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerPathBuilderRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerPathBuilderMoveTo(global::NImpeller.ImpellerPathBuilderHandle builder, global::NImpeller.ImpellerPoint* location);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerPathBuilderLineTo(global::NImpeller.ImpellerPathBuilderHandle builder, global::NImpeller.ImpellerPoint* location);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerPathBuilderQuadraticCurveTo(global::NImpeller.ImpellerPathBuilderHandle builder, global::NImpeller.ImpellerPoint* control_point, global::NImpeller.ImpellerPoint* end_point);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerPathBuilderCubicCurveTo(global::NImpeller.ImpellerPathBuilderHandle builder, global::NImpeller.ImpellerPoint* control_point_1, global::NImpeller.ImpellerPoint* control_point_2, global::NImpeller.ImpellerPoint* end_point);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerPathBuilderAddRect(global::NImpeller.ImpellerPathBuilderHandle builder, global::NImpeller.ImpellerRect* rect);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerPathBuilderAddArc(global::NImpeller.ImpellerPathBuilderHandle builder, global::NImpeller.ImpellerRect* oval_bounds, float start_angle_degrees, float end_angle_degrees);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerPathBuilderAddOval(global::NImpeller.ImpellerPathBuilderHandle builder, global::NImpeller.ImpellerRect* oval_bounds);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerPathBuilderAddRoundedRect(global::NImpeller.ImpellerPathBuilderHandle builder, global::NImpeller.ImpellerRect* rect, global::NImpeller.ImpellerRoundingRadii* rounding_radii);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerPathBuilderClose(global::NImpeller.ImpellerPathBuilderHandle builder);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial global::NImpeller.ImpellerPathHandle ImpellerPathBuilderCopyPathNew(global::NImpeller.ImpellerPathBuilderHandle builder, global::NImpeller.ImpellerFillType fill);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial global::NImpeller.ImpellerPathHandle ImpellerPathBuilderTakePathNew(global::NImpeller.ImpellerPathBuilderHandle builder, global::NImpeller.ImpellerFillType fill);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerPaintHandle ImpellerPaintNew();

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerPaintRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerPaintRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerPaintSetColor(global::NImpeller.ImpellerPaintHandle paint, global::NImpeller.ImpellerColor* color);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerPaintSetBlendMode(global::NImpeller.ImpellerPaintHandle paint, global::NImpeller.ImpellerBlendMode mode);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerPaintSetDrawStyle(global::NImpeller.ImpellerPaintHandle paint, global::NImpeller.ImpellerDrawStyle style);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerPaintSetStrokeCap(global::NImpeller.ImpellerPaintHandle paint, global::NImpeller.ImpellerStrokeCap cap);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerPaintSetStrokeJoin(global::NImpeller.ImpellerPaintHandle paint, global::NImpeller.ImpellerStrokeJoin join);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerPaintSetStrokeWidth(global::NImpeller.ImpellerPaintHandle paint, float width);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerPaintSetStrokeMiter(global::NImpeller.ImpellerPaintHandle paint, float miter);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerPaintSetColorFilter(global::NImpeller.ImpellerPaintHandle paint, global::NImpeller.ImpellerColorFilterHandle color_filter);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerPaintSetColorSource(global::NImpeller.ImpellerPaintHandle paint, global::NImpeller.ImpellerColorSourceHandle color_source);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerPaintSetImageFilter(global::NImpeller.ImpellerPaintHandle paint, global::NImpeller.ImpellerImageFilterHandle image_filter);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerPaintSetMaskFilter(global::NImpeller.ImpellerPaintHandle paint, global::NImpeller.ImpellerMaskFilterHandle mask_filter);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerTextureHandle ImpellerTextureCreateWithContentsNew(global::NImpeller.ImpellerContextHandle context, global::NImpeller.ImpellerTextureDescriptor* descriptor, global::NImpeller.ImpellerMapping* contents, System.IntPtr contents_on_release_user_data);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerTextureHandle ImpellerTextureCreateWithOpenGLTextureHandleNew(global::NImpeller.ImpellerContextHandle context, global::NImpeller.ImpellerTextureDescriptor* descriptor, ulong handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerTextureRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerTextureRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial ulong ImpellerTextureGetOpenGLHandle(global::NImpeller.ImpellerTextureHandle texture);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerFragmentProgramHandle ImpellerFragmentProgramNew(global::NImpeller.ImpellerMapping* data, System.IntPtr data_release_user_data);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerFragmentProgramRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerFragmentProgramRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerColorSourceRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerColorSourceRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerColorSourceHandle ImpellerColorSourceCreateLinearGradientNew(global::NImpeller.ImpellerPoint* start_point, global::NImpeller.ImpellerPoint* end_point, uint stop_count, global::NImpeller.ImpellerColor* colors, float* stops, global::NImpeller.ImpellerTileMode tile_mode, global::NImpeller.ImpellerMatrix* transformation);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerColorSourceHandle ImpellerColorSourceCreateRadialGradientNew(global::NImpeller.ImpellerPoint* center, float radius, uint stop_count, global::NImpeller.ImpellerColor* colors, float* stops, global::NImpeller.ImpellerTileMode tile_mode, global::NImpeller.ImpellerMatrix* transformation);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerColorSourceHandle ImpellerColorSourceCreateConicalGradientNew(global::NImpeller.ImpellerPoint* start_center, float start_radius, global::NImpeller.ImpellerPoint* end_center, float end_radius, uint stop_count, global::NImpeller.ImpellerColor* colors, float* stops, global::NImpeller.ImpellerTileMode tile_mode, global::NImpeller.ImpellerMatrix* transformation);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerColorSourceHandle ImpellerColorSourceCreateSweepGradientNew(global::NImpeller.ImpellerPoint* center, float start, float end, uint stop_count, global::NImpeller.ImpellerColor* colors, float* stops, global::NImpeller.ImpellerTileMode tile_mode, global::NImpeller.ImpellerMatrix* transformation);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerColorSourceHandle ImpellerColorSourceCreateImageNew(global::NImpeller.ImpellerTextureHandle image, global::NImpeller.ImpellerTileMode horizontal_tile_mode, global::NImpeller.ImpellerTileMode vertical_tile_mode, global::NImpeller.ImpellerTextureSampling sampling, global::NImpeller.ImpellerMatrix* transformation);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerColorSourceHandle ImpellerColorSourceCreateFragmentProgramNew(global::NImpeller.ImpellerContextHandle context, global::NImpeller.ImpellerFragmentProgramHandle fragment_program, global::System.IntPtr* samplers, ulong samplers_count, byte* data, ulong data_bytes_length);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerColorFilterRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerColorFilterRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerColorFilterHandle ImpellerColorFilterCreateBlendNew(global::NImpeller.ImpellerColor* color, global::NImpeller.ImpellerBlendMode blend_mode);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerColorFilterHandle ImpellerColorFilterCreateColorMatrixNew(global::NImpeller.ImpellerColorMatrix* color_matrix);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerMaskFilterRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerMaskFilterRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerMaskFilterHandle ImpellerMaskFilterCreateBlurNew(global::NImpeller.ImpellerBlurStyle style, float sigma);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerImageFilterRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerImageFilterRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerImageFilterHandle ImpellerImageFilterCreateBlurNew(float x_sigma, float y_sigma, global::NImpeller.ImpellerTileMode tile_mode);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerImageFilterHandle ImpellerImageFilterCreateDilateNew(float x_radius, float y_radius);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerImageFilterHandle ImpellerImageFilterCreateErodeNew(float x_radius, float y_radius);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerImageFilterHandle ImpellerImageFilterCreateMatrixNew(global::NImpeller.ImpellerMatrix* matrix, global::NImpeller.ImpellerTextureSampling sampling);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerImageFilterHandle ImpellerImageFilterCreateFragmentProgramNew(global::NImpeller.ImpellerContextHandle context, global::NImpeller.ImpellerFragmentProgramHandle fragment_program, global::System.IntPtr* samplers, ulong samplers_count, byte* data, ulong data_bytes_length);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerImageFilterHandle ImpellerImageFilterCreateComposeNew(global::NImpeller.ImpellerImageFilterHandle outer, global::NImpeller.ImpellerImageFilterHandle inner);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerDisplayListRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerDisplayListRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerDisplayListBuilderHandle ImpellerDisplayListBuilderNew(global::NImpeller.ImpellerRect* cull_rect);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerDisplayListBuilderRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerDisplayListBuilderRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerDisplayListHandle ImpellerDisplayListBuilderCreateDisplayListNew(global::NImpeller.ImpellerDisplayListBuilderHandle builder);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderSave(global::NImpeller.ImpellerDisplayListBuilderHandle builder);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderSaveLayer(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerRect* bounds, global::NImpeller.ImpellerPaintHandle paint, global::NImpeller.ImpellerImageFilterHandle backdrop);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderRestore(global::NImpeller.ImpellerDisplayListBuilderHandle builder);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderScale(global::NImpeller.ImpellerDisplayListBuilderHandle builder, float x_scale, float y_scale);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderRotate(global::NImpeller.ImpellerDisplayListBuilderHandle builder, float angle_degrees);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderTranslate(global::NImpeller.ImpellerDisplayListBuilderHandle builder, float x_translation, float y_translation);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderTransform(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerMatrix* transform);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderSetTransform(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerMatrix* transform);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderGetTransform(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerMatrix* out_transform);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderResetTransform(global::NImpeller.ImpellerDisplayListBuilderHandle builder);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial uint ImpellerDisplayListBuilderGetSaveCount(global::NImpeller.ImpellerDisplayListBuilderHandle builder);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderRestoreToCount(global::NImpeller.ImpellerDisplayListBuilderHandle builder, uint count);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderClipRect(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerRect* rect, global::NImpeller.ImpellerClipOperation op);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderClipOval(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerRect* oval_bounds, global::NImpeller.ImpellerClipOperation op);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderClipRoundedRect(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerRect* rect, global::NImpeller.ImpellerRoundingRadii* radii, global::NImpeller.ImpellerClipOperation op);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderClipPath(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerPathHandle path, global::NImpeller.ImpellerClipOperation op);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderDrawPaint(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerPaintHandle paint);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderDrawLine(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerPoint* from, global::NImpeller.ImpellerPoint* to, global::NImpeller.ImpellerPaintHandle paint);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderDrawDashedLine(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerPoint* from, global::NImpeller.ImpellerPoint* to, float on_length, float off_length, global::NImpeller.ImpellerPaintHandle paint);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderDrawRect(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerRect* rect, global::NImpeller.ImpellerPaintHandle paint);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderDrawOval(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerRect* oval_bounds, global::NImpeller.ImpellerPaintHandle paint);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderDrawRoundedRect(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerRect* rect, global::NImpeller.ImpellerRoundingRadii* radii, global::NImpeller.ImpellerPaintHandle paint);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderDrawRoundedRectDifference(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerRect* outer_rect, global::NImpeller.ImpellerRoundingRadii* outer_radii, global::NImpeller.ImpellerRect* inner_rect, global::NImpeller.ImpellerRoundingRadii* inner_radii, global::NImpeller.ImpellerPaintHandle paint);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderDrawPath(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerPathHandle path, global::NImpeller.ImpellerPaintHandle paint);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderDrawDisplayList(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerDisplayListHandle display_list, float opacity);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderDrawParagraph(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerParagraphHandle paragraph, global::NImpeller.ImpellerPoint* point);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderDrawShadow(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerPathHandle path, global::NImpeller.ImpellerColor* color, float elevation, int occluder_is_transparent, float device_pixel_ratio);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderDrawTexture(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerTextureHandle texture, global::NImpeller.ImpellerPoint* point, global::NImpeller.ImpellerTextureSampling sampling, global::NImpeller.ImpellerPaintHandle paint);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerDisplayListBuilderDrawTextureRect(global::NImpeller.ImpellerDisplayListBuilderHandle builder, global::NImpeller.ImpellerTextureHandle texture, global::NImpeller.ImpellerRect* src_rect, global::NImpeller.ImpellerRect* dst_rect, global::NImpeller.ImpellerTextureSampling sampling, global::NImpeller.ImpellerPaintHandle paint);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerTypographyContextHandle ImpellerTypographyContextNew();

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerTypographyContextRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerTypographyContextRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial int ImpellerTypographyContextRegisterFont(global::NImpeller.ImpellerTypographyContextHandle context, global::NImpeller.ImpellerMapping* contents, System.IntPtr contents_on_release_user_data, string family_name_alias);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerParagraphStyleHandle ImpellerParagraphStyleNew();

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerParagraphStyleRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerParagraphStyleRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphStyleSetForeground(global::NImpeller.ImpellerParagraphStyleHandle paragraph_style, global::NImpeller.ImpellerPaintHandle paint);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphStyleSetBackground(global::NImpeller.ImpellerParagraphStyleHandle paragraph_style, global::NImpeller.ImpellerPaintHandle paint);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphStyleSetFontWeight(global::NImpeller.ImpellerParagraphStyleHandle paragraph_style, global::NImpeller.ImpellerFontWeight weight);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphStyleSetFontStyle(global::NImpeller.ImpellerParagraphStyleHandle paragraph_style, global::NImpeller.ImpellerFontStyle style);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphStyleSetFontFamily(global::NImpeller.ImpellerParagraphStyleHandle paragraph_style, string family_name);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphStyleSetFontSize(global::NImpeller.ImpellerParagraphStyleHandle paragraph_style, float size);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphStyleSetHeight(global::NImpeller.ImpellerParagraphStyleHandle paragraph_style, float height);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphStyleSetTextAlignment(global::NImpeller.ImpellerParagraphStyleHandle paragraph_style, global::NImpeller.ImpellerTextAlignment align);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphStyleSetTextDirection(global::NImpeller.ImpellerParagraphStyleHandle paragraph_style, global::NImpeller.ImpellerTextDirection direction);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphStyleSetTextDecoration(global::NImpeller.ImpellerParagraphStyleHandle paragraph_style, global::NImpeller.ImpellerTextDecoration* decoration);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphStyleSetMaxLines(global::NImpeller.ImpellerParagraphStyleHandle paragraph_style, uint max_lines);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphStyleSetLocale(global::NImpeller.ImpellerParagraphStyleHandle paragraph_style, string locale);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphStyleSetEllipsis(global::NImpeller.ImpellerParagraphStyleHandle paragraph_style, string ellipsis);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerParagraphBuilderHandle ImpellerParagraphBuilderNew(global::NImpeller.ImpellerTypographyContextHandle context);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerParagraphBuilderRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerParagraphBuilderRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphBuilderPushStyle(global::NImpeller.ImpellerParagraphBuilderHandle paragraph_builder, global::NImpeller.ImpellerParagraphStyleHandle style);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphBuilderPopStyle(global::NImpeller.ImpellerParagraphBuilderHandle paragraph_builder);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphBuilderAddText(global::NImpeller.ImpellerParagraphBuilderHandle paragraph_builder, byte* data, uint length);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerParagraphHandle ImpellerParagraphBuilderBuildParagraphNew(global::NImpeller.ImpellerParagraphBuilderHandle paragraph_builder, float width);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerParagraphRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerParagraphRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial float ImpellerParagraphGetMaxWidth(global::NImpeller.ImpellerParagraphHandle paragraph);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial float ImpellerParagraphGetHeight(global::NImpeller.ImpellerParagraphHandle paragraph);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial float ImpellerParagraphGetLongestLineWidth(global::NImpeller.ImpellerParagraphHandle paragraph);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial float ImpellerParagraphGetMinIntrinsicWidth(global::NImpeller.ImpellerParagraphHandle paragraph);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial float ImpellerParagraphGetMaxIntrinsicWidth(global::NImpeller.ImpellerParagraphHandle paragraph);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial float ImpellerParagraphGetIdeographicBaseline(global::NImpeller.ImpellerParagraphHandle paragraph);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial float ImpellerParagraphGetAlphabeticBaseline(global::NImpeller.ImpellerParagraphHandle paragraph);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial uint ImpellerParagraphGetLineCount(global::NImpeller.ImpellerParagraphHandle paragraph);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerParagraphGetWordBoundary(global::NImpeller.ImpellerParagraphHandle paragraph, ulong code_unit_index, global::NImpeller.ImpellerRange* out_range);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::System.IntPtr ImpellerParagraphGetLineMetrics(global::NImpeller.ImpellerParagraphHandle paragraph);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerGlyphInfoHandle ImpellerParagraphCreateGlyphInfoAtCodeUnitIndexNew(global::NImpeller.ImpellerParagraphHandle paragraph, ulong code_unit_index);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerGlyphInfoHandle ImpellerParagraphCreateGlyphInfoAtParagraphCoordinatesNew(global::NImpeller.ImpellerParagraphHandle paragraph, double x, double y);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerLineMetricsRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerLineMetricsRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial double ImpellerLineMetricsGetUnscaledAscent(global::NImpeller.ImpellerLineMetricsHandle metrics, ulong line);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial double ImpellerLineMetricsGetAscent(global::NImpeller.ImpellerLineMetricsHandle metrics, ulong line);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial double ImpellerLineMetricsGetDescent(global::NImpeller.ImpellerLineMetricsHandle metrics, ulong line);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial double ImpellerLineMetricsGetBaseline(global::NImpeller.ImpellerLineMetricsHandle metrics, ulong line);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial int ImpellerLineMetricsIsHardbreak(global::NImpeller.ImpellerLineMetricsHandle metrics, ulong line);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial double ImpellerLineMetricsGetWidth(global::NImpeller.ImpellerLineMetricsHandle metrics, ulong line);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial double ImpellerLineMetricsGetHeight(global::NImpeller.ImpellerLineMetricsHandle metrics, ulong line);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial double ImpellerLineMetricsGetLeft(global::NImpeller.ImpellerLineMetricsHandle metrics, ulong line);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial ulong ImpellerLineMetricsGetCodeUnitStartIndex(global::NImpeller.ImpellerLineMetricsHandle metrics, ulong line);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial ulong ImpellerLineMetricsGetCodeUnitEndIndex(global::NImpeller.ImpellerLineMetricsHandle metrics, ulong line);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial ulong ImpellerLineMetricsGetCodeUnitEndIndexExcludingWhitespace(global::NImpeller.ImpellerLineMetricsHandle metrics, ulong line);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial ulong ImpellerLineMetricsGetCodeUnitEndIndexIncludingNewline(global::NImpeller.ImpellerLineMetricsHandle metrics, ulong line);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerGlyphInfoRetain(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        [System.Runtime.InteropServices.SuppressGCTransition]
        public static partial void ImpellerGlyphInfoRelease(IntPtr handle);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial ulong ImpellerGlyphInfoGetGraphemeClusterCodeUnitRangeBegin(global::NImpeller.ImpellerGlyphInfoHandle glyph_info);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial ulong ImpellerGlyphInfoGetGraphemeClusterCodeUnitRangeEnd(global::NImpeller.ImpellerGlyphInfoHandle glyph_info);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial void ImpellerGlyphInfoGetGraphemeClusterBounds(global::NImpeller.ImpellerGlyphInfoHandle glyph_info, global::NImpeller.ImpellerRect* out_bounds);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial int ImpellerGlyphInfoIsEllipsis(global::NImpeller.ImpellerGlyphInfoHandle glyph_info);

        [System.Runtime.InteropServices.UnmanagedCallConv(CallConvs = [typeof(System.Runtime.CompilerServices.CallConvStdcall)])]
        [System.Runtime.InteropServices.LibraryImport("impeller", StringMarshalling = System.Runtime.InteropServices.StringMarshalling.Utf8)]
        public static partial global::NImpeller.ImpellerTextDirection ImpellerGlyphInfoGetTextDirection(global::NImpeller.ImpellerGlyphInfoHandle glyph_info);

    }
    public partial class ImpellerContext : IDisposable
    {
        private ImpellerContextHandle _handle;
        internal ImpellerContextHandle Handle => _handle;
        internal ImpellerContext(ImpellerContextHandle handle)
        {
            _handle = handle;
        }

        public int GetVulkanInfo(out global::NImpeller.ImpellerContextVulkanInfo out_vulkan_info)
        {
            unsafe
            {
                global::NImpeller.ImpellerContextVulkanInfo __out_vulkan_info;
                var ret = UnsafeNativeMethods.ImpellerContextGetVulkanInfo(_handle, &__out_vulkan_info);
                out_vulkan_info = __out_vulkan_info;
                return ret;
            }

        }

        public global::NImpeller.ImpellerVulkanSwapchain? VulkanSwapchainCreateNew(System.IntPtr vulkan_surface_khr)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerVulkanSwapchainCreateNew(_handle, vulkan_surface_khr);
                if(ret == null) return null;
                return new ImpellerVulkanSwapchain(ret);
            }

        }

        public global::NImpeller.ImpellerSurface? SurfaceCreateWrappedFBONew(ulong fbo, global::NImpeller.ImpellerPixelFormat format, global::NImpeller.ImpellerISize size)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerSurfaceCreateWrappedFBONew(_handle, fbo, format, &size);
                if(ret == null) return null;
                return new ImpellerSurface(ret);
            }

        }

        public global::NImpeller.ImpellerSurface? SurfaceCreateWrappedMetalDrawableNew(System.IntPtr metal_drawable)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerSurfaceCreateWrappedMetalDrawableNew(_handle, metal_drawable);
                if(ret == null) return null;
                return new ImpellerSurface(ret);
            }

        }

        public global::NImpeller.ImpellerTexture? TextureCreateWithContentsNew(global::NImpeller.ImpellerTextureDescriptor descriptor, IImpellerUnmanagedMemory contents, System.IntPtr contents_on_release_user_data)
        {
            unsafe
            {
                using var __marshal_contents = ImpellerMapping.Marshal(contents);
                var ret = UnsafeNativeMethods.ImpellerTextureCreateWithContentsNew(_handle, &descriptor, __marshal_contents.Value, contents_on_release_user_data);
                if(ret == null) return null;
                return new ImpellerTexture(ret);
            }

        }

        public global::NImpeller.ImpellerTexture? TextureCreateWithOpenGLTextureHandleNew(global::NImpeller.ImpellerTextureDescriptor descriptor, ulong handle)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerTextureCreateWithOpenGLTextureHandleNew(_handle, &descriptor, handle);
                if(ret == null) return null;
                return new ImpellerTexture(ret);
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerDisplayList : IDisposable
    {
        private ImpellerDisplayListHandle _handle;
        internal ImpellerDisplayListHandle Handle => _handle;
        internal ImpellerDisplayList(ImpellerDisplayListHandle handle)
        {
            _handle = handle;
        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerDisplayListBuilder : IDisposable
    {
        private ImpellerDisplayListBuilderHandle _handle;
        internal ImpellerDisplayListBuilderHandle Handle => _handle;
        internal ImpellerDisplayListBuilder(ImpellerDisplayListBuilderHandle handle)
        {
            _handle = handle;
        }

        public global::NImpeller.ImpellerDisplayList? CreateDisplayListNew()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerDisplayListBuilderCreateDisplayListNew(_handle);
                if(ret == null) return null;
                return new ImpellerDisplayList(ret);
            }

        }

        public void Save()
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderSave(_handle);
            }

        }

        public void SaveLayer(global::NImpeller.ImpellerRect bounds, global::NImpeller.ImpellerPaint paint, global::NImpeller.ImpellerImageFilter backdrop)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderSaveLayer(_handle, &bounds, paint.Handle, backdrop.Handle);
            }

        }

        public void Restore()
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderRestore(_handle);
            }

        }

        public void Scale(float x_scale, float y_scale)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderScale(_handle, x_scale, y_scale);
            }

        }

        public void Rotate(float angle_degrees)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderRotate(_handle, angle_degrees);
            }

        }

        public void Translate(float x_translation, float y_translation)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderTranslate(_handle, x_translation, y_translation);
            }

        }

        public void Transform(global::NImpeller.ImpellerMatrix transform)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderTransform(_handle, &transform);
            }

        }

        public void SetTransform(global::NImpeller.ImpellerMatrix transform)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderSetTransform(_handle, &transform);
            }

        }

        public void GetTransform(out global::NImpeller.ImpellerMatrix out_transform)
        {
            unsafe
            {
                global::NImpeller.ImpellerMatrix __out_transform;
                UnsafeNativeMethods.ImpellerDisplayListBuilderGetTransform(_handle, &__out_transform);
                out_transform = __out_transform;
            }

        }

        public void ResetTransform()
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderResetTransform(_handle);
            }

        }

        public uint GetSaveCount()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerDisplayListBuilderGetSaveCount(_handle);
                return ret;
            }

        }

        public void RestoreToCount(uint count)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderRestoreToCount(_handle, count);
            }

        }

        public void ClipRect(global::NImpeller.ImpellerRect rect, global::NImpeller.ImpellerClipOperation op)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderClipRect(_handle, &rect, op);
            }

        }

        public void ClipOval(global::NImpeller.ImpellerRect oval_bounds, global::NImpeller.ImpellerClipOperation op)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderClipOval(_handle, &oval_bounds, op);
            }

        }

        public void ClipRoundedRect(global::NImpeller.ImpellerRect rect, global::NImpeller.ImpellerRoundingRadii radii, global::NImpeller.ImpellerClipOperation op)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderClipRoundedRect(_handle, &rect, &radii, op);
            }

        }

        public void ClipPath(global::NImpeller.ImpellerPath path, global::NImpeller.ImpellerClipOperation op)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderClipPath(_handle, path.Handle, op);
            }

        }

        public void DrawPaint(global::NImpeller.ImpellerPaint paint)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderDrawPaint(_handle, paint.Handle);
            }

        }

        public void DrawLine(global::NImpeller.ImpellerPoint from, global::NImpeller.ImpellerPoint to, global::NImpeller.ImpellerPaint paint)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderDrawLine(_handle, &from, &to, paint.Handle);
            }

        }

        public void DrawDashedLine(global::NImpeller.ImpellerPoint from, global::NImpeller.ImpellerPoint to, float on_length, float off_length, global::NImpeller.ImpellerPaint paint)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderDrawDashedLine(_handle, &from, &to, on_length, off_length, paint.Handle);
            }

        }

        public void DrawRect(global::NImpeller.ImpellerRect rect, global::NImpeller.ImpellerPaint paint)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderDrawRect(_handle, &rect, paint.Handle);
            }

        }

        public void DrawOval(global::NImpeller.ImpellerRect oval_bounds, global::NImpeller.ImpellerPaint paint)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderDrawOval(_handle, &oval_bounds, paint.Handle);
            }

        }

        public void DrawRoundedRect(global::NImpeller.ImpellerRect rect, global::NImpeller.ImpellerRoundingRadii radii, global::NImpeller.ImpellerPaint paint)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderDrawRoundedRect(_handle, &rect, &radii, paint.Handle);
            }

        }

        public void DrawRoundedRectDifference(global::NImpeller.ImpellerRect outer_rect, global::NImpeller.ImpellerRoundingRadii outer_radii, global::NImpeller.ImpellerRect inner_rect, global::NImpeller.ImpellerRoundingRadii inner_radii, global::NImpeller.ImpellerPaint paint)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderDrawRoundedRectDifference(_handle, &outer_rect, &outer_radii, &inner_rect, &inner_radii, paint.Handle);
            }

        }

        public void DrawPath(global::NImpeller.ImpellerPath path, global::NImpeller.ImpellerPaint paint)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderDrawPath(_handle, path.Handle, paint.Handle);
            }

        }

        public void DrawDisplayList(global::NImpeller.ImpellerDisplayList display_list, float opacity)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderDrawDisplayList(_handle, display_list.Handle, opacity);
            }

        }

        public void DrawParagraph(global::NImpeller.ImpellerParagraph paragraph, global::NImpeller.ImpellerPoint point)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderDrawParagraph(_handle, paragraph.Handle, &point);
            }

        }

        public void DrawShadow(global::NImpeller.ImpellerPath path, global::NImpeller.ImpellerColor color, float elevation, int occluder_is_transparent, float device_pixel_ratio)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderDrawShadow(_handle, path.Handle, &color, elevation, occluder_is_transparent, device_pixel_ratio);
            }

        }

        public void DrawTexture(global::NImpeller.ImpellerTexture texture, global::NImpeller.ImpellerPoint point, global::NImpeller.ImpellerTextureSampling sampling, global::NImpeller.ImpellerPaint paint)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderDrawTexture(_handle, texture.Handle, &point, sampling, paint.Handle);
            }

        }

        public void DrawTextureRect(global::NImpeller.ImpellerTexture texture, global::NImpeller.ImpellerRect src_rect, global::NImpeller.ImpellerRect dst_rect, global::NImpeller.ImpellerTextureSampling sampling, global::NImpeller.ImpellerPaint paint)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerDisplayListBuilderDrawTextureRect(_handle, texture.Handle, &src_rect, &dst_rect, sampling, paint.Handle);
            }

        }

        public static global::NImpeller.ImpellerDisplayListBuilder? New(global::NImpeller.ImpellerRect cull_rect)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerDisplayListBuilderNew(&cull_rect);
                if(ret == null) return null;
                return new ImpellerDisplayListBuilder(ret);
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerPaint : IDisposable
    {
        private ImpellerPaintHandle _handle;
        internal ImpellerPaintHandle Handle => _handle;
        internal ImpellerPaint(ImpellerPaintHandle handle)
        {
            _handle = handle;
        }

        public void SetColor(global::NImpeller.ImpellerColor color)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPaintSetColor(_handle, &color);
            }

        }

        public void SetBlendMode(global::NImpeller.ImpellerBlendMode mode)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPaintSetBlendMode(_handle, mode);
            }

        }

        public void SetDrawStyle(global::NImpeller.ImpellerDrawStyle style)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPaintSetDrawStyle(_handle, style);
            }

        }

        public void SetStrokeCap(global::NImpeller.ImpellerStrokeCap cap)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPaintSetStrokeCap(_handle, cap);
            }

        }

        public void SetStrokeJoin(global::NImpeller.ImpellerStrokeJoin join)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPaintSetStrokeJoin(_handle, join);
            }

        }

        public void SetStrokeWidth(float width)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPaintSetStrokeWidth(_handle, width);
            }

        }

        public void SetStrokeMiter(float miter)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPaintSetStrokeMiter(_handle, miter);
            }

        }

        public void SetColorFilter(global::NImpeller.ImpellerColorFilter color_filter)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPaintSetColorFilter(_handle, color_filter.Handle);
            }

        }

        public void SetColorSource(global::NImpeller.ImpellerColorSource color_source)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPaintSetColorSource(_handle, color_source.Handle);
            }

        }

        public void SetImageFilter(global::NImpeller.ImpellerImageFilter image_filter)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPaintSetImageFilter(_handle, image_filter.Handle);
            }

        }

        public void SetMaskFilter(global::NImpeller.ImpellerMaskFilter mask_filter)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPaintSetMaskFilter(_handle, mask_filter.Handle);
            }

        }

        public static global::NImpeller.ImpellerPaint? New()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerPaintNew();
                if(ret == null) return null;
                return new ImpellerPaint(ret);
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerColorFilter : IDisposable
    {
        private ImpellerColorFilterHandle _handle;
        internal ImpellerColorFilterHandle Handle => _handle;
        internal ImpellerColorFilter(ImpellerColorFilterHandle handle)
        {
            _handle = handle;
        }

        public static global::NImpeller.ImpellerColorFilter? CreateBlendNew(global::NImpeller.ImpellerColor color, global::NImpeller.ImpellerBlendMode blend_mode)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerColorFilterCreateBlendNew(&color, blend_mode);
                if(ret == null) return null;
                return new ImpellerColorFilter(ret);
            }

        }

        public static global::NImpeller.ImpellerColorFilter? CreateColorMatrixNew(global::NImpeller.ImpellerColorMatrix color_matrix)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerColorFilterCreateColorMatrixNew(&color_matrix);
                if(ret == null) return null;
                return new ImpellerColorFilter(ret);
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerColorSource : IDisposable
    {
        private ImpellerColorSourceHandle _handle;
        internal ImpellerColorSourceHandle Handle => _handle;
        internal ImpellerColorSource(ImpellerColorSourceHandle handle)
        {
            _handle = handle;
        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerImageFilter : IDisposable
    {
        private ImpellerImageFilterHandle _handle;
        internal ImpellerImageFilterHandle Handle => _handle;
        internal ImpellerImageFilter(ImpellerImageFilterHandle handle)
        {
            _handle = handle;
        }

        public global::NImpeller.ImpellerImageFilter? CreateComposeNew(global::NImpeller.ImpellerImageFilter inner)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerImageFilterCreateComposeNew(_handle, inner.Handle);
                if(ret == null) return null;
                return new ImpellerImageFilter(ret);
            }

        }

        public static global::NImpeller.ImpellerImageFilter? CreateBlurNew(float x_sigma, float y_sigma, global::NImpeller.ImpellerTileMode tile_mode)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerImageFilterCreateBlurNew(x_sigma, y_sigma, tile_mode);
                if(ret == null) return null;
                return new ImpellerImageFilter(ret);
            }

        }

        public static global::NImpeller.ImpellerImageFilter? CreateDilateNew(float x_radius, float y_radius)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerImageFilterCreateDilateNew(x_radius, y_radius);
                if(ret == null) return null;
                return new ImpellerImageFilter(ret);
            }

        }

        public static global::NImpeller.ImpellerImageFilter? CreateErodeNew(float x_radius, float y_radius)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerImageFilterCreateErodeNew(x_radius, y_radius);
                if(ret == null) return null;
                return new ImpellerImageFilter(ret);
            }

        }

        public static global::NImpeller.ImpellerImageFilter? CreateMatrixNew(global::NImpeller.ImpellerMatrix matrix, global::NImpeller.ImpellerTextureSampling sampling)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerImageFilterCreateMatrixNew(&matrix, sampling);
                if(ret == null) return null;
                return new ImpellerImageFilter(ret);
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerMaskFilter : IDisposable
    {
        private ImpellerMaskFilterHandle _handle;
        internal ImpellerMaskFilterHandle Handle => _handle;
        internal ImpellerMaskFilter(ImpellerMaskFilterHandle handle)
        {
            _handle = handle;
        }

        public static global::NImpeller.ImpellerMaskFilter? CreateBlurNew(global::NImpeller.ImpellerBlurStyle style, float sigma)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerMaskFilterCreateBlurNew(style, sigma);
                if(ret == null) return null;
                return new ImpellerMaskFilter(ret);
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerTypographyContext : IDisposable
    {
        private ImpellerTypographyContextHandle _handle;
        internal ImpellerTypographyContextHandle Handle => _handle;
        internal ImpellerTypographyContext(ImpellerTypographyContextHandle handle)
        {
            _handle = handle;
        }

        public global::NImpeller.ImpellerParagraphBuilder? ParagraphBuilderNew()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerParagraphBuilderNew(_handle);
                if(ret == null) return null;
                return new ImpellerParagraphBuilder(ret);
            }

        }

        public static global::NImpeller.ImpellerTypographyContext? New()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerTypographyContextNew();
                if(ret == null) return null;
                return new ImpellerTypographyContext(ret);
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerParagraph : IDisposable
    {
        private ImpellerParagraphHandle _handle;
        internal ImpellerParagraphHandle Handle => _handle;
        internal ImpellerParagraph(ImpellerParagraphHandle handle)
        {
            _handle = handle;
        }

        public float GetMaxWidth()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerParagraphGetMaxWidth(_handle);
                return ret;
            }

        }

        public float GetHeight()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerParagraphGetHeight(_handle);
                return ret;
            }

        }

        public float GetLongestLineWidth()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerParagraphGetLongestLineWidth(_handle);
                return ret;
            }

        }

        public float GetMinIntrinsicWidth()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerParagraphGetMinIntrinsicWidth(_handle);
                return ret;
            }

        }

        public float GetMaxIntrinsicWidth()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerParagraphGetMaxIntrinsicWidth(_handle);
                return ret;
            }

        }

        public float GetIdeographicBaseline()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerParagraphGetIdeographicBaseline(_handle);
                return ret;
            }

        }

        public float GetAlphabeticBaseline()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerParagraphGetAlphabeticBaseline(_handle);
                return ret;
            }

        }

        public uint GetLineCount()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerParagraphGetLineCount(_handle);
                return ret;
            }

        }

        public void GetWordBoundary(ulong code_unit_index, out global::NImpeller.ImpellerRange out_range)
        {
            unsafe
            {
                global::NImpeller.ImpellerRange __out_range;
                UnsafeNativeMethods.ImpellerParagraphGetWordBoundary(_handle, code_unit_index, &__out_range);
                out_range = __out_range;
            }

        }

        public global::NImpeller.ImpellerLineMetrics? GetLineMetrics()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerParagraphGetLineMetrics(_handle);
                if(ret == global::System.IntPtr.Zero) return null;
                return new ImpellerLineMetrics(ImpellerHandle.RetainFromNative<ImpellerLineMetricsHandle>(ret));
            }

        }

        public global::NImpeller.ImpellerGlyphInfo? CreateGlyphInfoAtCodeUnitIndexNew(ulong code_unit_index)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerParagraphCreateGlyphInfoAtCodeUnitIndexNew(_handle, code_unit_index);
                if(ret == null) return null;
                return new ImpellerGlyphInfo(ret);
            }

        }

        public global::NImpeller.ImpellerGlyphInfo? CreateGlyphInfoAtParagraphCoordinatesNew(double x, double y)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerParagraphCreateGlyphInfoAtParagraphCoordinatesNew(_handle, x, y);
                if(ret == null) return null;
                return new ImpellerGlyphInfo(ret);
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerParagraphBuilder : IDisposable
    {
        private ImpellerParagraphBuilderHandle _handle;
        internal ImpellerParagraphBuilderHandle Handle => _handle;
        internal ImpellerParagraphBuilder(ImpellerParagraphBuilderHandle handle)
        {
            _handle = handle;
        }

        public void PushStyle(global::NImpeller.ImpellerParagraphStyle style)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerParagraphBuilderPushStyle(_handle, style.Handle);
            }

        }

        public void PopStyle()
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerParagraphBuilderPopStyle(_handle);
            }

        }

        public global::NImpeller.ImpellerParagraph? BuildParagraphNew(float width)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerParagraphBuilderBuildParagraphNew(_handle, width);
                if(ret == null) return null;
                return new ImpellerParagraph(ret);
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerParagraphStyle : IDisposable
    {
        private ImpellerParagraphStyleHandle _handle;
        internal ImpellerParagraphStyleHandle Handle => _handle;
        internal ImpellerParagraphStyle(ImpellerParagraphStyleHandle handle)
        {
            _handle = handle;
        }

        public void SetForeground(global::NImpeller.ImpellerPaint paint)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerParagraphStyleSetForeground(_handle, paint.Handle);
            }

        }

        public void SetBackground(global::NImpeller.ImpellerPaint paint)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerParagraphStyleSetBackground(_handle, paint.Handle);
            }

        }

        public void SetFontWeight(global::NImpeller.ImpellerFontWeight weight)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerParagraphStyleSetFontWeight(_handle, weight);
            }

        }

        public void SetFontStyle(global::NImpeller.ImpellerFontStyle style)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerParagraphStyleSetFontStyle(_handle, style);
            }

        }

        public void SetFontFamily(string family_name)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerParagraphStyleSetFontFamily(_handle, family_name);
            }

        }

        public void SetFontSize(float size)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerParagraphStyleSetFontSize(_handle, size);
            }

        }

        public void SetHeight(float height)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerParagraphStyleSetHeight(_handle, height);
            }

        }

        public void SetTextAlignment(global::NImpeller.ImpellerTextAlignment align)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerParagraphStyleSetTextAlignment(_handle, align);
            }

        }

        public void SetTextDirection(global::NImpeller.ImpellerTextDirection direction)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerParagraphStyleSetTextDirection(_handle, direction);
            }

        }

        public void SetTextDecoration(global::NImpeller.ImpellerTextDecoration decoration)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerParagraphStyleSetTextDecoration(_handle, &decoration);
            }

        }

        public void SetMaxLines(uint max_lines)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerParagraphStyleSetMaxLines(_handle, max_lines);
            }

        }

        public void SetLocale(string locale)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerParagraphStyleSetLocale(_handle, locale);
            }

        }

        public void SetEllipsis(string ellipsis)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerParagraphStyleSetEllipsis(_handle, ellipsis);
            }

        }

        public static global::NImpeller.ImpellerParagraphStyle? New()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerParagraphStyleNew();
                if(ret == null) return null;
                return new ImpellerParagraphStyle(ret);
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerLineMetrics : IDisposable
    {
        private ImpellerLineMetricsHandle _handle;
        internal ImpellerLineMetricsHandle Handle => _handle;
        internal ImpellerLineMetrics(ImpellerLineMetricsHandle handle)
        {
            _handle = handle;
        }

        public double GetUnscaledAscent(ulong line)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerLineMetricsGetUnscaledAscent(_handle, line);
                return ret;
            }

        }

        public double GetAscent(ulong line)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerLineMetricsGetAscent(_handle, line);
                return ret;
            }

        }

        public double GetDescent(ulong line)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerLineMetricsGetDescent(_handle, line);
                return ret;
            }

        }

        public double GetBaseline(ulong line)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerLineMetricsGetBaseline(_handle, line);
                return ret;
            }

        }

        public int IsHardbreak(ulong line)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerLineMetricsIsHardbreak(_handle, line);
                return ret;
            }

        }

        public double GetWidth(ulong line)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerLineMetricsGetWidth(_handle, line);
                return ret;
            }

        }

        public double GetHeight(ulong line)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerLineMetricsGetHeight(_handle, line);
                return ret;
            }

        }

        public double GetLeft(ulong line)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerLineMetricsGetLeft(_handle, line);
                return ret;
            }

        }

        public ulong GetCodeUnitStartIndex(ulong line)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerLineMetricsGetCodeUnitStartIndex(_handle, line);
                return ret;
            }

        }

        public ulong GetCodeUnitEndIndex(ulong line)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerLineMetricsGetCodeUnitEndIndex(_handle, line);
                return ret;
            }

        }

        public ulong GetCodeUnitEndIndexExcludingWhitespace(ulong line)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerLineMetricsGetCodeUnitEndIndexExcludingWhitespace(_handle, line);
                return ret;
            }

        }

        public ulong GetCodeUnitEndIndexIncludingNewline(ulong line)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerLineMetricsGetCodeUnitEndIndexIncludingNewline(_handle, line);
                return ret;
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerGlyphInfo : IDisposable
    {
        private ImpellerGlyphInfoHandle _handle;
        internal ImpellerGlyphInfoHandle Handle => _handle;
        internal ImpellerGlyphInfo(ImpellerGlyphInfoHandle handle)
        {
            _handle = handle;
        }

        public ulong GetGraphemeClusterCodeUnitRangeBegin()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerGlyphInfoGetGraphemeClusterCodeUnitRangeBegin(_handle);
                return ret;
            }

        }

        public ulong GetGraphemeClusterCodeUnitRangeEnd()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerGlyphInfoGetGraphemeClusterCodeUnitRangeEnd(_handle);
                return ret;
            }

        }

        public void GetGraphemeClusterBounds(out global::NImpeller.ImpellerRect out_bounds)
        {
            unsafe
            {
                global::NImpeller.ImpellerRect __out_bounds;
                UnsafeNativeMethods.ImpellerGlyphInfoGetGraphemeClusterBounds(_handle, &__out_bounds);
                out_bounds = __out_bounds;
            }

        }

        public int IsEllipsis()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerGlyphInfoIsEllipsis(_handle);
                return ret;
            }

        }

        public global::NImpeller.ImpellerTextDirection GetTextDirection()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerGlyphInfoGetTextDirection(_handle);
                return ret;
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerPath : IDisposable
    {
        private ImpellerPathHandle _handle;
        internal ImpellerPathHandle Handle => _handle;
        internal ImpellerPath(ImpellerPathHandle handle)
        {
            _handle = handle;
        }

        public void GetBounds(out global::NImpeller.ImpellerRect out_bounds)
        {
            unsafe
            {
                global::NImpeller.ImpellerRect __out_bounds;
                UnsafeNativeMethods.ImpellerPathGetBounds(_handle, &__out_bounds);
                out_bounds = __out_bounds;
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerPathBuilder : IDisposable
    {
        private ImpellerPathBuilderHandle _handle;
        internal ImpellerPathBuilderHandle Handle => _handle;
        internal ImpellerPathBuilder(ImpellerPathBuilderHandle handle)
        {
            _handle = handle;
        }

        public void MoveTo(global::NImpeller.ImpellerPoint location)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPathBuilderMoveTo(_handle, &location);
            }

        }

        public void LineTo(global::NImpeller.ImpellerPoint location)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPathBuilderLineTo(_handle, &location);
            }

        }

        public void QuadraticCurveTo(global::NImpeller.ImpellerPoint control_point, global::NImpeller.ImpellerPoint end_point)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPathBuilderQuadraticCurveTo(_handle, &control_point, &end_point);
            }

        }

        public void CubicCurveTo(global::NImpeller.ImpellerPoint control_point_1, global::NImpeller.ImpellerPoint control_point_2, global::NImpeller.ImpellerPoint end_point)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPathBuilderCubicCurveTo(_handle, &control_point_1, &control_point_2, &end_point);
            }

        }

        public void AddRect(global::NImpeller.ImpellerRect rect)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPathBuilderAddRect(_handle, &rect);
            }

        }

        public void AddArc(global::NImpeller.ImpellerRect oval_bounds, float start_angle_degrees, float end_angle_degrees)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPathBuilderAddArc(_handle, &oval_bounds, start_angle_degrees, end_angle_degrees);
            }

        }

        public void AddOval(global::NImpeller.ImpellerRect oval_bounds)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPathBuilderAddOval(_handle, &oval_bounds);
            }

        }

        public void AddRoundedRect(global::NImpeller.ImpellerRect rect, global::NImpeller.ImpellerRoundingRadii rounding_radii)
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPathBuilderAddRoundedRect(_handle, &rect, &rounding_radii);
            }

        }

        public void Close()
        {
            unsafe
            {
                UnsafeNativeMethods.ImpellerPathBuilderClose(_handle);
            }

        }

        public global::NImpeller.ImpellerPath? CopyPathNew(global::NImpeller.ImpellerFillType fill)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerPathBuilderCopyPathNew(_handle, fill);
                if(ret == null) return null;
                return new ImpellerPath(ret);
            }

        }

        public global::NImpeller.ImpellerPath? TakePathNew(global::NImpeller.ImpellerFillType fill)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerPathBuilderTakePathNew(_handle, fill);
                if(ret == null) return null;
                return new ImpellerPath(ret);
            }

        }

        public static global::NImpeller.ImpellerPathBuilder? New()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerPathBuilderNew();
                if(ret == null) return null;
                return new ImpellerPathBuilder(ret);
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerSurface : IDisposable
    {
        private ImpellerSurfaceHandle _handle;
        internal ImpellerSurfaceHandle Handle => _handle;
        internal ImpellerSurface(ImpellerSurfaceHandle handle)
        {
            _handle = handle;
        }

        public int DrawDisplayList(global::NImpeller.ImpellerDisplayList display_list)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerSurfaceDrawDisplayList(_handle, display_list.Handle);
                return ret;
            }

        }

        public int Present()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerSurfacePresent(_handle);
                return ret;
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerTexture : IDisposable
    {
        private ImpellerTextureHandle _handle;
        internal ImpellerTextureHandle Handle => _handle;
        internal ImpellerTexture(ImpellerTextureHandle handle)
        {
            _handle = handle;
        }

        public ulong GetOpenGLHandle()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerTextureGetOpenGLHandle(_handle);
                return ret;
            }

        }

        public global::NImpeller.ImpellerColorSource? ColorSourceCreateImageNew(global::NImpeller.ImpellerTileMode horizontal_tile_mode, global::NImpeller.ImpellerTileMode vertical_tile_mode, global::NImpeller.ImpellerTextureSampling sampling, global::NImpeller.ImpellerMatrix transformation)
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerColorSourceCreateImageNew(_handle, horizontal_tile_mode, vertical_tile_mode, sampling, &transformation);
                if(ret == null) return null;
                return new ImpellerColorSource(ret);
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerVulkanSwapchain : IDisposable
    {
        private ImpellerVulkanSwapchainHandle _handle;
        internal ImpellerVulkanSwapchainHandle Handle => _handle;
        internal ImpellerVulkanSwapchain(ImpellerVulkanSwapchainHandle handle)
        {
            _handle = handle;
        }

        public global::NImpeller.ImpellerSurface? AcquireNextSurfaceNew()
        {
            unsafe
            {
                var ret = UnsafeNativeMethods.ImpellerVulkanSwapchainAcquireNextSurfaceNew(_handle);
                if(ret == null) return null;
                return new ImpellerSurface(ret);
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

    public partial class ImpellerFragmentProgram : IDisposable
    {
        private ImpellerFragmentProgramHandle _handle;
        internal ImpellerFragmentProgramHandle Handle => _handle;
        internal ImpellerFragmentProgram(ImpellerFragmentProgramHandle handle)
        {
            _handle = handle;
        }

        public static global::NImpeller.ImpellerFragmentProgram? New(IImpellerUnmanagedMemory data, System.IntPtr data_release_user_data)
        {
            unsafe
            {
                using var __marshal_data = ImpellerMapping.Marshal(data);
                var ret = UnsafeNativeMethods.ImpellerFragmentProgramNew(__marshal_data.Value, data_release_user_data);
                if(ret == null) return null;
                return new ImpellerFragmentProgram(ret);
            }

        }

        public void Dispose() => Handle?.Dispose();
    }

}

