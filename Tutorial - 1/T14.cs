using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___1
{
    internal class T14
    {
        public static void t14()
        {
            Array myArray = new String[10] { "Zero", "One", "Two", "Three", "Four","Five","Six","Seven","Eight","Nine" };
            Console.Write("INPUT : ");
            String str = Console.ReadLine();
            foreach (char c in str)
            {
                switch (c)
                {
                    case '0':
                        Console.Write("Zero ");
                        break;
                    case '1':
                        Console.Write("One ");
                        break;
                    case '2':
                        Console.Write("Two ");
                        break;
                    case '3':
                        Console.Write("Three");
                        break;
                    case '4':
                        Console.Write("Four ");
                        break;
                    case '5':
                        Console.Write("Five ");
                        break;
                    case '6':
                        Console.Write("Six ");
                        break;
                    case '7':
                        Console.Write("Seven ");
                        break;
                    case '8':
                        Console.Write("Eight ");
                        break;
                    case '9':
                        Console.Write("Nine ");
                        break;
                }
            }
            
        }
    }
}
