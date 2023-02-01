using System.ComponentModel.DataAnnotations;

namespace slnBelgradoAriana.Models
{
    public class Receta
    {
        public int RecetaId { get; set; }

        public string Categoria { get; set; }
        public string Ingredientes { get; set; }
        public string Instrucciones { get; set; }
        public string Autor { get; set; }
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Debes ingresar un numero")]
        [RegularExpression("^[^@]+@[^@]+\\.[a-zA-Z]{2,}$")]
        public string Email { get; set; }
        public int Edad { get; set; }


    }
}
