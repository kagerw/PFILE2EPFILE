using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
namespace PFILE2EPFILE
{
    class Record
    {
        //private String rawString;

        public int CustomerNo { get; private set; }
        DateTime date;
        public int Payment { get; private set; }

        public Record(String record)
        {
            SetRecord(record);
        }

        //与えられた文字列を分解してメンバ変数を登録します。
        private void SetRecord(String record)
        {
            String[] s = new String[3];
            String[] date = new String[3];
            s = record.Split(',');
            this.CustomerNo = int.Parse(s[0]);

            date = s[1].Split('.');

            this.date = new DateTime(int.Parse(date[0]),int.Parse(date[1]),int.Parse(date[2]));

            this.Payment = int.Parse(s[2]);
        }
        public string GetString()
        {
            return date.ToString("MMMM.dd, yyyy", new CultureInfo("en-US")) + "\t\\" + Payment.ToString() + "\r\n";
        }

    }
}
