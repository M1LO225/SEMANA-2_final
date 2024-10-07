using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MVC_2_SEMANA2.Models
{
    public class EstudianteUDLA
    {
        [Key]
        public string Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }

        [EmailAddress]
        public string Correo { get; set; }

    }

   
}
