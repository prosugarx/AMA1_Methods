using AMA1_metod.Abstract;
using AMA1_metod.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.ŞirketÇalışanMaaşları
{
    public class Stajyer : Çalışan
    {
        public override double maasinizNedir()
        {
            return 5000.0;
        }
    }
}
