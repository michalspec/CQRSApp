using AutoMapper;
using CQRSApp.Application.Contracts.Persistence;
using CQRSApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSApp.Application.Functions.Categories.Queries.GetCategoryList
{
    public class GetCategoriesListQueryHandler : IRequestHandler<GetCategoriesListQuery, List<CategoryInListViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Category> _categoryRepository;

        public GetCategoriesListQueryHandler(IMapper mapper, IAsyncRepository<Category> categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryInListViewModel>> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
        {
            var all = await _categoryRepository.GetAllAsync();
            var ordered = all.OrderBy(x => x.Name);

            return _mapper.Map<List<CategoryInListViewModel>>(ordered);
        }
    }
}
 