using CapaNegocio;
using Entidades;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CapaPresentacion.Formularios
{
    public partial class RegistroUsuarioForm : Form
    {
        //CN_RegistroUsuario CN_RegistroUsuario = new CN_RegistroUsuario();
        CN_Usuario CN_Usuario = new CN_Usuario();
        CN_Provincias CN_Provincias = new CN_Provincias();
        CN_Localidad CN_Localidad = new CN_Localidad();

        public RegistroUsuarioForm()
        {
            InitializeComponent();
            dtRegistroFechaNacimiento.MaxDate = DateTime.Today;
            dtRegistroFechaNacimiento.Value = DateTime.Today;

        }
        private void RegistroUsuarioForm_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboProvincias();
            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void Registrar()
        {
            if (validacionesUsuario())
            {
                try
                {
                    Usuario usuarioCrear = new Usuario();

                    usuarioCrear.nombreUsuario = txtRegistroNombre.Text.Trim();
                    usuarioCrear.apellidoUsuario = txtRegistroApellido.Text.Trim();
                    usuarioCrear.dniUsuario = Convert.ToInt32(txtRegistroDni.Text.Trim());
                    usuarioCrear.fechaNacimientoUsuario = dtRegistroFechaNacimiento.Value;
                    usuarioCrear.emailUsuario = txtRegistroEmail.Text.Trim();
                    usuarioCrear.contraseñaUsuario = txtRegistroContraseña.Text.Trim();
                    usuarioCrear.fechaNacimientoUsuario = dtRegistroFechaNacimiento.Value;

                    Tipo_Usuario tipoUsuario = new Tipo_Usuario();
                    tipoUsuario.idTipoUsuario = 1;
                    usuarioCrear.tipoUsuario = tipoUsuario;

                    Domicilio domicilioCrear = new Domicilio();
                    domicilioCrear.calleDomicilio = txtRegistroDomicilio.Text.Trim();
                    domicilioCrear.numeroDomicilio = Convert.ToInt32(txtRegistroNroDomicilio.Text.Trim());


                    Localidad localidadCrear = new Localidad();
                    localidadCrear.idLocalidad = (int)cboRegistroLocalidad.SelectedValue;
                    usuarioCrear.domicilioUsuario = domicilioCrear;
                    usuarioCrear.localidadUsuario = localidadCrear;


                    DialogResult registrar = MessageBox.Show("¿Confirma registrar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (registrar == DialogResult.No)
                    {
                        return;
                    }

                    //int idUsuarioCreado = CN_RegistroUsuario.InsertUsuario(usuarioCrear);
                    int idUsuarioCreado = CN_Usuario.InsertUsuario(usuarioCrear);
                    MessageBox.Show("Se registro el usuario correctamente", "Usuario registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Faltan ingresar datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool validacionesUsuario()
        {
            if (String.IsNullOrEmpty(txtRegistroNombre.Text))
            {
                return false; ;
            }

            if (String.IsNullOrEmpty(txtRegistroApellido.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtRegistroDni.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtRegistroEmail.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtRegistroContraseña.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtRegistroDomicilio.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtRegistroNroDomicilio.Text))
            {
                return false;
            }

            if (!IsValidEmail(txtRegistroEmail.Text))
            {
                return false;
            }

            if (cboRegistroLocalidad.SelectedValue == null)
            {
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();

                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void CargarComboProvincias()
        {
            cboRegistroProvincia.SelectedIndex = -1;
            Provincia provinciaCombo = new Provincia();
            List<Provincia> listaProv = new List<Provincia>();
            listaProv = CN_Provincias.GetProvincias(provinciaCombo);
            provinciaBindingSource.DataSource = listaProv;

           




        }
        private void CargarComboLocalidades(int idProv)
        {
            List<Localidad> listaLocalidades = new List<Localidad>();
            listaLocalidades = CN_Localidad.GetLocalidad(idProv);
            cboRegistroLocalidad.DataSource = listaLocalidades;
        }
        private void cboRegistroProvincia_SelectedValueChanged(object sender, EventArgs e)  //evento para que cambie combo box localidad
        {
            int idprov = (int)cboRegistroProvincia.SelectedIndex;
            idprov = idprov + 1;
            CargarComboLocalidades(idprov);
        }

        private void txtRegistroNombre_KeyPress(object sender, KeyPressEventArgs e) //limitar numeros nombre
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void txtRegistroApellido_KeyPress(object sender, KeyPressEventArgs e) //limitar numeros apellido
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void txtRegistroDni_KeyPress(object sender, KeyPressEventArgs e) //limitar solo numeros dni
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRegistroNroDomicilio_KeyPress(object sender, KeyPressEventArgs e) //limitar solo num en nro domicilio
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRegistroContraseña_KeyPress(object sender, KeyPressEventArgs e) //Limitar espacios contraseña
        {
            if ((char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
