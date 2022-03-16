using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task.Models
{
    class Developer:Person
    {
        // fields

       
        public int salary;

        public Developer()
        {
            Console.WriteLine("Parametirsiz constructor ishledi");
        }
        public Developer(string name) : this()
        {
            this.name = name;

        }

        public Developer(string name, string surName, int age) : this(name)
        {

            this.surName = surName;
            this.age = age;

        }


        public void Info()
        {
            Console.WriteLine($"{this.name} {surName} {age}");
        }


    }
}
