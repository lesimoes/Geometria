using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseRetangulo, alturaRetangulo, areaRetangulo;

            Console.WriteLine("Informe a base e altura de um retangulo:");
            baseRetangulo = double.Parse(Console.ReadLine());
            alturaRetangulo = double.Parse(Console.ReadLine());

            areaRetangulo = baseRetangulo * alturaRetangulo;

            Console.WriteLine("A area do retangulo informado é " + areaRetangulo);

            Console.ReadLine();
        }
    }
}
