﻿namespace Catalogo_Karina
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.bttnListarInvertido = new System.Windows.Forms.Button();
            this.bttnEliminarPrimero = new System.Windows.Forms.Button();
            this.bttnEliminarUltimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(26, 172);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(417, 231);
            this.txtResultado.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(226, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 32);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(226, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(226, 86);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 31);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(226, 123);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 31);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(23, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Costo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(80, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(135, 22);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(135, 22);
            this.txtNombre.TabIndex = 9;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(80, 84);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(135, 22);
            this.txtCantidad.TabIndex = 10;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(80, 113);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(135, 22);
            this.txtCosto.TabIndex = 11;
            // 
            // bttnListarInvertido
            // 
            this.bttnListarInvertido.Location = new System.Drawing.Point(307, 124);
            this.bttnListarInvertido.Name = "bttnListarInvertido";
            this.bttnListarInvertido.Size = new System.Drawing.Size(156, 31);
            this.bttnListarInvertido.TabIndex = 25;
            this.bttnListarInvertido.Text = "Listar invertido";
            this.bttnListarInvertido.UseVisualStyleBackColor = true;
            this.bttnListarInvertido.Click += new System.EventHandler(this.bttnListarInvertido_Click);
            // 
            // bttnEliminarPrimero
            // 
            this.bttnEliminarPrimero.Location = new System.Drawing.Point(307, 49);
            this.bttnEliminarPrimero.Name = "bttnEliminarPrimero";
            this.bttnEliminarPrimero.Size = new System.Drawing.Size(156, 31);
            this.bttnEliminarPrimero.TabIndex = 24;
            this.bttnEliminarPrimero.Text = "Eliminar primero";
            this.bttnEliminarPrimero.UseVisualStyleBackColor = true;
            this.bttnEliminarPrimero.Click += new System.EventHandler(this.bttnEliminarPrimero_Click);
            // 
            // bttnEliminarUltimo
            // 
            this.bttnEliminarUltimo.Location = new System.Drawing.Point(307, 87);
            this.bttnEliminarUltimo.Name = "bttnEliminarUltimo";
            this.bttnEliminarUltimo.Size = new System.Drawing.Size(156, 31);
            this.bttnEliminarUltimo.TabIndex = 23;
            this.bttnEliminarUltimo.Text = "Eliminar ultimo";
            this.bttnEliminarUltimo.UseVisualStyleBackColor = true;
            this.bttnEliminarUltimo.Click += new System.EventHandler(this.bttnEliminarUltimo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 437);
            this.Controls.Add(this.bttnListarInvertido);
            this.Controls.Add(this.bttnEliminarPrimero);
            this.Controls.Add(this.bttnEliminarUltimo);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button bttnListarInvertido;
        private System.Windows.Forms.Button bttnEliminarPrimero;
        private System.Windows.Forms.Button bttnEliminarUltimo;
    }
}

