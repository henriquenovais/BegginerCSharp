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
            /*
            // Experimenting with sequential deviation:
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
            */

            /*
            //Creating a switch case:
                            int luckyNumber;
            luckyNumber = Convert.ToInt32(Console.ReadLine());
             switch (luckyNumber)
            {
                case 0:
                    Console.Write("Case number zero");
                    break;
                case 1:
                    Console.Write("Case number one");
                    break;
                case 2:
                    Console.Write("Case number two");
                    break;
                case 3:
                    Console.Write("Case number three");
                    break;
                case 4:
                    Console.Write("Case number four");
                    break;
                default:
                    Console.Write("Invalid number was input");
                    break;
            }
             */
            /*
           //Implementing for and white loops:
           int index = 5;
           for (int i = 0; i < index;i++)
           {
               Console.WriteLine("This is \"for\" loop!");
               Console.WriteLine(i);
           }
           Console.WriteLine("Testing!!");
           while (index < 50)
           {
               Console.WriteLine("This is a \"while\" loop!");
               index = index + 10;
           }
           */
            /*
            //Testing two dimensional arrays(matrix):
             int[,] numberGrid =
             {
                 {1,2},
                 {3,4},
                 {6,7 }
             };
             for (int i = 0; i < 3;i++)
             {
                 for(int j = 0; j < 2; j++) {
                     Console.WriteLine(numberGrid[i, j]);
                 }
             }
             */

            /*
            //Exception handling through C#:
             */
            
            try
            {
                Console.WriteLine("Insert the number you want as dividend:");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Insert the number you want as divider:");
                double number2 = Convert.ToDouble(Console.ReadLine());
                number1 = number1 / number2;
                Console.WriteLine("The result is: " + number1);
            }
            catch(DivideByZeroException e)
            {
                //catch(Exception e){} can be used for a more generalistic approach to the error handling.
                /*
                It is not recommended to use the generalistic approach because the steps necessary
                for a proper error handling may require very different solutions. It is much better
                to treat errors through specific solutioning.
                */
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Read();
            

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
