﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutosoftService.Model
{
    public class Facturas
    {

        [Key]

        public int FacturaId { get; set; }
        public int VehiculoId { get; set; }
        public int ClienteId { get; set; }
        public int ArticuloId { get; set; }
        [Required(ErrorMessage = "El campo nombre no puede estar vació.")]
        public string Servicios { get; set; }
        public bool FacturaCredito { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Itbis { get; set; }
        public decimal Total { get; set; }
        public DateTime ProximoMantemiento { get; set; }
        public DateTime Fecha { get; set; }


        [ForeignKey("FacturaId")]
        public virtual List<FacturaD> Factura_Detalle { get; set; }

        public Facturas()
        {
            FacturaId = 0;
            VehiculoId = 0;
            ClienteId = 0;
            ArticuloId = 0;
            Servicios = string.Empty;
            FacturaCredito = false;
            SubTotal = 0;
            Itbis = 0;
            Total = 0;
            ProximoMantemiento = DateTime.Now.AddMonths(3);
            Fecha = DateTime.Now;
            Factura_Detalle = new List<FacturaD>();
        }
    }
}
