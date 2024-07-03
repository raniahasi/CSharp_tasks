using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7_2024
{
    internal class Car
    {
        public string type { get; set; }
        public string modale { get; set; }
        public int year { get; set; }
        public int price { get; set; }
        public string color { get; set; }
        public string palletNo { get; set; }



        public void DisplayInfo(string type, int year)
        {

            Console.WriteLine($"The Type is: {type} and Year of made is: {year}");
        }

        public void DisplayInfo(string type)
        {

        }



        public void Display()
        {
            Console.WriteLine("Welcome Car");
        }

        //public virtual void Display()
        //{
        //    Console.WriteLine("Welcome Car");
        //}
    }

    internal class BMW : Car
    {
        public void Display()
        {
            Console.WriteLine("Welcome BMW");
        }

        //public override void Display()
        //{
        //    Console.WriteLine("Welcome BMW");
        //}
    }


}