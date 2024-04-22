using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExamenP1_DRueda.Data
{
    public class ExamenP1_DRuedaContext : DbContext
    {
        public ExamenP1_DRuedaContext (DbContextOptions<ExamenP1_DRuedaContext> options)
            : base(options)
        {
        }

        public DbSet<DRueda> DRueda { get; set; } = default!;
    }
}
