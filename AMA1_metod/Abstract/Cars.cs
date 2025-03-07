using AMA1_metod.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.Abstract
{
    public abstract class Cars: Araba
    {
        public abstract double ArabaYakıt();

        public void ArabaYak(string name)
        {
            Console.WriteLine(name + " yakıt tüketiyorr...");
        }
       
    }
}
