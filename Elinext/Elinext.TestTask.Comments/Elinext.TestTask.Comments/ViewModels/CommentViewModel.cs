using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.ViewModels
{
	public class CommentViewModel
	{
        public long Id { get; set; }
        public string CommentContent { get; set; }
        public long ArticleId { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
    }
}
