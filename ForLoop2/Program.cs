using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1' den 100' e kadar olan sayilarin içinde 3' un katlarini toplayip, yazdirin
            //int sum = 0;

            //for (int i = 0; i <= 100; i +=3)
            //{
            //    Console.WriteLine(i);
            //    sum = sum + i;
            //}
            //Console.WriteLine("3' un katlari olan sayilarin toplami : " + sum);

            // *** 1 - 150 arasindaki sayilardan 3' un katlari toplami ve 3' un katlari sayisi toplamini yazdir
            //int sum = 0;
            //int sayac = 0;

            //for (int i = 3; i <= 150; i += 3)
            //{
            //    sum = sum + i;
            //    //Console.WriteLine(sum);
            //    sayac++;
            //}
            //Console.WriteLine("3' un kati olan sayilarin toplami : " + sum);
            //Console.WriteLine("sayac : " + sayac);

            // \n --> sting yazilar icinde yaziyi bir alt satira gecirmek icin kullanilir

            // *** tek for icinde 1-500 arasi 3,4 ve 5'in katlari toplamini hesaplayarak, gosterin
            int sum3 = 0;
            int sum4 = 0;
            int sum5 = 0;

            for (int i = 0; i <= 500; i++)
            {
                if (i % 3 == 0)
                {
                    sum3 = sum3 + i;
                }
                if (i % 4 == 0)
                {
                    sum4 = sum4 + i;
                }
                if (i % 5 == 0)
                {
                    sum5 = sum5 + i;
                }
            }

            Console.WriteLine("3'un katlari olan sayilarin toplami : " + sum3);
            Console.WriteLine("4'un katlari olan sayilarin toplami : " + sum4);
            Console.WriteLine("5'in katlari olan sayilarin toplami : " + sum5);

            Console.Read();
        }
    }
}
