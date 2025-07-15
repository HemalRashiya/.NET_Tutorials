using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___1
{
    internal class T21
    {
        public static void t21()
        {
          Console.WriteLine("Input the number of terms : ");
            String terms = Console.ReadLine();
            Console.WriteLine("Input number : ");
            String number = Console.ReadLine();
            int ans = 0, num = 0,total = 0;
            num = Convert.ToInt32(number);
            for (int i = 1; i <= Convert.ToInt32(terms); i++)
            {
                ans = (ans * 10) +num;
                total += ans;
                Console.Write(ans + " + ");
            }
            Console.WriteLine("The sum is : " + total);   
        }
    }
}
