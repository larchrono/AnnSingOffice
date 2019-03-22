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
                SQLManager.CreateData(SQLManager.DataType.Product);
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
            foreach(PictureBox pbox in listPictureBox)
            {
                pbox.Image = null;
            }
            comboBoxSimPrice.Text = "";
            comboBoxSimPrice.Items.Clear();
            ClearTextBoxShip();
        }

        string ComboBoxToString(ComboBox cb)
        {
            string result = "";
            foreach(var item in cb.Items)
            {
                if (result != "")
                    result += ",";
                result = result + item.ToString();
            }
            return result;
        }

        void StringToComboBox(string src,ComboBox cb)
        {
            cb.Items.Clear();
            cb.Text = "";
            if (string.IsNullOrEmpty(src))
                return;
            
            string[] result = src.Split(',');
            foreach (string s in result)
            {
                if (s.Trim() != "")
                {
                    cb.Items.Add(s);
                    cb.SelectedIndex = 0;
                }
            }
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
            CurrentData.Price = ComboBoxToString(comboBoxSimPrice);

            CurrentData.Picture_1 = pictureBox1.ImageLocation;
            CurrentData.Picture_2 = pictureBox2.ImageLocation;
            CurrentData.Picture_3 = pictureBox3.ImageLocation;

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
            StringToComboBox(data.Price,comboBoxSimPrice);

            pictureBox1.ImageLocation = data.Picture_1;
            pictureBox2.ImageLocation = data.Picture_2;
            pictureBox3.ImageLocation = data.Picture_3;

            try
            {
                pictureBox1.Load();
                pictureBox2.Load();
                pictureBox3.Load();
            }
            catch (Exception e) { }

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

        void SetPictureBoxImage(PictureBox pbox)
        {
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialogImage.FileName;
                //pbox.Image = Image.FromFile(file);
                pbox.ImageLocation = file;
                pbox.Load();
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SetPictureBoxImage(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SetPictureBoxImage(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SetPictureBoxImage(pictureBox3);
        }

        private void comboBoxSimPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string context = comboBoxSimPrice.Text;
                comboBoxSimPrice.Items.Add(context);
                comboBoxSimPrice.Sorted = true;

                //Remove sound
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void comboBoxSimPrice_Leave(object sender, EventArgs e)
        {
            string context = comboBoxSimPrice.Text;
            if (context != "" && !comboBoxSimPrice.Items.Contains(context))
            {
                comboBoxSimPrice.Items.Add(context);
                comboBoxSimPrice.Sorted = true;
            }
        }

        private void buttonSimPriceClear_Click(object sender, EventArgs e)
        {
            string context = comboBoxSimPrice.Text;
            comboBoxSimPrice.Items.Remove(context);
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string goalStr = textBoxSearch.Text;

                if (goalStr == "")
                {
                    UpdateListAll();
                }
                else
                {
                    dataList = SQLManager.SelectData(SQLManager.DataType.Product, goalStr) as List<ProductData>;
                    UpdateList(dataList);
                }

                //Remove sound
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (nowSelectListId >= dataList.Count)
                return;
            if (dataList[nowSelectListId] == null)
                return;

            string targetName = dataList[nowSelectListId].NCOrder;
            DialogResult result = MessageBox.Show("確認刪除[" + targetName + "]?", "系統訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            SQLManager.DeleteData(SQLManager.DataType.Product, dataList[nowSelectListId].Id);

            UpdateListAll();
        }
    }
}
