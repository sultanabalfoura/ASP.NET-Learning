using System;
using CompanySystem.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanySystem.DAL.Context
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
		{
		}

		public DbSet<Department> Departments { get; set; }
		public DbSet<Employee> Employee { get; set; }

    }
}

