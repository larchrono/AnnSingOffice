using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnSingOffice.Class
{
    class ClientData
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

        // @Name , @SimpleName , @Address , @PhoneNumber , @Fax , @TaxId , @Email @Date

        public ClientData(int id,string name, string simpleName, string addr, string phoneNumber, string fax, string taxId, string email, string memo)
        {
            this.Id = id;
            this.Name = name;
            this.SimpleName = simpleName;
            this.Address = addr;
            this.PhoneNumber = phoneNumber;
            this.Fax = fax;
            this.TaxId = taxId;
            this.Email = email;
            this.Memo = memo;
        }
    }
}
