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
    public class CN_Localidad
    {
        CD_Localidad CD_Localidad = new CD_Localidad();
        public List<Localidad> GetLocalidad(int idProvSeleccionada)
        {
            try
            {
                
                List<Localidad> listaLocalidades = new List<Localidad>();
                listaLocalidades = CD_Localidad.GetLocalidades(idProvSeleccionada);
                return listaLocalidades;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

