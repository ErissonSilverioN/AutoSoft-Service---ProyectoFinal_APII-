using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutosoftService.Model
{
    public class Usuarios
    {
        [Key]

        public int UsuarioId { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar su nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar su apellido")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Debe ingresar su email")]
        [EmailAddress(ErrorMessage = "Debe ingresar un Email valido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe ingresar su nombre se usuario")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Debe elegir un nivel de usuario.")]
        public string NivelUsuario { get; set; }

        [Required(ErrorMessage = "Debe ingresar una contraseña")]
        [MinLength(5, ErrorMessage = "La contraseña debe contener al menos 5 caracteres.")]
        [MaxLength(30, ErrorMessage = "La contraseña es muy larga.")]
        public string Contrasena { get; set; }

        public DateTime FechaIngreso { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            Apellidos = string.Empty;
            Email = string.Empty;
            Usuario = string.Empty;
            NivelUsuario = string.Empty;
            Contrasena = string.Empty;
            FechaIngreso = DateTime.Now;
        }
    }
}
