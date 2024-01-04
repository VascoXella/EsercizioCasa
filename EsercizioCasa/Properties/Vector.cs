using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioCasa.Properties
{
    internal class Vector
    {
        public float x { get; set; }
        public float y { get; set; }

        public Vector()
        {
        }

        public Vector(float X, float Y)
        {
            x = X;
            y = Y;            
        }



        public void Sommav(Vector v2, out float xr, out float yr)
        {
            xr = this.x + v2.x;
            yr = this.y + v2.y;
            return;
        }

    }
}
