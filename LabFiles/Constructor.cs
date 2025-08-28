using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LabFiles
{
    class Employee
    {
        public string Name = "";
        public int Age = 0;
        public string Department = "B.Tech";

        // Constructor with parameters
        public Employee()
        {
            Name = "Unknown";
            Age = 0;
        }
        public Employee(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public Employee(string Name, int Age, string Department) : this(Name, Age)
        {
            this.Name = Name;
            this.Age = Age;
            this.Department = Department;
        }
        // Default constructor
        
        // Method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}");
        }
    }

    class Student()
    {
        private int id;
        public  int ID
        {
            get { return id; }
            set { this.id = value; }
        }
        //public int getId()
        //{
        //    return id;
        //}

        //public void setId(int id) {
        //    this.id = id;
        //}
    }

    public class CallConstructor
    {
        public static void Main(string[] args)
        {
            //    Employee employee = new Employee("Hemal Rashiya", 24);
            //    employee.DisplayDetails();
            var studentId = 0;    
            Student student = new Student();
            student.ID = 10;
            studentId = student.ID;
            Console.WriteLine($"Student: {studentId}");
        }
    }
}
