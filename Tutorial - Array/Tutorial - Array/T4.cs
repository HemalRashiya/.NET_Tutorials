using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___Array
{
    internal class T4
    {
        public static void t4()
        {
            int[] arr1 = { 4, 32, 12, 67, 234, 32 };
            int[] arr2 = new int[arr1.Length];

            for(int i =  0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("Copied Array : ");
            for(int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
