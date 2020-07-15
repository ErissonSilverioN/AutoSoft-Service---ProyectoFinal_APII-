using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutosoftService.Model
{
    public class Vehiculos
    {
        [key]

        public int VehiculoId { get; set; }
        public int ClienteId { get; set; }
        public string TipoVehiculo { get; set; }
        public string Descripcion { get; set; }
        public string Placa { get; set; }
        public int Año { get; set; }
        public DateTime Fecha { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Clientes Clientes { get; set; }

        public Vehiculos()
        {
            VehiculoId = 0;
            ClienteId = 0;
            TipoVehiculo = string.Empty;
            Descripcion = string.Empty;
            Placa = string.Empty;
            Año = 0;
            Fecha = DateTime.Now;
           
        }
    }
}
