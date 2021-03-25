using Elinext.TestTask.Comments.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.BLL.Interfasces
{
	public interface IArticleProvider
	{
		public ArticleDTO GetById(int id);
	}
}
