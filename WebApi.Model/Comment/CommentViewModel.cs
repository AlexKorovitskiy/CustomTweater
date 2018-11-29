using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Model.Posts;
using WebApi.Model.Users;

namespace WebApi.Model.Comment
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UsertId { get; set; }
        public UserViewModel Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public int PostId { get; set; }
        public PostViewModel Post { get; set; }
    }
}
