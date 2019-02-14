// This part is bascalyl
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            Basic data manipulation:

            string characterName = "Henrique"; //Declaring string
            int characterAge; // Declaring int
            //float, double[most cases], decimal[insane precision]
            double gpa = 2.0;
            bool isMale = true; //Boolean
            characterAge = 24;
            string phrase1 = "Name:";
            string phrase2 = "Age:";
            Console.WriteLine(phrase1 + characterName);
            Console.WriteLine(phrase2 + characterAge);
            //It is possible to manipulate strings as an array. 
            //Ex: string[0]
            Console.ReadLine();
            */
            /*
            //Simple user input:
            Console.Write("Enter your ID: ");
            string userInput = Console.ReadLine(); //A user input through line is ALWAYS a string!
            Console.WriteLine("The name you typed was: " + userInput);
            Console.ReadLine();
            */
            /*
            //Creating a simple calculator through user input:
            Console.Write("Enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            //Use Convert.ToInt32 in order to convert the string to integer
            //double result = number1 + number2;
            Console.WriteLine(number1 + number2);//Why the hell is this not being correctly printed?
            Console.ReadLine();
            */
            /*
            //Basic array programming:
            int[] array = { 5, 4, 6, 10, 15 }; 
            string[] arrayOfStrings = { "kappa","many","manyy", "stringss"};
            Console.WriteLine(arrayOfStrings[2]);
            Console.WriteLine(array[4]);
            Console.WriteLine(array[3]);
            Console.Read();
            */
            /* 
            //Creating and testing methods:
            SayHi("Henrique", 23);
            int number = Cube(5);
            Console.WriteLine(number);
            Console.Read();
            */
            bool isMale;
            bool isTall;
            Console.WriteLine("Are you tall? ");
            isMale = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Are you male? ");
            isTall = Convert.ToBoolean(Console.ReadLine());
            if (isMale &&  isTall)
            {
                Console.WriteLine("You are male and tall!");
                Console.Read();
            } else
            {
                Console.WriteLine("You are either not male or not tall.");
                Console.Read();
            }

        }
        //Creating a method without returning a value:
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello! My name is " + name + " and my age is " + age + ".");

        }
        //Creating a method that does return a value:
        static int Cube(int number)
        {
            number = number * number * number;
            return number;
        }

    }
}
