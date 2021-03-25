using Elinext.TestTask.Comments.BLL.Interfasces;
using Elinext.TestTask.Comments.BLL.Models;
using Elinext.TestTask.Comments.DAL;
using Elinext.TestTask.Comments.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.BLL.Providers
{
	public class ReplyCommentProvider : IReplyCommentProvider
	{
		private readonly IUnitOfWork unitOfWork;
		public ReplyCommentProvider(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}
		public List<ReplyCommentDTO> GetAll()
		{
			List<ReplyCommentDTO> comments = new List<ReplyCommentDTO>();
			foreach (var comment in unitOfWork.ReplyCommentRepository.GetAll())
			{
				var newComment = new ReplyCommentDTO();
				newComment.Id = comment.Id;
				newComment.ReplyContent = comment.ReplyContent;
				newComment.MainCommentId= comment.MainCommentId;
				newComment.UserName = comment.UserName;
				comments.Add(newComment);
			}
			return comments;
		}
		public void InsertNew(ReplyCommentDTO entity)
		{
			unitOfWork.ReplyCommentRepository.InsertNew(new ReplyComment
			{
				Id = entity.Id,
				MainCommentId = entity.MainCommentId,
				ReplyContent = entity.ReplyContent,
				UserName = entity.UserName
			});
		}
	}
}
