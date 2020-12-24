using System; 
using Math;

namespace Distancia
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEntre la coordenada x del primer punto : ");
            double x1 = double.Parse(Console.ReadLine())
            Console.WriteLine("\nEntre la coordenada y del primer punto : ");
            double y1 = double.Parse(Console.ReadLine())

            Console.WriteLine("\nEntre la coordenada x del segundo punto : ");
            double x2 = double.Parse(Console.ReadLine())
            Console.WriteLine("\nEntre la coordenada y del segundo punto : ");
            double y2 = double.Parse(Console.ReadLine())

            Console.WriteLine("La distancia entre los dospuntos es {0}",Math.sqrt(Math.Pow(x2 - x1 , 2) + Math.Pow(y2 - y1 , 2)));
        }
    }
}