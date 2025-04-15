using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMA1_metod.Generics
{
    public class GenericClassÖrnek<T>
    {
        public void save<T>(T obj)
        {
            Console.WriteLine(obj.ToString() + " database e kaydedildi");
        }

        public void Yazdır<T>(List<T> list)
        {
            foreach (T item in list)
            {

                Console.WriteLine(item);
            }
        }
    }
}
