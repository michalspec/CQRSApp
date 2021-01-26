﻿using AutoMapper;
using CQRSApp.Application.Contracts.Persistence;
using CQRSApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSApp.Application.Functions.Categories.Queries.GetCategoryListWithPosts
{
    public class GetCategoriesWithPostListQueryHandler : IRequestHandler<GetCategoriesWithPostListQuery, List<CategoryPostListViewModel>>
    {
        private readonly IMapper _mapper;
        //private readonly ICategoryRepository<Category> _categoryRepository;
        private readonly ICategoryRepository _categoryRepository;

        public GetCategoriesWithPostListQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }
        public async Task<List<CategoryPostListViewModel>> Handle(GetCategoriesWithPostListQuery request, CancellationToken cancellationToken)
        {
            var list = await _categoryRepository.GetCategoriesWithPost(request.searchCategory);

            return _mapper.Map<List<CategoryPostListViewModel>>(list);
        }
    }
}
