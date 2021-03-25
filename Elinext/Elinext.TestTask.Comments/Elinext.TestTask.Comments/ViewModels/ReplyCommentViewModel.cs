using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.ViewModels
{
	public class ReplyCommentViewModel
	{
		public long MainCommentId { get; set; }
		public string ReplyContent { get; set; }
		public long Id { get; set; }
		public string UserName { get; set; }
	}
}
