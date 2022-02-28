using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AverageConsumption averageConsumption = new AverageConsumption();
            Console.WriteLine("Calculate the average consumption: ");

            Console.WriteLine("Inform the distance in KM: ");
            averageConsumption.Distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Inform the spent fuel in L: ");
            averageConsumption.SpentFuel = Convert.ToDouble(Console.ReadLine());

            averageConsumption.Displays();
            Console.ReadKey();
        }
    }
}
