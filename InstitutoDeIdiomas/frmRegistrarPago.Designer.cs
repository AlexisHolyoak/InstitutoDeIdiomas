namespace InstitutoDeIdiomas
{
    partial class frmRegistrarPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarPago));
            this.TXTDNIALUAPAGAR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNGUARDARPAGO = new System.Windows.Forms.Button();
            this.FOTOALUAPAGAR = new System.Windows.Forms.PictureBox();
            this.TXTALUMNOAPAGAR = new System.Windows.Forms.Label();
            this.BTNCARGARDNI = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TIMEPICKERFECHRECIBO = new System.Windows.Forms.DateTimePicker();
            this.TXTNUMRECIBO = new System.Windows.Forms.TextBox();
            this.TXTMONTOAPAGAR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBPAGARMENSUALIDAD = new System.Windows.Forms.CheckBox();
            this.CBPAGARCARNET = new System.Windows.Forms.CheckBox();
            this.CBPAGARMATRICULA = new System.Windows.Forms.CheckBox();
            this.LBLEDADALUAPAGAR = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTUSUENCARGADODEPAGO = new System.Windows.Forms.Label();
            this.DNITXTVACIO = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.LBLDNIALUAPAGAR = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ERRORDEPAGOS = new System.Windows.Forms.ErrorProvider(this.components);
            this.LBLTIPOALUMNO = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.FOTOALUAPAGAR)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DNITXTVACIO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERRORDEPAGOS)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTDNIALUAPAGAR
            // 
            this.TXTDNIALUAPAGAR.Location = new System.Drawing.Point(26, 115);
            this.TXTDNIALUAPAGAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTDNIALUAPAGAR.Name = "TXTDNIALUAPAGAR";
            this.TXTDNIALUAPAGAR.Size = new System.Drawing.Size(275, 20);
            this.TXTDNIALUAPAGAR.TabIndex = 0;
            this.TXTDNIALUAPAGAR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESA EL D.N.I. DEL ALUMNO PARA EMPEZAR EL PROCESO DE PAGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "BIENVENIDO AL MODULO DE REGISTRO DE PAGOS";
            // 
            // BTNGUARDARPAGO
            // 
            this.BTNGUARDARPAGO.Enabled = false;
            this.BTNGUARDARPAGO.Location = new System.Drawing.Point(663, 427);
            this.BTNGUARDARPAGO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNGUARDARPAGO.Name = "BTNGUARDARPAGO";
            this.BTNGUARDARPAGO.Size = new System.Drawing.Size(112, 29);
            this.BTNGUARDARPAGO.TabIndex = 3;
            this.BTNGUARDARPAGO.Text = "GUARDAR PAGO";
            this.BTNGUARDARPAGO.UseVisualStyleBackColor = true;
            this.BTNGUARDARPAGO.Click += new System.EventHandler(this.BTNGUARDARPAGO_Click);
            // 
            // FOTOALUAPAGAR
            // 
            this.FOTOALUAPAGAR.Location = new System.Drawing.Point(320, 33);
            this.FOTOALUAPAGAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FOTOALUAPAGAR.Name = "FOTOALUAPAGAR";
            this.FOTOALUAPAGAR.Size = new System.Drawing.Size(128, 135);
            this.FOTOALUAPAGAR.TabIndex = 5;
            this.FOTOALUAPAGAR.TabStop = false;
            // 
            // TXTALUMNOAPAGAR
            // 
            this.TXTALUMNOAPAGAR.AutoSize = true;
            this.TXTALUMNOAPAGAR.Location = new System.Drawing.Point(496, 43);
            this.TXTALUMNOAPAGAR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TXTALUMNOAPAGAR.Name = "TXTALUMNOAPAGAR";
            this.TXTALUMNOAPAGAR.Size = new System.Drawing.Size(0, 13);
            this.TXTALUMNOAPAGAR.TabIndex = 6;
            // 
            // BTNCARGARDNI
            // 
            this.BTNCARGARDNI.Location = new System.Drawing.Point(170, 137);
            this.BTNCARGARDNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNCARGARDNI.Name = "BTNCARGARDNI";
            this.BTNCARGARDNI.Size = new System.Drawing.Size(130, 21);
            this.BTNCARGARDNI.TabIndex = 7;
            this.BTNCARGARDNI.Text = "BUSCAR ALUMNO";
            this.BTNCARGARDNI.UseVisualStyleBackColor = true;
            this.BTNCARGARDNI.Click += new System.EventHandler(this.BTNCARGARDNI_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(26, 197);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 2);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TIMEPICKERFECHRECIBO);
            this.panel2.Controls.Add(this.TXTNUMRECIBO);
            this.panel2.Controls.Add(this.TXTMONTOAPAGAR);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.CBPAGARMENSUALIDAD);
            this.panel2.Controls.Add(this.CBPAGARCARNET);
            this.panel2.Controls.Add(this.CBPAGARMATRICULA);
            this.panel2.Location = new System.Drawing.Point(50, 204);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 213);
            this.panel2.TabIndex = 9;
            // 
            // TIMEPICKERFECHRECIBO
            // 
            this.TIMEPICKERFECHRECIBO.Enabled = false;
            this.TIMEPICKERFECHRECIBO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TIMEPICKERFECHRECIBO.Location = new System.Drawing.Point(203, 166);
            this.TIMEPICKERFECHRECIBO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TIMEPICKERFECHRECIBO.MaxDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.TIMEPICKERFECHRECIBO.Name = "TIMEPICKERFECHRECIBO";
            this.TIMEPICKERFECHRECIBO.Size = new System.Drawing.Size(214, 20);
            this.TIMEPICKERFECHRECIBO.TabIndex = 9;
            this.TIMEPICKERFECHRECIBO.Value = new System.DateTime(2017, 6, 4, 0, 0, 0, 0);
            this.TIMEPICKERFECHRECIBO.ValueChanged += new System.EventHandler(this.TIMEPICKERFECHRECIBO_ValueChanged);
            // 
            // TXTNUMRECIBO
            // 
            this.TXTNUMRECIBO.Enabled = false;
            this.TXTNUMRECIBO.Location = new System.Drawing.Point(203, 114);
            this.TXTNUMRECIBO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTNUMRECIBO.Name = "TXTNUMRECIBO";
            this.TXTNUMRECIBO.Size = new System.Drawing.Size(330, 20);
            this.TXTNUMRECIBO.TabIndex = 8;
            this.TXTNUMRECIBO.Text = " ";
            // 
            // TXTMONTOAPAGAR
            // 
            this.TXTMONTOAPAGAR.Enabled = false;
            this.TXTMONTOAPAGAR.Location = new System.Drawing.Point(203, 67);
            this.TXTMONTOAPAGAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTMONTOAPAGAR.Name = "TXTMONTOAPAGAR";
            this.TXTMONTOAPAGAR.Size = new System.Drawing.Size(330, 20);
            this.TXTMONTOAPAGAR.TabIndex = 7;
            this.TXTMONTOAPAGAR.Text = "0";
            this.TXTMONTOAPAGAR.TextChanged += new System.EventHandler(this.TXTMONTOAPAGAR_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "SELECCIONE FECHA DE RECIBO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "INGRESE NUMERO DE RECIBO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "MONTO TOTAL A PAGAR";
            // 
            // CBPAGARMENSUALIDAD
            // 
            this.CBPAGARMENSUALIDAD.AutoSize = true;
            this.CBPAGARMENSUALIDAD.Enabled = false;
            this.CBPAGARMENSUALIDAD.Location = new System.Drawing.Point(548, 15);
            this.CBPAGARMENSUALIDAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBPAGARMENSUALIDAD.Name = "CBPAGARMENSUALIDAD";
            this.CBPAGARMENSUALIDAD.Size = new System.Drawing.Size(144, 17);
            this.CBPAGARMENSUALIDAD.TabIndex = 3;
            this.CBPAGARMENSUALIDAD.Text = "PAGAR MENSUALIDAD";
            this.CBPAGARMENSUALIDAD.UseVisualStyleBackColor = true;
            this.CBPAGARMENSUALIDAD.CheckedChanged += new System.EventHandler(this.CBPAGARMENSUALIDAD_CheckedChanged);
            // 
            // CBPAGARCARNET
            // 
            this.CBPAGARCARNET.AutoSize = true;
            this.CBPAGARCARNET.Enabled = false;
            this.CBPAGARCARNET.Location = new System.Drawing.Point(294, 15);
            this.CBPAGARCARNET.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBPAGARCARNET.Name = "CBPAGARCARNET";
            this.CBPAGARCARNET.Size = new System.Drawing.Size(110, 17);
            this.CBPAGARCARNET.TabIndex = 2;
            this.CBPAGARCARNET.Text = "PAGAR CARNET";
            this.CBPAGARCARNET.UseVisualStyleBackColor = true;
            this.CBPAGARCARNET.CheckedChanged += new System.EventHandler(this.CBPAGARCARNET_CheckedChanged);
            // 
            // CBPAGARMATRICULA
            // 
            this.CBPAGARMATRICULA.AutoSize = true;
            this.CBPAGARMATRICULA.Enabled = false;
            this.CBPAGARMATRICULA.Location = new System.Drawing.Point(26, 15);
            this.CBPAGARMATRICULA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBPAGARMATRICULA.Name = "CBPAGARMATRICULA";
            this.CBPAGARMATRICULA.Size = new System.Drawing.Size(128, 17);
            this.CBPAGARMATRICULA.TabIndex = 1;
            this.CBPAGARMATRICULA.Text = "PAGAR MATRICULA";
            this.CBPAGARMATRICULA.UseVisualStyleBackColor = true;
            this.CBPAGARMATRICULA.CheckedChanged += new System.EventHandler(this.CBPAGARMATRICULA_CheckedChanged);
            // 
            // LBLEDADALUAPAGAR
            // 
            this.LBLEDADALUAPAGAR.AutoSize = true;
            this.LBLEDADALUAPAGAR.Location = new System.Drawing.Point(496, 83);
            this.LBLEDADALUAPAGAR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLEDADALUAPAGAR.Name = "LBLEDADALUAPAGAR";
            this.LBLEDADALUAPAGAR.Size = new System.Drawing.Size(0, 13);
            this.LBLEDADALUAPAGAR.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 442);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Codigo de sesión";
            // 
            // TXTUSUENCARGADODEPAGO
            // 
            this.TXTUSUENCARGADODEPAGO.AutoSize = true;
            this.TXTUSUENCARGADODEPAGO.Location = new System.Drawing.Point(119, 442);
            this.TXTUSUENCARGADODEPAGO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TXTUSUENCARGADODEPAGO.Name = "TXTUSUENCARGADODEPAGO";
            this.TXTUSUENCARGADODEPAGO.Size = new System.Drawing.Size(35, 13);
            this.TXTUSUENCARGADODEPAGO.TabIndex = 13;
            this.TXTUSUENCARGADODEPAGO.Text = "label6";
            // 
            // DNITXTVACIO
            // 
            this.DNITXTVACIO.ContainerControl = this;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(26, 419);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(748, 2);
            this.panel4.TabIndex = 14;
            // 
            // LBLDNIALUAPAGAR
            // 
            this.LBLDNIALUAPAGAR.AutoSize = true;
            this.LBLDNIALUAPAGAR.Location = new System.Drawing.Point(364, 171);
            this.LBLDNIALUAPAGAR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLDNIALUAPAGAR.Name = "LBLDNIALUAPAGAR";
            this.LBLDNIALUAPAGAR.Size = new System.Drawing.Size(0, 13);
            this.LBLDNIALUAPAGAR.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "D.N.I.";
            this.label7.Visible = false;
            // 
            // ERRORDEPAGOS
            // 
            this.ERRORDEPAGOS.ContainerControl = this;
            // 
            // LBLTIPOALUMNO
            // 
            this.LBLTIPOALUMNO.AutoSize = true;
            this.LBLTIPOALUMNO.Location = new System.Drawing.Point(596, 116);
            this.LBLTIPOALUMNO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLTIPOALUMNO.Name = "LBLTIPOALUMNO";
            this.LBLTIPOALUMNO.Size = new System.Drawing.Size(0, 13);
            this.LBLTIPOALUMNO.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "TIPO DE ALUMNO:";
            this.label8.Visible = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "MATRICULA",
            "CARNET",
            "MENSUALIDAD DEL AÑO TAL X A Y",
            "MENSUALIDAD DEL AÑO Y A Z",
            "CERTIFICADO"});
            this.checkedListBox1.Location = new System.Drawing.Point(598, 43);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(195, 79);
            this.checkedListBox1.TabIndex = 19;
            // 
            // frmRegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 466);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LBLTIPOALUMNO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LBLDNIALUAPAGAR);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TXTUSUENCARGADODEPAGO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBLEDADALUAPAGAR);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTNCARGARDNI);
            this.Controls.Add(this.TXTALUMNOAPAGAR);
            this.Controls.Add(this.FOTOALUAPAGAR);
            this.Controls.Add(this.BTNGUARDARPAGO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTDNIALUAPAGAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmRegistrarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAR PAGO";
            ((System.ComponentModel.ISupportInitialize)(this.FOTOALUAPAGAR)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DNITXTVACIO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERRORDEPAGOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTDNIALUAPAGAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNGUARDARPAGO;
        private System.Windows.Forms.PictureBox FOTOALUAPAGAR;
        private System.Windows.Forms.Label TXTALUMNOAPAGAR;
        private System.Windows.Forms.Button BTNCARGARDNI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBLEDADALUAPAGAR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TXTUSUENCARGADODEPAGO;
        private System.Windows.Forms.ErrorProvider DNITXTVACIO;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LBLDNIALUAPAGAR;
        private System.Windows.Forms.DateTimePicker TIMEPICKERFECHRECIBO;
        private System.Windows.Forms.TextBox TXTNUMRECIBO;
        private System.Windows.Forms.TextBox TXTMONTOAPAGAR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox CBPAGARMENSUALIDAD;
        public System.Windows.Forms.CheckBox CBPAGARCARNET;
        public System.Windows.Forms.CheckBox CBPAGARMATRICULA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider ERRORDEPAGOS;
        private System.Windows.Forms.Label LBLTIPOALUMNO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}