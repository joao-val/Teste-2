using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_02
{
    public class AverageConsumption
    {

        public AverageConsumption()
        {
            this.Distance = 0;
            this.SpentFuel = 0;
        }

        private double A, B;

        public double Distance
        {
            get { return A; }
            set
            {
                if (value >= 0) A = value;
                else A = 0;
            }
        }
        public double SpentFuel
        {
            get { return B; }
            set
            {
                if (value >= 0) B = value;
                else B = 0;
            }
        }

        public Double Average
        {
            get { return A/B ; }
        }

        public void Displays()
        {
            Console.WriteLine("");
            Console.WriteLine("Distance in KM: " + this.Distance);
            Console.WriteLine("Spent fuel in L: " + this.SpentFuel);
            Console.WriteLine("The average consumption is: " + this.Average.ToString("F2"));
        }

    }
}
