using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RRHH.Models
{
    [Table("IRH_PERIODOS_SECUENCIA")]
    public class PeriodoSecuencia
    {
        [Key]
        public Int64 persecId { get; set; }
        public int sec_comp { get; set; }
        public string cod_comp { get; set; }
        public string cod_ejer { get; set; }
        public int cod_per { get; set; }
    }
}
