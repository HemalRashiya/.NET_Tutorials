using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___Array
{
    internal class T6
    {
        public static void t6()
        {
            int[] arr = {23,1,45,34,2,56,5};
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] >= arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Minimum value is : " + arr[0]);

            Console.WriteLine("Maximum value is : " + arr[arr.Length - 1]);
        }
    }
}
