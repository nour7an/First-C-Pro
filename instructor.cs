using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp69
{
    class instructor
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int age{get;set;}
        public override string ToString()
        {
            return $"Instructors Data Name : {name} , age {age} ,gender {gender} ";
        }
    }
}
