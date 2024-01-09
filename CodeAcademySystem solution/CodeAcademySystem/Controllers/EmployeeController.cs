using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademySystem.BLL.Interface;
using CodeAcademySystem.DAL.Models;
using CodeAcademySystem_BLL.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeAcademySystem.PL.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /<controller>/
        private readonly IEmployeeRepository _EmployeeRepo;

        //IEmployeeReposatory empo = new EmployeeRepository();
        //empendency injection
        public EmployeeController(IEmployeeRepository Employeerepo)
        {
            _EmployeeRepo = Employeerepo;
        }

        public IActionResult Index()
        {
            var emps = _EmployeeRepo.GetAll();
            return View(emps);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var emp = _EmployeeRepo.Get(id.Value);
            return View(emp);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if (emp == null)
            {
                return BadRequest();
            }
            _EmployeeRepo.Create(emp);

            return RedirectToAction("Index");
        }
    }
}

