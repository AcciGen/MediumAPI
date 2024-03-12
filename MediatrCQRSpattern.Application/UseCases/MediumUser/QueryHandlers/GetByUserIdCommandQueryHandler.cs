using MediatR;
using MediatrCQRSpattern.Application.Abstractions;
using MediatrCQRSpattern.Application.UseCases.MediumUser.Queries;
using MediatrCQRSpattern.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCQRSpattern.Application.UseCases.MediumUser.QueryHandlers
{
    public class GetByUserIdCommandQueryHandler : IRequestHandler<GetByUserIdCommandQuery, User>
    {
        private readonly IApplicationDbContext _dbContext;

        public GetByUserIdCommandQueryHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> Handle(GetByUserIdCommandQuery request, CancellationToken cancellationToken)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == request.Id && x.IsDeleted != true);
        
            return user;
        }
    }
}
