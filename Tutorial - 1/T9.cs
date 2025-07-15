using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___1
{
    internal class T9
    {
        public static void t9()
        {
            Console.Write("INPUT : ");
            String str = Console.ReadLine();
            String outputStr = "";
            foreach (char c in str)
            {
                if (Char.IsUpper(c))
                {
                    outputStr += Char.ToLower(c);
                }
                else
                {
                    outputStr += Char.ToUpper(c);
                }
            }
            Console.WriteLine("OUTPUT : " + outputStr);
        }
    }
}
