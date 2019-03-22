using System;

namespace AnnSingOffice.Class
{
    class ShipData
    {
        public int Id { set; get; }

        public string ShipNo { set; get; }
        public string ShipDate { set; get; }
        public string ShipContact { set; get; }

        public string ShipClient { set; get; }
        public string ShipAddress { set; get; }
        public string Phone { set; get; }

        public string ClientNo { set; get; }
        public string ClientTaxId { set; get; }

        public DateTime SaveDate { get; set; }

        public ShipData()
        {
            ShipNo = "None";
        }

        public static string GenerateCommand_Create()
        {
            return @"CREATE TABLE ShipData (
                        Id INTEGER PRIMARY KEY NOT NULL,
                        ShipNo VARCHAR(32) NOT NULL,
                        ShipDate VARCHAR(32),
                        ShipContact VARCHAR(64),

                        ShipClient VARCHAR(32),
                        ShipAddress VARCHAR(32),
                        Phone VARCHAR(16),

                        ClientNo VARCHAR(32),
                        ClientTaxId VARCHAR(32),

                        SaveDate DATETIME
                    )";
        }

        public static string GenerateCommand_Insert()
        {
            return @"INSERT INTO ShipData VALUES (NULL , @ShipNo, @ShipDate, @ShipContact, @ShipClient, @ShipAddress, @Phone, @ClientNo, @ClientTaxId, @SaveDate)";
        }

        public static string GenerateCommand_Update()
        {
            return @"UPDATE ShipData SET
                        ShipNo = @ShipNo,
                        ShipDate = @ShipDate,
                        ShipContact = @ShipContact,

                        ShipClient = @ShipClient,
                        ShipAddress = @ShipAddress,
                        Phone = @Phone,

                        ClientNo = @ClientNo,
                        ClientTaxId = @ClientTaxId,

                        SaveDate = @SaveDate

                        WHERE Id = @Id";
        }
    }
}
