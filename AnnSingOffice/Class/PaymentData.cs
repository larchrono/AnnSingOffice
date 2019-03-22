using System;

namespace AnnSingOffice.Class
{
    class PaymentData
    {
        public int Id { set; get; }

        public string PNo { set; get; }
        public string PDate { set; get; }
        public string PMonth { set; get; }

        public string PClient { set; get; }
        public string PAddress { set; get; }
        public string Phone { set; get; }

        public string TaxId { set; get; }

        public DateTime SaveDate { get; set; }

        public PaymentData()
        {
            PNo = "None";
        }

        public static string GenerateCommand_Create()
        {
            return @"CREATE TABLE PaymentData (
                        Id INTEGER PRIMARY KEY NOT NULL,
                        PNo VARCHAR(32) NOT NULL,
                        PDate VARCHAR(32),
                        PMonth VARCHAR(32),

                        PClient VARCHAR(32),
                        PAddress VARCHAR(32),
                        Phone VARCHAR(16),

                        TaxId VARCHAR(32),

                        SaveDate DATETIME
                    )";
        }

        public static string GenerateCommand_Insert()
        {
            return @"INSERT INTO PaymentData VALUES (NULL , @PNo, @PDate, @PMonth, @PClient, @PAddress, @Phone, @TaxId, @SaveDate)";
        }

        public static string GenerateCommand_Update()
        {
            return @"UPDATE PaymentData SET
                        PNo = @PNo,
                        PDate = @PDate,
                        PMonth = @PMonth,

                        PClient = @PClient,
                        PAddress = @PAddress,
                        Phone = @Phone,

                        TaxId = @TaxId,

                        SaveDate = @SaveDate

                        WHERE Id = @Id";
        }
    }
}
