using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 This project was created in order to test knowledge about C# through
 the usage of classes,methods and attributes alongiside heritage properties.
 All content here is based on the Playstation 2 game Castlevania: Curse of Darkness.
 */
namespace DevilForge
{
    class Program
    {
        //Constructors in C# do not work with the usage of 'this.attribute'.
        static void Main(string[] args)
        {
            InnocentDevil bonny = new InnocentDevil(80, 1);
            Console.WriteLine(bonny.MaxHearts);
            Console.Read();
        }
    }
}
