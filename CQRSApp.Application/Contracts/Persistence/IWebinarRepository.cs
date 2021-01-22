using CQRSApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSApp.Application.Contracts.Persistence
{
    public interface IWebinarRepository : IAsyncRepository<Webinar>
    {
    }
}
