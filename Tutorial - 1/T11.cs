using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___1
{
    internal class T11
    {
        public static void t11()
        {
            Console.Write("NAME : ");
            String name = Console.ReadLine();
            Console.Write("\nGENDER : ");
            char gender = Console.ReadKey().KeyChar;
            if(gender == 'M')
            {
                Console.WriteLine("\nHello Mr. " + name);
            }
            else
            {
                Console.WriteLine("\nHello Ms. " + name);
            }
        }
    }
}
