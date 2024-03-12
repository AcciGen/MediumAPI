using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCQRSpattern.Application.UseCases.MediumUser.Commands
{
    public class CreateUserCommand : IRequest
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string? Email { get; set; }
        public string? Bio { get; set; }
        public string? PhotoPath { get; set; }
        public int Followers { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
    }
}
