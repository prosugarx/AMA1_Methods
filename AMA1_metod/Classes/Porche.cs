using AMA1_metod.Abstract;
using AMA1_metod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.Classes
{
    public class Porche : Cars, IOzellik3
    {
        public override double ArabaYakıt()
        {
            return 60.0;
        }

        public void hızlıyım()
        {
           
        }

        public void uçabilerem()
        {
            Console.WriteLine(" hava da uçar. ");
        }

        public void yüzebilirim()
        {
            
        }
    }
}
