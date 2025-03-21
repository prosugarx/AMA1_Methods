using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.Classes
{
    public class Matematik
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }

        public int Topla(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Carp(double x, double y)
        {
            return x * y;
        }

        public double Carp(double x, double y, double z)
        {
            return x * y * z;
        }
    }
}
