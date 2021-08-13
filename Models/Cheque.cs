using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RRHH.Models
{
    
    [Table("IRH_CHEQUES")]
    public class Cheque
    {
        
        #nullable disable
        [Key]
        public Int64 irh_chequeId { get; set; }
        public string empresa { get; set; }
        public string oficina { get; set; }
        public string cheque { get; set; }
        public string codigo { get; set; }  
        #nullable enable      
        public string? comentario { get; set; }
        public string? nombre { get; set; }
        public decimal monto { get; set; }
        public string? status { get; set; }
        public DateTime? fecha_impresion { get; set; }
        public DateTime fecha_registro { get; set; }
        public string? usuario { get; set; }
        public string? tipo_acreedor { get; set; }
        public string? forma_pago { get; set; }
        public string? debito { get; set; }
        public string? credito { get; set; }
        [NotMapped]
        public bool imp { get; set; }


    }
}
