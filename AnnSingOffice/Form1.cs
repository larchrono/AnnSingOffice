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
using System.Data.SQLite;
using Newtonsoft.Json;
using Dapper;
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

        private string dataPath = Properties.Settings.Default.dataPath;
        private string fileFolder = Properties.Settings.Default.fileFolder;

        static string initPath = @".\Test.sqlite";
        static string cnStr = "data source=" + initPath;

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

            InitSQLiteDb();

            if(dataPath == "")
                AnnGlobal.cnStr = AnnGlobal.preStr + initPath;
            else
                AnnGlobal.cnStr = AnnGlobal.preStr + dataPath;

        }

        void InitSQLiteDb()
        {
            if (File.Exists(initPath)) return;
            using (SQLiteConnection cn = new SQLiteConnection(cnStr))
            {
                cn.Execute(@"CREATE TABLE ClientData (
                        Id INTEGER PRIMARY KEY NOT NULL,
                        Name VARCHAR(32) NOT NULL,
                        SimpleName VARCHAR(32),
                        Address VARCHAR(64),
                        PhoneNumber VARCHAR(16),
                        Fax VARCHAR(16),
                        TaxId VARCHAR(16),
                        Email VARCHAR(32),
                        Date DATETIME,
                        Memo VARCHAR(128)
                    )");
                dataPath = Properties.Settings.Default.dataPath = Path.GetFullPath(initPath);
                Properties.Settings.Default.Save();
                MessageBox.Show("初次使用，已建立sqlite資料表","系統訊息");
            }
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
                dataPath = Path.GetFullPath(openFileDialogSQL.FileName);
                AnnGlobal.cnStr = AnnGlobal.preStr + dataPath;
                Properties.Settings.Default.dataPath = dataPath;
                Properties.Settings.Default.Save();
                MessageBox.Show("已設定sqlite路徑為 " + dataPath, "系統訊息");
            }
        }

        private void SQLLocateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("當前sqlite路徑為 " + dataPath, "系統訊息");
        }

        
    }
}
