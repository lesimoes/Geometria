using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Triangulo
    {

        public double perimetroTriangulo(double ax, double bx, double cx)
        {

            double px = (ax + bx + cx) / 2;
            return px;
        }

        public double areaTriangulo(double ax, double bx, double cx, double px)
        {

            double atx = Math.Sqrt(px * (px - ax) * (px - bx) * (px - cx));
            return atx;

        }

        


    }
}
