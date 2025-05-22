using System;
using System.IO;
using System.IO.Compression;

namespace BofEditor {
    public class GZipCompression : IStreamModifier {
        public void Modify(Stream input, Stream output) {
            using (GZipStream zc = new GZipStream(output, CompressionMode.Compress)) {
                input.CopyTo(zc);
                zc.Flush();
            }
        }
        public void Unmodify(Stream input, Stream output) {
            using (GZipStream zc = new GZipStream(input, CompressionMode.Decompress)) {
                zc.CopyTo(output);
            }
        }
    }
}
