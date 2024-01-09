using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAcademySystem.BLL.Interface;
using CodeAcademySystem.DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeAcademySystem.PL.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: /<controller>/
        private readonly IDepartmentRepository _departmentRepo;

        //IDepartmentReposatory depo = new DepartmentRepository();
        //dependency injection
        public DepartmentController(IDepartmentRepository departmentrepo)
        {
            _departmentRepo = departmentrepo;
        }

        public IActionResult Index()
        {
            var deps = _departmentRepo.GetAll();
            return View(deps);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var dep = _departmentRepo.Get(id.Value);
            return View(dep);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department dep)
        {
            if (dep == null)
            {
                return BadRequest();
            }
            _departmentRepo.Create(dep);

            return RedirectToAction("Index");
        }
    }
}

