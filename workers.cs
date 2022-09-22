using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp69
{
    class workers
    {
        public string name { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
        public override string ToString()
        {
            return $"workers Data Name : {name} , age {age} ,salary {salary} ";
        }

    }
}
