using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Provincias
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();
        public List<Provincia> GetProvincias(Provincia p)  //Obtener provincias para completar combo box
        {
            List<Provincia> listaProvincias = new List<Provincia>();

            comando.CommandText = "GetProvincias";
            comando.CommandType = CommandType.StoredProcedure;

            if( p.nombreProvincia != null )
            {
                comando.Parameters.AddWithValue("@id",p.idProvincia);
            }

            try
            {
                comando.Connection = conexion.AbrirConexion();
                SqlDataReader reader = comando.ExecuteReader();

                while(reader.Read() ) { 
                    Provincia prov = new Provincia();
                    prov.idProvincia = Convert.ToInt32(reader["ID_PROVINCIA"]);
                    prov.nombreProvincia = Convert.ToString(reader["NOMBRE_PROVINCIA"]);

                    listaProvincias.Add(prov);
                }
                comando.Parameters.Clear();
                reader.Close();
                conexion.CerrarConexion();
            }
            catch ( Exception)
            {
                throw;
            }
            return listaProvincias;
        }
    }
}
