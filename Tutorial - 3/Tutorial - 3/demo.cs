using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___3
{
    class Demo1
    {
        private int id = 0;
        private string name = string.Empty;

        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
    }
    internal class demo
    {
        public static void demoMethod()
        {
            Demo1 demo1 = new Demo1();
            Demo1 demo2 = new Demo1();

            demo1.setId(12);
            demo2.setName("Hemal Rashiya");

            Console.WriteLine("Your id : " + demo1.getId());
            Console.WriteLine("Your name : " + demo2.getName());
        }


    }
}
