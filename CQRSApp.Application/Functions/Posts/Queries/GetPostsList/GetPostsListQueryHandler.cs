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

namespace CQRSApp.Application.Functions.Posts
{
    class GetPostsListQueryHandler : IRequestHandler<GetPostsListQuery, List<PostViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Post> _postRepository;

        public GetPostsListQueryHandler(IMapper mapper, IAsyncRepository<Post> postRepository)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }
        public async Task<List<PostViewModel>> Handle(GetPostsListQuery request, CancellationToken cancellationToken)
        {
            var all = await _postRepository.GetAllAsync();
            var allordered = all.OrderBy(x => x.Date);

            return _mapper.Map<List<PostViewModel>>(all);
        }
    }
}
