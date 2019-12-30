using System;

namespace AnnSingOffice.Class
{
    class ShipItemListData
    {
        public int Id { set; get; }

        public string ByShipNo { set; get; }
        public string ProductNo { set; get; }

        public string ProductNumber { set; get; }
        public string ProductUnit { set; get; }
        public string UnitPrice { set; get; }
        public string TotalPrice { set; get; }

        public string Memo { set; get; }

        public DateTime SaveDate { get; set; }

        public ShipItemListData()
        {
            ByShipNo = "None";
        }

        public static string GenerateCommand_Create()
        {
            return @"CREATE TABLE ShipItemListData (
                        Id INTEGER PRIMARY KEY NOT NULL,
                        ByShipNo VARCHAR(32) NOT NULL,
                        ProductNo VARCHAR(32),

                        ProductNumber VARCHAR(32),
                        ProductUnit VARCHAR(16),
                        UnitPrice VARCHAR(16),
                        TotalPrice VARCHAR(16),

                        Memo VARCHAR(32),

                        SaveDate DATETIME
                    )";
        }

        public static string GenerateCommand_Insert()
        {
            return @"INSERT INTO ShipItemListData VALUES (NULL , @ByShipNo, @ProductNo, @ProductNumber, @ProductUnit, @UnitPrice, @TotalPrice, @Memo, @SaveDate)";
        }

        public static string GenerateCommand_Update()
        {
            return @"UPDATE ShipItemListData SET
                        ByShipNo = @ByShipNo,
                        ProductNo = @ProductNo,

                        ProductNumber = @ProductNumber,
                        ProductUnit = @ProductUnit,
                        UnitPrice = @UnitPrice,
                        TotalPrice = @TotalPrice,

                        Memo = @Memo,

                        SaveDate = @SaveDate

                        WHERE Id = @Id";
        }
    }
}
