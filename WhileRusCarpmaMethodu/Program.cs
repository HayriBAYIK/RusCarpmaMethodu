using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileRusCarpmaMethodu
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1;
            int sayi2;
            int sonuc = 0;
            int x, y;
            Console.WriteLine("1. sayıyı giriniz.");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz.");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            x = sayi1;
            y = sayi2;
            

            while (sayi1>=1)
            {
                if (sayi1%2==0)/* sayi1 çift ise yapılan işlemler*/
                {
                    Console.WriteLine("sayi1= " + sayi1 + " sayi2= " + sayi2 + "  sonuc=sonuc değerine atama yok.");
                    sayi2 = sayi2 * 2;
                    sayi1 = sayi1 / 2;

                    

                }
                if (sayi1%2!=0)/* sayi1 tek ise yapılacak işlemler*/
                {
                    sonuc = sonuc + sayi2;
                    Console.WriteLine("sayi1= " + sayi1 + " sayi2= " + sayi2 + "  sonuc=" + sonuc);
                    sayi2 = sayi2 * 2;
                    sayi1 = sayi1 / 2;

                }

            }


            Console.WriteLine(x+"x"+y+"="+sonuc);
            Console.ReadLine();



        }
    }
}
