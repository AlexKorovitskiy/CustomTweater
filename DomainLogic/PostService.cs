using DomainModels;
using RepositoryModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLogic
{
    public class PostService : AbstractService<PostInfo, Post>, IPostService
    {
        protected IEntityRepository<Post> BaseRepository { get; set; }

        public PostService(IEntityRepository<Post> postRepository)
            : base(postRepository)
        {
            BaseRepository = postRepository;
        }
    }
}
