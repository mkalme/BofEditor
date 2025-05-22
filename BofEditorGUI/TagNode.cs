using System;
using System.Linq;
using BinaryObjectFormat;
using CustomDialogs;

namespace BofEditorGUI {
    public class TagNode : INode {
        public INode Parent { get; }
        public string DisplayText { get; set; }
    
        public Tag Tag { get; }

        public TagNode(Tag tag, string displayText = "", bool isRoot = false) {
            Tag = tag;

            if (string.IsNullOrEmpty(displayText)) {
                if (isRoot || Tag.Parent == null) {
                    DisplayText = "Root";
                }
            } else {
                DisplayText = displayText;
            }

            if (Tag.Parent == null) return;

            if (Tag.Parent.ID == TagID.List || Tag.Parent.ID == TagID.Array) {                
                DisplayText = $"Click here to exit {Tag.ID.ToString().ToLower()}";
                
                Tag = Tag.Parent;
            } else {
                Parent = new TagNode(Tag.Parent);

                if (tag.Parent.ID == TagID.Object) {
                    DisplayText = ((ObjectTag)tag.Parent).FirstOrDefault(x => x.Value == tag).Key;
                }
            }
        }
    }
}
