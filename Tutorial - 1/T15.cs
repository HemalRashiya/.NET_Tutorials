using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___1
{
    internal class T15
    {
        public static void t15()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsArmstrong(number))
            {
                Console.WriteLine($"{number} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong number.");
            }
        }

        public static bool IsArmstrong(int number)
        {
            int originalNumber = number;
            int sum = 0;
            int numberOfDigits = 0;

            // Calculate the number of digits
            int tempNumber = number;
            while (tempNumber > 0)
            {
                tempNumber /= 10;
                numberOfDigits++;
            }

            // Calculate the sum of digits raised to the power of numberOfDigits
            tempNumber = number; // Reset tempNumber to the original number
            while (tempNumber > 0)
            {
                int digit = tempNumber % 10;
                sum += (int)Math.Pow(digit, numberOfDigits);
                tempNumber /= 10;
            }

            return sum == originalNumber;
        }
    }
}
