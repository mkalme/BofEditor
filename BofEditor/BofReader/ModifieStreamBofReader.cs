using System;
using System.IO;
using BinaryObjectFormat;

namespace BofEditor {
    public class ModifieStreamBofReader : IBofReader {
        public IBofReader Reader { get; set; }
        public IStreamModifier StreamModifier { get; set; }

        public ObjectTag Read(Stream input) {
            using (MemoryStream unmodifiedStream = new MemoryStream()) {
                StreamModifier.Unmodify(input, unmodifiedStream);

                unmodifiedStream.Position = 0;
                return Reader.Read(unmodifiedStream);
            }
        }
    }
}
