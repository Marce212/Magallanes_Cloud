using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GestionCanchaFutbol.Models
{
    public class MvcReservaContext : DbContext
    {
        public MvcReservaContext (DbContextOptions<MvcReservaContext> options)
            : base(options)
        {
        }

        public DbSet<GestionCanchaFutbol.Models.Reserva> Reserva { get; set; }
    }
}
