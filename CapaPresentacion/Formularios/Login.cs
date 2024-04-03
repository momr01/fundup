using CapaNegocio;
using CapaPresentacion.Formularios;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class LoginForm : Form
    {
        CN_Usuario usuarioCN = new CN_Usuario();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private bool isFormValid()
        {
            if (txtEmail.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El Email y la Contraseña son requeridos.", "Ingrese su Email y Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Ingresar()
        {
            if (isFormValid())
            {
                try
                {
                    Usuario usuarioExistente = usuarioCN.IniciarSesion(txtEmail.Text.Trim(), txtPassword.Text.Trim());

                    if (usuarioExistente.emailUsuario == null && usuarioExistente.contraseñaUsuario == null)
                    {
                        MessageBox.Show("Error al intentar iniciar sesión. Por favor, verifique los datos ingresados e inténtelo nuevamente más tarde.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtEmail.Text = "";
                        txtPassword.Text = "";
                        txtEmail.Focus();
                        MessageBox.Show("Inicio de sesión exitoso.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        using (DashboardForm df = new DashboardForm(usuarioExistente))
                        {
                            df.ShowDialog();
                        }
                    }


                }
                catch
                {
                    throw;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Ingresar();
            /*if (isFormValid())
            {
                try
                {
                    Usuario usuarioExistente = usuarioCN.IniciarSesion(txtEmail.Text.Trim(), txtPassword.Text.Trim());

                    if (usuarioExistente.emailUsuario == null && usuarioExistente.contraseñaUsuario == null)
                    {
                        MessageBox.Show("Error al intentar iniciar sesión. Por favor, verifique los datos ingresados e inténtelo nuevamente más tarde.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtEmail.Text = "";
                        txtPassword.Text = "";
                        txtEmail.Focus();
                        MessageBox.Show("Inicio de sesión exitoso.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        using (DashboardForm df = new DashboardForm(usuarioExistente))
                        {
                            df.ShowDialog();
                        }
                    }


                }
                catch
                {
                    throw;
                }
            }*/
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void lblRegistrate_Click(object sender, EventArgs e)  //Abrir form Registro Usuario
        {
            using (RegistroUsuarioForm ru = new RegistroUsuarioForm())
            {
                ru.ShowDialog();
            }
        }



        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Ingresar();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Ingresar();
            }
        }
    }
}
