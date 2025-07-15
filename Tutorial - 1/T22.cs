using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___1
{
    internal class T22
    {
        public static void t22()
        {
            int rows = 4;

            for (int i = 1; i <= rows; i++)
            {

                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }


                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* "); // Asterisk followed by a space
                }
                Console.WriteLine(); // Move to the next line after each row
            }

            for (int i = 4; i >= 0; i--)
            {

                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }


                for (int k = 1; k <= i ; k++)
                {
                    Console.Write("* "); // Asterisk followed by a space
                }
                Console.WriteLine(); // Move to the next line after each row
            }

        }
    }
}
