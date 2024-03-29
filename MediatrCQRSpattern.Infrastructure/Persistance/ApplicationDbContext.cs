﻿using MediatrCQRSpattern.Application.Abstractions;
using MediatrCQRSpattern.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediatrCQRSpattern.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            Database.Migrate();
        }
        public DbSet<User> Users { get; set; }
    }
}
