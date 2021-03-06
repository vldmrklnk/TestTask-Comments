using Elinext.TestTask.Comments.BLL.Interfaces;
using Elinext.TestTask.Comments.BLL.Interfasces;
using Elinext.TestTask.Comments.BLL.Models;
using Elinext.TestTask.Comments.DAL.Interfaces;
using System;

namespace Elinext.TestTask.Comments.BLL.Services
{
	public class CommentCreator : ICommentCreator
	{
		private readonly ICommentProvider commentProvider;
		private readonly IUnitOfWork unityOfWork;
		public CommentCreator(ICommentProvider commentProvider, IUnitOfWork unityOfWork)
		{
			this.commentProvider = commentProvider;
			this.unityOfWork = unityOfWork;
		}
		public void CreatComment(CommentDTO comment, ArticleDTO article)
		{
			comment.ArticleId = article.Id;;
			comment.Date = DateTime.Now;
			commentProvider.InsertNew(comment);
			unityOfWork.SaveChanges();
		}
	}
}
