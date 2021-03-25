using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elinext.TestTask.Comments.BLL.Models
{
	public class CommentDTO
	{
        public long Id { get; set; }
        public string CommentContent { get; set; }
        public long ArticleId { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
    }
}
