using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //tests out vehicle class
            Vehicle baseVehicle = new Vehicle(4, 2000, "green", 55.0d);
            baseVehicle.Move();

            Console.WriteLine(baseVehicle.DistanceTraveled);
        }
    }
}
