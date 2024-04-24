using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Plan
    {
        public int? IdPlan { get; set; }
        public string? NombrePlan { get; set; }
        public string? DescripcionPlan { get; set; }
        public DateTime? FechaInicioPlan { get; set; }
        public DateTime? FechaFinPlan { get; set; }
        public Double? CapitalPlan { get; set; }
        public Boolean? EstaActivoPlan { get; set; }
        public Usuario? Usuario { get; set; }
        public Boolean? EstaCompletoPlan { get; set; }

        public DateTime? FechaCompleto { get; set; }
    }
}
