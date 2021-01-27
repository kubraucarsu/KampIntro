using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{ // hangi tipte çalışıcağımızı belirliyor.
    class MyList<T>
    {
        T[] items;
        //Constructor=Clas newlenirse daha başlangıçta çalışıyor. Sınıf yenilendiğinde çalışan bloktur.
        public MyList() 
        { 
            items=new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;// geçici dizinin referansı items'ın referansı
            items = new T[items.Length+1];// Length dizinin eleman sayısını verir. 
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
               
            }
            items[items.Length - 1] = item;


        }
    }
}
