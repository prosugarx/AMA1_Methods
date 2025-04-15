using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.GenericClass
{
    public class Product 
    {
        public string Name;

        public override string ToString()
        {
            return "Person [name = " + Name + "]";
        }

        //public void save(Product p)
        //{
        //    Console.WriteLine(p.ToString() + " data base e başarıyla kaydedildi");
        //}
    }
}
