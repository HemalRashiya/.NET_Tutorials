using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___1
{
    internal class T4
    {
        public static void t4()
        {
            int x;
            Console.WriteLine("Enter Number:");
            String str = Console.ReadLine();
            x = Convert.ToInt32(str);
            if (x % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
