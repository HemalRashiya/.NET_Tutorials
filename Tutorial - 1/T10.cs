using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___1
{
    internal class T10
    {
        public static void t10()
        {
            Console.Write("INPUT : ");
            String input = Console.ReadLine();
            for (int i = 1; i < input.Length; i++)
            {
                if (i <= 5)
                {
                    Console.Write(input[i]);
                }else
                {
                    Console.Write("X");
                }
                
            }
        }
    }
}
