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
        SqlCommand comando = new SqlCommand();
        public List<Categoria> GetCategorias() 
        {
            List<Categoria> listaCategorias = new List<Categoria>();

            comando.CommandText = "GetCategorias";
            comando.CommandType = CommandType.StoredProcedure;

            try
            {
                comando.Connection = conexion.AbrirConexion();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Categoria cat = new Categoria();
                    cat.IdCategoria = Convert.ToInt32(reader["ID_CATEGORIA"]);
                    cat.NombreCategoria = Convert.ToString(reader["NOMBRE_CATEGORIA"]);

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
    }
}
