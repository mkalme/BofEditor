using System;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using BinaryObjectFormat;
using CustomDialogs;

namespace BofEditorGUI {
    public partial class BofEditor : Form {
        public ObjectTag ObjectTag { get; set; }

        public ViewController<Tag> ViewController { get; }
        public View<Tag> CurrentView => ViewController.CurrentView;
        public Tag CurrentTag => CurrentView.Node;

        public BofEditor(ObjectTag objectTag) {
            InitializeComponent();

            ObjectTag = objectTag;

            ViewController = new ViewController<Tag>(new TagNodeView(objectTag, true));
            ViewController.Update += ViewUpdate;

            GridView.SetDoubleBuffering();
            new DataGridViewSelection(GridView);

            MenuStrip.Renderer = new CustomToolStripRenderer();
            NewMenuItem.DropDown.BackColor = MenuStrip.BackColor;

            PathPanel.SetDoubleBuffering();
        }

        private void BofEditor_Load(object sender, EventArgs e) {
            DisplayView(CurrentView);
            GridView.ClearSelection();
        }

        //Update
        private bool _inUpdate = false;

        private void DisplayView(View<Tag> view) {
            _inUpdate = true;

            GridView.Rows.Clear();
            switch (view.Node.ID) {
                case TagID.Object:
                    AddRowsObject(view, view.Node as ObjectTag);
                    break;
                case TagID.List:
                    AddRowsList(view, view.Node as ListTag);
                    break;
                case TagID.Array:
                    AddRowsArray(view, view.Node as ArrayTag);
                    break;
            }

            PathPanel.Load(new TagNode(view.Node, isRoot: view.Node == ObjectTag));

            _inUpdate = false;
        }

        private void AddRowsObject(View<Tag> view, ObjectTag tag) {
            for (int i = 0; i < tag.Count; i++) {
                var pair = tag.ElementAt(i);

                GridView.Rows.Add($"{pair.Key}   ", pair.Value.ConvertValueToString(), pair.Value.ID);
                var row = GridView.Rows[i];

                ((TextAndImageCell)row.Cells[NameCol.Index]).XOffet = 2;

                row.DisplayImage(NameCol, pair.Value.ID.GetIcon(), 25);
                row.Tag = pair.Value;
                row.Selected = view.SelectedItems.Contains(pair.Value);

                if (pair.Value.ID == TagID.Object || pair.Value.ID == TagID.List || pair.Value.ID == TagID.Array) {
                    row.Cells[ValueCol.Index].Style = new DataGridViewCellStyle() {
                        Font = new Font(new FontFamily("Segoe UI"), 9, FontStyle.Italic),
                        ForeColor = Color.FromArgb(150, 150, 150)
                    };
                }
            }
        }
        private void AddRowsList(View<Tag> view, ListTag listTag) {
            for (int i = 0; i < listTag.Count; i++) {
                var tag = listTag[i];

                GridView.Rows.Add($"Index: {i}   ", tag.ConvertValueToString(), tag.ID);
                var row = GridView.Rows[i];

                ((TextAndImageCell)row.Cells[NameCol.Index]).XOffet = 2;

                row.DisplayImage(NameCol, tag.ID.GetIcon(), 25);
                row.Tag = tag;
                row.Selected = view.SelectedItems.Contains(tag);
            }
        }
        private void AddRowsArray(View<Tag> view, ArrayTag arrayTag) {
            object[] array = arrayTag.InternalArray.Cast<object>();

            for (int i = 0; i < array.Length; i++) {
                GridView.Rows.Add($"Index: {i}   ", array[i], arrayTag.ElementID);
                var row = GridView.Rows[i];

                ((TextAndImageCell)row.Cells[NameCol.Index]).XOffet = 2;

                row.DisplayImage(NameCol, arrayTag.ElementID.GetIcon(), 25);
                row.Tag = i;
                row.Selected = view.SelectedItems.Contains(i);
            }
        }

        private void ViewUpdate(object sender, EventArgs e) {
            DisplayView(CurrentView);
        }
        private void PathPanel_ButtonClick(object sender, EventArgs e) {
            ViewController.OpenParent(((TagNode)((NodePanel)sender).Node).Tag);
        }

