using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RRHH.Models
{
    [Table("IRH_ASIENTOS_DET")]
    public class AsientoDet
    {
        [Key]
        public Int64 asientos_detId { get; set; }

        [Display(Name = "Cuenta")]
        public string ca_cod_cta { get; set; }

        [Display(Name = "Débito")]
        public decimal ca_deb_local { get; set; }

        [Display(Name = "Crédito")]
        public decimal ca_crd_local { get; set; }

        public string ca_empresa { get; set; }

        public string ca_cod_geografico { get; set; }

        public string ca_cod_contab { get; set; }

        public string ca_cod_comp1 { get; set; }

        public string ca_anio_trans { get; set; }

        public decimal ca_cod_per { get; set; }

        public string cal_run_id { get; set; }

        public decimal ca_cod_sec_mov { get; set; }


    }
}
