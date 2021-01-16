using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        //Ekle metodu çağırıldığında diğer bloklarda çağırılır.
        //ne eklemek istediğimiz veriye parametre diyoruz. Parametre = (Urun urun) Urun=parametre tipi
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : " + urun.Adi);
        }
        public void Ekle2(string  urunAdi, string Aciklama, double Fiyat,int StokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi : " + urunAdi );
        }
    }
}
