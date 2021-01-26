using CQRSApp.Application.Functions.Categories.Queries.GetCategoryListWithPosts;
using CQRSApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRSApp.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithPost(SearchCategoryOptions searchCategory);
    }
}
