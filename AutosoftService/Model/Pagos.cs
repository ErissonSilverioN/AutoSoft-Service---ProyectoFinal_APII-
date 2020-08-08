using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutosoftService.Model
{
    public class Pagos
    {
        [Key]
        [Required(ErrorMessage = "El campo Id debe ser un numero")]
        [Range(0, 100000000, ErrorMessage = "El campo Id no puede ser menor que cero")]
        public int PagoId { get; set; }
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "El Monto es obligatorio.")]
        [Range(minimum: 1, maximum: 999999999999, ErrorMessage = "El Monto esta fuera del rango")]
        public decimal Monto { get; set; }
        public decimal Deuda { get; set; }
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo fecha no puede estar vacío.")]
        [DisplayFormat(DataFormatString = "{0:dd,mm,yyyy}")]
        public DateTime Fecha { get; set; }

        public Pagos()
        {
            PagoId = 0;
            ClienteId = 0;
            Monto = 0;
            Deuda = 0;
            Fecha = DateTime.Now;
        }
    }
}
