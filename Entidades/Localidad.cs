using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Localidad
    {
        public int? idLocalidad { get; set; }
        public string? codigoPostalLocalidad { get; set; }
        public string? nombreLocalidad { get; set; }
        public Provincia? provincia { get; set; }
    }
}
