using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task5
{
    class Dog : Animal
    {
        public string breed;

        public Dog(string name, string sound, string breed) : base(name, sound)
        {
            this.breed = breed;
        }
    }
}
