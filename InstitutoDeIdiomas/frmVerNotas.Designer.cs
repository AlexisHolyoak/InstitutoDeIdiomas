using InstitutoDeIdiomas.DataSetsIdiomas;

namespace InstitutoDeIdiomas
{
    partial class frmVerNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerNotas));
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetRelacionAlumno = new InstitutoDeIdiomas.DataSetsIdiomas.DataSetRelacionAlumno();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHorario2 = new System.Windows.Forms.TextBox();
            this.txtSalon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtCiclo = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvwNotas = new System.Windows.Forms.DataGridView();
            this.cmbTipoNota = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvwBase = new System.Windows.Forms.DataGridView();
            this.dgvwListening = new System.Windows.Forms.DataGridView();
            this.dgvwReading = new System.Windows.Forms.DataGridView();
            this.dgvwSpeaking = new System.Windows.Forms.DataGridView();
            this.dgvwWriting = new System.Windows.Forms.DataGridView();
            this.dgvwUseOfEnglish = new System.Windows.Forms.DataGridView();
            this.btnConcluirGrupo = new System.Windows.Forms.Button();
            this.btnRelacionAlumno = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDocente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRelacionAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwListening)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwReading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSpeaking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwWriting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwUseOfEnglish)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSetRelacionAlumno;
            // 
            // DataSetRelacionAlumno
            // 
            this.DataSetRelacionAlumno.DataSetName = "DataSetRelacionAlumno";
            this.DataSetRelacionAlumno.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "--";
            // 
            // txtHorario2
            // 
            this.txtHorario2.Location = new System.Drawing.Point(349, 63);
            this.txtHorario2.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorario2.Name = "txtHorario2";
            this.txtHorario2.ReadOnly = true;
            this.txtHorario2.Size = new System.Drawing.Size(53, 20);
            this.txtHorario2.TabIndex = 57;
            // 
            // txtSalon
            // 
            this.txtSalon.Location = new System.Drawing.Point(78, 90);
            this.txtSalon.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.ReadOnly = true;
            this.txtSalon.Size = new System.Drawing.Size(122, 20);
            this.txtSalon.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 93);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "SALON";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(280, 63);
            this.txtHorario.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.ReadOnly = true;
            this.txtHorario.Size = new System.Drawing.Size(53, 20);
            this.txtHorario.TabIndex = 54;
            // 
            // txtCiclo
            // 
            this.txtCiclo.Location = new System.Drawing.Point(280, 38);
            this.txtCiclo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.ReadOnly = true;
            this.txtCiclo.Size = new System.Drawing.Size(122, 20);
            this.txtCiclo.TabIndex = 53;
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(78, 63);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(2);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.ReadOnly = true;
            this.txtNivel.Size = new System.Drawing.Size(122, 20);
            this.txtNivel.TabIndex = 52;
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(78, 38);
            this.txtIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.ReadOnly = true;
            this.txtIdioma.Size = new System.Drawing.Size(122, 20);
            this.txtIdioma.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "NIVEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "CICLO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "HORARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "IDIOMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "DETALLE DEL GRUPO SELECCIONADO";
            // 
            // dgvwNotas
            // 
            this.dgvwNotas.AllowUserToAddRows = false;
            this.dgvwNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwNotas.Location = new System.Drawing.Point(24, 207);
            this.dgvwNotas.Name = "dgvwNotas";
            this.dgvwNotas.ReadOnly = true;
            this.dgvwNotas.Size = new System.Drawing.Size(794, 392);
            this.dgvwNotas.TabIndex = 60;
            // 
            // cmbTipoNota
            // 
            this.cmbTipoNota.FormattingEnabled = true;
            this.cmbTipoNota.Items.AddRange(new object[] {
            "LISTENING",
            "READING",
            "WRITING",
            "SPEAKING",
            "USE OF ENGLISH",
            "RESULTADOS HASTA AHORA"});
            this.cmbTipoNota.Location = new System.Drawing.Point(241, 121);
            this.cmbTipoNota.Name = "cmbTipoNota";
            this.cmbTipoNota.Size = new System.Drawing.Size(229, 21);
            this.cmbTipoNota.TabIndex = 61;
            this.cmbTipoNota.TextChanged += new System.EventHandler(this.cmbTipoNota_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 62;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Selecciona el criterio de nota o resultado";
            // 
            // dgvwBase
            // 
            this.dgvwBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwBase.Location = new System.Drawing.Point(778, 565);
            this.dgvwBase.Name = "dgvwBase";
            this.dgvwBase.Size = new System.Drawing.Size(40, 34);
            this.dgvwBase.TabIndex = 64;
            this.dgvwBase.Visible = false;
            // 
            // dgvwListening
            // 
            this.dgvwListening.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwListening.Location = new System.Drawing.Point(779, 571);
            this.dgvwListening.Name = "dgvwListening";
            this.dgvwListening.Size = new System.Drawing.Size(39, 28);
            this.dgvwListening.TabIndex = 65;
            // 
            // dgvwReading
            // 
            this.dgvwReading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwReading.Location = new System.Drawing.Point(778, 571);
            this.dgvwReading.Name = "dgvwReading";
            this.dgvwReading.Size = new System.Drawing.Size(39, 28);
            this.dgvwReading.TabIndex = 66;
            // 
            // dgvwSpeaking
            // 
            this.dgvwSpeaking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwSpeaking.Location = new System.Drawing.Point(773, 571);
            this.dgvwSpeaking.Name = "dgvwSpeaking";
            this.dgvwSpeaking.Size = new System.Drawing.Size(44, 28);
            this.dgvwSpeaking.TabIndex = 67;
            // 
            // dgvwWriting
            // 
            this.dgvwWriting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwWriting.Location = new System.Drawing.Point(776, 570);
            this.dgvwWriting.Name = "dgvwWriting";
            this.dgvwWriting.Size = new System.Drawing.Size(41, 29);
            this.dgvwWriting.TabIndex = 68;
            // 
            // dgvwUseOfEnglish
            // 
            this.dgvwUseOfEnglish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwUseOfEnglish.Location = new System.Drawing.Point(779, 570);
            this.dgvwUseOfEnglish.Name = "dgvwUseOfEnglish";
            this.dgvwUseOfEnglish.Size = new System.Drawing.Size(39, 28);
            this.dgvwUseOfEnglish.TabIndex = 69;
            // 
            // btnConcluirGrupo
            // 
            this.btnConcluirGrupo.Location = new System.Drawing.Point(587, 35);
            this.btnConcluirGrupo.Name = "btnConcluirGrupo";
            this.btnConcluirGrupo.Size = new System.Drawing.Size(196, 44);
            this.btnConcluirGrupo.TabIndex = 70;
            this.btnConcluirGrupo.Text = "CONCLUIR GRUPO";
            this.btnConcluirGrupo.UseVisualStyleBackColor = true;
            this.btnConcluirGrupo.Click += new System.EventHandler(this.btnConcluirGrupo_Click);
            // 
            // btnRelacionAlumno
            // 
            this.btnRelacionAlumno.Location = new System.Drawing.Point(587, 124);
            this.btnRelacionAlumno.Name = "btnRelacionAlumno";
            this.btnRelacionAlumno.Size = new System.Drawing.Size(196, 44);
            this.btnRelacionAlumno.TabIndex = 71;
            this.btnRelacionAlumno.Text = "ACTA RELACION DE ALUMNOS";
            this.btnRelacionAlumno.UseVisualStyleBackColor = true;
            this.btnRelacionAlumno.Click += new System.EventHandler(this.btnRelacionAlumno_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "DOCENTE";
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(280, 90);
            this.txtDocente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.ReadOnly = true;
            this.txtDocente.Size = new System.Drawing.Size(238, 20);
            this.txtDocente.TabIndex = 73;
            // 
            // frmVerNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 611);
            this.Controls.Add(this.txtDocente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRelacionAlumno);
            this.Controls.Add(this.btnConcluirGrupo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoNota);
            this.Controls.Add(this.dgvwNotas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtHorario2);
            this.Controls.Add(this.txtSalon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtCiclo);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvwBase);
            this.Controls.Add(this.dgvwUseOfEnglish);
            this.Controls.Add(this.dgvwWriting);
            this.Controls.Add(this.dgvwSpeaking);
            this.Controls.Add(this.dgvwReading);
            this.Controls.Add(this.dgvwListening);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VER NOTAS";
            this.Load += new System.EventHandler(this.frmVerNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRelacionAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwListening)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwReading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwSpeaking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwWriting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwUseOfEnglish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHorario2;
        private System.Windows.Forms.TextBox txtSalon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtCiclo;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoNota;
        private System.Windows.Forms.DataGridView dgvwNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvwBase;
        private System.Windows.Forms.DataGridView dgvwListening;
        private System.Windows.Forms.DataGridView dgvwReading;
        private System.Windows.Forms.DataGridView dgvwSpeaking;
        private System.Windows.Forms.DataGridView dgvwWriting;
        private System.Windows.Forms.DataGridView dgvwUseOfEnglish;
        private System.Windows.Forms.Button btnConcluirGrupo;
        private System.Windows.Forms.Button btnRelacionAlumno;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSetRelacionAlumno DataSetRelacionAlumno;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.Label label8;
    }
}