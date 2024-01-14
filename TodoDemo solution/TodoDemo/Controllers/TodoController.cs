using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoDemo.Data;
using TodoDemo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoDemo.Controllers
{
    public class TodoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TodoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var todo = _context.Todos.ToList();
            return View(todo);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Todo todo)
        {
            if (ModelState.IsValid)
            {
                _context.Todos.Add(todo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(todo);
        }

        public IActionResult Update(int id)
        {
            var todo = _context.Todos.Find(id);
            return View(todo);
        }

        [HttpPost]
        public IActionResult Update(Todo todo)
        {
            if (ModelState.IsValid)
            {
                _context.Todos.Update(todo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(todo);
        }

        public IActionResult Delete(int id)
        {
            var todo = _context.Todos.Find(id);
            _context.Todos.Remove(todo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

