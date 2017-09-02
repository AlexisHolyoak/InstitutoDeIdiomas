namespace InstitutoDeIdiomas
{
    partial class frmAsignarAlumnosToGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarAlumnosToGroup));
            this.label11 = new System.Windows.Forms.Label();
            this.txtHorario2 = new System.Windows.Forms.TextBox();
            this.txtSalon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscarDni = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuscarApellido = new System.Windows.Forms.TextBox();
            this.dataGridViewAlumno = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtCiclo = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewAlumnoGrupo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnoGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(776, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "--";
            // 
            // txtHorario2
            // 
            this.txtHorario2.Location = new System.Drawing.Point(790, 91);
            this.txtHorario2.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorario2.Name = "txtHorario2";
            this.txtHorario2.ReadOnly = true;
            this.txtHorario2.Size = new System.Drawing.Size(53, 20);
            this.txtHorario2.TabIndex = 44;
            // 
            // txtSalon
            // 
            this.txtSalon.Location = new System.Drawing.Point(519, 118);
            this.txtSalon.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalon.Name = "txtSalon";
            this.txtSalon.ReadOnly = true;
            this.txtSalon.Size = new System.Drawing.Size(122, 20);
            this.txtSalon.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(463, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "SALON";
            // 
            // txtBuscarDni
            // 
            this.txtBuscarDni.AutoCompleteCustomSource.AddRange(new string[] {
            "EJEMPLO DE AUTOCOMPLETE",
            "AUMNO X",
            "BALUMNO Y",
            "CALUMNO Z"});
            this.txtBuscarDni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBuscarDni.Enabled = false;
            this.txtBuscarDni.Location = new System.Drawing.Point(464, 227);
            this.txtBuscarDni.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.Size = new System.Drawing.Size(295, 20);
            this.txtBuscarDni.TabIndex = 41;
            this.txtBuscarDni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarDni_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 211);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "BUSCAR POR DNI";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(796, 185);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 64);
            this.btnAgregar.TabIndex = 39;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "BUSCAR POR APELLIDO";
            // 
            // txtBuscarApellido
            // 
            this.txtBuscarApellido.AutoCompleteCustomSource.AddRange(new string[] {
            "EJEMPLO DE AUTOCOMPLETE",
            "AUMNO X",
            "BALUMNO Y",
            "CALUMNO Z"});
            this.txtBuscarApellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBuscarApellido.Enabled = false;
            this.txtBuscarApellido.Location = new System.Drawing.Point(464, 183);
            this.txtBuscarApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarApellido.Name = "txtBuscarApellido";
            this.txtBuscarApellido.Size = new System.Drawing.Size(295, 20);
            this.txtBuscarApellido.TabIndex = 37;
            this.txtBuscarApellido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarApellido_KeyUp);
            // 
            // dataGridViewAlumno
            // 
            this.dataGridViewAlumno.AllowUserToAddRows = false;
            this.dataGridViewAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumno.Enabled = false;
            this.dataGridViewAlumno.Location = new System.Drawing.Point(464, 260);
            this.dataGridViewAlumno.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAlumno.Name = "dataGridViewAlumno";
            this.dataGridViewAlumno.ReadOnly = true;
            this.dataGridViewAlumno.RowTemplate.Height = 24;
            this.dataGridViewAlumno.Size = new System.Drawing.Size(426, 247);
            this.dataGridViewAlumno.TabIndex = 36;
            this.dataGridViewAlumno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlumno_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "AGREGAR ALUMNOS";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(721, 91);
            this.txtHorario.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.ReadOnly = true;
            this.txtHorario.Size = new System.Drawing.Size(53, 20);
            this.txtHorario.TabIndex = 34;
            // 
            // txtCiclo
            // 
            this.txtCiclo.Location = new System.Drawing.Point(721, 66);
            this.txtCiclo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.ReadOnly = true;
            this.txtCiclo.Size = new System.Drawing.Size(122, 20);
            this.txtCiclo.TabIndex = 33;
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(519, 91);
            this.txtNivel.Margin = new System.Windows.Forms.Padding(2);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.ReadOnly = true;
            this.txtNivel.Size = new System.Drawing.Size(122, 20);
            this.txtNivel.TabIndex = 32;
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(519, 66);
            this.txtIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.ReadOnly = true;
            this.txtIdioma.Size = new System.Drawing.Size(122, 20);
            this.txtIdioma.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "NIVEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(679, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "CICLO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "HORARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "IDIOMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "DETALLE DEL GRUPO SELECCIONADO";
            // 
            // dataGridViewAlumnoGrupo
            // 
            this.dataGridViewAlumnoGrupo.AllowUserToAddRows = false;
            this.dataGridViewAlumnoGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnoGrupo.Location = new System.Drawing.Point(29, 42);
            this.dataGridViewAlumnoGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAlumnoGrupo.Name = "dataGridViewAlumnoGrupo";
            this.dataGridViewAlumnoGrupo.ReadOnly = true;
            this.dataGridViewAlumnoGrupo.RowTemplate.Height = 24;
            this.dataGridViewAlumnoGrupo.Size = new System.Drawing.Size(396, 466);
            this.dataGridViewAlumnoGrupo.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "BIENVENIDO AQUI PODRA ASIGNAR ALUMNOS A LOS RESPECTIVOS GRUPOS CREADOS";
            // 
            // frmAsignarAlumnosToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 526);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtHorario2);
            this.Controls.Add(this.txtSalon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBuscarDni);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBuscarApellido);
            this.Controls.Add(this.dataGridViewAlumno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtCiclo);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewAlumnoGrupo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAsignarAlumnosToGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASIGNACION DE ALUMNOS A GRUPOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnoGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHorario2;
        private System.Windows.Forms.TextBox txtSalon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscarDni;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscarApellido;
        private System.Windows.Forms.DataGridView dataGridViewAlumno;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtCiclo;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.DataGridView dataGridViewAlumnoGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}