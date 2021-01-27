using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; // 2 numara veri kaynağında masa sandalye gibi birşey kodda 0 1 2 gibi değişken tanımladık
            product1.ProductName ="Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock=3;
            Product product2 = new Product{ Id=2,CategoryId=5,UnitsInStock=5, ProductName="Kalem",UnitPrice=35};

            //PascalCase  //camelCase yazımları // başharf büyük küçüğe göre ayrılıyor.
            //case sensitive= küçük büyük harf duyarlılığı
            ProductManager productManager = new ProductManager();//örnek oluşturma class oluşturma 
            productManager.Add(product1);
        }
    }
}
