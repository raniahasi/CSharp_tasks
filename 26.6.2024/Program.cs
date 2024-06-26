//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("enter the first number:");
//        int number1 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("enter the second number:");
//        int number2 = Convert.ToInt32(Console.ReadLine());

//        if (number1 < number2)
//        {
//            Console.WriteLine("The smaller number is: " + number1);
//        }
//        else
//        {
//            Console.WriteLine("The smaller number is: " + number2);
//        }
//    }
//}


//2.//

using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("enter a number:");
//        int num = Convert.ToInt32(Console.ReadLine());

//        if (num > 0)
//        {
//            Console.WriteLine(" sign is +");
//        }
//        else if (num < 0)
//        {
//            Console.WriteLine(" sign is -");
//        }
//        else
//        {
//            Console.WriteLine(" sign is 0");
//        }
//    }
//}

//3.//

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("enter the first number:");
//        int num1 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("enter the second number:");
//        int num2 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("enter the third number:");
//        int num3 = Convert.ToInt32(Console.ReadLine());

//        int temp;

//        if (num1 > num2)
//        {
//            temp = num1;
//            num1 = num2;
//            num2 = temp;
//        }

//        if (num1 > num3)
//        {
//            temp = num1;
//            num1 = num3;
//            num3 = temp;
//        }

//        if (num2 > num3)
//        {
//            temp = num2;
//            num2 = num3;
//            num3 = temp;
//        }

//        Console.WriteLine("the number in ascending order: " + num1 + ", " + num2 + ", " + num3);
//    }
//}


//4.//
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter the first number:");
//        int num1 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter the second number:");
//        int num2 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter the third number:");
//        int num3 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter the fourth number:");
//        int num4 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter the fifth number:");
//        int num5 = Convert.ToInt32(Console.ReadLine());

//        int max = num1;

//        if (num2 > max)
//        {
//            max = num2;
//        }
//        if (num3 > max)
//        {
//            max = num3;
//        }
//        if (num4 > max)
//        {
//            max = num4;
//        }
//        if (num5 > max)
//        {
//            max = num5;
//        }

//        Console.WriteLine("The maximum number is: " + max);
//    }
//}


//5//
using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("enter speed in km per hour:");
//        double killometerperhour = Convert.ToDouble(Console.ReadLine());

//        double milesperhour = killometerperhour * 0.621371;

//        Console.WriteLine(killometerperhour + " kilometers per hour is equal to " + milesperhour + " miles per hour.");
//    }
//}


//6//

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("enter hours:");
//        int hours = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("enter minutes:");
//        int minutes = Convert.ToInt32(Console.ReadLine());

//        int totalminutes = (hours * 60) + minutes;

//        Console.WriteLine("total minutes: " + totalminutes);
//    }
//}

//task7//
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("enter the total minutes");
//        int totalmins = Convert.ToInt32(Console.ReadLine());
//        int hours = totalmins / 60;
//        int mins = totalmins % 60;
//        Console.WriteLine(hours+"hours ," + mins +"minutes");
//    }
//}


//task8//


//using System;
//using System.Net.Security;

//class Program
//{
//    static void Main()
//    {
//        string[] sentences = { "hello " ,
//            "hello its me" ,
//            "hello everyone this is rania" ,
//            "hi",
//            "get out"



//        };
//        foreach (string sentence in sentences)
//        { Console.WriteLine(sentence.PadRight(20, ' ')); }
//    }
//}

//task8//
//using System;

//class Program
//{
//    static void Main()
//    {
        
//        string[] sentences = {
//            "hello is world.",
//            "Another hellooo.",
//            "Short hello.",
//            "A longer helloo for world and maybe idk.",
//            "The last helloooooooooooo ever never wow."
//        };

        
//        int fixedLength = 20;

       
//        foreach (string sentence in sentences)
//        {
//            // Padright ensures the sentence is  fixedlength characters long
//            // if the sentence is shorter than 20, it adds spaces to the right not left
//            // ff the sentence is longer than 20, it shortens the sentence
//            string paddedSentence = sentence.Length > fixedLength ? sentence.Substring(0, fixedLength) : sentence.PadRight(fixedLength, ' ');
//            Console.WriteLine(paddedSentence);
//        }
//    }
//}





