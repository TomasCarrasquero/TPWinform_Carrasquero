﻿using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinform_Carrasquero
{
    public partial class FrmMarca : Form
    {
        private List<Marca> listaMarca;
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            CargarMarca();
        }

        private void CargarMarca()
        {
            MarcaNegocio negocio = new MarcaNegocio();

            listaMarca = negocio.listar();
            dvgMarca.DataSource = listaMarca;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarMarca alta = new frmAgregarMarca();
            if (alta.ShowDialog() == DialogResult.OK)
            {
                CargarMarca();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dvgMarca.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un registro");
                return;

            }
            Marca seleccionado = (Marca)dvgMarca.CurrentRow.DataBoundItem;

            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar el registro?", "eliminar registro", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MarcaNegocio marcanegocio = new MarcaNegocio();
                marcanegocio.eliminar(seleccionado.id);

                MessageBox.Show("El registro se ha eliminado con exito");

                CargarMarca();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dvgMarca.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un registro");
                return;
            }

            Marca seleccionado = (Marca)dvgMarca.CurrentRow.DataBoundItem;

            frmAgregarMarca editar = new frmAgregarMarca(seleccionado);

            if (editar.ShowDialog() == DialogResult.OK)
            {
                CargarMarca();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
