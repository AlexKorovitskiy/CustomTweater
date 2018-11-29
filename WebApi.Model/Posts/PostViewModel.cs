using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Model.Comment;
using WebApi.Model.Users;

namespace WebApi.Model.Posts
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public UserViewModel Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<CommentViewModel> Comments { get; set; }
        // public virtual ICollection<TagInfo> Tags { get; set; }
    }
}
