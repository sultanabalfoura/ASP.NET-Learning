using System;
using CompanySystem.BLL.Interface;
using CompanySystem.DAL.Context;
using CompanySystem.DAL.Models;

namespace CompanySystem.BLL.Repository
{
	public class DepartmentRepository : GenericRepository<Department> , IDepartmentRepository
	{

		public DepartmentRepository(ApplicationDbContext context) :base(context)
		{
		}
	}
}

