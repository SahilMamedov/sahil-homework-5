using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task.Models
{
    // class member => fieldler, propertyler , methodlar
    class Student:Person
    {
        // fields

       
        public string profession;

        // constructor bir metoddur
        // classin adi ile eyni olur
        // return type olmur
        // ilk ishe dushen methoddur
        //public Student()
        //{
        //    Console.WriteLine("Constructor ishledi");
        //}
        public Student()
        {
            Console.WriteLine( "Parametirsiz constructor ishledi");
        }
        public Student(string name):this()
        {
            this.name = name;
         
        }

        public Student(string name, string surName, int age):this(name)
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
