﻿using MatinGallery.Application.Interfaces.Contexts;
using MatinGallery.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatinGallery.Persistence.Contexts
{
    public class DatabaseContext:DbContext , IDatabaseContext
    {
        public DatabaseContext(DbContextOptions options) :base (options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }
    }
}
