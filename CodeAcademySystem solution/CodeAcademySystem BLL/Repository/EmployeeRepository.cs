using System;
using CodeAcademySystem_DAL.Context;
using CodeAcademySystem.DAL.Models;

namespace CodeAcademySystem_BLL.Repository
{
	public class EmployeeRepository
	{
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Create(Employee emp)
        {
            _context.Employees.Add(emp);
            return _context.SaveChanges();
        }

        public int Delete(Employee emp)
        {
            _context.Employees.Remove(emp);
            return _context.SaveChanges();
        }

        public Employee Get(int id) => _context.Employees.Find(id);


        public IEnumerable<Employee> GetAll() => _context.Employees.ToList();

        public int Update(Employee emp)
        {
            _context.Employees.Update(emp);
            return _context.SaveChanges();
        }
    }
}

