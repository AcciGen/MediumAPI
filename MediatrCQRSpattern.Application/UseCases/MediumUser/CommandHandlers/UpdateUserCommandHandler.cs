using AutoMapper;
using MediatR;
using MediatrCQRSpattern.Application.Abstractions;
using MediatrCQRSpattern.Application.UseCases.MediumUser.Commands;
using MediatrCQRSpattern.Domain.DTOs;
using MediatrCQRSpattern.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCQRSpattern.Application.UseCases.MediumUser.CommandHandlers
{
    public class UpdateUserCommandHandler(IApplicationDbContext _dbContext, IMapper _mapper) : IRequestHandler<UpdateUserCommand, User>
    {
        public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == request.Id && !x.IsDeleted);
        
            if (user is not null)
            {
                user.ModifiedDate = DateTime.UtcNow;
                user.Name = request.Name;
                user.Email = request.Email;
                user.Username = request.Username;
                user.Bio = request.Bio;
                user.PhotoPath = request.PhotoPath;
                user.Followers = request.Followers;
                user.Login = request.Login;
                user.PasswordHash = request.PasswordHash;

                await _dbContext.SaveChangesAsync(cancellationToken);

                return user;
            }

            return null;
        }
    }
}
