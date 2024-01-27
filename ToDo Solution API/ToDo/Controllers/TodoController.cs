using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using ToDo.Context;
using ToDo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class TodoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public TodoController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        #region api test GetAll
        //[HttpGet]
        //public IEnumerable<Todo> GetALL()
        //{
        //    var todos = new List<Todo>()
        //    {
        //        new Todo{Id=1, Name= "Study API" , Description="study api"},
        //        new Todo{Id=2, Name= "Study MVC" , Description="study MVC"},
        //        new Todo{Id=3, Name= "Study MVP" , Description="study MVP"},
        //    };

        //    return todos;
        //}
        #endregion
        [HttpGet]
        [ProducesResponseType(statusCode: 200)]
        [ProducesResponseType(statusCode: 404)]
        public ActionResult GetAll()
        {
           var todos = _context.todos.ToList();
            if (todos.Count > 0)
            {
                return Ok(todos);
            }
            return NotFound();
        }

        [HttpGet("id:int")]
        [ProducesResponseType(statusCode: 200)]
        [ProducesResponseType(statusCode: 404)]
        public ActionResult Get(int id)
        {
            var todo = _context.todos.Find(id);
            if (todo is not null)
            {
                return Ok(todo);
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult Create(Todo todo)
        {
            if (ModelState.IsValid)
            {
                _context.todos.Add(todo);
                _context.SaveChanges();
                return Ok(todo);
            }
            return NotFound();
        }

        //[HttpGet("id:int")]
        //public ActionResult Update(int id)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.todos.Find(id);
        //        _context.SaveChanges();
        //        return Ok(id);
        //    }
        //    return NotFound();
        //}

        [HttpPut]
        public ActionResult Update(int id)
        {
            Todo todo = _context.todos.Find(id);
            if(todo == null)
            {
                return NotFound();
            }

            _context.Update(todo);
            _context.SaveChanges();
            return Ok(_context.todos.ToList());
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            Todo todo = _context.todos.Find(id);
            _context.Remove(todo);
            _context.SaveChanges();
            return Ok(_context.todos.ToList());
        }
    }
}

