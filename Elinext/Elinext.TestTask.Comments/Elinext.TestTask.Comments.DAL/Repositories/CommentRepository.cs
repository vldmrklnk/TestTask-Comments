using Elinext.TestTask.Comments.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.DAL.Repositories
{
	public class CommentRepository : IRepository<Comment>
	{
		private readonly ArticleWithCommentsContext context;
		public CommentRepository(ArticleWithCommentsContext context)
		{
			this.context = context;
		}
		public void Delete(Comment entity)
		{
			context.Comments.Remove(entity);
		}

		public IList<Comment> GetAll()
		{
			List<Comment> comments = new List<Comment>();
			foreach (var comment in context.Comments)
			 {
				var newComment = new Comment();
				newComment.Id = comment.Id;
				newComment.CommentContent = comment.CommentContent;
				newComment.ArticleId = comment.ArticleId;
				newComment.Date = comment.Date;
				newComment.UserName = comment.UserName;
				newComment.ParentCommentId = comment.ParentCommentId;
				comments.Add(newComment);
			}
			return comments;
		}

		public Comment GetById(int id)
		{
			var comment = new Comment()
			{
				Id = context.Comments.FirstOrDefault(x => x.Id == id).Id,
				CommentContent = context.Comments.FirstOrDefault(x => x.Id == id).CommentContent,
				ArticleId = context.Comments.FirstOrDefault(x => x.Id == id).ArticleId,
				Date= context.Comments.FirstOrDefault(x => x.Id == id).Date,
				UserName = context.Comments.FirstOrDefault(x => x.Id == id).UserName,
				ParentCommentId = context.Comments.FirstOrDefault(x => x.Id == id).ParentCommentId
			};
			return comment;
		}

		public void InsertNew(Comment entity)
		{
			context.Comments.Add(entity);
		}

		public void Update(Comment entity)
		{
			context.Comments.Update(entity);
		}
	}
}
