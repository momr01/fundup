using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int? idUsuario { get; set; }
        public string? nombreUsuario { get; set; }
        public string? apellidoUsuario { get; set; }
        public DateTime? fechaNacimientoUsuario { get; set; }
        public int? dniUsuario { get; set; }
        public string? emailUsuario { get; set; }
        public string? contraseñaUsuario { get; set; }
        public Boolean? estaActivoUsuario { get; set; }
        public Tipo_Usuario? tipoUsuario { get; set; }
        public DateTime? fechaCreacionUsuario { get; set; }


        public Domicilio? domicilioUsuario { get; set;}

        public Localidad? localidadUsuario { get; set; }

        public Provincia? provinciaUsuario { get; set; }
    }
}
