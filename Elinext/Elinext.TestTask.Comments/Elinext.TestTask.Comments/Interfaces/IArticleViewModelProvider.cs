using Elinext.TestTask.Comments.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.Interfaces
{
	public interface IArticleViewModelProvider
	{
		public ArticleViewModel GetById(int id);
	}
}
