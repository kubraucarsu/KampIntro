using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        { //Topla(5,6) içindeki parametreler değişken olanlardır.
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5,6);
            dortIslem.Topla(6,9);
        }
    }
}
