using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_6_2024
{
    public class task
    {
        //Write a function in C# that accept 10 numbers and return sum and average.

        public static (double, double) CalculateAverageAndSum(double[] numbers)
        {
            double sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            double average = sum / numbers.Length;

            return (sum, average);

        }

        //Write a program in C# to display the cube of the number up to given an integer.


        public static double cube(int number)
        {
            //double cube = number * number * number;
            double cube = Math.Pow(number, 3);
            return cube;
        }


        //Write a program in C# return only numbers in the years array greater than 1950.

        public static int[] GetYears(int[] years)
        {
            int[] greaterYears = new int[years.Length];

            for (int i = 0; i < years.Length; i++)
            {
                if (years[i] >= 1950)
                {
                    greaterYears[i] = years[i];
                }
            }

            return greaterYears;
        }



        // Create a function that takes the age in years and returns the age in days

        public static int ConvertToDays(int age)
        {
            int days = age * 365;
            return days;
        }




    }
}