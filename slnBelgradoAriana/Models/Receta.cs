using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using slnBelgradoAriana.Validation;

namespace slnBelgradoAriana.Models
{
    [Table("Receta")]
    public class Receta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debes ingresar un titulo")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Debes ingresar una categoria")]
        [CategoriaAttribute]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Debes ingresar los ingredientes")]
        public string Ingredientes { get; set; }

        [Required(ErrorMessage = "Debes ingresar las instrucciones")]
        public string Instrucciones { get; set; }

        [Required(ErrorMessage = "Debes ingresar un autor")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Debes ingresar un apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Debes ingresar un mail")]
        [RegularExpression("^[^@]+@[^@]+\\.[a-zA-Z]{2,}$")]
        public string Email { get; set; }

        [MayorEdadAtributte]
        public int Edad { get; set; }


    }
}
