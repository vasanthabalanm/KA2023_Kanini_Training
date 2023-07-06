﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JsonWedTokensample.Authorization
{
    public class AuthorizationDbContext : IdentityDbContext<IdentityUser>
    {
        public AuthorizationDbContext(DbContextOptions<AuthorizationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
