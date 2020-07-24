using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutosoftService.Model
{
    public class Clientes
    {
        [Key]
       
        [Required(ErrorMessage = "El campo ID no puede estar vació.")]
        [Range(0, 1000000, ErrorMessage = "El campo ID no puede ser menor que 1 o mayor que 1000000.")]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "El campo nombre no puede estar vació.")]
        [MinLength(3, ErrorMessage = "El campo lo minimo debe terner 3 caracteres.")]
        [MaxLength(40, ErrorMessage = "El nombre es muy largo.")]
        [RegularExpression(@"\S(.*)\S", ErrorMessage = "Debe ser un texto.")]
      
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo cedula no debe estar vació.")]
        [MinLength(11, ErrorMessage = "El Campo Cedula debe contener 11 Caracteres.")]
     
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El campo Teléfono no debe de estar vació.")]
        [Phone(ErrorMessage = "Debes de ingresar tu número telefonico.")]
        [MaxLength(10, ErrorMessage = "El campo telefono no tiene más de diez dígitos.")]
        public string Telefono { get; set; }


        [Required(ErrorMessage = "El campo Dirección no debe de estar vació.")]
        [MinLength(10, ErrorMessage = "La dirección es muy corta.")]
        [MaxLength(100, ErrorMessage = "La dirección debe contener menos de 40 caracteres.")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Debe ingresar su email")]
        [EmailAddress(ErrorMessage = "Debe ingresar un Email valido.")]
        public string Email { get; set; }
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo fecha no puede estar vacío.")]
        [DisplayFormat(DataFormatString = "{0:dd,mm,yyyy}")]
        public DateTime Fecha { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            Nombre = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
            Email = string.Empty; 
            Fecha = DateTime.Now; 
        }
    }
}
