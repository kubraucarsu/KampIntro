﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string kurs1 = "Yazılım Geliştirici Kampı";
             string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
             string kurs3 = "Java"; */

            // array =dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı" , "Programlamaya Başlangıç İçin Temel Kurs" , "Java","Python","C#" };
            //Lengt=eleman sayısı kursların sayısı kadar
            for (int i = 0; i <kurslar.Length; i++ ) //değeri artır 
            {
                Console.WriteLine(kurslar[i]);
            }
            //Dizileri tek tek dolaşmaya yarıyor.
            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu- Footer");
        }
    }
}
