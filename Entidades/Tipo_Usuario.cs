using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tipo_Usuario
    {
        public int? idTipoUsuario { get; set; }
        public string? nombreTipoUsuario { get; set; }
        public string? descripcionTipoUsuario { get; set; }
        public Boolean? estaActivoTipoUsuario { get; set; }
        public DateTime? fechaCreacionTipoUsuario { get; set; }
    }
}
