using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMVC.Models
{
    public class ClientesModel
    {
        
        
            [DisplayName("IDClientes")]
            public int IDCliente { get; set; }

            [DisplayName("Nombre")]
            public string Nombre { get; set; }

            [DisplayName("Apellido")]
            public string Apellido { get; set; }

            [DisplayName("Domicilio")]
            public string Domicilio { get; set; }

            [DisplayName("Localidad")]
            public string Localidad { get; set; }

            [DisplayName("Cuil")]
            [Required(ErrorMessage = "El CUIL es requerido")]
            [StringLength(11, ErrorMessage = "Debe ingresar una cadena de 11 dígitos")]
            public string Cuil { get; set; }

            [DisplayName("Teléfono Part")]
            public string Telpar { get; set; }

            [DisplayName("Teléfono Cel")]
            public string Telcel { get; set; }

            [DisplayName("e-mail")]
            public string email { get; set; }

            [DisplayName("Observaciones")]
            public string Observa { get; set; }

            //[DisplayName("CUIL")]
            //[Required(ErrorMessage = "El CUIL es requerido")]
            //[StringLength(11, ErrorMessage = "Debe ingresar una cadena de 11 dígitos")]
            //public string CUIL { get; set; }

            
        
    }
}