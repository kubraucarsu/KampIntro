using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{   //snippet
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }// foreingkey =referans anahtarları 2. sıraya yazılır.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
