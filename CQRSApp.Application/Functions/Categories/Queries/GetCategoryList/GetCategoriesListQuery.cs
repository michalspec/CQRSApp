using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSApp.Application.Functions.Categories.Queries.GetCategoryList
{
    public class GetCategoriesListQuery : IRequest<List<CategoryInListViewModel>>
    {
    }
}
