using Elinext.TestTask.Comments.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.Interfaces
{
	public interface ICommentCreatorService
	{
		public void CreatComment(PageModel pageModel);
		public void CreateReply(ReplyCommentViewModel reply);
	}
}
