using AutoMapper;
using CQRSApp.Application.Functions.Categories.Queries.GetCategoryList;
using CQRSApp.Application.Functions.Categories.Queries.GetCategoryListWithPosts;
using CQRSApp.Application.Functions.Posts;
using CQRSApp.Application.Functions.Posts.Commands.CreatePost;
using CQRSApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSApp.Application.Mapper
{
    class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Post, PostViewModel>().ReverseMap();
            CreateMap<Post, PostDetailViewModel>().ReverseMap();
            CreateMap<Category, CategoryDto>();

            CreateMap<Category, CategoryInListViewModel>();
            CreateMap<Category, CategoryPostDto>();
            CreateMap<Category, CategoryPostListViewModel>();

            CreateMap<Post, CreatedPostCommand>().ReverseMap();
        }
    }
}
