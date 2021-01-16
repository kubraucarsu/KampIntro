using System;

namespace DegerVeReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1); //cevap=30

            int[] sayilar1 = new int[] {10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]); //cevap=999

            // int,decimal,float,double,bool = değer tipidir.
            //array,class,interface=referans tipidir.
            //stack ve heap bellekteki iki alandır. Değer tipler Stack te gerçekleşiyor. referans tipler ise heap te tanımlanır.sayi1=10 Sayı1 in değeri eşittir 10 diye okuruz.
            //heap adres yeni bir bellek oluştur demektir.
        }
    }
}
