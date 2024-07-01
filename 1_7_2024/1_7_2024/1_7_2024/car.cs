using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7_2024
{
    internal class Car
    {
        protected static string type;
        protected static string modale;
        protected static int year;
        protected static int price;
        protected static string color;
        protected static string palletNo;



        public Car(string Type, string Modale, int Year, int Price, string Color, string PalletNo)
        {
            type = Type;
            modale = Modale;
            year = Year;
            price = Price;
            color = Color;
            palletNo = PalletNo;
        }


        public static void engine(string key = "ON")
        {
            if (key == "ON")
            {
                Console.WriteLine("Engine is working");
            }
            else if (key == "OFF")
            {
                Console.WriteLine("Engine stop");
            }
        }

        public string CarInformation()
        {
            return $"Car Information:\n\nThe type of the car is {type}, Type of it is {modale}, and the year of made is {year}.\n\nThe price of this type of car is {price}.\n\nThis is some infprmation about this car.\n\nColor: {color}\nPallet Number: {palletNo}";
        }

        public class BMW : Car
        {
            public BMW(string modale, int year, int price, string color, string palletNo)
                            : base("BMW", modale, year, price, color, palletNo)
            {

            }

        }
    }



}