using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll
{
    abstract class Person

    {
        private static int count = 0;
        public string Id { get; }
        public string Name { get; set; }
        public abstract float calculateSalary();
        
        private void constructId()
        {
            string Id = string.Empty;
            Id = Name.Substring(0, 2) + count++;
        }

        public Person(String name)
        {
            Name = name;
            constructId();
        }
    }

}
