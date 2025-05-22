using System;
using System.IO;

namespace BofEditor {
    public interface IStreamModifier {
        void Modify(Stream input, Stream output);
        void Unmodify(Stream input, Stream output);
    }
}
