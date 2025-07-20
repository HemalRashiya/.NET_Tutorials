using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___Array
{
    internal class T3
    {
        public static void t3()
        {
            Console.WriteLine("How many value you want to enter in array?");
            String str = Console.ReadLine();
            int n = Convert.ToInt32(str);

            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("\nEnter value " + (i + 1) + " : ");
                str = Console.ReadLine();
                arr[i] = Convert.ToInt32(str);
            }

            
            for (int i = arr.Length; i > 0; i--)
            {
                Console.WriteLine(" "+arr[(i-1)]);
            }


        }
    }
}
