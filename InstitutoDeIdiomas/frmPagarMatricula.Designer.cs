namespace InstitutoDeIdiomas
{
    partial class frmPagarMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagarMatricula));
            this.GBMODALIDADMATRICULA = new System.Windows.Forms.GroupBox();
            this.RBMATUBICACION = new System.Windows.Forms.RadioButton();
            this.RBMATREGULAR = new System.Windows.Forms.RadioButton();
            this.GBIDIOMA = new System.Windows.Forms.GroupBox();
            this.RBOTRO = new System.Windows.Forms.RadioButton();
            this.RBCHINO = new System.Windows.Forms.RadioButton();
            this.RBQUECHUA = new System.Windows.Forms.RadioButton();
            this.RBALEMAN = new System.Windows.Forms.RadioButton();
            this.RBPORTUGUES = new System.Windows.Forms.RadioButton();
            this.RBFRANCES = new System.Windows.Forms.RadioButton();
            this.RBITALIANO = new System.Windows.Forms.RadioButton();
            this.RBINGLES = new System.Windows.Forms.RadioButton();
            this.GBNIVEL = new System.Windows.Forms.GroupBox();
            this.RBAVANZADO = new System.Windows.Forms.RadioButton();
            this.RBINTERMEDIO = new System.Windows.Forms.RadioButton();
            this.RBBASICO = new System.Windows.Forms.RadioButton();
            this.BTNMATACEPTAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NUMCICLO = new System.Windows.Forms.NumericUpDown();
            this.BTNMATCANCELAR = new System.Windows.Forms.Button();
            this.FALTACOMPLETARERROR = new System.Windows.Forms.ErrorProvider(this.components);
            this.GBMODALIDADMATRICULA.SuspendLayout();
            this.GBIDIOMA.SuspendLayout();
            this.GBNIVEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMCICLO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FALTACOMPLETARERROR)).BeginInit();
            this.SuspendLayout();
            // 
            // GBMODALIDADMATRICULA
            // 
            this.GBMODALIDADMATRICULA.Controls.Add(this.RBMATUBICACION);
            this.GBMODALIDADMATRICULA.Controls.Add(this.RBMATREGULAR);
            this.GBMODALIDADMATRICULA.Location = new System.Drawing.Point(13, 26);
            this.GBMODALIDADMATRICULA.Name = "GBMODALIDADMATRICULA";
            this.GBMODALIDADMATRICULA.Size = new System.Drawing.Size(536, 73);
            this.GBMODALIDADMATRICULA.TabIndex = 0;
            this.GBMODALIDADMATRICULA.TabStop = false;
            this.GBMODALIDADMATRICULA.Text = "SELECCIONE MODALIDAD DE MATRICULA";
            // 
            // RBMATUBICACION
            // 
            this.RBMATUBICACION.AutoSize = true;
            this.RBMATUBICACION.Location = new System.Drawing.Point(301, 36);
            this.RBMATUBICACION.Name = "RBMATUBICACION";
            this.RBMATUBICACION.Size = new System.Drawing.Size(186, 21);
            this.RBMATUBICACION.TabIndex = 1;
            this.RBMATUBICACION.TabStop = true;
            this.RBMATUBICACION.Text = "EXAMEN DE UBICACION";
            this.RBMATUBICACION.UseVisualStyleBackColor = true;
            // 
            // RBMATREGULAR
            // 
            this.RBMATREGULAR.AutoSize = true;
            this.RBMATREGULAR.Location = new System.Drawing.Point(7, 36);
            this.RBMATREGULAR.Name = "RBMATREGULAR";
            this.RBMATREGULAR.Size = new System.Drawing.Size(178, 21);
            this.RBMATREGULAR.TabIndex = 0;
            this.RBMATREGULAR.TabStop = true;
            this.RBMATREGULAR.Text = "MATRICULA REGULAR";
            this.RBMATREGULAR.UseVisualStyleBackColor = true;
            // 
            // GBIDIOMA
            // 
            this.GBIDIOMA.Controls.Add(this.RBOTRO);
            this.GBIDIOMA.Controls.Add(this.RBCHINO);
            this.GBIDIOMA.Controls.Add(this.RBQUECHUA);
            this.GBIDIOMA.Controls.Add(this.RBALEMAN);
            this.GBIDIOMA.Controls.Add(this.RBPORTUGUES);
            this.GBIDIOMA.Controls.Add(this.RBFRANCES);
            this.GBIDIOMA.Controls.Add(this.RBITALIANO);
            this.GBIDIOMA.Controls.Add(this.RBINGLES);
            this.GBIDIOMA.Location = new System.Drawing.Point(13, 124);
            this.GBIDIOMA.Name = "GBIDIOMA";
            this.GBIDIOMA.Size = new System.Drawing.Size(260, 198);
            this.GBIDIOMA.TabIndex = 1;
            this.GBIDIOMA.TabStop = false;
            this.GBIDIOMA.Text = "SELECCIONE IDIOMA";
            // 
            // RBOTRO
            // 
            this.RBOTRO.AutoSize = true;
            this.RBOTRO.Location = new System.Drawing.Point(135, 149);
            this.RBOTRO.Name = "RBOTRO";
            this.RBOTRO.Size = new System.Drawing.Size(70, 21);
            this.RBOTRO.TabIndex = 7;
            this.RBOTRO.TabStop = true;
            this.RBOTRO.Text = "OTRO";
            this.RBOTRO.UseVisualStyleBackColor = true;
            // 
            // RBCHINO
            // 
            this.RBCHINO.AutoSize = true;
            this.RBCHINO.Location = new System.Drawing.Point(7, 149);
            this.RBCHINO.Name = "RBCHINO";
            this.RBCHINO.Size = new System.Drawing.Size(72, 21);
            this.RBCHINO.TabIndex = 6;
            this.RBCHINO.TabStop = true;
            this.RBCHINO.Text = "CHINO";
            this.RBCHINO.UseVisualStyleBackColor = true;
            // 
            // RBQUECHUA
            // 
            this.RBQUECHUA.AutoSize = true;
            this.RBQUECHUA.Location = new System.Drawing.Point(135, 104);
            this.RBQUECHUA.Name = "RBQUECHUA";
            this.RBQUECHUA.Size = new System.Drawing.Size(97, 21);
            this.RBQUECHUA.TabIndex = 5;
            this.RBQUECHUA.TabStop = true;
            this.RBQUECHUA.Text = "QUECHUA";
            this.RBQUECHUA.UseVisualStyleBackColor = true;
            // 
            // RBALEMAN
            // 
            this.RBALEMAN.AutoSize = true;
            this.RBALEMAN.Location = new System.Drawing.Point(7, 104);
            this.RBALEMAN.Name = "RBALEMAN";
            this.RBALEMAN.Size = new System.Drawing.Size(85, 21);
            this.RBALEMAN.TabIndex = 4;
            this.RBALEMAN.TabStop = true;
            this.RBALEMAN.Text = "ALEMAN";
            this.RBALEMAN.UseVisualStyleBackColor = true;
            // 
            // RBPORTUGUES
            // 
            this.RBPORTUGUES.AutoSize = true;
            this.RBPORTUGUES.Location = new System.Drawing.Point(135, 63);
            this.RBPORTUGUES.Name = "RBPORTUGUES";
            this.RBPORTUGUES.Size = new System.Drawing.Size(117, 21);
            this.RBPORTUGUES.TabIndex = 3;
            this.RBPORTUGUES.TabStop = true;
            this.RBPORTUGUES.Text = "PORTUGUES";
            this.RBPORTUGUES.UseVisualStyleBackColor = true;
            // 
            // RBFRANCES
            // 
            this.RBFRANCES.AutoSize = true;
            this.RBFRANCES.Location = new System.Drawing.Point(7, 63);
            this.RBFRANCES.Name = "RBFRANCES";
            this.RBFRANCES.Size = new System.Drawing.Size(93, 21);
            this.RBFRANCES.TabIndex = 2;
            this.RBFRANCES.TabStop = true;
            this.RBFRANCES.Text = "FRANCES";
            this.RBFRANCES.UseVisualStyleBackColor = true;
            // 
            // RBITALIANO
            // 
            this.RBITALIANO.AutoSize = true;
            this.RBITALIANO.Location = new System.Drawing.Point(135, 22);
            this.RBITALIANO.Name = "RBITALIANO";
            this.RBITALIANO.Size = new System.Drawing.Size(91, 21);
            this.RBITALIANO.TabIndex = 1;
            this.RBITALIANO.TabStop = true;
            this.RBITALIANO.Text = "ITALIANO";
            this.RBITALIANO.UseVisualStyleBackColor = true;
            // 
            // RBINGLES
            // 
            this.RBINGLES.AutoSize = true;
            this.RBINGLES.Location = new System.Drawing.Point(7, 22);
            this.RBINGLES.Name = "RBINGLES";
            this.RBINGLES.Size = new System.Drawing.Size(79, 21);
            this.RBINGLES.TabIndex = 0;
            this.RBINGLES.TabStop = true;
            this.RBINGLES.Text = "INGLES";
            this.RBINGLES.UseVisualStyleBackColor = true;
            // 
            // GBNIVEL
            // 
            this.GBNIVEL.Controls.Add(this.RBAVANZADO);
            this.GBNIVEL.Controls.Add(this.RBINTERMEDIO);
            this.GBNIVEL.Controls.Add(this.RBBASICO);
            this.GBNIVEL.Location = new System.Drawing.Point(300, 124);
            this.GBNIVEL.Name = "GBNIVEL";
            this.GBNIVEL.Size = new System.Drawing.Size(249, 198);
            this.GBNIVEL.TabIndex = 2;
            this.GBNIVEL.TabStop = false;
            this.GBNIVEL.Text = "SELECCIONE NIVEL";
            // 
            // RBAVANZADO
            // 
            this.RBAVANZADO.AutoSize = true;
            this.RBAVANZADO.Location = new System.Drawing.Point(14, 149);
            this.RBAVANZADO.Name = "RBAVANZADO";
            this.RBAVANZADO.Size = new System.Drawing.Size(105, 21);
            this.RBAVANZADO.TabIndex = 2;
            this.RBAVANZADO.TabStop = true;
            this.RBAVANZADO.Text = "AVANZADO";
            this.RBAVANZADO.UseVisualStyleBackColor = true;
            // 
            // RBINTERMEDIO
            // 
            this.RBINTERMEDIO.AutoSize = true;
            this.RBINTERMEDIO.Location = new System.Drawing.Point(14, 94);
            this.RBINTERMEDIO.Name = "RBINTERMEDIO";
            this.RBINTERMEDIO.Size = new System.Drawing.Size(114, 21);
            this.RBINTERMEDIO.TabIndex = 1;
            this.RBINTERMEDIO.TabStop = true;
            this.RBINTERMEDIO.Text = "INTERMEDIO";
            this.RBINTERMEDIO.UseVisualStyleBackColor = true;
            // 
            // RBBASICO
            // 
            this.RBBASICO.AutoSize = true;
            this.RBBASICO.Location = new System.Drawing.Point(14, 44);
            this.RBBASICO.Name = "RBBASICO";
            this.RBBASICO.Size = new System.Drawing.Size(79, 21);
            this.RBBASICO.TabIndex = 0;
            this.RBBASICO.TabStop = true;
            this.RBBASICO.Text = "BASICO";
            this.RBBASICO.UseVisualStyleBackColor = true;
            // 
            // BTNMATACEPTAR
            // 
            this.BTNMATACEPTAR.Location = new System.Drawing.Point(285, 341);
            this.BTNMATACEPTAR.Name = "BTNMATACEPTAR";
            this.BTNMATACEPTAR.Size = new System.Drawing.Size(123, 31);
            this.BTNMATACEPTAR.TabIndex = 3;
            this.BTNMATACEPTAR.Text = "ACEPTAR";
            this.BTNMATACEPTAR.UseVisualStyleBackColor = true;
            this.BTNMATACEPTAR.Click += new System.EventHandler(this.BTNMATACEPTAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "INGRESE CICLO";
            // 
            // NUMCICLO
            // 
            this.NUMCICLO.Location = new System.Drawing.Point(153, 341);
            this.NUMCICLO.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NUMCICLO.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUMCICLO.Name = "NUMCICLO";
            this.NUMCICLO.Size = new System.Drawing.Size(65, 22);
            this.NUMCICLO.TabIndex = 5;
            this.NUMCICLO.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BTNMATCANCELAR
            // 
            this.BTNMATCANCELAR.Location = new System.Drawing.Point(426, 341);
            this.BTNMATCANCELAR.Name = "BTNMATCANCELAR";
            this.BTNMATCANCELAR.Size = new System.Drawing.Size(123, 31);
            this.BTNMATCANCELAR.TabIndex = 6;
            this.BTNMATCANCELAR.Text = "CANCELAR";
            this.BTNMATCANCELAR.UseVisualStyleBackColor = true;
            this.BTNMATCANCELAR.Click += new System.EventHandler(this.BTNMATCANCELAR_Click);
            // 
            // FALTACOMPLETARERROR
            // 
            this.FALTACOMPLETARERROR.ContainerControl = this;
            // 
            // frmPagarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(564, 401);
            this.Controls.Add(this.BTNMATCANCELAR);
            this.Controls.Add(this.NUMCICLO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNMATACEPTAR);
            this.Controls.Add(this.GBNIVEL);
            this.Controls.Add(this.GBIDIOMA);
            this.Controls.Add(this.GBMODALIDADMATRICULA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPagarMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAGAR MATRICULA";
            this.GBMODALIDADMATRICULA.ResumeLayout(false);
            this.GBMODALIDADMATRICULA.PerformLayout();
            this.GBIDIOMA.ResumeLayout(false);
            this.GBIDIOMA.PerformLayout();
            this.GBNIVEL.ResumeLayout(false);
            this.GBNIVEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMCICLO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FALTACOMPLETARERROR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBMODALIDADMATRICULA;
        private System.Windows.Forms.RadioButton RBMATUBICACION;
        private System.Windows.Forms.RadioButton RBMATREGULAR;
        private System.Windows.Forms.GroupBox GBIDIOMA;
        private System.Windows.Forms.RadioButton RBOTRO;
        private System.Windows.Forms.RadioButton RBCHINO;
        private System.Windows.Forms.RadioButton RBQUECHUA;
        private System.Windows.Forms.RadioButton RBALEMAN;
        private System.Windows.Forms.RadioButton RBPORTUGUES;
        private System.Windows.Forms.RadioButton RBFRANCES;
        private System.Windows.Forms.RadioButton RBITALIANO;
        private System.Windows.Forms.RadioButton RBINGLES;
        private System.Windows.Forms.GroupBox GBNIVEL;
        private System.Windows.Forms.RadioButton RBAVANZADO;
        private System.Windows.Forms.RadioButton RBINTERMEDIO;
        private System.Windows.Forms.RadioButton RBBASICO;
        private System.Windows.Forms.Button BTNMATACEPTAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUMCICLO;
        private System.Windows.Forms.Button BTNMATCANCELAR;
        private System.Windows.Forms.ErrorProvider FALTACOMPLETARERROR;
    }
}