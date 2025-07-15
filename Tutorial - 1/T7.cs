using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___1
{
    internal class T7
    {
        public static void t7()
        {
            int num = 123;
            int ans = 0;
            int temp = num;

            while(temp != 0)
            {
                
                num = temp % 10;
                Console.WriteLine("Current digit: " + num);
                ans = (ans * 10) + num;
                Console.WriteLine("Current answer: " + ans);
                temp = temp / 10;
                Console.WriteLine("Remaining number: " + temp);
            }
            Console.WriteLine("The reverse of the number is: " + ans);

        }
    }
}
