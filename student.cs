using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp69
{
    class student
    {
       public int age { get; set; }
        public string Name { get; set; }
       public  float gpa { get; set; }
        public string department { get; set; }
        public override string ToString()
        {
            return $"Student Data Name : {Name} , age {age} and gpa : {gpa} ,department {department} ";
        }


    }
}
