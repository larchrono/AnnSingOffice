using System;

namespace AnnSingOffice.Class
{
    public class ClientData : AnnBaseData
    {
        // Top Part
        public int Id { get; set; }

        // Left Part
        public string Name { get; set; }
        public string SimpleName { get; set; }
        public string Address { get; set; }
        public string HomeNumber { set; get; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string TaxId { get; set; }

        //Right Part
        public string EnglishName { set; get; }
        public string Manager { set; get; }
        public string ContactMan { set; get; }
        public string Website { set; get; }
        public string Email { get; set; }
        public string ComType { set; get; }
        public string TaxType { set; get; }

        // Button Part
        public string Memo { get; set; }

        public DateTime SaveDate { get; set; }

        public ClientData()
        {
            Name = "None";
        }

        public static string GenerateCommand_Create()
        {
            return @"CREATE TABLE ClientData (
                        Id INTEGER PRIMARY KEY NOT NULL,
                        Name VARCHAR(32) NOT NULL,
                        SimpleName VARCHAR(32),
                        Address VARCHAR(64),
                        HomeNumber VARCHAR(16),
                        PhoneNumber VARCHAR(16),
                        Fax VARCHAR(16),
                        TaxId VARCHAR(16),

                        EnglishName VARCHAR(32),
                        Manager VARCHAR(32),
                        ContactMan VARCHAR(32),
                        Website VARCHAR(64),
                        Email VARCHAR(32),
                        ComType VARCHAR(32),
                        TaxType VARCHAR(32),
                        Memo VARCHAR(128),

                        SaveDate DATETIME
                    )";
        }

        public static string GenerateCommand_Insert()
        {
            //update ***** where 識別碼 = (select max(識別碼) from A where ...)
            //1) 可執行SQL資料更新指令，支援參數
            //2) 以陣列方式提供多組參數，可重複執行同一SQL指令
            // cn.Execute(@"INSERT INTO ClientData VALUES (NULL , @Name , @SimpleName , @Address , @PhoneNumber , @Fax , @TaxId , @Email , @Date , @Memo)",
            //     new { Name = name, SimpleName = simpleName, Address = addr, PhoneNumber = number, Fax = fax, TaxId = taxId, Email = email, Date = DateTime.Now, Memo = memo });

            return @"INSERT INTO ClientData VALUES (NULL , @Name, @SimpleName, @Address, @HomeNumber, @PhoneNumber, @Fax, @TaxId, @EnglishName, @Manager, @ContactMan, @Website, @Email, @ComType, @TaxType, @Memo, @SaveDate)";
        }

        public static string GenerateCommand_Update()
        {
            return @"UPDATE ClientData SET
                        Name = @Name,
                        SimpleName = @SimpleName,
                        Address = @Address,
                        HomeNumber = @HomeNumber,
                        PhoneNumber = @PhoneNumber,
                        Fax = @Fax,
                        TaxId = @TaxId,

                        EnglishName = @EnglishName,
                        Manager = @Manager,
                        ContactMan = @ContactMan,
                        Website = @Website,
                        Email = @Email,
                        ComType = @ComType,
                        TaxType = @TaxType,
                        Memo = @Memo,

                        SaveDate = @SaveDate

                        WHERE Id = @Id";
        }
    }
}
