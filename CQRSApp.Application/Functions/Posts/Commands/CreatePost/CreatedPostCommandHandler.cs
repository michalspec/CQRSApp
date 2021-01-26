using AutoMapper;
using CQRSApp.Application.Contracts.Persistence;
using CQRSApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSApp.Application.Functions.Posts.Commands.CreatePost
{
    public class CreatedPostCommandHandler : IRequestHandler<CreatedPostCommand, int>
    {
        private readonly IAsyncRepository<Post> _postRepository;
        private readonly IMapper _mapper;

        public CreatedPostCommandHandler(IAsyncRepository<Post> postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreatedPostCommand request, CancellationToken cancellationToken)
        {
            var post = _mapper.Map<Post>(request);

            post = await _postRepository.AddAsync(post);

            return post.PostId;
        }
    }
}
