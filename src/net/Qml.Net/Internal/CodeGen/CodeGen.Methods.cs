using System;
using System.Drawing;
#if NETSTANDARD2_1
using System.Numerics;
#endif
using System.Reflection;
using Qml.Net.Internal.Qml;
using Qml.Net.Internal.Types;

namespace Qml.Net.Internal.CodeGen
{
    internal partial class CodeGen
    {
        private class GenericMethods
        {
            public static PropertyInfo InstanceProperty = typeof(NetReference).GetProperty(nameof(NetReference.Instance));
        }

        private class LoadMethods
        {
            public static MethodInfo LoadBoolMethod = typeof(LoadMethods).GetMethod(nameof(LoadBool), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadBoolNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadBoolNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadCharMethod = typeof(LoadMethods).GetMethod(nameof(LoadChar), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadCharNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadCharNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadIntMethod = typeof(LoadMethods).GetMethod(nameof(LoadInt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadIntNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadIntNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadUIntMethod = typeof(LoadMethods).GetMethod(nameof(LoadUInt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadUIntNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadUIntNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadLongMethod = typeof(LoadMethods).GetMethod(nameof(LoadLong), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadLongNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadLongNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadULongMethod = typeof(LoadMethods).GetMethod(nameof(LoadULong), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadULongNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadULongNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadFloatMethod = typeof(LoadMethods).GetMethod(nameof(LoadFloat), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadFloatNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadFloatNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadDoubleMethod = typeof(LoadMethods).GetMethod(nameof(LoadDouble), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadDoubleNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadDoubleNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadSizeMethod = typeof(LoadMethods).GetMethod(nameof(LoadSize), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadSizeNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadSizeNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadSizeFMethod = typeof(LoadMethods).GetMethod(nameof(LoadSizeF), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadSizeFNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadSizeFNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadRectMethod = typeof(LoadMethods).GetMethod(nameof(LoadRect), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadRectNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadRectNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadRectFMethod = typeof(LoadMethods).GetMethod(nameof(LoadRectF), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadRectFNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadRectFNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadPointMethod = typeof(LoadMethods).GetMethod(nameof(LoadPoint), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadPointNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadPointNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadPointFMethod = typeof(LoadMethods).GetMethod(nameof(LoadPointF), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadPointFNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadPointFNullable), BindingFlags.Static | BindingFlags.NonPublic);
#if NETSTANDARD2_1
            public static MethodInfo LoadVector2DMethod = typeof(LoadMethods).GetMethod(nameof(LoadVector2D), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadVector2DNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadVector2DNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadVector3DMethod = typeof(LoadMethods).GetMethod(nameof(LoadVector3D), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadVector3DNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadVector3DNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadVector4DMethod = typeof(LoadMethods).GetMethod(nameof(LoadVector4D), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadVector4DNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadVector4DNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadQuaternionMethod = typeof(LoadMethods).GetMethod(nameof(LoadQuaternion), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadQuaternionNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadQuaternionNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadMatrix4x4Method = typeof(LoadMethods).GetMethod(nameof(LoadMatrix4x4), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadMatrix4x4NullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadMatrix4x4Nullable), BindingFlags.Static | BindingFlags.NonPublic);
#endif
            public static MethodInfo LoadColorMethod = typeof(LoadMethods).GetMethod(nameof(LoadColor), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadStringMethod = typeof(LoadMethods).GetMethod(nameof(LoadString), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadByteArrayMethod = typeof(LoadMethods).GetMethod(nameof(LoadByteArray), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadDateTimeMethod = typeof(LoadMethods).GetMethod(nameof(LoadDateTime), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadDateTimeNullableMethod = typeof(LoadMethods).GetMethod(nameof(LoadDateTimeNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LoadObjectMethod = typeof(LoadMethods).GetMethod(nameof(LoadObject), BindingFlags.Static | BindingFlags.NonPublic);

            private static void LoadBool(NetVariant variant, bool value)
            {
                variant.Bool = value;
            }

            private static void LoadBoolNullable(NetVariant variant, bool? value)
            {
                if (value.HasValue)
                {
                    variant.Bool = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadChar(NetVariant variant, char value)
            {
                variant.Char = value;
            }

            private static void LoadCharNullable(NetVariant variant, char? value)
            {
                if (value.HasValue)
                {
                    variant.Char = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadInt(NetVariant variant, int value)
            {
                variant.Int = value;
            }

            private static void LoadIntNullable(NetVariant variant, int? value)
            {
                if (value.HasValue)
                {
                    variant.Int = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadUInt(NetVariant variant, uint value)
            {
                variant.UInt = value;
            }

            private static void LoadUIntNullable(NetVariant variant, uint? value)
            {
                if (value.HasValue)
                {
                    variant.UInt = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadLong(NetVariant variant, long value)
            {
                variant.Long = value;
            }

            private static void LoadLongNullable(NetVariant variant, long? value)
            {
                if (value.HasValue)
                {
                    variant.Long = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadULong(NetVariant variant, ulong value)
            {
                variant.ULong = value;
            }

            private static void LoadULongNullable(NetVariant variant, ulong? value)
            {
                if (value.HasValue)
                {
                    variant.ULong = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadFloat(NetVariant variant, float value)
            {
                variant.Float = value;
            }

            private static void LoadFloatNullable(NetVariant variant, float? value)
            {
                if (value.HasValue)
                {
                    variant.Float = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadDouble(NetVariant variant, double value)
            {
                variant.Double = value;
            }

            private static void LoadDoubleNullable(NetVariant variant, double? value)
            {
                if (value.HasValue)
                {
                    variant.Double = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadSize(NetVariant variant, Size value)
            {
                variant.Size = value;
            }

            private static void LoadSizeNullable(NetVariant variant, Size? value)
            {
                if (value.HasValue)
                {
                    variant.Size = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadSizeF(NetVariant variant, SizeF value)
            {
                variant.SizeF = value;
            }

            private static void LoadSizeFNullable(NetVariant variant, SizeF? value)
            {
                if (value.HasValue)
                {
                    variant.SizeF = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadRect(NetVariant variant, Rectangle value)
            {
                variant.Rect = value;
            }

            private static void LoadRectNullable(NetVariant variant, Rectangle? value)
            {
                if (value.HasValue)
                {
                    variant.Rect = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadRectF(NetVariant variant, RectangleF value)
            {
                variant.RectF = value;
            }

            private static void LoadRectFNullable(NetVariant variant, RectangleF? value)
            {
                if (value.HasValue)
                {
                    variant.RectF = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadPoint(NetVariant variant, Point value)
            {
                variant.Point = value;
            }

            private static void LoadPointNullable(NetVariant variant, Point? value)
            {
                if (value.HasValue)
                {
                    variant.Point = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadPointF(NetVariant variant, PointF value)
            {
                variant.PointF = value;
            }

            private static void LoadPointFNullable(NetVariant variant, PointF? value)
            {
                if (value.HasValue)
                {
                    variant.PointF = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }
            
#if NETSTANDARD2_1
            private static void LoadVector2D(NetVariant variant, Vector2 value)
            {
                variant.Vector2D = value;
            }

            private static void LoadVector2DNullable(NetVariant variant, Vector2? value)
            {
                if (value.HasValue)
                {
                    variant.Vector2D = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadVector3D(NetVariant variant, Vector3 value)
            {
                variant.Vector3D = value;
            }

            private static void LoadVector3DNullable(NetVariant variant, Vector3? value)
            {
                if (value.HasValue)
                {
                    variant.Vector3D = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadVector4D(NetVariant variant, Vector4 value)
            {
                variant.Vector4D = value;
            }

            private static void LoadVector4DNullable(NetVariant variant, Vector4? value)
            {
                if (value.HasValue)
                {
                    variant.Vector4D = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadQuaternion(NetVariant variant, Quaternion value)
            {
                variant.Quaternion = value;
            }

            private static void LoadQuaternionNullable(NetVariant variant, Quaternion? value)
            {
                if (value.HasValue)
                {
                    variant.Quaternion = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadMatrix4x4(NetVariant variant, Matrix4x4 value)
            {
                variant.Matrix4x4 = value;
            }

            private static void LoadMatrix4x4Nullable(NetVariant variant, Matrix4x4? value)
            {
                if (value.HasValue)
                {
                    variant.Matrix4x4 = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }
#endif

            private static void LoadColor(NetVariant variant, Color value)
            {
                if (value.IsEmpty)
                {
                    variant.SetNull();
                }
                else
                {
                    variant.Color = value;
                }
            }

            private static void LoadString(NetVariant variant, string value)
            {
                if (value == null)
                {
                    variant.SetNull();
                }
                else
                {
                    variant.String = value;
                }
            }

             private static void LoadByteArray(NetVariant variant, byte[] value)
            {
                if (value == null)
                {
                    variant.SetNull();
                }
                else
                {
                    variant.ByteArray = value;
                }
            }

            private static void LoadDateTime(NetVariant variant, DateTimeOffset value)
            {
                variant.DateTime = value;
            }

            private static void LoadDateTimeNullable(NetVariant variant, DateTimeOffset? value)
            {
                if (value.HasValue)
                {
                    variant.DateTime = value.Value;
                }
                else
                {
                    variant.SetNull();
                }
            }

            private static void LoadObject(NetVariant variant, object value)
            {
                if (value != null)
                {
                    if (value is bool valueBool)
                    {
                        variant.Bool = valueBool;
                    }
                    else if (value is char valueChar)
                    {
                        variant.Char = valueChar;
                    }
                    else if (value is int valueInt)
                    {
                        variant.Int = valueInt;
                    }
                    else if (value is uint valueUInt)
                    {
                        variant.UInt = valueUInt;
                    }
                    else if (value is long valueLong)
                    {
                        variant.Long = valueLong;
                    }
                    else if (value is ulong valueULong)
                    {
                        variant.ULong = valueULong;
                    }
                    else if (value is float valueFloat)
                    {
                        variant.Float = valueFloat;
                    }
                    else if (value is double valueDouble)
                    {
                        variant.Double = valueDouble;
                    }
                    else if (value is string valueString)
                    {
                        variant.String = valueString;
                    }
                    else if (value is DateTimeOffset valueDateTimeOffset)
                    {
                        variant.DateTime = valueDateTimeOffset;
                    }
                    else if (value is NetJsValue valueJsValue)
                    {
                        variant.JsValue = valueJsValue;
                    }
                    else if (value is NetQObject valueQObject)
                    {
                        variant.QObject = valueQObject;
                    }
                    else
                    {
                        variant.Instance = NetReference.CreateForObject(value);
                    }
                }
                else
                {
                    variant.SetNull();
                }
            }
        }

        private class ListMethods
        {
            public static MethodInfo BoolAtMethod = typeof(ListMethods).GetMethod(nameof(BoolAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo BoolNullableAtMethod = typeof(ListMethods).GetMethod(nameof(BoolNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo CharAtMethod = typeof(ListMethods).GetMethod(nameof(CharAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo CharNullableAtMethod = typeof(ListMethods).GetMethod(nameof(CharNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo IntAtMethod = typeof(ListMethods).GetMethod(nameof(IntAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo IntNullableAtMethod = typeof(ListMethods).GetMethod(nameof(IntNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo UIntAtMethod = typeof(ListMethods).GetMethod(nameof(UIntAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo UIntNullableAtMethod = typeof(ListMethods).GetMethod(nameof(UIntNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LongAtMethod = typeof(ListMethods).GetMethod(nameof(LongAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LongNullableAtMethod = typeof(ListMethods).GetMethod(nameof(LongNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo ULongAtMethod = typeof(ListMethods).GetMethod(nameof(ULongAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo ULongNullableAtMethod = typeof(ListMethods).GetMethod(nameof(ULongNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo FloatAtMethod = typeof(ListMethods).GetMethod(nameof(FloatAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo FloatNullableAtMethod = typeof(ListMethods).GetMethod(nameof(FloatNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo DoubleAtMethod = typeof(ListMethods).GetMethod(nameof(DoubleAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo DoubleNullableAtMethod = typeof(ListMethods).GetMethod(nameof(DoubleNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo SizeAtMethod = typeof(ListMethods).GetMethod(nameof(SizeAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo SizeNullableAtMethod = typeof(ListMethods).GetMethod(nameof(SizeNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo SizeFAtMethod = typeof(ListMethods).GetMethod(nameof(SizeFAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo SizeFNullableAtMethod = typeof(ListMethods).GetMethod(nameof(SizeFNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo RectAtMethod = typeof(ListMethods).GetMethod(nameof(RectAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo RectNullableAtMethod = typeof(ListMethods).GetMethod(nameof(RectNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo RectFAtMethod = typeof(ListMethods).GetMethod(nameof(RectFAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo RectFNullableAtMethod = typeof(ListMethods).GetMethod(nameof(RectFNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo PointAtMethod = typeof(ListMethods).GetMethod(nameof(PointAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo PointNullableAtMethod = typeof(ListMethods).GetMethod(nameof(PointNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo PointFAtMethod = typeof(ListMethods).GetMethod(nameof(PointFAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo PointFNullableAtMethod = typeof(ListMethods).GetMethod(nameof(PointFNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
#if NETSTANDARD2_1
            public static MethodInfo Vector2DAtMethod = typeof(ListMethods).GetMethod(nameof(Vector2DAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo Vector2DNullableAtMethod = typeof(ListMethods).GetMethod(nameof(Vector2DNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo Vector3DAtMethod = typeof(ListMethods).GetMethod(nameof(Vector3DAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo Vector3DNullableAtMethod = typeof(ListMethods).GetMethod(nameof(Vector3DNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo Vector4DAtMethod = typeof(ListMethods).GetMethod(nameof(Vector4DAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo Vector4DNullableAtMethod = typeof(ListMethods).GetMethod(nameof(Vector4DNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo QuaternionAtMethod = typeof(ListMethods).GetMethod(nameof(QuaternionAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo QuaternionNullableAtMethod = typeof(ListMethods).GetMethod(nameof(QuaternionNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo Matrix4x4AtMethod = typeof(ListMethods).GetMethod(nameof(Matrix4x4At), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo Matrix4x4NullableAtMethod = typeof(ListMethods).GetMethod(nameof(Matrix4x4NullableAt), BindingFlags.Static | BindingFlags.NonPublic);
#endif
            public static MethodInfo ColorAtMethod = typeof(ListMethods).GetMethod(nameof(ColorAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo StringAtMethod = typeof(ListMethods).GetMethod(nameof(StringAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo ByteArrayAtMethod = typeof(ListMethods).GetMethod(nameof(ByteArrayAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo DateTimeAtMethod = typeof(ListMethods).GetMethod(nameof(DateTimeAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo DateTimeNullableAtMethod = typeof(ListMethods).GetMethod(nameof(DateTimeNullableAt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo ObjectAtMethod = typeof(ListMethods).GetMethod(nameof(ObjectAt), BindingFlags.Static | BindingFlags.NonPublic);

            private static bool BoolAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant != null && variant.Bool;
                }
            }

            private static bool? BoolNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.Bool;
                }
            }

            private static char CharAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.Char ?? default(char);
                }
            }

            private static char? CharNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.Char;
                }
            }

            private static int IntAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.Int ?? default(int);
                }
            }

            private static int? IntNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.Int;
                }
            }

            private static uint UIntAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.UInt ?? default(uint);
                }
            }

            private static uint? UIntNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.UInt;
                }
            }

            private static long LongAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.Long ?? default(long);
                }
            }

            private static long? LongNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.Long;
                }
            }

            private static ulong ULongAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.ULong ?? default(long);
                }
            }

            private static ulong? ULongNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.ULong;
                }
            }

            private static float FloatAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.Float ?? default(float);
                }
            }

            private static float? FloatNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.Float;
                }
            }

            private static double DoubleAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.Double ?? default(double);
                }
            }

            private static double? DoubleNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.Double;
                }
            }

            private static Size SizeAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.Size ?? default(Size);
                }
            }

            private static Size? SizeNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.Size;
                }
            }

            private static SizeF SizeFAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.SizeF ?? default(SizeF);
                }
            }

            private static SizeF? SizeFNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.SizeF;
                }
            }

            private static Rectangle RectAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.Rect ?? default(Rectangle);
                }
            }

            private static Rectangle? RectNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.Rect;
                }
            }

            private static RectangleF RectFAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.RectF ?? default(RectangleF);
                }
            }

            private static RectangleF? RectFNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.RectF;
                }
            }

            private static Point PointAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.Point ?? default(Point);
                }
            }

            private static Point? PointNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.Point;
                }
            }

            private static PointF PointFAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.PointF ?? default(PointF);
                }
            }

            private static PointF? PointFNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.PointF;
                }
            }

#if NETSTANDARD2_1
            private static Vector2 Vector2DAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.Vector2D ?? default(Vector2);
                }
            }

            private static Vector2? Vector2DNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.Vector2D;
                }
            }

            private static Vector3 Vector3DAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.Vector3D ?? default(Vector3);
                }
            }

            private static Vector3? Vector3DNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.Vector3D;
                }
            }

            private static Vector4 Vector4DAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.Vector4D ?? default(Vector4);
                }
            }

            private static Vector4? Vector4DNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.Vector4D;
                }
            }

            private static Quaternion QuaternionAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.Quaternion ?? default(Quaternion);
                }
            }

            private static Quaternion? QuaternionNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.Quaternion;
                }
            }

            private static Matrix4x4 Matrix4x4At(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.Matrix4x4 ?? default(Matrix4x4);
                }
            }

            private static Matrix4x4? Matrix4x4NullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.Matrix4x4;
                }
            }
#endif

            private static System.Drawing.Color ColorAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return default;
                    }

                    return variant.Color;
                }
            }

            private static string StringAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.String;
                }
            }

            private static byte[] ByteArrayAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.ByteArray;
                }
            }

            private static DateTimeOffset DateTimeAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.DateTime ?? default(DateTimeOffset);
                }
            }

            private static DateTimeOffset? DateTimeNullableAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    if (variant == null || variant.VariantType == NetVariantType.Invalid)
                    {
                        return null;
                    }

                    return variant.DateTime;
                }
            }

            private static object ObjectAt(NetVariantList list, int index)
            {
                using (var variant = list.Get(index))
                {
                    return variant?.AsObject();
                }
            }
        }

        private class GetMethods
        {
            public static MethodInfo BoolMethod = typeof(GetMethods).GetMethod(nameof(Bool), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo BoolNullableMethod = typeof(GetMethods).GetMethod(nameof(BoolNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo CharMethod = typeof(GetMethods).GetMethod(nameof(Char), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo CharNullableMethod = typeof(GetMethods).GetMethod(nameof(CharNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo IntMethod = typeof(GetMethods).GetMethod(nameof(Int), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo IntNullableMethod = typeof(GetMethods).GetMethod(nameof(IntNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo UIntMethod = typeof(GetMethods).GetMethod(nameof(UInt), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo UIntNullableMethod = typeof(GetMethods).GetMethod(nameof(UIntNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LongMethod = typeof(GetMethods).GetMethod(nameof(Long), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo LongNullableMethod = typeof(GetMethods).GetMethod(nameof(LongNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo ULongMethod = typeof(GetMethods).GetMethod(nameof(ULong), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo ULongNullableMethod = typeof(GetMethods).GetMethod(nameof(ULongNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo FloatMethod = typeof(GetMethods).GetMethod(nameof(Float), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo FloatNullableMethod = typeof(GetMethods).GetMethod(nameof(FloatNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo DoubleMethod = typeof(GetMethods).GetMethod(nameof(Double), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo DoubleNullableMethod = typeof(GetMethods).GetMethod(nameof(DoubleNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo StringMethod = typeof(GetMethods).GetMethod(nameof(String), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo DateTimeMethod = typeof(GetMethods).GetMethod(nameof(DateTime), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo DateTimeNullableMethod = typeof(GetMethods).GetMethod(nameof(DateTimeNullable), BindingFlags.Static | BindingFlags.NonPublic);
            public static MethodInfo ObjMethod = typeof(GetMethods).GetMethod(nameof(Obj), BindingFlags.Static | BindingFlags.NonPublic);

            private static bool Bool(NetVariant variant)
            {
                return variant.Bool;
            }

            private static bool? BoolNullable(NetVariant variant)
            {
                if (variant.VariantType == NetVariantType.Invalid)
                {
                    return null;
                }

                return variant.Bool;
            }

            private static char Char(NetVariant variant)
            {
                return variant.Char;
            }

            private static char? CharNullable(NetVariant variant)
            {
                if (variant.VariantType == NetVariantType.Invalid)
                {
                    return null;
                }

                return variant.Char;
            }

            private static int Int(NetVariant variant)
            {
                return variant.Int;
            }

            private static int? IntNullable(NetVariant variant)
            {
                if (variant.VariantType == NetVariantType.Invalid)
                {
                    return null;
                }

                return variant.Int;
            }

            private static uint UInt(NetVariant variant)
            {
                return variant.UInt;
            }

            private static uint? UIntNullable(NetVariant variant)
            {
                if (variant.VariantType == NetVariantType.Invalid)
                {
                    return null;
                }

                return variant.UInt;
            }

            private static long Long(NetVariant variant)
            {
                return variant.Long;
            }

            private static long? LongNullable(NetVariant variant)
            {
                if (variant.VariantType == NetVariantType.Invalid)
                {
                    return null;
                }

                return variant.Long;
            }

            private static ulong ULong(NetVariant variant)
            {
                return variant.ULong;
            }

            private static ulong? ULongNullable(NetVariant variant)
            {
                if (variant.VariantType == NetVariantType.Invalid)
                {
                    return null;
                }

                return variant.ULong;
            }

            private static float Float(NetVariant variant)
            {
                return variant.ULong;
            }

            private static float? FloatNullable(NetVariant variant)
            {
                if (variant.VariantType == NetVariantType.Invalid)
                {
                    return null;
                }

                return variant.Float;
            }

            private static double Double(NetVariant variant)
            {
                return variant.Double;
            }

            private static double? DoubleNullable(NetVariant variant)
            {
                if (variant.VariantType == NetVariantType.Invalid)
                {
                    return null;
                }

                return variant.Double;
            }

            private static string String(NetVariant variant)
            {
                return variant.String;
            }

            private static DateTimeOffset DateTime(NetVariant variant)
            {
                var result = variant.DateTime;
                return result ?? default(DateTimeOffset);
            }

            private static DateTimeOffset? DateTimeNullable(NetVariant variant)
            {
                return variant.DateTime;
            }

            private static object Obj(NetVariant variant)
            {
                using (var reference = variant.Instance)
                {
                    return reference?.Instance;
                }
            }
        }
    }
}