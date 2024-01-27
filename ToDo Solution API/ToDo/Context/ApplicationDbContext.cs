using System;
using Microsoft.EntityFrameworkCore;
using ToDo.Models;

namespace ToDo.Context
{
	public class ApplicationDbContext : DbContext
	{

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base (options)
		{
		}

		public DbSet<Todo> todos { set; get; }
	}
}

