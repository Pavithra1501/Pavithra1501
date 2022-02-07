using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class student_details
    {
        static void Main(string[] args)
        {

            Person[] people = {
                                new Person("pavi", "chinthamani", "karnataka", " vikram english medium school", 2016, 4500.0),
                                new Person("srikanth", "Bangalore"," Karnataka", "royal Public school", 35000.0),
                                new Person("gopi", "kolar", "Karnataka", "jain Public school", 42000.0),
                                new Person("raghu", "hassan", "Karnataka", " fundamentals", 2002, 4750.0),
                                new Person("abhi", "vasco", "Goa", "Reactjs", 2018, 12500.0)
                                };
            Console.ReadLine();
        }
    }

    public class Student
    {

        public Student(string name, string city, string state, string school, int year, double fees)
        {
        }
    }
    public class Staff
    {

        public Staff(string name, string city, string state, string school, double salary)
        {
        }
    }
    public class Person
    {


        public Person(string v1, string v2, string v3, string v4, double v5)
        {
            Console.WriteLine("Staff Details:" + "Name: " + v1 + ", City:" + v2 + ", State: " + v3 + ", School: " + v4 + ", Salary: " + v5);

        }
        public Person(string name, string city, string state, string school, int year, double fees)
        {
            Console.WriteLine("Student Details:" + "Name: " + name + ", City: " + city + ", State: " + state + ", Year: " + year + ", fees:" + fees);
        }
    }
}
    

