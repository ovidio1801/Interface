using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RRHH.Models{
    [Table("IRH_DESCUENTO_PRODUCTO")]
    public class DescuentoProducto{
        [Key]
        public Int64 prodId { get; set; }
        public string ca_producto { get; set; }
        public decimal ca_num_cuenta { get; set; }
        public decimal ca_monto_pag { get; set; }
        public DateTime fecha { get; set; }
        public string ca_status { get; set; } 

    }

}
