using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace PFILE2EPFILE
{
    class Program
    {
        static void Main(string[] args)
        {
            //古いカスタマー番号
            int oldCNo=-1;

            //カスタマーには複数レコードが登録される。
            Customer customer = null;

            //EPFileには複数のカスタマーが登録される。
            EPFIle epfile = new EPFIle();


            StreamReader sr = new StreamReader("PFILE.txt");
            String rec;
            rec = sr.ReadLine();
            do{

                Record r = new Record(rec);


                if (r.CustomerNo != oldCNo)
                {
                    oldCNo = r.CustomerNo;

                    //カスタマーを新しく設定
                    customer = new Customer();

                    //カスタマーを登録
                    epfile.setCustomer(customer);
                }
                customer.SetRecord(r);
            }while((rec = sr.ReadLine() ) != null);
            sr.Close();

            epfile.FileOut();
        }
    }
}
