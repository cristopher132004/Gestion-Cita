﻿
namespace Gestor_de_Citas
{
    partial class ConsultaServicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaServicio));
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LCantidadCita = new System.Windows.Forms.Label();
            this.bSalir = new System.Windows.Forms.Button();
            this.bUltimo = new System.Windows.Forms.Button();
            this.bSiguiente = new System.Windows.Forms.Button();
            this.bAnterior = new System.Windows.Forms.Button();
            this.bPrimero = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDatos
            // 
            this.DGVDatos.AllowUserToAddRows = false;
            this.DGVDatos.AllowUserToDeleteRows = false;
            this.DGVDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDatos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Location = new System.Drawing.Point(-2, 109);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.ReadOnly = true;
            this.DGVDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDatos.Size = new System.Drawing.Size(880, 383);
            this.DGVDatos.TabIndex = 19;
            this.DGVDatos.CurrentCellChanged += new System.EventHandler(this.DGVDatos_CurrentCellChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(107)))), ((int)(((byte)(123)))));
            this.panel3.Controls.Add(this.LCantidadCita);
            this.panel3.Controls.Add(this.bSalir);
            this.panel3.Controls.Add(this.bUltimo);
            this.panel3.Controls.Add(this.bSiguiente);
            this.panel3.Controls.Add(this.bAnterior);
            this.panel3.Controls.Add(this.bPrimero);
            this.panel3.Location = new System.Drawing.Point(-173, 487);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1147, 70);
            this.panel3.TabIndex = 18;
            // 
            // LCantidadCita
            // 
            this.LCantidadCita.AutoSize = true;
            this.LCantidadCita.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidadCita.Location = new System.Drawing.Point(634, 28);
            this.LCantidadCita.Name = "LCantidadCita";
            this.LCantidadCita.Size = new System.Drawing.Size(16, 19);
            this.LCantidadCita.TabIndex = 6;
            this.LCantidadCita.Text = ": ";
            // 
            // bSalir
            // 
            this.bSalir.FlatAppearance.BorderSize = 0;
            this.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSalir.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.Image = ((System.Drawing.Image)(resources.GetObject("bSalir.Image")));
            this.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSalir.Location = new System.Drawing.Point(945, 21);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 33);
            this.bSalir.TabIndex = 5;
            this.bSalir.Text = "Salir";
            this.bSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bUltimo
            // 
            this.bUltimo.FlatAppearance.BorderSize = 0;
            this.bUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUltimo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUltimo.Image = ((System.Drawing.Image)(resources.GetObject("bUltimo.Image")));
            this.bUltimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bUltimo.Location = new System.Drawing.Point(537, 21);
            this.bUltimo.Name = "bUltimo";
            this.bUltimo.Size = new System.Drawing.Size(84, 33);
            this.bUltimo.TabIndex = 3;
            this.bUltimo.Text = "&Ultimo";
            this.bUltimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bUltimo.UseVisualStyleBackColor = true;
            this.bUltimo.Click += new System.EventHandler(this.bUltimo_Click);
            // 
            // bSiguiente
            // 
            this.bSiguiente.FlatAppearance.BorderSize = 0;
            this.bSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSiguiente.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("bSiguiente.Image")));
            this.bSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSiguiente.Location = new System.Drawing.Point(425, 21);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(104, 33);
            this.bSiguiente.TabIndex = 2;
            this.bSiguiente.Text = "&Siguiente";
            this.bSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // bAnterior
            // 
            this.bAnterior.FlatAppearance.BorderSize = 0;
            this.bAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAnterior.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnterior.Image = ((System.Drawing.Image)(resources.GetObject("bAnterior.Image")));
            this.bAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAnterior.Location = new System.Drawing.Point(329, 21);
            this.bAnterior.Name = "bAnterior";
            this.bAnterior.Size = new System.Drawing.Size(95, 33);
            this.bAnterior.TabIndex = 1;
            this.bAnterior.Text = "&Anterior";
            this.bAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAnterior.UseVisualStyleBackColor = true;
            this.bAnterior.Click += new System.EventHandler(this.bAnterior_Click);
            // 
            // bPrimero
            // 
            this.bPrimero.FlatAppearance.BorderSize = 0;
            this.bPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrimero.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrimero.Image = ((System.Drawing.Image)(resources.GetObject("bPrimero.Image")));
            this.bPrimero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPrimero.Location = new System.Drawing.Point(223, 21);
            this.bPrimero.Name = "bPrimero";
            this.bPrimero.Size = new System.Drawing.Size(96, 33);
            this.bPrimero.TabIndex = 0;
            this.bPrimero.Text = "&Primero";
            this.bPrimero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bPrimero.UseVisualStyleBackColor = true;
            this.bPrimero.Click += new System.EventHandler(this.bPrimero_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.BConsultar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbBuscar);
            this.panel2.Location = new System.Drawing.Point(-173, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1213, 48);
            this.panel2.TabIndex = 17;
            // 
            // BConsultar
            // 
            this.BConsultar.BackColor = System.Drawing.Color.Transparent;
            this.BConsultar.FlatAppearance.BorderSize = 0;
            this.BConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BConsultar.Image = ((System.Drawing.Image)(resources.GetObject("BConsultar.Image")));
            this.BConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BConsultar.Location = new System.Drawing.Point(575, 6);
            this.BConsultar.Name = "BConsultar";
            this.BConsultar.Size = new System.Drawing.Size(110, 32);
            this.BConsultar.TabIndex = 2;
            this.BConsultar.Text = "Consultar";
            this.BConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BConsultar.UseVisualStyleBackColor = false;
            this.BConsultar.Click += new System.EventHandler(this.BConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(185, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese los datos a buscar";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(373, 12);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(196, 20);
            this.tbBuscar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(107)))), ((int)(((byte)(123)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-175, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 76);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(338, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultas Generales Servicios";
            // 
            // ConsultaServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 556);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Servicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultaServicio_FormClosing);
            this.Load += new System.EventHandler(this.ConsultaServicio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConsultaServicio_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LCantidadCita;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bUltimo;
        private System.Windows.Forms.Button bSiguiente;
        private System.Windows.Forms.Button bAnterior;
        private System.Windows.Forms.Button bPrimero;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}