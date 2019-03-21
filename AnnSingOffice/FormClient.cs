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

namespace AnnSingOffice
{
    public partial class FormClient : FormExtension
    {
        //String Pre-define
        const string groupBoxPretext = "編號：";

        int nowSelectListId;
        List<ClientData> clientList;

        ClientData CurrentClientData;

        public FormClient()
        {
            InitializeComponent();
            //Application.ExitThread();
            //System.Environment.Exit(0);
            
        }


        public override void ActiveWork()
        {
            base.ActiveWork();
            UpdateClientListView();

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

        void InsertClientToSQL(ClientData data)
        {
            using (var cn = new SQLiteConnection(AnnGlobal.cnStr))
            {
                //1) 可執行SQL資料更新指令，支援參數
                //2) 以陣列方式提供多組參數，可重複執行同一SQL指令

                //cn.Execute(@"INSERT INTO ClientData")

               // cn.Execute(@"INSERT INTO ClientData VALUES (NULL , @Name , @SimpleName , @Address , @PhoneNumber , @Fax , @TaxId , @Email , @Date , @Memo)",
               //     new { Name = name, SimpleName = simpleName, Address = addr, PhoneNumber = number, Fax = fax, TaxId = taxId, Email = email, Date = DateTime.Now, Memo = memo });
            }
        }

        void ListDataAdd(string name, string simpleName, string addr, string number, string fax, string taxId, string email)
        {
            int useId = listView1.Items.Count;
            ListViewItem temp = new ListViewItem();
            temp.Text = useId.ToString();
            temp.SubItems.Add(simpleName);
            listView1.Items.Add(temp);
            ClearTextBox();
        }

        /// <summary>
        /// 更新ListView的內容，並且更新clientList這個List變數
        /// </summary>
        public void UpdateClientListView()
        {
            listView1.Items.Clear();

            using (var cn = new SQLiteConnection(AnnGlobal.cnStr))
            {
                clientList = cn.Query<ClientData>("SELECT * FROM ClientData").ToList();
            }
            if (clientList == null)
                return;
            for(int i = 0; i < clientList.Count; i++)
            {
                ListViewItem temp = new ListViewItem();
                temp.Text = clientList[i].Id.ToString();
                temp.SubItems.Add(clientList[i].SimpleName);
                listView1.Items.Add(temp);
            }
        }

        void ClearTextBox()
        {
            textName.Text = "";
            textSimName.Text = "";
            textAddress.Text = "";
            textHomeNumber.Text = "";
            textFax.Text = "";
            textTaxId.Text = "";
            textWebsite.Text = "";
            textMemo.Text = "";
        }


        private void buttonTest_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddData_Click(object sender, EventArgs e)
        {
            var clientData = GenerateCurrentClientData();
            InsertClientToSQL(clientData);
            UpdateClientListView();
            
            //ListDataAdd(name, simpleName, addr, number,fax,taxId,email);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (clientList == null)
                return;
            if (clientList[nowSelectListId] == null)
                return;
            int updateId = clientList[nowSelectListId].Id;

            using (var cn = new SQLiteConnection(AnnGlobal.cnStr))
            {

                string strSql = @"UPDATE ClientData SET 
                                Name = @Name,
                                SimpleName = @SimpleName,
                                Address = @Address,
                                PhoneNumber = @PhoneNumber,
                                Fax = @Fax,
                                TaxId = @TaxId,
                                Email = @Email,
                                Memo = @Memo 
                                WHERE Id = @Id";

                ClientData datas = new ClientData(updateId, textName.Text, textSimName.Text, textAddress.Text, textHomeNumber.Text, textFax.Text, textTaxId.Text, textWebsite.Text, textMemo.Text);
                cn.Execute(strSql, datas);

            }
            UpdateClientListView();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;

            if (listView.SelectedItems.Count > 0)
            {
                nowSelectListId = listView.SelectedItems[0].Index;
                if (clientList[nowSelectListId] == null)
                    return;
                string Cid = clientList[nowSelectListId].Id.ToString();
                groupBox1.Text = groupBoxPretext + Cid;

                textName.Text = clientList[nowSelectListId].Name;
                textSimName.Text = clientList[nowSelectListId].SimpleName;
                textAddress.Text = clientList[nowSelectListId].Address;
                textHomeNumber.Text = clientList[nowSelectListId].PhoneNumber;
                textFax.Text = clientList[nowSelectListId].Fax;
                textTaxId.Text = clientList[nowSelectListId].TaxId;
                textWebsite.Text = clientList[nowSelectListId].Email;
                textMemo.Text = clientList[nowSelectListId].Memo;
            }
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string goalStr = textBoxSearch.Text;

                if (goalStr == "")
                {
                    UpdateClientListView();
                }
                else
                {
                    goalStr = "%" + goalStr + "%";

                    //QueryFirstOrDefault
                    using (var cn = new SQLiteConnection(AnnGlobal.cnStr))
                    {
                        string strSql = "SELECT * FROM ClientData WHERE SimpleName LIKE @SimpleName";
                        clientList = cn.Query<ClientData>(strSql, new { SimpleName = goalStr }).ToList();
                    }

                    if (clientList == null)
                        return;

                    listView1.Items.Clear();
                    for (int i = 0; i < clientList.Count; i++)
                    {
                        ListViewItem temp = new ListViewItem();
                        temp.Text = clientList[i].Id.ToString();
                        temp.SubItems.Add(clientList[i].SimpleName);
                        listView1.Items.Add(temp);
                    }
                }
            }
        }




    }
}
