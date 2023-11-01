using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Provincias
    {
        CD_Provincias CD_Provincias = new CD_Provincias();
        public List<Provincia> GetProvincias(Provincia p)
        {
            try
            {
                List<Provincia> listaProv = new List<Provincia>();
                listaProv = CD_Provincias.GetProvincias(p);
                return listaProv;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
