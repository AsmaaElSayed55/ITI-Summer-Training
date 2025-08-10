using BrightStars.Data;
using BrightStars.Models;
using Microsoft.AspNetCore.Mvc;

namespace BrightStars.Controllers
{
    public class EmployeesController : Controller
    {



        ApplicationDbContext context=new ApplicationDbContext();

        
        [HttpGet]
        public IActionResult GetIndexView()
        {
            return View("Index",context.Employees.ToList());
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(context.Employees.ToList());
        }

        [HttpGet]
        public IActionResult GetDetailsView(int id)
        {
            Employee employee=context.Employees.Find(id);
            if(employee==null)
            {
                return NotFound();
            }
            else
            {
                return View("Details",employee);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee employee = context.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                return View(employee);
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Employee employee = context.Employees.FirstOrDefault(emp => emp.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                return View(employee);
            }
        }

        
        [HttpGet]
        public IActionResult GetCreateView()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult AddNew(Employee emp)
        {
            if (ModelState.IsValid == true)
            {
                context.Employees.Add(emp);
                context.SaveChanges();
                return RedirectToAction(
                    "GetIndexView");
            }
            else 
                return View("Create" , emp);
        }

        public string CalculateAge(string name , int birhtYear)
        {
            return $"Hi , {name} . You are {DateTime.Now.Year-birhtYear}";
        }

        public string GreetVisitor()
        {
            return "Welcome to Bright Stars!";

        }

    }
}


