using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.GenericClass
{
    public class Person
    {
        public string Name;
        //override iptal etmek 
        public override string ToString()
        {
            return "Person [name = " + Name + "]";
            //return $"ad: {Name}";
        }
        public void save (Person p)
        {
            Console.WriteLine(p.ToString() + " data base e kaydedildi");
        }
    }
}
