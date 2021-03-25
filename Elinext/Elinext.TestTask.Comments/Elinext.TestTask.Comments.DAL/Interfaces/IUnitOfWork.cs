using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.DAL.Interfaces
{
	public interface IUnitOfWork
	{
		IRepository<Article> ArticleRepository { get; }
		IRepository<Comment> CommentRepository { get;  }
		IRepository<ReplyComment> ReplyCommentRepository { get;}
		void SaveChanges();
	}
}
