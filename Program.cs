using System;
using System.Collections.Generic;

namespace ConsoleApp69
{
    class Program
    {
        public  static void genaralsort(List<student> Ls,Isort sort)
        {
            for (int i=0;i<Ls.Count-1;i++)
            { for (int j = i + 1; j < Ls.Count - 1; j++)
                {
                    if (sort.compare(Ls[i], Ls[j]) > 0)
                    {
                        var temp = Ls[i];
                        Ls[i] = Ls[j];
                        Ls[j] = temp;

                    }
                } }
        }public static void salarysort(List<workers> wo,Isort sort)
        {
            for (int i=0;i<wo.Count-1;i++)
            {
                for (int j=i+1;j<wo.Count-1;j++)
                {
                    if (sort.compar(wo[i], wo[j])>0)
                    {
                        var temp = wo[i];
                        wo[i] = wo[j];
                        wo[j] = temp;
                    }
                }
            }
        }
        public static void selectdepartment(List <student> Ls,Department Dp)
        {
            
            for(int i=0;i<Ls.Count-1;i++)
            {
                if(Dp.select(Ls[i])>0)
                {

                    Console.Write("name :" + " "+Ls[i].Name +" "+ "age :" + Ls[i].age + " "+"department :" + " "+ Ls[i].department + " "+"GBA :" + " "+ Ls[i].gpa );
                    Console.WriteLine();
                    
                }
            }
            
        }
        public static void firstrank(List<student> Ls, Department Dp)
        {

            for (int i = 0; i < Ls.Count - 1; i++)
            {
                if (Dp.select(Ls[i]) > 0)
                {

                    for (int j = i + 1; j < Ls.Count - 1; j++)
                    {
                        if (Dp.comparer(Ls[i], Ls[j]) > 0)
                        {
                            var temp = Ls[i];
                            Ls[i] = Ls[j];
                            Ls[j] = temp;
                        }
                    }



                }
                if (Dp.select(Ls[i]) < 0)
                {
                    for (int j = i + 1; j < Ls.Count - 1; j++)
                    {
                        if (Dp.comparer(Ls[i], Ls[j]) > 0)
                        {
                            var temp = Ls[i];
                            Ls[i] = Ls[j];
                            Ls[j] = temp;
                        }
                    }

                }
                if (Dp.select(Ls[i]) == 0)
                {
                    for (int j = i + 1; j < Ls.Count - 1; j++)
                    {
                        if (Dp.comparer(Ls[i], Ls[j]) > 0)
                        {
                            var temp = Ls[i];
                            Ls[i] = Ls[j];
                            Ls[j] = temp;
                        }
                    }
                }
                

            }
            for(int i=0;i<3;i++)
            {
                Console.WriteLine(Ls[i]);
            }

        }
        public static void selectgender(List<instructor> IS, Gender D)
        {

            for (int i = 0; i < IS.Count ; i++)
            {
                if (D.selecti(IS[i]) > 0)
                {

                    Console.Write("name :" + " " + IS[i].name + " " + "age :" + IS[i].age + " " + "gender :" + " " + IS[i].gender );
                    Console.WriteLine();

                }
            }

        }

        static void Main(string[] args)
        {
            List<student> students = new List<student>();
            students.FakeData();
            List<workers> worker = new List<workers>();
            worker.FakeDatawo();
            List<instructor> instructors = new List<instructor>();
            instructors.FakeDatains();
            studentsortbyage s = new studentsortbyage();
            DepartmentSelect d = new DepartmentSelect();
            studentsortbyage w = new studentsortbyage();
            selectgender n = new selectgender();
            DepartmentSelect t = new DepartmentSelect();
            
            
            genaralsort(students, s);
            
            salarysort(worker, w);
            selectdepartment(students, d);//select student from IT department
            Console.WriteLine("***********************************************************************************");



            List<student> Top3 = new List<student>();
            List<workers> Top2 = new List<workers>();
            Top2.AddRange(worker.GetRange(0,3));


            Top3.AddRange(students);// Sort student 

            Top3.Print();
            Console.WriteLine("***********************************************************************************");

            Top2.Printworker();//Display the largest three worker in salary
            Console.WriteLine("***********************************************************************************");
            selectgender(instructors, n);//select male gender
            Console.WriteLine("***********************************************************************************");
            firstrank(students, t);//display first rank
            
           

        }
    }
}
