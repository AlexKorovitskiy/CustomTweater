using System;
using System.Collections.Generic;

namespace DomainModels
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<PostInfo> Posts { get; set; }
        public virtual ICollection<CommentInfo> Comments { get; set; }
        public virtual ICollection<RoleInfo> Rols { get; set; }
    }
}
