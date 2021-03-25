using Elinext.TestTask.Comments.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.DAL.Repositories
{
	public class ArticleRepository : IRepository<Article>
	{
		private readonly ArticleWithCommentsContext context;
		public ArticleRepository(ArticleWithCommentsContext context)
		{
			this.context = context;
		}
		public void Delete(Article entity)
		{
			context.Remove(entity);
		}

		public IList<Article> GetAll()
		{
			List<Article> articles = new List<Article>();
			foreach (var article in context.Articles)
			{
				var newArticle = new Article();
				newArticle.ArticleContent = article.ArticleContent;
				newArticle.Id = article.Id;
				newArticle.Theme = article.Theme;
				articles.Add(newArticle);
			}
			return articles;
		}

		public Article GetById(int id)
		{
			var article = new Article()
			{
				Id = context.Articles.FirstOrDefault(x => x.Id == id).Id,
				ArticleContent = context.Articles.FirstOrDefault(x => x.Id == id).ArticleContent,
				Theme = context.Articles.FirstOrDefault(x => x.Id == id).Theme
			};
			return article;
		}

		public void InsertNew(Article entity)
		{
			context.Articles.Add(entity);
		}

		public void Update(Article entity)
		{
			context.Articles.Update(entity);
		}
	}
}
