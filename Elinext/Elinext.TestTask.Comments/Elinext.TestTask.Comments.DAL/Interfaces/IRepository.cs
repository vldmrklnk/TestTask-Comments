using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.DAL.Interfaces
{
	public interface IRepository<T> where T : class
	{
		IList<T> GetAll();
		T GetById(int id);
		void InsertNew(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}
