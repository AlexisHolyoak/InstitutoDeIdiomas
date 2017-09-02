namespace InstitutoDeIdiomas.ReportForms
{
    partial class frmRptFichaMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptFichaMatricula));
            this.FICHAMATRICULARPT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // FICHAMATRICULARPT
            // 
            this.FICHAMATRICULARPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FICHAMATRICULARPT.LocalReport.ReportEmbeddedResource = "InstitutoDeIdiomas.Reportes.rptFichaDeMatricula.rdlc";
            this.FICHAMATRICULARPT.Location = new System.Drawing.Point(0, 0);
            this.FICHAMATRICULARPT.Name = "FICHAMATRICULARPT";
            this.FICHAMATRICULARPT.ServerReport.BearerToken = null;
            this.FICHAMATRICULARPT.Size = new System.Drawing.Size(1104, 657);
            this.FICHAMATRICULARPT.TabIndex = 0;
            // 
            // frmRptFichaMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 657);
            this.Controls.Add(this.FICHAMATRICULARPT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRptFichaMatricula";
            this.Text = "REPORTE DE FICHA DE MATRICULA";
            this.Load += new System.EventHandler(this.frmRptFichaMatricula_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer FICHAMATRICULARPT;
    }
}