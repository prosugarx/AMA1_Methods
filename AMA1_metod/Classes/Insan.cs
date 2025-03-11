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
        public int age = 18;
        public bool gender = false;


        public void uyu()
        {
            Console.WriteLine("uyuyor...");
        }
        public void ekranaYaz(string name, string surname)
        {
            Console.WriteLine("\nkişinim adı: " + name + "soyadı : " + surname);
        }
        public int yaşBulma(int yıl)
        {

            int yaş = DateTime.Now.Year - yıl;
            return yaş;
        }

        public string YaşDurum(int yaş)
        { 

        string durum;
            if (yaş > 0 && yaş <= 18)
            {
                durum = "Küçüksünüz";
                Console.WriteLine(durum);

            }
            else if (yaş > 18 && yaş <= 35)
            {
                durum = "gençsiniz";
                Console.WriteLine(durum);
            }
            else if (yaş > 35 && yaş <= 55)
            {
                durum = "Yetişkinsiniz";
                Console.WriteLine(durum);

            }
            else if (yaş > 55 && yaş <= 75)
            {
                durum = "Yaşlısınız";
                Console.WriteLine(durum);
            }
            else if (yaş > 75 && yaş <= 99)
            {
                durum = "Çok yaşlısınız";
                Console.WriteLine(durum);
            }
            else
            {
                durum = "ya hiç doğmadınız yada çoktan öldünüz";
                Console.WriteLine(durum);
            }
            return durum;
        }
        
    }
}
