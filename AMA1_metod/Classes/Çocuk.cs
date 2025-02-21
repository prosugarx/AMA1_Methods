using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.Classes
{
    public class Çocuk: Insan
    {
        public string durum;
        public void cocukYazdırma(string name, string surname,string durum)
        {
            Console.WriteLine(name + surname + durum + "dır.");
        }
    }
}
