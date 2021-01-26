using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSApp.Application.Functions.Categories.Queries.GetCategoryListWithPosts
{
    public class GetCategoriesWithPostListQuery : IRequest<List<CategoryPostListViewModel>>
    {
        public SearchCategoryOptions searchCategory { get; set; }
    }
}
