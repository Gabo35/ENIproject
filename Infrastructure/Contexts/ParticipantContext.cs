﻿using Domaine.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contexts
{
    public class ParticipantContext : DbContext
    {
        public DbSet<Participant> Participant { get; set; }

        public ParticipantContext(DbContextOptions<ParticipantContext> options) : base(options) { }
    }
}
