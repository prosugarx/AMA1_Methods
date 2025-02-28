using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.Abstract
{
    public abstract class Çalışan
    {

        //1. abstract class ların nesnesi oluşturulamaz
        //2. kendisinden türeyen classları eğer abstract class içinde normal metodların dışında
        //abstract keyword ile tanımlanmış bir metod varsa o metodu yazmak zorundadırlar.
        

            public abstract double maasinizNedir();

            public void mesaiyeBasla(string isim)
            {
                Console.WriteLine(isim + " mesaiye başladı");
            }
        
    }
}
