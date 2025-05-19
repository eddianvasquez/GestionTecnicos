using System.ComponentModel.DataAnnotations;


namespace BlazorApp1.Components.models
{
    public class Tecnico
    {
        [Key]
        public int TecnicoId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombres { get; set; } = string.Empty;

        [Range(1, double.MaxValue, ErrorMessage = "El sueldo por hora debe ser mayor que cero.")]
        public decimal SueldoHora { get; set; }
    }
}