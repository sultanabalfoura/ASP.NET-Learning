using System;
using AutoMapper;
using CompanySystem.DAL.Models;
using CompanySystem.PL.Models;

namespace CompanySystem.PL.ProfileMapper
{
	public class DepartmentProfile : Profile
	{
		public DepartmentProfile()
		{
			CreateMap<DepartmentVM, Department>();
		}
	}
}

