using HomeWork03.Models;
using HomeWork03.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            Employee employee = new Employee(1, "Sara", "Gjuzelova", "2020", Position.Junior, 500);
            Division division = new Division(2, " Finance", employee);

            var employeeDetails = new EmployeeDetails
            {
                FullEmployeeName = employee.GetFullName(),

                Position = employee.Position,

                DateOfHire = employee.DateOfHire,

                DivisionName = division.Name
            };

            return View(employeeDetails);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
