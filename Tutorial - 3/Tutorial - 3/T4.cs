using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial___3
{
    using System;

    namespace StudentDemo
    {
        // Student class definition
        public class Student
        {
            // Data members (fields)
            private int rollNo;
            private string name;
            private int age;

            // Property for RollNo
            public int RollNo
            {
                get { return rollNo; }
                set { rollNo = value; }
            }

            // Property for Name
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            // Property for Age
            public int Age
            {
                get { return age; }
                set
                {
                    if (value > 0)
                        age = value;
                    else
                        throw new ArgumentException("Age must be greater than 0");
                }
            }

            // Default constructor
            public Student()
            {
                rollNo = 0;
                name = "Unknown";
                age = 0;
            }

            // Parameterized constructor
            public Student(int rollNo, string name, int age)
            {
                this.rollNo = rollNo;
                this.name = name;
                this.age = age;
            }

            // Method to display student info
            public void DisplayInfo()
            {
                Console.WriteLine($"Roll No: {rollNo}, Name: {name}, Age: {age}");
            }
        }

        // Test class in same file
        class T4
        {
            public static void t4()
            {
                // Creating 5 student objects using constructor
                Student s1 = new Student(1, "Hemal", 21);
                Student s2 = new Student(2, "Rahul", 20);
                Student s3 = new Student(3, "Neha", 22);
                Student s4 = new Student(4, "Karan", 19);
                Student s5 = new Student(5, "Priya", 23);

                // Displaying info of each student
                Console.WriteLine("Student Details:\n");
                s1.DisplayInfo();
                s2.DisplayInfo();
                s3.DisplayInfo();
                s4.DisplayInfo();
                s5.DisplayInfo();

                Console.ReadLine();
            }
        }
    }

}
