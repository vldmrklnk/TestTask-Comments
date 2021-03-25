using System;
using System.Collections.Generic;

#nullable disable

namespace Elinext.TestTask.Comments.DAL
{
    public partial class Article
    {
        public Article()
        {
            Comments = new HashSet<Comment>();
        }

        public long Id { get; set; }
        public string Theme { get; set; }
        public string ArticleContent { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
