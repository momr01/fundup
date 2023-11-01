using CapaDatos;
using Entidades;
using System.Data;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario usuarioCD = new CD_Usuario();

        public Usuario IniciarSesion(string email, string password)
        {
            try
            {
                return usuarioCD.IniciarSesion(email, password);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int InsertUsuario(Usuario usuario)
        {
            try
            {
                return usuarioCD.InsertUsuario(usuario);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}