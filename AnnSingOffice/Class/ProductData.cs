using System;

namespace AnnSingOffice.Class
{
    public class ProductData : AnnBaseData
    {
        // Top Part
        public int Id { get; set; }

        //Left Part
        public string Spec { set; get; }
        public string InDiameter { set; get; }
        public string OutDiameter { set; get; }
        public string TotalLengh { set; get; }

        //Right Part
        public string NCOrder { set; get; }
        public string Machine { set; get; }
        public string NCNumber { set; get; }
        public string Price { set; get; }

        //Button Part
        public string Picture_1 { set; get; }
        public string Picture_2 { set; get; }
        public string Picture_3 { set; get; }

        public string Memo { set; get; }

        public DateTime SaveDate { get; set; }

        public ProductData()
        {
            Spec = "None";
        }

        public static string GenerateCommand_Create()
        {
            return @"CREATE TABLE ProductData (
                        Id INTEGER PRIMARY KEY NOT NULL,
                        Spec VARCHAR(32) NOT NULL,
                        InDiameter VARCHAR(32),
                        OutDiameter VARCHAR(32),
                        TotalLengh VARCHAR(32),

                        NCOrder VARCHAR(32),
                        Machine VARCHAR(32),
                        NCNumber VARCHAR(32),
                        Price VARCHAR(64),

                        Picture_1 VARCHAR(64),
                        Picture_2 VARCHAR(64),
                        Picture_3 VARCHAR(64),

                        Memo VARCHAR(64),

                        SaveDate DATETIME
                    )";
        }

        public static string GenerateCommand_Insert()
        {
            return @"INSERT INTO ProductData VALUES (NULL , @Spec, @InDiameter, @OutDiameter, @TotalLengh, @NCOrder, @Machine, @NCNumber, @Price, @Picture_1, @Picture_2, @Picture_3, @Memo, @SaveDate)";
        }

        public static string GenerateCommand_Update()
        {
            return @"UPDATE ProductData SET
                        Spec = @Spec,
                        InDiameter = @InDiameter,
                        OutDiameter = @OutDiameter,
                        TotalLengh = @TotalLengh,

                        NCOrder = @NCOrder,
                        Machine = @Machine,
                        NCNumber = @NCNumber,
                        Price = @Price,

                        Picture_1 = @Picture_1,
                        Picture_2 = @Picture_2,
                        Picture_3 = @Picture_3,

                        Memo = @Memo,

                        SaveDate = @SaveDate

                        WHERE Id = @Id";
        }
    }
}
