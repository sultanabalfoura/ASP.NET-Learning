using System;
using CodeAcademySystem.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademySystem_DAL.Context
{
	public class ApplicationDbContext :DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
		{
		}

		public DbSet<Department> Departments { get; set; }
		public DbSet<Employee> Employees { get; set; }
	}
}

