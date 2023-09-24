using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task3
{
    partial class Student
    {
        private int Student_id;
        private string name;
        private int age;

        public Student(int student_id, string name, int age)
        {
            Student_id = student_id;
            this.name = name;
            this.age = age;
        }
    }

    partial class Student
    {
        public int GetID()
        {
            return Student_id;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetName()
        {
            return name;
        }

        public void GetStudentInfo()
        {
            Console.WriteLine("Student ID: " + GetID());
            Console.WriteLine("Name: " + GetName());
            Console.WriteLine("Age: " + GetAge());
        }
    }

}
