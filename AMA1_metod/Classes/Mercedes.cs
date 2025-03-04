using AMA1_metod.Abstract;
using AMA1_metod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.Classes
{
    public class Mercedes : Cars, IOzellik3 
    {
        public override double ArabaYakıt()
        {
            return 70.0;
        }

        public void hızlıyım()
        {
            
        }

        public void uçabilerem()
        {
            Console.Write("havada uçar, ");
        }

        public void yüzebilirim()
        {
            Console.WriteLine("denizde yüzer ");
        }
    }
}
