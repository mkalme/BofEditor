using System;
using System.Collections.Generic;
using BinaryObjectFormat;
using CustomDialogs;

namespace BofEditorGUI {
    public class TagUtilities {
        public static readonly IDictionary<TagID, Type> IdTypeDictionary = new Dictionary<TagID, Type>() {
            { TagID.Object, typeof(ObjectTag) },
            { TagID.Array, typeof(ArrayTag) },
            { TagID.List, typeof(ListTag) },
            { TagID.Byte, typeof(byte) },
            { TagID.SByte, typeof(sbyte) },
            { TagID.UInt16, typeof(ushort) },
            { TagID.Int16, typeof(short) },
            { TagID.UInt32, typeof(uint) },
            { TagID.Int32, typeof(int) },
            { TagID.UInt64, typeof(ulong) },
            { TagID.Int64, typeof(long) },
            { TagID.Single, typeof(float) },
            { TagID.Double, typeof(double) },
            { TagID.Decimal, typeof(decimal) },
            { TagID.Char, typeof(char) },
            { TagID.Boolean, typeof(bool) },
            { TagID.String, typeof(string) },
            { TagID.DateTime, typeof(DateTime) }
        };

        public static Tag ShowTagEditor(Tag tag) {
            InputResult<object> result = DialogUtilities.ShowValueEditor(tag.GetValue());
            if (result.DialogClosed) return null;

            switch (tag.ID) {
                case TagID.Byte: return (byte)result.Value;
                case TagID.SByte: return (sbyte)result.Value;
                case TagID.UInt16: return (ushort)result.Value;
                case TagID.Int16: return (short)result.Value;
                case TagID.UInt32: return (uint)result.Value;
                case TagID.Int32: return (int)result.Value;
                case TagID.UInt64: return (ulong)result.Value;
                case TagID.Int64: return (long)result.Value;
                case TagID.Single: return (float)result.Value;
                case TagID.Double: return (double)result.Value;
                case TagID.Decimal: return (decimal)result.Value;
                case TagID.Char: return (char)result.Value;
                case TagID.Boolean: return (bool)result.Value;
                case TagID.String: return (string)result.Value;
                case TagID.DateTime: return (DateTime)result.Value;
                default:
                    return null;
            }
        }
    }
}
