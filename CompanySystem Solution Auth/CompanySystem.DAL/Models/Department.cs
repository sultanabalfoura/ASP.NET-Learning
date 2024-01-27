using System;
using System.ComponentModel.DataAnnotations;

namespace CompanySystem.DAL.Models
{
	public class Department
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Code is Required for the Department")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Name is Required for the Department")]
        [MaxLength(50)] // nvarchar(max)
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<Employee> employees { get; set; } = new List<Employee>();
    }
}

