using MediatR;
using MediatrCQRSpattern.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCQRSpattern.Application.UseCases.MediumUser.Queries
{
    public class GetByUserIdCommandQuery : IRequest<User>
    {
        public Guid Id { get; set; }
    }
}
