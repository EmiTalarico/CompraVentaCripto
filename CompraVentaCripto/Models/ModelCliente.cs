using System.ComponentModel.DataAnnotations;

namespace CompraVentaCripto.Models
{
    public class ModelCliente
    {
        //Estos son las representacion de los campos de la tabla
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string apellido { get; set; }
        [Required(ErrorMessage = "El dni es obligatorio")]
        public string dni { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es obligatorio")]
        public DateTime fechaNacimiento { get; set; }
        

        public int cPesos { get; set; }
        public int cDolares { get; set; }
        public int cCripto { get; set; }
    }
}
