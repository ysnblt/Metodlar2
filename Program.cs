using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan sayının karesini alıp , eğer 25 ten büyükse büyüktür ,
            // küçükse küçüktür yazdıran program

            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine()); 
            int kareDeger = kareAl(sayi);
            if(kareDeger < 25)
            {

                Console.WriteLine("Sayı 25'ten küçüktür.");

            }
            else
            {

                Console.WriteLine("Sayı 25'ten büyüktür");

            }
        }

        static int kareAl(int a)
        {

            return a * a;

        }
    }
}
