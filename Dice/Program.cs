using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object for rollingdice/ constructor is called here

            RollingDice objsixside = new RollingDice(10);
            RollingDice objtenside = new RollingDice();

            Console.WriteLine(objsixside.SideCount());
            Console.WriteLine(objtenside.SideCount());

           // Console.WriteLine(objsixside);
            

            // roll the 6 side dice

            Console.WriteLine(objsixside);
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(objsixside.RollCount());
            }
            // roll the 10 side die
            Console.WriteLine(objtenside);
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(objtenside.RollCount());
            }

            Console.ReadKey();
        }
    }
}
