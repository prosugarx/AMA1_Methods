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
    public class Anne: Insan,IOzellik
    {
        

        public void oku(string name)
        {
            Console.WriteLine(name + "okusun...");
        }
    }
}
