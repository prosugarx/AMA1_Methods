using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.Classes
{
    public class Araba
    {
        public string CarName = "Porche 911";
        public string model = "911";
        public string Color = "Purple";
        public int DoorAccount = 2;
        public bool backBagaj = false;

        public void git(string carname, string model)
        {
            Console.WriteLine("\narabanın markası: " + carname + " arabanın modeli: " + model);
        }
        public void vites(string carname, string vitesTürü)
        {
            Console.WriteLine(carname + vitesTürü + "dir");
        }

        public string arabaYaşı(int ArabaYaşı)
        {
            string durum;
            if (ArabaYaşı >= 0 && ArabaYaşı < 10)
            {
                durum = "Arabanız yeni";
                Console.WriteLine(durum);
            }
            else if (ArabaYaşı >= 10 && ArabaYaşı < 20)
            {
                durum = "Servise götürmeniz gerekebilir";
                Console.WriteLine(durum);
            }
            else if (ArabaYaşı >= 20 && ArabaYaşı < 30)
            {
                durum = "Arabanız hurdaya çıkabilir";
                Console.WriteLine(durum);
            }
            else
            {
                durum = "Ya hiç üretilmedi ya da trafikden men edilmiştir";
                Console.WriteLine( durum);
            }
            return durum;

        }
    }
}
