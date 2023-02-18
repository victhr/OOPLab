using Microsoft.AspNetCore.Mvc;
using MVCLab.Filters;
using MVCLab.Models;
using MVCLab.Service;
using System.Diagnostics;

namespace MVCLab.Controllers
{
    //Exception Filter by Controller
    //[TypeFilter(typeof(CustomExceptionFilter))]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ServiceEmloyee serviceEmloyee = new ServiceEmloyee();
            EmployeeModel modelEmployee = serviceEmloyee.GetDetails(102);

            //ViewData
            ViewData["Employee"] = modelEmployee;
            ViewData["Header"] = "Employee Details";
            
            return View();
        }

        //Exception Filter by action
        //[TypeFilter(typeof(CustomExceptionFilter))]
        public IActionResult ViewViewBagTest()
        {
            ServiceEmloyee serviceEmloyee = new ServiceEmloyee();
            EmployeeModel employeeModel = serviceEmloyee.GetDetails(101);

            ViewBag.Employee = employeeModel;
            ViewBag.Header = "Employee Details ViewBag Test";

             //throw new Exception("Test Exception");
           return View();
        }

        public IActionResult Privacy()
        {
            List<Product> Lstproducts = new List<Product>()
            {
                new Product { ProductId = 1, Name="Product 1", Category = "Category 1", Description = "Description Product 1", Price = 10},
                 new Product { ProductId = 2, Name="Product 2", Category = "Category 1", Description = "Description Product 2", Price = 10},
                  new Product { ProductId = 3, Name="Product 3", Category = "Category 1", Description = "Description Product 3", Price = 10},
                   new Product { ProductId = 4, Name="Product 4", Category = "Category 2", Description = "Description Product 4", Price = 10},
                    new Product { ProductId = 5, Name="Product 5", Category = "Category 2", Description = "Description Product 5", Price = 10},
                     new Product { ProductId = 6, Name="Product 6", Category = "Category 2", Description = "Description Product 6", Price = 10}

            };

            //throw new Exception("Test Exception");
            return View(Lstproducts);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}