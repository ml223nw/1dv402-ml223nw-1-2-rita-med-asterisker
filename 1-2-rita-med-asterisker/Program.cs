using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_rita_med_asterisker
{
    class Program
    {
        static void Main(string[] args)
        {

            int caseSwitch = 0;

            for (int row = 0; row < 25; row ++)
            {
                if (caseSwitch > 2)
                {
                    caseSwitch = 0;
                }

                switch (caseSwitch)
                    {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }

                ++caseSwitch;
                                
                for (int column = 0; column < 39; column ++)
                {                   
                    Console.Write("* ");
                }
                
                Console.WriteLine();
                
                if (row % 2 == 0)
                {
                    Console.Write(" ");
                }                                    
             }
             Console.ResetColor();
          }

     }

}