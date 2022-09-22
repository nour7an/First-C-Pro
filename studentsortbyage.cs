using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp69
{
    class studentsortbyage :Isort
    {
        public int compare(student x,student y)
        {
            if (x.age > y.age)
            {
                return -1;
            }
            else if (x.age < y.age)
            {
                return 1;
            }
            else return 0;
        }
        public int compar(workers x,workers y)
        {
            if (x.salary > y.salary)
            {
                return -1;

            }
            else if (x.salary < y.salary)
            {
                return 1;
            }
            else return 0;
        }
    }
}
