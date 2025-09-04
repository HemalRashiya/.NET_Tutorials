using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___3
{
    public class Student
    {
        // Data members (fields)
        private int rollNo;
        private string name;
        private int age;
        private string course;

        // Properties
        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
                else
                    Console.WriteLine("Age must be positive.");
            }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        // Default Constructor
        public Student()
        {
            rollNo = 0;
            name = "Unknown";
            age = 0;
            course = "Not Assigned";
        }

        // Parameterized Constructor
        public Student(int rollNo, string name, int age, string course)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.Age = age; // using property for validation
            this.course = course;
        }

        // Method to Display Student Details
        public void DisplayDetails()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Name   : {Name}");
            Console.WriteLine($"Age    : {Age}");
            Console.WriteLine($"Course : {Course}");
        }
    }

    // TestStudent class in same file
    public class T3
    {
        public static void t3()
        {
            // Creating object using default constructor
            Student s1 = new Student();
            s1.DisplayDetails();

            Console.WriteLine();

            Student s2 = new Student(101, "Hemal Rashiya", 44, "Computer Engineering");
            s2.DisplayDetails();

            Console.WriteLine();

            s1.RollNo = 102;
            s1.Name = "Aarav";
            s1.Age = 19;
            s1.Course = "Information Technology";

            Console.WriteLine("Updated Student Details:");
            s1.DisplayDetails();

            Console.ReadLine();
        }
    }
}
