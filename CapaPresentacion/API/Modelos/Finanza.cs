using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.API.Modelos
{
    public class Finanza
    {
        public string Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string MinAmount { get; set; }
        public string MaxAmount { get; set; }
        public string Url { get; set; }
        public string Country { get; set; }
        public string CurrencyDesc { get; set; }
        public string CurrencySymbol { get; set; }
        public List<string> Market { get; set; }
        public List<string> Types { get; set; }
        public string Costs { get; set; }
        public string Profile { get; set; }
        public string Risk { get; set; }
        public string Profitability { get; set; }

    }
}
