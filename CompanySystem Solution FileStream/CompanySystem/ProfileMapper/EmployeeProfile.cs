using System;
using AutoMapper;
using CompanySystem.DAL.Models;
using CompanySystem.PL.Models;

namespace CompanySystem.PL.ProfileMapper
{
	public class EmployeeProfile : Profile
	{
		public EmployeeProfile()
		{
			CreateMap<EmployeeVM, Employee>();
		}
	}
}

