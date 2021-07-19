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

        public DbSet<RRHH.Models.PS_CA_PARAM> PS_CA_PARAM { get; set; }
        public DbSet<RRHH.Models.TIPO_CHEQUE> TIPO_CHEQUE { get; set; }
        public DbSet<RRHH.Models.IRH_CHEQUE> IRH_CHEQUES { get; set; }
        public DbSet<RRHH.Models.PS_CA_ROL_PAGO_ACREEDOR> PS_CA_ROL_PAGO_ACREEDOR { get; set; }
        public DbSet<RRHH.Models.AsientoEnc> AsientoEncs { get; set; }
        public DbSet<RRHH.Models.AsientoDet> AsientoDets { get; set; }


    }
}

