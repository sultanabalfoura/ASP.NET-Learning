using System;
using CompanySystem.BLL.Interface;
using CompanySystem.DAL.Context;
using CompanySystem.DAL.Models;

namespace CompanySystem.BLL.Repository
{
	public class EmployeeRepository : GenericRepository<Employee> , IEmployeeRepository
	{

        private readonly ApplicationDbContext _context;
		public EmployeeRepository(ApplicationDbContext context) : base(context)
		{
            _context = context;
		}

        public IEnumerable<Employee> Search(string name)
        {
            var emp = _context.Employee.Where(w => w.Name.ToLower().Contains(name)).ToList();
            return emp;
        }
    }
}

