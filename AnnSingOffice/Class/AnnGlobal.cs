using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnSingOffice.Class
{
    class AnnGlobal
    {
        public const string preStr = "data source=";
        public static string cnStr = "";



        public static string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2} {3}:{4}:{5}.{6}";
            return string.Format(dateTimeFormat, datetime.Year, datetime.Month, datetime.Day, datetime.Hour, datetime.Minute, datetime.Second, datetime.Millisecond);
        }
    }
}
