using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RRHH.Models
{
    
    [Table ("PS_CA_TIPO_CHEQUE")]
    public class TipoCheque
    {
        [Key]
        public int ID_TIPO_CHEQUE { get; set; }

        [Display(Name = "Tipo Cheque")]
        [MaxLength(4, ErrorMessage = "{0} con máximo de {1} caracteres")]
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string COD_TIPO_CHEQUE { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(50, ErrorMessage = "{0} con máximo de {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string DESCRIPCION { get; set; }
    }
}
