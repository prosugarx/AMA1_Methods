using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.Composition
{
    public class Yeniİnsan
    {
        public Kafa kafa;
        public string isim;
        public string soyisim;



        //parametre alan construtcor
        public Yeniİnsan(Kafa kafa, string isim, string soyisim)
        {
            this.kafa = kafa;
            this.isim = isim;
            this.soyisim = soyisim;
        }

        public void randevuKaydet()
        {
            Console.WriteLine("Randevu alan kişinin adı : " + isim +
                              " soyadı : " + soyisim +
                              " göz rengi : " + kafa.goz.renk +
                              " burnu : " + kafa.burun.tip +
                              " kulağı : " + kafa.kulak.şekil);
        }
    }
}
