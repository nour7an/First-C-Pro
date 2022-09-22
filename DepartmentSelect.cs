using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp69
{
    class DepartmentSelect : Department
    {
        public int select(student x)
        {
            if (x.department == "CS")
            {
                return -1;
            }
            else if (x.department == "IT")
            {
                return 1;
            }
            else return 0;
        }
        public int  comparer(student x,student y)
        {
            if (x.gpa > y.gpa)
            {
                return -1;
            }
            else if (x.gpa < y.gpa)
            {
                return 1;
            }
            else return 0;
                
        }
    }
    class selectgender : Gender
    {
        public int selecti(instructor x)
        {
            if (x.gender == "male")
            {
                return 1;
            }
            else return -1;
        }




    }
}
    

