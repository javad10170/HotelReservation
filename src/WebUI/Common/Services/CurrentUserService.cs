﻿using Common;
using Domain.Entities;

namespace WebUI.Common.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public string Ip { get; set; }

        public AppUser User { get; set; }

        public bool IsAuthenticated { get; set; }
    }
}