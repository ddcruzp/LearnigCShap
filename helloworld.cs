using System; 
using System.Diagnostics;

namespace Prueba
{
    class Program
    {   
        static void Main (string [] args) 
        {
            StopWatch.crono = new StopWatch();
            Console.WriteLine("Hello, write your name pleace:");
            crono.Start();
            string nombre = Console.ReadLine();
            crono.stop();
            Console.WriteLine("Hello" + nombre + "wellcome");
            Console.WriteLine("te has demorado en teclear tu nombre" + crono.Elapsedmilliseconds + "ms.");
        }
    }
}
