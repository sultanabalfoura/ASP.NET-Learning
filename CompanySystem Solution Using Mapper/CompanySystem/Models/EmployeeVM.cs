using System;
using CompanySystem.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace CompanySystem.PL.Models
{
	public class EmployeeVM
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [MinLength(5)]
        public string Name { get; set; }

        [MinLength(4)]
        public string City { get; set; }

        public string Email { get; set; }

        [Range(18, 33)]
        public int age { get; set; }

        [DataType(DataType.Currency)]
        public double Salary { get; set; }

        public int departmentId { get; set; }

        public Department? department { get; set; }
    }
}

