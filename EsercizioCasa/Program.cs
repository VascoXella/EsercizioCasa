using EsercizioCasa.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float xr = 0;
            float yr = 0;

            Vector v1 = new Vector(2, 2);

            Vector v2 = new Vector(3, 3);

            // Vector v3 = new Vector();
            // v3 = Vector.Parse("4; 4");

            v1.Sommav(v2, out xr, out yr);

            Console.WriteLine("{0}, {1}", xr, yr);





            Console.ReadLine();
        }
    }
}
