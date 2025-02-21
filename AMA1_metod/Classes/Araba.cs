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
        public bool backBagaj=false;

        public void git(string carname, string model)
        {
            Console.WriteLine("arabanın markası: "+carname +" arabanın modeli: " +model );
        }
        public void vites(string carname, string vitesTürü)
        {
            Console.WriteLine(carname + vitesTürü + "dir");
        }
    }
}
