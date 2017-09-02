namespace InstitutoDeIdiomas
{
    partial class frmRegistroAuxiliar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroAuxiliar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtInicioCurso = new System.Windows.Forms.TextBox();
            this.txtSalon = new System.Windows.Forms.TextBox();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvwAlumnos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTerminarClase = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.cmbTipoNota = new System.Windows.Forms.ComboBox();
            this.btnAgregarCriterio = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.ERRORESREGAUX = new System.Windows.Forms.ErrorProvider(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.txtHoraFinal = new System.Windows.Forms.TextBox();
            this.txtCiclo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFinReading = new System.Windows.Forms.Button();
            this.btnFinWriting = new System.Windows.Forms.Button();
            this.btnFinListening = new System.Windows.Forms.Button();
            this.btnFinUseOfEnglish = new System.Windows.Forms.Button();
            this.btnFinSpeaking = new System.Windows.Forms.Button();
            this.dtpFechaClase = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERRORESREGAUX)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CURSO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "BIENVENIDO AL REGISTRO AUXILIAR DE DOCENTES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIVEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "INICIO DEL CURSO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CICLO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "HORARIO";
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(116, 41);
            this.txtIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.ReadOnly = true;
            this.txtIdioma.Size = new System.Drawing.Size(144, 20);
            this.txtIdioma.TabIndex = 6;
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(116, 64);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(2);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.ReadOnly = true;
            this.txtNivel.Size = new System.Drawing.Size(144, 20);
            this.txtNivel.TabIndex = 7;
            // 
            // txtInicioCurso
            // 
            this.txtInicioCurso.Location = new System.Drawing.Point(116, 87);
            this.txtInicioCurso.Margin = new System.Windows.Forms.Padding(2);
            this.txtInicioCurso.Name = "txtInicioCurso";
            this.txtInicioCurso.ReadOnly = true;
            this.txtInicioCurso.Size = new System.Drawing.Size(144, 20);
            this.txtInicioCurso.TabIndex = 8;
            // 
            // txtSalon
            // 
            this.txtSalon.Location = new System.Drawing.Point(362, 65);
            this.txtSalon.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.ReadOnly = true;
            this.txtSalon.Size = new System.Drawing.Size(163, 20);
            this.txtSalon.TabIndex = 10;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(362, 88);
            this.txtHoraInicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.ReadOnly = true;
            this.txtHoraInicio.Size = new System.Drawing.Size(70, 20);
            this.txtHoraInicio.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(17, 119);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 10);
            this.panel1.TabIndex = 13;
            // 
            // dgvwAlumnos
            // 
            this.dgvwAlumnos.AllowUserToAddRows = false;
            this.dgvwAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvwAlumnos.Location = new System.Drawing.Point(22, 244);
            this.dgvwAlumnos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvwAlumnos.Name = "dgvwAlumnos";
            this.dgvwAlumnos.RowTemplate.Height = 24;
            this.dgvwAlumnos.Size = new System.Drawing.Size(503, 315);
            this.dgvwAlumnos.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(382, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "NOTAS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(564, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "FECHA DE CLASE ";
            // 
            // btnTerminarClase
            // 
            this.btnTerminarClase.Enabled = false;
            this.btnTerminarClase.Location = new System.Drawing.Point(591, 379);
            this.btnTerminarClase.Margin = new System.Windows.Forms.Padding(2);
            this.btnTerminarClase.Name = "btnTerminarClase";
            this.btnTerminarClase.Size = new System.Drawing.Size(133, 60);
            this.btnTerminarClase.TabIndex = 14;
            this.btnTerminarClase.Text = "TERMINAR LA CLASE DE HOY";
            this.btnTerminarClase.UseVisualStyleBackColor = true;
            this.btnTerminarClase.Click += new System.EventHandler(this.BTNSAVEREGAUX_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 166);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(256, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "AGREGAR CRITERIOS PARA LA SESION DE HOY\r\n";
            // 
            // txtCriterio
            // 
            this.txtCriterio.Enabled = false;
            this.txtCriterio.Location = new System.Drawing.Point(167, 195);
            this.txtCriterio.Margin = new System.Windows.Forms.Padding(2);
            this.txtCriterio.Multiline = true;
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(283, 32);
            this.txtCriterio.TabIndex = 15;
            // 
            // cmbTipoNota
            // 
            this.cmbTipoNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoNota.Enabled = false;
            this.cmbTipoNota.FormattingEnabled = true;
            this.cmbTipoNota.Items.AddRange(new object[] {
            "USE OF ENGLISH",
            "READING",
            "WRITING",
            "LISTENING",
            "SPEAKING"});
            this.cmbTipoNota.Location = new System.Drawing.Point(22, 195);
            this.cmbTipoNota.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoNota.Name = "cmbTipoNota";
            this.cmbTipoNota.Size = new System.Drawing.Size(135, 21);
            this.cmbTipoNota.TabIndex = 16;
            this.cmbTipoNota.TextChanged += new System.EventHandler(this.cmbTipoNota_TextChanged);
            // 
            // btnAgregarCriterio
            // 
            this.btnAgregarCriterio.Enabled = false;
            this.btnAgregarCriterio.Location = new System.Drawing.Point(471, 195);
            this.btnAgregarCriterio.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarCriterio.Name = "btnAgregarCriterio";
            this.btnAgregarCriterio.Size = new System.Drawing.Size(115, 32);
            this.btnAgregarCriterio.TabIndex = 21;
            this.btnAgregarCriterio.Text = "AÑADIR CRITERIO";
            this.btnAgregarCriterio.UseVisualStyleBackColor = true;
            this.btnAgregarCriterio.Click += new System.EventHandler(this.btnAgregarCriterio_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(22, 575);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(503, 48);
            this.btnFinalizar.TabIndex = 22;
            this.btnFinalizar.Text = "FINALIZAR ASISTENCIA";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // ERRORESREGAUX
            // 
            this.ERRORESREGAUX.ContainerControl = this;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(437, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "--";
            // 
            // txtHoraFinal
            // 
            this.txtHoraFinal.Location = new System.Drawing.Point(455, 88);
            this.txtHoraFinal.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoraFinal.Name = "txtHoraFinal";
            this.txtHoraFinal.ReadOnly = true;
            this.txtHoraFinal.Size = new System.Drawing.Size(70, 20);
            this.txtHoraFinal.TabIndex = 25;
            // 
            // txtCiclo
            // 
            this.txtCiclo.Location = new System.Drawing.Point(362, 41);
            this.txtCiclo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.ReadOnly = true;
            this.txtCiclo.Size = new System.Drawing.Size(163, 20);
            this.txtCiclo.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "SALON";
            // 
            // btnFinReading
            // 
            this.btnFinReading.Location = new System.Drawing.Point(22, 575);
            this.btnFinReading.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinReading.Name = "btnFinReading";
            this.btnFinReading.Size = new System.Drawing.Size(503, 48);
            this.btnFinReading.TabIndex = 29;
            this.btnFinReading.Text = "FINALIZAR NOTAS READING";
            this.btnFinReading.UseVisualStyleBackColor = true;
            this.btnFinReading.Visible = false;
            this.btnFinReading.Click += new System.EventHandler(this.btnFinReading_Click);
            // 
            // btnFinWriting
            // 
            this.btnFinWriting.Location = new System.Drawing.Point(22, 575);
            this.btnFinWriting.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinWriting.Name = "btnFinWriting";
            this.btnFinWriting.Size = new System.Drawing.Size(503, 48);
            this.btnFinWriting.TabIndex = 30;
            this.btnFinWriting.Text = "FINALIZAR NOTAS WRITING";
            this.btnFinWriting.UseVisualStyleBackColor = true;
            this.btnFinWriting.Visible = false;
            this.btnFinWriting.Click += new System.EventHandler(this.btnFinWriting_Click);
            // 
            // btnFinListening
            // 
            this.btnFinListening.Location = new System.Drawing.Point(22, 575);
            this.btnFinListening.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinListening.Name = "btnFinListening";
            this.btnFinListening.Size = new System.Drawing.Size(503, 48);
            this.btnFinListening.TabIndex = 31;
            this.btnFinListening.Text = "FINALIZAR NOTAS LISTENING";
            this.btnFinListening.UseVisualStyleBackColor = true;
            this.btnFinListening.Visible = false;
            this.btnFinListening.Click += new System.EventHandler(this.btnFinListening_Click);
            // 
            // btnFinUseOfEnglish
            // 
            this.btnFinUseOfEnglish.Location = new System.Drawing.Point(22, 575);
            this.btnFinUseOfEnglish.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinUseOfEnglish.Name = "btnFinUseOfEnglish";
            this.btnFinUseOfEnglish.Size = new System.Drawing.Size(503, 48);
            this.btnFinUseOfEnglish.TabIndex = 32;
            this.btnFinUseOfEnglish.Text = "FINALIZAR NOTAS USE OF ENGLISH";
            this.btnFinUseOfEnglish.UseVisualStyleBackColor = true;
            this.btnFinUseOfEnglish.Visible = false;
            this.btnFinUseOfEnglish.Click += new System.EventHandler(this.btnFinUseOfEnglish_Click);
            // 
            // btnFinSpeaking
            // 
            this.btnFinSpeaking.Location = new System.Drawing.Point(22, 575);
            this.btnFinSpeaking.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinSpeaking.Name = "btnFinSpeaking";
            this.btnFinSpeaking.Size = new System.Drawing.Size(503, 48);
            this.btnFinSpeaking.TabIndex = 28;
            this.btnFinSpeaking.Text = "FINALIZAR NOTAS SPEAKING";
            this.btnFinSpeaking.UseVisualStyleBackColor = true;
            this.btnFinSpeaking.Visible = false;
            this.btnFinSpeaking.Click += new System.EventHandler(this.btnFinSpeaking_Click);
            // 
            // dtpFechaClase
            // 
            this.dtpFechaClase.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtpFechaClase.Location = new System.Drawing.Point(568, 69);
            this.dtpFechaClase.Name = "dtpFechaClase";
            this.dtpFechaClase.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaClase.TabIndex = 33;
            // 
            // frmRegistroAuxiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 634);
            this.Controls.Add(this.dtpFechaClase);
            this.Controls.Add(this.btnFinUseOfEnglish);
            this.Controls.Add(this.btnFinListening);
            this.Controls.Add(this.btnFinWriting);
            this.Controls.Add(this.btnFinReading);
            this.Controls.Add(this.btnFinSpeaking);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCiclo);
            this.Controls.Add(this.txtHoraFinal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAgregarCriterio);
            this.Controls.Add(this.cmbTipoNota);
            this.Controls.Add(this.btnTerminarClase);
            this.Controls.Add(this.txtCriterio);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvwAlumnos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.txtSalon);
            this.Controls.Add(this.txtInicioCurso);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmRegistroAuxiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO AUXILIAR";
            ((System.ComponentModel.ISupportInitialize)(this.dgvwAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERRORESREGAUX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtInicioCurso;
        private System.Windows.Forms.TextBox txtSalon;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvwAlumnos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTerminarClase;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbTipoNota;
        private System.Windows.Forms.Button btnAgregarCriterio;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ErrorProvider ERRORESREGAUX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCiclo;
        private System.Windows.Forms.TextBox txtHoraFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFinUseOfEnglish;
        private System.Windows.Forms.Button btnFinListening;
        private System.Windows.Forms.Button btnFinWriting;
        private System.Windows.Forms.Button btnFinReading;
        private System.Windows.Forms.Button btnFinSpeaking;
        private System.Windows.Forms.DateTimePicker dtpFechaClase;
    }
}