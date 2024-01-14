using System;
using Microsoft.EntityFrameworkCore;
using TodoDemo.Models;

namespace TodoDemo.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Todo>().Property(x => x.isFinished)
				.HasDefaultValue(false);
        }
        public DbSet<Todo> Todos { get; set; }
	}
}

