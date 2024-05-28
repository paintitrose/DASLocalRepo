using System.ComponentModel.DataAnnotations;

namespace T2_VEGA_CHRIS.Models
{
    public class Distribuidor
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "Ingrese el Nombre del distribuidor")]
        public string NombreDistribuidor { get; set; }

        [Required(ErrorMessage = "Ingrese la razón social")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "Ingrese el número de teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Ingrese el correo de contacto")]
        public string Contacto { get; set; }

        [Required(ErrorMessage = "Ingrese el año de inicio")]
        [Range(1900, 3000, ErrorMessage = "Error. Año inválido. Ingrese nuevamente")]
        public int AnioInicioOperacion { get; set; }
    }
}
