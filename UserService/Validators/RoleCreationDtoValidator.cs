﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Dtos.Roles;

namespace UserService.Validators
{
    public class RoleCreationDtoValidator: AbstractValidator<RoleCreationDto>
    {
        public RoleCreationDtoValidator()
        {
            RuleFor(x => x.RoleName).NotNull().NotEmpty().MaximumLength(50).MinimumLength(3);
        }
    }
}
