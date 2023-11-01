using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dinero
    {
        public int? IdDinero { get; set; }
        public Double? ImporteDinero { get; set; }
        public string? DescripcionDinero { get; set; }
        public DateTime? FechaDinero { get; set; }
        public Boolean? EstaActivoDinero { get; set; }
        public Categoria? Categoria { get; set; }
        public Usuario? Usuario { get; set; }



    
    }
}
