using System;
using System.Windows.Forms;

namespace pr_7
{
    public partial class InputDialog : Form
    {
        public string InputValue { get; private set; }

        public InputDialog(string title, string prompt, string defaultValue = "")
        {
            InitializeComponent();
            this.Text = title;
            lblPrompt.Text = prompt;
            txtInput.Text = defaultValue;
            txtInput.SelectAll();
        }
        

        private void btnOK_Click(object sender, EventArgs e)
        {
            InputValue = txtInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
    }
}
