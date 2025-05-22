using System;

namespace BofEditor {
    public interface IFileFormatEditor {
        string Format { get; }
        
        IBofReader Reader { get; }
        IBofWriter Writer { get; }
    }
}
