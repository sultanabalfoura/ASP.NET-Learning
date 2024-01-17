using System;
using CompanySystem.BLL.Interface;
using CompanySystem.DAL.Context;

namespace CompanySystem.BLL.Repository
{
	public class UnitofWork : IUnitofWork
	{
        public IDepartmentRepository departmentRepository { get; set; }
        public IEmployeeRepository employeeRepository { get; set; }

        public UnitofWork(ApplicationDbContext context)
		{
            departmentRepository = new DepartmentRepository(context);
            employeeRepository = new EmployeeRepository(context);
		}

        
    }
}

