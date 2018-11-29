using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model.Posts;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        IPostService postService;

        public HomeController(IPostService postService)
        {
            this.postService = postService;
        }

        [HttpGet]
        [Authorize]
        [Route("/posts")]
        public IEnumerable<PostViewModel> GetPosts()
        {
            var domainModels = this.postService.GetModelCollections();
            return AutoMapper.Mapper.Map<IEnumerable<PostInfo>, IEnumerable<PostViewModel>>(domainModels);
        }

        [HttpPost]
        [Authorize]
        [Route("/create_posts")]
        public void CreatePost([FromBody] PostViewModel post)
        {
            //post.UserId=User.
            var domainModel = AutoMapper.Mapper.Map<PostViewModel, PostInfo>(post);
            this.postService.Create(domainModel);
        }
    }
}