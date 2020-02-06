using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcialAplicada2.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Debes Elegir un fecha")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El campo Descripcion no puede esta vacio")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo Costo no puede esta vacio")]
        
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "El campo Ganancia no puede esta vacio")]
        public decimal Ganacia { get; set; }

        [Required(ErrorMessage = "El campo Precio no puede esta vacio")]
        public decimal Precio { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Costo = 0;
            Ganacia = 0;
            Precio = 0;
        }
    }
}
