
namespace BofEditorGUI {
    partial class BofEditor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.NameCol = new CustomDialogs.TextAndImageColumn();
            this.ValueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewObjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewArrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewListSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.NewByteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSByteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewInt16MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewUInt16MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewInt32MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewUInt32MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewInt64MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewUInt64MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSingleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDoubleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDecimalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewCharMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewBooleanMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewStringMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDateTimeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.RenameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeaderPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PathPanelContainer = new System.Windows.Forms.Panel();
            this.PathPanel = new CustomDialogs.PathNodePanel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.PrevButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.GlobalContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.PathPanelContainer.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.GridView, 0, 1);
            this.GlobalContainer.Controls.Add(this.HeaderPanel, 0, 0);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(0, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GlobalContainer.Size = new System.Drawing.Size(687, 391);
            this.GlobalContainer.TabIndex = 0;
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToOrderColumns = true;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.ValueCol,
            this.TypeCol});
            this.GridView.ContextMenuStrip = this.MenuStrip;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.GridView.Location = new System.Drawing.Point(7, 37);
            this.GridView.Margin = new System.Windows.Forms.Padding(0);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersVisible = false;
            this.GridView.RowTemplate.Height = 23;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(673, 348);
            this.GridView.TabIndex = 0;
            this.GridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellDoubleClick);
            this.GridView.SelectionChanged += new System.EventHandler(this.GridView_SelectionChanged);
            // 
            // NameCol
            // 
            this.NameCol.AlignmentToRight = false;
            this.NameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.NameCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.NameCol.HeaderText = "Name";
            this.NameCol.Image = null;
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            this.NameCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameCol.Width = 63;
            // 
            // ValueCol
            // 
            this.ValueCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ValueCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.ValueCol.HeaderText = "Value";
            this.ValueCol.Name = "ValueCol";
            this.ValueCol.ReadOnly = true;
            // 
            // TypeCol
            // 
            this.TypeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.TypeCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.TypeCol.HeaderText = "Type";
            this.TypeCol.Name = "TypeCol";
            this.TypeCol.ReadOnly = true;
            this.TypeCol.Width = 55;
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.NewSeperator,
            this.CopyMenuItem,
            this.PasteMenuItem,
            this.PasteSeparator,
            this.RenameMenuItem,
            this.DeleteMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(156, 126);
            this.MenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MenuStrip_Opening);
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewObjectMenuItem,
            this.NewArrayMenuItem,
            this.NewListMenuItem,
            this.NewListSeparator,
            this.NewByteMenuItem,
            this.NewSByteMenuItem,
            this.NewInt16MenuItem,
            this.NewUInt16MenuItem,
            this.NewInt32MenuItem,
            this.NewUInt32MenuItem,
            this.NewInt64MenuItem,
            this.NewUInt64MenuItem,
            this.NewSingleMenuItem,
            this.NewDoubleMenuItem,
            this.NewDecimalMenuItem,
            this.NewCharMenuItem,
            this.NewBooleanMenuItem,
            this.NewStringMenuItem,
            this.NewDateTimeMenuItem});
            this.NewMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxAdd;
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(155, 22);
            this.NewMenuItem.Text = "New                   ";
            // 
            // NewObjectMenuItem
            // 
            this.NewObjectMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewObjectMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewObjectMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxObject;
            this.NewObjectMenuItem.Name = "NewObjectMenuItem";
            this.NewObjectMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewObjectMenuItem.Text = "Object                ";
            this.NewObjectMenuItem.Click += new System.EventHandler(this.NewObjectMenuItem_Click);
            // 
            // NewArrayMenuItem
            // 
            this.NewArrayMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewArrayMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewArrayMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxArray;
            this.NewArrayMenuItem.Name = "NewArrayMenuItem";
            this.NewArrayMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewArrayMenuItem.Text = "Array";
            this.NewArrayMenuItem.Click += new System.EventHandler(this.NewArrayMenuItem_Click);
            // 
            // NewListMenuItem
            // 
            this.NewListMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewListMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewListMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxBulletList;
            this.NewListMenuItem.Name = "NewListMenuItem";
            this.NewListMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewListMenuItem.Text = "List";
            this.NewListMenuItem.Click += new System.EventHandler(this.NewListMenuItem_Click);
            // 
            // NewListSeparator
            // 
            this.NewListSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewListSeparator.Name = "NewListSeparator";
            this.NewListSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // NewByteMenuItem
            // 
            this.NewByteMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewByteMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewByteMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxInteger;
            this.NewByteMenuItem.Name = "NewByteMenuItem";
            this.NewByteMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewByteMenuItem.Text = "Byte";
            this.NewByteMenuItem.Click += new System.EventHandler(this.NewByteMenuItem_Click);
            // 
            // NewSByteMenuItem
            // 
            this.NewSByteMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewSByteMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewSByteMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxInteger;
            this.NewSByteMenuItem.Name = "NewSByteMenuItem";
            this.NewSByteMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewSByteMenuItem.Text = "SByte";
            this.NewSByteMenuItem.Click += new System.EventHandler(this.NewSByteMenuItem_Click);
            // 
            // NewInt16MenuItem
            // 
            this.NewInt16MenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewInt16MenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewInt16MenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxInteger;
            this.NewInt16MenuItem.Name = "NewInt16MenuItem";
            this.NewInt16MenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewInt16MenuItem.Text = "Int16";
            this.NewInt16MenuItem.Click += new System.EventHandler(this.NewInt16MenuItem_Click);
            // 
            // NewUInt16MenuItem
            // 
            this.NewUInt16MenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewUInt16MenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewUInt16MenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxInteger;
            this.NewUInt16MenuItem.Name = "NewUInt16MenuItem";
            this.NewUInt16MenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewUInt16MenuItem.Text = "UInt16";
            this.NewUInt16MenuItem.Click += new System.EventHandler(this.NewUInt16MenuItem_Click);
            // 
            // NewInt32MenuItem
            // 
            this.NewInt32MenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewInt32MenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewInt32MenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxInteger;
            this.NewInt32MenuItem.Name = "NewInt32MenuItem";
            this.NewInt32MenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewInt32MenuItem.Text = "Int32";
            this.NewInt32MenuItem.Click += new System.EventHandler(this.NewInt32MenuItem_Click);
            // 
            // NewUInt32MenuItem
            // 
            this.NewUInt32MenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewUInt32MenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewUInt32MenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxInteger;
            this.NewUInt32MenuItem.Name = "NewUInt32MenuItem";
            this.NewUInt32MenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewUInt32MenuItem.Text = "UInt32";
            this.NewUInt32MenuItem.Click += new System.EventHandler(this.NewUInt32MenuItem_Click);
            // 
            // NewInt64MenuItem
            // 
            this.NewInt64MenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewInt64MenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewInt64MenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxInteger;
            this.NewInt64MenuItem.Name = "NewInt64MenuItem";
            this.NewInt64MenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewInt64MenuItem.Text = "Int64";
            this.NewInt64MenuItem.Click += new System.EventHandler(this.NewInt64MenuItem_Click);
            // 
            // NewUInt64MenuItem
            // 
            this.NewUInt64MenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewUInt64MenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewUInt64MenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxInteger;
            this.NewUInt64MenuItem.Name = "NewUInt64MenuItem";
            this.NewUInt64MenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewUInt64MenuItem.Text = "UInt64";
            this.NewUInt64MenuItem.Click += new System.EventHandler(this.NewUInt64MenuItem_Click);
            // 
            // NewSingleMenuItem
            // 
            this.NewSingleMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewSingleMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewSingleMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxDouble;
            this.NewSingleMenuItem.Name = "NewSingleMenuItem";
            this.NewSingleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewSingleMenuItem.Text = "Single";
            this.NewSingleMenuItem.Click += new System.EventHandler(this.NewSingleMenuItem_Click);
            // 
            // NewDoubleMenuItem
            // 
            this.NewDoubleMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewDoubleMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewDoubleMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxDouble;
            this.NewDoubleMenuItem.Name = "NewDoubleMenuItem";
            this.NewDoubleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewDoubleMenuItem.Text = "Double";
            this.NewDoubleMenuItem.Click += new System.EventHandler(this.NewDoubleMenuItem_Click);
            // 
            // NewDecimalMenuItem
            // 
            this.NewDecimalMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewDecimalMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewDecimalMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxDouble;
            this.NewDecimalMenuItem.Name = "NewDecimalMenuItem";
            this.NewDecimalMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewDecimalMenuItem.Text = "Decimal";
            this.NewDecimalMenuItem.Click += new System.EventHandler(this.NewDecimalMenuItem_Click);
            // 
            // NewCharMenuItem
            // 
            this.NewCharMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewCharMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewCharMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxAttribute;
            this.NewCharMenuItem.Name = "NewCharMenuItem";
            this.NewCharMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewCharMenuItem.Text = "Char";
            this.NewCharMenuItem.Click += new System.EventHandler(this.NewCharMenuItem_Click);
            // 
            // NewBooleanMenuItem
            // 
            this.NewBooleanMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewBooleanMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewBooleanMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxBoolean;
            this.NewBooleanMenuItem.Name = "NewBooleanMenuItem";
            this.NewBooleanMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewBooleanMenuItem.Text = "Boolean";
            this.NewBooleanMenuItem.Click += new System.EventHandler(this.NewBooleanMenuItem_Click);
            // 
            // NewStringMenuItem
            // 
            this.NewStringMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewStringMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewStringMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxString;
            this.NewStringMenuItem.Name = "NewStringMenuItem";
            this.NewStringMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewStringMenuItem.Text = "String";
            this.NewStringMenuItem.Click += new System.EventHandler(this.NewStringMenuItem_Click);
            // 
            // NewDateTimeMenuItem
            // 
            this.NewDateTimeMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewDateTimeMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewDateTimeMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxCalendar;
            this.NewDateTimeMenuItem.Name = "NewDateTimeMenuItem";
            this.NewDateTimeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewDateTimeMenuItem.Text = "DateTime";
            this.NewDateTimeMenuItem.Click += new System.EventHandler(this.NewDateTimeMenuItem_Click);
            // 
            // NewSeperator
            // 
            this.NewSeperator.Name = "NewSeperator";
            this.NewSeperator.Size = new System.Drawing.Size(152, 6);
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CopyMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxCopyItem;
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.Size = new System.Drawing.Size(155, 22);
            this.CopyMenuItem.Text = "Copy";
            // 
            // PasteMenuItem
            // 
            this.PasteMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PasteMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxPaste;
            this.PasteMenuItem.Name = "PasteMenuItem";
            this.PasteMenuItem.Size = new System.Drawing.Size(155, 22);
            this.PasteMenuItem.Text = "Paste";
            // 
            // PasteSeparator
            // 
            this.PasteSeparator.Name = "PasteSeparator";
            this.PasteSeparator.Size = new System.Drawing.Size(152, 6);
            // 
            // RenameMenuItem
            // 
            this.RenameMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RenameMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxRename;
            this.RenameMenuItem.Name = "RenameMenuItem";
            this.RenameMenuItem.Size = new System.Drawing.Size(155, 22);
            this.RenameMenuItem.Text = "Rename";
            this.RenameMenuItem.Click += new System.EventHandler(this.RenameMenuItem_Click);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteMenuItem.Image = global::BofEditorGUI.Properties.Resources._16pxTrash;
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.Size = new System.Drawing.Size(155, 22);
            this.DeleteMenuItem.Text = "Delete";
            this.DeleteMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.ColumnCount = 2;
            this.HeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.HeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderPanel.Controls.Add(this.PathPanelContainer, 0, 0);
            this.HeaderPanel.Controls.Add(this.ButtonPanel, 0, 0);
            this.HeaderPanel.Location = new System.Drawing.Point(7, 6);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.RowCount = 1;
            this.HeaderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderPanel.Size = new System.Drawing.Size(673, 31);
            this.HeaderPanel.TabIndex = 3;
            // 
            // PathPanelContainer
            // 
            this.PathPanelContainer.Controls.Add(this.PathPanel);
            this.PathPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathPanelContainer.Location = new System.Drawing.Point(85, 0);
            this.PathPanelContainer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.PathPanelContainer.Name = "PathPanelContainer";
            this.PathPanelContainer.Size = new System.Drawing.Size(588, 25);
            this.PathPanelContainer.TabIndex = 2;
            // 
            // PathPanel
            // 
            this.PathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathPanel.Location = new System.Drawing.Point(0, 0);
            this.PathPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PathPanel.Name = "PathPanel";
            this.PathPanel.Size = new System.Drawing.Size(588, 25);
            this.PathPanel.TabIndex = 0;
            this.PathPanel.ButtonClick += new System.EventHandler(this.PathPanel_ButtonClick);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.PrevButton);
            this.ButtonPanel.Controls.Add(this.RefreshButton);
            this.ButtonPanel.Controls.Add(this.ForwardButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(85, 31);
            this.ButtonPanel.TabIndex = 0;
            // 
            // PrevButton
            // 
            this.PrevButton.BackgroundImage = global::BofEditorGUI.Properties.Resources._512pxLeftArrow;
            this.PrevButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PrevButton.FlatAppearance.BorderSize = 0;
            this.PrevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PrevButton.Location = new System.Drawing.Point(0, 1);
            this.PrevButton.Margin = new System.Windows.Forms.Padding(0);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(23, 23);
            this.PrevButton.TabIndex = 3;
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = global::BofEditorGUI.Properties.Resources.Refresh;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RefreshButton.Location = new System.Drawing.Point(59, 1);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 23);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackgroundImage = global::BofEditorGUI.Properties.Resources._512pxRightArrow;
            this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ForwardButton.FlatAppearance.BorderSize = 0;
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ForwardButton.Location = new System.Drawing.Point(24, 1);
            this.ForwardButton.Margin = new System.Windows.Forms.Padding(0);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(23, 23);
            this.ForwardButton.TabIndex = 1;
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // BofEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(687, 391);
            this.Controls.Add(this.GlobalContainer);
            this.Name = "BofEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bof Editor";
            this.Load += new System.EventHandler(this.BofEditor_Load);
            this.GlobalContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.PathPanelContainer.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TableLayoutPanel HeaderPanel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Panel PathPanelContainer;
        private CustomDialogs.PathNodePanel PathPanel;
        private CustomDialogs.TextAndImageColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCol;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripSeparator NewSeperator;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteMenuItem;
        private System.Windows.Forms.ToolStripSeparator PasteSeparator;
        private System.Windows.Forms.ToolStripMenuItem RenameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewObjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewArrayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewListMenuItem;
        private System.Windows.Forms.ToolStripSeparator NewListSeparator;
        private System.Windows.Forms.ToolStripMenuItem NewByteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewSByteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewInt16MenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewUInt16MenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewInt32MenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewUInt32MenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewInt64MenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem NewUInt64MenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewSingleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewDoubleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewDecimalMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewCharMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewBooleanMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewStringMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewDateTimeMenuItem;
    }
}