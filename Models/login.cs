using System.ComponentModel.DataAnnotations;

namespace taller_netcore.Models
{
    public class login
    {
        [Required(ErrorMessage = "Por favor ingrese este campo")]
        [MaxLength(15)]
        public string usuario { get; set; }
        
        [Required(ErrorMessage = "Por favor ingrese este campo")]
        [DataType(DataType.Password)]
        public string clave { get; set; }
    }
}