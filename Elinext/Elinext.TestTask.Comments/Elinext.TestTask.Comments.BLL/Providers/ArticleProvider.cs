using Elinext.TestTask.Comments.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elinext.TestTask.Comments.DAL.Interfaces;
using Elinext.TestTask.Comments.BLL.Interfasces;

namespace Elinext.TestTask.Comments.BLL.Providers
{
	public class ArticleProvider : IArticleProvider
	{
		private readonly IUnitOfWork unitOfWork;
		public ArticleProvider(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		public ArticleDTO GetById(int id)
		{
			ArticleDTO articleDTO = new ArticleDTO()
			{
				Id = unitOfWork.ArticleRepository.GetById(id).Id,
				ArticleContent = unitOfWork.ArticleRepository.GetById(id).ArticleContent,
				Theme = unitOfWork.ArticleRepository.GetById(id).Theme
			};
			return articleDTO;
		}
	}
}
