using System;
using BinaryObjectFormat;
using CustomDialogs;

namespace BofEditorGUI {
    public class TagNodeView : IViewNode<Tag> {
        public Tag Node { get; }
        public Tag Parent { get; }

        public event EventHandler ContentsChanged;
        public event EventHandler Removed;

        public TagNodeView(Tag tag, bool isRoot = false) {
            Node = tag;
            if(!isRoot) Parent = Node.Parent;

            tag.ContentsChanged += (sender, e) => { if (ContentsChanged != null) ContentsChanged(Node, EventArgs.Empty); };
            tag.Removed += (sender, e) => { if (Removed != null) Removed(Node, EventArgs.Empty); };
        }

        public IViewNode<Tag> CreateNode(Tag node) => new TagNodeView(node);
    }
}
