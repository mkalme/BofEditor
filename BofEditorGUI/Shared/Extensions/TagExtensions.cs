using System;
using System.Drawing;
using BinaryObjectFormat;

namespace BofEditorGUI {
    public static class TagExtensions {
        public static Image GetIcon(this TagID id) {
            switch (id) {
                case TagID.Object: return Properties.Resources._16pxObject;
                case TagID.List: return Properties.Resources._16pxBulletList;
                case TagID.Array: return Properties.Resources._16pxArray;
                case TagID.Byte:
                case TagID.SByte:
                case TagID.UInt16:
                case TagID.Int16:
                case TagID.UInt32:
                case TagID.Int32:
                case TagID.UInt64:
                case TagID.Int64: return Properties.Resources._16pxInteger;
                case TagID.Single:
                case TagID.Double:
                case TagID.Decimal: return Properties.Resources._16pxDouble;
                case TagID.Char: return Properties.Resources._16pxAttribute;
                case TagID.Boolean: return Properties.Resources._16pxBoolean;
                case TagID.String: return Properties.Resources._16pxString;
                case TagID.DateTime: return Properties.Resources._16pxCalendar;
                default:
                    return null;
            }
        }
        public static string ConvertValueToString(this Tag tag) {
            switch (tag.ID) {
                case TagID.Object:
                case TagID.List:
                case TagID.Array: return "Double click to edit";
                case TagID.DateTime: return ((DateTime)tag).ToString();
                case TagID.Byte: return ((byte)tag).ToString();
                case TagID.SByte: return ((sbyte)tag).ToString();
                case TagID.UInt16: return ((ushort)tag).ToString();
                case TagID.Int16: return ((short)tag).ToString();
                case TagID.UInt32: return ((uint)tag).ToString();
                case TagID.Int32: return ((int)tag).ToString();
                case TagID.UInt64: return ((ulong)tag).ToString();
                case TagID.Int64: return ((long)tag).ToString();
                case TagID.Single: return ((float)tag).ToString();
                case TagID.Double: return ((double)tag).ToString();
                case TagID.Decimal: return ((decimal)tag).ToString();
                case TagID.Char: return ((char)tag).ToString();
                case TagID.Boolean: return ((bool)tag).ToString();
                case TagID.String: return tag;
                default:
                    return string.Empty;
            }
        }
    }
}
