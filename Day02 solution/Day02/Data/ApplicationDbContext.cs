using System;
using Day02.Models;
using Microsoft.EntityFrameworkCore;

namespace Day02.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
		{

		}

		public DbSet<Employee> Employees { get; set; }

	}
}

