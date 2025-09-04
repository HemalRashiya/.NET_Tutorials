using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___3
{
    class Student1
    {
        // Data members (fields)
        private string enrolmentNo;
        private string name;

        // Property for EnrolmentNo
        public string EnrolmentNo
        {
            get { return enrolmentNo; }
            set { enrolmentNo = value; }
        }

        // Property for Name
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
                else
                    throw new ArgumentException("Name cannot be empty");
            }
        }

        // Default constructor
        public Student1()
        {
            enrolmentNo = "N/A";
            name = "Unknown";
        }

        // Parameterized constructor
        public Student1(string enrolNo, string nm)
        {
            enrolmentNo = enrolNo;
            name = nm;
        }

        // Method to display student info
        public void DisplayInfo()
        {
            Console.WriteLine($"Enrolment No: {enrolmentNo}, Name: {name}");
        }
    }

    class T7
    {
        public static void t7()
        {
            // Using default constructor
            Student1 s1 = new Student1();
            s1.DisplayInfo();

            // Using parameterized constructor
            Student1 s2 = new Student1("E001", "Hemal");
            s2.DisplayInfo();

            // Using properties to set values
            Student1 s3 = new Student1();
            s3.EnrolmentNo = "E002";
            s3.Name = "Rahul";
            s3.DisplayInfo();

            Console.ReadLine();
        }
    }
}
