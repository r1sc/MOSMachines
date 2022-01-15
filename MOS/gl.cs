using System.Runtime.InteropServices;
using System.Text;

#nullable disable
#pragma warning disable CS0618 // Type or member is obsolete
namespace MOS.OpenGL
{
    public class GL
    {
        [DllImport("opengl32.dll")]
        public static extern IntPtr wglGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string proc);
        public enum AlphaFunction : uint
        {
            GL_ALWAYS = 0x0207,
            GL_EQUAL = 0x0202,
            GL_GEQUAL = 0x0206,
            GL_GREATER = 0x0204,
            GL_LEQUAL = 0x0203,
            GL_LESS = 0x0201,
            GL_NEVER = 0x0200,
            GL_NOTEQUAL = 0x0205
        }
        public enum AttribMask : uint
        {
            GL_ACCUM_BUFFER_BIT = 0x00000200,
            GL_ALL_ATTRIB_BITS = 0xFFFFFFFF,
            GL_COLOR_BUFFER_BIT = 0x00004000,
            GL_CURRENT_BIT = 0x00000001,
            GL_DEPTH_BUFFER_BIT = 0x00000100,
            GL_ENABLE_BIT = 0x00002000,
            GL_EVAL_BIT = 0x00010000,
            GL_FOG_BIT = 0x00000080,
            GL_HINT_BIT = 0x00008000,
            GL_LIGHTING_BIT = 0x00000040,
            GL_LINE_BIT = 0x00000004,
            GL_LIST_BIT = 0x00020000,
            GL_MULTISAMPLE_BIT = 0x20000000,
            GL_MULTISAMPLE_BIT_3DFX = 0x20000000,
            GL_MULTISAMPLE_BIT_ARB = 0x20000000,
            GL_MULTISAMPLE_BIT_EXT = 0x20000000,
            GL_PIXEL_MODE_BIT = 0x00000020,
            GL_POINT_BIT = 0x00000002,
            GL_POLYGON_BIT = 0x00000008,
            GL_POLYGON_STIPPLE_BIT = 0x00000010,
            GL_SCISSOR_BIT = 0x00080000,
            GL_STENCIL_BUFFER_BIT = 0x00000400,
            GL_TEXTURE_BIT = 0x00040000,
            GL_TRANSFORM_BIT = 0x00001000,
            GL_VIEWPORT_BIT = 0x00000800
        }
        public enum AttributeType : uint
        {
            GL_FLOAT = 0x1406,
            GL_FLOAT_VEC2 = 0x8B50,
            GL_FLOAT_VEC2_ARB = 0x8B50,
            GL_FLOAT_VEC3 = 0x8B51,
            GL_FLOAT_VEC3_ARB = 0x8B51,
            GL_FLOAT_VEC4 = 0x8B52,
            GL_FLOAT_VEC4_ARB = 0x8B52,
            GL_DOUBLE = 0x140A,
            GL_DOUBLE_VEC2 = 0x8FFC,
            GL_DOUBLE_VEC3 = 0x8FFD,
            GL_DOUBLE_VEC4 = 0x8FFE,
            GL_INT = 0x1404,
            GL_INT_VEC2 = 0x8B53,
            GL_INT_VEC2_ARB = 0x8B53,
            GL_INT_VEC3 = 0x8B54,
            GL_INT_VEC3_ARB = 0x8B54,
            GL_INT_VEC4 = 0x8B55,
            GL_INT_VEC4_ARB = 0x8B55,
            GL_UNSIGNED_INT = 0x1405,
            GL_UNSIGNED_INT_VEC2 = 0x8DC6,
            GL_UNSIGNED_INT_VEC3 = 0x8DC7,
            GL_UNSIGNED_INT_VEC4 = 0x8DC8,
            GL_BOOL = 0x8B56,
            GL_BOOL_ARB = 0x8B56,
            GL_BOOL_VEC2 = 0x8B57,
            GL_BOOL_VEC2_ARB = 0x8B57,
            GL_BOOL_VEC3 = 0x8B58,
            GL_BOOL_VEC3_ARB = 0x8B58,
            GL_BOOL_VEC4 = 0x8B59,
            GL_BOOL_VEC4_ARB = 0x8B59,
            GL_FLOAT_MAT2 = 0x8B5A,
            GL_FLOAT_MAT2_ARB = 0x8B5A,
            GL_FLOAT_MAT3 = 0x8B5B,
            GL_FLOAT_MAT3_ARB = 0x8B5B,
            GL_FLOAT_MAT4 = 0x8B5C,
            GL_FLOAT_MAT4_ARB = 0x8B5C,
            GL_FLOAT_MAT2x3 = 0x8B65,
            GL_FLOAT_MAT2x3_NV = 0x8B65,
            GL_FLOAT_MAT2x4 = 0x8B66,
            GL_FLOAT_MAT2x4_NV = 0x8B66,
            GL_FLOAT_MAT3x2 = 0x8B67,
            GL_FLOAT_MAT3x2_NV = 0x8B67,
            GL_FLOAT_MAT3x4 = 0x8B68,
            GL_FLOAT_MAT3x4_NV = 0x8B68,
            GL_FLOAT_MAT4x2 = 0x8B69,
            GL_FLOAT_MAT4x2_NV = 0x8B69,
            GL_FLOAT_MAT4x3 = 0x8B6A,
            GL_FLOAT_MAT4x3_NV = 0x8B6A,
            GL_DOUBLE_MAT2 = 0x8F46,
            GL_DOUBLE_MAT3 = 0x8F47,
            GL_DOUBLE_MAT4 = 0x8F48,
            GL_DOUBLE_MAT2x3 = 0x8F49,
            GL_DOUBLE_MAT2x4 = 0x8F4A,
            GL_DOUBLE_MAT3x2 = 0x8F4B,
            GL_DOUBLE_MAT3x4 = 0x8F4C,
            GL_DOUBLE_MAT4x2 = 0x8F4D,
            GL_DOUBLE_MAT4x3 = 0x8F4E,
            GL_SAMPLER_1D = 0x8B5D,
            GL_SAMPLER_1D_ARB = 0x8B5D,
            GL_SAMPLER_2D = 0x8B5E,
            GL_SAMPLER_2D_ARB = 0x8B5E,
            GL_SAMPLER_3D = 0x8B5F,
            GL_SAMPLER_3D_ARB = 0x8B5F,
            GL_SAMPLER_3D_OES = 0x8B5F,
            GL_SAMPLER_CUBE = 0x8B60,
            GL_SAMPLER_CUBE_ARB = 0x8B60,
            GL_SAMPLER_1D_SHADOW = 0x8B61,
            GL_SAMPLER_1D_SHADOW_ARB = 0x8B61,
            GL_SAMPLER_2D_SHADOW = 0x8B62,
            GL_SAMPLER_2D_SHADOW_ARB = 0x8B62,
            GL_SAMPLER_2D_SHADOW_EXT = 0x8B62,
            GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C,
            GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3,
            GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4,
            GL_SAMPLER_2D_MULTISAMPLE = 0x9108,
            GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B,
            GL_SAMPLER_CUBE_SHADOW = 0x8DC5,
            GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D,
            GL_SAMPLER_BUFFER = 0x8DC2,
            GL_SAMPLER_2D_RECT = 0x8B63,
            GL_SAMPLER_2D_RECT_ARB = 0x8B63,
            GL_SAMPLER_2D_RECT_SHADOW = 0x8B64,
            GL_SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64,
            GL_INT_SAMPLER_1D = 0x8DC9,
            GL_INT_SAMPLER_2D = 0x8DCA,
            GL_INT_SAMPLER_3D = 0x8DCB,
            GL_INT_SAMPLER_CUBE = 0x8DCC,
            GL_INT_SAMPLER_1D_ARRAY = 0x8DCE,
            GL_INT_SAMPLER_2D_ARRAY = 0x8DCF,
            GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E,
            GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109,
            GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C,
            GL_INT_SAMPLER_BUFFER = 0x8DD0,
            GL_INT_SAMPLER_2D_RECT = 0x8DCD,
            GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1,
            GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2,
            GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3,
            GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4,
            GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6,
            GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7,
            GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F,
            GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A,
            GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D,
            GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8,
            GL_UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5,
            GL_IMAGE_1D = 0x904C,
            GL_IMAGE_2D = 0x904D,
            GL_IMAGE_3D = 0x904E,
            GL_IMAGE_2D_RECT = 0x904F,
            GL_IMAGE_CUBE = 0x9050,
            GL_IMAGE_BUFFER = 0x9051,
            GL_IMAGE_1D_ARRAY = 0x9052,
            GL_IMAGE_2D_ARRAY = 0x9053,
            GL_IMAGE_CUBE_MAP_ARRAY = 0x9054,
            GL_IMAGE_2D_MULTISAMPLE = 0x9055,
            GL_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056,
            GL_INT_IMAGE_1D = 0x9057,
            GL_INT_IMAGE_2D = 0x9058,
            GL_INT_IMAGE_3D = 0x9059,
            GL_INT_IMAGE_2D_RECT = 0x905A,
            GL_INT_IMAGE_CUBE = 0x905B,
            GL_INT_IMAGE_BUFFER = 0x905C,
            GL_INT_IMAGE_1D_ARRAY = 0x905D,
            GL_INT_IMAGE_2D_ARRAY = 0x905E,
            GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F,
            GL_INT_IMAGE_2D_MULTISAMPLE = 0x9060,
            GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061,
            GL_UNSIGNED_INT_IMAGE_1D = 0x9062,
            GL_UNSIGNED_INT_IMAGE_2D = 0x9063,
            GL_UNSIGNED_INT_IMAGE_3D = 0x9064,
            GL_UNSIGNED_INT_IMAGE_2D_RECT = 0x9065,
            GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066,
            GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067,
            GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068,
            GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069,
            GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A,
            GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B,
            GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C,
            GL_INT64_ARB = 0x140E,
            GL_INT64_NV = 0x140E,
            GL_INT64_VEC2_ARB = 0x8FE9,
            GL_INT64_VEC3_ARB = 0x8FEA,
            GL_INT64_VEC4_ARB = 0x8FEB,
            GL_UNSIGNED_INT64_ARB = 0x140F,
            GL_UNSIGNED_INT64_NV = 0x140F,
            GL_UNSIGNED_INT64_VEC2_ARB = 0x8FF5,
            GL_UNSIGNED_INT64_VEC3_ARB = 0x8FF6,
            GL_UNSIGNED_INT64_VEC4_ARB = 0x8FF7
        }
        public enum BinormalPointerTypeEXT : uint
        {
            GL_BYTE = 0x1400,
            GL_SHORT = 0x1402,
            GL_INT = 0x1404,
            GL_FLOAT = 0x1406,
            GL_DOUBLE = 0x140A,
            GL_DOUBLE_EXT = 0x140A
        }
        public enum BlendEquationModeEXT : uint
        {
            GL_ALPHA_MAX_SGIX = 0x8321,
            GL_ALPHA_MIN_SGIX = 0x8320,
            GL_FUNC_ADD = 0x8006,
            GL_FUNC_ADD_EXT = 0x8006,
            GL_FUNC_REVERSE_SUBTRACT = 0x800B,
            GL_FUNC_REVERSE_SUBTRACT_EXT = 0x800B,
            GL_FUNC_SUBTRACT = 0x800A,
            GL_FUNC_SUBTRACT_EXT = 0x800A,
            GL_MAX = 0x8008,
            GL_MAX_EXT = 0x8008,
            GL_MIN = 0x8007,
            GL_MIN_EXT = 0x8007
        }
        public enum BlendingFactor : uint
        {
            GL_ZERO = 0,
            GL_ONE = 1,
            GL_SRC_COLOR = 0x0300,
            GL_ONE_MINUS_SRC_COLOR = 0x0301,
            GL_DST_COLOR = 0x0306,
            GL_ONE_MINUS_DST_COLOR = 0x0307,
            GL_SRC_ALPHA = 0x0302,
            GL_ONE_MINUS_SRC_ALPHA = 0x0303,
            GL_DST_ALPHA = 0x0304,
            GL_ONE_MINUS_DST_ALPHA = 0x0305,
            GL_CONSTANT_COLOR = 0x8001,
            GL_ONE_MINUS_CONSTANT_COLOR = 0x8002,
            GL_CONSTANT_ALPHA = 0x8003,
            GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004,
            GL_SRC_ALPHA_SATURATE = 0x0308,
            GL_SRC1_COLOR = 0x88F9,
            GL_ONE_MINUS_SRC1_COLOR = 0x88FA,
            GL_SRC1_ALPHA = 0x8589,
            GL_ONE_MINUS_SRC1_ALPHA = 0x88FB
        }
        public enum BlitFramebufferFilter : uint
        {
            GL_NEAREST = 0x2600,
            GL_LINEAR = 0x2601
        }
        public enum Boolean : uint
        {
            GL_FALSE = 0,
            GL_TRUE = 1
        }
        public enum Buffer : uint
        {
            GL_COLOR = 0x1800,
            GL_DEPTH = 0x1801,
            GL_STENCIL = 0x1802
        }
        public enum BufferAccessARB : uint
        {
            GL_READ_ONLY = 0x88B8,
            GL_WRITE_ONLY = 0x88B9,
            GL_READ_WRITE = 0x88BA
        }
        public enum BufferPNameARB : uint
        {
            GL_BUFFER_SIZE_ARB = 0x8764,
            GL_BUFFER_USAGE_ARB = 0x8765,
            GL_BUFFER_ACCESS_ARB = 0x88BB,
            GL_BUFFER_MAPPED_ARB = 0x88BC,
            GL_BUFFER_SIZE = 0x8764,
            GL_BUFFER_USAGE = 0x8765,
            GL_BUFFER_ACCESS = 0x88BB,
            GL_BUFFER_ACCESS_FLAGS = 0x911F,
            GL_BUFFER_IMMUTABLE_STORAGE = 0x821F,
            GL_BUFFER_MAPPED = 0x88BC,
            GL_BUFFER_MAP_OFFSET = 0x9121,
            GL_BUFFER_MAP_LENGTH = 0x9120,
            GL_BUFFER_STORAGE_FLAGS = 0x8220
        }
        public enum BufferPointerNameARB : uint
        {
            GL_BUFFER_MAP_POINTER_ARB = 0x88BD,
            GL_BUFFER_MAP_POINTER = 0x88BD
        }
        public enum BufferStorageMask : uint
        {
            GL_CLIENT_STORAGE_BIT = 0x0200,
            GL_CLIENT_STORAGE_BIT_EXT = 0x0200,
            GL_DYNAMIC_STORAGE_BIT = 0x0100,
            GL_DYNAMIC_STORAGE_BIT_EXT = 0x0100,
            GL_MAP_COHERENT_BIT = 0x0080,
            GL_MAP_COHERENT_BIT_EXT = 0x0080,
            GL_MAP_PERSISTENT_BIT = 0x0040,
            GL_MAP_PERSISTENT_BIT_EXT = 0x0040,
            GL_MAP_READ_BIT = 0x0001,
            GL_MAP_READ_BIT_EXT = 0x0001,
            GL_MAP_WRITE_BIT = 0x0002,
            GL_MAP_WRITE_BIT_EXT = 0x0002,
            GL_SPARSE_STORAGE_BIT_ARB = 0x0400,
            GL_LGPU_SEPARATE_STORAGE_BIT_NVX = 0x0800,
            GL_PER_GPU_STORAGE_BIT_NV = 0x0800,
            GL_EXTERNAL_STORAGE_BIT_NVX = 0x2000
        }
        public enum BufferStorageTarget : uint
        {
            GL_ARRAY_BUFFER = 0x8892,
            GL_ATOMIC_COUNTER_BUFFER = 0x92C0,
            GL_COPY_READ_BUFFER = 0x8F36,
            GL_COPY_WRITE_BUFFER = 0x8F37,
            GL_DISPATCH_INDIRECT_BUFFER = 0x90EE,
            GL_DRAW_INDIRECT_BUFFER = 0x8F3F,
            GL_ELEMENT_ARRAY_BUFFER = 0x8893,
            GL_PIXEL_PACK_BUFFER = 0x88EB,
            GL_PIXEL_UNPACK_BUFFER = 0x88EC,
            GL_QUERY_BUFFER = 0x9192,
            GL_SHADER_STORAGE_BUFFER = 0x90D2,
            GL_TEXTURE_BUFFER = 0x8C2A,
            GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E,
            GL_UNIFORM_BUFFER = 0x8A11
        }
        public enum BufferTargetARB : uint
        {
            GL_ARRAY_BUFFER = 0x8892,
            GL_ATOMIC_COUNTER_BUFFER = 0x92C0,
            GL_COPY_READ_BUFFER = 0x8F36,
            GL_COPY_WRITE_BUFFER = 0x8F37,
            GL_DISPATCH_INDIRECT_BUFFER = 0x90EE,
            GL_DRAW_INDIRECT_BUFFER = 0x8F3F,
            GL_ELEMENT_ARRAY_BUFFER = 0x8893,
            GL_PIXEL_PACK_BUFFER = 0x88EB,
            GL_PIXEL_UNPACK_BUFFER = 0x88EC,
            GL_QUERY_BUFFER = 0x9192,
            GL_SHADER_STORAGE_BUFFER = 0x90D2,
            GL_TEXTURE_BUFFER = 0x8C2A,
            GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E,
            GL_UNIFORM_BUFFER = 0x8A11,
            GL_PARAMETER_BUFFER = 0x80EE
        }
        public enum BufferUsageARB : uint
        {
            GL_STREAM_DRAW = 0x88E0,
            GL_STREAM_READ = 0x88E1,
            GL_STREAM_COPY = 0x88E2,
            GL_STATIC_DRAW = 0x88E4,
            GL_STATIC_READ = 0x88E5,
            GL_STATIC_COPY = 0x88E6,
            GL_DYNAMIC_DRAW = 0x88E8,
            GL_DYNAMIC_READ = 0x88E9,
            GL_DYNAMIC_COPY = 0x88EA
        }
        public enum CheckFramebufferStatusTarget : uint
        {
            GL_DRAW_FRAMEBUFFER = 0x8CA9,
            GL_READ_FRAMEBUFFER = 0x8CA8,
            GL_FRAMEBUFFER = 0x8D40
        }
        public enum ClampColorModeARB : uint
        {
            GL_FIXED_ONLY_ARB = 0x891D,
            GL_FALSE = 0,
            GL_TRUE = 1,
            GL_FIXED_ONLY = 0x891D
        }
        public enum ClampColorTargetARB : uint
        {
            GL_CLAMP_VERTEX_COLOR_ARB = 0x891A,
            GL_CLAMP_FRAGMENT_COLOR_ARB = 0x891B,
            GL_CLAMP_READ_COLOR_ARB = 0x891C,
            GL_CLAMP_READ_COLOR = 0x891C
        }
        public enum ClearBufferMask : uint
        {
            GL_ACCUM_BUFFER_BIT = 0x00000200,
            GL_COLOR_BUFFER_BIT = 0x00004000,
            GL_COVERAGE_BUFFER_BIT_NV = 0x00008000,
            GL_DEPTH_BUFFER_BIT = 0x00000100,
            GL_STENCIL_BUFFER_BIT = 0x00000400
        }
        public enum ClipControlOrigin : uint
        {
            GL_LOWER_LEFT = 0x8CA1,
            GL_UPPER_LEFT = 0x8CA2
        }
        public enum ClipPlaneName : uint
        {
            GL_CLIP_DISTANCE0 = 0x3000,
            GL_CLIP_DISTANCE1 = 0x3001,
            GL_CLIP_DISTANCE2 = 0x3002,
            GL_CLIP_DISTANCE3 = 0x3003,
            GL_CLIP_DISTANCE4 = 0x3004,
            GL_CLIP_DISTANCE5 = 0x3005,
            GL_CLIP_DISTANCE6 = 0x3006,
            GL_CLIP_DISTANCE7 = 0x3007,
            GL_CLIP_PLANE0 = 0x3000,
            GL_CLIP_PLANE1 = 0x3001,
            GL_CLIP_PLANE2 = 0x3002,
            GL_CLIP_PLANE3 = 0x3003,
            GL_CLIP_PLANE4 = 0x3004,
            GL_CLIP_PLANE5 = 0x3005
        }
        public enum ColorBuffer : uint
        {
            GL_NONE = 0,
            GL_FRONT_LEFT = 0x0400,
            GL_FRONT_RIGHT = 0x0401,
            GL_BACK_LEFT = 0x0402,
            GL_BACK_RIGHT = 0x0403,
            GL_FRONT = 0x0404,
            GL_BACK = 0x0405,
            GL_LEFT = 0x0406,
            GL_RIGHT = 0x0407,
            GL_FRONT_AND_BACK = 0x0408,
            GL_COLOR_ATTACHMENT0 = 0x8CE0,
            GL_COLOR_ATTACHMENT1 = 0x8CE1,
            GL_COLOR_ATTACHMENT2 = 0x8CE2,
            GL_COLOR_ATTACHMENT3 = 0x8CE3,
            GL_COLOR_ATTACHMENT4 = 0x8CE4,
            GL_COLOR_ATTACHMENT5 = 0x8CE5,
            GL_COLOR_ATTACHMENT6 = 0x8CE6,
            GL_COLOR_ATTACHMENT7 = 0x8CE7,
            GL_COLOR_ATTACHMENT8 = 0x8CE8,
            GL_COLOR_ATTACHMENT9 = 0x8CE9,
            GL_COLOR_ATTACHMENT10 = 0x8CEA,
            GL_COLOR_ATTACHMENT11 = 0x8CEB,
            GL_COLOR_ATTACHMENT12 = 0x8CEC,
            GL_COLOR_ATTACHMENT13 = 0x8CED,
            GL_COLOR_ATTACHMENT14 = 0x8CEE,
            GL_COLOR_ATTACHMENT15 = 0x8CEF,
            GL_COLOR_ATTACHMENT16 = 0x8CF0,
            GL_COLOR_ATTACHMENT17 = 0x8CF1,
            GL_COLOR_ATTACHMENT18 = 0x8CF2,
            GL_COLOR_ATTACHMENT19 = 0x8CF3,
            GL_COLOR_ATTACHMENT20 = 0x8CF4,
            GL_COLOR_ATTACHMENT21 = 0x8CF5,
            GL_COLOR_ATTACHMENT22 = 0x8CF6,
            GL_COLOR_ATTACHMENT23 = 0x8CF7,
            GL_COLOR_ATTACHMENT24 = 0x8CF8,
            GL_COLOR_ATTACHMENT25 = 0x8CF9,
            GL_COLOR_ATTACHMENT26 = 0x8CFA,
            GL_COLOR_ATTACHMENT27 = 0x8CFB,
            GL_COLOR_ATTACHMENT28 = 0x8CFC,
            GL_COLOR_ATTACHMENT29 = 0x8CFD,
            GL_COLOR_ATTACHMENT30 = 0x8CFE,
            GL_COLOR_ATTACHMENT31 = 0x8CFF
        }
        public enum ColorMaterialFace : uint
        {
            GL_BACK = 0x0405,
            GL_FRONT = 0x0404,
            GL_FRONT_AND_BACK = 0x0408
        }
        public enum ColorPointerType : uint
        {
            GL_BYTE = 0x1400,
            GL_DOUBLE = 0x140A,
            GL_FLOAT = 0x1406,
            GL_INT = 0x1404,
            GL_SHORT = 0x1402,
            GL_UNSIGNED_BYTE = 0x1401,
            GL_UNSIGNED_INT = 0x1405,
            GL_UNSIGNED_SHORT = 0x1403
        }
        public enum CombinerBiasNV : uint
        {
            GL_NONE = 0,
            GL_BIAS_BY_NEGATIVE_ONE_HALF_NV = 0x8541
        }
        public enum CombinerComponentUsageNV : uint
        {
            GL_RGB = 0x1907,
            GL_ALPHA = 0x1906,
            GL_BLUE = 0x1905
        }
        public enum CombinerPortionNV : uint
        {
            GL_RGB = 0x1907,
            GL_ALPHA = 0x1906
        }
        public enum CombinerScaleNV : uint
        {
            GL_NONE = 0,
            GL_SCALE_BY_TWO_NV = 0x853E,
            GL_SCALE_BY_FOUR_NV = 0x853F,
            GL_SCALE_BY_ONE_HALF_NV = 0x8540
        }
        public enum ConditionalRenderMode : uint
        {
            GL_QUERY_WAIT = 0x8E13,
            GL_QUERY_NO_WAIT = 0x8E14,
            GL_QUERY_BY_REGION_WAIT = 0x8E15,
            GL_QUERY_BY_REGION_NO_WAIT = 0x8E16,
            GL_QUERY_WAIT_INVERTED = 0x8E17,
            GL_QUERY_NO_WAIT_INVERTED = 0x8E18,
            GL_QUERY_BY_REGION_WAIT_INVERTED = 0x8E19,
            GL_QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A
        }
        public enum ContextFlagMask : uint
        {
            GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002,
            GL_CONTEXT_FLAG_DEBUG_BIT_KHR = 0x00000002,
            GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001,
            GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004,
            GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x00000004,
            GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT = 0x00000010,
            GL_CONTEXT_FLAG_NO_ERROR_BIT = 0x00000008,
            GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR = 0x00000008
        }
        public enum ContextProfileMask : uint
        {
            GL_CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002,
            GL_CONTEXT_CORE_PROFILE_BIT = 0x00000001
        }
        public enum CopyBufferSubDataTarget : uint
        {
            GL_ARRAY_BUFFER = 0x8892,
            GL_ATOMIC_COUNTER_BUFFER = 0x92C0,
            GL_COPY_READ_BUFFER = 0x8F36,
            GL_COPY_WRITE_BUFFER = 0x8F37,
            GL_DISPATCH_INDIRECT_BUFFER = 0x90EE,
            GL_DRAW_INDIRECT_BUFFER = 0x8F3F,
            GL_ELEMENT_ARRAY_BUFFER = 0x8893,
            GL_PIXEL_PACK_BUFFER = 0x88EB,
            GL_PIXEL_UNPACK_BUFFER = 0x88EC,
            GL_QUERY_BUFFER = 0x9192,
            GL_SHADER_STORAGE_BUFFER = 0x90D2,
            GL_TEXTURE_BUFFER = 0x8C2A,
            GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E,
            GL_UNIFORM_BUFFER = 0x8A11
        }
        public enum CopyImageSubDataTarget : uint
        {
            GL_RENDERBUFFER = 0x8D41,
            GL_TEXTURE_1D = 0x0DE0,
            GL_TEXTURE_2D = 0x0DE1,
            GL_TEXTURE_3D = 0x806F,
            GL_TEXTURE_RECTANGLE = 0x84F5,
            GL_TEXTURE_CUBE_MAP = 0x8513,
            GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009,
            GL_TEXTURE_1D_ARRAY = 0x8C18,
            GL_TEXTURE_2D_ARRAY = 0x8C1A,
            GL_TEXTURE_2D_MULTISAMPLE = 0x9100,
            GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102
        }
        public enum CullFaceMode : uint
        {
            GL_BACK = 0x0405,
            GL_FRONT = 0x0404,
            GL_FRONT_AND_BACK = 0x0408
        }
        public enum DebugSeverity : uint
        {
            GL_DEBUG_SEVERITY_LOW = 0x9148,
            GL_DEBUG_SEVERITY_MEDIUM = 0x9147,
            GL_DEBUG_SEVERITY_HIGH = 0x9146,
            GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B,
            GL_DONT_CARE = 0x1100
        }
        public enum DebugSource : uint
        {
            GL_DEBUG_SOURCE_API = 0x8246,
            GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247,
            GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248,
            GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249,
            GL_DEBUG_SOURCE_APPLICATION = 0x824A,
            GL_DEBUG_SOURCE_OTHER = 0x824B,
            GL_DONT_CARE = 0x1100
        }
        public enum DebugType : uint
        {
            GL_DEBUG_TYPE_ERROR = 0x824C,
            GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D,
            GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E,
            GL_DEBUG_TYPE_PORTABILITY = 0x824F,
            GL_DEBUG_TYPE_PERFORMANCE = 0x8250,
            GL_DEBUG_TYPE_MARKER = 0x8268,
            GL_DEBUG_TYPE_PUSH_GROUP = 0x8269,
            GL_DEBUG_TYPE_POP_GROUP = 0x826A,
            GL_DEBUG_TYPE_OTHER = 0x8251,
            GL_DONT_CARE = 0x1100
        }
        public enum DepthFunction : uint
        {
            GL_ALWAYS = 0x0207,
            GL_EQUAL = 0x0202,
            GL_GEQUAL = 0x0206,
            GL_GREATER = 0x0204,
            GL_LEQUAL = 0x0203,
            GL_LESS = 0x0201,
            GL_NEVER = 0x0200,
            GL_NOTEQUAL = 0x0205
        }
        public enum DrawBufferMode : uint
        {
            GL_AUX0 = 0x0409,
            GL_AUX1 = 0x040A,
            GL_AUX2 = 0x040B,
            GL_AUX3 = 0x040C,
            GL_BACK = 0x0405,
            GL_BACK_LEFT = 0x0402,
            GL_BACK_RIGHT = 0x0403,
            GL_FRONT = 0x0404,
            GL_FRONT_AND_BACK = 0x0408,
            GL_FRONT_LEFT = 0x0400,
            GL_FRONT_RIGHT = 0x0401,
            GL_LEFT = 0x0406,
            GL_NONE = 0,
            GL_NONE_OES = 0,
            GL_RIGHT = 0x0407,
            GL_COLOR_ATTACHMENT0 = 0x8CE0,
            GL_COLOR_ATTACHMENT1 = 0x8CE1,
            GL_COLOR_ATTACHMENT2 = 0x8CE2,
            GL_COLOR_ATTACHMENT3 = 0x8CE3,
            GL_COLOR_ATTACHMENT4 = 0x8CE4,
            GL_COLOR_ATTACHMENT5 = 0x8CE5,
            GL_COLOR_ATTACHMENT6 = 0x8CE6,
            GL_COLOR_ATTACHMENT7 = 0x8CE7,
            GL_COLOR_ATTACHMENT8 = 0x8CE8,
            GL_COLOR_ATTACHMENT9 = 0x8CE9,
            GL_COLOR_ATTACHMENT10 = 0x8CEA,
            GL_COLOR_ATTACHMENT11 = 0x8CEB,
            GL_COLOR_ATTACHMENT12 = 0x8CEC,
            GL_COLOR_ATTACHMENT13 = 0x8CED,
            GL_COLOR_ATTACHMENT14 = 0x8CEE,
            GL_COLOR_ATTACHMENT15 = 0x8CEF,
            GL_COLOR_ATTACHMENT16 = 0x8CF0,
            GL_COLOR_ATTACHMENT17 = 0x8CF1,
            GL_COLOR_ATTACHMENT18 = 0x8CF2,
            GL_COLOR_ATTACHMENT19 = 0x8CF3,
            GL_COLOR_ATTACHMENT20 = 0x8CF4,
            GL_COLOR_ATTACHMENT21 = 0x8CF5,
            GL_COLOR_ATTACHMENT22 = 0x8CF6,
            GL_COLOR_ATTACHMENT23 = 0x8CF7,
            GL_COLOR_ATTACHMENT24 = 0x8CF8,
            GL_COLOR_ATTACHMENT25 = 0x8CF9,
            GL_COLOR_ATTACHMENT26 = 0x8CFA,
            GL_COLOR_ATTACHMENT27 = 0x8CFB,
            GL_COLOR_ATTACHMENT28 = 0x8CFC,
            GL_COLOR_ATTACHMENT29 = 0x8CFD,
            GL_COLOR_ATTACHMENT30 = 0x8CFE,
            GL_COLOR_ATTACHMENT31 = 0x8CFF
        }
        public enum DrawElementsType : uint
        {
            GL_UNSIGNED_BYTE = 0x1401,
            GL_UNSIGNED_SHORT = 0x1403,
            GL_UNSIGNED_INT = 0x1405
        }
        public enum ElementPointerTypeATI : uint
        {
            GL_UNSIGNED_BYTE = 0x1401,
            GL_UNSIGNED_SHORT = 0x1403,
            GL_UNSIGNED_INT = 0x1405
        }
        public enum EnableCap : uint
        {
            GL_ALPHA_TEST = 0x0BC0,
            GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D,
            GL_ASYNC_HISTOGRAM_SGIX = 0x832C,
            GL_ASYNC_READ_PIXELS_SGIX = 0x835E,
            GL_ASYNC_TEX_IMAGE_SGIX = 0x835C,
            GL_AUTO_NORMAL = 0x0D80,
            GL_BLEND = 0x0BE2,
            GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183,
            GL_CLIP_DISTANCE0 = 0x3000,
            GL_CLIP_DISTANCE1 = 0x3001,
            GL_CLIP_DISTANCE2 = 0x3002,
            GL_CLIP_DISTANCE3 = 0x3003,
            GL_CLIP_DISTANCE4 = 0x3004,
            GL_CLIP_DISTANCE5 = 0x3005,
            GL_CLIP_DISTANCE6 = 0x3006,
            GL_CLIP_DISTANCE7 = 0x3007,
            GL_CLIP_PLANE0 = 0x3000,
            GL_CLIP_PLANE1 = 0x3001,
            GL_CLIP_PLANE2 = 0x3002,
            GL_CLIP_PLANE3 = 0x3003,
            GL_CLIP_PLANE4 = 0x3004,
            GL_CLIP_PLANE5 = 0x3005,
            GL_COLOR_ARRAY = 0x8076,
            GL_COLOR_LOGIC_OP = 0x0BF2,
            GL_COLOR_MATERIAL = 0x0B57,
            GL_COLOR_TABLE_SGI = 0x80D0,
            GL_CONVOLUTION_1D_EXT = 0x8010,
            GL_CONVOLUTION_2D_EXT = 0x8011,
            GL_CULL_FACE = 0x0B44,
            GL_DEBUG_OUTPUT = 0x92E0,
            GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242,
            GL_DEPTH_CLAMP = 0x864F,
            GL_DEPTH_TEST = 0x0B71,
            GL_DITHER = 0x0BD0,
            GL_EDGE_FLAG_ARRAY = 0x8079,
            GL_FOG = 0x0B60,
            GL_FOG_OFFSET_SGIX = 0x8198,
            GL_FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401,
            GL_FRAGMENT_LIGHT0_SGIX = 0x840C,
            GL_FRAGMENT_LIGHT1_SGIX = 0x840D,
            GL_FRAGMENT_LIGHT2_SGIX = 0x840E,
            GL_FRAGMENT_LIGHT3_SGIX = 0x840F,
            GL_FRAGMENT_LIGHT4_SGIX = 0x8410,
            GL_FRAGMENT_LIGHT5_SGIX = 0x8411,
            GL_FRAGMENT_LIGHT6_SGIX = 0x8412,
            GL_FRAGMENT_LIGHT7_SGIX = 0x8413,
            GL_FRAGMENT_LIGHTING_SGIX = 0x8400,
            GL_FRAMEBUFFER_SRGB = 0x8DB9,
            GL_FRAMEZOOM_SGIX = 0x818B,
            GL_HISTOGRAM_EXT = 0x8024,
            GL_INDEX_ARRAY = 0x8077,
            GL_INDEX_LOGIC_OP = 0x0BF1,
            GL_INTERLACE_SGIX = 0x8094,
            GL_IR_INSTRUMENT1_SGIX = 0x817F,
            GL_LIGHT0 = 0x4000,
            GL_LIGHT1 = 0x4001,
            GL_LIGHT2 = 0x4002,
            GL_LIGHT3 = 0x4003,
            GL_LIGHT4 = 0x4004,
            GL_LIGHT5 = 0x4005,
            GL_LIGHT6 = 0x4006,
            GL_LIGHT7 = 0x4007,
            GL_LIGHTING = 0x0B50,
            GL_LINE_SMOOTH = 0x0B20,
            GL_LINE_STIPPLE = 0x0B24,
            GL_MAP1_COLOR_4 = 0x0D90,
            GL_MAP1_INDEX = 0x0D91,
            GL_MAP1_NORMAL = 0x0D92,
            GL_MAP1_TEXTURE_COORD_1 = 0x0D93,
            GL_MAP1_TEXTURE_COORD_2 = 0x0D94,
            GL_MAP1_TEXTURE_COORD_3 = 0x0D95,
            GL_MAP1_TEXTURE_COORD_4 = 0x0D96,
            GL_MAP1_VERTEX_3 = 0x0D97,
            GL_MAP1_VERTEX_4 = 0x0D98,
            GL_MAP2_COLOR_4 = 0x0DB0,
            GL_MAP2_INDEX = 0x0DB1,
            GL_MAP2_NORMAL = 0x0DB2,
            GL_MAP2_TEXTURE_COORD_1 = 0x0DB3,
            GL_MAP2_TEXTURE_COORD_2 = 0x0DB4,
            GL_MAP2_TEXTURE_COORD_3 = 0x0DB5,
            GL_MAP2_TEXTURE_COORD_4 = 0x0DB6,
            GL_MAP2_VERTEX_3 = 0x0DB7,
            GL_MAP2_VERTEX_4 = 0x0DB8,
            GL_MINMAX_EXT = 0x802E,
            GL_MULTISAMPLE = 0x809D,
            GL_MULTISAMPLE_SGIS = 0x809D,
            GL_NORMALIZE = 0x0BA1,
            GL_NORMAL_ARRAY = 0x8075,
            GL_PIXEL_TEXTURE_SGIS = 0x8353,
            GL_PIXEL_TEX_GEN_SGIX = 0x8139,
            GL_POINT_SMOOTH = 0x0B10,
            GL_POLYGON_OFFSET_FILL = 0x8037,
            GL_POLYGON_OFFSET_LINE = 0x2A02,
            GL_POLYGON_OFFSET_POINT = 0x2A01,
            GL_POLYGON_SMOOTH = 0x0B41,
            GL_POLYGON_STIPPLE = 0x0B42,
            GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2,
            GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1,
            GL_PRIMITIVE_RESTART = 0x8F9D,
            GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69,
            GL_PROGRAM_POINT_SIZE = 0x8642,
            GL_RASTERIZER_DISCARD = 0x8C89,
            GL_REFERENCE_PLANE_SGIX = 0x817D,
            GL_RESCALE_NORMAL_EXT = 0x803A,
            GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E,
            GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E,
            GL_SAMPLE_ALPHA_TO_ONE = 0x809F,
            GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F,
            GL_SAMPLE_COVERAGE = 0x80A0,
            GL_SAMPLE_MASK = 0x8E51,
            GL_SAMPLE_MASK_SGIS = 0x80A0,
            GL_SAMPLE_SHADING = 0x8C36,
            GL_SCISSOR_TEST = 0x0C11,
            GL_SEPARABLE_2D_EXT = 0x8012,
            GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB,
            GL_SPRITE_SGIX = 0x8148,
            GL_STENCIL_TEST = 0x0B90,
            GL_TEXTURE_1D = 0x0DE0,
            GL_TEXTURE_2D = 0x0DE1,
            GL_TEXTURE_3D_EXT = 0x806F,
            GL_TEXTURE_4D_SGIS = 0x8134,
            GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC,
            GL_TEXTURE_COORD_ARRAY = 0x8078,
            GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F,
            GL_TEXTURE_GEN_Q = 0x0C63,
            GL_TEXTURE_GEN_R = 0x0C62,
            GL_TEXTURE_GEN_S = 0x0C60,
            GL_TEXTURE_GEN_T = 0x0C61,
            GL_VERTEX_ARRAY = 0x8074
        }
        public enum ErrorCode : uint
        {
            GL_INVALID_ENUM = 0x0500,
            GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506,
            GL_INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506,
            GL_INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506,
            GL_INVALID_OPERATION = 0x0502,
            GL_INVALID_VALUE = 0x0501,
            GL_NO_ERROR = 0,
            GL_OUT_OF_MEMORY = 0x0505,
            GL_STACK_OVERFLOW = 0x0503,
            GL_STACK_UNDERFLOW = 0x0504,
            GL_TABLE_TOO_LARGE = 0x8031,
            GL_TABLE_TOO_LARGE_EXT = 0x8031,
            GL_TEXTURE_TOO_LARGE_EXT = 0x8065
        }
        public enum FogCoordinatePointerType : uint
        {
            GL_FLOAT = 0x1406,
            GL_DOUBLE = 0x140A
        }
        public enum FogMode : uint
        {
            GL_EXP = 0x0800,
            GL_EXP2 = 0x0801,
            GL_FOG_FUNC_SGIS = 0x812A,
            GL_LINEAR = 0x2601
        }
        public enum FogPointerTypeEXT : uint
        {
            GL_FLOAT = 0x1406,
            GL_DOUBLE = 0x140A
        }
        public enum FogPointerTypeIBM : uint
        {
            GL_FLOAT = 0x1406,
            GL_DOUBLE = 0x140A
        }
        public enum FramebufferAttachment : uint
        {
            GL_COLOR_ATTACHMENT0 = 0x8CE0,
            GL_COLOR_ATTACHMENT0_EXT = 0x8CE0,
            GL_COLOR_ATTACHMENT0_NV = 0x8CE0,
            GL_COLOR_ATTACHMENT0_OES = 0x8CE0,
            GL_COLOR_ATTACHMENT1 = 0x8CE1,
            GL_COLOR_ATTACHMENT1_EXT = 0x8CE1,
            GL_COLOR_ATTACHMENT1_NV = 0x8CE1,
            GL_COLOR_ATTACHMENT2 = 0x8CE2,
            GL_COLOR_ATTACHMENT2_EXT = 0x8CE2,
            GL_COLOR_ATTACHMENT2_NV = 0x8CE2,
            GL_COLOR_ATTACHMENT3 = 0x8CE3,
            GL_COLOR_ATTACHMENT3_EXT = 0x8CE3,
            GL_COLOR_ATTACHMENT3_NV = 0x8CE3,
            GL_COLOR_ATTACHMENT4 = 0x8CE4,
            GL_COLOR_ATTACHMENT4_EXT = 0x8CE4,
            GL_COLOR_ATTACHMENT4_NV = 0x8CE4,
            GL_COLOR_ATTACHMENT5 = 0x8CE5,
            GL_COLOR_ATTACHMENT5_EXT = 0x8CE5,
            GL_COLOR_ATTACHMENT5_NV = 0x8CE5,
            GL_COLOR_ATTACHMENT6 = 0x8CE6,
            GL_COLOR_ATTACHMENT6_EXT = 0x8CE6,
            GL_COLOR_ATTACHMENT6_NV = 0x8CE6,
            GL_COLOR_ATTACHMENT7 = 0x8CE7,
            GL_COLOR_ATTACHMENT7_EXT = 0x8CE7,
            GL_COLOR_ATTACHMENT7_NV = 0x8CE7,
            GL_COLOR_ATTACHMENT8 = 0x8CE8,
            GL_COLOR_ATTACHMENT8_EXT = 0x8CE8,
            GL_COLOR_ATTACHMENT8_NV = 0x8CE8,
            GL_COLOR_ATTACHMENT9 = 0x8CE9,
            GL_COLOR_ATTACHMENT9_EXT = 0x8CE9,
            GL_COLOR_ATTACHMENT9_NV = 0x8CE9,
            GL_COLOR_ATTACHMENT10 = 0x8CEA,
            GL_COLOR_ATTACHMENT10_EXT = 0x8CEA,
            GL_COLOR_ATTACHMENT10_NV = 0x8CEA,
            GL_COLOR_ATTACHMENT11 = 0x8CEB,
            GL_COLOR_ATTACHMENT11_EXT = 0x8CEB,
            GL_COLOR_ATTACHMENT11_NV = 0x8CEB,
            GL_COLOR_ATTACHMENT12 = 0x8CEC,
            GL_COLOR_ATTACHMENT12_EXT = 0x8CEC,
            GL_COLOR_ATTACHMENT12_NV = 0x8CEC,
            GL_COLOR_ATTACHMENT13 = 0x8CED,
            GL_COLOR_ATTACHMENT13_EXT = 0x8CED,
            GL_COLOR_ATTACHMENT13_NV = 0x8CED,
            GL_COLOR_ATTACHMENT14 = 0x8CEE,
            GL_COLOR_ATTACHMENT14_EXT = 0x8CEE,
            GL_COLOR_ATTACHMENT14_NV = 0x8CEE,
            GL_COLOR_ATTACHMENT15 = 0x8CEF,
            GL_COLOR_ATTACHMENT15_EXT = 0x8CEF,
            GL_COLOR_ATTACHMENT15_NV = 0x8CEF,
            GL_COLOR_ATTACHMENT16 = 0x8CF0,
            GL_COLOR_ATTACHMENT17 = 0x8CF1,
            GL_COLOR_ATTACHMENT18 = 0x8CF2,
            GL_COLOR_ATTACHMENT19 = 0x8CF3,
            GL_COLOR_ATTACHMENT20 = 0x8CF4,
            GL_COLOR_ATTACHMENT21 = 0x8CF5,
            GL_COLOR_ATTACHMENT22 = 0x8CF6,
            GL_COLOR_ATTACHMENT23 = 0x8CF7,
            GL_COLOR_ATTACHMENT24 = 0x8CF8,
            GL_COLOR_ATTACHMENT25 = 0x8CF9,
            GL_COLOR_ATTACHMENT26 = 0x8CFA,
            GL_COLOR_ATTACHMENT27 = 0x8CFB,
            GL_COLOR_ATTACHMENT28 = 0x8CFC,
            GL_COLOR_ATTACHMENT29 = 0x8CFD,
            GL_COLOR_ATTACHMENT30 = 0x8CFE,
            GL_COLOR_ATTACHMENT31 = 0x8CFF,
            GL_DEPTH_ATTACHMENT = 0x8D00,
            GL_DEPTH_STENCIL_ATTACHMENT = 0x821A,
            GL_DEPTH_ATTACHMENT_EXT = 0x8D00,
            GL_DEPTH_ATTACHMENT_OES = 0x8D00,
            GL_STENCIL_ATTACHMENT = 0x8D20,
            GL_STENCIL_ATTACHMENT_EXT = 0x8D20,
            GL_STENCIL_ATTACHMENT_OES = 0x8D20
        }
        public enum FramebufferAttachmentParameterName : uint
        {
            GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212,
            GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213,
            GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214,
            GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215,
            GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216,
            GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217,
            GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211,
            GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT = 0x8211,
            GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210,
            GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT = 0x8210,
            GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1,
            GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT = 0x8CD1,
            GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES = 0x8CD1,
            GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0,
            GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT = 0x8CD0,
            GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES = 0x8CD0,
            GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2,
            GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT = 0x8CD2,
            GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES = 0x8CD2,
            GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3,
            GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT = 0x8CD3,
            GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES = 0x8CD3,
            GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT = 0x8CD4,
            GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES = 0x8CD4,
            GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4,
            GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT = 0x8CD4,
            GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR = 0x9630,
            GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR = 0x9632,
            GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT = 0x8D6C,
            GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SCALE_IMG = 0x913F,
            GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7,
            GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB = 0x8DA7,
            GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT = 0x8DA7,
            GL_FRAMEBUFFER_ATTACHMENT_LAYERED_OES = 0x8DA7
        }
        public enum FramebufferStatus : uint
        {
            GL_FRAMEBUFFER_COMPLETE = 0x8CD5,
            GL_FRAMEBUFFER_UNDEFINED = 0x8219,
            GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6,
            GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7,
            GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB,
            GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC,
            GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD,
            GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56,
            GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8
        }
        public enum FramebufferTarget : uint
        {
            GL_FRAMEBUFFER = 0x8D40,
            GL_FRAMEBUFFER_OES = 0x8D40,
            GL_DRAW_FRAMEBUFFER = 0x8CA9,
            GL_READ_FRAMEBUFFER = 0x8CA8
        }
        public enum FrontFaceDirection : uint
        {
            GL_CCW = 0x0901,
            GL_CW = 0x0900
        }
        public enum GetFramebufferParameter : uint
        {
            GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310,
            GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311,
            GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312,
            GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313,
            GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314,
            GL_DOUBLEBUFFER = 0x0C32,
            GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B,
            GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A,
            GL_SAMPLES = 0x80A9,
            GL_SAMPLE_BUFFERS = 0x80A8,
            GL_STEREO = 0x0C33
        }
        public enum GetMultisamplePNameNV : uint
        {
            GL_SAMPLE_POSITION = 0x8E50,
            GL_SAMPLE_LOCATION_ARB = 0x8E50,
            GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB = 0x9341
        }
        public enum GetPName : uint
        {
            GL_ACCUM_ALPHA_BITS = 0x0D5B,
            GL_ACCUM_BLUE_BITS = 0x0D5A,
            GL_ACCUM_CLEAR_VALUE = 0x0B80,
            GL_ACCUM_GREEN_BITS = 0x0D59,
            GL_ACCUM_RED_BITS = 0x0D58,
            GL_ACTIVE_TEXTURE = 0x84E0,
            GL_ALIASED_LINE_WIDTH_RANGE = 0x846E,
            GL_ALIASED_POINT_SIZE_RANGE = 0x846D,
            GL_ALPHA_BIAS = 0x0D1D,
            GL_ALPHA_BITS = 0x0D55,
            GL_ALPHA_SCALE = 0x0D1C,
            GL_ALPHA_TEST = 0x0BC0,
            GL_ALPHA_TEST_FUNC = 0x0BC1,
            GL_ALPHA_TEST_FUNC_QCOM = 0x0BC1,
            GL_ALPHA_TEST_QCOM = 0x0BC0,
            GL_ALPHA_TEST_REF = 0x0BC2,
            GL_ALPHA_TEST_REF_QCOM = 0x0BC2,
            GL_ARRAY_BUFFER_BINDING = 0x8894,
            GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D,
            GL_ASYNC_HISTOGRAM_SGIX = 0x832C,
            GL_ASYNC_MARKER_SGIX = 0x8329,
            GL_ASYNC_READ_PIXELS_SGIX = 0x835E,
            GL_ASYNC_TEX_IMAGE_SGIX = 0x835C,
            GL_ATTRIB_STACK_DEPTH = 0x0BB0,
            GL_AUTO_NORMAL = 0x0D80,
            GL_AUX_BUFFERS = 0x0C00,
            GL_BLEND = 0x0BE2,
            GL_BLEND_COLOR = 0x8005,
            GL_BLEND_COLOR_EXT = 0x8005,
            GL_BLEND_DST = 0x0BE0,
            GL_BLEND_DST_ALPHA = 0x80CA,
            GL_BLEND_DST_RGB = 0x80C8,
            GL_BLEND_EQUATION_ALPHA = 0x883D,
            GL_BLEND_EQUATION_EXT = 0x8009,
            GL_BLEND_EQUATION_RGB = 0x8009,
            GL_BLEND_SRC = 0x0BE1,
            GL_BLEND_SRC_ALPHA = 0x80CB,
            GL_BLEND_SRC_RGB = 0x80C9,
            GL_BLUE_BIAS = 0x0D1B,
            GL_BLUE_BITS = 0x0D54,
            GL_BLUE_SCALE = 0x0D1A,
            GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183,
            GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1,
            GL_CLIP_PLANE0 = 0x3000,
            GL_CLIP_PLANE1 = 0x3001,
            GL_CLIP_PLANE2 = 0x3002,
            GL_CLIP_PLANE3 = 0x3003,
            GL_CLIP_PLANE4 = 0x3004,
            GL_CLIP_PLANE5 = 0x3005,
            GL_COLOR_ARRAY = 0x8076,
            GL_COLOR_ARRAY_COUNT_EXT = 0x8084,
            GL_COLOR_ARRAY_SIZE = 0x8081,
            GL_COLOR_ARRAY_STRIDE = 0x8083,
            GL_COLOR_ARRAY_TYPE = 0x8082,
            GL_COLOR_CLEAR_VALUE = 0x0C22,
            GL_COLOR_LOGIC_OP = 0x0BF2,
            GL_COLOR_MATERIAL = 0x0B57,
            GL_COLOR_MATERIAL_FACE = 0x0B55,
            GL_COLOR_MATERIAL_PARAMETER = 0x0B56,
            GL_COLOR_MATRIX_SGI = 0x80B1,
            GL_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2,
            GL_COLOR_TABLE_SGI = 0x80D0,
            GL_COLOR_WRITEMASK = 0x0C23,
            GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3,
            GL_CONTEXT_FLAGS = 0x821E,
            GL_CONVOLUTION_1D_EXT = 0x8010,
            GL_CONVOLUTION_2D_EXT = 0x8011,
            GL_CONVOLUTION_HINT_SGIX = 0x8316,
            GL_CULL_FACE = 0x0B44,
            GL_CULL_FACE_MODE = 0x0B45,
            GL_CURRENT_COLOR = 0x0B00,
            GL_CURRENT_INDEX = 0x0B01,
            GL_CURRENT_NORMAL = 0x0B02,
            GL_CURRENT_PROGRAM = 0x8B8D,
            GL_CURRENT_RASTER_COLOR = 0x0B04,
            GL_CURRENT_RASTER_DISTANCE = 0x0B09,
            GL_CURRENT_RASTER_INDEX = 0x0B05,
            GL_CURRENT_RASTER_POSITION = 0x0B07,
            GL_CURRENT_RASTER_POSITION_VALID = 0x0B08,
            GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06,
            GL_CURRENT_TEXTURE_COORDS = 0x0B03,
            GL_DEBUG_GROUP_STACK_DEPTH = 0x826D,
            GL_DEFORMATIONS_MASK_SGIX = 0x8196,
            GL_DEPTH_BIAS = 0x0D1F,
            GL_DEPTH_BITS = 0x0D56,
            GL_DEPTH_CLEAR_VALUE = 0x0B73,
            GL_DEPTH_FUNC = 0x0B74,
            GL_DEPTH_RANGE = 0x0B70,
            GL_DEPTH_SCALE = 0x0D1E,
            GL_DEPTH_TEST = 0x0B71,
            GL_DEPTH_WRITEMASK = 0x0B72,
            GL_DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096,
            GL_DEVICE_LUID_EXT = 0x9599,
            GL_DEVICE_NODE_MASK_EXT = 0x959A,
            GL_DEVICE_UUID_EXT = 0x9597,
            GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF,
            GL_DISTANCE_ATTENUATION_SGIS = 0x8129,
            GL_DITHER = 0x0BD0,
            GL_DOUBLEBUFFER = 0x0C32,
            GL_DRAW_BUFFER = 0x0C01,
            GL_DRAW_BUFFER_EXT = 0x0C01,
            GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6,
            GL_DRIVER_UUID_EXT = 0x9598,
            GL_EDGE_FLAG = 0x0B43,
            GL_EDGE_FLAG_ARRAY = 0x8079,
            GL_EDGE_FLAG_ARRAY_COUNT_EXT = 0x808D,
            GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C,
            GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895,
            GL_FEEDBACK_BUFFER_SIZE = 0x0DF1,
            GL_FEEDBACK_BUFFER_TYPE = 0x0DF2,
            GL_FOG = 0x0B60,
            GL_FOG_COLOR = 0x0B66,
            GL_FOG_DENSITY = 0x0B62,
            GL_FOG_END = 0x0B64,
            GL_FOG_FUNC_POINTS_SGIS = 0x812B,
            GL_FOG_HINT = 0x0C54,
            GL_FOG_INDEX = 0x0B61,
            GL_FOG_MODE = 0x0B65,
            GL_FOG_OFFSET_SGIX = 0x8198,
            GL_FOG_OFFSET_VALUE_SGIX = 0x8199,
            GL_FOG_START = 0x0B63,
            GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX = 0x8402,
            GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = 0x8403,
            GL_FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401,
            GL_FRAGMENT_LIGHT0_SGIX = 0x840C,
            GL_FRAGMENT_LIGHTING_SGIX = 0x8400,
            GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A,
            GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408,
            GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B,
            GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409,
            GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B,
            GL_FRAMEZOOM_FACTOR_SGIX = 0x818C,
            GL_FRAMEZOOM_SGIX = 0x818B,
            GL_FRONT_FACE = 0x0B46,
            GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192,
            GL_GREEN_BIAS = 0x0D19,
            GL_GREEN_BITS = 0x0D53,
            GL_GREEN_SCALE = 0x0D18,
            GL_HISTOGRAM_EXT = 0x8024,
            GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B,
            GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A,
            GL_INDEX_ARRAY = 0x8077,
            GL_INDEX_ARRAY_COUNT_EXT = 0x8087,
            GL_INDEX_ARRAY_STRIDE = 0x8086,
            GL_INDEX_ARRAY_TYPE = 0x8085,
            GL_INDEX_BITS = 0x0D51,
            GL_INDEX_CLEAR_VALUE = 0x0C20,
            GL_INDEX_LOGIC_OP = 0x0BF1,
            GL_INDEX_MODE = 0x0C30,
            GL_INDEX_OFFSET = 0x0D13,
            GL_INDEX_SHIFT = 0x0D12,
            GL_INDEX_WRITEMASK = 0x0C21,
            GL_INSTRUMENT_MEASUREMENTS_SGIX = 0x8181,
            GL_INTERLACE_SGIX = 0x8094,
            GL_IR_INSTRUMENT1_SGIX = 0x817F,
            GL_LAYER_PROVOKING_VERTEX = 0x825E,
            GL_LIGHT0 = 0x4000,
            GL_LIGHT1 = 0x4001,
            GL_LIGHT2 = 0x4002,
            GL_LIGHT3 = 0x4003,
            GL_LIGHT4 = 0x4004,
            GL_LIGHT5 = 0x4005,
            GL_LIGHT6 = 0x4006,
            GL_LIGHT7 = 0x4007,
            GL_LIGHTING = 0x0B50,
            GL_LIGHT_ENV_MODE_SGIX = 0x8407,
            GL_LIGHT_MODEL_AMBIENT = 0x0B53,
            GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8,
            GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51,
            GL_LIGHT_MODEL_TWO_SIDE = 0x0B52,
            GL_LINE_SMOOTH = 0x0B20,
            GL_LINE_SMOOTH_HINT = 0x0C52,
            GL_LINE_STIPPLE = 0x0B24,
            GL_LINE_STIPPLE_PATTERN = 0x0B25,
            GL_LINE_STIPPLE_REPEAT = 0x0B26,
            GL_LINE_WIDTH = 0x0B21,
            GL_LINE_WIDTH_GRANULARITY = 0x0B23,
            GL_LINE_WIDTH_RANGE = 0x0B22,
            GL_LIST_BASE = 0x0B32,
            GL_LIST_INDEX = 0x0B33,
            GL_LIST_MODE = 0x0B30,
            GL_LOGIC_OP = 0x0BF1,
            GL_LOGIC_OP_MODE = 0x0BF0,
            GL_MAJOR_VERSION = 0x821B,
            GL_MAP1_COLOR_4 = 0x0D90,
            GL_MAP1_GRID_DOMAIN = 0x0DD0,
            GL_MAP1_GRID_SEGMENTS = 0x0DD1,
            GL_MAP1_INDEX = 0x0D91,
            GL_MAP1_NORMAL = 0x0D92,
            GL_MAP1_TEXTURE_COORD_1 = 0x0D93,
            GL_MAP1_TEXTURE_COORD_2 = 0x0D94,
            GL_MAP1_TEXTURE_COORD_3 = 0x0D95,
            GL_MAP1_TEXTURE_COORD_4 = 0x0D96,
            GL_MAP1_VERTEX_3 = 0x0D97,
            GL_MAP1_VERTEX_4 = 0x0D98,
            GL_MAP2_COLOR_4 = 0x0DB0,
            GL_MAP2_GRID_DOMAIN = 0x0DD2,
            GL_MAP2_GRID_SEGMENTS = 0x0DD3,
            GL_MAP2_INDEX = 0x0DB1,
            GL_MAP2_NORMAL = 0x0DB2,
            GL_MAP2_TEXTURE_COORD_1 = 0x0DB3,
            GL_MAP2_TEXTURE_COORD_2 = 0x0DB4,
            GL_MAP2_TEXTURE_COORD_3 = 0x0DB5,
            GL_MAP2_TEXTURE_COORD_4 = 0x0DB6,
            GL_MAP2_VERTEX_3 = 0x0DB7,
            GL_MAP2_VERTEX_4 = 0x0DB8,
            GL_MAP_COLOR = 0x0D10,
            GL_MAP_STENCIL = 0x0D11,
            GL_MATRIX_MODE = 0x0BA0,
            GL_MAX_3D_TEXTURE_SIZE = 0x8073,
            GL_MAX_3D_TEXTURE_SIZE_EXT = 0x8073,
            GL_MAX_4D_TEXTURE_SIZE_SGIS = 0x8138,
            GL_MAX_ACTIVE_LIGHTS_SGIX = 0x8405,
            GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF,
            GL_MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360,
            GL_MAX_ASYNC_HISTOGRAM_SGIX = 0x832D,
            GL_MAX_ASYNC_READ_PIXELS_SGIX = 0x8361,
            GL_MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F,
            GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35,
            GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B,
            GL_MAX_CLIPMAP_DEPTH_SGIX = 0x8177,
            GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178,
            GL_MAX_CLIP_DISTANCES = 0x0D32,
            GL_MAX_CLIP_PLANES = 0x0D32,
            GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3,
            GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E,
            GL_MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7,
            GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266,
            GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33,
            GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32,
            GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC,
            GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D,
            GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E,
            GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31,
            GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265,
            GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264,
            GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB,
            GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC,
            GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB,
            GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263,
            GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE,
            GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB,
            GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF,
            GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C,
            GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C,
            GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F,
            GL_MAX_DRAW_BUFFERS = 0x8824,
            GL_MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC,
            GL_MAX_ELEMENTS_INDICES = 0x80E9,
            GL_MAX_ELEMENTS_VERTICES = 0x80E8,
            GL_MAX_ELEMENT_INDEX = 0x8D6B,
            GL_MAX_EVAL_ORDER = 0x0D30,
            GL_MAX_FOG_FUNC_POINTS_SGIS = 0x812C,
            GL_MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6,
            GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125,
            GL_MAX_FRAGMENT_LIGHTS_SGIX = 0x8404,
            GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA,
            GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D,
            GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49,
            GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD,
            GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316,
            GL_MAX_FRAMEBUFFER_LAYERS = 0x9317,
            GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318,
            GL_MAX_FRAMEBUFFER_WIDTH = 0x9315,
            GL_MAX_FRAMEZOOM_FACTOR_SGIX = 0x818D,
            GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5,
            GL_MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123,
            GL_MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124,
            GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7,
            GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29,
            GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C,
            GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF,
            GL_MAX_INTEGER_SAMPLES = 0x9110,
            GL_MAX_LABEL_LENGTH = 0x82E8,
            GL_MAX_LIGHTS = 0x0D31,
            GL_MAX_LIST_NESTING = 0x0B31,
            GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36,
            GL_MAX_NAME_STACK_DEPTH = 0x0D37,
            GL_MAX_PIXEL_MAP_TABLE = 0x0D34,
            GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905,
            GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38,
            GL_MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8,
            GL_MAX_RENDERBUFFER_SIZE = 0x84E8,
            GL_MAX_SAMPLE_MASK_WORDS = 0x8E59,
            GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111,
            GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD,
            GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3,
            GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8,
            GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4,
            GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9,
            GL_MAX_TEXTURE_BUFFER_SIZE = 0x8C2B,
            GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872,
            GL_MAX_TEXTURE_LOD_BIAS = 0x84FD,
            GL_MAX_TEXTURE_SIZE = 0x0D33,
            GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39,
            GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30,
            GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F,
            GL_MAX_UNIFORM_LOCATIONS = 0x826E,
            GL_MAX_VARYING_COMPONENTS = 0x8B4B,
            GL_MAX_VARYING_FLOATS = 0x8B4B,
            GL_MAX_VARYING_VECTORS = 0x8DFC,
            GL_MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2,
            GL_MAX_VERTEX_ATTRIBS = 0x8869,
            GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA,
            GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9,
            GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122,
            GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6,
            GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C,
            GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B,
            GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A,
            GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB,
            GL_MAX_VIEWPORTS = 0x825B,
            GL_MAX_VIEWPORT_DIMS = 0x0D3A,
            GL_MINMAX_EXT = 0x802E,
            GL_MINOR_VERSION = 0x821C,
            GL_MIN_MAP_BUFFER_ALIGNMENT = 0x90BC,
            GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904,
            GL_MODELVIEW0_MATRIX_EXT = 0x0BA6,
            GL_MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3,
            GL_MODELVIEW_MATRIX = 0x0BA6,
            GL_MODELVIEW_STACK_DEPTH = 0x0BA3,
            GL_MULTISAMPLE_SGIS = 0x809D,
            GL_NAME_STACK_DEPTH = 0x0D70,
            GL_NORMALIZE = 0x0BA1,
            GL_NORMAL_ARRAY = 0x8075,
            GL_NORMAL_ARRAY_COUNT_EXT = 0x8080,
            GL_NORMAL_ARRAY_STRIDE = 0x807F,
            GL_NORMAL_ARRAY_TYPE = 0x807E,
            GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2,
            GL_NUM_DEVICE_UUIDS_EXT = 0x9596,
            GL_NUM_EXTENSIONS = 0x821D,
            GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE,
            GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9,
            GL_PACK_ALIGNMENT = 0x0D05,
            GL_PACK_CMYK_HINT_EXT = 0x800E,
            GL_PACK_IMAGE_DEPTH_SGIS = 0x8131,
            GL_PACK_IMAGE_HEIGHT = 0x806C,
            GL_PACK_IMAGE_HEIGHT_EXT = 0x806C,
            GL_PACK_LSB_FIRST = 0x0D01,
            GL_PACK_RESAMPLE_SGIX = 0x842E,
            GL_PACK_ROW_LENGTH = 0x0D02,
            GL_PACK_SKIP_IMAGES = 0x806B,
            GL_PACK_SKIP_IMAGES_EXT = 0x806B,
            GL_PACK_SKIP_PIXELS = 0x0D04,
            GL_PACK_SKIP_ROWS = 0x0D03,
            GL_PACK_SKIP_VOLUMES_SGIS = 0x8130,
            GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0,
            GL_PACK_SWAP_BYTES = 0x0D00,
            GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50,
            GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9,
            GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8,
            GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7,
            GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5,
            GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4,
            GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3,
            GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0,
            GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2,
            GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6,
            GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1,
            GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED,
            GL_PIXEL_TEXTURE_SGIS = 0x8353,
            GL_PIXEL_TEX_GEN_MODE_SGIX = 0x832B,
            GL_PIXEL_TEX_GEN_SGIX = 0x8139,
            GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E,
            GL_PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F,
            GL_PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145,
            GL_PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144,
            GL_PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143,
            GL_PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142,
            GL_PIXEL_TILE_HEIGHT_SGIX = 0x8141,
            GL_PIXEL_TILE_WIDTH_SGIX = 0x8140,
            GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF,
            GL_POINT_FADE_THRESHOLD_SIZE = 0x8128,
            GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128,
            GL_POINT_SIZE = 0x0B11,
            GL_POINT_SIZE_GRANULARITY = 0x0B13,
            GL_POINT_SIZE_MAX_SGIS = 0x8127,
            GL_POINT_SIZE_MIN_SGIS = 0x8126,
            GL_POINT_SIZE_RANGE = 0x0B12,
            GL_POINT_SMOOTH = 0x0B10,
            GL_POINT_SMOOTH_HINT = 0x0C51,
            GL_POLYGON_MODE = 0x0B40,
            GL_POLYGON_OFFSET_BIAS_EXT = 0x8039,
            GL_POLYGON_OFFSET_FACTOR = 0x8038,
            GL_POLYGON_OFFSET_FILL = 0x8037,
            GL_POLYGON_OFFSET_LINE = 0x2A02,
            GL_POLYGON_OFFSET_POINT = 0x2A01,
            GL_POLYGON_OFFSET_UNITS = 0x2A00,
            GL_POLYGON_SMOOTH = 0x0B41,
            GL_POLYGON_SMOOTH_HINT = 0x0C53,
            GL_POLYGON_STIPPLE = 0x0B42,
            GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB,
            GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7,
            GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA,
            GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6,
            GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2,
            GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9,
            GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5,
            GL_POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8,
            GL_POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4,
            GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023,
            GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F,
            GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022,
            GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E,
            GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1,
            GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021,
            GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D,
            GL_POST_CONVOLUTION_RED_BIAS_EXT = 0x8020,
            GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C,
            GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B,
            GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C,
            GL_PRIMITIVE_RESTART_INDEX = 0x8F9E,
            GL_PROGRAM_BINARY_FORMATS = 0x87FF,
            GL_PROGRAM_PIPELINE_BINDING = 0x825A,
            GL_PROGRAM_POINT_SIZE = 0x8642,
            GL_PROJECTION_MATRIX = 0x0BA7,
            GL_PROJECTION_STACK_DEPTH = 0x0BA4,
            GL_PROVOKING_VERTEX = 0x8E4F,
            GL_READ_BUFFER = 0x0C02,
            GL_READ_BUFFER_EXT = 0x0C02,
            GL_READ_BUFFER_NV = 0x0C02,
            GL_READ_FRAMEBUFFER_BINDING = 0x8CAA,
            GL_RED_BIAS = 0x0D15,
            GL_RED_BITS = 0x0D52,
            GL_RED_SCALE = 0x0D14,
            GL_REFERENCE_PLANE_EQUATION_SGIX = 0x817E,
            GL_REFERENCE_PLANE_SGIX = 0x817D,
            GL_RENDERBUFFER_BINDING = 0x8CA7,
            GL_RENDER_MODE = 0x0C40,
            GL_RESCALE_NORMAL_EXT = 0x803A,
            GL_RGBA_MODE = 0x0C31,
            GL_SAMPLER_BINDING = 0x8919,
            GL_SAMPLES = 0x80A9,
            GL_SAMPLES_SGIS = 0x80A9,
            GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E,
            GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F,
            GL_SAMPLE_BUFFERS = 0x80A8,
            GL_SAMPLE_BUFFERS_SGIS = 0x80A8,
            GL_SAMPLE_COVERAGE_INVERT = 0x80AB,
            GL_SAMPLE_COVERAGE_VALUE = 0x80AA,
            GL_SAMPLE_MASK_INVERT_SGIS = 0x80AB,
            GL_SAMPLE_MASK_SGIS = 0x80A0,
            GL_SAMPLE_MASK_VALUE_SGIS = 0x80AA,
            GL_SAMPLE_PATTERN_SGIS = 0x80AC,
            GL_SCISSOR_BOX = 0x0C10,
            GL_SCISSOR_TEST = 0x0C11,
            GL_SELECTION_BUFFER_SIZE = 0x0DF4,
            GL_SEPARABLE_2D_EXT = 0x8012,
            GL_SHADER_COMPILER = 0x8DFA,
            GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3,
            GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF,
            GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5,
            GL_SHADER_STORAGE_BUFFER_START = 0x90D4,
            GL_SHADE_MODEL = 0x0B54,
            GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB,
            GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23,
            GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22,
            GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13,
            GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12,
            GL_SPRITE_AXIS_SGIX = 0x814A,
            GL_SPRITE_MODE_SGIX = 0x8149,
            GL_SPRITE_SGIX = 0x8148,
            GL_SPRITE_TRANSLATION_SGIX = 0x814B,
            GL_STENCIL_BACK_FAIL = 0x8801,
            GL_STENCIL_BACK_FUNC = 0x8800,
            GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802,
            GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803,
            GL_STENCIL_BACK_REF = 0x8CA3,
            GL_STENCIL_BACK_VALUE_MASK = 0x8CA4,
            GL_STENCIL_BACK_WRITEMASK = 0x8CA5,
            GL_STENCIL_BITS = 0x0D57,
            GL_STENCIL_CLEAR_VALUE = 0x0B91,
            GL_STENCIL_FAIL = 0x0B94,
            GL_STENCIL_FUNC = 0x0B92,
            GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95,
            GL_STENCIL_PASS_DEPTH_PASS = 0x0B96,
            GL_STENCIL_REF = 0x0B97,
            GL_STENCIL_TEST = 0x0B90,
            GL_STENCIL_VALUE_MASK = 0x0B93,
            GL_STENCIL_WRITEMASK = 0x0B98,
            GL_STEREO = 0x0C33,
            GL_SUBPIXEL_BITS = 0x0D50,
            GL_TEXTURE_1D = 0x0DE0,
            GL_TEXTURE_2D = 0x0DE1,
            GL_TEXTURE_3D_BINDING_EXT = 0x806A,
            GL_TEXTURE_3D_EXT = 0x806F,
            GL_TEXTURE_4D_BINDING_SGIS = 0x814F,
            GL_TEXTURE_4D_SGIS = 0x8134,
            GL_TEXTURE_BINDING_1D = 0x8068,
            GL_TEXTURE_BINDING_1D_ARRAY = 0x8C1C,
            GL_TEXTURE_BINDING_2D = 0x8069,
            GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D,
            GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104,
            GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105,
            GL_TEXTURE_BINDING_3D = 0x806A,
            GL_TEXTURE_BINDING_BUFFER = 0x8C2C,
            GL_TEXTURE_BINDING_CUBE_MAP = 0x8514,
            GL_TEXTURE_BINDING_RECTANGLE = 0x84F6,
            GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F,
            GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC,
            GL_TEXTURE_COMPRESSION_HINT = 0x84EF,
            GL_TEXTURE_COORD_ARRAY = 0x8078,
            GL_TEXTURE_COORD_ARRAY_COUNT_EXT = 0x808B,
            GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088,
            GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A,
            GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089,
            GL_TEXTURE_GEN_Q = 0x0C63,
            GL_TEXTURE_GEN_R = 0x0C62,
            GL_TEXTURE_GEN_S = 0x0C60,
            GL_TEXTURE_GEN_T = 0x0C61,
            GL_TEXTURE_MATRIX = 0x0BA8,
            GL_TEXTURE_STACK_DEPTH = 0x0BA5,
            GL_TIMESTAMP = 0x8E28,
            GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F,
            GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85,
            GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84,
            GL_UNIFORM_BUFFER_BINDING = 0x8A28,
            GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34,
            GL_UNIFORM_BUFFER_SIZE = 0x8A2A,
            GL_UNIFORM_BUFFER_START = 0x8A29,
            GL_UNPACK_ALIGNMENT = 0x0CF5,
            GL_UNPACK_CMYK_HINT_EXT = 0x800F,
            GL_UNPACK_IMAGE_DEPTH_SGIS = 0x8133,
            GL_UNPACK_IMAGE_HEIGHT = 0x806E,
            GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E,
            GL_UNPACK_LSB_FIRST = 0x0CF1,
            GL_UNPACK_RESAMPLE_SGIX = 0x842F,
            GL_UNPACK_ROW_LENGTH = 0x0CF2,
            GL_UNPACK_SKIP_IMAGES = 0x806D,
            GL_UNPACK_SKIP_IMAGES_EXT = 0x806D,
            GL_UNPACK_SKIP_PIXELS = 0x0CF4,
            GL_UNPACK_SKIP_ROWS = 0x0CF3,
            GL_UNPACK_SKIP_VOLUMES_SGIS = 0x8132,
            GL_UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1,
            GL_UNPACK_SWAP_BYTES = 0x0CF0,
            GL_VERTEX_ARRAY = 0x8074,
            GL_VERTEX_ARRAY_BINDING = 0x85B5,
            GL_VERTEX_ARRAY_COUNT_EXT = 0x807D,
            GL_VERTEX_ARRAY_SIZE = 0x807A,
            GL_VERTEX_ARRAY_STRIDE = 0x807C,
            GL_VERTEX_ARRAY_TYPE = 0x807B,
            GL_VERTEX_BINDING_DIVISOR = 0x82D6,
            GL_VERTEX_BINDING_OFFSET = 0x82D7,
            GL_VERTEX_BINDING_STRIDE = 0x82D8,
            GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF,
            GL_VERTEX_PRECLIP_SGIX = 0x83EE,
            GL_VIEWPORT = 0x0BA2,
            GL_VIEWPORT_BOUNDS_RANGE = 0x825D,
            GL_VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F,
            GL_VIEWPORT_SUBPIXEL_BITS = 0x825C,
            GL_ZOOM_X = 0x0D16,
            GL_ZOOM_Y = 0x0D17
        }
        public enum GetTextureParameter : uint
        {
            GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C,
            GL_DETAIL_TEXTURE_LEVEL_SGIS = 0x809A,
            GL_DETAIL_TEXTURE_MODE_SGIS = 0x809B,
            GL_DUAL_TEXTURE_SELECT_SGIS = 0x8124,
            GL_GENERATE_MIPMAP_SGIS = 0x8191,
            GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179,
            GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A,
            GL_QUAD_TEXTURE_SELECT_SGIS = 0x8125,
            GL_SHADOW_AMBIENT_SGIX = 0x80BF,
            GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0,
            GL_TEXTURE_4DSIZE_SGIS = 0x8136,
            GL_TEXTURE_ALPHA_SIZE = 0x805F,
            GL_TEXTURE_BASE_LEVEL_SGIS = 0x813C,
            GL_TEXTURE_BLUE_SIZE = 0x805E,
            GL_TEXTURE_BORDER = 0x1005,
            GL_TEXTURE_BORDER_COLOR = 0x1004,
            GL_TEXTURE_BORDER_COLOR_NV = 0x1004,
            GL_TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171,
            GL_TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176,
            GL_TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172,
            GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175,
            GL_TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173,
            GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174,
            GL_TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B,
            GL_TEXTURE_COMPARE_SGIX = 0x819A,
            GL_TEXTURE_COMPONENTS = 0x1003,
            GL_TEXTURE_DEPTH_EXT = 0x8071,
            GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147,
            GL_TEXTURE_GEQUAL_R_SGIX = 0x819D,
            GL_TEXTURE_GREEN_SIZE = 0x805D,
            GL_TEXTURE_HEIGHT = 0x1001,
            GL_TEXTURE_INTENSITY_SIZE = 0x8061,
            GL_TEXTURE_INTERNAL_FORMAT = 0x1003,
            GL_TEXTURE_LEQUAL_R_SGIX = 0x819C,
            GL_TEXTURE_LOD_BIAS_R_SGIX = 0x8190,
            GL_TEXTURE_LOD_BIAS_S_SGIX = 0x818E,
            GL_TEXTURE_LOD_BIAS_T_SGIX = 0x818F,
            GL_TEXTURE_LUMINANCE_SIZE = 0x8060,
            GL_TEXTURE_MAG_FILTER = 0x2800,
            GL_TEXTURE_MAX_CLAMP_R_SGIX = 0x836B,
            GL_TEXTURE_MAX_CLAMP_S_SGIX = 0x8369,
            GL_TEXTURE_MAX_CLAMP_T_SGIX = 0x836A,
            GL_TEXTURE_MAX_LEVEL_SGIS = 0x813D,
            GL_TEXTURE_MAX_LOD_SGIS = 0x813B,
            GL_TEXTURE_MIN_FILTER = 0x2801,
            GL_TEXTURE_MIN_LOD_SGIS = 0x813A,
            GL_TEXTURE_PRIORITY = 0x8066,
            GL_TEXTURE_RED_SIZE = 0x805C,
            GL_TEXTURE_RESIDENT = 0x8067,
            GL_TEXTURE_WIDTH = 0x1000,
            GL_TEXTURE_WRAP_Q_SGIS = 0x8137,
            GL_TEXTURE_WRAP_R_EXT = 0x8072,
            GL_TEXTURE_WRAP_S = 0x2802,
            GL_TEXTURE_WRAP_T = 0x2803
        }
        public enum GlslTypeToken : uint
        {
            GL_FLOAT = 0x1406,
            GL_FLOAT_VEC2 = 0x8B50,
            GL_FLOAT_VEC3 = 0x8B51,
            GL_FLOAT_VEC4 = 0x8B52,
            GL_DOUBLE = 0x140A,
            GL_DOUBLE_VEC2 = 0x8FFC,
            GL_DOUBLE_VEC3 = 0x8FFD,
            GL_DOUBLE_VEC4 = 0x8FFE,
            GL_INT = 0x1404,
            GL_INT_VEC2 = 0x8B53,
            GL_INT_VEC3 = 0x8B54,
            GL_INT_VEC4 = 0x8B55,
            GL_UNSIGNED_INT = 0x1405,
            GL_UNSIGNED_INT_VEC2 = 0x8DC6,
            GL_UNSIGNED_INT_VEC3 = 0x8DC7,
            GL_UNSIGNED_INT_VEC4 = 0x8DC8,
            GL_BOOL = 0x8B56,
            GL_BOOL_VEC2 = 0x8B57,
            GL_BOOL_VEC3 = 0x8B58,
            GL_BOOL_VEC4 = 0x8B59,
            GL_FLOAT_MAT2 = 0x8B5A,
            GL_FLOAT_MAT3 = 0x8B5B,
            GL_FLOAT_MAT4 = 0x8B5C,
            GL_FLOAT_MAT2x3 = 0x8B65,
            GL_FLOAT_MAT2x4 = 0x8B66,
            GL_FLOAT_MAT3x2 = 0x8B67,
            GL_FLOAT_MAT3x4 = 0x8B68,
            GL_FLOAT_MAT4x2 = 0x8B69,
            GL_FLOAT_MAT4x3 = 0x8B6A,
            GL_DOUBLE_MAT2 = 0x8F46,
            GL_DOUBLE_MAT3 = 0x8F47,
            GL_DOUBLE_MAT4 = 0x8F48,
            GL_SAMPLER_1D = 0x8B5D,
            GL_SAMPLER_2D = 0x8B5E,
            GL_SAMPLER_3D = 0x8B5F,
            GL_SAMPLER_CUBE = 0x8B60,
            GL_SAMPLER_1D_SHADOW = 0x8B61,
            GL_SAMPLER_2D_SHADOW = 0x8B62,
            GL_SAMPLER_1D_ARRAY = 0x8DC0,
            GL_SAMPLER_2D_ARRAY = 0x8DC1,
            GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C,
            GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3,
            GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4,
            GL_SAMPLER_2D_MULTISAMPLE = 0x9108,
            GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B,
            GL_SAMPLER_CUBE_SHADOW = 0x8DC5,
            GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D,
            GL_SAMPLER_BUFFER = 0x8DC2,
            GL_SAMPLER_2D_RECT = 0x8B63,
            GL_SAMPLER_2D_RECT_SHADOW = 0x8B64,
            GL_INT_SAMPLER_1D = 0x8DC9,
            GL_INT_SAMPLER_2D = 0x8DCA,
            GL_INT_SAMPLER_3D = 0x8DCB,
            GL_INT_SAMPLER_CUBE = 0x8DCC,
            GL_INT_SAMPLER_1D_ARRAY = 0x8DCE,
            GL_INT_SAMPLER_2D_ARRAY = 0x8DCF,
            GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E,
            GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109,
            GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C,
            GL_INT_SAMPLER_BUFFER = 0x8DD0,
            GL_INT_SAMPLER_2D_RECT = 0x8DCD,
            GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1,
            GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2,
            GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3,
            GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4,
            GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6,
            GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7,
            GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F,
            GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A,
            GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D,
            GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8,
            GL_UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5,
            GL_IMAGE_1D = 0x904C,
            GL_IMAGE_2D = 0x904D,
            GL_IMAGE_3D = 0x904E,
            GL_IMAGE_2D_RECT = 0x904F,
            GL_IMAGE_CUBE = 0x9050,
            GL_IMAGE_BUFFER = 0x9051,
            GL_IMAGE_1D_ARRAY = 0x9052,
            GL_IMAGE_2D_ARRAY = 0x9053,
            GL_IMAGE_CUBE_MAP_ARRAY = 0x9054,
            GL_IMAGE_2D_MULTISAMPLE = 0x9055,
            GL_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056,
            GL_INT_IMAGE_1D = 0x9057,
            GL_INT_IMAGE_2D = 0x9058,
            GL_INT_IMAGE_3D = 0x9059,
            GL_INT_IMAGE_2D_RECT = 0x905A,
            GL_INT_IMAGE_CUBE = 0x905B,
            GL_INT_IMAGE_BUFFER = 0x905C,
            GL_INT_IMAGE_1D_ARRAY = 0x905D,
            GL_INT_IMAGE_2D_ARRAY = 0x905E,
            GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F,
            GL_INT_IMAGE_2D_MULTISAMPLE = 0x9060,
            GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061,
            GL_UNSIGNED_INT_IMAGE_1D = 0x9062,
            GL_UNSIGNED_INT_IMAGE_2D = 0x9063,
            GL_UNSIGNED_INT_IMAGE_3D = 0x9064,
            GL_UNSIGNED_INT_IMAGE_2D_RECT = 0x9065,
            GL_UNSIGNED_INT_IMAGE_CUBE = 0x9066,
            GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067,
            GL_UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068,
            GL_UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069,
            GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A,
            GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B,
            GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C,
            GL_UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB
        }
        public enum GraphicsResetStatus : uint
        {
            GL_NO_ERROR = 0,
            GL_GUILTY_CONTEXT_RESET = 0x8253,
            GL_INNOCENT_CONTEXT_RESET = 0x8254,
            GL_UNKNOWN_CONTEXT_RESET = 0x8255
        }
        public enum HintMode : uint
        {
            GL_DONT_CARE = 0x1100,
            GL_FASTEST = 0x1101,
            GL_NICEST = 0x1102
        }
        public enum HintTarget : uint
        {
            GL_ALLOW_DRAW_FRG_HINT_PGI = 0x1A210,
            GL_ALLOW_DRAW_MEM_HINT_PGI = 0x1A211,
            GL_ALLOW_DRAW_OBJ_HINT_PGI = 0x1A20E,
            GL_ALLOW_DRAW_WIN_HINT_PGI = 0x1A20F,
            GL_ALWAYS_FAST_HINT_PGI = 0x1A20C,
            GL_ALWAYS_SOFT_HINT_PGI = 0x1A20D,
            GL_BACK_NORMALS_HINT_PGI = 0x1A223,
            GL_BINNING_CONTROL_HINT_QCOM = 0x8FB0,
            GL_CLIP_FAR_HINT_PGI = 0x1A221,
            GL_CLIP_NEAR_HINT_PGI = 0x1A220,
            GL_CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0,
            GL_CONSERVE_MEMORY_HINT_PGI = 0x1A1FD,
            GL_CONVOLUTION_HINT_SGIX = 0x8316,
            GL_FOG_HINT = 0x0C54,
            GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B,
            GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B,
            GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES = 0x8B8B,
            GL_FULL_STIPPLE_HINT_PGI = 0x1A219,
            GL_GENERATE_MIPMAP_HINT = 0x8192,
            GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192,
            GL_LINE_QUALITY_HINT_SGIX = 0x835B,
            GL_LINE_SMOOTH_HINT = 0x0C52,
            GL_MATERIAL_SIDE_HINT_PGI = 0x1A22C,
            GL_MAX_VERTEX_HINT_PGI = 0x1A22D,
            GL_MULTISAMPLE_FILTER_HINT_NV = 0x8534,
            GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203,
            GL_NATIVE_GRAPHICS_END_HINT_PGI = 0x1A204,
            GL_PACK_CMYK_HINT_EXT = 0x800E,
            GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50,
            GL_PHONG_HINT_WIN = 0x80EB,
            GL_POINT_SMOOTH_HINT = 0x0C51,
            GL_POLYGON_SMOOTH_HINT = 0x0C53,
            GL_PREFER_DOUBLEBUFFER_HINT_PGI = 0x1A1F8,
            GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257,
            GL_RECLAIM_MEMORY_HINT_PGI = 0x1A1FE,
            GL_SCALEBIAS_HINT_SGIX = 0x8322,
            GL_STRICT_DEPTHFUNC_HINT_PGI = 0x1A216,
            GL_STRICT_LIGHTING_HINT_PGI = 0x1A217,
            GL_STRICT_SCISSOR_HINT_PGI = 0x1A218,
            GL_TEXTURE_COMPRESSION_HINT = 0x84EF,
            GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF,
            GL_TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E,
            GL_TEXTURE_STORAGE_HINT_APPLE = 0x85BC,
            GL_TRANSFORM_HINT_APPLE = 0x85B1,
            GL_UNPACK_CMYK_HINT_EXT = 0x800F,
            GL_VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F,
            GL_VERTEX_CONSISTENT_HINT_PGI = 0x1A22B,
            GL_VERTEX_DATA_HINT_PGI = 0x1A22A,
            GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF,
            GL_VERTEX_PRECLIP_SGIX = 0x83EE,
            GL_WIDE_LINE_HINT_PGI = 0x1A222
        }
        public enum IndexFunctionEXT : uint
        {
            GL_NEVER = 0x0200,
            GL_ALWAYS = 0x0207,
            GL_LESS = 0x0201,
            GL_LEQUAL = 0x0203,
            GL_EQUAL = 0x0202,
            GL_GEQUAL = 0x0206,
            GL_GREATER = 0x0204,
            GL_NOTEQUAL = 0x0205
        }
        public enum IndexPointerType : uint
        {
            GL_DOUBLE = 0x140A,
            GL_FLOAT = 0x1406,
            GL_INT = 0x1404,
            GL_SHORT = 0x1402
        }
        public enum InternalFormat : uint
        {
            GL_ALPHA12 = 0x803D,
            GL_ALPHA16 = 0x803E,
            GL_ALPHA4 = 0x803B,
            GL_ALPHA8 = 0x803C,
            GL_DUAL_ALPHA12_SGIS = 0x8112,
            GL_DUAL_ALPHA16_SGIS = 0x8113,
            GL_DUAL_ALPHA4_SGIS = 0x8110,
            GL_DUAL_ALPHA8_SGIS = 0x8111,
            GL_DUAL_INTENSITY12_SGIS = 0x811A,
            GL_DUAL_INTENSITY16_SGIS = 0x811B,
            GL_DUAL_INTENSITY4_SGIS = 0x8118,
            GL_DUAL_INTENSITY8_SGIS = 0x8119,
            GL_DUAL_LUMINANCE12_SGIS = 0x8116,
            GL_DUAL_LUMINANCE16_SGIS = 0x8117,
            GL_DUAL_LUMINANCE4_SGIS = 0x8114,
            GL_DUAL_LUMINANCE8_SGIS = 0x8115,
            GL_DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C,
            GL_DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D,
            GL_INTENSITY = 0x8049,
            GL_INTENSITY12 = 0x804C,
            GL_INTENSITY16 = 0x804D,
            GL_INTENSITY4 = 0x804A,
            GL_INTENSITY8 = 0x804B,
            GL_LUMINANCE12 = 0x8041,
            GL_LUMINANCE12_ALPHA12 = 0x8047,
            GL_LUMINANCE12_ALPHA4 = 0x8046,
            GL_LUMINANCE16 = 0x8042,
            GL_LUMINANCE16_ALPHA16 = 0x8048,
            GL_LUMINANCE4 = 0x803F,
            GL_LUMINANCE4_ALPHA4 = 0x8043,
            GL_LUMINANCE6_ALPHA2 = 0x8044,
            GL_LUMINANCE8 = 0x8040,
            GL_LUMINANCE8_ALPHA8 = 0x8045,
            GL_QUAD_ALPHA4_SGIS = 0x811E,
            GL_QUAD_ALPHA8_SGIS = 0x811F,
            GL_QUAD_INTENSITY4_SGIS = 0x8122,
            GL_QUAD_INTENSITY8_SGIS = 0x8123,
            GL_QUAD_LUMINANCE4_SGIS = 0x8120,
            GL_QUAD_LUMINANCE8_SGIS = 0x8121,
            GL_RED = 0x1903,
            GL_RED_EXT = 0x1903,
            GL_R8 = 0x8229,
            GL_R8_EXT = 0x8229,
            GL_R8_SNORM = 0x8F94,
            GL_R16 = 0x822A,
            GL_R16_EXT = 0x822A,
            GL_R16_SNORM = 0x8F98,
            GL_R16_SNORM_EXT = 0x8F98,
            GL_R16F = 0x822D,
            GL_R16F_EXT = 0x822D,
            GL_R32F = 0x822E,
            GL_R32F_EXT = 0x822E,
            GL_R8I = 0x8231,
            GL_R16I = 0x8233,
            GL_R32I = 0x8235,
            GL_R8UI = 0x8232,
            GL_R16UI = 0x8234,
            GL_R32UI = 0x8236,
            GL_RG = 0x8227,
            GL_RG8 = 0x822B,
            GL_RG8_EXT = 0x822B,
            GL_RG8_SNORM = 0x8F95,
            GL_RG16 = 0x822C,
            GL_RG16_EXT = 0x822C,
            GL_RG16_SNORM = 0x8F99,
            GL_RG16_SNORM_EXT = 0x8F99,
            GL_RG16F = 0x822F,
            GL_RG16F_EXT = 0x822F,
            GL_RG32F = 0x8230,
            GL_RG32F_EXT = 0x8230,
            GL_RG8I = 0x8237,
            GL_RG16I = 0x8239,
            GL_RG32I = 0x823B,
            GL_RG8UI = 0x8238,
            GL_RG16UI = 0x823A,
            GL_RG32UI = 0x823C,
            GL_RGB = 0x1907,
            GL_RGB2_EXT = 0x804E,
            GL_RGB4 = 0x804F,
            GL_RGB4_EXT = 0x804F,
            GL_RGB5 = 0x8050,
            GL_RGB5_EXT = 0x8050,
            GL_RGB8 = 0x8051,
            GL_RGB8_EXT = 0x8051,
            GL_RGB8_OES = 0x8051,
            GL_RGB8_SNORM = 0x8F96,
            GL_RGB10 = 0x8052,
            GL_RGB10_EXT = 0x8052,
            GL_RGB12 = 0x8053,
            GL_RGB12_EXT = 0x8053,
            GL_RGB16 = 0x8054,
            GL_RGB16_EXT = 0x8054,
            GL_RGB16F = 0x881B,
            GL_RGB16F_ARB = 0x881B,
            GL_RGB16F_EXT = 0x881B,
            GL_RGB16_SNORM = 0x8F9A,
            GL_RGB16_SNORM_EXT = 0x8F9A,
            GL_RGB32F = 0x8815,
            GL_RGB8I = 0x8D8F,
            GL_RGB16I = 0x8D89,
            GL_RGB32I = 0x8D83,
            GL_RGB8UI = 0x8D7D,
            GL_RGB16UI = 0x8D77,
            GL_RGB32UI = 0x8D71,
            GL_SRGB = 0x8C40,
            GL_SRGB_EXT = 0x8C40,
            GL_SRGB_ALPHA = 0x8C42,
            GL_SRGB_ALPHA_EXT = 0x8C42,
            GL_SRGB8 = 0x8C41,
            GL_SRGB8_EXT = 0x8C41,
            GL_SRGB8_NV = 0x8C41,
            GL_SRGB8_ALPHA8 = 0x8C43,
            GL_SRGB8_ALPHA8_EXT = 0x8C43,
            GL_R3_G3_B2 = 0x2A10,
            GL_R11F_G11F_B10F = 0x8C3A,
            GL_R11F_G11F_B10F_APPLE = 0x8C3A,
            GL_R11F_G11F_B10F_EXT = 0x8C3A,
            GL_RGB9_E5 = 0x8C3D,
            GL_RGB9_E5_APPLE = 0x8C3D,
            GL_RGB9_E5_EXT = 0x8C3D,
            GL_RGBA = 0x1908,
            GL_RGBA4 = 0x8056,
            GL_RGBA4_EXT = 0x8056,
            GL_RGBA4_OES = 0x8056,
            GL_RGB5_A1 = 0x8057,
            GL_RGB5_A1_EXT = 0x8057,
            GL_RGB5_A1_OES = 0x8057,
            GL_RGBA8 = 0x8058,
            GL_RGBA8_EXT = 0x8058,
            GL_RGBA8_OES = 0x8058,
            GL_RGBA8_SNORM = 0x8F97,
            GL_RGB10_A2 = 0x8059,
            GL_RGB10_A2_EXT = 0x8059,
            GL_RGBA12 = 0x805A,
            GL_RGBA12_EXT = 0x805A,
            GL_RGBA16 = 0x805B,
            GL_RGBA16_EXT = 0x805B,
            GL_RGBA16F = 0x881A,
            GL_RGBA16F_ARB = 0x881A,
            GL_RGBA16F_EXT = 0x881A,
            GL_RGBA32F = 0x8814,
            GL_RGBA32F_ARB = 0x8814,
            GL_RGBA32F_EXT = 0x8814,
            GL_RGBA8I = 0x8D8E,
            GL_RGBA16I = 0x8D88,
            GL_RGBA32I = 0x8D82,
            GL_RGBA8UI = 0x8D7C,
            GL_RGBA16UI = 0x8D76,
            GL_RGBA32UI = 0x8D70,
            GL_RGB10_A2UI = 0x906F,
            GL_DEPTH_COMPONENT = 0x1902,
            GL_DEPTH_COMPONENT16 = 0x81A5,
            GL_DEPTH_COMPONENT16_ARB = 0x81A5,
            GL_DEPTH_COMPONENT16_OES = 0x81A5,
            GL_DEPTH_COMPONENT16_SGIX = 0x81A5,
            GL_DEPTH_COMPONENT24_ARB = 0x81A6,
            GL_DEPTH_COMPONENT24_OES = 0x81A6,
            GL_DEPTH_COMPONENT24_SGIX = 0x81A6,
            GL_DEPTH_COMPONENT32_ARB = 0x81A7,
            GL_DEPTH_COMPONENT32_OES = 0x81A7,
            GL_DEPTH_COMPONENT32_SGIX = 0x81A7,
            GL_DEPTH_COMPONENT32F = 0x8CAC,
            GL_DEPTH_COMPONENT32F_NV = 0x8DAB,
            GL_DEPTH_STENCIL = 0x84F9,
            GL_DEPTH_STENCIL_EXT = 0x84F9,
            GL_DEPTH_STENCIL_MESA = 0x8750,
            GL_DEPTH_STENCIL_NV = 0x84F9,
            GL_DEPTH_STENCIL_OES = 0x84F9,
            GL_DEPTH24_STENCIL8 = 0x88F0,
            GL_DEPTH24_STENCIL8_EXT = 0x88F0,
            GL_DEPTH24_STENCIL8_OES = 0x88F0,
            GL_DEPTH32F_STENCIL8 = 0x8CAD,
            GL_DEPTH32F_STENCIL8_NV = 0x8DAC,
            GL_STENCIL_INDEX = 0x1901,
            GL_STENCIL_INDEX_OES = 0x1901,
            GL_STENCIL_INDEX1 = 0x8D46,
            GL_STENCIL_INDEX1_OES = 0x8D46,
            GL_STENCIL_INDEX1_EXT = 0x8D46,
            GL_STENCIL_INDEX4 = 0x8D47,
            GL_STENCIL_INDEX4_OES = 0x8D47,
            GL_STENCIL_INDEX4_EXT = 0x8D47,
            GL_STENCIL_INDEX8 = 0x8D48,
            GL_STENCIL_INDEX8_OES = 0x8D48,
            GL_STENCIL_INDEX8_EXT = 0x8D48,
            GL_STENCIL_INDEX16 = 0x8D49,
            GL_STENCIL_INDEX16_EXT = 0x8D49,
            GL_COMPRESSED_RED = 0x8225,
            GL_COMPRESSED_RG = 0x8226,
            GL_COMPRESSED_RGB = 0x84ED,
            GL_COMPRESSED_RGBA = 0x84EE,
            GL_COMPRESSED_SRGB = 0x8C48,
            GL_COMPRESSED_SRGB_ALPHA = 0x8C49,
            GL_COMPRESSED_RED_RGTC1 = 0x8DBB,
            GL_COMPRESSED_RED_RGTC1_EXT = 0x8DBB,
            GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC,
            GL_COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC,
            GL_COMPRESSED_R11_EAC = 0x9270,
            GL_COMPRESSED_SIGNED_R11_EAC = 0x9271,
            GL_COMPRESSED_RG_RGTC2 = 0x8DBD,
            GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE,
            GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C,
            GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D,
            GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E,
            GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F,
            GL_COMPRESSED_RGB8_ETC2 = 0x9274,
            GL_COMPRESSED_SRGB8_ETC2 = 0x9275,
            GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276,
            GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277,
            GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278,
            GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279,
            GL_COMPRESSED_RG11_EAC = 0x9272,
            GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273,
            GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0,
            GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C,
            GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1,
            GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D,
            GL_COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2,
            GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E,
            GL_COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3,
            GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F,
            GL_COMPRESSED_RGBA_ASTC_3x3x3_OES = 0x93C0,
            GL_COMPRESSED_RGBA_ASTC_4x3x3_OES = 0x93C1,
            GL_COMPRESSED_RGBA_ASTC_4x4 = 0x93B0,
            GL_COMPRESSED_RGBA_ASTC_4x4_KHR = 0x93B0,
            GL_COMPRESSED_RGBA_ASTC_4x4x3_OES = 0x93C2,
            GL_COMPRESSED_RGBA_ASTC_4x4x4_OES = 0x93C3,
            GL_COMPRESSED_RGBA_ASTC_5x4 = 0x93B1,
            GL_COMPRESSED_RGBA_ASTC_5x4_KHR = 0x93B1,
            GL_COMPRESSED_RGBA_ASTC_5x4x4_OES = 0x93C4,
            GL_COMPRESSED_RGBA_ASTC_5x5 = 0x93B2,
            GL_COMPRESSED_RGBA_ASTC_5x5_KHR = 0x93B2,
            GL_COMPRESSED_RGBA_ASTC_5x5x4_OES = 0x93C5,
            GL_COMPRESSED_RGBA_ASTC_5x5x5_OES = 0x93C6,
            GL_COMPRESSED_RGBA_ASTC_6x5 = 0x93B3,
            GL_COMPRESSED_RGBA_ASTC_6x5_KHR = 0x93B3,
            GL_COMPRESSED_RGBA_ASTC_6x5x5_OES = 0x93C7,
            GL_COMPRESSED_RGBA_ASTC_6x6 = 0x93B4,
            GL_COMPRESSED_RGBA_ASTC_6x6_KHR = 0x93B4,
            GL_COMPRESSED_RGBA_ASTC_6x6x5_OES = 0x93C8,
            GL_COMPRESSED_RGBA_ASTC_6x6x6_OES = 0x93C9,
            GL_COMPRESSED_RGBA_ASTC_8x5 = 0x93B5,
            GL_COMPRESSED_RGBA_ASTC_8x5_KHR = 0x93B5,
            GL_COMPRESSED_RGBA_ASTC_8x6 = 0x93B6,
            GL_COMPRESSED_RGBA_ASTC_8x6_KHR = 0x93B6,
            GL_COMPRESSED_RGBA_ASTC_8x8 = 0x93B7,
            GL_COMPRESSED_RGBA_ASTC_8x8_KHR = 0x93B7,
            GL_COMPRESSED_RGBA_ASTC_10x10 = 0x93BB,
            GL_COMPRESSED_RGBA_ASTC_10x10_KHR = 0x93BB,
            GL_COMPRESSED_RGBA_ASTC_10x5 = 0x93B8,
            GL_COMPRESSED_RGBA_ASTC_10x5_KHR = 0x93B8,
            GL_COMPRESSED_RGBA_ASTC_10x6 = 0x93B9,
            GL_COMPRESSED_RGBA_ASTC_10x6_KHR = 0x93B9,
            GL_COMPRESSED_RGBA_ASTC_10x8 = 0x93BA,
            GL_COMPRESSED_RGBA_ASTC_10x8_KHR = 0x93BA,
            GL_COMPRESSED_RGBA_ASTC_12x10 = 0x93BC,
            GL_COMPRESSED_RGBA_ASTC_12x10_KHR = 0x93BC,
            GL_COMPRESSED_RGBA_ASTC_12x12 = 0x93BD,
            GL_COMPRESSED_RGBA_ASTC_12x12_KHR = 0x93BD,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES = 0x93E0,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES = 0x93E1,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4 = 0x93D0,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR = 0x93D0,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES = 0x93E2,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES = 0x93E3,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4 = 0x93D1,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR = 0x93D1,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES = 0x93E4,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5 = 0x93D2,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR = 0x93D2,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES = 0x93E5,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES = 0x93E6,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5 = 0x93D3,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR = 0x93D3,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES = 0x93E7,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6 = 0x93D4,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR = 0x93D4,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES = 0x93E8,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES = 0x93E9,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5 = 0x93D5,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR = 0x93D5,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6 = 0x93D6,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR = 0x93D6,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8 = 0x93D7,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR = 0x93D7,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10 = 0x93DB,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR = 0x93DB,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5 = 0x93D8,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR = 0x93D8,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6 = 0x93D9,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR = 0x93D9,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8 = 0x93DA,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR = 0x93DA,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10 = 0x93DC,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR = 0x93DC,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12 = 0x93DD,
            GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR = 0x93DD
        }
        public enum InternalFormatPName : uint
        {
            GL_NUM_SAMPLE_COUNTS = 0x9380,
            GL_SAMPLES = 0x80A9,
            GL_INTERNALFORMAT_SUPPORTED = 0x826F,
            GL_INTERNALFORMAT_PREFERRED = 0x8270,
            GL_INTERNALFORMAT_RED_SIZE = 0x8271,
            GL_INTERNALFORMAT_GREEN_SIZE = 0x8272,
            GL_INTERNALFORMAT_BLUE_SIZE = 0x8273,
            GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274,
            GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275,
            GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276,
            GL_INTERNALFORMAT_SHARED_SIZE = 0x8277,
            GL_INTERNALFORMAT_RED_TYPE = 0x8278,
            GL_INTERNALFORMAT_GREEN_TYPE = 0x8279,
            GL_INTERNALFORMAT_BLUE_TYPE = 0x827A,
            GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B,
            GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C,
            GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D,
            GL_MAX_WIDTH = 0x827E,
            GL_MAX_HEIGHT = 0x827F,
            GL_MAX_DEPTH = 0x8280,
            GL_MAX_LAYERS = 0x8281,
            GL_COLOR_COMPONENTS = 0x8283,
            GL_COLOR_RENDERABLE = 0x8286,
            GL_DEPTH_RENDERABLE = 0x8287,
            GL_STENCIL_RENDERABLE = 0x8288,
            GL_FRAMEBUFFER_RENDERABLE = 0x8289,
            GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A,
            GL_FRAMEBUFFER_BLEND = 0x828B,
            GL_READ_PIXELS = 0x828C,
            GL_READ_PIXELS_FORMAT = 0x828D,
            GL_READ_PIXELS_TYPE = 0x828E,
            GL_TEXTURE_IMAGE_FORMAT = 0x828F,
            GL_TEXTURE_IMAGE_TYPE = 0x8290,
            GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291,
            GL_GET_TEXTURE_IMAGE_TYPE = 0x8292,
            GL_MIPMAP = 0x8293,
            GL_GENERATE_MIPMAP = 0x8191,
            GL_AUTO_GENERATE_MIPMAP = 0x8295,
            GL_COLOR_ENCODING = 0x8296,
            GL_SRGB_READ = 0x8297,
            GL_SRGB_WRITE = 0x8298,
            GL_FILTER = 0x829A,
            GL_VERTEX_TEXTURE = 0x829B,
            GL_TESS_CONTROL_TEXTURE = 0x829C,
            GL_TESS_EVALUATION_TEXTURE = 0x829D,
            GL_GEOMETRY_TEXTURE = 0x829E,
            GL_FRAGMENT_TEXTURE = 0x829F,
            GL_COMPUTE_TEXTURE = 0x82A0,
            GL_TEXTURE_SHADOW = 0x82A1,
            GL_TEXTURE_GATHER = 0x82A2,
            GL_TEXTURE_GATHER_SHADOW = 0x82A3,
            GL_SHADER_IMAGE_LOAD = 0x82A4,
            GL_SHADER_IMAGE_STORE = 0x82A5,
            GL_SHADER_IMAGE_ATOMIC = 0x82A6,
            GL_IMAGE_TEXEL_SIZE = 0x82A7,
            GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8,
            GL_IMAGE_PIXEL_FORMAT = 0x82A9,
            GL_IMAGE_PIXEL_TYPE = 0x82AA,
            GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7,
            GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC,
            GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD,
            GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE,
            GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF,
            GL_TEXTURE_COMPRESSED = 0x86A1,
            GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1,
            GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2,
            GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3,
            GL_CLEAR_BUFFER = 0x82B4,
            GL_TEXTURE_VIEW = 0x82B5,
            GL_VIEW_COMPATIBILITY_CLASS = 0x82B6,
            GL_CLEAR_TEXTURE = 0x9365
        }
        public enum InvalidateFramebufferAttachment : uint
        {
            GL_COLOR_ATTACHMENT0 = 0x8CE0,
            GL_COLOR_ATTACHMENT0_EXT = 0x8CE0,
            GL_COLOR_ATTACHMENT0_NV = 0x8CE0,
            GL_COLOR_ATTACHMENT0_OES = 0x8CE0,
            GL_COLOR_ATTACHMENT1 = 0x8CE1,
            GL_COLOR_ATTACHMENT1_EXT = 0x8CE1,
            GL_COLOR_ATTACHMENT1_NV = 0x8CE1,
            GL_COLOR_ATTACHMENT2 = 0x8CE2,
            GL_COLOR_ATTACHMENT2_EXT = 0x8CE2,
            GL_COLOR_ATTACHMENT2_NV = 0x8CE2,
            GL_COLOR_ATTACHMENT3 = 0x8CE3,
            GL_COLOR_ATTACHMENT3_EXT = 0x8CE3,
            GL_COLOR_ATTACHMENT3_NV = 0x8CE3,
            GL_COLOR_ATTACHMENT4 = 0x8CE4,
            GL_COLOR_ATTACHMENT4_EXT = 0x8CE4,
            GL_COLOR_ATTACHMENT4_NV = 0x8CE4,
            GL_COLOR_ATTACHMENT5 = 0x8CE5,
            GL_COLOR_ATTACHMENT5_EXT = 0x8CE5,
            GL_COLOR_ATTACHMENT5_NV = 0x8CE5,
            GL_COLOR_ATTACHMENT6 = 0x8CE6,
            GL_COLOR_ATTACHMENT6_EXT = 0x8CE6,
            GL_COLOR_ATTACHMENT6_NV = 0x8CE6,
            GL_COLOR_ATTACHMENT7 = 0x8CE7,
            GL_COLOR_ATTACHMENT7_EXT = 0x8CE7,
            GL_COLOR_ATTACHMENT7_NV = 0x8CE7,
            GL_COLOR_ATTACHMENT8 = 0x8CE8,
            GL_COLOR_ATTACHMENT8_EXT = 0x8CE8,
            GL_COLOR_ATTACHMENT8_NV = 0x8CE8,
            GL_COLOR_ATTACHMENT9 = 0x8CE9,
            GL_COLOR_ATTACHMENT9_EXT = 0x8CE9,
            GL_COLOR_ATTACHMENT9_NV = 0x8CE9,
            GL_COLOR_ATTACHMENT10 = 0x8CEA,
            GL_COLOR_ATTACHMENT10_EXT = 0x8CEA,
            GL_COLOR_ATTACHMENT10_NV = 0x8CEA,
            GL_COLOR_ATTACHMENT11 = 0x8CEB,
            GL_COLOR_ATTACHMENT11_EXT = 0x8CEB,
            GL_COLOR_ATTACHMENT11_NV = 0x8CEB,
            GL_COLOR_ATTACHMENT12 = 0x8CEC,
            GL_COLOR_ATTACHMENT12_EXT = 0x8CEC,
            GL_COLOR_ATTACHMENT12_NV = 0x8CEC,
            GL_COLOR_ATTACHMENT13 = 0x8CED,
            GL_COLOR_ATTACHMENT13_EXT = 0x8CED,
            GL_COLOR_ATTACHMENT13_NV = 0x8CED,
            GL_COLOR_ATTACHMENT14 = 0x8CEE,
            GL_COLOR_ATTACHMENT14_EXT = 0x8CEE,
            GL_COLOR_ATTACHMENT14_NV = 0x8CEE,
            GL_COLOR_ATTACHMENT15 = 0x8CEF,
            GL_COLOR_ATTACHMENT15_EXT = 0x8CEF,
            GL_COLOR_ATTACHMENT15_NV = 0x8CEF,
            GL_COLOR_ATTACHMENT16 = 0x8CF0,
            GL_COLOR_ATTACHMENT17 = 0x8CF1,
            GL_COLOR_ATTACHMENT18 = 0x8CF2,
            GL_COLOR_ATTACHMENT19 = 0x8CF3,
            GL_COLOR_ATTACHMENT20 = 0x8CF4,
            GL_COLOR_ATTACHMENT21 = 0x8CF5,
            GL_COLOR_ATTACHMENT22 = 0x8CF6,
            GL_COLOR_ATTACHMENT23 = 0x8CF7,
            GL_COLOR_ATTACHMENT24 = 0x8CF8,
            GL_COLOR_ATTACHMENT25 = 0x8CF9,
            GL_COLOR_ATTACHMENT26 = 0x8CFA,
            GL_COLOR_ATTACHMENT27 = 0x8CFB,
            GL_COLOR_ATTACHMENT28 = 0x8CFC,
            GL_COLOR_ATTACHMENT29 = 0x8CFD,
            GL_COLOR_ATTACHMENT30 = 0x8CFE,
            GL_COLOR_ATTACHMENT31 = 0x8CFF,
            GL_DEPTH_ATTACHMENT = 0x8D00,
            GL_DEPTH_STENCIL_ATTACHMENT = 0x821A,
            GL_DEPTH_ATTACHMENT_EXT = 0x8D00,
            GL_DEPTH_ATTACHMENT_OES = 0x8D00,
            GL_STENCIL = 0x1802,
            GL_STENCIL_ATTACHMENT_EXT = 0x8D20,
            GL_STENCIL_ATTACHMENT_OES = 0x8D20,
            GL_COLOR = 0x1800,
            GL_DEPTH = 0x1801
        }
        public enum LightEnvModeSGIX : uint
        {
            GL_ADD = 0x0104,
            GL_MODULATE = 0x2100,
            GL_REPLACE = 0x1E01
        }
        public enum ListNameType : uint
        {
            GL_2_BYTES = 0x1407,
            GL_3_BYTES = 0x1408,
            GL_4_BYTES = 0x1409,
            GL_BYTE = 0x1400,
            GL_FLOAT = 0x1406,
            GL_INT = 0x1404,
            GL_SHORT = 0x1402,
            GL_UNSIGNED_BYTE = 0x1401,
            GL_UNSIGNED_INT = 0x1405,
            GL_UNSIGNED_SHORT = 0x1403
        }
        public enum LogicOp : uint
        {
            GL_AND = 0x1501,
            GL_AND_INVERTED = 0x1504,
            GL_AND_REVERSE = 0x1502,
            GL_CLEAR = 0x1500,
            GL_COPY = 0x1503,
            GL_COPY_INVERTED = 0x150C,
            GL_EQUIV = 0x1509,
            GL_INVERT = 0x150A,
            GL_NAND = 0x150E,
            GL_NOOP = 0x1505,
            GL_NOR = 0x1508,
            GL_OR = 0x1507,
            GL_OR_INVERTED = 0x150D,
            GL_OR_REVERSE = 0x150B,
            GL_SET = 0x150F,
            GL_XOR = 0x1506
        }
        public enum MapBufferAccessMask : uint
        {
            GL_MAP_COHERENT_BIT = 0x0080,
            GL_MAP_COHERENT_BIT_EXT = 0x0080,
            GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010,
            GL_MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010,
            GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008,
            GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008,
            GL_MAP_INVALIDATE_RANGE_BIT = 0x0004,
            GL_MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004,
            GL_MAP_PERSISTENT_BIT = 0x0040,
            GL_MAP_PERSISTENT_BIT_EXT = 0x0040,
            GL_MAP_READ_BIT = 0x0001,
            GL_MAP_READ_BIT_EXT = 0x0001,
            GL_MAP_UNSYNCHRONIZED_BIT = 0x0020,
            GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020,
            GL_MAP_WRITE_BIT = 0x0002,
            GL_MAP_WRITE_BIT_EXT = 0x0002
        }
        public enum MapTypeNV : uint
        {
            GL_FLOAT = 0x1406,
            GL_DOUBLE = 0x140A
        }
        public enum MaterialFace : uint
        {
            GL_BACK = 0x0405,
            GL_FRONT = 0x0404,
            GL_FRONT_AND_BACK = 0x0408
        }
        public enum MatrixIndexPointerTypeARB : uint
        {
            GL_UNSIGNED_BYTE = 0x1401,
            GL_UNSIGNED_SHORT = 0x1403,
            GL_UNSIGNED_INT = 0x1405
        }
        public enum MatrixMode : uint
        {
            GL_MODELVIEW = 0x1700,
            GL_MODELVIEW0_EXT = 0x1700,
            GL_PROJECTION = 0x1701,
            GL_TEXTURE = 0x1702
        }
        public enum MeshMode1 : uint
        {
            GL_LINE = 0x1B01,
            GL_POINT = 0x1B00
        }
        public enum MeshMode2 : uint
        {
            GL_FILL = 0x1B02,
            GL_LINE = 0x1B01,
            GL_POINT = 0x1B00
        }
        public enum NormalPointerType : uint
        {
            GL_BYTE = 0x1400,
            GL_DOUBLE = 0x140A,
            GL_FLOAT = 0x1406,
            GL_INT = 0x1404,
            GL_SHORT = 0x1402
        }
        public enum ObjectIdentifier : uint
        {
            GL_BUFFER = 0x82E0,
            GL_SHADER = 0x82E1,
            GL_PROGRAM = 0x82E2,
            GL_VERTEX_ARRAY = 0x8074,
            GL_QUERY = 0x82E3,
            GL_PROGRAM_PIPELINE = 0x82E4,
            GL_TRANSFORM_FEEDBACK = 0x8E22,
            GL_SAMPLER = 0x82E6,
            GL_TEXTURE = 0x1702,
            GL_RENDERBUFFER = 0x8D41,
            GL_FRAMEBUFFER = 0x8D40
        }
        public enum PathColorFormat : uint
        {
            GL_NONE = 0,
            GL_LUMINANCE = 0x1909,
            GL_ALPHA = 0x1906,
            GL_INTENSITY = 0x8049,
            GL_LUMINANCE_ALPHA = 0x190A,
            GL_RGB = 0x1907,
            GL_RGBA = 0x1908
        }
        public enum PathFillMode : uint
        {
            GL_INVERT = 0x150A,
            GL_COUNT_UP_NV = 0x9088,
            GL_COUNT_DOWN_NV = 0x9089,
            GL_PATH_FILL_MODE_NV = 0x9080
        }
        public enum PathFontStyle : uint
        {
            GL_NONE = 0,
            GL_BOLD_BIT_NV = 0x01,
            GL_ITALIC_BIT_NV = 0x02
        }
        public enum PathGenMode : uint
        {
            GL_NONE = 0,
            GL_EYE_LINEAR = 0x2400,
            GL_OBJECT_LINEAR = 0x2401,
            GL_PATH_OBJECT_BOUNDING_BOX_NV = 0x908A,
            GL_CONSTANT = 0x8576
        }
        public enum PathTransformType : uint
        {
            GL_NONE = 0,
            GL_TRANSLATE_X_NV = 0x908E,
            GL_TRANSLATE_Y_NV = 0x908F,
            GL_TRANSLATE_2D_NV = 0x9090,
            GL_TRANSLATE_3D_NV = 0x9091,
            GL_AFFINE_2D_NV = 0x9092,
            GL_AFFINE_3D_NV = 0x9094,
            GL_TRANSPOSE_AFFINE_2D_NV = 0x9096,
            GL_TRANSPOSE_AFFINE_3D_NV = 0x9098
        }
        public enum PipelineParameterName : uint
        {
            GL_ACTIVE_PROGRAM = 0x8259,
            GL_VERTEX_SHADER = 0x8B31,
            GL_TESS_CONTROL_SHADER = 0x8E88,
            GL_TESS_EVALUATION_SHADER = 0x8E87,
            GL_GEOMETRY_SHADER = 0x8DD9,
            GL_FRAGMENT_SHADER = 0x8B30,
            GL_INFO_LOG_LENGTH = 0x8B84
        }
        public enum PixelCopyType : uint
        {
            GL_COLOR = 0x1800,
            GL_COLOR_EXT = 0x1800,
            GL_DEPTH = 0x1801,
            GL_DEPTH_EXT = 0x1801,
            GL_STENCIL = 0x1802,
            GL_STENCIL_EXT = 0x1802
        }
        public enum PixelFormat : uint
        {
            GL_ABGR_EXT = 0x8000,
            GL_ALPHA = 0x1906,
            GL_BGR = 0x80E0,
            GL_BGR_INTEGER = 0x8D9A,
            GL_BGRA = 0x80E1,
            GL_BGRA_INTEGER = 0x8D9B,
            GL_BLUE = 0x1905,
            GL_BLUE_INTEGER = 0x8D96,
            GL_CMYKA_EXT = 0x800D,
            GL_CMYK_EXT = 0x800C,
            GL_COLOR_INDEX = 0x1900,
            GL_DEPTH_COMPONENT = 0x1902,
            GL_DEPTH_STENCIL = 0x84F9,
            GL_GREEN = 0x1904,
            GL_GREEN_INTEGER = 0x8D95,
            GL_LUMINANCE = 0x1909,
            GL_LUMINANCE_ALPHA = 0x190A,
            GL_RED = 0x1903,
            GL_RED_EXT = 0x1903,
            GL_RED_INTEGER = 0x8D94,
            GL_RG = 0x8227,
            GL_RG_INTEGER = 0x8228,
            GL_RGB = 0x1907,
            GL_RGB_INTEGER = 0x8D98,
            GL_RGBA = 0x1908,
            GL_RGBA_INTEGER = 0x8D99,
            GL_STENCIL_INDEX = 0x1901,
            GL_UNSIGNED_INT = 0x1405,
            GL_UNSIGNED_SHORT = 0x1403,
            GL_YCRCB_422_SGIX = 0x81BB,
            GL_YCRCB_444_SGIX = 0x81BC
        }
        public enum PixelStoreParameter : uint
        {
            GL_PACK_ALIGNMENT = 0x0D05,
            GL_PACK_IMAGE_DEPTH_SGIS = 0x8131,
            GL_PACK_IMAGE_HEIGHT = 0x806C,
            GL_PACK_IMAGE_HEIGHT_EXT = 0x806C,
            GL_PACK_LSB_FIRST = 0x0D01,
            GL_PACK_RESAMPLE_OML = 0x8984,
            GL_PACK_RESAMPLE_SGIX = 0x842E,
            GL_PACK_ROW_LENGTH = 0x0D02,
            GL_PACK_SKIP_IMAGES = 0x806B,
            GL_PACK_SKIP_IMAGES_EXT = 0x806B,
            GL_PACK_SKIP_PIXELS = 0x0D04,
            GL_PACK_SKIP_ROWS = 0x0D03,
            GL_PACK_SKIP_VOLUMES_SGIS = 0x8130,
            GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0,
            GL_PACK_SWAP_BYTES = 0x0D00,
            GL_PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145,
            GL_PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144,
            GL_PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143,
            GL_PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142,
            GL_PIXEL_TILE_HEIGHT_SGIX = 0x8141,
            GL_PIXEL_TILE_WIDTH_SGIX = 0x8140,
            GL_UNPACK_ALIGNMENT = 0x0CF5,
            GL_UNPACK_IMAGE_DEPTH_SGIS = 0x8133,
            GL_UNPACK_IMAGE_HEIGHT = 0x806E,
            GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E,
            GL_UNPACK_LSB_FIRST = 0x0CF1,
            GL_UNPACK_RESAMPLE_OML = 0x8985,
            GL_UNPACK_RESAMPLE_SGIX = 0x842F,
            GL_UNPACK_ROW_LENGTH = 0x0CF2,
            GL_UNPACK_ROW_LENGTH_EXT = 0x0CF2,
            GL_UNPACK_SKIP_IMAGES = 0x806D,
            GL_UNPACK_SKIP_IMAGES_EXT = 0x806D,
            GL_UNPACK_SKIP_PIXELS = 0x0CF4,
            GL_UNPACK_SKIP_PIXELS_EXT = 0x0CF4,
            GL_UNPACK_SKIP_ROWS = 0x0CF3,
            GL_UNPACK_SKIP_ROWS_EXT = 0x0CF3,
            GL_UNPACK_SKIP_VOLUMES_SGIS = 0x8132,
            GL_UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1,
            GL_UNPACK_SWAP_BYTES = 0x0CF0
        }
        public enum PixelTexGenMode : uint
        {
            GL_LUMINANCE = 0x1909,
            GL_LUMINANCE_ALPHA = 0x190A,
            GL_NONE = 0,
            GL_PIXEL_TEX_GEN_ALPHA_LS_SGIX = 0x8189,
            GL_PIXEL_TEX_GEN_ALPHA_MS_SGIX = 0x818A,
            GL_PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX = 0x8188,
            GL_PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX = 0x8187,
            GL_RGB = 0x1907,
            GL_RGBA = 0x1908
        }
        public enum PixelType : uint
        {
            GL_BITMAP = 0x1A00,
            GL_BYTE = 0x1400,
            GL_FLOAT = 0x1406,
            GL_INT = 0x1404,
            GL_SHORT = 0x1402,
            GL_UNSIGNED_BYTE = 0x1401,
            GL_UNSIGNED_BYTE_3_3_2 = 0x8032,
            GL_UNSIGNED_BYTE_3_3_2_EXT = 0x8032,
            GL_UNSIGNED_INT = 0x1405,
            GL_UNSIGNED_INT_10_10_10_2 = 0x8036,
            GL_UNSIGNED_INT_10_10_10_2_EXT = 0x8036,
            GL_UNSIGNED_INT_8_8_8_8 = 0x8035,
            GL_UNSIGNED_INT_8_8_8_8_EXT = 0x8035,
            GL_UNSIGNED_SHORT = 0x1403,
            GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033,
            GL_UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033,
            GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034,
            GL_UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034
        }
        public enum PointParameterNameARB : uint
        {
            GL_POINT_SIZE_MIN_EXT = 0x8126,
            GL_POINT_SIZE_MAX_EXT = 0x8127,
            GL_POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128,
            GL_POINT_FADE_THRESHOLD_SIZE = 0x8128
        }
        public enum PointParameterNameSGIS : uint
        {
            GL_DISTANCE_ATTENUATION_EXT = 0x8129,
            GL_DISTANCE_ATTENUATION_SGIS = 0x8129,
            GL_POINT_DISTANCE_ATTENUATION = 0x8129,
            GL_POINT_DISTANCE_ATTENUATION_ARB = 0x8129,
            GL_POINT_FADE_THRESHOLD_SIZE = 0x8128,
            GL_POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128,
            GL_POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128,
            GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128,
            GL_POINT_SIZE_MAX = 0x8127,
            GL_POINT_SIZE_MAX_ARB = 0x8127,
            GL_POINT_SIZE_MAX_EXT = 0x8127,
            GL_POINT_SIZE_MAX_SGIS = 0x8127,
            GL_POINT_SIZE_MIN = 0x8126,
            GL_POINT_SIZE_MIN_ARB = 0x8126,
            GL_POINT_SIZE_MIN_EXT = 0x8126,
            GL_POINT_SIZE_MIN_SGIS = 0x8126
        }
        public enum PolygonMode : uint
        {
            GL_FILL = 0x1B02,
            GL_LINE = 0x1B01,
            GL_POINT = 0x1B00
        }
        public enum PrimitiveType : uint
        {
            GL_LINES = 0x0001,
            GL_LINES_ADJACENCY = 0x000A,
            GL_LINES_ADJACENCY_ARB = 0x000A,
            GL_LINES_ADJACENCY_EXT = 0x000A,
            GL_LINE_LOOP = 0x0002,
            GL_LINE_STRIP = 0x0003,
            GL_LINE_STRIP_ADJACENCY = 0x000B,
            GL_LINE_STRIP_ADJACENCY_ARB = 0x000B,
            GL_LINE_STRIP_ADJACENCY_EXT = 0x000B,
            GL_PATCHES = 0x000E,
            GL_PATCHES_EXT = 0x000E,
            GL_POINTS = 0x0000,
            GL_POLYGON = 0x0009,
            GL_QUADS = 0x0007,
            GL_QUADS_EXT = 0x0007,
            GL_QUAD_STRIP = 0x0008,
            GL_TRIANGLES = 0x0004,
            GL_TRIANGLES_ADJACENCY = 0x000C,
            GL_TRIANGLES_ADJACENCY_ARB = 0x000C,
            GL_TRIANGLES_ADJACENCY_EXT = 0x000C,
            GL_TRIANGLE_FAN = 0x0006,
            GL_TRIANGLE_STRIP = 0x0005,
            GL_TRIANGLE_STRIP_ADJACENCY = 0x000D,
            GL_TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D,
            GL_TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D
        }
        public enum ProgramInterface : uint
        {
            GL_UNIFORM = 0x92E1,
            GL_UNIFORM_BLOCK = 0x92E2,
            GL_PROGRAM_INPUT = 0x92E3,
            GL_PROGRAM_OUTPUT = 0x92E4,
            GL_VERTEX_SUBROUTINE = 0x92E8,
            GL_TESS_CONTROL_SUBROUTINE = 0x92E9,
            GL_TESS_EVALUATION_SUBROUTINE = 0x92EA,
            GL_GEOMETRY_SUBROUTINE = 0x92EB,
            GL_FRAGMENT_SUBROUTINE = 0x92EC,
            GL_COMPUTE_SUBROUTINE = 0x92ED,
            GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE,
            GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF,
            GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0,
            GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1,
            GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2,
            GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3,
            GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4,
            GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E,
            GL_BUFFER_VARIABLE = 0x92E5,
            GL_SHADER_STORAGE_BLOCK = 0x92E6
        }
        public enum ProgramPropertyARB : uint
        {
            GL_DELETE_STATUS = 0x8B80,
            GL_LINK_STATUS = 0x8B82,
            GL_VALIDATE_STATUS = 0x8B83,
            GL_INFO_LOG_LENGTH = 0x8B84,
            GL_ATTACHED_SHADERS = 0x8B85,
            GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9,
            GL_ACTIVE_ATTRIBUTES = 0x8B89,
            GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A,
            GL_ACTIVE_UNIFORMS = 0x8B86,
            GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36,
            GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35,
            GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87,
            GL_COMPUTE_WORK_GROUP_SIZE = 0x8267,
            GL_PROGRAM_BINARY_LENGTH = 0x8741,
            GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F,
            GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83,
            GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76,
            GL_GEOMETRY_VERTICES_OUT = 0x8916,
            GL_GEOMETRY_INPUT_TYPE = 0x8917,
            GL_GEOMETRY_OUTPUT_TYPE = 0x8918
        }
        public enum QueryCounterTarget : uint
        {
            GL_TIMESTAMP = 0x8E28
        }
        public enum QueryObjectParameterName : uint
        {
            GL_QUERY_RESULT_AVAILABLE = 0x8867,
            GL_QUERY_RESULT = 0x8866,
            GL_QUERY_RESULT_NO_WAIT = 0x9194,
            GL_QUERY_TARGET = 0x82EA
        }
        public enum QueryParameterName : uint
        {
            GL_CURRENT_QUERY = 0x8865,
            GL_QUERY_COUNTER_BITS = 0x8864
        }
        public enum QueryTarget : uint
        {
            GL_SAMPLES_PASSED = 0x8914,
            GL_ANY_SAMPLES_PASSED = 0x8C2F,
            GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A,
            GL_PRIMITIVES_GENERATED = 0x8C87,
            GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88,
            GL_TIME_ELAPSED = 0x88BF,
            GL_TRANSFORM_FEEDBACK_OVERFLOW = 0x82EC,
            GL_VERTICES_SUBMITTED = 0x82EE,
            GL_PRIMITIVES_SUBMITTED = 0x82EF,
            GL_VERTEX_SHADER_INVOCATIONS = 0x82F0
        }
        public enum ReadBufferMode : uint
        {
            GL_NONE = 0,
            GL_NONE_OES = 0,
            GL_AUX0 = 0x0409,
            GL_AUX1 = 0x040A,
            GL_AUX2 = 0x040B,
            GL_AUX3 = 0x040C,
            GL_BACK = 0x0405,
            GL_BACK_LEFT = 0x0402,
            GL_BACK_RIGHT = 0x0403,
            GL_FRONT = 0x0404,
            GL_FRONT_LEFT = 0x0400,
            GL_FRONT_RIGHT = 0x0401,
            GL_LEFT = 0x0406,
            GL_RIGHT = 0x0407,
            GL_COLOR_ATTACHMENT0 = 0x8CE0,
            GL_COLOR_ATTACHMENT1 = 0x8CE1,
            GL_COLOR_ATTACHMENT2 = 0x8CE2,
            GL_COLOR_ATTACHMENT3 = 0x8CE3,
            GL_COLOR_ATTACHMENT4 = 0x8CE4,
            GL_COLOR_ATTACHMENT5 = 0x8CE5,
            GL_COLOR_ATTACHMENT6 = 0x8CE6,
            GL_COLOR_ATTACHMENT7 = 0x8CE7,
            GL_COLOR_ATTACHMENT8 = 0x8CE8,
            GL_COLOR_ATTACHMENT9 = 0x8CE9,
            GL_COLOR_ATTACHMENT10 = 0x8CEA,
            GL_COLOR_ATTACHMENT11 = 0x8CEB,
            GL_COLOR_ATTACHMENT12 = 0x8CEC,
            GL_COLOR_ATTACHMENT13 = 0x8CED,
            GL_COLOR_ATTACHMENT14 = 0x8CEE,
            GL_COLOR_ATTACHMENT15 = 0x8CEF
        }
        public enum RenderbufferParameterName : uint
        {
            GL_RENDERBUFFER_WIDTH = 0x8D42,
            GL_RENDERBUFFER_WIDTH_EXT = 0x8D42,
            GL_RENDERBUFFER_WIDTH_OES = 0x8D42,
            GL_RENDERBUFFER_HEIGHT = 0x8D43,
            GL_RENDERBUFFER_HEIGHT_EXT = 0x8D43,
            GL_RENDERBUFFER_HEIGHT_OES = 0x8D43,
            GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44,
            GL_RENDERBUFFER_INTERNAL_FORMAT_EXT = 0x8D44,
            GL_RENDERBUFFER_INTERNAL_FORMAT_OES = 0x8D44,
            GL_RENDERBUFFER_SAMPLES = 0x8CAB,
            GL_RENDERBUFFER_SAMPLES_ANGLE = 0x8CAB,
            GL_RENDERBUFFER_SAMPLES_APPLE = 0x8CAB,
            GL_RENDERBUFFER_SAMPLES_EXT = 0x8CAB,
            GL_RENDERBUFFER_SAMPLES_IMG = 0x9133,
            GL_RENDERBUFFER_SAMPLES_NV = 0x8CAB,
            GL_RENDERBUFFER_RED_SIZE = 0x8D50,
            GL_RENDERBUFFER_RED_SIZE_EXT = 0x8D50,
            GL_RENDERBUFFER_RED_SIZE_OES = 0x8D50,
            GL_RENDERBUFFER_GREEN_SIZE = 0x8D51,
            GL_RENDERBUFFER_GREEN_SIZE_EXT = 0x8D51,
            GL_RENDERBUFFER_GREEN_SIZE_OES = 0x8D51,
            GL_RENDERBUFFER_BLUE_SIZE = 0x8D52,
            GL_RENDERBUFFER_BLUE_SIZE_EXT = 0x8D52,
            GL_RENDERBUFFER_BLUE_SIZE_OES = 0x8D52,
            GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53,
            GL_RENDERBUFFER_ALPHA_SIZE_EXT = 0x8D53,
            GL_RENDERBUFFER_ALPHA_SIZE_OES = 0x8D53,
            GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54,
            GL_RENDERBUFFER_DEPTH_SIZE_EXT = 0x8D54,
            GL_RENDERBUFFER_DEPTH_SIZE_OES = 0x8D54,
            GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55,
            GL_RENDERBUFFER_STENCIL_SIZE_EXT = 0x8D55,
            GL_RENDERBUFFER_STENCIL_SIZE_OES = 0x8D55,
            GL_RENDERBUFFER_STORAGE_SAMPLES_AMD = 0x91B2,
            GL_RENDERBUFFER_COVERAGE_SAMPLES_NV = 0x8CAB,
            GL_RENDERBUFFER_COLOR_SAMPLES_NV = 0x8E10
        }
        public enum RenderbufferTarget : uint
        {
            GL_RENDERBUFFER = 0x8D41,
            GL_RENDERBUFFER_OES = 0x8D41
        }
        public enum ReplacementCodeTypeSUN : uint
        {
            GL_UNSIGNED_BYTE = 0x1401,
            GL_UNSIGNED_SHORT = 0x1403,
            GL_UNSIGNED_INT = 0x1405
        }
        public enum SamplerParameterF : uint
        {
            GL_TEXTURE_BORDER_COLOR = 0x1004,
            GL_TEXTURE_MIN_LOD = 0x813A,
            GL_TEXTURE_MAX_LOD = 0x813B,
            GL_TEXTURE_MAX_ANISOTROPY = 0x84FE
        }
        public enum SamplerParameterI : uint
        {
            GL_TEXTURE_WRAP_S = 0x2802,
            GL_TEXTURE_WRAP_T = 0x2803,
            GL_TEXTURE_WRAP_R = 0x8072,
            GL_TEXTURE_MIN_FILTER = 0x2801,
            GL_TEXTURE_MAG_FILTER = 0x2800,
            GL_TEXTURE_COMPARE_MODE = 0x884C,
            GL_TEXTURE_COMPARE_FUNC = 0x884D
        }
        public enum ScalarType : uint
        {
            GL_UNSIGNED_BYTE = 0x1401,
            GL_UNSIGNED_SHORT = 0x1403,
            GL_UNSIGNED_INT = 0x1405
        }
        public enum SecondaryColorPointerTypeIBM : uint
        {
            GL_SHORT = 0x1402,
            GL_INT = 0x1404,
            GL_FLOAT = 0x1406,
            GL_DOUBLE = 0x140A
        }
        public enum ShaderParameterName : uint
        {
            GL_SHADER_TYPE = 0x8B4F,
            GL_DELETE_STATUS = 0x8B80,
            GL_COMPILE_STATUS = 0x8B81,
            GL_INFO_LOG_LENGTH = 0x8B84,
            GL_SHADER_SOURCE_LENGTH = 0x8B88
        }
        public enum ShaderType : uint
        {
            GL_COMPUTE_SHADER = 0x91B9,
            GL_VERTEX_SHADER = 0x8B31,
            GL_TESS_CONTROL_SHADER = 0x8E88,
            GL_TESS_EVALUATION_SHADER = 0x8E87,
            GL_GEOMETRY_SHADER = 0x8DD9,
            GL_FRAGMENT_SHADER = 0x8B30,
            GL_FRAGMENT_SHADER_ARB = 0x8B30,
            GL_VERTEX_SHADER_ARB = 0x8B31
        }
        public enum StencilFaceDirection : uint
        {
            GL_FRONT = 0x0404,
            GL_BACK = 0x0405,
            GL_FRONT_AND_BACK = 0x0408
        }
        public enum StencilFunction : uint
        {
            GL_ALWAYS = 0x0207,
            GL_EQUAL = 0x0202,
            GL_GEQUAL = 0x0206,
            GL_GREATER = 0x0204,
            GL_LEQUAL = 0x0203,
            GL_LESS = 0x0201,
            GL_NEVER = 0x0200,
            GL_NOTEQUAL = 0x0205
        }
        public enum StencilOp : uint
        {
            GL_DECR = 0x1E03,
            GL_DECR_WRAP = 0x8508,
            GL_INCR = 0x1E02,
            GL_INCR_WRAP = 0x8507,
            GL_INVERT = 0x150A,
            GL_KEEP = 0x1E00,
            GL_REPLACE = 0x1E01,
            GL_ZERO = 0
        }
        public enum StringName : uint
        {
            GL_EXTENSIONS = 0x1F03,
            GL_RENDERER = 0x1F01,
            GL_VENDOR = 0x1F00,
            GL_VERSION = 0x1F02,
            GL_SHADING_LANGUAGE_VERSION = 0x8B8C
        }
        public enum SubroutineParameterName : uint
        {
            GL_NUM_COMPATIBLE_SUBROUTINES = 0x8E4A,
            GL_COMPATIBLE_SUBROUTINES = 0x8E4B,
            GL_UNIFORM_SIZE = 0x8A38,
            GL_UNIFORM_NAME_LENGTH = 0x8A39
        }
        public enum SyncCondition : uint
        {
            GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117
        }
        public enum SyncObjectMask : uint
        {
            GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001,
            GL_SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001
        }
        public enum SyncParameterName : uint
        {
            GL_OBJECT_TYPE = 0x9112,
            GL_SYNC_STATUS = 0x9114,
            GL_SYNC_CONDITION = 0x9113,
            GL_SYNC_FLAGS = 0x9115
        }
        public enum SyncStatus : uint
        {
            GL_ALREADY_SIGNALED = 0x911A,
            GL_TIMEOUT_EXPIRED = 0x911B,
            GL_CONDITION_SATISFIED = 0x911C,
            GL_WAIT_FAILED = 0x911D
        }
        public enum TangentPointerTypeEXT : uint
        {
            GL_BYTE = 0x1400,
            GL_SHORT = 0x1402,
            GL_INT = 0x1404,
            GL_FLOAT = 0x1406,
            GL_DOUBLE = 0x140A,
            GL_DOUBLE_EXT = 0x140A
        }
        public enum TexCoordPointerType : uint
        {
            GL_DOUBLE = 0x140A,
            GL_FLOAT = 0x1406,
            GL_INT = 0x1404,
            GL_SHORT = 0x1402
        }
        public enum TextureCompareMode : uint
        {
            GL_NONE = 0,
            GL_COMPARE_REF_TO_TEXTURE = 0x884E,
            GL_COMPARE_R_TO_TEXTURE = 0x884E
        }
        public enum TextureEnvMode : uint
        {
            GL_ADD = 0x0104,
            GL_BLEND = 0x0BE2,
            GL_DECAL = 0x2101,
            GL_MODULATE = 0x2100,
            GL_REPLACE_EXT = 0x8062,
            GL_TEXTURE_ENV_BIAS_SGIX = 0x80BE
        }
        public enum TextureMagFilter : uint
        {
            GL_FILTER4_SGIS = 0x8146,
            GL_LINEAR = 0x2601,
            GL_LINEAR_DETAIL_ALPHA_SGIS = 0x8098,
            GL_LINEAR_DETAIL_COLOR_SGIS = 0x8099,
            GL_LINEAR_DETAIL_SGIS = 0x8097,
            GL_LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE,
            GL_LINEAR_SHARPEN_COLOR_SGIS = 0x80AF,
            GL_LINEAR_SHARPEN_SGIS = 0x80AD,
            GL_NEAREST = 0x2600,
            GL_PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184,
            GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186,
            GL_PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185
        }
        public enum TextureMinFilter : uint
        {
            GL_FILTER4_SGIS = 0x8146,
            GL_LINEAR = 0x2601,
            GL_LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170,
            GL_LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F,
            GL_LINEAR_MIPMAP_LINEAR = 0x2703,
            GL_LINEAR_MIPMAP_NEAREST = 0x2701,
            GL_NEAREST = 0x2600,
            GL_NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E,
            GL_NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D,
            GL_NEAREST_MIPMAP_LINEAR = 0x2702,
            GL_NEAREST_MIPMAP_NEAREST = 0x2700,
            GL_PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184,
            GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186,
            GL_PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185
        }
        public enum TextureParameterName : uint
        {
            GL_DETAIL_TEXTURE_LEVEL_SGIS = 0x809A,
            GL_DETAIL_TEXTURE_MODE_SGIS = 0x809B,
            GL_DUAL_TEXTURE_SELECT_SGIS = 0x8124,
            GL_GENERATE_MIPMAP = 0x8191,
            GL_GENERATE_MIPMAP_SGIS = 0x8191,
            GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179,
            GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A,
            GL_QUAD_TEXTURE_SELECT_SGIS = 0x8125,
            GL_SHADOW_AMBIENT_SGIX = 0x80BF,
            GL_TEXTURE_BORDER_COLOR = 0x1004,
            GL_TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171,
            GL_TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176,
            GL_TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172,
            GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175,
            GL_TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173,
            GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174,
            GL_TEXTURE_COMPARE_SGIX = 0x819A,
            GL_TEXTURE_LOD_BIAS_R_SGIX = 0x8190,
            GL_TEXTURE_LOD_BIAS_S_SGIX = 0x818E,
            GL_TEXTURE_LOD_BIAS_T_SGIX = 0x818F,
            GL_TEXTURE_MAG_FILTER = 0x2800,
            GL_TEXTURE_MAX_CLAMP_R_SGIX = 0x836B,
            GL_TEXTURE_MAX_CLAMP_S_SGIX = 0x8369,
            GL_TEXTURE_MAX_CLAMP_T_SGIX = 0x836A,
            GL_TEXTURE_MIN_FILTER = 0x2801,
            GL_TEXTURE_PRIORITY = 0x8066,
            GL_TEXTURE_PRIORITY_EXT = 0x8066,
            GL_TEXTURE_WRAP_Q_SGIS = 0x8137,
            GL_TEXTURE_WRAP_R = 0x8072,
            GL_TEXTURE_WRAP_R_EXT = 0x8072,
            GL_TEXTURE_WRAP_R_OES = 0x8072,
            GL_TEXTURE_WRAP_S = 0x2802,
            GL_TEXTURE_WRAP_T = 0x2803,
            GL_TEXTURE_BASE_LEVEL = 0x813C,
            GL_TEXTURE_COMPARE_MODE = 0x884C,
            GL_TEXTURE_COMPARE_FUNC = 0x884D,
            GL_TEXTURE_LOD_BIAS = 0x8501,
            GL_TEXTURE_MIN_LOD = 0x813A,
            GL_TEXTURE_MAX_LOD = 0x813B,
            GL_TEXTURE_MAX_LEVEL = 0x813D,
            GL_TEXTURE_SWIZZLE_R = 0x8E42,
            GL_TEXTURE_SWIZZLE_G = 0x8E43,
            GL_TEXTURE_SWIZZLE_B = 0x8E44,
            GL_TEXTURE_SWIZZLE_A = 0x8E45,
            GL_TEXTURE_SWIZZLE_RGBA = 0x8E46,
            GL_TEXTURE_TILING_EXT = 0x9580,
            GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA,
            GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C,
            GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0,
            GL_TEXTURE_4DSIZE_SGIS = 0x8136,
            GL_TEXTURE_ALPHA_SIZE = 0x805F,
            GL_TEXTURE_BASE_LEVEL_SGIS = 0x813C,
            GL_TEXTURE_BLUE_SIZE = 0x805E,
            GL_TEXTURE_BORDER = 0x1005,
            GL_TEXTURE_BORDER_COLOR_NV = 0x1004,
            GL_TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B,
            GL_TEXTURE_COMPONENTS = 0x1003,
            GL_TEXTURE_DEPTH_EXT = 0x8071,
            GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147,
            GL_TEXTURE_GEQUAL_R_SGIX = 0x819D,
            GL_TEXTURE_GREEN_SIZE = 0x805D,
            GL_TEXTURE_HEIGHT = 0x1001,
            GL_TEXTURE_INTENSITY_SIZE = 0x8061,
            GL_TEXTURE_INTERNAL_FORMAT = 0x1003,
            GL_TEXTURE_LEQUAL_R_SGIX = 0x819C,
            GL_TEXTURE_LUMINANCE_SIZE = 0x8060,
            GL_TEXTURE_MAX_LEVEL_SGIS = 0x813D,
            GL_TEXTURE_MAX_LOD_SGIS = 0x813B,
            GL_TEXTURE_MIN_LOD_SGIS = 0x813A,
            GL_TEXTURE_RED_SIZE = 0x805C,
            GL_TEXTURE_RESIDENT = 0x8067,
            GL_TEXTURE_WIDTH = 0x1000
        }
        public enum TextureSwizzle : uint
        {
            GL_RED = 0x1903,
            GL_GREEN = 0x1904,
            GL_BLUE = 0x1905,
            GL_ALPHA = 0x1906,
            GL_ZERO = 0,
            GL_ONE = 1
        }
        public enum TextureTarget : uint
        {
            GL_DETAIL_TEXTURE_2D_SGIS = 0x8095,
            GL_PROXY_TEXTURE_1D = 0x8063,
            GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19,
            GL_PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19,
            GL_PROXY_TEXTURE_1D_EXT = 0x8063,
            GL_PROXY_TEXTURE_2D = 0x8064,
            GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B,
            GL_PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B,
            GL_PROXY_TEXTURE_2D_EXT = 0x8064,
            GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101,
            GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103,
            GL_PROXY_TEXTURE_3D = 0x8070,
            GL_PROXY_TEXTURE_3D_EXT = 0x8070,
            GL_PROXY_TEXTURE_4D_SGIS = 0x8135,
            GL_PROXY_TEXTURE_CUBE_MAP = 0x851B,
            GL_PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B,
            GL_PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B,
            GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B,
            GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B,
            GL_PROXY_TEXTURE_RECTANGLE = 0x84F7,
            GL_PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7,
            GL_PROXY_TEXTURE_RECTANGLE_NV = 0x84F7,
            GL_TEXTURE_1D = 0x0DE0,
            GL_TEXTURE_2D = 0x0DE1,
            GL_TEXTURE_3D = 0x806F,
            GL_TEXTURE_3D_EXT = 0x806F,
            GL_TEXTURE_3D_OES = 0x806F,
            GL_TEXTURE_4D_SGIS = 0x8134,
            GL_TEXTURE_RECTANGLE = 0x84F5,
            GL_TEXTURE_CUBE_MAP = 0x8513,
            GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515,
            GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516,
            GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517,
            GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518,
            GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519,
            GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A,
            GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009,
            GL_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009,
            GL_TEXTURE_CUBE_MAP_ARRAY_EXT = 0x9009,
            GL_TEXTURE_CUBE_MAP_ARRAY_OES = 0x9009,
            GL_TEXTURE_1D_ARRAY = 0x8C18,
            GL_TEXTURE_2D_ARRAY = 0x8C1A,
            GL_TEXTURE_2D_MULTISAMPLE = 0x9100,
            GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102
        }
        public enum TextureUnit : uint
        {
            GL_TEXTURE0 = 0x84C0,
            GL_TEXTURE1 = 0x84C1,
            GL_TEXTURE2 = 0x84C2,
            GL_TEXTURE3 = 0x84C3,
            GL_TEXTURE4 = 0x84C4,
            GL_TEXTURE5 = 0x84C5,
            GL_TEXTURE6 = 0x84C6,
            GL_TEXTURE7 = 0x84C7,
            GL_TEXTURE8 = 0x84C8,
            GL_TEXTURE9 = 0x84C9,
            GL_TEXTURE10 = 0x84CA,
            GL_TEXTURE11 = 0x84CB,
            GL_TEXTURE12 = 0x84CC,
            GL_TEXTURE13 = 0x84CD,
            GL_TEXTURE14 = 0x84CE,
            GL_TEXTURE15 = 0x84CF,
            GL_TEXTURE16 = 0x84D0,
            GL_TEXTURE17 = 0x84D1,
            GL_TEXTURE18 = 0x84D2,
            GL_TEXTURE19 = 0x84D3,
            GL_TEXTURE20 = 0x84D4,
            GL_TEXTURE21 = 0x84D5,
            GL_TEXTURE22 = 0x84D6,
            GL_TEXTURE23 = 0x84D7,
            GL_TEXTURE24 = 0x84D8,
            GL_TEXTURE25 = 0x84D9,
            GL_TEXTURE26 = 0x84DA,
            GL_TEXTURE27 = 0x84DB,
            GL_TEXTURE28 = 0x84DC,
            GL_TEXTURE29 = 0x84DD,
            GL_TEXTURE30 = 0x84DE,
            GL_TEXTURE31 = 0x84DF
        }
        public enum TextureWrapMode : uint
        {
            GL_CLAMP = 0x2900,
            GL_CLAMP_TO_BORDER = 0x812D,
            GL_CLAMP_TO_BORDER_ARB = 0x812D,
            GL_CLAMP_TO_BORDER_NV = 0x812D,
            GL_CLAMP_TO_BORDER_SGIS = 0x812D,
            GL_CLAMP_TO_EDGE = 0x812F,
            GL_CLAMP_TO_EDGE_SGIS = 0x812F,
            GL_REPEAT = 0x2901,
            GL_LINEAR_MIPMAP_LINEAR = 0x2703,
            GL_MIRRORED_REPEAT = 0x8370
        }
        public enum TransformFeedbackBufferMode : uint
        {
            GL_INTERLEAVED_ATTRIBS = 0x8C8C,
            GL_SEPARATE_ATTRIBS = 0x8C8D
        }
        public enum TransformFeedbackPName : uint
        {
            GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F,
            GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84,
            GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85,
            GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23,
            GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24
        }
        public enum UniformBlockPName : uint
        {
            GL_UNIFORM_BLOCK_BINDING = 0x8A3F,
            GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40,
            GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41,
            GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42,
            GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43,
            GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44,
            GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0,
            GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1,
            GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45,
            GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46,
            GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC
        }
        public enum UniformPName : uint
        {
            GL_UNIFORM_TYPE = 0x8A37,
            GL_UNIFORM_SIZE = 0x8A38,
            GL_UNIFORM_NAME_LENGTH = 0x8A39,
            GL_UNIFORM_BLOCK_INDEX = 0x8A3A,
            GL_UNIFORM_OFFSET = 0x8A3B,
            GL_UNIFORM_ARRAY_STRIDE = 0x8A3C,
            GL_UNIFORM_MATRIX_STRIDE = 0x8A3D,
            GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E,
            GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA
        }
        public enum UniformType : uint
        {
            GL_INT = 0x1404,
            GL_UNSIGNED_INT = 0x1405,
            GL_FLOAT = 0x1406,
            GL_DOUBLE = 0x140A,
            GL_FLOAT_VEC2 = 0x8B50,
            GL_FLOAT_VEC3 = 0x8B51,
            GL_FLOAT_VEC4 = 0x8B52,
            GL_INT_VEC2 = 0x8B53,
            GL_INT_VEC3 = 0x8B54,
            GL_INT_VEC4 = 0x8B55,
            GL_BOOL = 0x8B56,
            GL_BOOL_VEC2 = 0x8B57,
            GL_BOOL_VEC3 = 0x8B58,
            GL_BOOL_VEC4 = 0x8B59,
            GL_FLOAT_MAT2 = 0x8B5A,
            GL_FLOAT_MAT3 = 0x8B5B,
            GL_FLOAT_MAT4 = 0x8B5C,
            GL_SAMPLER_1D = 0x8B5D,
            GL_SAMPLER_2D = 0x8B5E,
            GL_SAMPLER_3D = 0x8B5F,
            GL_SAMPLER_CUBE = 0x8B60,
            GL_SAMPLER_1D_SHADOW = 0x8B61,
            GL_SAMPLER_2D_SHADOW = 0x8B62,
            GL_SAMPLER_2D_RECT = 0x8B63,
            GL_SAMPLER_2D_RECT_SHADOW = 0x8B64,
            GL_FLOAT_MAT2x3 = 0x8B65,
            GL_FLOAT_MAT2x4 = 0x8B66,
            GL_FLOAT_MAT3x2 = 0x8B67,
            GL_FLOAT_MAT3x4 = 0x8B68,
            GL_FLOAT_MAT4x2 = 0x8B69,
            GL_FLOAT_MAT4x3 = 0x8B6A,
            GL_SAMPLER_1D_ARRAY = 0x8DC0,
            GL_SAMPLER_2D_ARRAY = 0x8DC1,
            GL_SAMPLER_BUFFER = 0x8DC2,
            GL_SAMPLER_1D_ARRAY_SHADOW = 0x8DC3,
            GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4,
            GL_SAMPLER_CUBE_SHADOW = 0x8DC5,
            GL_UNSIGNED_INT_VEC2 = 0x8DC6,
            GL_UNSIGNED_INT_VEC3 = 0x8DC7,
            GL_UNSIGNED_INT_VEC4 = 0x8DC8,
            GL_INT_SAMPLER_1D = 0x8DC9,
            GL_INT_SAMPLER_2D = 0x8DCA,
            GL_INT_SAMPLER_3D = 0x8DCB,
            GL_INT_SAMPLER_CUBE = 0x8DCC,
            GL_INT_SAMPLER_2D_RECT = 0x8DCD,
            GL_INT_SAMPLER_1D_ARRAY = 0x8DCE,
            GL_INT_SAMPLER_2D_ARRAY = 0x8DCF,
            GL_INT_SAMPLER_BUFFER = 0x8DD0,
            GL_UNSIGNED_INT_SAMPLER_1D = 0x8DD1,
            GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2,
            GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3,
            GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4,
            GL_UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5,
            GL_UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6,
            GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7,
            GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8,
            GL_DOUBLE_MAT2 = 0x8F46,
            GL_DOUBLE_MAT3 = 0x8F47,
            GL_DOUBLE_MAT4 = 0x8F48,
            GL_DOUBLE_MAT2x3 = 0x8F49,
            GL_DOUBLE_MAT2x4 = 0x8F4A,
            GL_DOUBLE_MAT3x2 = 0x8F4B,
            GL_DOUBLE_MAT3x4 = 0x8F4C,
            GL_DOUBLE_MAT4x2 = 0x8F4D,
            GL_DOUBLE_MAT4x3 = 0x8F4E,
            GL_DOUBLE_VEC2 = 0x8FFC,
            GL_DOUBLE_VEC3 = 0x8FFD,
            GL_DOUBLE_VEC4 = 0x8FFE,
            GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C,
            GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D,
            GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E,
            GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F,
            GL_SAMPLER_2D_MULTISAMPLE = 0x9108,
            GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109,
            GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A,
            GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B,
            GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C,
            GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D
        }
        public enum VertexArrayPName : uint
        {
            GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622,
            GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623,
            GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624,
            GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625,
            GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A,
            GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD,
            GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E,
            GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE,
            GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5
        }
        public enum VertexAttribEnum : uint
        {
            GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F,
            GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622,
            GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623,
            GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624,
            GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625,
            GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A,
            GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD,
            GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE,
            GL_CURRENT_VERTEX_ATTRIB = 0x8626
        }
        public enum VertexAttribIType : uint
        {
            GL_BYTE = 0x1400,
            GL_UNSIGNED_BYTE = 0x1401,
            GL_SHORT = 0x1402,
            GL_UNSIGNED_SHORT = 0x1403,
            GL_INT = 0x1404,
            GL_UNSIGNED_INT = 0x1405
        }
        public enum VertexAttribLType : uint
        {
            GL_DOUBLE = 0x140A
        }
        public enum VertexAttribPointerPropertyARB : uint
        {
            GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB = 0x8645,
            GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645
        }
        public enum VertexAttribPointerType : uint
        {
            GL_BYTE = 0x1400,
            GL_UNSIGNED_BYTE = 0x1401,
            GL_SHORT = 0x1402,
            GL_UNSIGNED_SHORT = 0x1403,
            GL_INT = 0x1404,
            GL_UNSIGNED_INT = 0x1405,
            GL_FLOAT = 0x1406,
            GL_DOUBLE = 0x140A,
            GL_HALF_FLOAT = 0x140B,
            GL_FIXED = 0x140C,
            GL_INT_2_10_10_10_REV = 0x8D9F,
            GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368,
            GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B,
            GL_INT64_ARB = 0x140E,
            GL_INT64_NV = 0x140E,
            GL_UNSIGNED_INT64_ARB = 0x140F,
            GL_UNSIGNED_INT64_NV = 0x140F
        }
        public enum VertexAttribPropertyARB : uint
        {
            GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F,
            GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622,
            GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623,
            GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624,
            GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625,
            GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A,
            GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD,
            GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E,
            GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE,
            GL_VERTEX_ATTRIB_BINDING = 0x82D4,
            GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5,
            GL_CURRENT_VERTEX_ATTRIB = 0x8626,
            GL_VERTEX_ATTRIB_ARRAY_INTEGER_EXT = 0x88FD
        }
        public enum VertexAttribType : uint
        {
            GL_BYTE = 0x1400,
            GL_SHORT = 0x1402,
            GL_INT = 0x1404,
            GL_FIXED = 0x140C,
            GL_FLOAT = 0x1406,
            GL_HALF_FLOAT = 0x140B,
            GL_DOUBLE = 0x140A,
            GL_UNSIGNED_BYTE = 0x1401,
            GL_UNSIGNED_SHORT = 0x1403,
            GL_UNSIGNED_INT = 0x1405,
            GL_INT_2_10_10_10_REV = 0x8D9F,
            GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368,
            GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        }
        public enum VertexBufferObjectParameter : uint
        {
            GL_BUFFER_ACCESS = 0x88BB,
            GL_BUFFER_ACCESS_FLAGS = 0x911F,
            GL_BUFFER_IMMUTABLE_STORAGE = 0x821F,
            GL_BUFFER_MAPPED = 0x88BC,
            GL_BUFFER_MAP_LENGTH = 0x9120,
            GL_BUFFER_MAP_OFFSET = 0x9121,
            GL_BUFFER_SIZE = 0x8764,
            GL_BUFFER_STORAGE_FLAGS = 0x8220,
            GL_BUFFER_USAGE = 0x8765
        }
        public enum VertexBufferObjectUsage : uint
        {
            GL_STREAM_DRAW = 0x88E0,
            GL_STREAM_READ = 0x88E1,
            GL_STREAM_COPY = 0x88E2,
            GL_STATIC_DRAW = 0x88E4,
            GL_STATIC_READ = 0x88E5,
            GL_STATIC_COPY = 0x88E6,
            GL_DYNAMIC_DRAW = 0x88E8,
            GL_DYNAMIC_READ = 0x88E9,
            GL_DYNAMIC_COPY = 0x88EA
        }
        public enum VertexPointerType : uint
        {
            GL_DOUBLE = 0x140A,
            GL_FLOAT = 0x1406,
            GL_INT = 0x1404,
            GL_SHORT = 0x1402
        }
        public enum VertexProvokingMode : uint
        {
            GL_FIRST_VERTEX_CONVENTION = 0x8E4D,
            GL_LAST_VERTEX_CONVENTION = 0x8E4E
        }
        public enum VertexShaderWriteMaskEXT : uint
        {
            GL_TRUE = 1,
            GL_FALSE = 0
        }
        public enum VertexWeightPointerTypeEXT : uint
        {
            GL_FLOAT = 0x1406
        }
        public enum WeightPointerTypeARB : uint
        {
            GL_BYTE = 0x1400,
            GL_UNSIGNED_BYTE = 0x1401,
            GL_SHORT = 0x1402,
            GL_UNSIGNED_SHORT = 0x1403,
            GL_INT = 0x1404,
            GL_UNSIGNED_INT = 0x1405,
            GL_FLOAT = 0x1406,
            GL_DOUBLE = 0x140A
        }
        [DllImport("opengl32.dll")] public static extern void glBindTexture(TextureTarget target, uint texture);
        [DllImport("opengl32.dll")] public static extern void glBlendFunc(BlendingFactor sfactor, BlendingFactor dfactor);
        [DllImport("opengl32.dll")] public static extern void glClear(ClearBufferMask mask);
        [DllImport("opengl32.dll")] public static extern void glClearColor(float red, float green, float blue, float alpha);
        [DllImport("opengl32.dll")] public static extern void glClearDepth(double depth);
        [DllImport("opengl32.dll")] public static extern void glClearStencil(int s);
        [DllImport("opengl32.dll")] public static extern void glColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha);
        [DllImport("opengl32.dll")] public static extern void glCopyTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int border);
        [DllImport("opengl32.dll")] public static extern void glCopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border);
        [DllImport("opengl32.dll")] public static extern void glCopyTexSubImage1D(TextureTarget target, int level, int xoffset, int x, int y, int width);
        [DllImport("opengl32.dll")] public static extern void glCopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        [DllImport("opengl32.dll")] public static extern void glCullFace(CullFaceMode mode);
        [DllImport("opengl32.dll")] public static extern void glDeleteTextures(int n, uint[] textures);
        [DllImport("opengl32.dll")] public static extern void glDepthFunc(DepthFunction func);
        [DllImport("opengl32.dll")] public static extern void glDepthMask(Boolean flag);
        [DllImport("opengl32.dll")] public static extern void glDepthRange(double n, double f);
        [DllImport("opengl32.dll")] public static extern void glDisable(EnableCap cap);
        [DllImport("opengl32.dll")] public static extern void glDrawArrays(PrimitiveType mode, int first, int count);
        [DllImport("opengl32.dll")] public static extern void glDrawBuffer(DrawBufferMode buf);
        [DllImport("opengl32.dll")] public static extern void glDrawElements(PrimitiveType mode, int count, DrawElementsType type, [MarshalAs(UnmanagedType.AsAny)] object indices);
        [DllImport("opengl32.dll")] public static extern void glEnable(EnableCap cap);
        [DllImport("opengl32.dll")] public static extern void glFinish();
        [DllImport("opengl32.dll")] public static extern void glFlush();
        [DllImport("opengl32.dll")] public static extern void glFrontFace(FrontFaceDirection mode);
        [DllImport("opengl32.dll")] public static extern void glGenTextures(int n, uint[] textures);
        [DllImport("opengl32.dll")] public static extern void glGetBooleanv(GetPName pname, Boolean[] data);
        [DllImport("opengl32.dll")] public static extern void glGetDoublev(GetPName pname, double[] data);
        [DllImport("opengl32.dll")] public static extern uint glGetError();
        [DllImport("opengl32.dll")] public static extern void glGetFloatv(GetPName pname, float[] data);
        [DllImport("opengl32.dll")] public static extern void glGetIntegerv(GetPName pname, int[] data);
        [DllImport("opengl32.dll")] public static extern byte glGetString(StringName name);
        [DllImport("opengl32.dll")] public static extern void glGetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, [MarshalAs(UnmanagedType.AsAny)] object pixels);
        [DllImport("opengl32.dll")] public static extern void glGetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, float[] _params);
        [DllImport("opengl32.dll")] public static extern void glGetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, int[] _params);
        [DllImport("opengl32.dll")] public static extern void glGetTexParameterfv(TextureTarget target, GetTextureParameter pname, float[] _params);
        [DllImport("opengl32.dll")] public static extern void glGetTexParameteriv(TextureTarget target, GetTextureParameter pname, int[] _params);
        [DllImport("opengl32.dll")] public static extern void glHint(HintTarget target, HintMode mode);
        [DllImport("opengl32.dll")] public static extern bool glIsEnabled(EnableCap cap);
        [DllImport("opengl32.dll")] public static extern bool glIsTexture(uint texture);
        [DllImport("opengl32.dll")] public static extern void glLineWidth(float width);
        [DllImport("opengl32.dll")] public static extern void glLogicOp(LogicOp opcode);
        [DllImport("opengl32.dll")] public static extern void glPixelStoref(PixelStoreParameter pname, float param);
        [DllImport("opengl32.dll")] public static extern void glPixelStorei(PixelStoreParameter pname, int param);
        [DllImport("opengl32.dll")] public static extern void glPointSize(float size);
        [DllImport("opengl32.dll")] public static extern void glPolygonMode(MaterialFace face, PolygonMode mode);
        [DllImport("opengl32.dll")] public static extern void glPolygonOffset(float factor, float units);
        [DllImport("opengl32.dll")] public static extern void glReadBuffer(ReadBufferMode src);
        [DllImport("opengl32.dll")] public static extern void glReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, [MarshalAs(UnmanagedType.AsAny)] object pixels);
        [DllImport("opengl32.dll")] public static extern void glScissor(int x, int y, int width, int height);
        [DllImport("opengl32.dll")] public static extern void glStencilFunc(StencilFunction func, int _ref, uint mask);
        [DllImport("opengl32.dll")] public static extern void glStencilMask(uint mask);
        [DllImport("opengl32.dll")] public static extern void glStencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass);
        [DllImport("opengl32.dll")] public static extern void glTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int width, int border, PixelFormat format, PixelType type, [MarshalAs(UnmanagedType.AsAny)] object pixels);
        [DllImport("opengl32.dll")] public static extern void glTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, [MarshalAs(UnmanagedType.AsAny)] object pixels);
        [DllImport("opengl32.dll")] public static extern void glTexParameterf(TextureTarget target, TextureParameterName pname, float param);
        [DllImport("opengl32.dll")] public static extern void glTexParameterfv(TextureTarget target, TextureParameterName pname, float[] _params);
        [DllImport("opengl32.dll")] public static extern void glTexParameteri(TextureTarget target, TextureParameterName pname, int param);
        [DllImport("opengl32.dll")] public static extern void glTexParameteriv(TextureTarget target, TextureParameterName pname, int[] _params);
        [DllImport("opengl32.dll")] public static extern void glTexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, [MarshalAs(UnmanagedType.AsAny)] object pixels);
        [DllImport("opengl32.dll")] public static extern void glTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, [MarshalAs(UnmanagedType.AsAny)] object pixels);
        [DllImport("opengl32.dll")] public static extern void glViewport(int x, int y, int width, int height);
        public delegate void DelglActiveTexture(TextureUnit texture); public static DelglActiveTexture glActiveTexture;
        public delegate void DelglAttachShader(uint program, uint shader); public static DelglAttachShader glAttachShader;
        public delegate void DelglBeginConditionalRender(uint id, ConditionalRenderMode mode); public static DelglBeginConditionalRender glBeginConditionalRender;
        public delegate void DelglBeginQuery(QueryTarget target, uint id); public static DelglBeginQuery glBeginQuery;
        public delegate void DelglBeginTransformFeedback(PrimitiveType primitiveMode); public static DelglBeginTransformFeedback glBeginTransformFeedback;
        public delegate void DelglBindAttribLocation(uint program, uint index, StringBuilder name); public static DelglBindAttribLocation glBindAttribLocation;
        public delegate void DelglBindBuffer(BufferTargetARB target, uint buffer); public static DelglBindBuffer glBindBuffer;
        public delegate void DelglBindBufferBase(BufferTargetARB target, uint index, uint buffer); public static DelglBindBufferBase glBindBufferBase;
        public delegate void DelglBindBufferRange(BufferTargetARB target, uint index, uint buffer, IntPtr offset, IntPtr size); public static DelglBindBufferRange glBindBufferRange;
        public delegate void DelglBindFragDataLocation(uint program, uint color, StringBuilder name); public static DelglBindFragDataLocation glBindFragDataLocation;
        public delegate void DelglBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, StringBuilder name); public static DelglBindFragDataLocationIndexed glBindFragDataLocationIndexed;
        public delegate void DelglBindFramebuffer(FramebufferTarget target, uint framebuffer); public static DelglBindFramebuffer glBindFramebuffer;
        public delegate void DelglBindRenderbuffer(RenderbufferTarget target, uint renderbuffer); public static DelglBindRenderbuffer glBindRenderbuffer;
        public delegate void DelglBindSampler(uint unit, uint sampler); public static DelglBindSampler glBindSampler;
        public delegate void DelglBindVertexArray(uint array); public static DelglBindVertexArray glBindVertexArray;
        public delegate void DelglBlendColor(float red, float green, float blue, float alpha); public static DelglBlendColor glBlendColor;
        public delegate void DelglBlendEquation(BlendEquationModeEXT mode); public static DelglBlendEquation glBlendEquation;
        public delegate void DelglBlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha); public static DelglBlendEquationSeparate glBlendEquationSeparate;
        public delegate void DelglBlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha); public static DelglBlendFuncSeparate glBlendFuncSeparate;
        public delegate void DelglBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter); public static DelglBlitFramebuffer glBlitFramebuffer;
        public delegate void DelglBufferData(BufferTargetARB target, uint size, [MarshalAs(UnmanagedType.AsAny)] object data, BufferUsageARB usage); public static DelglBufferData glBufferData;
        public delegate void DelglBufferSubData(BufferTargetARB target, IntPtr offset, IntPtr size, [MarshalAs(UnmanagedType.AsAny)] object data); public static DelglBufferSubData glBufferSubData;
        public delegate uint DelglCheckFramebufferStatus(FramebufferTarget target); public static DelglCheckFramebufferStatus glCheckFramebufferStatus;
        public delegate void DelglClampColor(ClampColorTargetARB target, ClampColorModeARB clamp); public static DelglClampColor glClampColor;
        public delegate void DelglClearBufferfi(Buffer buffer, int drawbuffer, float depth, int stencil); public static DelglClearBufferfi glClearBufferfi;
        public delegate void DelglClearBufferfv(Buffer buffer, int drawbuffer, float[] value); public static DelglClearBufferfv glClearBufferfv;
        public delegate void DelglClearBufferiv(Buffer buffer, int drawbuffer, int[] value); public static DelglClearBufferiv glClearBufferiv;
        public delegate void DelglClearBufferuiv(Buffer buffer, int drawbuffer, uint[] value); public static DelglClearBufferuiv glClearBufferuiv;
        public delegate uint DelglClientWaitSync(IntPtr sync, SyncObjectMask flags, ulong timeout); public static DelglClientWaitSync glClientWaitSync;
        public delegate void DelglColorMaski(uint index, Boolean r, Boolean g, Boolean b, Boolean a); public static DelglColorMaski glColorMaski;
        public delegate void DelglColorP3ui(ColorPointerType type, uint color); public static DelglColorP3ui glColorP3ui;
        public delegate void DelglColorP3uiv(ColorPointerType type, uint[] color); public static DelglColorP3uiv glColorP3uiv;
        public delegate void DelglColorP4ui(ColorPointerType type, uint color); public static DelglColorP4ui glColorP4ui;
        public delegate void DelglColorP4uiv(ColorPointerType type, uint[] color); public static DelglColorP4uiv glColorP4uiv;
        public delegate void DelglCompileShader(uint shader); public static DelglCompileShader glCompileShader;
        public delegate void DelglCompressedTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int width, int border, int imageSize, [MarshalAs(UnmanagedType.AsAny)] object data); public static DelglCompressedTexImage1D glCompressedTexImage1D;
        public delegate void DelglCompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, [MarshalAs(UnmanagedType.AsAny)] object data); public static DelglCompressedTexImage2D glCompressedTexImage2D;
        public delegate void DelglCompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, [MarshalAs(UnmanagedType.AsAny)] object data); public static DelglCompressedTexImage3D glCompressedTexImage3D;
        public delegate void DelglCompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, [MarshalAs(UnmanagedType.AsAny)] object data); public static DelglCompressedTexSubImage1D glCompressedTexSubImage1D;
        public delegate void DelglCompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, [MarshalAs(UnmanagedType.AsAny)] object data); public static DelglCompressedTexSubImage2D glCompressedTexSubImage2D;
        public delegate void DelglCompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, [MarshalAs(UnmanagedType.AsAny)] object data); public static DelglCompressedTexSubImage3D glCompressedTexSubImage3D;
        public delegate void DelglCopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size); public static DelglCopyBufferSubData glCopyBufferSubData;
        public delegate void DelglCopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height); public static DelglCopyTexSubImage3D glCopyTexSubImage3D;
        public delegate uint DelglCreateProgram(); public static DelglCreateProgram glCreateProgram;
        public delegate uint DelglCreateShader(ShaderType type); public static DelglCreateShader glCreateShader;
        public delegate void DelglDeleteBuffers(int n, uint[] buffers); public static DelglDeleteBuffers glDeleteBuffers;
        public delegate void DelglDeleteFramebuffers(int n, uint[] framebuffers); public static DelglDeleteFramebuffers glDeleteFramebuffers;
        public delegate void DelglDeleteProgram(uint program); public static DelglDeleteProgram glDeleteProgram;
        public delegate void DelglDeleteQueries(int n, uint[] ids); public static DelglDeleteQueries glDeleteQueries;
        public delegate void DelglDeleteRenderbuffers(int n, uint[] renderbuffers); public static DelglDeleteRenderbuffers glDeleteRenderbuffers;
        public delegate void DelglDeleteSamplers(int count, uint[] samplers); public static DelglDeleteSamplers glDeleteSamplers;
        public delegate void DelglDeleteShader(uint shader); public static DelglDeleteShader glDeleteShader;
        public delegate void DelglDeleteSync(IntPtr sync); public static DelglDeleteSync glDeleteSync;
        public delegate void DelglDeleteVertexArrays(int n, uint[] arrays); public static DelglDeleteVertexArrays glDeleteVertexArrays;
        public delegate void DelglDetachShader(uint program, uint shader); public static DelglDetachShader glDetachShader;
        public delegate void DelglDisableVertexAttribArray(uint index); public static DelglDisableVertexAttribArray glDisableVertexAttribArray;
        public delegate void DelglDisablei(EnableCap target, uint index); public static DelglDisablei glDisablei;
        public delegate void DelglDrawArraysInstanced(PrimitiveType mode, int first, int count, int instancecount); public static DelglDrawArraysInstanced glDrawArraysInstanced;
        public delegate void DelglDrawBuffers(int n, DrawBufferMode[] bufs); public static DelglDrawBuffers glDrawBuffers;
        public delegate void DelglDrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, [MarshalAs(UnmanagedType.AsAny)] object indices, int basevertex); public static DelglDrawElementsBaseVertex glDrawElementsBaseVertex;
        public delegate void DelglDrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, [MarshalAs(UnmanagedType.AsAny)] object indices, int instancecount); public static DelglDrawElementsInstanced glDrawElementsInstanced;
        public delegate void DelglDrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, [MarshalAs(UnmanagedType.AsAny)] object indices, int instancecount, int basevertex); public static DelglDrawElementsInstancedBaseVertex glDrawElementsInstancedBaseVertex;
        public delegate void DelglDrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, [MarshalAs(UnmanagedType.AsAny)] object indices); public static DelglDrawRangeElements glDrawRangeElements;
        public delegate void DelglDrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, [MarshalAs(UnmanagedType.AsAny)] object indices, int basevertex); public static DelglDrawRangeElementsBaseVertex glDrawRangeElementsBaseVertex;
        public delegate void DelglEnableVertexAttribArray(uint index); public static DelglEnableVertexAttribArray glEnableVertexAttribArray;
        public delegate void DelglEnablei(EnableCap target, uint index); public static DelglEnablei glEnablei;
        public delegate void DelglEndConditionalRender(); public static DelglEndConditionalRender glEndConditionalRender;
        public delegate void DelglEndQuery(QueryTarget target); public static DelglEndQuery glEndQuery;
        public delegate void DelglEndTransformFeedback(); public static DelglEndTransformFeedback glEndTransformFeedback;
        public delegate IntPtr DelglFenceSync(SyncCondition condition, uint flags); public static DelglFenceSync glFenceSync;
        public delegate void DelglFlushMappedBufferRange(BufferTargetARB target, IntPtr offset, IntPtr length); public static DelglFlushMappedBufferRange glFlushMappedBufferRange;
        public delegate void DelglFramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer); public static DelglFramebufferRenderbuffer glFramebufferRenderbuffer;
        public delegate void DelglFramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level); public static DelglFramebufferTexture glFramebufferTexture;
        public delegate void DelglFramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level); public static DelglFramebufferTexture1D glFramebufferTexture1D;
        public delegate void DelglFramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level); public static DelglFramebufferTexture2D glFramebufferTexture2D;
        public delegate void DelglFramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset); public static DelglFramebufferTexture3D glFramebufferTexture3D;
        public delegate void DelglFramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer); public static DelglFramebufferTextureLayer glFramebufferTextureLayer;
        public delegate void DelglGenBuffers(int n, uint[] buffers); public static DelglGenBuffers glGenBuffers;
        public delegate void DelglGenFramebuffers(int n, uint[] framebuffers); public static DelglGenFramebuffers glGenFramebuffers;
        public delegate void DelglGenQueries(int n, uint[] ids); public static DelglGenQueries glGenQueries;
        public delegate void DelglGenRenderbuffers(int n, uint[] renderbuffers); public static DelglGenRenderbuffers glGenRenderbuffers;
        public delegate void DelglGenSamplers(int count, uint[] samplers); public static DelglGenSamplers glGenSamplers;
        public delegate void DelglGenVertexArrays(int n, uint[] arrays); public static DelglGenVertexArrays glGenVertexArrays;
        public delegate void DelglGenerateMipmap(TextureTarget target); public static DelglGenerateMipmap glGenerateMipmap;
        public delegate void DelglGetActiveAttrib(uint program, uint index, int bufSize, int[] length, int[] size, AttributeType[] type, StringBuilder name); public static DelglGetActiveAttrib glGetActiveAttrib;
        public delegate void DelglGetActiveUniform(uint program, uint index, int bufSize, int[] length, int[] size, UniformType[] type, StringBuilder name); public static DelglGetActiveUniform glGetActiveUniform;
        public delegate void DelglGetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int[] length, StringBuilder uniformBlockName); public static DelglGetActiveUniformBlockName glGetActiveUniformBlockName;
        public delegate void DelglGetActiveUniformBlockiv(uint program, uint uniformBlockIndex, UniformBlockPName pname, int[] _params); public static DelglGetActiveUniformBlockiv glGetActiveUniformBlockiv;
        public delegate void DelglGetActiveUniformName(uint program, uint uniformIndex, int bufSize, int[] length, StringBuilder uniformName); public static DelglGetActiveUniformName glGetActiveUniformName;
        public delegate void DelglGetActiveUniformsiv(uint program, int uniformCount, uint[] uniformIndices, UniformPName pname, int[] _params); public static DelglGetActiveUniformsiv glGetActiveUniformsiv;
        public delegate void DelglGetAttachedShaders(uint program, int maxCount, int[] count, uint[] shaders); public static DelglGetAttachedShaders glGetAttachedShaders;
        public delegate int DelglGetAttribLocation(uint program, StringBuilder name); public static DelglGetAttribLocation glGetAttribLocation;
        public delegate void DelglGetBooleani_v(BufferTargetARB target, uint index, Boolean[] data); public static DelglGetBooleani_v glGetBooleani_v;
        public delegate void DelglGetBufferParameteri64v(BufferTargetARB target, BufferPNameARB pname, long[] _params); public static DelglGetBufferParameteri64v glGetBufferParameteri64v;
        public delegate void DelglGetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int[] _params); public static DelglGetBufferParameteriv glGetBufferParameteriv;
        public delegate void DelglGetBufferPointerv(BufferTargetARB target, BufferPointerNameARB pname, [MarshalAs(UnmanagedType.AsAny)] object _params); public static DelglGetBufferPointerv glGetBufferPointerv;
        public delegate void DelglGetBufferSubData(BufferTargetARB target, IntPtr offset, IntPtr size, [MarshalAs(UnmanagedType.AsAny)] object data); public static DelglGetBufferSubData glGetBufferSubData;
        public delegate void DelglGetCompressedTexImage(TextureTarget target, int level, [MarshalAs(UnmanagedType.AsAny)] object img); public static DelglGetCompressedTexImage glGetCompressedTexImage;
        public delegate int DelglGetFragDataIndex(uint program, StringBuilder name); public static DelglGetFragDataIndex glGetFragDataIndex;
        public delegate int DelglGetFragDataLocation(uint program, StringBuilder name); public static DelglGetFragDataLocation glGetFragDataLocation;
        public delegate void DelglGetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int[] _params); public static DelglGetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv;
        public delegate void DelglGetInteger64i_v(uint target, uint index, long[] data); public static DelglGetInteger64i_v glGetInteger64i_v;
        public delegate void DelglGetInteger64v(GetPName pname, long[] data); public static DelglGetInteger64v glGetInteger64v;
        public delegate void DelglGetIntegeri_v(uint target, uint index, int[] data); public static DelglGetIntegeri_v glGetIntegeri_v;
        public delegate void DelglGetMultisamplefv(GetMultisamplePNameNV pname, uint index, float[] val); public static DelglGetMultisamplefv glGetMultisamplefv;
        public delegate void DelglGetProgramInfoLog(uint program, int bufSize, int[] length, StringBuilder infoLog); public static DelglGetProgramInfoLog glGetProgramInfoLog;
        public delegate void DelglGetProgramiv(uint program, ProgramPropertyARB pname, int[] _params); public static DelglGetProgramiv glGetProgramiv;
        public delegate void DelglGetQueryObjecti64v(uint id, QueryObjectParameterName pname, long[] _params); public static DelglGetQueryObjecti64v glGetQueryObjecti64v;
        public delegate void DelglGetQueryObjectiv(uint id, QueryObjectParameterName pname, int[] _params); public static DelglGetQueryObjectiv glGetQueryObjectiv;
        public delegate void DelglGetQueryObjectui64v(uint id, QueryObjectParameterName pname, ulong[] _params); public static DelglGetQueryObjectui64v glGetQueryObjectui64v;
        public delegate void DelglGetQueryObjectuiv(uint id, QueryObjectParameterName pname, uint[] _params); public static DelglGetQueryObjectuiv glGetQueryObjectuiv;
        public delegate void DelglGetQueryiv(QueryTarget target, QueryParameterName pname, int[] _params); public static DelglGetQueryiv glGetQueryiv;
        public delegate void DelglGetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, int[] _params); public static DelglGetRenderbufferParameteriv glGetRenderbufferParameteriv;
        public delegate void DelglGetSamplerParameterIiv(uint sampler, SamplerParameterI pname, int[] _params); public static DelglGetSamplerParameterIiv glGetSamplerParameterIiv;
        public delegate void DelglGetSamplerParameterIuiv(uint sampler, SamplerParameterI pname, uint[] _params); public static DelglGetSamplerParameterIuiv glGetSamplerParameterIuiv;
        public delegate void DelglGetSamplerParameterfv(uint sampler, SamplerParameterF pname, float[] _params); public static DelglGetSamplerParameterfv glGetSamplerParameterfv;
        public delegate void DelglGetSamplerParameteriv(uint sampler, SamplerParameterI pname, int[] _params); public static DelglGetSamplerParameteriv glGetSamplerParameteriv;
        public delegate void DelglGetShaderInfoLog(uint shader, int bufSize, int[] length, StringBuilder infoLog); public static DelglGetShaderInfoLog glGetShaderInfoLog;
        public delegate void DelglGetShaderSource(uint shader, int bufSize, int[] length, StringBuilder source); public static DelglGetShaderSource glGetShaderSource;
        public delegate void DelglGetShaderiv(uint shader, ShaderParameterName pname, int[] _params); public static DelglGetShaderiv glGetShaderiv;
        public delegate byte DelglGetStringi(StringName name, uint index); public static DelglGetStringi glGetStringi;
        public delegate void DelglGetSynciv(IntPtr sync, SyncParameterName pname, int count, int[] length, int[] values); public static DelglGetSynciv glGetSynciv;
        public delegate void DelglGetTexParameterIiv(TextureTarget target, GetTextureParameter pname, int[] _params); public static DelglGetTexParameterIiv glGetTexParameterIiv;
        public delegate void DelglGetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, uint[] _params); public static DelglGetTexParameterIuiv glGetTexParameterIuiv;
        public delegate void DelglGetTransformFeedbackVarying(uint program, uint index, int bufSize, int[] length, int[] size, GlslTypeToken[] type, StringBuilder name); public static DelglGetTransformFeedbackVarying glGetTransformFeedbackVarying;
        public delegate uint DelglGetUniformBlockIndex(uint program, StringBuilder uniformBlockName); public static DelglGetUniformBlockIndex glGetUniformBlockIndex;
        public delegate void DelglGetUniformIndices(uint program, int uniformCount, string[] uniformNames, uint[] uniformIndices); public static DelglGetUniformIndices glGetUniformIndices;
        public delegate int DelglGetUniformLocation(uint program, StringBuilder name); public static DelglGetUniformLocation glGetUniformLocation;
        public delegate void DelglGetUniformfv(uint program, int location, float[] _params); public static DelglGetUniformfv glGetUniformfv;
        public delegate void DelglGetUniformiv(uint program, int location, int[] _params); public static DelglGetUniformiv glGetUniformiv;
        public delegate void DelglGetUniformuiv(uint program, int location, uint[] _params); public static DelglGetUniformuiv glGetUniformuiv;
        public delegate void DelglGetVertexAttribIiv(uint index, VertexAttribEnum pname, int[] _params); public static DelglGetVertexAttribIiv glGetVertexAttribIiv;
        public delegate void DelglGetVertexAttribIuiv(uint index, VertexAttribEnum pname, uint[] _params); public static DelglGetVertexAttribIuiv glGetVertexAttribIuiv;
        public delegate void DelglGetVertexAttribPointerv(uint index, VertexAttribPointerPropertyARB pname, [MarshalAs(UnmanagedType.AsAny)] object pointer); public static DelglGetVertexAttribPointerv glGetVertexAttribPointerv;
        public delegate void DelglGetVertexAttribdv(uint index, VertexAttribPropertyARB pname, double[] _params); public static DelglGetVertexAttribdv glGetVertexAttribdv;
        public delegate void DelglGetVertexAttribfv(uint index, VertexAttribPropertyARB pname, float[] _params); public static DelglGetVertexAttribfv glGetVertexAttribfv;
        public delegate void DelglGetVertexAttribiv(uint index, VertexAttribPropertyARB pname, int[] _params); public static DelglGetVertexAttribiv glGetVertexAttribiv;
        public delegate bool DelglIsBuffer(uint buffer); public static DelglIsBuffer glIsBuffer;
        public delegate bool DelglIsEnabledi(EnableCap target, uint index); public static DelglIsEnabledi glIsEnabledi;
        public delegate bool DelglIsFramebuffer(uint framebuffer); public static DelglIsFramebuffer glIsFramebuffer;
        public delegate bool DelglIsProgram(uint program); public static DelglIsProgram glIsProgram;
        public delegate bool DelglIsQuery(uint id); public static DelglIsQuery glIsQuery;
        public delegate bool DelglIsRenderbuffer(uint renderbuffer); public static DelglIsRenderbuffer glIsRenderbuffer;
        public delegate bool DelglIsSampler(uint sampler); public static DelglIsSampler glIsSampler;
        public delegate bool DelglIsShader(uint shader); public static DelglIsShader glIsShader;
        public delegate bool DelglIsSync(IntPtr sync); public static DelglIsSync glIsSync;
        public delegate bool DelglIsVertexArray(uint array); public static DelglIsVertexArray glIsVertexArray;
        public delegate void DelglLinkProgram(uint program); public static DelglLinkProgram glLinkProgram;
        public delegate IntPtr DelglMapBuffer(BufferTargetARB target, BufferAccessARB access); public static DelglMapBuffer glMapBuffer;
        public delegate IntPtr DelglMapBufferRange(BufferTargetARB target, IntPtr offset, IntPtr length, MapBufferAccessMask access); public static DelglMapBufferRange glMapBufferRange;
        public delegate void DelglMultiDrawArrays(PrimitiveType mode, int[] first, int[] count, int drawcount); public static DelglMultiDrawArrays glMultiDrawArrays;
        public delegate void DelglMultiDrawElements(PrimitiveType mode, int[] count, DrawElementsType type, [MarshalAs(UnmanagedType.AsAny)] object indices, int drawcount); public static DelglMultiDrawElements glMultiDrawElements;
        public delegate void DelglMultiDrawElementsBaseVertex(PrimitiveType mode, int[] count, DrawElementsType type, [MarshalAs(UnmanagedType.AsAny)] object indices, int drawcount, int[] basevertex); public static DelglMultiDrawElementsBaseVertex glMultiDrawElementsBaseVertex;
        public delegate void DelglMultiTexCoordP1ui(TextureUnit texture, TexCoordPointerType type, uint coords); public static DelglMultiTexCoordP1ui glMultiTexCoordP1ui;
        public delegate void DelglMultiTexCoordP1uiv(TextureUnit texture, TexCoordPointerType type, uint[] coords); public static DelglMultiTexCoordP1uiv glMultiTexCoordP1uiv;
        public delegate void DelglMultiTexCoordP2ui(TextureUnit texture, TexCoordPointerType type, uint coords); public static DelglMultiTexCoordP2ui glMultiTexCoordP2ui;
        public delegate void DelglMultiTexCoordP2uiv(TextureUnit texture, TexCoordPointerType type, uint[] coords); public static DelglMultiTexCoordP2uiv glMultiTexCoordP2uiv;
        public delegate void DelglMultiTexCoordP3ui(TextureUnit texture, TexCoordPointerType type, uint coords); public static DelglMultiTexCoordP3ui glMultiTexCoordP3ui;
        public delegate void DelglMultiTexCoordP3uiv(TextureUnit texture, TexCoordPointerType type, uint[] coords); public static DelglMultiTexCoordP3uiv glMultiTexCoordP3uiv;
        public delegate void DelglMultiTexCoordP4ui(TextureUnit texture, TexCoordPointerType type, uint coords); public static DelglMultiTexCoordP4ui glMultiTexCoordP4ui;
        public delegate void DelglMultiTexCoordP4uiv(TextureUnit texture, TexCoordPointerType type, uint[] coords); public static DelglMultiTexCoordP4uiv glMultiTexCoordP4uiv;
        public delegate void DelglNormalP3ui(NormalPointerType type, uint coords); public static DelglNormalP3ui glNormalP3ui;
        public delegate void DelglNormalP3uiv(NormalPointerType type, uint[] coords); public static DelglNormalP3uiv glNormalP3uiv;
        public delegate void DelglPointParameterf(PointParameterNameARB pname, float param); public static DelglPointParameterf glPointParameterf;
        public delegate void DelglPointParameterfv(PointParameterNameARB pname, float[] _params); public static DelglPointParameterfv glPointParameterfv;
        public delegate void DelglPointParameteri(PointParameterNameARB pname, int param); public static DelglPointParameteri glPointParameteri;
        public delegate void DelglPointParameteriv(PointParameterNameARB pname, int[] _params); public static DelglPointParameteriv glPointParameteriv;
        public delegate void DelglPrimitiveRestartIndex(uint index); public static DelglPrimitiveRestartIndex glPrimitiveRestartIndex;
        public delegate void DelglProvokingVertex(VertexProvokingMode mode); public static DelglProvokingVertex glProvokingVertex;
        public delegate void DelglQueryCounter(uint id, QueryCounterTarget target); public static DelglQueryCounter glQueryCounter;
        public delegate void DelglRenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height); public static DelglRenderbufferStorage glRenderbufferStorage;
        public delegate void DelglRenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height); public static DelglRenderbufferStorageMultisample glRenderbufferStorageMultisample;
        public delegate void DelglSampleCoverage(float value, Boolean invert); public static DelglSampleCoverage glSampleCoverage;
        public delegate void DelglSampleMaski(uint maskNumber, uint mask); public static DelglSampleMaski glSampleMaski;
        public delegate void DelglSamplerParameterIiv(uint sampler, SamplerParameterI pname, int[] param); public static DelglSamplerParameterIiv glSamplerParameterIiv;
        public delegate void DelglSamplerParameterIuiv(uint sampler, SamplerParameterI pname, uint[] param); public static DelglSamplerParameterIuiv glSamplerParameterIuiv;
        public delegate void DelglSamplerParameterf(uint sampler, SamplerParameterF pname, float param); public static DelglSamplerParameterf glSamplerParameterf;
        public delegate void DelglSamplerParameterfv(uint sampler, SamplerParameterF pname, float[] param); public static DelglSamplerParameterfv glSamplerParameterfv;
        public delegate void DelglSamplerParameteri(uint sampler, SamplerParameterI pname, int param); public static DelglSamplerParameteri glSamplerParameteri;
        public delegate void DelglSamplerParameteriv(uint sampler, SamplerParameterI pname, int[] param); public static DelglSamplerParameteriv glSamplerParameteriv;
        public delegate void DelglSecondaryColorP3ui(ColorPointerType type, uint color); public static DelglSecondaryColorP3ui glSecondaryColorP3ui;
        public delegate void DelglSecondaryColorP3uiv(ColorPointerType type, uint[] color); public static DelglSecondaryColorP3uiv glSecondaryColorP3uiv;
        public delegate void DelglShaderSource(uint shader, int count, string[] _string, int[] length); public static DelglShaderSource glShaderSource;
        public delegate void DelglStencilFuncSeparate(StencilFaceDirection face, StencilFunction func, int _ref, uint mask); public static DelglStencilFuncSeparate glStencilFuncSeparate;
        public delegate void DelglStencilMaskSeparate(StencilFaceDirection face, uint mask); public static DelglStencilMaskSeparate glStencilMaskSeparate;
        public delegate void DelglStencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass); public static DelglStencilOpSeparate glStencilOpSeparate;
        public delegate void DelglTexBuffer(TextureTarget target, InternalFormat internalformat, uint buffer); public static DelglTexBuffer glTexBuffer;
        public delegate void DelglTexCoordP1ui(TexCoordPointerType type, uint coords); public static DelglTexCoordP1ui glTexCoordP1ui;
        public delegate void DelglTexCoordP1uiv(TexCoordPointerType type, uint[] coords); public static DelglTexCoordP1uiv glTexCoordP1uiv;
        public delegate void DelglTexCoordP2ui(TexCoordPointerType type, uint coords); public static DelglTexCoordP2ui glTexCoordP2ui;
        public delegate void DelglTexCoordP2uiv(TexCoordPointerType type, uint[] coords); public static DelglTexCoordP2uiv glTexCoordP2uiv;
        public delegate void DelglTexCoordP3ui(TexCoordPointerType type, uint coords); public static DelglTexCoordP3ui glTexCoordP3ui;
        public delegate void DelglTexCoordP3uiv(TexCoordPointerType type, uint[] coords); public static DelglTexCoordP3uiv glTexCoordP3uiv;
        public delegate void DelglTexCoordP4ui(TexCoordPointerType type, uint coords); public static DelglTexCoordP4ui glTexCoordP4ui;
        public delegate void DelglTexCoordP4uiv(TexCoordPointerType type, uint[] coords); public static DelglTexCoordP4uiv glTexCoordP4uiv;
        public delegate void DelglTexImage2DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, Boolean fixedsamplelocations); public static DelglTexImage2DMultisample glTexImage2DMultisample;
        public delegate void DelglTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, [MarshalAs(UnmanagedType.AsAny)] object pixels); public static DelglTexImage3D glTexImage3D;
        public delegate void DelglTexImage3DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, int depth, Boolean fixedsamplelocations); public static DelglTexImage3DMultisample glTexImage3DMultisample;
        public delegate void DelglTexParameterIiv(TextureTarget target, TextureParameterName pname, int[] _params); public static DelglTexParameterIiv glTexParameterIiv;
        public delegate void DelglTexParameterIuiv(TextureTarget target, TextureParameterName pname, uint[] _params); public static DelglTexParameterIuiv glTexParameterIuiv;
        public delegate void DelglTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, [MarshalAs(UnmanagedType.AsAny)] object pixels); public static DelglTexSubImage3D glTexSubImage3D;
        public delegate void DelglTransformFeedbackVaryings(uint program, int count, string[] varyings, TransformFeedbackBufferMode bufferMode); public static DelglTransformFeedbackVaryings glTransformFeedbackVaryings;
        public delegate void DelglUniform1f(int location, float v0); public static DelglUniform1f glUniform1f;
        public delegate void DelglUniform1fv(int location, int count, float[] value); public static DelglUniform1fv glUniform1fv;
        public delegate void DelglUniform1i(int location, int v0); public static DelglUniform1i glUniform1i;
        public delegate void DelglUniform1iv(int location, int count, int[] value); public static DelglUniform1iv glUniform1iv;
        public delegate void DelglUniform1ui(int location, uint v0); public static DelglUniform1ui glUniform1ui;
        public delegate void DelglUniform1uiv(int location, int count, uint[] value); public static DelglUniform1uiv glUniform1uiv;
        public delegate void DelglUniform2f(int location, float v0, float v1); public static DelglUniform2f glUniform2f;
        public delegate void DelglUniform2fv(int location, int count, float[] value); public static DelglUniform2fv glUniform2fv;
        public delegate void DelglUniform2i(int location, int v0, int v1); public static DelglUniform2i glUniform2i;
        public delegate void DelglUniform2iv(int location, int count, int[] value); public static DelglUniform2iv glUniform2iv;
        public delegate void DelglUniform2ui(int location, uint v0, uint v1); public static DelglUniform2ui glUniform2ui;
        public delegate void DelglUniform2uiv(int location, int count, uint[] value); public static DelglUniform2uiv glUniform2uiv;
        public delegate void DelglUniform3f(int location, float v0, float v1, float v2); public static DelglUniform3f glUniform3f;
        public delegate void DelglUniform3fv(int location, int count, float[] value); public static DelglUniform3fv glUniform3fv;
        public delegate void DelglUniform3i(int location, int v0, int v1, int v2); public static DelglUniform3i glUniform3i;
        public delegate void DelglUniform3iv(int location, int count, int[] value); public static DelglUniform3iv glUniform3iv;
        public delegate void DelglUniform3ui(int location, uint v0, uint v1, uint v2); public static DelglUniform3ui glUniform3ui;
        public delegate void DelglUniform3uiv(int location, int count, uint[] value); public static DelglUniform3uiv glUniform3uiv;
        public delegate void DelglUniform4f(int location, float v0, float v1, float v2, float v3); public static DelglUniform4f glUniform4f;
        public delegate void DelglUniform4fv(int location, int count, float[] value); public static DelglUniform4fv glUniform4fv;
        public delegate void DelglUniform4i(int location, int v0, int v1, int v2, int v3); public static DelglUniform4i glUniform4i;
        public delegate void DelglUniform4iv(int location, int count, int[] value); public static DelglUniform4iv glUniform4iv;
        public delegate void DelglUniform4ui(int location, uint v0, uint v1, uint v2, uint v3); public static DelglUniform4ui glUniform4ui;
        public delegate void DelglUniform4uiv(int location, int count, uint[] value); public static DelglUniform4uiv glUniform4uiv;
        public delegate void DelglUniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding); public static DelglUniformBlockBinding glUniformBlockBinding;
        public delegate void DelglUniformMatrix2fv(int location, int count, Boolean transpose, float[] value); public static DelglUniformMatrix2fv glUniformMatrix2fv;
        public delegate void DelglUniformMatrix2x3fv(int location, int count, Boolean transpose, float[] value); public static DelglUniformMatrix2x3fv glUniformMatrix2x3fv;
        public delegate void DelglUniformMatrix2x4fv(int location, int count, Boolean transpose, float[] value); public static DelglUniformMatrix2x4fv glUniformMatrix2x4fv;
        public delegate void DelglUniformMatrix3fv(int location, int count, Boolean transpose, float[] value); public static DelglUniformMatrix3fv glUniformMatrix3fv;
        public delegate void DelglUniformMatrix3x2fv(int location, int count, Boolean transpose, float[] value); public static DelglUniformMatrix3x2fv glUniformMatrix3x2fv;
        public delegate void DelglUniformMatrix3x4fv(int location, int count, Boolean transpose, float[] value); public static DelglUniformMatrix3x4fv glUniformMatrix3x4fv;
        public delegate void DelglUniformMatrix4fv(int location, int count, Boolean transpose, float[] value); public static DelglUniformMatrix4fv glUniformMatrix4fv;
        public delegate void DelglUniformMatrix4x2fv(int location, int count, Boolean transpose, float[] value); public static DelglUniformMatrix4x2fv glUniformMatrix4x2fv;
        public delegate void DelglUniformMatrix4x3fv(int location, int count, Boolean transpose, float[] value); public static DelglUniformMatrix4x3fv glUniformMatrix4x3fv;
        public delegate bool DelglUnmapBuffer(BufferTargetARB target); public static DelglUnmapBuffer glUnmapBuffer;
        public delegate void DelglUseProgram(uint program); public static DelglUseProgram glUseProgram;
        public delegate void DelglValidateProgram(uint program); public static DelglValidateProgram glValidateProgram;
        public delegate void DelglVertexAttrib1d(uint index, double x); public static DelglVertexAttrib1d glVertexAttrib1d;
        public delegate void DelglVertexAttrib1dv(uint index, double[] v); public static DelglVertexAttrib1dv glVertexAttrib1dv;
        public delegate void DelglVertexAttrib1f(uint index, float x); public static DelglVertexAttrib1f glVertexAttrib1f;
        public delegate void DelglVertexAttrib1fv(uint index, float[] v); public static DelglVertexAttrib1fv glVertexAttrib1fv;
        public delegate void DelglVertexAttrib1s(uint index, short x); public static DelglVertexAttrib1s glVertexAttrib1s;
        public delegate void DelglVertexAttrib1sv(uint index, short[] v); public static DelglVertexAttrib1sv glVertexAttrib1sv;
        public delegate void DelglVertexAttrib2d(uint index, double x, double y); public static DelglVertexAttrib2d glVertexAttrib2d;
        public delegate void DelglVertexAttrib2dv(uint index, double[] v); public static DelglVertexAttrib2dv glVertexAttrib2dv;
        public delegate void DelglVertexAttrib2f(uint index, float x, float y); public static DelglVertexAttrib2f glVertexAttrib2f;
        public delegate void DelglVertexAttrib2fv(uint index, float[] v); public static DelglVertexAttrib2fv glVertexAttrib2fv;
        public delegate void DelglVertexAttrib2s(uint index, short x, short y); public static DelglVertexAttrib2s glVertexAttrib2s;
        public delegate void DelglVertexAttrib2sv(uint index, short[] v); public static DelglVertexAttrib2sv glVertexAttrib2sv;
        public delegate void DelglVertexAttrib3d(uint index, double x, double y, double z); public static DelglVertexAttrib3d glVertexAttrib3d;
        public delegate void DelglVertexAttrib3dv(uint index, double[] v); public static DelglVertexAttrib3dv glVertexAttrib3dv;
        public delegate void DelglVertexAttrib3f(uint index, float x, float y, float z); public static DelglVertexAttrib3f glVertexAttrib3f;
        public delegate void DelglVertexAttrib3fv(uint index, float[] v); public static DelglVertexAttrib3fv glVertexAttrib3fv;
        public delegate void DelglVertexAttrib3s(uint index, short x, short y, short z); public static DelglVertexAttrib3s glVertexAttrib3s;
        public delegate void DelglVertexAttrib3sv(uint index, short[] v); public static DelglVertexAttrib3sv glVertexAttrib3sv;
        public delegate void DelglVertexAttrib4Nbv(uint index, sbyte[] v); public static DelglVertexAttrib4Nbv glVertexAttrib4Nbv;
        public delegate void DelglVertexAttrib4Niv(uint index, int[] v); public static DelglVertexAttrib4Niv glVertexAttrib4Niv;
        public delegate void DelglVertexAttrib4Nsv(uint index, short[] v); public static DelglVertexAttrib4Nsv glVertexAttrib4Nsv;
        public delegate void DelglVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w); public static DelglVertexAttrib4Nub glVertexAttrib4Nub;
        public delegate void DelglVertexAttrib4Nubv(uint index, byte[] v); public static DelglVertexAttrib4Nubv glVertexAttrib4Nubv;
        public delegate void DelglVertexAttrib4Nuiv(uint index, uint[] v); public static DelglVertexAttrib4Nuiv glVertexAttrib4Nuiv;
        public delegate void DelglVertexAttrib4Nusv(uint index, ushort[] v); public static DelglVertexAttrib4Nusv glVertexAttrib4Nusv;
        public delegate void DelglVertexAttrib4bv(uint index, sbyte[] v); public static DelglVertexAttrib4bv glVertexAttrib4bv;
        public delegate void DelglVertexAttrib4d(uint index, double x, double y, double z, double w); public static DelglVertexAttrib4d glVertexAttrib4d;
        public delegate void DelglVertexAttrib4dv(uint index, double[] v); public static DelglVertexAttrib4dv glVertexAttrib4dv;
        public delegate void DelglVertexAttrib4f(uint index, float x, float y, float z, float w); public static DelglVertexAttrib4f glVertexAttrib4f;
        public delegate void DelglVertexAttrib4fv(uint index, float[] v); public static DelglVertexAttrib4fv glVertexAttrib4fv;
        public delegate void DelglVertexAttrib4iv(uint index, int[] v); public static DelglVertexAttrib4iv glVertexAttrib4iv;
        public delegate void DelglVertexAttrib4s(uint index, short x, short y, short z, short w); public static DelglVertexAttrib4s glVertexAttrib4s;
        public delegate void DelglVertexAttrib4sv(uint index, short[] v); public static DelglVertexAttrib4sv glVertexAttrib4sv;
        public delegate void DelglVertexAttrib4ubv(uint index, byte[] v); public static DelglVertexAttrib4ubv glVertexAttrib4ubv;
        public delegate void DelglVertexAttrib4uiv(uint index, uint[] v); public static DelglVertexAttrib4uiv glVertexAttrib4uiv;
        public delegate void DelglVertexAttrib4usv(uint index, ushort[] v); public static DelglVertexAttrib4usv glVertexAttrib4usv;
        public delegate void DelglVertexAttribDivisor(uint index, uint divisor); public static DelglVertexAttribDivisor glVertexAttribDivisor;
        public delegate void DelglVertexAttribI1i(uint index, int x); public static DelglVertexAttribI1i glVertexAttribI1i;
        public delegate void DelglVertexAttribI1iv(uint index, int[] v); public static DelglVertexAttribI1iv glVertexAttribI1iv;
        public delegate void DelglVertexAttribI1ui(uint index, uint x); public static DelglVertexAttribI1ui glVertexAttribI1ui;
        public delegate void DelglVertexAttribI1uiv(uint index, uint[] v); public static DelglVertexAttribI1uiv glVertexAttribI1uiv;
        public delegate void DelglVertexAttribI2i(uint index, int x, int y); public static DelglVertexAttribI2i glVertexAttribI2i;
        public delegate void DelglVertexAttribI2iv(uint index, int[] v); public static DelglVertexAttribI2iv glVertexAttribI2iv;
        public delegate void DelglVertexAttribI2ui(uint index, uint x, uint y); public static DelglVertexAttribI2ui glVertexAttribI2ui;
        public delegate void DelglVertexAttribI2uiv(uint index, uint[] v); public static DelglVertexAttribI2uiv glVertexAttribI2uiv;
        public delegate void DelglVertexAttribI3i(uint index, int x, int y, int z); public static DelglVertexAttribI3i glVertexAttribI3i;
        public delegate void DelglVertexAttribI3iv(uint index, int[] v); public static DelglVertexAttribI3iv glVertexAttribI3iv;
        public delegate void DelglVertexAttribI3ui(uint index, uint x, uint y, uint z); public static DelglVertexAttribI3ui glVertexAttribI3ui;
        public delegate void DelglVertexAttribI3uiv(uint index, uint[] v); public static DelglVertexAttribI3uiv glVertexAttribI3uiv;
        public delegate void DelglVertexAttribI4bv(uint index, sbyte[] v); public static DelglVertexAttribI4bv glVertexAttribI4bv;
        public delegate void DelglVertexAttribI4i(uint index, int x, int y, int z, int w); public static DelglVertexAttribI4i glVertexAttribI4i;
        public delegate void DelglVertexAttribI4iv(uint index, int[] v); public static DelglVertexAttribI4iv glVertexAttribI4iv;
        public delegate void DelglVertexAttribI4sv(uint index, short[] v); public static DelglVertexAttribI4sv glVertexAttribI4sv;
        public delegate void DelglVertexAttribI4ubv(uint index, byte[] v); public static DelglVertexAttribI4ubv glVertexAttribI4ubv;
        public delegate void DelglVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w); public static DelglVertexAttribI4ui glVertexAttribI4ui;
        public delegate void DelglVertexAttribI4uiv(uint index, uint[] v); public static DelglVertexAttribI4uiv glVertexAttribI4uiv;
        public delegate void DelglVertexAttribI4usv(uint index, ushort[] v); public static DelglVertexAttribI4usv glVertexAttribI4usv;
        public delegate void DelglVertexAttribIPointer(uint index, int size, VertexAttribPointerType type, int stride, [MarshalAs(UnmanagedType.AsAny)] object pointer); public static DelglVertexAttribIPointer glVertexAttribIPointer;
        public delegate void DelglVertexAttribP1ui(uint index, VertexAttribPointerType type, Boolean normalized, uint value); public static DelglVertexAttribP1ui glVertexAttribP1ui;
        public delegate void DelglVertexAttribP1uiv(uint index, VertexAttribPointerType type, Boolean normalized, uint[] value); public static DelglVertexAttribP1uiv glVertexAttribP1uiv;
        public delegate void DelglVertexAttribP2ui(uint index, VertexAttribPointerType type, Boolean normalized, uint value); public static DelglVertexAttribP2ui glVertexAttribP2ui;
        public delegate void DelglVertexAttribP2uiv(uint index, VertexAttribPointerType type, Boolean normalized, uint[] value); public static DelglVertexAttribP2uiv glVertexAttribP2uiv;
        public delegate void DelglVertexAttribP3ui(uint index, VertexAttribPointerType type, Boolean normalized, uint value); public static DelglVertexAttribP3ui glVertexAttribP3ui;
        public delegate void DelglVertexAttribP3uiv(uint index, VertexAttribPointerType type, Boolean normalized, uint[] value); public static DelglVertexAttribP3uiv glVertexAttribP3uiv;
        public delegate void DelglVertexAttribP4ui(uint index, VertexAttribPointerType type, Boolean normalized, uint value); public static DelglVertexAttribP4ui glVertexAttribP4ui;
        public delegate void DelglVertexAttribP4uiv(uint index, VertexAttribPointerType type, Boolean normalized, uint[] value); public static DelglVertexAttribP4uiv glVertexAttribP4uiv;
        public delegate void DelglVertexAttribPointer(uint index, int size, VertexAttribPointerType type, Boolean normalized, int stride, int pointer); public static DelglVertexAttribPointer glVertexAttribPointer;
        public delegate void DelglVertexP2ui(VertexPointerType type, uint value); public static DelglVertexP2ui glVertexP2ui;
        public delegate void DelglVertexP2uiv(VertexPointerType type, uint[] value); public static DelglVertexP2uiv glVertexP2uiv;
        public delegate void DelglVertexP3ui(VertexPointerType type, uint value); public static DelglVertexP3ui glVertexP3ui;
        public delegate void DelglVertexP3uiv(VertexPointerType type, uint[] value); public static DelglVertexP3uiv glVertexP3uiv;
        public delegate void DelglVertexP4ui(VertexPointerType type, uint value); public static DelglVertexP4ui glVertexP4ui;
        public delegate void DelglVertexP4uiv(VertexPointerType type, uint[] value); public static DelglVertexP4uiv glVertexP4uiv;
        public delegate void DelglWaitSync(IntPtr sync, uint flags, ulong timeout); public static DelglWaitSync glWaitSync;
        public static void LoadGLFuncs()
        {
            glActiveTexture = (DelglActiveTexture)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glActiveTexture"), typeof(DelglActiveTexture));
            glAttachShader = (DelglAttachShader)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glAttachShader"), typeof(DelglAttachShader));
            glBeginConditionalRender = (DelglBeginConditionalRender)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBeginConditionalRender"), typeof(DelglBeginConditionalRender));
            glBeginQuery = (DelglBeginQuery)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBeginQuery"), typeof(DelglBeginQuery));
            glBeginTransformFeedback = (DelglBeginTransformFeedback)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBeginTransformFeedback"), typeof(DelglBeginTransformFeedback));
            glBindAttribLocation = (DelglBindAttribLocation)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBindAttribLocation"), typeof(DelglBindAttribLocation));
            glBindBuffer = (DelglBindBuffer)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBindBuffer"), typeof(DelglBindBuffer));
            glBindBufferBase = (DelglBindBufferBase)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBindBufferBase"), typeof(DelglBindBufferBase));
            glBindBufferRange = (DelglBindBufferRange)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBindBufferRange"), typeof(DelglBindBufferRange));
            glBindFragDataLocation = (DelglBindFragDataLocation)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBindFragDataLocation"), typeof(DelglBindFragDataLocation));
            glBindFragDataLocationIndexed = (DelglBindFragDataLocationIndexed)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBindFragDataLocationIndexed"), typeof(DelglBindFragDataLocationIndexed));
            glBindFramebuffer = (DelglBindFramebuffer)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBindFramebuffer"), typeof(DelglBindFramebuffer));
            glBindRenderbuffer = (DelglBindRenderbuffer)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBindRenderbuffer"), typeof(DelglBindRenderbuffer));
            glBindSampler = (DelglBindSampler)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBindSampler"), typeof(DelglBindSampler));
            glBindVertexArray = (DelglBindVertexArray)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBindVertexArray"), typeof(DelglBindVertexArray));
            glBlendColor = (DelglBlendColor)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBlendColor"), typeof(DelglBlendColor));
            glBlendEquation = (DelglBlendEquation)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBlendEquation"), typeof(DelglBlendEquation));
            glBlendEquationSeparate = (DelglBlendEquationSeparate)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBlendEquationSeparate"), typeof(DelglBlendEquationSeparate));
            glBlendFuncSeparate = (DelglBlendFuncSeparate)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBlendFuncSeparate"), typeof(DelglBlendFuncSeparate));
            glBlitFramebuffer = (DelglBlitFramebuffer)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBlitFramebuffer"), typeof(DelglBlitFramebuffer));
            glBufferData = (DelglBufferData)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBufferData"), typeof(DelglBufferData));
            glBufferSubData = (DelglBufferSubData)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glBufferSubData"), typeof(DelglBufferSubData));
            glCheckFramebufferStatus = (DelglCheckFramebufferStatus)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glCheckFramebufferStatus"), typeof(DelglCheckFramebufferStatus));
            glClampColor = (DelglClampColor)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glClampColor"), typeof(DelglClampColor));
            glClearBufferfi = (DelglClearBufferfi)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glClearBufferfi"), typeof(DelglClearBufferfi));
            glClearBufferfv = (DelglClearBufferfv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glClearBufferfv"), typeof(DelglClearBufferfv));
            glClearBufferiv = (DelglClearBufferiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glClearBufferiv"), typeof(DelglClearBufferiv));
            glClearBufferuiv = (DelglClearBufferuiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glClearBufferuiv"), typeof(DelglClearBufferuiv));
            glClientWaitSync = (DelglClientWaitSync)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glClientWaitSync"), typeof(DelglClientWaitSync));
            glColorMaski = (DelglColorMaski)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glColorMaski"), typeof(DelglColorMaski));
            glColorP3ui = (DelglColorP3ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glColorP3ui"), typeof(DelglColorP3ui));
            glColorP3uiv = (DelglColorP3uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glColorP3uiv"), typeof(DelglColorP3uiv));
            glColorP4ui = (DelglColorP4ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glColorP4ui"), typeof(DelglColorP4ui));
            glColorP4uiv = (DelglColorP4uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glColorP4uiv"), typeof(DelglColorP4uiv));
            glCompileShader = (DelglCompileShader)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glCompileShader"), typeof(DelglCompileShader));
            glCompressedTexImage1D = (DelglCompressedTexImage1D)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glCompressedTexImage1D"), typeof(DelglCompressedTexImage1D));
            glCompressedTexImage2D = (DelglCompressedTexImage2D)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glCompressedTexImage2D"), typeof(DelglCompressedTexImage2D));
            glCompressedTexImage3D = (DelglCompressedTexImage3D)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glCompressedTexImage3D"), typeof(DelglCompressedTexImage3D));
            glCompressedTexSubImage1D = (DelglCompressedTexSubImage1D)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glCompressedTexSubImage1D"), typeof(DelglCompressedTexSubImage1D));
            glCompressedTexSubImage2D = (DelglCompressedTexSubImage2D)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glCompressedTexSubImage2D"), typeof(DelglCompressedTexSubImage2D));
            glCompressedTexSubImage3D = (DelglCompressedTexSubImage3D)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glCompressedTexSubImage3D"), typeof(DelglCompressedTexSubImage3D));
            glCopyBufferSubData = (DelglCopyBufferSubData)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glCopyBufferSubData"), typeof(DelglCopyBufferSubData));
            glCopyTexSubImage3D = (DelglCopyTexSubImage3D)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glCopyTexSubImage3D"), typeof(DelglCopyTexSubImage3D));
            glCreateProgram = (DelglCreateProgram)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glCreateProgram"), typeof(DelglCreateProgram));
            glCreateShader = (DelglCreateShader)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glCreateShader"), typeof(DelglCreateShader));
            glDeleteBuffers = (DelglDeleteBuffers)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDeleteBuffers"), typeof(DelglDeleteBuffers));
            glDeleteFramebuffers = (DelglDeleteFramebuffers)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDeleteFramebuffers"), typeof(DelglDeleteFramebuffers));
            glDeleteProgram = (DelglDeleteProgram)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDeleteProgram"), typeof(DelglDeleteProgram));
            glDeleteQueries = (DelglDeleteQueries)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDeleteQueries"), typeof(DelglDeleteQueries));
            glDeleteRenderbuffers = (DelglDeleteRenderbuffers)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDeleteRenderbuffers"), typeof(DelglDeleteRenderbuffers));
            glDeleteSamplers = (DelglDeleteSamplers)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDeleteSamplers"), typeof(DelglDeleteSamplers));
            glDeleteShader = (DelglDeleteShader)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDeleteShader"), typeof(DelglDeleteShader));
            glDeleteSync = (DelglDeleteSync)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDeleteSync"), typeof(DelglDeleteSync));
            glDeleteVertexArrays = (DelglDeleteVertexArrays)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDeleteVertexArrays"), typeof(DelglDeleteVertexArrays));
            glDetachShader = (DelglDetachShader)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDetachShader"), typeof(DelglDetachShader));
            glDisableVertexAttribArray = (DelglDisableVertexAttribArray)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDisableVertexAttribArray"), typeof(DelglDisableVertexAttribArray));
            glDisablei = (DelglDisablei)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDisablei"), typeof(DelglDisablei));
            glDrawArraysInstanced = (DelglDrawArraysInstanced)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDrawArraysInstanced"), typeof(DelglDrawArraysInstanced));
            glDrawBuffers = (DelglDrawBuffers)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDrawBuffers"), typeof(DelglDrawBuffers));
            glDrawElementsBaseVertex = (DelglDrawElementsBaseVertex)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDrawElementsBaseVertex"), typeof(DelglDrawElementsBaseVertex));
            glDrawElementsInstanced = (DelglDrawElementsInstanced)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDrawElementsInstanced"), typeof(DelglDrawElementsInstanced));
            glDrawElementsInstancedBaseVertex = (DelglDrawElementsInstancedBaseVertex)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDrawElementsInstancedBaseVertex"), typeof(DelglDrawElementsInstancedBaseVertex));
            glDrawRangeElements = (DelglDrawRangeElements)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDrawRangeElements"), typeof(DelglDrawRangeElements));
            glDrawRangeElementsBaseVertex = (DelglDrawRangeElementsBaseVertex)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glDrawRangeElementsBaseVertex"), typeof(DelglDrawRangeElementsBaseVertex));
            glEnableVertexAttribArray = (DelglEnableVertexAttribArray)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glEnableVertexAttribArray"), typeof(DelglEnableVertexAttribArray));
            glEnablei = (DelglEnablei)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glEnablei"), typeof(DelglEnablei));
            glEndConditionalRender = (DelglEndConditionalRender)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glEndConditionalRender"), typeof(DelglEndConditionalRender));
            glEndQuery = (DelglEndQuery)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glEndQuery"), typeof(DelglEndQuery));
            glEndTransformFeedback = (DelglEndTransformFeedback)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glEndTransformFeedback"), typeof(DelglEndTransformFeedback));
            glFenceSync = (DelglFenceSync)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glFenceSync"), typeof(DelglFenceSync));
            glFlushMappedBufferRange = (DelglFlushMappedBufferRange)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glFlushMappedBufferRange"), typeof(DelglFlushMappedBufferRange));
            glFramebufferRenderbuffer = (DelglFramebufferRenderbuffer)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glFramebufferRenderbuffer"), typeof(DelglFramebufferRenderbuffer));
            glFramebufferTexture = (DelglFramebufferTexture)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glFramebufferTexture"), typeof(DelglFramebufferTexture));
            glFramebufferTexture1D = (DelglFramebufferTexture1D)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glFramebufferTexture1D"), typeof(DelglFramebufferTexture1D));
            glFramebufferTexture2D = (DelglFramebufferTexture2D)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glFramebufferTexture2D"), typeof(DelglFramebufferTexture2D));
            glFramebufferTexture3D = (DelglFramebufferTexture3D)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glFramebufferTexture3D"), typeof(DelglFramebufferTexture3D));
            glFramebufferTextureLayer = (DelglFramebufferTextureLayer)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glFramebufferTextureLayer"), typeof(DelglFramebufferTextureLayer));
            glGenBuffers = (DelglGenBuffers)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGenBuffers"), typeof(DelglGenBuffers));
            glGenFramebuffers = (DelglGenFramebuffers)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGenFramebuffers"), typeof(DelglGenFramebuffers));
            glGenQueries = (DelglGenQueries)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGenQueries"), typeof(DelglGenQueries));
            glGenRenderbuffers = (DelglGenRenderbuffers)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGenRenderbuffers"), typeof(DelglGenRenderbuffers));
            glGenSamplers = (DelglGenSamplers)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGenSamplers"), typeof(DelglGenSamplers));
            glGenVertexArrays = (DelglGenVertexArrays)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGenVertexArrays"), typeof(DelglGenVertexArrays));
            glGenerateMipmap = (DelglGenerateMipmap)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGenerateMipmap"), typeof(DelglGenerateMipmap));
            glGetActiveAttrib = (DelglGetActiveAttrib)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetActiveAttrib"), typeof(DelglGetActiveAttrib));
            glGetActiveUniform = (DelglGetActiveUniform)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetActiveUniform"), typeof(DelglGetActiveUniform));
            glGetActiveUniformBlockName = (DelglGetActiveUniformBlockName)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetActiveUniformBlockName"), typeof(DelglGetActiveUniformBlockName));
            glGetActiveUniformBlockiv = (DelglGetActiveUniformBlockiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetActiveUniformBlockiv"), typeof(DelglGetActiveUniformBlockiv));
            glGetActiveUniformName = (DelglGetActiveUniformName)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetActiveUniformName"), typeof(DelglGetActiveUniformName));
            glGetActiveUniformsiv = (DelglGetActiveUniformsiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetActiveUniformsiv"), typeof(DelglGetActiveUniformsiv));
            glGetAttachedShaders = (DelglGetAttachedShaders)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetAttachedShaders"), typeof(DelglGetAttachedShaders));
            glGetAttribLocation = (DelglGetAttribLocation)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetAttribLocation"), typeof(DelglGetAttribLocation));
            glGetBooleani_v = (DelglGetBooleani_v)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetBooleani_v"), typeof(DelglGetBooleani_v));
            glGetBufferParameteri64v = (DelglGetBufferParameteri64v)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetBufferParameteri64v"), typeof(DelglGetBufferParameteri64v));
            glGetBufferParameteriv = (DelglGetBufferParameteriv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetBufferParameteriv"), typeof(DelglGetBufferParameteriv));
            glGetBufferPointerv = (DelglGetBufferPointerv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetBufferPointerv"), typeof(DelglGetBufferPointerv));
            glGetBufferSubData = (DelglGetBufferSubData)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetBufferSubData"), typeof(DelglGetBufferSubData));
            glGetCompressedTexImage = (DelglGetCompressedTexImage)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetCompressedTexImage"), typeof(DelglGetCompressedTexImage));
            glGetFragDataIndex = (DelglGetFragDataIndex)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetFragDataIndex"), typeof(DelglGetFragDataIndex));
            glGetFragDataLocation = (DelglGetFragDataLocation)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetFragDataLocation"), typeof(DelglGetFragDataLocation));
            glGetFramebufferAttachmentParameteriv = (DelglGetFramebufferAttachmentParameteriv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetFramebufferAttachmentParameteriv"), typeof(DelglGetFramebufferAttachmentParameteriv));
            glGetInteger64i_v = (DelglGetInteger64i_v)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetInteger64i_v"), typeof(DelglGetInteger64i_v));
            glGetInteger64v = (DelglGetInteger64v)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetInteger64v"), typeof(DelglGetInteger64v));
            glGetIntegeri_v = (DelglGetIntegeri_v)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetIntegeri_v"), typeof(DelglGetIntegeri_v));
            glGetMultisamplefv = (DelglGetMultisamplefv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetMultisamplefv"), typeof(DelglGetMultisamplefv));
            glGetProgramInfoLog = (DelglGetProgramInfoLog)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetProgramInfoLog"), typeof(DelglGetProgramInfoLog));
            glGetProgramiv = (DelglGetProgramiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetProgramiv"), typeof(DelglGetProgramiv));
            glGetQueryObjecti64v = (DelglGetQueryObjecti64v)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetQueryObjecti64v"), typeof(DelglGetQueryObjecti64v));
            glGetQueryObjectiv = (DelglGetQueryObjectiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetQueryObjectiv"), typeof(DelglGetQueryObjectiv));
            glGetQueryObjectui64v = (DelglGetQueryObjectui64v)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetQueryObjectui64v"), typeof(DelglGetQueryObjectui64v));
            glGetQueryObjectuiv = (DelglGetQueryObjectuiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetQueryObjectuiv"), typeof(DelglGetQueryObjectuiv));
            glGetQueryiv = (DelglGetQueryiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetQueryiv"), typeof(DelglGetQueryiv));
            glGetRenderbufferParameteriv = (DelglGetRenderbufferParameteriv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetRenderbufferParameteriv"), typeof(DelglGetRenderbufferParameteriv));
            glGetSamplerParameterIiv = (DelglGetSamplerParameterIiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetSamplerParameterIiv"), typeof(DelglGetSamplerParameterIiv));
            glGetSamplerParameterIuiv = (DelglGetSamplerParameterIuiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetSamplerParameterIuiv"), typeof(DelglGetSamplerParameterIuiv));
            glGetSamplerParameterfv = (DelglGetSamplerParameterfv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetSamplerParameterfv"), typeof(DelglGetSamplerParameterfv));
            glGetSamplerParameteriv = (DelglGetSamplerParameteriv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetSamplerParameteriv"), typeof(DelglGetSamplerParameteriv));
            glGetShaderInfoLog = (DelglGetShaderInfoLog)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetShaderInfoLog"), typeof(DelglGetShaderInfoLog));
            glGetShaderSource = (DelglGetShaderSource)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetShaderSource"), typeof(DelglGetShaderSource));
            glGetShaderiv = (DelglGetShaderiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetShaderiv"), typeof(DelglGetShaderiv));
            glGetStringi = (DelglGetStringi)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetStringi"), typeof(DelglGetStringi));
            glGetSynciv = (DelglGetSynciv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetSynciv"), typeof(DelglGetSynciv));
            glGetTexParameterIiv = (DelglGetTexParameterIiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetTexParameterIiv"), typeof(DelglGetTexParameterIiv));
            glGetTexParameterIuiv = (DelglGetTexParameterIuiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetTexParameterIuiv"), typeof(DelglGetTexParameterIuiv));
            glGetTransformFeedbackVarying = (DelglGetTransformFeedbackVarying)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetTransformFeedbackVarying"), typeof(DelglGetTransformFeedbackVarying));
            glGetUniformBlockIndex = (DelglGetUniformBlockIndex)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetUniformBlockIndex"), typeof(DelglGetUniformBlockIndex));
            glGetUniformIndices = (DelglGetUniformIndices)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetUniformIndices"), typeof(DelglGetUniformIndices));
            glGetUniformLocation = (DelglGetUniformLocation)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetUniformLocation"), typeof(DelglGetUniformLocation));
            glGetUniformfv = (DelglGetUniformfv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetUniformfv"), typeof(DelglGetUniformfv));
            glGetUniformiv = (DelglGetUniformiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetUniformiv"), typeof(DelglGetUniformiv));
            glGetUniformuiv = (DelglGetUniformuiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetUniformuiv"), typeof(DelglGetUniformuiv));
            glGetVertexAttribIiv = (DelglGetVertexAttribIiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetVertexAttribIiv"), typeof(DelglGetVertexAttribIiv));
            glGetVertexAttribIuiv = (DelglGetVertexAttribIuiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetVertexAttribIuiv"), typeof(DelglGetVertexAttribIuiv));
            glGetVertexAttribPointerv = (DelglGetVertexAttribPointerv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetVertexAttribPointerv"), typeof(DelglGetVertexAttribPointerv));
            glGetVertexAttribdv = (DelglGetVertexAttribdv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetVertexAttribdv"), typeof(DelglGetVertexAttribdv));
            glGetVertexAttribfv = (DelglGetVertexAttribfv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetVertexAttribfv"), typeof(DelglGetVertexAttribfv));
            glGetVertexAttribiv = (DelglGetVertexAttribiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glGetVertexAttribiv"), typeof(DelglGetVertexAttribiv));
            glIsBuffer = (DelglIsBuffer)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glIsBuffer"), typeof(DelglIsBuffer));
            glIsEnabledi = (DelglIsEnabledi)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glIsEnabledi"), typeof(DelglIsEnabledi));
            glIsFramebuffer = (DelglIsFramebuffer)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glIsFramebuffer"), typeof(DelglIsFramebuffer));
            glIsProgram = (DelglIsProgram)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glIsProgram"), typeof(DelglIsProgram));
            glIsQuery = (DelglIsQuery)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glIsQuery"), typeof(DelglIsQuery));
            glIsRenderbuffer = (DelglIsRenderbuffer)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glIsRenderbuffer"), typeof(DelglIsRenderbuffer));
            glIsSampler = (DelglIsSampler)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glIsSampler"), typeof(DelglIsSampler));
            glIsShader = (DelglIsShader)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glIsShader"), typeof(DelglIsShader));
            glIsSync = (DelglIsSync)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glIsSync"), typeof(DelglIsSync));
            glIsVertexArray = (DelglIsVertexArray)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glIsVertexArray"), typeof(DelglIsVertexArray));
            glLinkProgram = (DelglLinkProgram)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glLinkProgram"), typeof(DelglLinkProgram));
            glMapBuffer = (DelglMapBuffer)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glMapBuffer"), typeof(DelglMapBuffer));
            glMapBufferRange = (DelglMapBufferRange)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glMapBufferRange"), typeof(DelglMapBufferRange));
            glMultiDrawArrays = (DelglMultiDrawArrays)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glMultiDrawArrays"), typeof(DelglMultiDrawArrays));
            glMultiDrawElements = (DelglMultiDrawElements)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glMultiDrawElements"), typeof(DelglMultiDrawElements));
            glMultiDrawElementsBaseVertex = (DelglMultiDrawElementsBaseVertex)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glMultiDrawElementsBaseVertex"), typeof(DelglMultiDrawElementsBaseVertex));
            glMultiTexCoordP1ui = (DelglMultiTexCoordP1ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glMultiTexCoordP1ui"), typeof(DelglMultiTexCoordP1ui));
            glMultiTexCoordP1uiv = (DelglMultiTexCoordP1uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glMultiTexCoordP1uiv"), typeof(DelglMultiTexCoordP1uiv));
            glMultiTexCoordP2ui = (DelglMultiTexCoordP2ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glMultiTexCoordP2ui"), typeof(DelglMultiTexCoordP2ui));
            glMultiTexCoordP2uiv = (DelglMultiTexCoordP2uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glMultiTexCoordP2uiv"), typeof(DelglMultiTexCoordP2uiv));
            glMultiTexCoordP3ui = (DelglMultiTexCoordP3ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glMultiTexCoordP3ui"), typeof(DelglMultiTexCoordP3ui));
            glMultiTexCoordP3uiv = (DelglMultiTexCoordP3uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glMultiTexCoordP3uiv"), typeof(DelglMultiTexCoordP3uiv));
            glMultiTexCoordP4ui = (DelglMultiTexCoordP4ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glMultiTexCoordP4ui"), typeof(DelglMultiTexCoordP4ui));
            glMultiTexCoordP4uiv = (DelglMultiTexCoordP4uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glMultiTexCoordP4uiv"), typeof(DelglMultiTexCoordP4uiv));
            glNormalP3ui = (DelglNormalP3ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glNormalP3ui"), typeof(DelglNormalP3ui));
            glNormalP3uiv = (DelglNormalP3uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glNormalP3uiv"), typeof(DelglNormalP3uiv));
            glPointParameterf = (DelglPointParameterf)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glPointParameterf"), typeof(DelglPointParameterf));
            glPointParameterfv = (DelglPointParameterfv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glPointParameterfv"), typeof(DelglPointParameterfv));
            glPointParameteri = (DelglPointParameteri)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glPointParameteri"), typeof(DelglPointParameteri));
            glPointParameteriv = (DelglPointParameteriv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glPointParameteriv"), typeof(DelglPointParameteriv));
            glPrimitiveRestartIndex = (DelglPrimitiveRestartIndex)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glPrimitiveRestartIndex"), typeof(DelglPrimitiveRestartIndex));
            glProvokingVertex = (DelglProvokingVertex)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glProvokingVertex"), typeof(DelglProvokingVertex));
            glQueryCounter = (DelglQueryCounter)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glQueryCounter"), typeof(DelglQueryCounter));
            glRenderbufferStorage = (DelglRenderbufferStorage)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glRenderbufferStorage"), typeof(DelglRenderbufferStorage));
            glRenderbufferStorageMultisample = (DelglRenderbufferStorageMultisample)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glRenderbufferStorageMultisample"), typeof(DelglRenderbufferStorageMultisample));
            glSampleCoverage = (DelglSampleCoverage)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glSampleCoverage"), typeof(DelglSampleCoverage));
            glSampleMaski = (DelglSampleMaski)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glSampleMaski"), typeof(DelglSampleMaski));
            glSamplerParameterIiv = (DelglSamplerParameterIiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glSamplerParameterIiv"), typeof(DelglSamplerParameterIiv));
            glSamplerParameterIuiv = (DelglSamplerParameterIuiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glSamplerParameterIuiv"), typeof(DelglSamplerParameterIuiv));
            glSamplerParameterf = (DelglSamplerParameterf)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glSamplerParameterf"), typeof(DelglSamplerParameterf));
            glSamplerParameterfv = (DelglSamplerParameterfv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glSamplerParameterfv"), typeof(DelglSamplerParameterfv));
            glSamplerParameteri = (DelglSamplerParameteri)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glSamplerParameteri"), typeof(DelglSamplerParameteri));
            glSamplerParameteriv = (DelglSamplerParameteriv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glSamplerParameteriv"), typeof(DelglSamplerParameteriv));
            glSecondaryColorP3ui = (DelglSecondaryColorP3ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glSecondaryColorP3ui"), typeof(DelglSecondaryColorP3ui));
            glSecondaryColorP3uiv = (DelglSecondaryColorP3uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glSecondaryColorP3uiv"), typeof(DelglSecondaryColorP3uiv));
            glShaderSource = (DelglShaderSource)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glShaderSource"), typeof(DelglShaderSource));
            glStencilFuncSeparate = (DelglStencilFuncSeparate)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glStencilFuncSeparate"), typeof(DelglStencilFuncSeparate));
            glStencilMaskSeparate = (DelglStencilMaskSeparate)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glStencilMaskSeparate"), typeof(DelglStencilMaskSeparate));
            glStencilOpSeparate = (DelglStencilOpSeparate)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glStencilOpSeparate"), typeof(DelglStencilOpSeparate));
            glTexBuffer = (DelglTexBuffer)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glTexBuffer"), typeof(DelglTexBuffer));
            glTexCoordP1ui = (DelglTexCoordP1ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glTexCoordP1ui"), typeof(DelglTexCoordP1ui));
            glTexCoordP1uiv = (DelglTexCoordP1uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glTexCoordP1uiv"), typeof(DelglTexCoordP1uiv));
            glTexCoordP2ui = (DelglTexCoordP2ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glTexCoordP2ui"), typeof(DelglTexCoordP2ui));
            glTexCoordP2uiv = (DelglTexCoordP2uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glTexCoordP2uiv"), typeof(DelglTexCoordP2uiv));
            glTexCoordP3ui = (DelglTexCoordP3ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glTexCoordP3ui"), typeof(DelglTexCoordP3ui));
            glTexCoordP3uiv = (DelglTexCoordP3uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glTexCoordP3uiv"), typeof(DelglTexCoordP3uiv));
            glTexCoordP4ui = (DelglTexCoordP4ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glTexCoordP4ui"), typeof(DelglTexCoordP4ui));
            glTexCoordP4uiv = (DelglTexCoordP4uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glTexCoordP4uiv"), typeof(DelglTexCoordP4uiv));
            glTexImage2DMultisample = (DelglTexImage2DMultisample)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glTexImage2DMultisample"), typeof(DelglTexImage2DMultisample));
            glTexImage3D = (DelglTexImage3D)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glTexImage3D"), typeof(DelglTexImage3D));
            glTexImage3DMultisample = (DelglTexImage3DMultisample)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glTexImage3DMultisample"), typeof(DelglTexImage3DMultisample));
            glTexParameterIiv = (DelglTexParameterIiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glTexParameterIiv"), typeof(DelglTexParameterIiv));
            glTexParameterIuiv = (DelglTexParameterIuiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glTexParameterIuiv"), typeof(DelglTexParameterIuiv));
            glTexSubImage3D = (DelglTexSubImage3D)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glTexSubImage3D"), typeof(DelglTexSubImage3D));
            glTransformFeedbackVaryings = (DelglTransformFeedbackVaryings)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glTransformFeedbackVaryings"), typeof(DelglTransformFeedbackVaryings));
            glUniform1f = (DelglUniform1f)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform1f"), typeof(DelglUniform1f));
            glUniform1fv = (DelglUniform1fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform1fv"), typeof(DelglUniform1fv));
            glUniform1i = (DelglUniform1i)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform1i"), typeof(DelglUniform1i));
            glUniform1iv = (DelglUniform1iv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform1iv"), typeof(DelglUniform1iv));
            glUniform1ui = (DelglUniform1ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform1ui"), typeof(DelglUniform1ui));
            glUniform1uiv = (DelglUniform1uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform1uiv"), typeof(DelglUniform1uiv));
            glUniform2f = (DelglUniform2f)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform2f"), typeof(DelglUniform2f));
            glUniform2fv = (DelglUniform2fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform2fv"), typeof(DelglUniform2fv));
            glUniform2i = (DelglUniform2i)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform2i"), typeof(DelglUniform2i));
            glUniform2iv = (DelglUniform2iv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform2iv"), typeof(DelglUniform2iv));
            glUniform2ui = (DelglUniform2ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform2ui"), typeof(DelglUniform2ui));
            glUniform2uiv = (DelglUniform2uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform2uiv"), typeof(DelglUniform2uiv));
            glUniform3f = (DelglUniform3f)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform3f"), typeof(DelglUniform3f));
            glUniform3fv = (DelglUniform3fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform3fv"), typeof(DelglUniform3fv));
            glUniform3i = (DelglUniform3i)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform3i"), typeof(DelglUniform3i));
            glUniform3iv = (DelglUniform3iv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform3iv"), typeof(DelglUniform3iv));
            glUniform3ui = (DelglUniform3ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform3ui"), typeof(DelglUniform3ui));
            glUniform3uiv = (DelglUniform3uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform3uiv"), typeof(DelglUniform3uiv));
            glUniform4f = (DelglUniform4f)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform4f"), typeof(DelglUniform4f));
            glUniform4fv = (DelglUniform4fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform4fv"), typeof(DelglUniform4fv));
            glUniform4i = (DelglUniform4i)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform4i"), typeof(DelglUniform4i));
            glUniform4iv = (DelglUniform4iv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform4iv"), typeof(DelglUniform4iv));
            glUniform4ui = (DelglUniform4ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform4ui"), typeof(DelglUniform4ui));
            glUniform4uiv = (DelglUniform4uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniform4uiv"), typeof(DelglUniform4uiv));
            glUniformBlockBinding = (DelglUniformBlockBinding)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniformBlockBinding"), typeof(DelglUniformBlockBinding));
            glUniformMatrix2fv = (DelglUniformMatrix2fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniformMatrix2fv"), typeof(DelglUniformMatrix2fv));
            glUniformMatrix2x3fv = (DelglUniformMatrix2x3fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniformMatrix2x3fv"), typeof(DelglUniformMatrix2x3fv));
            glUniformMatrix2x4fv = (DelglUniformMatrix2x4fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniformMatrix2x4fv"), typeof(DelglUniformMatrix2x4fv));
            glUniformMatrix3fv = (DelglUniformMatrix3fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniformMatrix3fv"), typeof(DelglUniformMatrix3fv));
            glUniformMatrix3x2fv = (DelglUniformMatrix3x2fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniformMatrix3x2fv"), typeof(DelglUniformMatrix3x2fv));
            glUniformMatrix3x4fv = (DelglUniformMatrix3x4fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniformMatrix3x4fv"), typeof(DelglUniformMatrix3x4fv));
            glUniformMatrix4fv = (DelglUniformMatrix4fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniformMatrix4fv"), typeof(DelglUniformMatrix4fv));
            glUniformMatrix4x2fv = (DelglUniformMatrix4x2fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniformMatrix4x2fv"), typeof(DelglUniformMatrix4x2fv));
            glUniformMatrix4x3fv = (DelglUniformMatrix4x3fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUniformMatrix4x3fv"), typeof(DelglUniformMatrix4x3fv));
            glUnmapBuffer = (DelglUnmapBuffer)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUnmapBuffer"), typeof(DelglUnmapBuffer));
            glUseProgram = (DelglUseProgram)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glUseProgram"), typeof(DelglUseProgram));
            glValidateProgram = (DelglValidateProgram)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glValidateProgram"), typeof(DelglValidateProgram));
            glVertexAttrib1d = (DelglVertexAttrib1d)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib1d"), typeof(DelglVertexAttrib1d));
            glVertexAttrib1dv = (DelglVertexAttrib1dv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib1dv"), typeof(DelglVertexAttrib1dv));
            glVertexAttrib1f = (DelglVertexAttrib1f)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib1f"), typeof(DelglVertexAttrib1f));
            glVertexAttrib1fv = (DelglVertexAttrib1fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib1fv"), typeof(DelglVertexAttrib1fv));
            glVertexAttrib1s = (DelglVertexAttrib1s)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib1s"), typeof(DelglVertexAttrib1s));
            glVertexAttrib1sv = (DelglVertexAttrib1sv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib1sv"), typeof(DelglVertexAttrib1sv));
            glVertexAttrib2d = (DelglVertexAttrib2d)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib2d"), typeof(DelglVertexAttrib2d));
            glVertexAttrib2dv = (DelglVertexAttrib2dv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib2dv"), typeof(DelglVertexAttrib2dv));
            glVertexAttrib2f = (DelglVertexAttrib2f)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib2f"), typeof(DelglVertexAttrib2f));
            glVertexAttrib2fv = (DelglVertexAttrib2fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib2fv"), typeof(DelglVertexAttrib2fv));
            glVertexAttrib2s = (DelglVertexAttrib2s)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib2s"), typeof(DelglVertexAttrib2s));
            glVertexAttrib2sv = (DelglVertexAttrib2sv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib2sv"), typeof(DelglVertexAttrib2sv));
            glVertexAttrib3d = (DelglVertexAttrib3d)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib3d"), typeof(DelglVertexAttrib3d));
            glVertexAttrib3dv = (DelglVertexAttrib3dv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib3dv"), typeof(DelglVertexAttrib3dv));
            glVertexAttrib3f = (DelglVertexAttrib3f)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib3f"), typeof(DelglVertexAttrib3f));
            glVertexAttrib3fv = (DelglVertexAttrib3fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib3fv"), typeof(DelglVertexAttrib3fv));
            glVertexAttrib3s = (DelglVertexAttrib3s)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib3s"), typeof(DelglVertexAttrib3s));
            glVertexAttrib3sv = (DelglVertexAttrib3sv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib3sv"), typeof(DelglVertexAttrib3sv));
            glVertexAttrib4Nbv = (DelglVertexAttrib4Nbv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4Nbv"), typeof(DelglVertexAttrib4Nbv));
            glVertexAttrib4Niv = (DelglVertexAttrib4Niv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4Niv"), typeof(DelglVertexAttrib4Niv));
            glVertexAttrib4Nsv = (DelglVertexAttrib4Nsv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4Nsv"), typeof(DelglVertexAttrib4Nsv));
            glVertexAttrib4Nub = (DelglVertexAttrib4Nub)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4Nub"), typeof(DelglVertexAttrib4Nub));
            glVertexAttrib4Nubv = (DelglVertexAttrib4Nubv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4Nubv"), typeof(DelglVertexAttrib4Nubv));
            glVertexAttrib4Nuiv = (DelglVertexAttrib4Nuiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4Nuiv"), typeof(DelglVertexAttrib4Nuiv));
            glVertexAttrib4Nusv = (DelglVertexAttrib4Nusv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4Nusv"), typeof(DelglVertexAttrib4Nusv));
            glVertexAttrib4bv = (DelglVertexAttrib4bv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4bv"), typeof(DelglVertexAttrib4bv));
            glVertexAttrib4d = (DelglVertexAttrib4d)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4d"), typeof(DelglVertexAttrib4d));
            glVertexAttrib4dv = (DelglVertexAttrib4dv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4dv"), typeof(DelglVertexAttrib4dv));
            glVertexAttrib4f = (DelglVertexAttrib4f)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4f"), typeof(DelglVertexAttrib4f));
            glVertexAttrib4fv = (DelglVertexAttrib4fv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4fv"), typeof(DelglVertexAttrib4fv));
            glVertexAttrib4iv = (DelglVertexAttrib4iv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4iv"), typeof(DelglVertexAttrib4iv));
            glVertexAttrib4s = (DelglVertexAttrib4s)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4s"), typeof(DelglVertexAttrib4s));
            glVertexAttrib4sv = (DelglVertexAttrib4sv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4sv"), typeof(DelglVertexAttrib4sv));
            glVertexAttrib4ubv = (DelglVertexAttrib4ubv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4ubv"), typeof(DelglVertexAttrib4ubv));
            glVertexAttrib4uiv = (DelglVertexAttrib4uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4uiv"), typeof(DelglVertexAttrib4uiv));
            glVertexAttrib4usv = (DelglVertexAttrib4usv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttrib4usv"), typeof(DelglVertexAttrib4usv));
            glVertexAttribDivisor = (DelglVertexAttribDivisor)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribDivisor"), typeof(DelglVertexAttribDivisor));
            glVertexAttribI1i = (DelglVertexAttribI1i)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI1i"), typeof(DelglVertexAttribI1i));
            glVertexAttribI1iv = (DelglVertexAttribI1iv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI1iv"), typeof(DelglVertexAttribI1iv));
            glVertexAttribI1ui = (DelglVertexAttribI1ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI1ui"), typeof(DelglVertexAttribI1ui));
            glVertexAttribI1uiv = (DelglVertexAttribI1uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI1uiv"), typeof(DelglVertexAttribI1uiv));
            glVertexAttribI2i = (DelglVertexAttribI2i)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI2i"), typeof(DelglVertexAttribI2i));
            glVertexAttribI2iv = (DelglVertexAttribI2iv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI2iv"), typeof(DelglVertexAttribI2iv));
            glVertexAttribI2ui = (DelglVertexAttribI2ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI2ui"), typeof(DelglVertexAttribI2ui));
            glVertexAttribI2uiv = (DelglVertexAttribI2uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI2uiv"), typeof(DelglVertexAttribI2uiv));
            glVertexAttribI3i = (DelglVertexAttribI3i)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI3i"), typeof(DelglVertexAttribI3i));
            glVertexAttribI3iv = (DelglVertexAttribI3iv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI3iv"), typeof(DelglVertexAttribI3iv));
            glVertexAttribI3ui = (DelglVertexAttribI3ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI3ui"), typeof(DelglVertexAttribI3ui));
            glVertexAttribI3uiv = (DelglVertexAttribI3uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI3uiv"), typeof(DelglVertexAttribI3uiv));
            glVertexAttribI4bv = (DelglVertexAttribI4bv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI4bv"), typeof(DelglVertexAttribI4bv));
            glVertexAttribI4i = (DelglVertexAttribI4i)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI4i"), typeof(DelglVertexAttribI4i));
            glVertexAttribI4iv = (DelglVertexAttribI4iv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI4iv"), typeof(DelglVertexAttribI4iv));
            glVertexAttribI4sv = (DelglVertexAttribI4sv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI4sv"), typeof(DelglVertexAttribI4sv));
            glVertexAttribI4ubv = (DelglVertexAttribI4ubv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI4ubv"), typeof(DelglVertexAttribI4ubv));
            glVertexAttribI4ui = (DelglVertexAttribI4ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI4ui"), typeof(DelglVertexAttribI4ui));
            glVertexAttribI4uiv = (DelglVertexAttribI4uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI4uiv"), typeof(DelglVertexAttribI4uiv));
            glVertexAttribI4usv = (DelglVertexAttribI4usv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribI4usv"), typeof(DelglVertexAttribI4usv));
            glVertexAttribIPointer = (DelglVertexAttribIPointer)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribIPointer"), typeof(DelglVertexAttribIPointer));
            glVertexAttribP1ui = (DelglVertexAttribP1ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribP1ui"), typeof(DelglVertexAttribP1ui));
            glVertexAttribP1uiv = (DelglVertexAttribP1uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribP1uiv"), typeof(DelglVertexAttribP1uiv));
            glVertexAttribP2ui = (DelglVertexAttribP2ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribP2ui"), typeof(DelglVertexAttribP2ui));
            glVertexAttribP2uiv = (DelglVertexAttribP2uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribP2uiv"), typeof(DelglVertexAttribP2uiv));
            glVertexAttribP3ui = (DelglVertexAttribP3ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribP3ui"), typeof(DelglVertexAttribP3ui));
            glVertexAttribP3uiv = (DelglVertexAttribP3uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribP3uiv"), typeof(DelglVertexAttribP3uiv));
            glVertexAttribP4ui = (DelglVertexAttribP4ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribP4ui"), typeof(DelglVertexAttribP4ui));
            glVertexAttribP4uiv = (DelglVertexAttribP4uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribP4uiv"), typeof(DelglVertexAttribP4uiv));
            glVertexAttribPointer = (DelglVertexAttribPointer)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexAttribPointer"), typeof(DelglVertexAttribPointer));
            glVertexP2ui = (DelglVertexP2ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexP2ui"), typeof(DelglVertexP2ui));
            glVertexP2uiv = (DelglVertexP2uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexP2uiv"), typeof(DelglVertexP2uiv));
            glVertexP3ui = (DelglVertexP3ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexP3ui"), typeof(DelglVertexP3ui));
            glVertexP3uiv = (DelglVertexP3uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexP3uiv"), typeof(DelglVertexP3uiv));
            glVertexP4ui = (DelglVertexP4ui)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexP4ui"), typeof(DelglVertexP4ui));
            glVertexP4uiv = (DelglVertexP4uiv)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glVertexP4uiv"), typeof(DelglVertexP4uiv));
            glWaitSync = (DelglWaitSync)Marshal.GetDelegateForFunctionPointer(wglGetProcAddress("glWaitSync"), typeof(DelglWaitSync));
        }
    }
}
#pragma warning restore CS0618