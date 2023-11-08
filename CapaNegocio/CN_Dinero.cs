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
    public class CN_Dinero
    {
        CD_Dinero CD_Dinero = new CD_Dinero();

        public DataTable GetDinero(int? idUsuario, int? idDinero, char tipo)
        {
            DataTable tabla = new DataTable();
            tabla = CD_Dinero.GetDinero(idUsuario, idDinero, tipo);
            return tabla;
        }
        public int InsertDinero(Dinero dinero, char tipo)
        {
            try
            {
                return CD_Dinero.InsertDinero(dinero, tipo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EditarDinero(int? idUsuario, Dinero dinero, char tipo)
        {
            if (dinero.IdDinero == null || idUsuario == null || String.IsNullOrEmpty(dinero.DescripcionDinero)
                || dinero.ImporteDinero == null || dinero.Categoria?.IdCategoria == null)
                return false;

            if(dinero.FechaDinero == null)
                dinero.FechaDinero = DateTime.Now;

           
            try
            {
                return CD_Dinero.EditarDinero(idUsuario, dinero, tipo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool AnularDinero(int? idUsuario, int? idDinero, char tipo)
        {
            if (idDinero == null || idUsuario == null)
                return false;

            try
            {
                return CD_Dinero.AnularDinero(idUsuario, idDinero, tipo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Dinero> GetGraficoPorFecha(DateTime? fechaInicial,DateTime? fechaFinal, int? idUsuario, char tipo)
        {
            //List<Dinero> lista = new List<Dinero>();

            try
            {
                return CD_Dinero.GetGraficoPorFecha(fechaInicial, fechaFinal, idUsuario, tipo);
            }
            catch(Exception)
            {
                throw;
            }
                
        }

        public List<Dinero> GetGraficoPorCategorias(int? idUsuario, char tipo)
        {
            //List<Dinero> lista = new List<Dinero>();

            try
            {
                return CD_Dinero.GetGraficoPorCategorias(idUsuario, tipo);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Dinero TableroImportesTotales(int? idUsuario, char tipo)
        {
            //Dinero dinero = new Dinero();

            try
            {
                return CD_Dinero.TableroImportesTotales(idUsuario, tipo);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Dinero TableroCategoriasUsadas(int? idUsuario, char tipo)
        {
            try
            {
                return CD_Dinero.TableroCategoriasUsadas(idUsuario, tipo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Dinero TableroUltimaFecha(int? idUsuario)
        {
            try
            {
                return CD_Dinero.TableroUltimaFecha(idUsuario);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
