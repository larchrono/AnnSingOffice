﻿namespace AnnSingOffice
{
    partial class FormShipOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLastCreate = new System.Windows.Forms.Button();
            this.buttonRemoveProduct = new System.Windows.Forms.Button();
            this.buttonConform = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonLazy = new System.Windows.Forms.Button();
            this.buttonSelectClient = new System.Windows.Forms.Button();
            this.buttonContact = new System.Windows.Forms.Button();
            this.buttonCreateNo = new System.Windows.Forms.Button();
            this.buttonToday = new System.Windows.Forms.Button();
            this.textBoxClientTaxId = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxClientNo = new System.Windows.Forms.TextBox();
            this.textBoxShipAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxShipClient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxShipContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxShipNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxShipDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 12F);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1215, 540);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewProduct);
            this.tabPage1.Controls.Add(this.buttonLastCreate);
            this.tabPage1.Controls.Add(this.buttonRemoveProduct);
            this.tabPage1.Controls.Add(this.buttonReset);
            this.tabPage1.Controls.Add(this.buttonConform);
            this.tabPage1.Controls.Add(this.buttonAddProduct);
            this.tabPage1.Controls.Add(this.buttonLazy);
            this.tabPage1.Controls.Add(this.buttonSelectClient);
            this.tabPage1.Controls.Add(this.buttonContact);
            this.tabPage1.Controls.Add(this.buttonCreateNo);
            this.tabPage1.Controls.Add(this.buttonToday);
            this.tabPage1.Controls.Add(this.textBoxClientTaxId);
            this.tabPage1.Controls.Add(this.textBoxPhone);
            this.tabPage1.Controls.Add(this.textBoxClientNo);
            this.tabPage1.Controls.Add(this.textBoxShipAddress);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxShipClient);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxShipContact);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxShipNo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxShipDate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("新細明體", 12F);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1207, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "資料編輯";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewProduct
            // 
            this.listViewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewProduct.FullRowSelect = true;
            this.listViewProduct.GridLines = true;
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(31, 217);
            this.listViewProduct.MultiSelect = false;
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(1018, 287);
            this.listViewProduct.TabIndex = 4;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "項次";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "產品編號";
            this.columnHeader2.Width = 148;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "品名規格";
            this.columnHeader3.Width = 159;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "數量";
            this.columnHeader4.Width = 71;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "單位";
            this.columnHeader5.Width = 74;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "單價";
            this.columnHeader6.Width = 73;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "小計";
            this.columnHeader7.Width = 95;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "備註";
            this.columnHeader8.Width = 285;
            // 
            // buttonLastCreate
            // 
            this.buttonLastCreate.Location = new System.Drawing.Point(138, 16);
            this.buttonLastCreate.Name = "buttonLastCreate";
            this.buttonLastCreate.Size = new System.Drawing.Size(101, 32);
            this.buttonLastCreate.TabIndex = 3;
            this.buttonLastCreate.Text = "上次生成";
            this.buttonLastCreate.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveProduct
            // 
            this.buttonRemoveProduct.Location = new System.Drawing.Point(138, 179);
            this.buttonRemoveProduct.Name = "buttonRemoveProduct";
            this.buttonRemoveProduct.Size = new System.Drawing.Size(101, 32);
            this.buttonRemoveProduct.TabIndex = 3;
            this.buttonRemoveProduct.Text = "移除產品";
            this.buttonRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // buttonConform
            // 
            this.buttonConform.Location = new System.Drawing.Point(1055, 448);
            this.buttonConform.Name = "buttonConform";
            this.buttonConform.Size = new System.Drawing.Size(146, 56);
            this.buttonConform.TabIndex = 3;
            this.buttonConform.Text = "確定";
            this.buttonConform.UseVisualStyleBackColor = true;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(31, 179);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(101, 32);
            this.buttonAddProduct.TabIndex = 3;
            this.buttonAddProduct.Text = "加入產品";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonLazy
            // 
            this.buttonLazy.Location = new System.Drawing.Point(31, 16);
            this.buttonLazy.Name = "buttonLazy";
            this.buttonLazy.Size = new System.Drawing.Size(101, 32);
            this.buttonLazy.TabIndex = 3;
            this.buttonLazy.Text = "一鍵生成";
            this.buttonLazy.UseVisualStyleBackColor = true;
            // 
            // buttonSelectClient
            // 
            this.buttonSelectClient.Location = new System.Drawing.Point(754, 63);
            this.buttonSelectClient.Name = "buttonSelectClient";
            this.buttonSelectClient.Size = new System.Drawing.Size(105, 27);
            this.buttonSelectClient.TabIndex = 2;
            this.buttonSelectClient.Text = "選擇";
            this.buttonSelectClient.UseVisualStyleBackColor = true;
            this.buttonSelectClient.Click += new System.EventHandler(this.buttonSelectClient_Click);
            // 
            // buttonContact
            // 
            this.buttonContact.Location = new System.Drawing.Point(329, 129);
            this.buttonContact.Name = "buttonContact";
            this.buttonContact.Size = new System.Drawing.Size(105, 27);
            this.buttonContact.TabIndex = 2;
            this.buttonContact.Text = "預設";
            this.buttonContact.UseVisualStyleBackColor = true;
            this.buttonContact.Click += new System.EventHandler(this.buttonContact_Click);
            // 
            // buttonCreateNo
            // 
            this.buttonCreateNo.Location = new System.Drawing.Point(329, 64);
            this.buttonCreateNo.Name = "buttonCreateNo";
            this.buttonCreateNo.Size = new System.Drawing.Size(105, 27);
            this.buttonCreateNo.TabIndex = 2;
            this.buttonCreateNo.Text = "自動產生";
            this.buttonCreateNo.UseVisualStyleBackColor = true;
            this.buttonCreateNo.Click += new System.EventHandler(this.buttonCreateNo_Click);
            // 
            // buttonToday
            // 
            this.buttonToday.Location = new System.Drawing.Point(329, 97);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(105, 27);
            this.buttonToday.TabIndex = 2;
            this.buttonToday.Text = "使用今日";
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // textBoxClientTaxId
            // 
            this.textBoxClientTaxId.Location = new System.Drawing.Point(832, 129);
            this.textBoxClientTaxId.Name = "textBoxClientTaxId";
            this.textBoxClientTaxId.Size = new System.Drawing.Size(217, 27);
            this.textBoxClientTaxId.TabIndex = 1;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(531, 129);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(217, 27);
            this.textBoxPhone.TabIndex = 1;
            // 
            // textBoxClientNo
            // 
            this.textBoxClientNo.Location = new System.Drawing.Point(832, 96);
            this.textBoxClientNo.Name = "textBoxClientNo";
            this.textBoxClientNo.Size = new System.Drawing.Size(217, 27);
            this.textBoxClientNo.TabIndex = 1;
            // 
            // textBoxShipAddress
            // 
            this.textBoxShipAddress.Location = new System.Drawing.Point(531, 96);
            this.textBoxShipAddress.Name = "textBoxShipAddress";
            this.textBoxShipAddress.Size = new System.Drawing.Size(217, 27);
            this.textBoxShipAddress.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(754, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "統一編號";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "連絡電話";
            // 
            // textBoxShipClient
            // 
            this.textBoxShipClient.Enabled = false;
            this.textBoxShipClient.Location = new System.Drawing.Point(531, 63);
            this.textBoxShipClient.Name = "textBoxShipClient";
            this.textBoxShipClient.Size = new System.Drawing.Size(217, 27);
            this.textBoxShipClient.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(754, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "客戶編號";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "送貨地址";
            // 
            // textBoxShipContact
            // 
            this.textBoxShipContact.Location = new System.Drawing.Point(106, 129);
            this.textBoxShipContact.Name = "textBoxShipContact";
            this.textBoxShipContact.Size = new System.Drawing.Size(217, 27);
            this.textBoxShipContact.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "客戶名稱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "業務人員";
            // 
            // textBoxShipNo
            // 
            this.textBoxShipNo.Location = new System.Drawing.Point(106, 64);
            this.textBoxShipNo.Name = "textBoxShipNo";
            this.textBoxShipNo.Size = new System.Drawing.Size(217, 27);
            this.textBoxShipNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "銷貨單號";
            // 
            // textBoxShipDate
            // 
            this.textBoxShipDate.Location = new System.Drawing.Point(106, 97);
            this.textBoxShipDate.Name = "textBoxShipDate";
            this.textBoxShipDate.Size = new System.Drawing.Size(217, 27);
            this.textBoxShipDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "銷貨日期";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Font = new System.Drawing.Font("新細明體", 12F);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1207, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "預覽";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(527, 23);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 29);
            this.button8.TabIndex = 1;
            this.button8.Text = "確認列印";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(1055, 6);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(146, 56);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "清除重填";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // FormShipOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1240, 565);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormShipOrder";
            this.Text = "FormShipOrder";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.TextBox textBoxShipDate;
        private System.Windows.Forms.Button buttonCreateNo;
        private System.Windows.Forms.TextBox textBoxShipNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonContact;
        private System.Windows.Forms.TextBox textBoxShipContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLazy;
        private System.Windows.Forms.Button buttonLastCreate;
        private System.Windows.Forms.Button buttonSelectClient;
        private System.Windows.Forms.TextBox textBoxShipAddress;
        private System.Windows.Forms.TextBox textBoxShipClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxClientTaxId;
        private System.Windows.Forms.TextBox textBoxClientNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonRemoveProduct;
        private System.Windows.Forms.Button buttonConform;
        private System.Windows.Forms.Button buttonReset;
    }
}