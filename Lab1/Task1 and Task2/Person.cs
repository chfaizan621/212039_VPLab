using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task1_and_Task2
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            name = string.Empty;
        }

        public Person(string n, int a)
        {
            name = n;
            age = a;
        }
        public Person(string n)
        {
            name = n;
        }

        public Person(int a)
        {
            age = a;
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }
    }
}
