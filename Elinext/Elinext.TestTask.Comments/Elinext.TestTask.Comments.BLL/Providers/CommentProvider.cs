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
	public class CommentProvider : ICommentProvider
	{
		private readonly IUnitOfWork unitOfWork;
		public CommentProvider(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}
		public List<CommentDTO> GetAll()
		{
			List<CommentDTO> comments = new List<CommentDTO>();
			foreach (var comment in unitOfWork.CommentRepository.GetAll())
			{
				var newComment = new CommentDTO();
				newComment.Id = comment.Id;
				newComment.CommentContent = comment.CommentContent;
				newComment.ArticleId = comment.ArticleId;
				newComment.Date = comment.Date;
				newComment.UserName = comment.UserName;
				comments.Add(newComment);
			}
			return comments;
		}
		public void InsertNew(CommentDTO entity)
		{
			unitOfWork.CommentRepository.InsertNew(new Comment
			{
				ArticleId = entity.ArticleId,
				CommentContent = entity.CommentContent,
				Date = entity.Date,
				UserName = entity.UserName
			});
		}
	}
}
