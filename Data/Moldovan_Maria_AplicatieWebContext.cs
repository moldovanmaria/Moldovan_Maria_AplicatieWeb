using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moldovan_Maria_AplicatieWeb.Models;

namespace Moldovan_Maria_AplicatieWeb.Data
{
    public class Moldovan_Maria_AplicatieWebContext : DbContext
    {
        public Moldovan_Maria_AplicatieWebContext (DbContextOptions<Moldovan_Maria_AplicatieWebContext> options)
            : base(options)
        {
        }

        public DbSet<Moldovan_Maria_AplicatieWeb.Models.Retete> Retete { get; set; }
    }
}
