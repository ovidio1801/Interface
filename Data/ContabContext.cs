using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RRHH.Models;

namespace RRHH.Data
{
    public class ContabContext : DbContext
    {
        public ContabContext (DbContextOptions<ContabContext> options)
            : base(options)
        {
        }

        public DbSet<RRHH.Models.Periodo> Periodos { get; set; }
        public DbSet<RRHH.Models.PeriodoSecuencia> Secuencias { get; set; }

    }
}

