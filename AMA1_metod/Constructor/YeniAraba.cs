using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.Constructor
{
    public class YeniAraba
    {

        public Kasa kasa;
        

        public YeniAraba(Kasa kasa)
        { 
            this.kasa = kasa;
        }

        public void yazdır()
        {
            Console.WriteLine("Arabanın markası: " + kasa.marka.marka+
                 " kapı sayısı: " + kasa.kapı.KapıSayısı +
                 " pencere sayısı: " + kasa.pencere.PencereSyısı+
                 " kasası: " + kasa.kasa+
                 " fiyatı: "  + kasa.fiyat.fiyat + " TL dir.");
        }
    }
}
