using System;
using System.ComponentModel.DataAnnotations;

namespace CompanySystem.DAL.Models
{
	public class Employee
	{
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public int age { get; set; }

        [DataType(DataType.Currency)]
        public double Salary { get; set; }

        public int departmentId { get; set; }

        public Department? department { get; set; }
    }
}

