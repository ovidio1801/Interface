using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RRHH.Models;

namespace RRHH.Data
{
    public class RRHHContext : DbContext
    {
        public RRHHContext (DbContextOptions<RRHHContext> options)
            : base(options)
        {
        }

        public DbSet<RRHH.Models.Parametro> Parametros { get; set; }
        public DbSet<RRHH.Models.TipoCheque> TiposCheque { get; set; }
        public DbSet<RRHH.Models.Cheque> Cheques { get; set; }
        public DbSet<RRHH.Models.AsientoEnc> AsientosEnc { get; set; }
        public DbSet<RRHH.Models.AsientoDet> AsientosDet { get; set; }
        public DbSet<RRHH.Models.AcreditacionEmpleado> AcredsEmpl { get; set; }
        public DbSet<RRHH.Models.DescuentoProducto> DescsProd { get; set; }
        public DbSet<RRHH.Models.DescuentoTarjeta> DescsTar { get; set; }

    }
}

