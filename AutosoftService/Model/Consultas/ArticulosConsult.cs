using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutosoftService.Model.Consultas
{
    public class ArticulosConsult
    {
        [Key]

        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public string Proveedor { get; set; }
        public decimal Costo { get; set; }
        public int Existencia { get; set; }
        public decimal ValorInventario { get; set; }
        public DateTime Fecha { get; set; }

        public ArticulosConsult()
        {
            ArticuloId = 0;
            Descripcion = string.Empty;
            Proveedor = string.Empty;
            Costo = 0;
            Existencia = 0;
            ValorInventario = 0;
            Fecha = DateTime.Now;
        }
    }
}
