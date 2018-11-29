using AutoMapper;
using DomainLogic;
using DomainModels;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using RepositoryModels;
using System;
using WebApi.Model.Comment;
using WebApi.Model.Posts;
using WebApi.Model.Users;

namespace Dependencies
{
    public static class Initializer
    {
        public static void AddCustumTewaterDependencies(this IServiceCollection services)
        {
            //Services
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IPostService, PostService>();

            //Repositories
            services.AddTransient<IEntityRepository<User>, UserRepository>();
            services.AddTransient<IEntityRepository<Post>, PostRepository>();
        }

        public static void AddCustumTewaterMappConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(x =>
            {
                x.CreateMap<UserViewModel, UserInfo>();
                x.CreateMap<PostViewModel, PostInfo>();
                x.CreateMap<CommentViewModel, CommentInfo>();
                x.CreateMap<RoleViewModel, RoleInfo>();

                x.CreateMap<UserInfo, UserViewModel>();
                x.CreateMap<PostInfo, PostViewModel>();
                x.CreateMap<CommentInfo, CommentViewModel>();
                x.CreateMap<RoleInfo, RoleViewModel>();

                x.CreateMap<UserInfo, User>();
                x.CreateMap<PostInfo, Post>();
                x.CreateMap<CommentInfo, Comment>();
                x.CreateMap<RoleInfo, Role>();

                x.CreateMap<User, UserInfo>();
                x.CreateMap<Post, PostInfo>();
                x.CreateMap<Comment, CommentInfo>();
                x.CreateMap<Role, RoleInfo>();

            });
        }
    }
}
