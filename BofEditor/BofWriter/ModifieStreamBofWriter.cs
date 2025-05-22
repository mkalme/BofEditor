using System;
using System.IO;
using BinaryObjectFormat;

namespace BofEditor {
    public class ModifieStreamBofWriter : IBofWriter {
        public IBofWriter Writer { get; set; }
        public IStreamModifier StreamModifier { get; set; }

        public void Write(ObjectTag objectTag, Stream output) {
            using (MemoryStream unmodifiedStream = new MemoryStream()) {
                Writer.Write(objectTag, unmodifiedStream);

                unmodifiedStream.Position = 0;
                StreamModifier.Modify(unmodifiedStream, output);
            }
        }
    }
}
