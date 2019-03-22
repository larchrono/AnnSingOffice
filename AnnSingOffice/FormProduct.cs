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
    public partial class FormProduct : FormExtension
    {
        //String Pre-define
        const string groupBoxPretext = "項次：";
        const string _TABLENAME = "ProductData";

        int nowSelectListId;
        List<ProductData> dataList;

        List<TextBox> listTextBoxSpec = new List<TextBox>();
        List<TextBox> listTextBoxShip = new List<TextBox>();
        List<PictureBox> listPictureBox = new List<PictureBox>();

        ProductData CurrentData;

        public FormProduct()
        {
            InitializeComponent();

            listTextBoxSpec.Add(textBoxSpec);
            listTextBoxSpec.Add(textBoxInner);
            listTextBoxSpec.Add(textBoxOutter);
            listTextBoxSpec.Add(textBoxLength);

            listTextBoxSpec.Add(textBoxOrder);
            listTextBoxSpec.Add(textBoxMachine);
            listTextBoxSpec.Add(textBoxNC);

            listTextBoxSpec.Add(textBoxMemo);
            /////Part
            listTextBoxShip.Add(textBoxNumber);
            listTextBoxShip.Add(textBoxUnit);
            listTextBoxShip.Add(textBoxPrice);
            listTextBoxShip.Add(textBoxTotal);
            /////Part
            listPictureBox.Add(pictureBox1);
            listPictureBox.Add(pictureBox2);
            listPictureBox.Add(pictureBox3);
        }

        /// <summary>
        /// 在這個視窗被顯示時執行
        /// </summary>
        public override void ActiveWork()
        {
            base.ActiveWork();
            UpdateListAll();

            if (!SQLManager.CheckTableExist(_TABLENAME))
                SQLManager.CreateProductData();
        }

        void ClearTextBoxShip()
        {
            foreach (TextBox box in listTextBoxShip)
            {
                box.Text = "";
            }
        }

        void ClearTextBoxSpec()
        {
            foreach (TextBox box in listTextBoxSpec)
            {
                box.Text = "";
            }
            ClearTextBoxShip();
        }

        ProductData GenerateCurrentData()
        {
            // in standard C# , is it need to destroy ?
            CurrentData = new ProductData();

            CurrentData.Spec = textBoxSpec.Text;
            CurrentData.InDiameter = textBoxInner.Text;
            CurrentData.OutDiameter = textBoxOutter.Text;
            CurrentData.TotalLengh = textBoxLength.Text;

            CurrentData.NCOrder = textBoxOrder.Text;
            CurrentData.Machine = textBoxMachine.Text;
            CurrentData.NCNumber = textBoxNC.Text;

            CurrentData.Memo = textBoxMemo.Text;

            return CurrentData;
        }

        void UpdateFormContent(ProductData data)
        {
            // 更新內容的標題流水號，更新日期
            string Cid = data.Id.ToString();
            string date = data.SaveDate.ToString("yyyy-MM-dd  HH:mm");
            groupBoxData.Text = groupBoxPretext + Cid + "　　" + date;

            textBoxSpec.Text = data.Spec;
            textBoxInner.Text = data.InDiameter;
            textBoxOutter.Text = data.OutDiameter;
            textBoxLength.Text = data.TotalLengh;

            textBoxOrder.Text = data.NCOrder;
            textBoxMachine.Text = data.Machine;
            textBoxNC.Text = data.NCNumber;

            textBoxMemo.Text = data.Memo;
        }

        void UpdateList(List<ProductData> list)
        {
            listViewProduct.Items.Clear();

            if (list == null)
                return;

            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem temp = new ListViewItem();
                temp.Text = list[i].Id.ToString();
                temp.SubItems.Add(list[i].NCOrder);
                temp.SubItems.Add(list[i].Spec);

                listViewProduct.Items.Add(temp);
            }
        }
        /// <summary>
        /// 更新ListView的內容，並且更新clientList這個List變數
        /// </summary>
        public void UpdateListAll()
        {
            dataList = SQLManager.GetDataList(SQLManager.DataType.Product) as List<ProductData>;
            UpdateList(dataList);
        }

        private void listViewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;

            if (listView.SelectedItems.Count > 0)
            {
                nowSelectListId = listView.SelectedItems[0].Index;
                if (dataList[nowSelectListId] == null)
                    return;

                UpdateFormContent(dataList[nowSelectListId]);
            }
        }

        private void listViewOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var produceData = GenerateCurrentData();
            SQLManager.InsertData(SQLManager.DataType.Product, produceData);
            UpdateListAll();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataList == null)
                return;
            if (nowSelectListId >= dataList.Count)
                return;
            if (dataList[nowSelectListId] == null)
                return;

            DialogResult result = MessageBox.Show("確認覆蓋資料?", "系統訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            int updateId = dataList[nowSelectListId].Id;

            ProductData data = GenerateCurrentData();
            data.Id = updateId;

            SQLManager.UpdateData(SQLManager.DataType.Product, data);
            UpdateListAll();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxSpec();
        }
    }
}
