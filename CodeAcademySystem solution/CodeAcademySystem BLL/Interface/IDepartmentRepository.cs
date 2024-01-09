using System;
using CodeAcademySystem.DAL.Models;

namespace CodeAcademySystem.BLL.Interface
{
	public interface IDepartmentRepository
	{
		IEnumerable<Department> GetAll();
		Department Get(int id);

		int Create(Department dep);
		int Update(Department dep);
		int Delete(Department dep);

	}
}

