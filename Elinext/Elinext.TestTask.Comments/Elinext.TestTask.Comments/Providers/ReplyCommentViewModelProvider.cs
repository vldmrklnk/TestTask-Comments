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
	public class ReplyCommentViewModelprovider : IReplyCommentViewModelProvider
	{
		private readonly IReplyCommentProvider replyCommentProvider;
		public ReplyCommentViewModelprovider(IReplyCommentProvider replyCommentProvider)
		{
			this.replyCommentProvider = replyCommentProvider;
		}
		public List<ReplyCommentViewModel> GetAll()
		{
			List<ReplyCommentViewModel> comments = new List<ReplyCommentViewModel>();
			foreach (var comment in replyCommentProvider.GetAll())
			{
				var newComment = new ReplyCommentViewModel();
				newComment.Id = comment.Id;
				newComment.ReplyContent = comment.ReplyContent;
				newComment.MainCommentId = comment.MainCommentId;
				newComment.UserName = comment.UserName;
				comments.Add(newComment);
			}
			return comments;
		}
		public void InsertNew(ReplyCommentViewModel entity)
		{
			replyCommentProvider.InsertNew(new ReplyCommentDTO
			{
				Id = entity.Id,
				MainCommentId = entity.MainCommentId,
				ReplyContent = entity.ReplyContent,
				UserName = entity.UserName
			});
		}
	}
}
