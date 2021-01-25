using AutoMapper;
using CQRSApp.Application.Functions.Posts;
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
            CreateMap<Post, PostInListViewModel>().ReverseMap();
            CreateMap<Post, PostDetailViewModel>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
