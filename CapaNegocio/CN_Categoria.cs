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
    public class CN_Categoria
    {
        CD_Categoria CD_Categoria = new CD_Categoria();
        public List<Categoria> GetCategorias(int? idCategoria, int? idUsuario)
        {
            try
            {
                List<Categoria> listaCategorias = new List<Categoria>();
                listaCategorias = CD_Categoria.GetCategorias(idCategoria, idUsuario);
                return listaCategorias;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetTablaCategorias(int? idUsuario)
        {
            DataTable tabla = new DataTable();
            tabla = CD_Categoria.GetTablaCategorias(idUsuario);
            return tabla;
        }
        public int InsertCategoria(Categoria categoria)
        {
            try
            {
                return CD_Categoria.InsertCategoria(categoria);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EditarCategoria(Categoria categoria)
        {
            if (categoria.IdCategoria == null || String.IsNullOrEmpty(categoria.NombreCategoria) ||String.IsNullOrEmpty(categoria.DescripcionCategoria))
                return false;

            try
            {
                return CD_Categoria.EditarCategoria(categoria);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool AnularCategoria(int? idCategoria, int? idUsuario)
        {
            if (idCategoria == null)
                return false;

            try
            {
                return CD_Categoria.AnularCategoria(idCategoria, idUsuario);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
