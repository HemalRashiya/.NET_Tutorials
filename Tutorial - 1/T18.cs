using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___1
{
    internal class T18
    {

        
        public static void t18()
        {
            int n = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(n + " ");
                    n++;
                }
                Console.WriteLine();
            }
        }
    }
}
