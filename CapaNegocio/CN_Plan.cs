using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Plan
    {
        CD_Plan CD_Plan = new CD_Plan();
        public List<Plan> GetPlanes(int? idUsuario, int? idPlan)
        {
            try
            {
                List<Plan> listaPlanes = new List<Plan>();
                listaPlanes = CD_Plan.GetPlanes(idUsuario, idPlan);
                return listaPlanes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetTablaPlanes(int? idUsuario)
        {
            DataTable tabla = new DataTable();
            tabla = CD_Plan.GetTablaPlanes(idUsuario);
            return tabla;
        }

        public DataTable GetTablaPlanesFinalizados(int? idUsuario)
        {
            DataTable tabla = new DataTable();
            tabla = CD_Plan.GetTablaPlanesFinalizados(idUsuario);
            return tabla;
        }

        

        public int InsertPlan(Plan plan)
        {
            try
            {
                return CD_Plan.InsertPlan(plan);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EditarPlan(int? idUsuario, Plan plan)
        {
            if (plan.IdPlan == null || idUsuario == null || String.IsNullOrEmpty(plan.NombrePlan) || String.IsNullOrEmpty(plan.DescripcionPlan) || 
                plan.FechaInicioPlan == null || plan.FechaFinPlan == null || plan.CapitalPlan == null)
                return false;

            try
            {
                return CD_Plan.EditarPlan(idUsuario, plan);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool AnularPlan(int? idUsuario, int? idPlan)
        {
            if (idPlan == null)
                return false;

            try
            {
                return CD_Plan.AnularPlan(idUsuario, idPlan);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetPlanDinero(int? idUsuario, int? idPlan)
        {
            DataTable tabla = new DataTable();
            tabla = CD_Plan.GetPlanDinero(idUsuario, idPlan);
            return tabla;
        }

        public int InsertDineroPlan(Dinero dinero, char tipo, int? idPlan)
        {
            try
            {
                return CD_Plan.InsertDineroPlan(dinero, tipo, idPlan);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int GetTotalPlanesPendientes(int? idUsuario)
        {
            try
            {
                return CD_Plan.GetTotalPlanesPendientes(idUsuario);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool FinalizarPlan(int? idUsuario, int? idPlan)
        {
            if (idPlan == null)
                return false;

            try
            {
                return CD_Plan.FinalizarPlan(idUsuario, idPlan);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
