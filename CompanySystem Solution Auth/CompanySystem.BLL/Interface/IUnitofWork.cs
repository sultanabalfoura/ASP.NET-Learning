using System;
namespace CompanySystem.BLL.Interface
{
	public interface IUnitofWork
	{
		public IDepartmentRepository departmentRepository { get; set; }
		public IEmployeeRepository employeeRepository { get; set; }
	}
}

