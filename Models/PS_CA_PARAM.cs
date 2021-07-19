using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RRHH.Models
{
    public class PS_CA_PARAM
    {
        [Key]       
        public int ID_PARAM { get; set; }
        [Display(Name ="CÓDIGO")]
        public string CODIGO_TR { get; set; }
        public string CENTRO { get; set; }
        [Display(Name = "CUENTA DB")]
        public string CUENTA_DB { get; set; }
        [Display(Name = "CUENTA CR")]
        public string CUENTA_CR { get; set; }
        [Display(Name = "DESCRIPCIÓN")]
        public string DESCRIPCION { get; set; }

    }

}
