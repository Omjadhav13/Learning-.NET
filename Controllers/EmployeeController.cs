using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
namespace MyWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeController model)
        {
            if (ModelState.IsValid) {
                return RedirectToAction("Index");
             }
            return View(model);
        }

        [HttpGet]
        public  IActionResult Display(Employee model)
        {
            //Employee e = new Employee();
            //Console.WriteLine(e.EmpID);
            //Console.WriteLine(e.Name);
            //Console.WriteLine(e.);
            var emp = new Employee
            {
                EmpID = model.EmpID,
                Name=model.Name,
                Age=model.Age,
                DeptId=model.DeptId,
            };
            return View(model);
        }
    }
}
