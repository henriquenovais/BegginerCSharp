using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevilForge
{
    class InnocentDevil
    {
        private int currentHearts;
        private int devilLevel;
        private int MaxHearts;

        public int MaxHearts
        {
            get { return MaxHearts; }
            set
            {
                if (value < MaxHearts)
                {
                    Console.WriteLine("The maximium amount of hearts cannot be reduced");
                }
                else
                {
                    MaxHearts = value;
                    Console.WriteLine("The maximium hearts of the I.D. is: " + MaxHearts);
                }
            }
        }

        public InnocentDevil(int hearts, int level)
        {
            currentHearts = hearts;
            MaxHearts = hearts;
            devilLevel = level;
        }


     

    }
}
