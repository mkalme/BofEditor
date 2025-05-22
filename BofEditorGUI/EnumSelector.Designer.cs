
namespace BofEditorGUI {
    partial class EnumSelector {
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.EnumComboBox = new System.Windows.Forms.ComboBox();
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CancelButton = new CustomDialogs.DarkButton();
            this.DoneButton = new CustomDialogs.DarkButton();
            this.GlobalContainer.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MessageLabel.Location = new System.Drawing.Point(3, 7);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 15);
            this.MessageLabel.TabIndex = 0;
            // 
            // EnumComboBox
            // 
            this.EnumComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EnumComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnumComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnumComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EnumComboBox.FormattingEnabled = true;
            this.EnumComboBox.Location = new System.Drawing.Point(9, 3);
            this.EnumComboBox.Name = "EnumComboBox";
            this.EnumComboBox.Size = new System.Drawing.Size(226, 23);
            this.EnumComboBox.TabIndex = 1;
            this.EnumComboBox.SelectedIndexChanged += new System.EventHandler(this.EnumComboBox_SelectedIndexChanged);
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.HeaderPanel, 0, 0);
            this.GlobalContainer.Controls.Add(this.ButtonPanel, 0, 2);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(0, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.Padding = new System.Windows.Forms.Padding(7);
            this.GlobalContainer.RowCount = 3;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.Size = new System.Drawing.Size(252, 100);
            this.GlobalContainer.TabIndex = 2;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.AutoSize = true;
            this.HeaderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HeaderPanel.ColumnCount = 2;
            this.HeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.HeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderPanel.Controls.Add(this.MessageLabel, 0, 0);
            this.HeaderPanel.Controls.Add(this.EnumComboBox, 1, 0);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderPanel.Location = new System.Drawing.Point(7, 7);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.RowCount = 1;
            this.HeaderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderPanel.Size = new System.Drawing.Size(238, 29);
            this.HeaderPanel.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.AutoSize = true;
            this.ButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonPanel.ColumnCount = 2;
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonPanel.Controls.Add(this.CancelButton, 0, 0);
            this.ButtonPanel.Controls.Add(this.DoneButton, 0, 0);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(7, 62);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Padding = new System.Windows.Forms.Padding(3);
            this.ButtonPanel.RowCount = 1;
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonPanel.Size = new System.Drawing.Size(238, 31);
            this.ButtonPanel.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton.Location = new System.Drawing.Point(88, 3);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 25);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DoneButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(3, 3);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 25);
            this.DoneButton.TabIndex = 2;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // EnumSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(252, 100);
            this.Controls.Add(this.GlobalContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EnumSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enum selector";
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.ComboBox EnumComboBox;
        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.TableLayoutPanel HeaderPanel;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private CustomDialogs.DarkButton CancelButton;
        private CustomDialogs.DarkButton DoneButton;
    }
}