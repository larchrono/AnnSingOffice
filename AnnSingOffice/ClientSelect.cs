using System;
using System.Windows.Forms;

namespace AnnSingOffice
{
    public partial class ClientSelect : Form
    {

        public string ReturnValue1 { get; set; }
        public string ReturnValue2 { get; set; }

        public ClientSelect()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            this.ReturnValue1 = "Something";
            this.ReturnValue2 = DateTime.Now.ToString(); //example
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
