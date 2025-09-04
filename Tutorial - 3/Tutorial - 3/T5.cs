using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___3
{

    class Product
    {
        string pcode;
        string pname, mname;

        // Constructor
        public Product(string pcd, string pnm, string mnm)
        {
            pcode = pcd;
            pname = pnm;
            mname = mnm;
        }

        // Display method
        public void Display()
        {
            Console.WriteLine("\nProduct Code:= " + pcode);
            Console.WriteLine("\nProduct Name:= " + pname);
            Console.WriteLine("\nManufacturer Name:= " + mname);
        }
    }

    public class T5
    {
        public static void t5(string[] args)
        {
            int n = args.Length;

            if (n < 3)
            {
                Console.WriteLine("Syntax Error\n");
                Console.WriteLine("Must Have THREE Arguments\n");
                Console.WriteLine("Please, Write as [csc TestProduct ProductCode ProductName Manufacturer] \n");
            }
            else
            {
                string pcd = args[0];
                string pnm = args[1];
                string mnm = args[2];

                Product p = new Product(pcd, pnm, mnm);
                p.Display();

                Console.Read();
            }
        }
    }
}
