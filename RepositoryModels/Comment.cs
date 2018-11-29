using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModels
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public User Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
