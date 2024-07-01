using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _1_7_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "camry", 2022, 20000, "red", "20-2145");
            Car.engine();

            Console.WriteLine();

            Console.WriteLine(car.CarInformation());

            Console.WriteLine();

            Car.engine("OFF");

            Console.WriteLine("-------------------------------------------------------------------");
            Car.BMW bmw = new Car.BMW("X6", 2022, 80000, "Blue", "20-2325");
            Car.engine();

            Console.WriteLine();

            Console.WriteLine(bmw.CarInformation());

            Console.WriteLine();

            Car.engine("OFF");

        }
    }
}