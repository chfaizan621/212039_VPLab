using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task4
{
    public class Person2
    {
        private string name;
        private int age;

        public Person2() : this("Unknown", 0) { }

        public Person2(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person2(string name) : this(name, 0) { }
        public Person2(int age) : this("Unknown", age) { }

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
