using System;

//Don't repeat yourself-DRY = Kendini tekrar etme! Clean Code = temiz kod Best Practice = Doğru Uygulama Teknikleri

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";



            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2 };//Urun Array(Dizisi) de oluşturulabilir.

            //in urunler: benim urunler dizimin her elemanını gez foreach ile tektek ekrana bas.
            //urun:takma isim o an ki senin urun sayın kadar doner.
            //Urun: Senin veri tipindir. type safe-tip güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("..............");
            }

            Console.WriteLine("------------METOTLAR------");

            //instance-Örnek
            //encapsulation:Oluşturulan bir sınıf (class) içerisinde kullanıcının işlemlerini daha kolay gerçekleştirebilmesi için bazı işlemler birleştirilerek tek bir işlem gibi gösterilir. Bu birleştirme işlemine kapsülleme denir.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 10);
            sepetManager.Ekle2("Armut", "Yeşil", 12, 10);

        }
    }
}
