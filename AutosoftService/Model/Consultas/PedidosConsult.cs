using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutosoftService.Model.Consultas
{
    public class PedidosConsult
    {
        [Key]
        public int PedidoId { get; set; }
        public string Articulo { get; set; }
        public string Proveedor { get; set; }
        public decimal Subtotal { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEntrega { get; set; }

        public PedidosConsult()
        {
            PedidoId = 0;
            Articulo = string.Empty;
            Proveedor = string.Empty;
            Subtotal = 0;
            Fecha = DateTime.Now;
            FechaEntrega = DateTime.Now;
        }
    }
}
