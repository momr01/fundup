using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        CD_Categoria CD_Categoria = new CD_Categoria();
        public List<Categoria> GetCategorias()
        {
            try
            {
                List<Categoria> listaCategorias = new List<Categoria>();
                listaCategorias = CD_Categoria.GetCategorias();
                return listaCategorias;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