        //Header buttons
        private void PrevButton_Click(object sender, EventArgs e) {
            ViewController.Prev();
        }
        private void ForwardButton_Click(object sender, EventArgs e) {
            ViewController.Next();
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            DisplayView(CurrentView);
        }

        //GridView
        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            if (CurrentTag.ID == TagID.Object || CurrentTag.ID == TagID.List) {
                Tag tag = GridView.Rows[e.RowIndex].Tag as Tag;
                if (tag.ID == TagID.Object || tag.ID == TagID.List || tag.ID == TagID.Array) {
                    ViewController.OpenChild(tag);
                } else {
                    Tag resultTag = TagUtilities.ShowTagEditor(tag);
                    if (resultTag == null) return;

                    int selectedTagIndex = CurrentView.SelectedItems.IndexOf(tag);

                    CurrentView.SelectedItems[selectedTagIndex] = resultTag;
                    GridView.Rows[e.RowIndex].Tag = resultTag;

                    if (CurrentTag.ID == TagID.Object) {
                        string key = ((ObjectTag)CurrentTag).GetKeyFromValue(tag);
                        ((ObjectTag)CurrentTag)[key] = resultTag;
                    } else {
                        int tagIndex = ((ListTag)CurrentTag).IndexOf(tag);
                        ((ListTag)CurrentTag)[tagIndex] = resultTag;
                    }
                }

                return;
            }

            int index = (int)GridView.Rows[e.RowIndex].Tag;
            object[] values = ((ArrayTag)CurrentTag).InternalArray.Cast<object>();

            InputResult<object> result = DialogUtilities.ShowValueEditor(values[index]);
            if (result.DialogClosed) return;

            ((ArrayTag)CurrentTag).InternalArray.SetValue(result.Value, index);
            ((ArrayTag)CurrentTag).CallContentsChangedEvent();
        }
        private void GridView_SelectionChanged(object sender, EventArgs e) {
            if (_inUpdate) return;

            CurrentView.SelectedItems.Clear();
            foreach (DataGridViewRow row in GridView.SelectedRows) {
                CurrentView.SelectedItems.Add(row.Tag);
            }
        }

        private void SelectRow(Tag item) {
            foreach (DataGridViewRow row in GridView.Rows) {
                if (row.Tag == item) {
                    row.Selected = true;
                    return;
                }
            }
        }
        private Tag GetItemFromPoint(Point point) {
            Point rPoint = GridView.PointToClient(point);
            int rowIndex = GridView.HitTest(rPoint.X, rPoint.Y).RowIndex;

            if (rowIndex < 0) return null;
            return GridView.Rows[rowIndex].Tag as Tag;
        }

        //MenuStrip
        private void MenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            Tag tag = GetItemFromPoint(MenuStrip.Bounds.Location);

            PasteMenuItem.Enabled = false;
            RenameMenuItem.Enabled = CurrentTag.ID == TagID.Object && tag != null;

            TagID allowedId = TagID.Object;
            if (CurrentTag.ID == TagID.Array) allowedId = ((ArrayTag)CurrentTag).ElementID;
            else if (CurrentTag.ID == TagID.List) allowedId = ((ListTag)CurrentTag).ElementID;

            bool isObject = CurrentTag.ID == TagID.Object;

            NewObjectMenuItem.Enabled = isObject || TagID.Object == allowedId;
            NewArrayMenuItem.Enabled = isObject || TagID.Array == allowedId;
            NewListMenuItem.Enabled = isObject || TagID.List == allowedId;

