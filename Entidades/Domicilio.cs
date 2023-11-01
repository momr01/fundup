using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Domicilio
    {   public int? idDomicilio { get; set; }
        public string? calleDomicilio { get; set; }
        public int? numeroDomicilio { get; set; }
        public Localidad? localidad { get; set; }
    }
}
