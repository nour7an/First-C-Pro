using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp69
{
    static class studentExe
    {
        public static void Print(this List<student> Ls)
        {
            foreach (var item in Ls)
            {
                Console.WriteLine(item);
            }
        }
        public static void Printworker(this List<workers> wo)
        {
            foreach (var item in wo)
            {
                Console.WriteLine(item);
            }
        }
        public static void FakeData(this List<student> Ls)
        {

            List<student> fake = new List<student>()
        {
            new student{Name = "Nour" , age = 20 , gpa = 3.1f,department="CS"},
            new student{Name = "Ahmed" , age = 19, gpa = 3.3f,department="IT"},
            new student{Name = "Reem" , age = 18 , gpa = 3.6f,department="BIO"},
            new student{Name = "Shahd" , age = 17 , gpa = 3.7f,department="CS"},
            new student{Name = "Ahd" , age = 14 , gpa = 2.4f,department="BIO"},
            new student{Name = "Medo" , age = 15 , gpa = 2.3f,department="IT"},
            new student{Name = "Nourhan" , age = 20 , gpa = 3.1f,department="CS"},

        };

            Ls.AddRange(fake);


        }
        public static void FakeDatawo(this List<workers> wo)
        {

            List<workers> fake = new List<workers>()
        {
            new workers{name = "Aml" , age = 20 ,salary=2000},
            new workers{name = "Ahmed" , age = 19,salary=3000},
            new workers{name = "Omar" , age = 18,salary=2500 },
            new workers{name = "Shahd" , age = 17,salary=3200 },
            new workers{name = "Aya" , age = 17,salary=3500 },


        };

            wo.AddRange(fake);

        }
        public static void FakeDatains(this List<instructor> IS)
        {

            List<instructor> fake = new List<instructor>()
        {
            new instructor{name = "Khaled" , age = 50 ,gender="male"},
            new instructor{name = "Abdo" , age = 55 ,gender="male"},
            new instructor{name = "Asala" , age = 44 ,gender="female"},
            new instructor{name = "Nagwa" , age = 56 ,gender="female"},
            new instructor{name = "Reda" , age = 60 ,gender="male"},
            new instructor{name = "Alla" , age = 47 ,gender="male"},



        };

            IS.AddRange(fake);

        }
    }
}
