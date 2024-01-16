using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanySystem.BLL.Interface;
using CompanySystem.DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanySystem.PL.Controllers
{
    public class EmployeeController : Controller
    {
        //private readonly IEmployeeRepository _EmployeeRepository;
        //private readonly IDepartmentRepository _departmentRepository;

        //public EmployeeController(IEmployeeRepository EmployeeRepository, IDepartmentRepository DepartmentRepository)
        //{
        //    _EmployeeRepository = EmployeeRepository;
        //    _departmentRepository = DepartmentRepository;
        //}

        private readonly IUnitofWork _unitofwork;
        public EmployeeController(IUnitofWork unitofwork)
        {
            _unitofwork = unitofwork;
        }


        // GET: /<controller>/
        public IActionResult Index(string name)
        {
            IEnumerable<Employee> emps;
            if (String.IsNullOrEmpty(name))
            {
                emps = _unitofwork.employeeRepository.GetAll();
            }
            else
            {
                emps = _unitofwork.employeeRepository.Search(name);
            }
            return View(emps);
        }

        public IActionResult Create()
        {
            ViewBag.Departments = _unitofwork.departmentRepository.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _unitofwork.employeeRepository.Create(emp);
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public IActionResult Update(int id)
        {
            var emp = _unitofwork.employeeRepository.Get(id);
            ViewBag.Departments = _unitofwork.departmentRepository.GetAll();

            return View(emp);
        }

        [HttpPost]
        public IActionResult Update(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _unitofwork.employeeRepository.Update(emp);
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public IActionResult Delete(int id)
        {
            var emp = _unitofwork.employeeRepository.Get(id);
            return View(emp);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            var emp = _unitofwork.employeeRepository.Get(id);
            _unitofwork.employeeRepository.Delete(emp);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var emp = _unitofwork.employeeRepository.Get(id.Value);
            return View(emp);

        }
    }
}

