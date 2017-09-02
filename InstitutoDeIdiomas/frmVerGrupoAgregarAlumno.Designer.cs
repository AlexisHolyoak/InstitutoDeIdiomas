namespace InstitutoDeIdiomas
{
    partial class frmVerGrupoAgregarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerGrupoAgregarAlumno));
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewGrupo = new System.Windows.Forms.DataGridView();
            this.btnVerNotas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Enabled = false;
            this.btnAgregarAlumno.Location = new System.Drawing.Point(782, 312);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(75, 59);
            this.btnAgregarAlumno.TabIndex = 7;
            this.btnAgregarAlumno.Text = "AGREGAR ALUMNOS";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Visible = false;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SELECCIONE EL GRUPO";
            // 
            // dataGridViewGrupo
            // 
            this.dataGridViewGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupo.Location = new System.Drawing.Point(11, 33);
            this.dataGridViewGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewGrupo.Name = "dataGridViewGrupo";
            this.dataGridViewGrupo.RowTemplate.Height = 24;
            this.dataGridViewGrupo.Size = new System.Drawing.Size(760, 466);
            this.dataGridViewGrupo.TabIndex = 5;
            this.dataGridViewGrupo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGrupo_CellClick);
            // 
            // btnVerNotas
            // 
            this.btnVerNotas.Enabled = false;
            this.btnVerNotas.Location = new System.Drawing.Point(782, 126);
            this.btnVerNotas.Name = "btnVerNotas";
            this.btnVerNotas.Size = new System.Drawing.Size(75, 59);
            this.btnVerNotas.TabIndex = 8;
            this.btnVerNotas.Text = "VER GRUPO";
            this.btnVerNotas.UseVisualStyleBackColor = true;
            this.btnVerNotas.Visible = false;
            this.btnVerNotas.Click += new System.EventHandler(this.btnVerNotas_Click);
            // 
            // frmVerGrupoAgregarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 510);
            this.Controls.Add(this.btnVerNotas);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewGrupo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerGrupoAgregarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SELECCIONAR GRUPOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewGrupo;
        private System.Windows.Forms.Button btnVerNotas;
    }
}