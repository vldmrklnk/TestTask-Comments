using Elinext.TestTask.Comments.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elinext.TestTask.Comments.DAL.Repositories;

namespace Elinext.TestTask.Comments.DAL.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ArticleWithCommentsContext context;
		public UnitOfWork(ArticleWithCommentsContext context)
		{
			this.context = context;
		}
		public IRepository<Article> ArticleRepository
		{
			get
			{
				return new ArticleRepository(context);
			}
		}

		public IRepository<Comment> CommentRepository
		{
			get
			{
				return new CommentRepository(context);
			}
		}

		public IRepository<ReplyComment> ReplyCommentRepository
		{
			get
			{
				return new ReplyCommentRepository(context);
			}
		}
		public void SaveChanges()
		{
			context.SaveChanges();
		}
	}
}
