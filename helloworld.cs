using System; 
using System.Diagnostics;

namespace Prueba
{
    class Program
    {   
        static void Main (string [] args) 
        {
            Stopwatch crono = new Stopwatch();
            Console.WriteLine("Hello, write your name pleace:");
            crono.Start();
            string nombre = Console.ReadLine();
            crono.Stop();
            Console.WriteLine("Hello" + nombre + "wellcome");
            Console.WriteLine("te has demorado en teclear tu nombre" + crono.ElapsedMilliseconds + "ms.");
        }
    }
}
