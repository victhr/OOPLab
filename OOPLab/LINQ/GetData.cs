using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab.LINQ
{
    internal class GetData
    {
        public List<outputResult> QueryExtraction(List<Employee1> LstEmp1, List<Employee2> LstEmp2)
        {
            List<outputResult> LstsRes = new List<outputResult>();

            var res = from e1 in LstEmp1
                      join e2 in LstEmp2
                         on e1.Emp_id equals e2.Emp_id
                      select new
                      {
                          Emp_name = e1.Emp_name,
                          Emp_Salay = e2.Emp_Salary,
                          Emp_id = e2.Emp_id,
                      };

            foreach (var val in res)
            {
                outputResult item =
                    new outputResult
                    { Emp_id = val.Emp_id, Emp_name = val.Emp_name, Emp_Salary = val.Emp_Salay};

                LstsRes.Add(item); 
            }

            return LstsRes;
        }

        public List<outputResult> MethodExtraction(List<Employee1> LstEmp1, List<Employee2> LstEmp2)
        {
            List<outputResult> LstsRes = new List<outputResult>();

            var res = LstEmp1.Join(LstEmp2,
                e1 => e1.Emp_id, e2 => e2.Emp_id,
                (e1, e2) =>
                new
                {
                    Emp_name = e1.Emp_name,
                    Emp_Dept = e2.Emp_dept,
                    Emp_Id = e2.Emp_id
                });

            foreach (var val in res)
            {
                outputResult item =
                    new outputResult
                    { Emp_id = val.Emp_Id, Emp_name = val.Emp_name, Emp_dept = val.Emp_Dept };

                LstsRes.Add(item);
            }

            return LstsRes;
        }
    }
}
