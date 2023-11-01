using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace CapaDatos
{
    public class CD_Localidad
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();

        public List<Localidad> GetLocalidades(int idProvinciaSeleccionada) //Obtener localidades para llenar combo box
        {

            List<Localidad> listaLocalidades = new List<Localidad>();
            comando.CommandText = "GetLocalidades";
            comando.CommandType = CommandType.StoredProcedure;

            
           comando.Parameters.AddWithValue("@idProv", idProvinciaSeleccionada);
            

            try
            {
                comando.Connection = conexion.AbrirConexion();
   
                SqlDataReader reader = comando.ExecuteReader();
                
                while (reader.Read())
                {
                    Localidad lo = new Localidad();
                    lo.idLocalidad = Convert.ToInt32(reader["ID_LOCALIDAD"]);
                    lo.nombreLocalidad = Convert.ToString(reader["NOMBRE_LOCALIDAD"]);

                    listaLocalidades.Add(lo);
                    
                }
                comando.Parameters.Clear();
                reader.Close();
                conexion.CerrarConexion();
            }
            catch (Exception)
            {
                throw;
            }
            return listaLocalidades;
        }
    }
}

