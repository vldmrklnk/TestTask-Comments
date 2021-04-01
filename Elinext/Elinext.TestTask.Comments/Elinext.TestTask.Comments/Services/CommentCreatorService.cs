using Elinext.TestTask.Comments.BLL.Interfaces;
using Elinext.TestTask.Comments.BLL.Models;
using Elinext.TestTask.Comments.Interfaces;
using Elinext.TestTask.Comments.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.Services
{
	public class CommentCreatorService : ICommentCreatorService
	{
		private readonly ICommentCreator commentCreator;
		public CommentCreatorService(ICommentCreator commentCreator)
		{
			this.commentCreator = commentCreator;
		}
		public void CreatComment(PageModel pageModel)
		{
			commentCreator.CreatComment(
				new CommentDTO { CommentContent = pageModel.comment.CommentContent, UserName= pageModel.comment.UserName},
				new ArticleDTO { ArticleContent = pageModel.article.ArticleContent, Theme = pageModel.article.Theme, Id = pageModel.article.Id }
				);
		}
	}
}
