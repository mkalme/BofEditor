using System;
using System.IO;
using BinaryObjectFormat;

namespace BofEditor {
    public interface IBofWriter {
        void Write(ObjectTag objectTag, Stream output);
    }
}
