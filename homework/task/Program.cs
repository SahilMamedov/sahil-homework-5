using System;
using task.Models;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {


            #region class start
            // DRY 
            string name = "Sahil";
            string surName = "Mamedov";
            int age = 24;

            string name1 = "Ugur";
            string surName1 = "Eliyev";
            int age1 = 23;


            var obj1 = new
            {
                name = "Sahil",
                surName = "Mamedov",
                age = 24
            };


            var obj2 = new
            {
                name = "Ugur",
                surName = "Eliyev",
                age = 23
            };
            // videoda bura kimi yazilmishdi kodlar.
            #endregion

            #region class
            // int num =5;
            // Console.WriteLine(num);

            //Student stu1 = new Student();
            // stu1 instance

            //stu1.name = "Sahil";
            //stu1.surName = "Mamedov";
            //stu1.age = 24;
            //  Console.WriteLine(stu1.name);
            // stu1.Info();

            //Student stu2 = new Student();

            //stu2.name = "Ugur";
            //stu2.surName="Eliyev";
            //stu2.age = 23;
            //stu2.Info();

            //int[] arr = { 1, 2, 3 };
            //Student[] students = { };
            //students[0] = stu1;

            //foreach (var item in students)
            //{
            //    item.Info();
            //}

            #endregion
            #region constructor

            //Student stu3 = new Student("Lorem", "ipsum", 25);
            ////stu3.name = "test";
            ////stu3.name = "lorem";
            ////stu3.surName = "ipsum";
            ////stu3.age = 25;
            //// Console.WriteLine(stu3.name);
            //Student stu4 = new Student("Murad", "Veliyev",27);
            //stu4.Info();

            //  Student stu5 = new Student("Mamed", "Mamedov", 25);





            #endregion
            #region inheritance 

            Developer dev1 = new Developer();
            dev1.salary = 700;
            dev1.name = "Sahil";


            #endregion
        }

    }
    
}
