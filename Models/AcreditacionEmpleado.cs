using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RRHH.Models
{
    [Table("IRH_ACREDITACION_EMPLEADOS")]
    public class AcreditacionEmpleado
    {
        [Key]
        public Int64 acredId { get; set; }
        public DateTime ca_fec_pago { get; set; }
        public decimal ca_monto_pg { get; set; }
        public decimal ca_cta_acre { get; set; }
        public string ca_num_empl { get; set; }
        public string ca_tp_pago { get; set; }
        public string ca_estatus { get; set; }
        public string ca_centro { get; set; }
    }
}
