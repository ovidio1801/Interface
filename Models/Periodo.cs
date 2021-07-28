using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RRHH.Models
{
    [Table("IRH_PERIODOS")]
    public class Periodo
    {
        [Key]
        public Int64 periodoId { get; set; }
        public int comp_eje { get; set; }
        public int comp_per { get; set; }
        public string cod_ejer { get; set; }
        public int cod_per { get; set; }
    }
}
