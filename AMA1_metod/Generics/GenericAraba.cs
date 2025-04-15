using AMA1_metod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.GenericClass
{
    public class GenericAraba : Cars
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double FuelConsumption { get; set; } // 100 km'deki yakıt tüketimi
        public double TotalDistance { get; set; }    // Toplam gidilen mesafe (km)

        public override double ArabaYakıt()
        {
            return (TotalDistance / 100) * FuelConsumption;
        }



        // Toplam yakıt tüketimini hesaplayan metot
      

    }
}
