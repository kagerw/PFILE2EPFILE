using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PFILE2EPFILE
{
    class EPFIle
    {
        List<Customer> customer = new List<Customer>();

        public void setCustomer(Customer c)
        {
            customer.Add(c);
        }
        public void FileOut()
        {
            int fullTotal = 0;

            StringBuilder result = new StringBuilder();

            foreach (Customer c in customer)
            {

                result.Append(c.GetString());
                fullTotal += c.PaySum;

            }
            result.Append("\t\tfull total \t\\" + fullTotal.ToString());

            StreamWriter sw = new StreamWriter("EPFILE.txt");

            sw.Write(result.ToString());

            sw.Close();
        }
    }
}
