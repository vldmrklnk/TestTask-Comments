using System;
using System.Collections.Generic;

#nullable disable

namespace Elinext.TestTask.Comments.DAL
{
    public partial class ReplyComment
    {
        public long MainCommentId { get; set; }
        public string ReplyContent { get; set; }
        public long Id { get; set; }
        public string UserName { get; set; }

        public virtual Comment MainComment { get; set; }
    }
}
