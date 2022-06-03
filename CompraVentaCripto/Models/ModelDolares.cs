using System.ComponentModel.DataAnnotations;

namespace CompraVentaCripto.Models
{
    public class ModelDolares
    {
        //Estos son las representacion de los campos de la tabla
        public int Id { get; set; }
        public string numeroCuenta { get; set; }
        public string cbuCuenta { get; set; }
        public string aliasCuenta { get; set; }
        public double montoDinero { get; set; }
        public int cPesos { get; set; }
        public int cCripto { get; set; }

    }
}
