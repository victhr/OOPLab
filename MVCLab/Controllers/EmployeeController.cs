using Microsoft.AspNetCore.Mvc;

namespace MVCLab.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Method1()
        {
            TempData["Name"] = "Juan Perez";
            TempData["Age"] = 20;

            //throw new Exception("Test Exception Employee Controller");
            return View();
        }

        public IActionResult Method2()
        {
            string name;
            int age;

            if (TempData.ContainsKey("Name"))
                name = TempData["Name"].ToString();
            if (TempData.ContainsKey("Age"))
                age = int.Parse(TempData["Age"].ToString());

            //TempData.Keep();

            return View();
        }

        public IActionResult Method3()
        {
            string name;
            int age;

            if (TempData.ContainsKey("Name"))
                name = TempData["Name"].ToString();
            if (TempData.ContainsKey("Age"))
                age = int.Parse(TempData["Age"].ToString());

            return View();
        }
    }
}
