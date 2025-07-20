using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___Array
{
    internal class T5
    {
        public static void t5()
        {
            int[] arr = {1,1,1,2,2};
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Duplicate Element : "+ count);
        }
    }
}
