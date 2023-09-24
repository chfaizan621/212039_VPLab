using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task5
{
    class Animal
    {
        public string name;
        public string sound;

        public Animal()
        {
            name = string.Empty;
            sound = string.Empty;
        }

        public Animal(string name, string sound)
        {
            this.name = name;
            this.sound = sound;
        }
    }
}
