﻿
namespace Sistema_Barberia
{
    partial class FMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasYReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datosGeneralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porSuEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.datosGeneralesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porDisponibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porBarberoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFechaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.registrarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.consultarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.consultasYReportesToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salidaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantenimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoToolStripMenuItem.Image")));
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(129, 21);
            this.mantenimientoToolStripMenuItem.Text = "&Mantenimientos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.clientesToolStripMenuItem.Text = "&Clientes";
            this.clientesToolStripMenuItem.ToolTipText = "Crear y modificar los Datos del Cliente";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadosToolStripMenuItem.Image")));
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.empleadosToolStripMenuItem.Text = "&Empleados";
            this.empleadosToolStripMenuItem.ToolTipText = "Crear y Modificar los Datos de los Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioToolStripMenuItem.Image")));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.usuarioToolStripMenuItem.Text = "&Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citaToolStripMenuItem,
            this.pagoToolStripMenuItem});
            this.procesosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procesosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("procesosToolStripMenuItem.Image")));
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(89, 21);
            this.procesosToolStripMenuItem.Text = "&Procesos";
            // 
            // citaToolStripMenuItem
            // 
            this.citaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("citaToolStripMenuItem.Image")));
            this.citaToolStripMenuItem.Name = "citaToolStripMenuItem";
            this.citaToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.citaToolStripMenuItem.Text = "&Cita";
            this.citaToolStripMenuItem.ToolTipText = "Realización de Cita";
            this.citaToolStripMenuItem.Click += new System.EventHandler(this.citaToolStripMenuItem_Click);
            // 
            // pagoToolStripMenuItem
            // 
            this.pagoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pagoToolStripMenuItem.Image")));
            this.pagoToolStripMenuItem.Name = "pagoToolStripMenuItem";
            this.pagoToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.pagoToolStripMenuItem.Text = "&Pago";
            this.pagoToolStripMenuItem.Click += new System.EventHandler(this.pagoToolStripMenuItem_Click);
            // 
            // consultasYReportesToolStripMenuItem
            // 
            this.consultasYReportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.empleadosToolStripMenuItem1,
            this.citasToolStripMenuItem,
            this.pagosToolStripMenuItem});
            this.consultasYReportesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasYReportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasYReportesToolStripMenuItem.Image")));
            this.consultasYReportesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultasYReportesToolStripMenuItem.Name = "consultasYReportesToolStripMenuItem";
            this.consultasYReportesToolStripMenuItem.Size = new System.Drawing.Size(159, 21);
            this.consultasYReportesToolStripMenuItem.Text = "&Consultas y Reportes";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosGeneralesToolStripMenuItem,
            this.porSuEstadoToolStripMenuItem,
            this.consultarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem1.Image")));
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem1.Text = "&Clientes";
            // 
            // datosGeneralesToolStripMenuItem
            // 
            this.datosGeneralesToolStripMenuItem.Name = "datosGeneralesToolStripMenuItem";
            this.datosGeneralesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datosGeneralesToolStripMenuItem.Text = "Datos &Generales";
            this.datosGeneralesToolStripMenuItem.ToolTipText = "Visualizar e Imprimir los Datos Generales de los Cliente";
            this.datosGeneralesToolStripMenuItem.Click += new System.EventHandler(this.datosGeneralesToolStripMenuItem_Click);
            // 
            // porSuEstadoToolStripMenuItem
            // 
            this.porSuEstadoToolStripMenuItem.Name = "porSuEstadoToolStripMenuItem";
            this.porSuEstadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porSuEstadoToolStripMenuItem.Text = "Por su Estado";
            this.porSuEstadoToolStripMenuItem.ToolTipText = "Visualizar e Imprimir los Datos de los Clientes por su Estado";
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosGeneralesToolStripMenuItem1,
            this.porEstadoToolStripMenuItem,
            this.porDisponibilidadToolStripMenuItem});
            this.empleadosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("empleadosToolStripMenuItem1.Image")));
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.empleadosToolStripMenuItem1.Text = "&Empleados";
            // 
            // datosGeneralesToolStripMenuItem1
            // 
            this.datosGeneralesToolStripMenuItem1.Name = "datosGeneralesToolStripMenuItem1";
            this.datosGeneralesToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.datosGeneralesToolStripMenuItem1.Text = "Datos &Generales";
            this.datosGeneralesToolStripMenuItem1.ToolTipText = "Visualizar e Imprimir los Datos Generales de los Empleados";
            this.datosGeneralesToolStripMenuItem1.Click += new System.EventHandler(this.datosGeneralesToolStripMenuItem1_Click);
            // 
            // porEstadoToolStripMenuItem
            // 
            this.porEstadoToolStripMenuItem.Name = "porEstadoToolStripMenuItem";
            this.porEstadoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.porEstadoToolStripMenuItem.Text = "Por &Estado";
            this.porEstadoToolStripMenuItem.ToolTipText = "Visualizar e Imprimir los Datos de los empleados por su Estado";
            this.porEstadoToolStripMenuItem.Click += new System.EventHandler(this.porEstadoToolStripMenuItem_Click);
            // 
            // porDisponibilidadToolStripMenuItem
            // 
            this.porDisponibilidadToolStripMenuItem.Name = "porDisponibilidadToolStripMenuItem";
            this.porDisponibilidadToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.porDisponibilidadToolStripMenuItem.Text = "Por &Disponibilidad";
            this.porDisponibilidadToolStripMenuItem.ToolTipText = "Visualizar e Imprimir la disponibilidad de los empleados";
            this.porDisponibilidadToolStripMenuItem.Click += new System.EventHandler(this.porDisponibilidadToolStripMenuItem_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porFechaToolStripMenuItem,
            this.porClienteToolStripMenuItem,
            this.porBarberoToolStripMenuItem});
            this.citasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("citasToolStripMenuItem.Image")));
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.citasToolStripMenuItem.Text = "&Citas";
            // 
            // porFechaToolStripMenuItem
            // 
            this.porFechaToolStripMenuItem.Name = "porFechaToolStripMenuItem";
            this.porFechaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.porFechaToolStripMenuItem.Text = "Por &Fecha";
            this.porFechaToolStripMenuItem.ToolTipText = "Visualizar e Imprimir los Datos de las citas por fechas";
            this.porFechaToolStripMenuItem.Click += new System.EventHandler(this.porFechaToolStripMenuItem_Click);
            // 
            // porClienteToolStripMenuItem
            // 
            this.porClienteToolStripMenuItem.Name = "porClienteToolStripMenuItem";
            this.porClienteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.porClienteToolStripMenuItem.Text = "Por &Cliente";
            this.porClienteToolStripMenuItem.ToolTipText = "Visualizar e Imprimir los Datos de las citas por cliente";
            this.porClienteToolStripMenuItem.Click += new System.EventHandler(this.porClienteToolStripMenuItem_Click);
            // 
            // porBarberoToolStripMenuItem
            // 
            this.porBarberoToolStripMenuItem.Name = "porBarberoToolStripMenuItem";
            this.porBarberoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.porBarberoToolStripMenuItem.Text = "Por &Empleado";
            this.porBarberoToolStripMenuItem.ToolTipText = "Visualizar e Imprimir los Datos de las citas por empleado";
            this.porBarberoToolStripMenuItem.Click += new System.EventHandler(this.porBarberoToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porClientesToolStripMenuItem,
            this.porFechaToolStripMenuItem1,
            this.porNombreToolStripMenuItem});
            this.pagosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pagosToolStripMenuItem.Image")));
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pagosToolStripMenuItem.Text = "&Pagos";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.pagosToolStripMenuItem_Click);
            // 
            // porClientesToolStripMenuItem
            // 
            this.porClientesToolStripMenuItem.Name = "porClientesToolStripMenuItem";
            this.porClientesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.porClientesToolStripMenuItem.Text = "Datos Generales";
            this.porClientesToolStripMenuItem.Click += new System.EventHandler(this.porClientesToolStripMenuItem_Click);
            // 
            // porFechaToolStripMenuItem1
            // 
            this.porFechaToolStripMenuItem1.Name = "porFechaToolStripMenuItem1";
            this.porFechaToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.porFechaToolStripMenuItem1.Text = "Por Fecha";
            this.porFechaToolStripMenuItem1.Click += new System.EventHandler(this.porFechaToolStripMenuItem1_Click_1);
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.porNombreToolStripMenuItem.Text = "Por nombre";
            this.porNombreToolStripMenuItem.Click += new System.EventHandler(this.porNombreToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.restaurarToolStripMenuItem,
            this.toolStripSeparator1,
            this.registrarEmpresaToolStripMenuItem});
            this.seguridadToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seguridadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seguridadToolStripMenuItem.Image")));
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.seguridadToolStripMenuItem.Text = "&Seguridad";
            this.seguridadToolStripMenuItem.ToolTipText = "Registrar los Datos de la Empresa";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.seguridadToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backupToolStripMenuItem.Image")));
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.backupToolStripMenuItem.Text = "&Backup";
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restaurarToolStripMenuItem.Image")));
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.restaurarToolStripMenuItem.Text = "Restaurar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // registrarEmpresaToolStripMenuItem
            // 
            this.registrarEmpresaToolStripMenuItem.Name = "registrarEmpresaToolStripMenuItem";
            this.registrarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.registrarEmpresaToolStripMenuItem.Text = "Registrar &Empresa";
            this.registrarEmpresaToolStripMenuItem.ToolTipText = "Registrar los Datos de la Empresa";
            this.registrarEmpresaToolStripMenuItem.Click += new System.EventHandler(this.registrarEmpresaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acercaDeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercaDeToolStripMenuItem.Image")));
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.salidaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.salidaToolStripMenuItem.Text = "Salida";
            this.salidaToolStripMenuItem.Click += new System.EventHandler(this.salidaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.ToolTipText = "Salir del Sistema";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 706);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(395, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Copyright JAC-Software 2024 ,La Vega Rep. Dominicana";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(395, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "Fecha/Hora:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(395, 17);
            this.toolStripStatusLabel4.Spring = true;
            this.toolStripStatusLabel4.Text = "Usuario: Admin";
            this.toolStripStatusLabel4.Click += new System.EventHandler(this.toolStripStatusLabel4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // consultarClientesToolStripMenuItem
            // 
            this.consultarClientesToolStripMenuItem.Name = "consultarClientesToolStripMenuItem";
            this.consultarClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarClientesToolStripMenuItem.Text = "&Consultar Clientes";
            this.consultarClientesToolStripMenuItem.Click += new System.EventHandler(this.consultarClientesToolStripMenuItem_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 728);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gestión De Citas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMenu_FormClosing);
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasYReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem datosGeneralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porSuEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem registrarEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem datosGeneralesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porDisponibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porBarberoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFechaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClientesToolStripMenuItem;
    }
}