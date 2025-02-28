using AMA1_metod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.Classes
{
    //Anne classı Insan classından türemiştir
    // ınsan clasındaki public olan tüm değişkenler ve metotlara erişilebilir
    public class Anne: Insan,IOzellik, IOzellik2
    {
        

        public void oku(string name)
        {
            Console.WriteLine(name + "okusun...");
        }

        public void dinle(string isim)
        {
            Console.WriteLine(isim + " dinliyor...");
        }

        public void yaz(string isim)
        {
            Console.WriteLine(isim + " yazıyor...");
        }
    }
}
