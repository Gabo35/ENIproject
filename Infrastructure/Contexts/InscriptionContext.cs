using Domaine.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contexts
{
    public class InscriptionContext : DbContext
    {
        public DbSet<Inscription> Inscription { get; set; }

        public InscriptionContext(DbContextOptions<InscriptionContext> options) : base(options) { }
    }
}
