using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevilForge
{
    class BattleType : InnocentDevil
    {
        //In order to call the parent class's constructor it is necessary to use ':base()'
        public BattleType(int heart, int level) : base(heart, level)
        {

        }
        public override void LevelUp()
        {
            base.LevelUp();
            Console.WriteLine("Your Battle Type Innocent Devil has leveled up!");
            MaxHearts = MaxHearts + 10;
        }
    }
}
