using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___Array
{
    internal class T7
    {
        public static void t7()
        {
            int[] arr = {12,23,45,23,45,67,4,34,2,67,89};
            int[] oddArr = new int[arr.Length];
            int[] evenArr = new int[arr.Length];

            int evenCount = 0, oddCount = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr[evenCount] = arr[i];
                    evenCount++;
                }
                else
                {
                    oddArr[oddCount] = arr[i];
                    oddCount++;
                }
            }

            Console.WriteLine("Even Numbers:");
            foreach (var num in evenArr)
            {
                if (num != 0) // To avoid printing uninitialized elements
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine("\nOdd Numbers:");
            foreach (var num in oddArr)
            {
                if (num != 0) // To avoid printing uninitialized elements
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
