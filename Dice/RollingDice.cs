using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class RollingDice
    {
        // fields for sides and Random number
        private int sides;
        private Random random;
        // create a constructor for class to intialize sides and randomfields
        public RollingDice()
        {
            sides = 6;
            random = new Random();
        }
        public RollingDice(int totalsides)
        {
            sides = totalsides;
            random = new Random();
        }
        // create a method/function for no:of sides or sidecount

        public int SideCount()
        {
            return sides;
        }
        public int RollCount()
        {
            return random.Next (1,sides+1);
        }
        
        public override string ToString()
        {
            return string.Format(" Rolling a die with{0} sides",sides);
        }

    }
}
