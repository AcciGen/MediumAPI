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
    public class GetAllUsersCommandQueryHandler : IRequestHandler<GetAllUsersCommandQuery, List<User>>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public GetAllUsersCommandQueryHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<User>> Handle(GetAllUsersCommandQuery request, CancellationToken cancellationToken)
        {
            var users = await _applicationDbContext.Users.ToListAsync();

            return users;
        }
    }
}
