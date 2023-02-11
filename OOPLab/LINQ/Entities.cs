using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab.LINQ
{
    internal class Entities
    {
    }

    public class Employee1
    {
        public int Emp_id { get; set; }
        public string? Emp_name { get; set; }
        public string? Emp_Lang{ get; set; }

    }

    public class Employee2
    {
        public int Emp_id { get; set; }
        public string? Emp_dept { get; set; }
        public int? Emp_Salary { get; set; }
    }

    public class outputResult
    {
        public int Emp_id { get; set; }
        public string? Emp_name { get; set; }
        public int? Emp_Salary { get; set; }
        public string? Emp_dept { get; set; }
    }
}
