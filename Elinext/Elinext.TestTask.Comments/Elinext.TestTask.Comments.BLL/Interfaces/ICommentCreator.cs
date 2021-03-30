using Elinext.TestTask.Comments.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.BLL.Interfaces
{
	public interface ICommentCreator
	{
		public void CreatComment(CommentDTO comment, ArticleDTO article);
		public void CreateReply(ReplyCommentDTO replyComment);
	}
}
