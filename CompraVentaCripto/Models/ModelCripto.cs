using System.ComponentModel.DataAnnotations;

namespace CompraVentaCripto.Models
{
    public class ModelCripto
    {
        //Estos son las representacion de los campos de la tabla
        public int Id { get; set; }
        public string uuid { get; set; }
        public double montoDinero { get; set; }
        public int cDolares { get; set; }

    }
}
