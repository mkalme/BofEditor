using System;
using CustomDialogs;

namespace BofEditorGUI {
    public static class DialogUtilities {
        private delegate object ParseDelegate(string text);

        public static InputResult<object> ShowValueEditor(object value) {
            ParseDelegate parseDelegate = GetParseDelegate(Type.GetTypeCode(value.GetType()));
            Func<string, bool> validator = text => {
                try {
                    parseDelegate(text);
                    return true;
                } catch {
                    CustomDialog.ShowError("Error", "Invalid input.");
                    return false;
                }
            };

            string message = $"Edit {value.GetType()}";
            InputResult<string> result = CustomDialog.ShowTextInput(message, message, value != null ? value.ToString() : "", Properties.Resources._16pxArray, validator);

            return new InputResult<object>(!result.DialogClosed ? parseDelegate(result.Value) : null, result.DialogClosed);
        }

        private static ParseDelegate GetParseDelegate(TypeCode typeCode) {
            switch (typeCode) {
                case TypeCode.Boolean:
                    return t => bool.Parse(t);
                case TypeCode.Char:
                    return t => char.Parse(t);
                case TypeCode.SByte:
                    return t => sbyte.Parse(t);
                case TypeCode.Byte:
                    return t => byte.Parse(t);
                case TypeCode.Int16:
                    return t => short.Parse(t);
                case TypeCode.UInt16:
                    return t => ushort.Parse(t);
                case TypeCode.Int32:
                    return t => int.Parse(t);
                case TypeCode.UInt32:
                    return t => uint.Parse(t);
                case TypeCode.Int64:
                    return t => long.Parse(t);
                case TypeCode.UInt64:
                    return t => ulong.Parse(t);
                case TypeCode.Single:
                    return t => float.Parse(t);
                case TypeCode.Double:
                    return t => double.Parse(t);
                case TypeCode.Decimal:
                    return t => decimal.Parse(t);
                case TypeCode.DateTime:
                    return t => DateTime.Parse(t);
                case TypeCode.String:
                    return t => t;
                default:
                    return null;
            }
        }
    }
}
