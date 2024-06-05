using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Conexion
    {
        //conexion Maxi
        // private SqlConnection Conexion = new SqlConnection("data source=localhost;initial catalog=FUNDUP;user=code;password=Partition01");

        //conexion Anto
        //private SqlConnection Conexion = new SqlConnection("Server=localhost\\sqlexpress;Database= FUNDUP; Integrated Security=True;");

        //cloud
        private SqlConnection Conexion = new SqlConnection("Server=FUNDUPDB.mssql.somee.com;initial catalog=FUNDUPDB;user=fundup_SQLLogin_1;password=bkfjqa3oof");

        //cloud 2
        //private SqlConnection Conexion = new SqlConnection("Server=sql.bsite.net\\MSSQL2016;initial catalog=momr01_fundup;user=momr01_fundup;password=bkfjqa3oof");

        public SqlConnection AbrirConexion()
        {
                if (Conexion.State == ConnectionState.Closed)
                    Conexion.Open();
                return Conexion;
            
        }

        public SqlConnection CerrarConexion()
        {
            if(Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}