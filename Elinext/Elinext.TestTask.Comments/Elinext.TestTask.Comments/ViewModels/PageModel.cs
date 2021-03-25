using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.ViewModels
{
	public class PageModel
	{
		public CommentViewModel comment { get; set; }
		public ArticleViewModel article { get; set; }
		public List<CommentViewModel> comments { get; set; }
	}
}
