using Elinext.TestTask.Comments.BLL.Interfasces;
using Elinext.TestTask.Comments.BLL.Models;
using Elinext.TestTask.Comments.Interfaces;
using Elinext.TestTask.Comments.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.Providers
{
	public class CommentViewModelProvider : ICommentViewModelProvider
	{
		private readonly ICommentProvider commentProvider;
		public CommentViewModelProvider(ICommentProvider commentProvider)
		{
			this.commentProvider = commentProvider;
		}
		public List<CommentViewModel> GetAll()
		{
			List<CommentViewModel> comments = new List<CommentViewModel>();
			foreach (var comment in commentProvider.GetAll())
			{
				var newComment = new CommentViewModel();
				newComment.Id = comment.Id;
				newComment.CommentContent = comment.CommentContent;
				newComment.ArticleId = comment.ArticleId;
				newComment.Date = comment.Date;
				newComment.UserName = comment.UserName;
				comments.Add(newComment);
			}
			return comments;
		}
		public void InsertNew(CommentViewModel entity)
		{
			commentProvider.InsertNew(new CommentDTO
			{
				Id = entity.Id,
				ArticleId = entity.ArticleId,
				CommentContent = entity.CommentContent,
				Date = entity.Date,
				UserName = entity.UserName
			});
		}
	}
}
