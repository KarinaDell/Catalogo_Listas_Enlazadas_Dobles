﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo_Karina
{
    public partial class Form1 : Form
    {
        Catalogo catalogo = new Catalogo();
        Producto producto;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            producto = new Producto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToDouble(txtCosto.Text));
            catalogo.Agregar(producto);
            txtCodigo.Text = txtNombre.Text = txtCantidad.Text = txtCosto.Text = "";
            txtCodigo.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = catalogo.Buscar(Convert.ToInt32(txtCodigo.Text)).ToString();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            producto = new Producto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToDouble(txtCosto.Text));
            catalogo.Insertar(producto, Convert.ToInt32(txtPosicion.Text));
            txtCodigo.Text = txtNombre.Text = txtCantidad.Text = txtCosto.Text = "";
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            catalogo.Eliminar(Convert.ToInt32(txtCodigo.Text));
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = catalogo.Listar();
        }

        private void bttnEliminarPrimero_Click(object sender, EventArgs e)
        {
            catalogo.EliminarPrimero();
        }

        private void bttnAgregarPrimero_Click(object sender, EventArgs e)
        {
            producto = new Producto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToDouble(txtCosto.Text));
            catalogo.AgregarInicio(producto);
        }

        private void bttnInvertirLista_Click(object sender, EventArgs e)
        {
            catalogo.InvertirLista();
        }

        private void bttnEliminarUltimo_Click(object sender, EventArgs e)
        {
            catalogo.EliminarUltimo();
        }

        private void bttnListarInvertido_Click(object sender, EventArgs e)
        {
            txtResultado.Text = catalogo.ReporteInverso();
        }
    }
}
