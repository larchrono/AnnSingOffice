using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnnSingOffice.Class;

namespace AnnSingOffice
{
    public partial class Form1 : Form
    {
        FormNormal formNormal;
        FormSearch formSearch;
        FormShipOrder formShipOrder;
        FormPayment formPayment;
        FormClient formClient;
        FormProduct formProduct;
        FormStock formStock;

        public Form1()
        {
            InitializeComponent();

            formNormal      = new FormNormal();
            formSearch      = new FormSearch();
            formShipOrder   = new FormShipOrder();
            formPayment     = new FormPayment();
            formClient      = new FormClient();
            formProduct     = new FormProduct();
            formStock       = new FormStock();

            formNormal.TopLevel = false;
            formSearch.TopLevel = false;
            formShipOrder.TopLevel = false;
            formPayment.TopLevel = false;
            formClient.TopLevel = false;
            formProduct.TopLevel = false;
            formStock.TopLevel = false;

            SQLManager.Init();

            //Clear Setting for Debug
            //Properties.Settings.Default.Reset();
        }

        public void SetAllControlsFont(Control.ControlCollection ctrls , int size)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl.Controls != null)
                    SetAllControlsFont(ctrl.Controls, size);

                ctrl.Font = new Font("新細明體", size);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox comboBox = (ToolStripComboBox)sender;

            // Save the selected employee's name, because we will remove
            // the employee's name from the list.
            string selectedEmployee = (string)comboBox.SelectedItem;

            int size = Convert.ToInt32(selectedEmployee);

            SetAllControlsFont(this.Controls, size);

        }

        //將視窗啟動
        private void SetPanelContent(FormExtension form)
        {
            // ?? maybe add all forms to control will be better
            panelWork.Controls.Add(form);
            form.BringToFront();
            form.Show();
            form.ActiveWork();
        }

        //主要按鈕按鈕事件
        private void buttonWork_Click(object sender, EventArgs e)
        {
            SetPanelContent(formNormal);
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SetPanelContent(formSearch);
        }
        private void buttonShipOrder_Click(object sender, EventArgs e)
        {
            SetPanelContent(formShipOrder);
        }
        private void buttonPayment_Click(object sender, EventArgs e)
        {
            SetPanelContent(formPayment);
        }
        private void buttonClient_Click(object sender, EventArgs e)
        {
            SetPanelContent(formClient);
        }
        private void buttonProduct_Click(object sender, EventArgs e)
        {
            SetPanelContent(formProduct);
        }
        private void buttonStock_Click(object sender, EventArgs e)
        {
            SetPanelContent(formStock);
        }

        private void SQLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogSQL.ShowDialog() == DialogResult.OK)
            {
                SQLManager.SetupPath(Path.GetFullPath(openFileDialogSQL.FileName));
            }
        }

        private void SQLLocateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("當前sqlite路徑為 " + SQLManager.SQLPath, "系統訊息");
        }

        private void BackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileNameWithoutExtension(SQLManager.SQLPath);
            string fileExtension = Path.GetExtension(SQLManager.SQLPath);
            string filePath = Path.GetDirectoryName(SQLManager.SQLPath);
            string date = DateTime.Now.ToString(" yyyy-MM-dd HH-mm");
            string newFile = filePath + @"\" + fileName + date + fileExtension;
            try {
                File.Copy(SQLManager.SQLPath, newFile);
                MessageBox.Show("已備份資料庫:" + newFile, "系統訊息");
            }
            catch(Exception ee) {
                MessageBox.Show(ee.Message.ToString(),"系統訊息");
            }
            
        }
    }
}
