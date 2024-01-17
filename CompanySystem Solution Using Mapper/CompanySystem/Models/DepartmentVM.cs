using System;
using CompanySystem.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace CompanySystem.PL.Models
{
	public class DepartmentVM
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Code is Required for the Department")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Name is Required for the Department")]
        public string Name { get; set; }

        public ICollection<Employee> employees { get; set; } = new List<Employee>();
    }
}

