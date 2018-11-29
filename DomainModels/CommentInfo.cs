using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class CommentInfo
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UsertId { get; set; }
        public UserInfo Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public int PostId { get; set; }
        public PostInfo Post { get; set; }
    }
}
