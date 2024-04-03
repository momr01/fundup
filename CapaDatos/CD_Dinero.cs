using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Dinero
    {
        private CD_Conexion conexion = new CD_Conexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;

        public DataTable GetDinero(int? idUsuario, int? idDinero, char tipo)
        {
            comando.Connection = conexion.AbrirConexion();

            if (tipo == 'I')
                comando.CommandText = "GetIngresos";
            else if (tipo == 'G')
                comando.CommandText = "GetGastos";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            if(idDinero > 0)
            {
                comando.Parameters.AddWithValue("@idDinero", idDinero);
            }

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }

        
        public int InsertDinero(Dinero i, char tipo)
        {
            int idMovCreado = 0;

            if (tipo == 'I')
                comando.CommandText = "RegistrarIngreso";
            else if (tipo == 'G')
                comando.CommandText = "RegistrarGasto";

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

        public bool EditarDinero(int? idUsuario, Dinero i, char tipo)
        {
            if (tipo == 'I')
                comando.CommandText = "EditarIngreso";
            else if (tipo == 'G')
                comando.CommandText = "EditarGasto";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

            if (i.IdDinero != null)
                comando.Parameters.AddWithValue("@ID_DINERO", i.IdDinero);

            if (i.Categoria != null)
                comando.Parameters.AddWithValue("@ID_CATEGORIA", i.Categoria.IdCategoria);

            if (i.ImporteDinero != null)
                comando.Parameters.AddWithValue("@IMPORTE_DINERO", i.ImporteDinero);

            if (i.DescripcionDinero != null)
                comando.Parameters.AddWithValue("@DESCRIPCION_DINERO", i.DescripcionDinero);

            if (i.FechaDinero != null)
                comando.Parameters.AddWithValue("@FECHA_DINERO", i.FechaDinero);

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

        public bool AnularDinero(int? idUsuario, int? idDinero, char tipo)
        {
            if (tipo == 'I')
                comando.CommandText = "AnularIngreso";
            else if (tipo == 'G')
                comando.CommandText = "AnularGasto";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            if (idDinero != null)
                comando.Parameters.AddWithValue("@idDinero", idDinero);

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

        public List<Dinero> GetGraficoPorFecha(DateTime? fechaInicial, DateTime? fechaFinal, int? idUsuario, char tipo)
        {
            List<Dinero> lista = new List<Dinero>();

            if (tipo == 'I')
                comando.CommandText = "GraficoIngresosPorFecha";
            else if (tipo == 'G')
                comando.CommandText = "GraficoGastosPorFecha";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            if (fechaInicial != null)
                comando.Parameters.AddWithValue("@fechaInicial", fechaInicial);

            if (fechaFinal != null)
                comando.Parameters.AddWithValue("@fechaFinal", fechaFinal);

            try
            {
                comando.Connection = conexion.AbrirConexion();
                leer = comando.ExecuteReader();

                while(leer.Read())
                {
                    Dinero ing = new Dinero();
                    ing.FechaDinero = Convert.ToDateTime(leer["FECHA"]);
                    ing.ImporteDinero = Convert.ToInt32(leer["IMPORTE"]);
                    lista.Add(ing);
                }
                leer.Close();

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
            return lista;


        }



        public List<Dinero> GetGraficoPorCategorias(int? idUsuario, char tipo)
        {
            List<Dinero> lista = new List<Dinero>();

            if (tipo == 'I')
                comando.CommandText = "GraficoIngresosPorCategoria";
            else if (tipo == 'G')
                comando.CommandText = "GraficoGastosPorCategoria";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

           try
            {
                comando.Connection = conexion.AbrirConexion();
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    Dinero ing = new Dinero();
                    ing.ImporteDinero = Convert.ToInt32(leer["IMPORTE"]);

                    Categoria cat = new Categoria();
                    ing.Categoria = cat;
                    cat.NombreCategoria = leer["CATEGORIA"].ToString();

                    lista.Add(ing);
                }
                leer.Close();

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
            return lista;


        }


        public Dinero TableroImportesTotales(int? idUsuario, char tipo)
        {
            Dinero dinero = new Dinero();

            if (tipo == 'I')
                comando.CommandText = "TotalIngresos";
            else if (tipo == 'G')
                comando.CommandText = "TotalGastos";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            try
            {
                comando.Connection = conexion.AbrirConexion();
                leer = comando.ExecuteReader();

                if(leer.Read())
                {
                    dinero.ImporteDinero = Convert.ToInt32(leer["IMPORTE"]);
                }

                leer.Close();

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
            return dinero;


        }

        public Dinero TableroCategoriasUsadas(int? idUsuario, char tipo)
        {
            Dinero dinero = new Dinero();

            if (tipo == 'I')
                comando.CommandText = "CategoriasIngresos";
            else if (tipo == 'G')
                comando.CommandText = "CategoriasGastos";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            try
            {
                comando.Connection = conexion.AbrirConexion();
                leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    dinero.ImporteDinero = Convert.ToInt32(leer["CATEGORIAS_USADAS"]);
                }

                leer.Close();

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
            return dinero;


        }


        public Dinero TableroUltimaFecha(int? idUsuario)
        {
            Dinero dinero = new Dinero();

            comando.CommandText = "UltimaFecha";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            try
            {
                comando.Connection = conexion.AbrirConexion();
                leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    dinero.FechaDinero = Convert.ToDateTime(leer["ULTIMA_FECHA"]);
                }

                leer.Close();

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
            return dinero;


        }

        public DataTable GetDineroPorFechas(int? idUsuario, DateTime? fechaInicial, DateTime? fechaFinal)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListadoDineroPorFecha";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            comando.Parameters.AddWithValue("@fechaInicial", fechaInicial);
            comando.Parameters.AddWithValue("@fechaFinal", fechaFinal);

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable GetDineroTotal(int? idUsuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListadoDineroTotal";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }
    }
}
