using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tarih1 = new DateTime(1900, 01, 01);
            DateTime tarih2 = new DateTime(2000, 12, 31);
            //DateTime dt_Ay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // Ay ilk günü

            //Console.WriteLine(dt_Ay);

            Console.WriteLine(tarih1 + " -- " + tarih2);

            for (DateTime x = tarih1; x <= tarih2; x = x.AddMonths(1))
            {
                //Console.WriteLine(x.Month);
                string gun = x.DayOfWeek.ToString();
                if (gun == "Sunday")
                {
                    DateTime tarih = new DateTime(x.Year, x.Month, x.Day);
                    Console.WriteLine(tarih + "," + "Pazar");
                }

            }
        }
    }
}
