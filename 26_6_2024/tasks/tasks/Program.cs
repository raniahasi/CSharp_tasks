//using System;

//class Program
//{
//    static void Main()
//    {

//        Console.WriteLine("Enter the first number:");
//        int number1 = Convert.ToInt32(Console.ReadLine());


//        Console.WriteLine("Enter the second number:");
//        int number2 = Convert.ToInt32(Console.ReadLine());


//        int smallerNumber = Math.Min(number1, number2);


//        Console.WriteLine("The smaller number is: " + smallerNumber);
//    }
//}



//2.//

//Console.Write("enter your first text: ");
//string first = Console.ReadLine();
//Console.Write("enter your second text: ");
//string second = Console.ReadLine();
//string textSpace = " ";

//string conStrng = string.Concat(first, textSpace, second);

//Console.WriteLine("your text is: " + conStrng);
//Console.WriteLine("your text is: " + first + textSpace + second);

//Console.WriteLine("");

//3.//

//int num5 = 46, num6 = -37, num7 = 2;
//int[] intArr2 = { num5, num6, num7 };
//Array.Sort(intArr2);
//Console.WriteLine("numbers in ascending order " + "[{0}]", string.Join(", ", intArr2));
//Array.Reverse(intArr2);
//Console.WriteLine("numbers in descending order " + "[{0}]", string.Join(", ", intArr2));

//Console.WriteLine("");

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Define the five numbers
//        int num1 = -5;
//        int num2 = -2;
//        int num3 = -6;
//        int num4 = 0;
//        int num5 = -1;

//        // Find the maximum number using Math.Max
//        int max = Math.Max(num1, Math.Max(num2, Math.Max(num3, Math.Max(num4, num5))));

//        // Display the maximum number
//        Console.WriteLine("The maximum number is: " + max);
//    }
//}



//5//
//using System;

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
//        Console.WriteLine(hours + "hours ," + mins + "minutes");
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

string[] strings = new string[5] { "Rania ", " Chemist ", " 26 old", " I love music", " Full stack developer" };
string s0 = strings[0];
string s1 = strings[1];
string s2 = strings[2];
string s3 = strings[3];
string s4 = strings[4];
Console.WriteLine(s0.Substring(0, 5));
Console.WriteLine(s1.Substring(0, 5));
Console.WriteLine(s2.Substring(0, 5));
Console.WriteLine(s3.Substring(0, 5));
Console.WriteLine(s4.Substring(0, 5));