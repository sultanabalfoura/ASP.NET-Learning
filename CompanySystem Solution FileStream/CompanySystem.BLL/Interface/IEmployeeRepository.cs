using System;
using CompanySystem.DAL.Models;

namespace CompanySystem.BLL.Interface
{
	public interface IEmployeeRepository : IGeneric<Employee>
	{

		IEnumerable<Employee> Search(string name);
	}
}

