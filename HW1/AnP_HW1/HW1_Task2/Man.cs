using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_Task2
{
    class Man
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Age { get; private set; }

        public Man(string name, string description, int age)
        {
            Name = name;
            Description = description;
            Age = age;
        }
    }
}
