using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RRHH.Models
{
    public class FiltroCheque
    {
        [Display(Name = "Desde")]
        //[Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Date, ErrorMessage = "Ingrese una fecha")]
        public DateTime desde { get; set; }

        [Display(Name = "Hasta")]
        //[Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Date, ErrorMessage = "Ingrese una fecha")]
        public DateTime hasta { get; set; }

        [Display(Name = "Tipo de cheque")]
        [StringLength(4, ErrorMessage = "Máximo {0} caracteres")]
        //[Required(ErrorMessage = "{0} es requerido")]
        public string tipoCheque { get; set; }

        //[Required(ErrorMessage ="{0} es requerido")]
        [Display(Name = "Secuencia inicial")]
        [Range(1, int.MaxValue, ErrorMessage = "{0} debe estar en un rango entre {1} y {2}")]
        public int secIni { get; set; }

        //[Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Secuencia final")]
        [Range(1, int.MaxValue, ErrorMessage = "{0} debe estar en un rango entre {1} y {2}")]
        public int secFin { get; set; }

        public virtual TipoCheque TIPO_CHEQUE { get; set; }
    }
}
