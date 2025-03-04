using AMA1_metod.Abstract;
using AMA1_metod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.Classes
{
    public class Bmw : Cars, IOzellik3
    {
        public override double ArabaYakıt()
        {
            return 80.0;
        }

        public void hızlıyım()
        {
            Console.Write(" çok hızlı gider, ");
        }

        public void uçabilerem()
        {
            Console.Write("hava da uçar, ");
        }

        public void yüzebilirim()
        {
            Console.WriteLine("denizde yüzer ");
        }
    }
}
