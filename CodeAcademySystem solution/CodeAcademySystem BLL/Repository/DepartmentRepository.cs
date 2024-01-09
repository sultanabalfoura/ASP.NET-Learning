using System;
using System.Runtime.Intrinsics.Arm;
using CodeAcademySystem.BLL.Interface;
using CodeAcademySystem.DAL.Models;
using CodeAcademySystem_DAL.Context;

namespace CodeAcademySystem_BLL.Repository
{
	public class DepartmentRepository : IDepartmentRepository
	{
		private readonly ApplicationDbContext _context;

		public DepartmentRepository(ApplicationDbContext context)
		{
             _context = context;
		}

        public int Create(Department dep)
        {
            _context.Departments.Add(dep);
            return _context.SaveChanges();
        }

        public int Delete(Department dep)
        {
            _context.Departments.Remove(dep);
            return _context.SaveChanges();
        }

        public Department Get(int id) => _context.Departments.Find(id);


        public IEnumerable<Department> GetAll() => _context.Departments.ToList();
        
        public int Update(Department dep)
        {
            _context.Departments.Update(dep);
            return _context.SaveChanges();
        }
    }
}

