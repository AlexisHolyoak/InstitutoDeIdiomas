namespace InstitutoDeIdiomas
{
    partial class frmCrearGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearGrupo));
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.btnCrearGrupo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtmHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clbHorario = new System.Windows.Forms.CheckedListBox();
            this.dtmHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.numCiclo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCiclo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSalon
            // 
            this.cmbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(348, 116);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(50, 21);
            this.cmbSalon.TabIndex = 35;
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(206, 266);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(201, 21);
            this.cmbProfesor.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Nivel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Idioma";
            // 
            // cmbNivel
            // 
            this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(109, 116);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(121, 21);
            this.cmbNivel.TabIndex = 31;
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(109, 71);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(121, 21);
            this.cmbIdioma.TabIndex = 30;
            // 
            // btnCrearGrupo
            // 
            this.btnCrearGrupo.Location = new System.Drawing.Point(237, 294);
            this.btnCrearGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearGrupo.Name = "btnCrearGrupo";
            this.btnCrearGrupo.Size = new System.Drawing.Size(143, 43);
            this.btnCrearGrupo.TabIndex = 29;
            this.btnCrearGrupo.Text = "CREAR GRUPO";
            this.btnCrearGrupo.UseVisualStyleBackColor = true;
            this.btnCrearGrupo.Click += new System.EventHandler(this.btnCrearGrupo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "PROFESOR";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(206, 176);
            this.dtFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(201, 20);
            this.dtFechaInicio.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "FECHA DE INICIO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtmHoraFinal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.clbHorario);
            this.groupBox1.Controls.Add(this.dtmHoraInicio);
            this.groupBox1.Location = new System.Drawing.Point(18, 158);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(179, 197);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HORARIO";
            // 
            // dtmHoraFinal
            // 
            this.dtmHoraFinal.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtmHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmHoraFinal.Location = new System.Drawing.Point(78, 162);
            this.dtmHoraFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtmHoraFinal.Name = "dtmHoraFinal";
            this.dtmHoraFinal.ShowUpDown = true;
            this.dtmHoraFinal.Size = new System.Drawing.Size(86, 20);
            this.dtmHoraFinal.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "HORA FINAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "HORA INICIO";
            // 
            // clbHorario
            // 
            this.clbHorario.BackColor = System.Drawing.SystemColors.Menu;
            this.clbHorario.FormattingEnabled = true;
            this.clbHorario.Location = new System.Drawing.Point(5, 18);
            this.clbHorario.Name = "clbHorario";
            this.clbHorario.Size = new System.Drawing.Size(170, 109);
            this.clbHorario.TabIndex = 0;
            // 
            // dtmHoraInicio
            // 
            this.dtmHoraInicio.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtmHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmHoraInicio.Location = new System.Drawing.Point(78, 134);
            this.dtmHoraInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtmHoraInicio.Name = "dtmHoraInicio";
            this.dtmHoraInicio.ShowUpDown = true;
            this.dtmHoraInicio.Size = new System.Drawing.Size(86, 20);
            this.dtmHoraInicio.TabIndex = 8;
            // 
            // numCiclo
            // 
            this.numCiclo.Location = new System.Drawing.Point(247, 117);
            this.numCiclo.Margin = new System.Windows.Forms.Padding(2);
            this.numCiclo.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numCiclo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCiclo.Name = "numCiclo";
            this.numCiclo.Size = new System.Drawing.Size(82, 20);
            this.numCiclo.TabIndex = 24;
            this.numCiclo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "AQUI PODRAS CREAR UN NUEVO GRUPO DE ESTUDIOS";
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFinal.Location = new System.Drawing.Point(206, 223);
            this.dtFechaFinal.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(201, 20);
            this.dtFechaFinal.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "FECHA FINAL";
            // 
            // frmCrearGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 358);
            this.Controls.Add(this.dtFechaFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSalon);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.btnCrearGrupo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numCiclo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCrearGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREAR GRUPO DE ESTUDIOS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCiclo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSalon;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Button btnCrearGrupo;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.DateTimePicker dtmHoraFinal;
        private System.Windows.Forms.CheckedListBox clbHorario;
        private System.Windows.Forms.DateTimePicker dtmHoraInicio;
        private System.Windows.Forms.NumericUpDown numCiclo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
        private System.Windows.Forms.Label label2;
    }
}