using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{   //Public erişime açık herkes erişebilir.
    //Property- Özellik
    public class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
    }
}
