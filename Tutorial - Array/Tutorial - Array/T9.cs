using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___Array
{
    internal class T9
    {
        public static void t9()
        {
            int[] arr = new int[5];
            string str;
            int temp;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter value " + (i + 1) + " : ");
                str = Console.ReadLine();
                arr[i] = Convert.ToInt32(str);
                Console.WriteLine();
            }

            Console.WriteLine("Provide an elemen to delete : ");
            string deleteStr = Console.ReadLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if(Convert.ToInt32(deleteStr) == arr[i])
                {
                       arr[i] = 0;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Arr value " + (i + 1) + " : " + arr[i]);
            }
        }
    }
}
