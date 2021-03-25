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
		public ArticleController(IArticleViewModelProvider articleViewModelProvider, ICommentCreatorService commentCreatorService,
									ICommentViewModelProvider comment)
		{
			this.articleViewModelProvider = articleViewModelProvider;
			this.commentCreatorService = commentCreatorService;
			this.comment = comment;
		}
		[HttpGet]
		[Route("article/{id:int}")]
		public IActionResult Article(int id)
		
		{
			ViewBag.PageModel = new PageModel(){ article = articleViewModelProvider.GetById(id),
												comments = comment.GetAll()};
			return View();
		}

		[HttpPost]
		[Route("article/{id:int}")]
		public IActionResult Article(PageModel pageModel,[FromRoute]int id)
		{
			pageModel.article = articleViewModelProvider.GetById(id);
			commentCreatorService.CreatComment(pageModel);
			return RedirectToAction("Article");
		}
	}
}
