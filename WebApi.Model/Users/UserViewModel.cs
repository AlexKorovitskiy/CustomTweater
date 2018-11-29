using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Model.Comment;
using WebApi.Model.Posts;

namespace WebApi.Model.Users
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<PostViewModel> Posts { get; set; }
        public virtual ICollection<CommentViewModel> Comments { get; set; }
        public virtual ICollection<RoleViewModel> Rols { get; set; }
    }
}
