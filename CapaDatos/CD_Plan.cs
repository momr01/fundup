using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Plan
    {
        private CD_Conexion conexion = new CD_Conexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        public List<Plan> GetPlanes(int? idUsuario, int? idPlan)
        {
            List<Plan> listaPlanes = new List<Plan>();

            comando.CommandText = "GetPlanes";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            if(idPlan != null ) {
                comando.Parameters.AddWithValue("@idPlan", idPlan);
            }

            try
            {
                comando.Connection = conexion.AbrirConexion();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Plan pl = new Plan();
                    pl.IdPlan = Convert.ToInt32(reader["ID"]);
                    pl.NombrePlan = Convert.ToString(reader["NOMBRE"]);
                    pl.DescripcionPlan = Convert.ToString(reader["DESCRIPCIÓN"]);
                    pl.FechaInicioPlan = Convert.ToDateTime(reader["FECHA INICIO"]);
                    pl.FechaFinPlan = Convert.ToDateTime(reader["FECHA FIN"]);
                    pl.CapitalPlan = Convert.ToDouble(reader["CAPITAL"]);
                    pl.EstaCompletoPlan = Convert.ToBoolean(reader["ESTADO"]);
                    pl.FechaCompleto = Convert.ToDateTime(reader["FECHA COMPLETO"]);

                    listaPlanes.Add(pl);
                }
                comando.Parameters.Clear();
                reader.Close();
                conexion.CerrarConexion();
            }
            catch (Exception)
            {
                throw;
            }
            return listaPlanes;
        }

        public DataTable GetTablaPlanes(int? idUsuario )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "GetPlanes";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable GetTablaPlanesFinalizados(int? idUsuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "GetPlanesFinalizados";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }

        public int InsertPlan(Plan p)
        {
            int idMovCreado = 0;

            comando.CommandText = "RegistrarPlan";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@ID_USUARIO", p.Usuario!.idUsuario);

            if (p.NombrePlan != null)
                comando.Parameters.AddWithValue("@NOMBRE_PLAN", p.NombrePlan);

            if (p.DescripcionPlan != null)
                comando.Parameters.AddWithValue("@DESCRIPCION_PLAN", p.DescripcionPlan);

            if (p.FechaInicioPlan != null)
                comando.Parameters.AddWithValue("@FECHA_INICIO_PLAN", p.FechaInicioPlan);

            if (p.FechaFinPlan != null)
                comando.Parameters.AddWithValue("@FECHA_FIN_PLAN", p.FechaFinPlan);

            if (p.CapitalPlan != null)
                comando.Parameters.AddWithValue("@CAPITAL_OBJETIVO_PLAN", p.CapitalPlan);

            if (p.FechaCompleto != null)
                comando.Parameters.AddWithValue("@FECHA_COMPLETO", p.FechaCompleto);

            try
            {
                comando.Connection = conexion.AbrirConexion();
                idMovCreado = Convert.ToInt32(comando.ExecuteScalar());

                conexion.CerrarConexion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                comando.Parameters.Clear();
            }
            return idMovCreado;
        }

        public bool EditarPlan(int? idUsuario, Plan p)
        {

            comando.CommandText = "EditarPlan";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

            if (p.IdPlan != null)
                comando.Parameters.AddWithValue("@ID_PLAN", p.IdPlan);

            if (p.NombrePlan != null)
                comando.Parameters.AddWithValue("@NOMBRE_PLAN", p.NombrePlan);

            if (p.DescripcionPlan != null)
                comando.Parameters.AddWithValue("@DESCRIPCION_PLAN", p.DescripcionPlan);

            if (p.FechaInicioPlan != null)
                comando.Parameters.AddWithValue("@FECHA_INICIO_PLAN", p.FechaInicioPlan);

            if (p.FechaFinPlan != null)
                comando.Parameters.AddWithValue("@FECHA_FIN_PLAN", p.FechaFinPlan);

            if (p.CapitalPlan != null)
                comando.Parameters.AddWithValue("@CAPITAL_OBJETIVO_PLAN", p.CapitalPlan);



            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.ExecuteNonQuery();

                conexion.CerrarConexion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                comando.Parameters.Clear();
            }
            return true;

        }

        public bool AnularPlan(int? idUsuario, int? idPlan)
        {
            comando.CommandText = "AnularPlan";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            if (idPlan != null)
                comando.Parameters.AddWithValue("@idPlan", idPlan);

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.ExecuteNonQuery();

                conexion.CerrarConexion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                comando.Parameters.Clear();
            }
            return true;

        }

        public DataTable GetPlanDinero(int? idUsuario, int? idPlan)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "GetPlanDinero";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            comando.Parameters.AddWithValue("@idPlan", idPlan);

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }

        public int InsertDineroPlan(Dinero i, char tipo, int? idPlan)
        {
            int idMovCreado = 0;

            if (tipo == 'I')
                comando.CommandText = "RegistrarIngresoPlan";
            else if (tipo == 'G')
                comando.CommandText = "RegistrarGastoPlan";

            comando.CommandType = CommandType.StoredProcedure;

            if (i.ImporteDinero != null)
                comando.Parameters.AddWithValue("@IMPORTE_DINERO", i.ImporteDinero);

            if (i.DescripcionDinero != null)
                comando.Parameters.AddWithValue("@DESCRIPCION_DINERO", i.DescripcionDinero);

            if (i.FechaDinero != null)
                comando.Parameters.AddWithValue("@FECHA_DINERO", i.FechaDinero);

            if (i.Categoria != null)
            {
                comando.Parameters.AddWithValue("@ID_CATEGORIA", i.Categoria.IdCategoria);
            }

            if (i.Usuario != null)
            {
                comando.Parameters.AddWithValue("@ID_USUARIO", i.Usuario.idUsuario);
            }

            if (idPlan != null)
                comando.Parameters.AddWithValue("@ID_PLAN", idPlan);

            if (i.EsPlan != null)
                comando.Parameters.AddWithValue("@ES_PLAN", i.EsPlan);

            try
            {
                comando.Connection = conexion.AbrirConexion();
                idMovCreado = Convert.ToInt32(comando.ExecuteScalar());

                conexion.CerrarConexion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                comando.Parameters.Clear();
            }
            return idMovCreado;
        }

        public int GetTotalPlanesPendientes(int? idUsuario)
        {
            int total = 0;

            comando.CommandText = "GetTotalPlanesPendientes";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            try
            {
                comando.Connection = conexion.AbrirConexion();
                total = Convert.ToInt32(comando.ExecuteScalar());

                conexion.CerrarConexion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                comando.Parameters.Clear();
            }
            return total;
        }

        public bool FinalizarPlan(int? idUsuario, int? idPlan)
        {
            comando.CommandText = "FinalizarPlan";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            if (idPlan != null)
                comando.Parameters.AddWithValue("@ID_PLAN", idPlan);

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.ExecuteNonQuery();

                conexion.CerrarConexion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                comando.Parameters.Clear();
            }
            return true;

        }




    }
}
