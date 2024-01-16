using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanySystem.BLL.Interface;
using CompanySystem.DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanySystem.PL.Controllers
{
    public class DepartmentController : Controller
    {
        //private readonly IDepartmentRepository _departmentRepository;

        //public DepartmentController(IDepartmentRepository departmentRepository)
        //{
        //    _departmentRepository = departmentRepository;
        //}

        private readonly IUnitofWork _unitofwork;
        public DepartmentController(IUnitofWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var dep = _unitofwork.departmentRepository.GetAll();
            return View(dep);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department dep)
        {
            if (ModelState.IsValid)
            {
                _unitofwork.departmentRepository.Create(dep);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Update(int id)
        {
            var dep = _unitofwork.departmentRepository.Get(id);
            return View(dep);
        }

        [HttpPost]
        public IActionResult Update(Department dep)
        {
            if (ModelState.IsValid)
            {
                _unitofwork.departmentRepository.Update(dep);
                return RedirectToAction("Index");
            }
            return View(dep);
        }

        public IActionResult Delete(int id)
        {
            var dep = _unitofwork.departmentRepository.Get(id);
            _unitofwork.departmentRepository.Delete(dep);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var dep = _unitofwork.departmentRepository.Get(id.Value);
            return View(dep);

        }
    }
}

