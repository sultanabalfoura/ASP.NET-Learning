using System;
using CodeAcademySystem.DAL.Models;

namespace CodeAcademySystem_BLL.Interface
{
	public interface IEmployeeRepository
	{
        IEnumerable<Employee> GetAll();
        Employee Get(int id);

        int Create(Employee emp);
        int Update(Employee emp);
        int Delete(Employee emp);
    }
}

