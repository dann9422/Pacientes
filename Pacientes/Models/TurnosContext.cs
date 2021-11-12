using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacientes.Models
{
    public class TurnosContext : DbContext
    {

        public TurnosContext(DbContextOptions<TurnosContext> options) : base(options)
        {

        }
        public DbSet<especialidad> especialidad { get; set; }
    }
}
