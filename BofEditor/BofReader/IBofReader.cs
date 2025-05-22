using System;
using System.IO;
using BinaryObjectFormat;

namespace BofEditor {
    public interface IBofReader {
        ObjectTag Read(Stream input);
    }
}
