using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.Constructor
{
    public class Kasa
    {
        public string kasa;
        public Fiyat fiyat;
        public Kapı kapı;
        public Pencere pencere;
        public Marka marka;
        

        public Kasa(string kasa, Fiyat fiyat, Kapı kapı, Pencere pencere, Marka marka)
        {
            this.kasa = kasa;
            this.fiyat = fiyat;
            this.kapı = kapı;
            this.pencere = pencere;
            this.marka = marka;
        }
    }
}
