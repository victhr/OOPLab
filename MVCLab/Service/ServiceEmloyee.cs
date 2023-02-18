using MVCLab.Models;

namespace MVCLab.Service
{
    public class ServiceEmloyee
    {
        public EmployeeModel GetDetails(int EmployeeId)
        {
            EmployeeModel employee = new EmployeeModel()
            {
                EmployeeID = EmployeeId,
                Name = "Juan Perez",
                Gender = "Male",
                City = "Monterrey",
                Salary = 10000,
                Address = "Av de la Alegria"
            };

            return employee;
        }
    }
}
