using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Collections namespace

            ArrayList liste = new ArrayList();
            //liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');

            //// verilere erişim
            //Console.WriteLine(liste[1]);

            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}

            //AddRange, ile koleksiyon tipindeki verileri ekleyebiliriz.
            Console.WriteLine("**** AddRange ****");
            
            //string[] renkler = { "kırmızı", "sarı", "yeşil" };
            //liste.AddRange(renkler);
            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // Sort
            Console.WriteLine("**** Sort *****");
            liste.Sort(); // runtime da hata verir. Farklı veri tipindeki verileri sıralarken hata döndürür.

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // Binary Search, önce sıralayıp sonra indekse erişmemiz gerekli
            Console.WriteLine("**** Binary Search ****");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("**** Reverse ****");
            liste.Reverse();
            
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Clear, listeyi temizler
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


        }
    }
}
