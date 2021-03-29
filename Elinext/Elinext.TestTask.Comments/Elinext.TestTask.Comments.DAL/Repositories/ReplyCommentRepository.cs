using Elinext.TestTask.Comments.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.DAL.Repositories
{
	public class ReplyCommentRepository : IRepository<ReplyComment>
	{
		private readonly ArticleWithCommentsContext context;
		public ReplyCommentRepository(ArticleWithCommentsContext context)
		{
			this.context = context;
		}
		public void Delete(ReplyComment entity)
		{
			context.ReplyComments.Remove(entity);
		}

		public IList<ReplyComment> GetAll()
		{
			List<ReplyComment> replyComments = new List<ReplyComment>();
			foreach (var comment in context.ReplyComments)
			{
				var replyComment = new ReplyComment();
				replyComment.MainCommentId = comment.MainCommentId;
				replyComment.ReplyContent = comment.ReplyContent;
				replyComment.Id = comment.Id;
				replyComment.UserName = comment.UserName;
				replyComments.Add(replyComment);
			}
			return replyComments;
		}

		public ReplyComment GetById(int id)
		{
			var comment = new ReplyComment()
			{
				Id = context.ReplyComments.FirstOrDefault(x => x.Id == id).Id,
				MainCommentId = context.ReplyComments.FirstOrDefault(x => x.Id == id).MainCommentId,
				ReplyContent = context.ReplyComments.FirstOrDefault(x => x.Id == id).ReplyContent,
				UserName = context.ReplyComments.FirstOrDefault(x => x.Id == id).UserName
			};
			return comment;
		}

		public void InsertNew(ReplyComment entity)
		{
			context.ReplyComments.Add(entity);
		}

		public void Update(ReplyComment entity)
		{
			context.ReplyComments.Update(entity);
		}
	}
}
