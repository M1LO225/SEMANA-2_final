using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MVC_2_SEMANA2.Models
{
    public class EstudianteUDLA
    {
        [Key]
        public string IdBanner { get; set; }
        [AllowNull]
        public string? Nombre { get; set; }
        public Carrera Carrera { get; set; }

    }

   
}
