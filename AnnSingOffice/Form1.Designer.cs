namespace AnnSingOffice
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageListTC = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SQLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SQLLocateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顯示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字型大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.幫助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明書ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonWork = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonStock = new System.Windows.Forms.Button();
            this.panelWork = new System.Windows.Forms.Panel();
            this.openFileDialogSQL = new System.Windows.Forms.OpenFileDialog();
            this.buttonShipOrder = new System.Windows.Forms.Button();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListTC
            // 
            this.imageListTC.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTC.ImageStream")));
            this.imageListTC.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTC.Images.SetKeyName(0, "shejiyeiconz2gvi45og2w.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.顯示ToolStripMenuItem,
            this.幫助ToolStripMenuItem,
            this.版本ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SQLiteToolStripMenuItem,
            this.SQLLocateToolStripMenuItem,
            this.BackupToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // SQLiteToolStripMenuItem
            // 
            this.SQLiteToolStripMenuItem.Name = "SQLiteToolStripMenuItem";
            this.SQLiteToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.SQLiteToolStripMenuItem.Text = "資料庫選擇";
            this.SQLiteToolStripMenuItem.Click += new System.EventHandler(this.SQLiteToolStripMenuItem_Click);
            // 
            // SQLLocateToolStripMenuItem
            // 
            this.SQLLocateToolStripMenuItem.Name = "SQLLocateToolStripMenuItem";
            this.SQLLocateToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.SQLLocateToolStripMenuItem.Text = "當前資料庫位置";
            this.SQLLocateToolStripMenuItem.Click += new System.EventHandler(this.SQLLocateToolStripMenuItem_Click);
            // 
            // BackupToolStripMenuItem
            // 
            this.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem";
            this.BackupToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.BackupToolStripMenuItem.Text = "備份資料庫";
            this.BackupToolStripMenuItem.Click += new System.EventHandler(this.BackupToolStripMenuItem_Click);
            // 
            // 顯示ToolStripMenuItem
            // 
            this.顯示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字型大小ToolStripMenuItem});
            this.顯示ToolStripMenuItem.Name = "顯示ToolStripMenuItem";
            this.顯示ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.顯示ToolStripMenuItem.Text = "顯示";
            // 
            // 字型大小ToolStripMenuItem
            // 
            this.字型大小ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.字型大小ToolStripMenuItem.Name = "字型大小ToolStripMenuItem";
            this.字型大小ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.字型大小ToolStripMenuItem.Text = "字型大小";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "9",
            "12",
            "15",
            "18"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // 幫助ToolStripMenuItem
            // 
            this.幫助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.說明書ToolStripMenuItem});
            this.幫助ToolStripMenuItem.Name = "幫助ToolStripMenuItem";
            this.幫助ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.幫助ToolStripMenuItem.Text = "幫助";
            // 
            // 說明書ToolStripMenuItem
            // 
            this.說明書ToolStripMenuItem.Name = "說明書ToolStripMenuItem";
            this.說明書ToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.說明書ToolStripMenuItem.Text = "說明書";
            // 
            // 版本ToolStripMenuItem
            // 
            this.版本ToolStripMenuItem.Name = "版本ToolStripMenuItem";
            this.版本ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.版本ToolStripMenuItem.Text = "版本";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("新細明體", 12F);
            this.buttonSearch.Location = new System.Drawing.Point(143, 38);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(125, 60);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "(未定)";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonWork
            // 
            this.buttonWork.Font = new System.Drawing.Font("新細明體", 12F);
            this.buttonWork.Location = new System.Drawing.Point(12, 38);
            this.buttonWork.Name = "buttonWork";
            this.buttonWork.Size = new System.Drawing.Size(125, 60);
            this.buttonWork.TabIndex = 3;
            this.buttonWork.Text = "(未定)";
            this.buttonWork.UseVisualStyleBackColor = true;
            this.buttonWork.Click += new System.EventHandler(this.buttonWork_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Font = new System.Drawing.Font("新細明體", 12F);
            this.buttonClient.Location = new System.Drawing.Point(865, 38);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(125, 60);
            this.buttonClient.TabIndex = 3;
            this.buttonClient.Text = "客戶資料";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.Font = new System.Drawing.Font("新細明體", 12F);
            this.buttonProduct.Location = new System.Drawing.Point(996, 38);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(125, 60);
            this.buttonProduct.TabIndex = 3;
            this.buttonProduct.Text = "產品資料";
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // buttonStock
            // 
            this.buttonStock.Font = new System.Drawing.Font("新細明體", 12F);
            this.buttonStock.Location = new System.Drawing.Point(1127, 38);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(125, 60);
            this.buttonStock.TabIndex = 3;
            this.buttonStock.Text = "原料庫存";
            this.buttonStock.UseVisualStyleBackColor = true;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // panelWork
            // 
            this.panelWork.Location = new System.Drawing.Point(12, 104);
            this.panelWork.Name = "panelWork";
            this.panelWork.Size = new System.Drawing.Size(1240, 565);
            this.panelWork.TabIndex = 4;
            // 
            // openFileDialogSQL
            // 
            this.openFileDialogSQL.Filter = "資料庫檔案 (*.sqlite)|*.sqlite";
            // 
            // buttonShipOrder
            // 
            this.buttonShipOrder.Font = new System.Drawing.Font("新細明體", 12F);
            this.buttonShipOrder.Location = new System.Drawing.Point(274, 38);
            this.buttonShipOrder.Name = "buttonShipOrder";
            this.buttonShipOrder.Size = new System.Drawing.Size(125, 60);
            this.buttonShipOrder.TabIndex = 3;
            this.buttonShipOrder.Text = "出貨";
            this.buttonShipOrder.UseVisualStyleBackColor = true;
            this.buttonShipOrder.Click += new System.EventHandler(this.buttonShipOrder_Click);
            // 
            // buttonPayment
            // 
            this.buttonPayment.Font = new System.Drawing.Font("新細明體", 12F);
            this.buttonPayment.Location = new System.Drawing.Point(405, 38);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(125, 60);
            this.buttonPayment.TabIndex = 3;
            this.buttonPayment.Text = "請款";
            this.buttonPayment.UseVisualStyleBackColor = true;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelWork);
            this.Controls.Add(this.buttonWork);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.buttonShipOrder);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "安興";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageListTC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SQLiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 幫助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明書ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本ToolStripMenuItem;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonWork;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.ToolStripMenuItem 顯示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字型大小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Panel panelWork;
        private System.Windows.Forms.OpenFileDialog openFileDialogSQL;
        private System.Windows.Forms.ToolStripMenuItem SQLLocateToolStripMenuItem;
        private System.Windows.Forms.Button buttonShipOrder;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.ToolStripMenuItem BackupToolStripMenuItem;
    }
}

