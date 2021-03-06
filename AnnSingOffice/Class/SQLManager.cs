﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Newtonsoft.Json;
using Dapper;
using AnnSingOffice.Class;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace AnnSingOffice
{
    public class SQLManager
    {
        public const string preStr = "data source=";

        public static string initPath = @".\Test.sqlite";
        public static string SQLPath = "";
        public static string connectString = "";

        //private string fileFolder = Properties.Settings.Default.fileFolder;

        public enum DataType
        {
            Client,
            Product
        }

        public static void Init() {

            //讀取使用者SQL路徑
            SQLPath = Properties.Settings.Default.dataPath;

            if (File.Exists(SQLPath))
            {
                //MessageBox.Show("SQL載入完成", "系統訊息");
            }
            else
            {   //路徑遺失，可能預設路徑已有檔案
                if (!File.Exists(initPath))
                {
                    //建立預設路徑跟檔案
                    SQLiteConnection.CreateFile(initPath);
                    MessageBox.Show("初次使用，已建立sqlite資料表", "系統訊息");
                }

                SQLPath = Path.GetFullPath(initPath);
                Properties.Settings.Default.dataPath = SQLPath;
                Properties.Settings.Default.Save();
            }

            connectString = preStr + SQLPath;
        }

        public static void SetupPath(string path)
        {
            SQLPath = path;
            Properties.Settings.Default.dataPath = SQLPath;
            Properties.Settings.Default.Save();
            MessageBox.Show("已設定sqlite路徑為 " + SQLPath, "系統訊息");

            connectString = preStr + SQLPath;
        }

        public static string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2} {3}:{4}:{5}.{6}";
            return string.Format(dateTimeFormat, datetime.Year, datetime.Month, datetime.Day, datetime.Hour, datetime.Minute, datetime.Second, datetime.Millisecond);
        }

        public static bool CheckTableExist(string name)
        {
            string tb;
            using (SQLiteConnection cn = new SQLiteConnection(connectString))
            {
                //ExecuteScalar : 回傳第一欄位的第一筆資料 , sqlite_master 中，第一筆資料為類型，因此為table字串 , 沒有的話回傳null , 而不是空字串
                tb = cn.ExecuteScalar<string>("SELECT * FROM sqlite_master WHERE type = 'table' AND tbl_name = @Name", new { name });
            }
            return tb != null;
        }

        //#region ClientData Region
        //public static void CreateClientData()
        //{
        //    using (SQLiteConnection cn = new SQLiteConnection(connectString))
        //    {
        //        /* 正式.NET 寫法
        //        cn.Open();
        //        string sql = "create table highscores (name varchar(20), score int)";
        //        SQLiteCommand command = new SQLiteCommand(sql, cn);
        //        command.ExecuteNonQuery();
        //        cn.Clone();
        //        */

        //        //Dapper 寫法
        //        cn.Execute(ClientData.GenerateCommand_Create());
        //    }
        //}

        //public static List<ClientData> GetClientDataList()
        //{
        //    using (SQLiteConnection cn = new SQLiteConnection(connectString))
        //    {
        //        var clientList = cn.Query<ClientData>("SELECT * FROM ClientData").ToList();
        //        return clientList;
        //    }
        //}

        //public static List<ClientData> SelectClientDataSimpleName(string goalString)
        //{
        //    goalString = "%" + goalString + "%";

        //    //QueryFirstOrDefault
        //    using (SQLiteConnection cn = new SQLiteConnection(connectString))
        //    {
        //        string strSql = "SELECT * FROM ClientData WHERE SimpleName LIKE @SimpleName";
        //        var clientList = cn.Query<ClientData>(strSql, new { SimpleName = goalString }).ToList();
        //        return clientList;
        //    }
        //}

        //public static void InsertClientData(ClientData clientData)
        //{
        //    clientData.SaveDate = DateTime.Now;
        //    using (SQLiteConnection cn = new SQLiteConnection(connectString))
        //    {
        //        string sqlCommand = ClientData.GenerateCommand_Insert();
        //        var excuteResult = cn.Execute(sqlCommand, clientData);
        //    }
        //}

        //public static void UpdateClientData(ClientData data)
        //{
        //    using (SQLiteConnection cn = new SQLiteConnection(connectString))
        //    {
        //        string strSql = ClientData.GenerateCommand_Update();
        //        cn.Execute(strSql, data);
        //    }
        //}

        //public static void DeleteClientData(int cid)
        //{
        //    using (SQLiteConnection cn = new SQLiteConnection(connectString))
        //    {
        //        string strSql = " DELETE FROM ClientData WHERE Id=@Id";
        //        cn.Execute(strSql, new { Id = cid });
        //    }
        //}
        //#endregion

        public static void CreateData(DataType type)
        {
            using (SQLiteConnection cn = new SQLiteConnection(connectString))
            {
                switch (type)
                {
                    case DataType.Client:
                        cn.Execute(ClientData.GenerateCommand_Create());
                        break;
                    case DataType.Product:
                        cn.Execute(ProductData.GenerateCommand_Create());
                        break;
                    default:
                        MessageBox.Show("創建資料錯誤","Error");
                        break;
                }
            }
        }
        public static IList GetDataList(DataType type)
        {
            using (SQLiteConnection cn = new SQLiteConnection(connectString))
            {
                object data;
                switch (type)
                {
                    case DataType.Client:
                        data = cn.Query<ClientData>("SELECT * FROM ClientData").ToList();
                        break;
                    case DataType.Product:
                        data = cn.Query<ProductData>("SELECT * FROM ProductData").ToList();
                        break;
                    default:
                        MessageBox.Show("獲取資料錯誤", "Error");
                        data = null;
                        break;
                }
                return data as IList;
            }
        }

        public static IList SelectData(DataType type, string goalString)
        {
            goalString = "%" + goalString + "%";

            //QueryFirstOrDefault
            object data;
            string sqlCommand;
            using (SQLiteConnection cn = new SQLiteConnection(connectString))
            {
                switch (type)
                {
                    case DataType.Client:
                        sqlCommand = "SELECT * FROM ClientData WHERE SimpleName LIKE @SimpleName";
                        data = cn.Query<ClientData>(sqlCommand, new { SimpleName = goalString }).ToList();
                        break;
                    case DataType.Product:
                        sqlCommand = "SELECT * FROM ProductData WHERE NCOrder LIKE @NCOrder";
                        data = cn.Query<ProductData>(sqlCommand, new { NCOrder = goalString }).ToList();
                        break;
                    default:
                        MessageBox.Show("獲取資料錯誤", "Error");
                        data = null;
                        break;
                }
                return data as IList;
            }
        }

        public static void InsertData(DataType type, AnnBaseData srcData)
        {
            string sqlCommand;
            using (SQLiteConnection cn = new SQLiteConnection(connectString))
            {
                switch(type)
                {
                    case DataType.Client:
                        (srcData as ClientData).SaveDate = DateTime.Now;
                        sqlCommand = ClientData.GenerateCommand_Insert();
                        cn.Execute(sqlCommand, srcData);
                        break;
                    case DataType.Product:
                        (srcData as ProductData).SaveDate = DateTime.Now;
                        sqlCommand = ProductData.GenerateCommand_Insert();
                        cn.Execute(sqlCommand, srcData);
                        break;
                    default:
                        MessageBox.Show("插入資料錯誤", "Error");
                        break;
                }
            }
        }

        public static void UpdateData(DataType type, AnnBaseData data)
        {
            string sqlCommand;
            using (SQLiteConnection cn = new SQLiteConnection(connectString))
            {
                switch (type)
                {
                    case DataType.Client:
                        (data as ClientData).SaveDate = DateTime.Now;
                        sqlCommand = ClientData.GenerateCommand_Update();
                        cn.Execute(sqlCommand, data);
                        break;
                    case DataType.Product:
                        (data as ProductData).SaveDate = DateTime.Now;
                        sqlCommand = ProductData.GenerateCommand_Update();
                        cn.Execute(sqlCommand, data);
                        break;
                    default:
                        MessageBox.Show("更新資料錯誤", "Error");
                        break;
                }
            }
        }

        public static void DeleteData(DataType type, int cid)
        {
            string sqlCommand;
            using (SQLiteConnection cn = new SQLiteConnection(connectString))
            {
                switch (type)
                {
                    case DataType.Client:
                        sqlCommand = " DELETE FROM ClientData WHERE Id=@Id";
                        cn.Execute(sqlCommand, new { Id = cid });
                        break;
                    case DataType.Product:
                        sqlCommand = " DELETE FROM ProductData WHERE Id=@Id";
                        cn.Execute(sqlCommand, new { Id = cid });
                        break;
                    default:
                        MessageBox.Show("刪除資料錯誤", "Error");
                        break;
                }
            }
        }
    }
}
