using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModels
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public virtual User Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        //public virtual ICollection<Tag> Tags { get; set; }
    }
}
