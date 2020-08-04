using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutosoftService.Model.Consultas
{
    public class FacturasConsult
    {
        [Key]
        public int FacturaId { get; set; }
        public string Servicios { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }

        public FacturasConsult()
        {
            FacturaId = 0;
            Cliente = string.Empty;
            Total = 0;
            Fecha = DateTime.Now;

        }

    }
}
