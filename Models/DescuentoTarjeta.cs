using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RRHH.Models{
    [Table("IRH_DESCUENTO_TARJETA")]
    public class DescuentoTarjeta{
        [Key]
        public Int64 tcId { get; set; }
        public string ca_conc_pago { get; set; }
        public decimal ca_num_tarj { get; set; }
        public decimal ca_dig_verif { get; set; }
        public decimal ca_monto_pag { get; set; }
        public DateTime fecha { get; set; }
        public string ca_status { get; set; } 

    }

}
