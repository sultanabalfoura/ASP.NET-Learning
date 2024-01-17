using System;
using CompanySystem.BLL.Interface;
using CompanySystem.DAL.Context;
using CompanySystem.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanySystem.BLL.Repository
{
	public class GenericRepository<T> : IGeneric<T> where T : class
	{
        private readonly ApplicationDbContext _context;

		public GenericRepository(ApplicationDbContext context)
		{
            _context = context;
		}

        public int Create(T item)
        {
            _context.Set<T>().Add(item);
            return _context.SaveChanges();
        }

        public int Delete(T item)
        {
            _context.Set<T>().Remove(item);
            return _context.SaveChanges();
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            if(typeof(T) == typeof(Employee))
            {
                return (IEnumerable<T>)_context.Employee.Include(e => e.department).ToList();
            }
            else
            {
                return _context.Set<T>().ToList();

            }
        }

        public int Update(T item)
        {
            _context.Set<T>().Update(item);
            return _context.SaveChanges();
        }
    }
}

