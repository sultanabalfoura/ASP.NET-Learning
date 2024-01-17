using System;
using System.ComponentModel.DataAnnotations;

namespace CompanySystem.DAL.Models
{
	public class Department
	{
        public int Id { get; set; }

        public string Code { get; set; }

        [MaxLength(50)] // nvarchar(max)
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<Employee> employees { get; set; } = new List<Employee>();
    }
}

