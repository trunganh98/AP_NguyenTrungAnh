using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_NguyenTrungAnh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> arrProduct = new List<Product>();
            Book bk1 = new Book(1, "Book1", 98.99, "QWER");
            Book bk2 = new Book(2, "Book2", 31.99, "QWER");
            Book bk3 = new Book(3, "Book3", 08.99, "QWER");
            MobilePhone mb1 = new MobilePhone(4, "SamSung 3", 888.88, "SamSung");
            MobilePhone mb2 = new MobilePhone(5, "Xiaomi 4", 1998.66, "Xiaomi");
            MobilePhone mb3 = new MobilePhone(6, "SamSung 5", 998.98, "SamSung");

            arrProduct.Add(bk1);
            arrProduct.Add(bk2);
            arrProduct.Add(bk3);
            arrProduct.Add(mb1);
            arrProduct.Add(mb2);
            arrProduct.Add(mb3);
            
            double totalBookTax = 0;

            double totalMobileTax = 0;
            double totalTax = 0;

            for (int i = 0; i < arrProduct.Count; i++)
            {
                if (arrProduct[i].Id <= 3)
                {
                    totalBookTax += arrProduct[i].ComputeTax();
                }
                else
                {
                    totalMobileTax += arrProduct[i].ComputeTax();
                }

            }
            Console.WriteLine("Total book tax: " + totalBookTax);
            Console.WriteLine("Total mobile tax: " + totalMobileTax);
            totalTax = totalBookTax + totalMobileTax;
            Console.WriteLine("Total Tax is: " + totalTax);
            Console.ReadKey();
        }
    }
}
