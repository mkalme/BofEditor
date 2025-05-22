using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinaryObjectFormat;

namespace BofEditorGUI {
    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TestSpeed();

            BofEditorApplication application = new BofEditorApplication();

            Application.Run(new BofEditor(new ObjectTag() {
                { "Test", "t" },
                { "Tesdf t", 534 },
                { "Tes87t", false },
                { "Test1", 'a' },
                { "Test54", 645.64F },
                { "Test541111", new ListTag(TagID.Int32) {
                    0, 1, 2, 3, 4, 5, 6, 7, 8, 9
                } },
                { "Object list", new ListTag(TagID.Object)},
                { "Time", DateTime.Now },
                { "Object test", new ObjectTag()},
                { "Array", new int[20] },
                { "ArrayList", new ListTag(TagID.Array) { new int[10] } },
                { "DoubleArray", new double[0] }
            }));
        }

        private static void TestSpeed() {
            byte[] bytes = CreateTestTag().ToBytes();
            Tag tag = Tag.FromBytes(bytes);

            Stopwatch watch = new Stopwatch();
            watch.Start();

            int times = 10;
            Parallel.For(0, times, j => {
                Tag.FromBytes(bytes);
            });

            //for (int i = 0; i < times; i++) {
            //    Tag.FromBytes(bytes);
            //}

            watch.Stop();

            double bytesPerSecond = bytes.Length * (long)times / (double)(watch.ElapsedMilliseconds / (double)1000);
            bytesPerSecond /= 1024 * 1024;

            CustomDialogs.CustomDialog.ShowMessage("Speed", $"Elapsed milliseconds: {watch.ElapsedMilliseconds} | {bytesPerSecond.ToString("N2")} mb/s");
        }
        private static Tag CreateTestTag() {
            ObjectTag objectTag = new ObjectTag();

            objectTag.Add("Byte", byte.MaxValue);
            objectTag.Add("ByteArray", new byte[10].Populate(byte.MaxValue));

            objectTag.Add("SByte", sbyte.MaxValue);
            objectTag.Add("SByteArray", new sbyte[10].Populate(sbyte.MaxValue));

            objectTag.Add("UInt16", ushort.MaxValue);
            objectTag.Add("UInt16Array", new ushort[10].Populate(ushort.MaxValue));

            objectTag.Add("Int16", short.MaxValue);
            objectTag.Add("Int16Array", new short[10].Populate(short.MaxValue));

            objectTag.Add("UInt32", uint.MaxValue);
            objectTag.Add("UInt32Array", new uint[10].Populate(uint.MaxValue));

            objectTag.Add("Int32", int.MaxValue);
            objectTag.Add("Int32Array", new int[10].Populate(int.MaxValue));

            objectTag.Add("UInt64", ulong.MaxValue);
            objectTag.Add("UInt64Array", new ulong[10].Populate(ulong.MaxValue));

            objectTag.Add("Int64", long.MaxValue);
            objectTag.Add("Int64Array", new long[10].Populate(long.MaxValue));

            objectTag.Add("Single", float.MaxValue);
            objectTag.Add("SingleArray", new float[10].Populate(float.MaxValue));

            objectTag.Add("Double", double.MaxValue);
            objectTag.Add("DoubleArray", new double[10].Populate(double.MaxValue));

            objectTag.Add("Decimal", decimal.MaxValue);
            objectTag.Add("DecimalArray", new decimal[10].Populate(decimal.MaxValue));

            objectTag.Add("Char", char.MaxValue);
            objectTag.Add("CharArray", new char[10].Populate(char.MaxValue));

            objectTag.Add("Boolean", true);
            objectTag.Add("BooleanArray", new bool[10].Populate(true));

            objectTag.Add("String", "testString");
            objectTag.Add("StringArray", new string[100].Populate(new string('-', 1000000)));

            objectTag.Add("DateTime", DateTime.MaxValue);
            objectTag.Add("DateTimeArray", new DateTime[10].Populate(DateTime.MaxValue));

            ListTag listTag = new ListTag(TagID.UInt16);
            listTag.Add(ushort.MaxValue);
            listTag.Add(ushort.MaxValue);
            listTag.Add(ushort.MaxValue);

            objectTag.Add("List", listTag);
            objectTag.Add("Object", objectTag.Clone() as Tag);

            return objectTag;
        }
    }

    static class ArrayExtensions {
        public static T[] Populate<T>(this T[] array, T value) {
            for (int i = 0; i < array.Length; i++) {
                array[i] = value;
            }

            return array;
        }
    }
}
