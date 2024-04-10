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
    public class CD_Categoria
    {
        private CD_Conexion conexion = new CD_Conexion();
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        public List<Categoria> GetCategorias(int? idCategoria, int? idUsuario) 
        {
            List<Categoria> listaCategorias = new List<Categoria>();

            comando.CommandText = "GetCategorias";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            if (idCategoria > 0)
                comando.Parameters.AddWithValue("@idCategoria", idCategoria);

            try
            {
                comando.Connection = conexion.AbrirConexion();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Categoria cat = new Categoria();
                    cat.IdCategoria = Convert.ToInt32(reader["ID"]);
                    cat.NombreCategoria = Convert.ToString(reader["NOMBRE"]);
                    cat.DescripcionCategoria = Convert.ToString(reader["DESCRIPCION"]);

                    listaCategorias.Add(cat);
                }
                comando.Parameters.Clear();
                reader.Close();
                conexion.CerrarConexion();
            }
            catch (Exception)
            {
                throw;
            }
            return listaCategorias;
        }

        public DataTable GetTablaCategorias(int? idUsuario)
        {
            comando.Connection = conexion.AbrirConexion();

           
                comando.CommandText = "GetCategorias";
          

            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }

        public int InsertCategoria(Categoria c)
        {
            int idMovCreado = 0;

                comando.CommandText = "RegistrarCategoria";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@ID_USUARIO", c.Usuario!.idUsuario);

            if (c.NombreCategoria != null)
                comando.Parameters.AddWithValue("@NOMBRE_CATEGORIA", c.NombreCategoria);

            if (c.DescripcionCategoria != null)
                comando.Parameters.AddWithValue("@DESCRIPCION_CATEGORIA", c.DescripcionCategoria);

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

        public bool EditarCategoria(Categoria c)
        {
           
                comando.CommandText = "EditarCategoria";

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@ID_USUARIO", c.Usuario!.idUsuario);

            if (c.IdCategoria != null)
                comando.Parameters.AddWithValue("@ID_CATEGORIA", c.IdCategoria);

            if (c.NombreCategoria != null)
                comando.Parameters.AddWithValue("@NOMBRE_CATEGORIA", c.NombreCategoria);

            if (c.DescripcionCategoria != null)
                comando.Parameters.AddWithValue("@DESCRIPCION_CATEGORIA", c.DescripcionCategoria);

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

        public bool AnularCategoria(int? idCategoria, int? idUsuario)
        {
                comando.CommandText = "AnularCategoria";

            comando.CommandType = CommandType.StoredProcedure;

            if(idCategoria != null)
                comando.Parameters.AddWithValue("@idCategoria", idCategoria);

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

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
