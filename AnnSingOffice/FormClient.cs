using System;
using System.IO;
using System.Data.SQLite;
using Dapper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnnSingOffice.Class;
using Newtonsoft.Json;

//Application.ExitThread();
//System.Environment.Exit(0);

namespace AnnSingOffice
{
    public partial class FormClient : FormExtension
    {
        //String Pre-define
        const string groupBoxPretext = "編號：";
        const string _TABLENAME = "ClientData";

        int nowSelectListId;
        List<ClientData> clientList;

        ClientData CurrentClientData;

        List<TextBox> listTextBox = new List<TextBox>();

        void TestReigon()
        {

        }

        public FormClient()
        {
            InitializeComponent();

            listTextBox.Add(textName);
            listTextBox.Add(textSimName);
            listTextBox.Add(textAddress);
            listTextBox.Add(textHomeNumber);
            listTextBox.Add(textPhoneNumber);
            listTextBox.Add(textFax);
            listTextBox.Add(textTaxId);

            listTextBox.Add(textEngName);
            listTextBox.Add(textManager);
            listTextBox.Add(textContactMan);
            listTextBox.Add(textWebsite);
            listTextBox.Add(textEmail);
            listTextBox.Add(textComType);
            listTextBox.Add(textTaxType);

            listTextBox.Add(textMemo);
        }

        /// <summary>
        /// 在這個視窗被顯示時執行
        /// </summary>
        public override void ActiveWork()
        {
            base.ActiveWork();
            UpdateClientListAll();

            if (!SQLManager.CheckTableExist(_TABLENAME))
                SQLManager.CreateData(SQLManager.DataType.Client);

            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        ClientData GenerateCurrentClientData()
        {
            // in standard C# , is it need to destroy ?
            CurrentClientData = new ClientData();

            CurrentClientData.Name = textName.Text;
            CurrentClientData.SimpleName = textSimName.Text;
            CurrentClientData.Address = textAddress.Text;
            CurrentClientData.HomeNumber = textHomeNumber.Text;
            CurrentClientData.PhoneNumber = textPhoneNumber.Text;
            CurrentClientData.Fax = textFax.Text;
            CurrentClientData.TaxId = textTaxId.Text;

            CurrentClientData.EnglishName = textEngName.Text;
            CurrentClientData.Manager = textManager.Text;
            CurrentClientData.ContactMan = textContactMan.Text;
            CurrentClientData.Website = textWebsite.Text;
            CurrentClientData.Email = textEmail.Text;
            CurrentClientData.ComType = textComType.Text;
            CurrentClientData.TaxType = textTaxType.Text;

            CurrentClientData.Memo = textMemo.Text;
            
            return CurrentClientData;
        }

        void UpdateFormContent(ClientData data)
        {
            // 更新內容的標題流水號，更新日期
            string Cid = data.Id.ToString();
            string date = data.SaveDate.ToString("yyyy-MM-dd  HH:mm");
            groupBoxClientData.Text = groupBoxPretext + Cid + "　　" + date;

            textName.Text = data.Name;
            textSimName.Text = data.SimpleName;
            textAddress.Text = data.Address;
            textHomeNumber.Text = data.HomeNumber;
            textPhoneNumber.Text = data.PhoneNumber;
            textFax.Text = data.Fax;
            textTaxId.Text = data.TaxId;

            textEngName.Text = data.EnglishName;
            textManager.Text = data.Manager;
            textContactMan.Text = data.ContactMan;
            textWebsite.Text = data.Website;
            textEmail.Text = data.Email;
            textComType.Text = data.ComType;
            textTaxType.Text = data.TaxType;

            textMemo.Text = data.Memo;
        }

        void UpdateClientList(List<ClientData> list)
        {
            listViewClients.Items.Clear();

            if (list == null)
                return;

            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem temp = new ListViewItem();
                temp.Text = list[i].Id.ToString();
                temp.SubItems.Add(list[i].SimpleName);

                listViewClients.Items.Add(temp);
            }
        }

        /// <summary>
        /// 更新ListView的內容，並且更新clientList這個List變數
        /// </summary>
        public void UpdateClientListAll()
        {
            clientList = SQLManager.GetDataList(SQLManager.DataType.Client) as List<ClientData>;
            UpdateClientList(clientList);
        }

        void ClearTextBox()
        {
            foreach(TextBox box in listTextBox) {
                box.Text = "";
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            TestReigon();
        }

        private void buttonAddData_Click(object sender, EventArgs e)
        {
            var clientData = GenerateCurrentClientData();
            SQLManager.InsertData(SQLManager.DataType.Client, clientData);
            UpdateClientListAll();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (clientList == null)
                return;
            if (nowSelectListId >= clientList.Count)
                return;
            if (clientList[nowSelectListId] == null)
                return;

            DialogResult result = MessageBox.Show("確認覆蓋資料?", "系統訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            int updateId = clientList[nowSelectListId].Id;

            ClientData data = GenerateCurrentClientData();
            data.Id = updateId;

            SQLManager.UpdateData(SQLManager.DataType.Client, data);
            UpdateClientListAll();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;

            if (listView.SelectedItems.Count > 0)
            {
                nowSelectListId = listView.SelectedItems[0].Index;
                if (clientList[nowSelectListId] == null)
                    return;

                UpdateFormContent(clientList[nowSelectListId]);
            }
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string goalStr = textBoxSearch.Text;

                if (goalStr == "")
                {
                    UpdateClientListAll();
                }
                else
                {
                    clientList = SQLManager.SelectData(SQLManager.DataType.Client, goalStr) as List<ClientData>;
                    UpdateClientList(clientList);
                }

                //Remove sound
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (nowSelectListId >= clientList.Count)
                return;
            if (clientList[nowSelectListId] == null)
                return;

            string targetName = clientList[nowSelectListId].SimpleName;
            DialogResult result = MessageBox.Show("確認刪除[" + targetName + "]?", "系統訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            SQLManager.DeleteData(SQLManager.DataType.Client, clientList[nowSelectListId].Id);

            UpdateClientListAll();
        }
    }
}
