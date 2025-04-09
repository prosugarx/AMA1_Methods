using AMA1_metod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.Classes
{
    public class Calısans
    {
       
        public class Calisans
        {
            public string AdiSoyadi { get; set; }
            public int Maas { get; set; }
            public string Meslegi { get; set; }
            public string Departmani { get; set; }

            public Calisans(string adiSoyadi, int maas, string meslegi, string departmani)
            {
                AdiSoyadi = adiSoyadi;
                Maas = maas;
                Meslegi = meslegi;
                Departmani = departmani;
            }

            public void Göster()
            {
                Console.WriteLine("adı soyadı: " + AdiSoyadi + " Mesleği: " + Meslegi + " departmanı: " + Departmani + " maası: "+ Maas);
            }
        }

    }
}