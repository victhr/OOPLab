using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab.LINQ
{
    internal class PopulationFake
    {
        public static List<Employee1> FillEmployee1()
        {
            List<Employee1> employees = new List<Employee1>()
            {
                new Employee1(){ Emp_id = 300, Emp_name = "Victor", Emp_Lang ="C#"},
                new Employee1(){ Emp_id = 301, Emp_name = "Javier", Emp_Lang ="Java"},
                new Employee1(){ Emp_id = 302, Emp_name = "Daniel", Emp_Lang ="Go"},
                new Employee1(){ Emp_id = 303, Emp_name = "Roberto", Emp_Lang ="C"},
                new Employee1(){ Emp_id = 304, Emp_name = "Mildred", Emp_Lang ="C#"},
                new Employee1(){ Emp_id = 305, Emp_name = "Ricardo", Emp_Lang ="Java"}
            };

            return employees;
        }

        public static List<Employee2> FillEmployee2()
        {
            List<Employee2> employees = new List<Employee2>()
            {
                new Employee2(){ Emp_id = 300, Emp_dept = "Designing", Emp_Salary =30000},
                new Employee2(){ Emp_id = 301, Emp_dept = "Developing", Emp_Salary =35000},
                new Employee2(){ Emp_id = 302, Emp_dept = "HR", Emp_Salary =30000},
                new Employee2(){ Emp_id = 303, Emp_dept = "Developing", Emp_Salary =60000}
            };
            return employees;
        }
    }
}
