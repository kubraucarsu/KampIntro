using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {   //veri türü
            string adi = "Kübra";
            int yas = 36;
            //değişken tanımlarkende class şeklinde kursu tanımlamam lazım
            Kurs kurs1= new Kurs(); //kurs1 değişkenim var tipi KURS
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Kübra";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs(); //kurs2 değişkenim var tipi KURS
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.İzlenmeOrani = 64;

            Kurs kurs3 = new Kurs(); //kurs3 değişkenim var tipi KURS
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay";
            kurs3.İzlenmeOrani = 80;

            Kurs kurs4 = new Kurs(); //kurs3 değişkenim var tipi KURS
            kurs4.KursAdi = "HTML";
            kurs4.Egitmen = "Engin";
            kurs4.İzlenmeOrani = 100;
            //Console.WriteLine(kurs1.KursAdi+""+kurs1.Egitmeni);

            //dizide tanımlayacağız. ARRAY
            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            //Kurs olan veri tipi kurs olan takma isim
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.Egitmen);
            }


        }
    }
    class Kurs
    { // prop tab tab yapınca aşağısı oluşuyor. Özelliklerini oluşturuyoruz.
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
