using System.ComponentModel.DataAnnotations;

namespace taller_netcore.Models
{
    public class FormContactoWebApi
    {
        [Required(ErrorMessage = "Campo Obligatorio.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Este campo debe tener entre 3 y 50 caracteres.")]
        public string Nombres { get; set; }
        
        [Required(ErrorMessage = "Campo Obligatorio.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Este campo debe tener entre 3 y 50 caracteres.")]
        public string Apellidos { get; set; }
        
        [Required(ErrorMessage = "Campo Obligatorio.")]
        [StringLength(64)]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        
        [Required(ErrorMessage = "Campo Obligatorio.")]
        [EmailAddress]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio.")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Este campo debe tener entre 3 y 15 caracteres.")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio.")]
        public string Comentario { get; set; }
    }
}