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
            //Simple user input:
            Console.Write("Enter your ID: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("The name you typed was: " + userInput);
            Console.ReadLine();
        }
    }
}