            NewByteMenuItem.Enabled = isObject || TagID.Byte == allowedId;
            NewSByteMenuItem.Enabled = isObject || TagID.SByte == allowedId;
            NewInt16MenuItem.Enabled = isObject || TagID.Int16 == allowedId;
            NewUInt16MenuItem.Enabled = isObject || TagID.UInt16 == allowedId;
            NewInt32MenuItem.Enabled = isObject || TagID.Int32 == allowedId;
            NewUInt32MenuItem.Enabled = isObject || TagID.UInt32 == allowedId;
            NewInt64MenuItem.Enabled = isObject || TagID.Int64 == allowedId;
            NewUInt64MenuItem.Enabled = isObject || TagID.UInt64 == allowedId;
            NewSingleMenuItem.Enabled = isObject || TagID.Single == allowedId;
            NewDoubleMenuItem.Enabled = isObject || TagID.Double == allowedId;
            NewDecimalMenuItem.Enabled = isObject || TagID.Decimal == allowedId;
            NewCharMenuItem.Enabled = isObject || TagID.Char == allowedId;
            NewBooleanMenuItem.Enabled = isObject || TagID.Boolean == allowedId;
            NewStringMenuItem.Enabled = isObject || TagID.String == allowedId;
            NewDateTimeMenuItem.Enabled = isObject || TagID.DateTime == allowedId;
        }

        private void RenameMenuItem_Click(object sender, EventArgs e) {
            Tag tag = GetItemFromPoint(MenuStrip.Bounds.Location);

            string key = ((ObjectTag)CurrentTag).GetKeyFromValue(tag);

            Func<string, bool> validator = name => {
                if (string.IsNullOrEmpty(name)) {
                    CustomDialog.ShowError("Error", "Tag's name cannot be empty.");
                    return false;
                }

                if (key != name && ((ObjectTag)CurrentTag).ContainsKey(name)) {
                    CustomDialog.ShowError("Error", "A tag with that name already exists.");
                    return false;
                }

                return true;
            };

            InputResult<string> result = CustomDialog.ShowTextInput("Tag's name", "Edit the tag's name.", key,
                Properties.Resources._64pxRename, validator);

            if (result.DialogClosed) return;

            ((ObjectTag)CurrentTag).Remove(key);
            ((ObjectTag)CurrentTag).Add(result.Value, tag);
        }
        private void DeleteMenuItem_Click(object sender, EventArgs e) {
            string result = CustomDialog.ShowMessage("Delete", "Are you sure you want to delete this?",
                Properties.Resources._64pxTrash, SystemSounds.Hand, "Delete", "No");

            if (result != "Delete") return;

            foreach (var item in CurrentView.SelectedItems) {
                Tag tag = item as Tag;
                
                if (CurrentTag.ID == TagID.Object) {
                    string key = ((ObjectTag)CurrentTag).GetKeyFromValue(tag);
                    ((ObjectTag)CurrentTag).Remove(key);
                } else {
                    ((ListTag)CurrentTag).Remove(tag);
                }
            }
        }

        private void NewObjectMenuItem_Click(object sender, EventArgs e) {
            AddTag(new ObjectTag(), "New object");
        }
        private void NewArrayMenuItem_Click(object sender, EventArgs e) {
            EnumSelector selector = new EnumSelector("Choose id", "Choose id", TagID.Object);
            selector.ShowDialog();

            if (selector.DialogClosed) return;
            
            TagID id = (TagID)selector.SelectedEnum;
            AddTag(new ArrayTag(Array.CreateInstance(TagUtilities.IdTypeDictionary[id], 0), id), "New array");
        }
        private void NewListMenuItem_Click(object sender, EventArgs e) {
            EnumSelector selector = new EnumSelector("Choose id", "Choose id", TagID.Object);
            selector.ShowDialog();

            if (selector.DialogClosed) return;

            AddTag(new ListTag((TagID)selector.SelectedEnum), "New list");
        }

        private void NewByteMenuItem_Click(object sender, EventArgs e) {
            if (CurrentTag.ID == TagID.Array) AddValue(CurrentTag as ArrayTag, (byte)0);
            else AddTag((byte)0, "New byte");
        }
        private void NewSByteMenuItem_Click(object sender, EventArgs e) {
            if (CurrentTag.ID == TagID.Array) AddValue(CurrentTag as ArrayTag, (sbyte)0);
            else AddTag((sbyte)0, "New sbyte");
        }
        private void NewInt16MenuItem_Click(object sender, EventArgs e) {
            if (CurrentTag.ID == TagID.Array) AddValue(CurrentTag as ArrayTag, (short)0);
            else AddTag((short)0, "New Int16 tag");
        }
        private void NewUInt16MenuItem_Click(object sender, EventArgs e) {
            if (CurrentTag.ID == TagID.Array) AddValue(CurrentTag as ArrayTag, (ushort)0);
            else AddTag((ushort)0, "New UInt16 tag");
        }
        private void NewInt32MenuItem_Click(object sender, EventArgs e) {
            if (CurrentTag.ID == TagID.Array) AddValue(CurrentTag as ArrayTag, 0);
            else AddTag(0, "New Int32 tag");
        }
        private void NewUInt32MenuItem_Click(object sender, EventArgs e) {
            if (CurrentTag.ID == TagID.Array) AddValue(CurrentTag as ArrayTag, (uint)0);
            else AddTag((uint)0, "New UInt32 tag");
        }
        private void NewInt64MenuItem_Click(object sender, EventArgs e) {
            if (CurrentTag.ID == TagID.Array) AddValue(CurrentTag as ArrayTag, (long)0);
            else AddTag((long)0, "New Int64 tag");
        }
        private void NewUInt64MenuItem_Click(object sender, EventArgs e) {
            if (CurrentTag.ID == TagID.Array) AddValue(CurrentTag as ArrayTag, (ulong)0);
            else AddTag((ulong)0, "New UInt64 tag");
        }
        private void NewSingleMenuItem_Click(object sender, EventArgs e) {
            if (CurrentTag.ID == TagID.Array) AddValue(CurrentTag as ArrayTag, (float)0);
            else AddTag((float)0, "New single tag");
        }
        private void NewDoubleMenuItem_Click(object sender, EventArgs e) {
            if (CurrentTag.ID == TagID.Array) AddValue(CurrentTag as ArrayTag, (double)0);
            else AddTag((double)0, "New double tag");
        }
        private void NewDecimalMenuItem_Click(object sender, EventArgs e) {
            if (CurrentTag.ID == TagID.Array) AddValue(CurrentTag as ArrayTag, (decimal)0);
            else AddTag((decimal)0, "New decimal tag");
        }
        private void NewCharMenuItem_Click(object sender, EventArgs e) {
            if (CurrentTag.ID == TagID.Array) AddValue(CurrentTag as ArrayTag, '-');
            else AddTag('-', "New char tag");
        }
        private void NewBooleanMenuItem_Click(object sender, EventArgs e) {
            if (CurrentTag.ID == TagID.Array) AddValue(CurrentTag as ArrayTag, false);
            else AddTag(false, "New boolean tag");
        }
        private void NewStringMenuItem_Click(object sender, EventArgs e) {
            if (CurrentTag.ID == TagID.Array) AddValue(CurrentTag as ArrayTag, string.Empty);
            else AddTag(string.Empty, "New string tag");
        }
        private void NewDateTimeMenuItem_Click(object sender, EventArgs e) {
            if (CurrentTag.ID == TagID.Array) AddValue(CurrentTag as ArrayTag, DateTime.Now);
            else AddTag(DateTime.Now, "New datetime tag");
        }

        //Functions
        public void AddTag(Tag tag, string name) {
            if (CurrentTag.ID == TagID.Object) {
                ((ObjectTag)CurrentTag).Add(CreateName(CurrentTag as ObjectTag, name), tag);
            } else {
                ((ListTag)CurrentTag).Add(tag);
            }

            SelectRow(tag);
        }
        public void AddValue(ArrayTag array, object value) {
            Array newArray = Array.CreateInstance(array.InternalArray.GetType().GetElementType(), array.Length + 1);

            array.InternalArray.CopyTo(newArray, 0);
            newArray.SetValue(value, newArray.Length - 1);

            ArrayTag newArrayTag = new ArrayTag(newArray, array.ElementID);

            if (array.Parent.ID == TagID.Object) {
                string key = ((ObjectTag)array.Parent).GetKeyFromValue(array);
                ((ObjectTag)array.Parent)[key] = newArrayTag;
            } else if (array.Parent.ID == TagID.List) {
                int index = ((ListTag)array.Parent).IndexOf(array);
                ((ListTag)array.Parent)[index] = newArrayTag;
            } else if (array.Parent.ID == TagID.Array) {
                int index = Array.FindIndex(((ArrayTag)array.Parent).As<ArrayTag>(), x => x == array);
                ((ArrayTag)array.Parent).InternalArray.SetValue(newArrayTag, index);
            }
        }

        public static string CreateName(ObjectTag obj, string name) {
            string output = name;
            int count = 2;

            while (true) {
                if (!obj.ContainsKey(output)) {
                    return output;
                } else {
                    output = $"{name} ({count++})";
                }
            }
        }
    }
}
