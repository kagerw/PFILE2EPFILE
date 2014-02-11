using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PFILE2EPFILE
{
    class Customer
    {
        List<Record> recordList = new List<Record>();

        public int PaySum { get; private set; }

        public void SetRecord(Record r)
        {
            recordList.Add(r);
        }
        public String GetString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Record r in recordList)
            {
                sb.Append(r.GetString());
                PaySum += r.Payment;
            }

            //最後に顧客別合計金額を付け足します。
            sb.Append(String.Format("\t{0:000} total \t\\{1}\r\n", recordList[0].CustomerNo, PaySum));
            return sb.ToString();
        }
    }
}
