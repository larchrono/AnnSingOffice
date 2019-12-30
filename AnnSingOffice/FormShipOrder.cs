using System;
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
    public partial class FormShipOrder : FormExtension
    {
        int itemListIndex;

        public FormShipOrder()
        {
            InitializeComponent();
        }

        public override void ActiveWork()
        {
            base.ActiveWork();

        }

        private void buttonCreateNo_Click(object sender, EventArgs e)
        {

        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            textBoxShipDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void buttonContact_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelectClient_Click(object sender, EventArgs e)
        {
            ClientSelect clientSelect = new ClientSelect();
            
            var result = clientSelect.ShowDialog();
            if (result == DialogResult.OK)
            {
                string val = clientSelect.ReturnValue1;            //values preserved after close
                string dateString = clientSelect.ReturnValue2;
                //Do something here with these values

                MessageBox.Show("ok");
            }
            MessageBox.Show("no");
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            ProductData testData = new ProductData();
            testData.Id = 15;
            testData.InDiameter = "20";
            testData.Machine = "FA2";
            testData.Memo = "is good";
            testData.NCNumber = "O2100";
            testData.NCOrder = "quae";
            testData.OutDiameter = "17";
            testData.Price = "125,120,175";
            testData.Spec = "G503";

            ListViewItem temp = new ListViewItem();
            temp.Text = (itemListIndex + 1).ToString();
            temp.SubItems.Add(testData.NCOrder);
            temp.SubItems.Add(testData.Spec);
            temp.SubItems.Add("20");
            temp.SubItems.Add("15");
            temp.SubItems.Add("250");
            temp.SubItems.Add("5000");
            temp.SubItems.Add("Memos");
            listViewProduct.Items.Add(temp);

            itemListIndex++;

        }
    }
}
