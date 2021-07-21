using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RRHH.Models
{
    [Table("IRH_ASIENTOS_ENC")]
    public class AsientoEnc
    {
        [Key]
        public Int64 asientos_encId { get; set; }

        [Display(Name = "Fecha")]
        public DateTime ca_fec_asiento { get; set; }

        [Display(Name = "Grupo Calendario")]
        public string cal_run_id { get; set; }

        [Display(Name = "Concepto")]
        public string ca_concepto { get; set; }

        [Display(Name = "Comentario")]
        public string ca_nom_benef { get; set; }

        public string ca_empresa { get; set; }

        public string ca_cod_geografico { get; set; }

        public string ca_cod_contab { get; set; }

        public string ca_cod_comp1 { get; set; }

        public decimal ca_anio_trans { get; set; }

        public decimal ca_cod_per { get; set; }

        public string ca_pasado { get; set; }


    }
}
