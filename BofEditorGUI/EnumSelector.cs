using System;
using System.Windows.Forms;

namespace BofEditorGUI {
    public partial class EnumSelector : Form {
        public Enum SelectedEnum { get; private set; }
        public bool DialogClosed { get; private set; } = true;

        public string Title { get; }
        public string Message { get; }

        public EnumSelector(string title, string message, Enum enumValue) {
            InitializeComponent();

            Title = title;
            Message = message;

            Text = Title;
            MessageLabel.Text = Message;

            SelectedEnum = enumValue;

            foreach (var value in Enum.GetNames(enumValue.GetType())) {
                EnumComboBox.Items.Add(value);
            }

            EnumComboBox.SelectedItem = Enum.GetName(enumValue.GetType(), enumValue);
        }

        private void EnumComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            SelectedEnum = (Enum)Enum.Parse(SelectedEnum.GetType(), (string)EnumComboBox.SelectedItem);
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            Close();
        }
        private void DoneButton_Click(object sender, EventArgs e) {
            DialogClosed = false;
            Close();
        }
    }
}
