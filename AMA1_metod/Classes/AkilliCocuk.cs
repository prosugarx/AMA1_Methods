using AMA1_metod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.Classes
{
    public class AkilliCocuk : Çocuk, IAsker , IKulüp , IEhliyet
    {
        public void asker(string isism)
        {
            Console.WriteLine(isism + " askere gidiyor...");
        }

        public void ehliyet(string isism)
        {
            Console.WriteLine(isism + " ehliyeti var...");
        }

        public void kulüp(string isism)
        {
            Console.WriteLine(isism + " kulübe gidiyor...");
        }
    }
}
