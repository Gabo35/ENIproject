﻿using Domaine.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contexts
{
    public class RoleContext : DbContext
    {
        public DbSet<Role> Role { get; set; }

        public RoleContext(DbContextOptions<RoleContext> options) : base(options) { }
    }
}
