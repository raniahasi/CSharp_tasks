using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_6_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Write a function in C# that accept 10 numbers and return sum and average.
            Console.WriteLine("Enter 10 numbers to calculate their Total and Average:\n");

            double[] numbers = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter the number #{i + 1}: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            double sum = task.CalculateAverageAndSum(numbers).Item1;
            Console.WriteLine($"The Sum of the numbers: {sum}");

            double averege = task.CalculateAverageAndSum(numbers).Item2;
            Console.WriteLine($"The Averege of the numbers: {averege}");

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");

            //Write a program in C to display the cube of the number up to given an integer

            Console.Write("Enter the number of cube: ");

            double num = double.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Number is : {i} and cube of the {i} is : {task.cube(i)}");
            }


            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");

            //Write a program in C# return only numbers in the years array greater than 1950.

            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };

            int[] newYears = task.GetYears(years);

            Console.Write($"The years greater than 1950 are: ");
            for (int i = 1; i < years.Length; i++)
            {
                //Console.WriteLine(newYears[i]);

                if (newYears[i] != 0)
                {
                    Console.Write(newYears[i] + ", ");
                }
            }


            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");

            // Create a function that takes the age in years and returns the age in days

            Console.Write("\nEnter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your age in days is: {task.ConvertToDays(age)}");



            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");

            // Create class that contain the following field: Age, gender, name, email, id, phone

            Informations raniaInformation = new Informations(18, "female", "rania", "rania@yahoo.com", 123321, "0799999999");

            //Informations raniaInformation = new Informations();

            raniaInformation.Display();


        }


    }
}