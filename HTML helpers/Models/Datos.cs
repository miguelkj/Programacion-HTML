using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HTML_helpers.Models
{
    public class Datos
    {
        

        [Required(ErrorMessage = "Ingresar cedula")]
        public int Cedula { get; set; }



        [Required(ErrorMessage = "Ingresar nombre")]
        public string Nombre { get; set; }



        [Required(ErrorMessage = "Ingresar apellido")]
        public string Apellido { get; set; }
        
        [Range(15,100)]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Ingresa telefono")]
        public int Telefono { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "ingresa el correo")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Correo no valido.")]

        public string Correo { get; set; }

        public string Genero { get; set; }

        public string EstadoCivil { get; set; }

        public string Hobbys { get; set; }
    }
}