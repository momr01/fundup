﻿using CapaDatos;
using CapaNegocio;
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

namespace CapaPresentacion.Formularios
{
    public partial class EditarCategoria : Form
    {

        CN_Categoria CN_Categoria = new CN_Categoria();

        int _idCategoria;
        int? _idUsuario;
        public EditarCategoria(int? idUsuario, int idCategoria)
        {
            InitializeComponent();
            _idCategoria = idCategoria;
            _idUsuario = idUsuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }



        private void EditarCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarDatosCategoria();
            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }
        }

        private void MostrarDatosCategoria()
        {
            try
            {
                CN_Categoria categoria = new CN_Categoria();
                var data = categoria.GetCategorias(_idCategoria, _idUsuario);

                txtNombre.Text = data[0].NombreCategoria;
                txtDescripcion.Text = data[0].DescripcionCategoria;
            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }

        }

        private bool FormularioValido()
        {
            if (txtDescripcion.Text.Length == 0 || txtNombre.Text.Length == 0)
            {

                return false;
            }

            return true;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!FormularioValido())
            {
                MessageBox.Show("Verifique los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Categoria catModificada = new Categoria();
                    catModificada.IdCategoria = _idCategoria;
                    catModificada.NombreCategoria = txtNombre.Text;
                    catModificada.DescripcionCategoria = txtDescripcion.Text;

                    catModificada.Usuario = new Usuario();
                    catModificada.Usuario.idUsuario = Convert.ToInt32(_idUsuario);

                    DialogResult editar = MessageBox.Show("¿Confirma edición?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (editar == DialogResult.No)
                    {
                        return;
                    }

                    CN_Categoria.EditarCategoria(catModificada);
                    MessageBox.Show("Se modificó la categoría correctamente.", "Categoría editada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();

                }
                catch
                {
                    MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
