using System;
namespace CompanySystem.BLL.Interface
{
	public interface IGeneric<T>
	{
		IEnumerable<T> GetAll();
		T Get(int id);
		int Create(T item);
		int Delete(T item);
		int Update(T item);
	}
}

