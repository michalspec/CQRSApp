using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSApp.Application.Functions.Posts
{
    public class GetPostDetailQuery : IRequest<PostDetailViewModel>
    {
        public int Id { get; set; }
    }
}
