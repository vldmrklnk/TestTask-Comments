using Elinext.TestTask.Comments.Interfaces;
using Elinext.TestTask.Comments.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.Controllers
{
	public class ArticleController : Controller
	{
		private readonly IArticleViewModelProvider articleViewModelProvider;
		private readonly ICommentCreatorService commentCreatorService;
		private readonly ICommentViewModelProvider comment;
		private readonly IReplyCommentViewModelProvider replyComment;
		public ArticleController(IArticleViewModelProvider articleViewModelProvider, ICommentCreatorService commentCreatorService,
									ICommentViewModelProvider comment, IReplyCommentViewModelProvider replyComment)
		{
			this.articleViewModelProvider = articleViewModelProvider;
			this.commentCreatorService = commentCreatorService;
			this.comment = comment;
			this.replyComment = replyComment;
		}
		[HttpGet]
		[Route("article/{id:int}")]
		public IActionResult Article(int id)
		
		{
			ViewBag.PageModel = new PageModel(){ article = articleViewModelProvider.GetById(id),
												comments = comment.GetAll(),
													replyComments=replyComment.GetAll()
			};
			return View();
		}

		[HttpPost]
		[Route("article/{id:int}")]
		public IActionResult Article(PageModel pageModel, [FromRoute]int id)
		{

			if (pageModel.reply==null)
			{ 
			pageModel.article = articleViewModelProvider.GetById(id);
			commentCreatorService.CreatComment(pageModel);
			}
			else
			{
				pageModel.reply.MainCommentId = pageModel.comment.Id;
				commentCreatorService.CreateReply(pageModel.reply);
			}
			return RedirectToAction("Article");
		}

	}
}
