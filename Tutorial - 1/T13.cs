using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___1
{
    internal class T13
    {
        public static void t13()
        {
            Console.Write("Enter number for fibonacci sereis : ");
            String n = Console.ReadLine();

            int a = 0, b = 1, c = 0,num;
            num = Convert.ToInt32(n);
            for(int i = 1; i <= num; i++)
            {
                c = a + b;
                Console.Write(a + " ");
                a = b;
                b = c;
            }


        }
    }
}
