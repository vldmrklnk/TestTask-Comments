using Elinext.TestTask.Comments.BLL.Interfasces;
using Elinext.TestTask.Comments.Interfaces;
using Elinext.TestTask.Comments.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.Providers
{
	public class ArticleViewModelProvider : IArticleViewModelProvider
	{
		private readonly IArticleProvider articleProvider;
		public ArticleViewModelProvider(IArticleProvider articleProvider)
		{
			this.articleProvider = articleProvider;
		}

		public ArticleViewModel GetById(int id)
		{
			ArticleViewModel article = new ArticleViewModel()
			{
				Id = articleProvider.GetById(id).Id,
				ArticleContent = articleProvider.GetById(id).ArticleContent,
				Theme = articleProvider.GetById(id).Theme
			};
			return article;
		}
	}
}
