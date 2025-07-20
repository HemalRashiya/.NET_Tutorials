using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___Array
{
    internal class T2
    {
        public static void t2()
        {
            int[] arr = new int[5];
            string str;
            int temp;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter value " + (i+1) + " : ");
                str = Console.ReadLine();
                arr[i] = Convert.ToInt32(str);
                Console.WriteLine();
            }

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i; j < arr.Length; j++)
                {
                    if(arr[i] >= arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Arr value "+(i+1)+" : " + arr[i]);
            }
        }
    }
}
