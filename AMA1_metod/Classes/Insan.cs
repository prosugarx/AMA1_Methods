using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.Classes
{
    public class Insan
    {
        public string name = "medine";
        public string surname = "keleş";
        public int age=18;
        public bool gender=false;

        public void uyu()
        {
            Console.WriteLine("uyuyor...");
        }
        public void ekranaYaz(string name, string surname)
        {
            Console.WriteLine("kişinim adı: " + name + "soyadı : " + surname);
        }
    }
}
