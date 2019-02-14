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
        private int maxHearts;
        public static int numberOfID = 0;

        public int MaxHearts
        {
            get { return maxHearts; }
            set
            {
                if (value < maxHearts)
                {
                    Console.WriteLine("The maximium amount of hearts cannot be reduced");
                }
                else
                {
                    maxHearts = value;
                    Console.WriteLine("The maximium hearts of the I.D. is: " + MaxHearts);
                }
            }
        }

        public int DevilLevel
        {
            get { return devilLevel; }
            set
            {
                if(value < 0 || value < DevilLevel)
                {
                    Console.WriteLine("An Innocent Devil cannot have negative level!");
                } else
                {
                    DevilLevel = value;
                    Console.WriteLine("The new level of your I.D. is: " + DevilLevel);
                }
            }
        }

        public InnocentDevil(int hearts, int level)
        {
            currentHearts = hearts;
            MaxHearts = hearts;
            devilLevel = level;
            numberOfID += numberOfID;
        }

        public virtual void LevelUp()
        {
        }

        public static void DevilForge()
        {
            Console.WriteLine("You are devil forging right now!");
        }


     

    }
}
