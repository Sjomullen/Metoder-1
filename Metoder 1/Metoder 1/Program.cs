using System;

namespace Metoder_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double radie = 2.4;
            Console.WriteLine("Cirkelns omkrets: " + CirkelOmkrets(radie));
            Console.WriteLine("Cirkelns area: " + CirkelArea(radie));
        }
          
        static double CirkelOmkrets(double r)
        {
            return (r * 2 * Math.PI);
        }

        static double CirkelArea(double r)
        {
            return (r*r*Math.PI);
        }
    }
}
