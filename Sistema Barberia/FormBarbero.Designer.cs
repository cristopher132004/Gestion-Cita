﻿
namespace Sistema_Barberia
{
    partial class FormBarbero
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DBCitaDataSet2 = new Sistema_Barberia.DBCitaDataSet2();
            this.BarberoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BarberoTableAdapter = new Sistema_Barberia.DBCitaDataSet2TableAdapters.BarberoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DBCitaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarberoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BarberoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Barberia.ReporteBbeo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DBCitaDataSet2
            // 
            this.DBCitaDataSet2.DataSetName = "DBCitaDataSet2";
            this.DBCitaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BarberoBindingSource
            // 
            this.BarberoBindingSource.DataMember = "Barbero";
            this.BarberoBindingSource.DataSource = this.DBCitaDataSet2;
            // 
            // BarberoTableAdapter
            // 
            this.BarberoTableAdapter.ClearBeforeFill = true;
            // 
            // FormBarbero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormBarbero";
            this.Text = "FormBarbero";
            this.Load += new System.EventHandler(this.FormBarbero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBCitaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarberoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BarberoBindingSource;
        private DBCitaDataSet2 DBCitaDataSet2;
        private DBCitaDataSet2TableAdapters.BarberoTableAdapter BarberoTableAdapter;
    }
}