using System;
using System.Collections.Generic;
using BofEditor;

namespace BofEditorGUI {
    public class BofEditorApplication {
        public IDictionary<string, IFileFormatEditor> Formats { get; set; }

        public BofEditorApplication() { 
            
        }
    }
}
