﻿using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Application.Admin.Commands.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest
    {
        [Required]
        [MaxLength(100)]
        public string MiddleName { get; set; }

        [Required]
        public ulong EGN { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}