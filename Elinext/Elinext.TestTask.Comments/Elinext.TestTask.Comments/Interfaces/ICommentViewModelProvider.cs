using Elinext.TestTask.Comments.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.Interfaces
{
	public interface ICommentViewModelProvider
	{
		public List<CommentViewModel> GetAll();
		public void InsertNew(CommentViewModel entity);
	}
}
