using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public int? IdCategoria { get; set; }
        public string? NombreCategoria { get; set; }
        public string? DescripcionCategoria { get; set; }
        public DateTime? FCreacionCategoria { get; set; }
        public Boolean? EstaActivaCategoria { get; set;}
        public Usuario? Usuario { get; set; }
    }
}
