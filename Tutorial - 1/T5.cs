using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___1
{
    internal class T5
    {
        public static void t5()
        {
            int n, fact = 1; 
            //Intialize the variable 'fact' to 1 and also intiaalize n.

            Console.WriteLine("Enter Number : ");
            //Print a statement 'enter number :' using writeline method.

            string str = Console.ReadLine();
            //Take a input from the user suing ReadLine method and store it in a string variable 'str'.
            n = Convert.ToInt32(str);
            //Convert str value into integer using Convert.ToInt32 method and stroe into n.


            for (int i = 1; i <= n; i++)
               //in for loop intialize i to 1 and check or run loop untill i is less than n.
            {

                fact = fact * i;
                //Multiply the value of fact with i and store it in fact.

            }

            Console.WriteLine("Factorial : {0}", fact);
            //Print a factorial value using WriteLine method.


            Console.Read();
        }
    }
}
