﻿using MediatR;
using MediatrCQRSpattern.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCQRSpattern.Application.UseCases.MediumUser.Commands
{
    public class CreateUserCommand : UserDTO, IRequest
    {

    }
}
