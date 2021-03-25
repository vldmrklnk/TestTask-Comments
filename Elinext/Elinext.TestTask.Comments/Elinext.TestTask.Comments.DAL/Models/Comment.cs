using System;
using System.Collections.Generic;

#nullable disable

namespace Elinext.TestTask.Comments.DAL
{
    public partial class Comment
    {
        public Comment()
        {
            ReplyComments = new HashSet<ReplyComment>();
        }

        public long Id { get; set; }
        public string CommentContent { get; set; }
        public long ArticleId { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }

        public virtual Article Article { get; set; }
        public virtual ICollection<ReplyComment> ReplyComments { get; set; }
    }
}
