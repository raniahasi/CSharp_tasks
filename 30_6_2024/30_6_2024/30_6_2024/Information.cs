using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _30_6_2024
{
    public class Informations
    {

        public int Age;
        public string Gender;
        public string Name;
        public string Email;
        public int ID;
        public string Phone;

        public Informations()
        {
            Age = 18;
            Gender = "Male";
            Name = "Omar";
            Email = "O@yahoo.com";
            ID = 123456987;
            Phone = "07978787878";
        }

        public Informations(int age, string gender, string name, string email, int id, string phone)
        {
            if (age >= 18 && age <= 60)
            {
                Age = age;
            }
            else
            {
                throw new ArgumentException("Age must be between 18 and 60.");
            }


            Gender = gender;
            Name = name;
            Email = email;
            ID = id;

            if (phone.StartsWith("077") || phone.StartsWith("078") || phone.StartsWith("079"))
            {
                Phone = phone;
            }
            else
            {
                throw new ArgumentException("Phone number must start with 077, 078, or 079.");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Phone: {Phone}");
        }
    }
}