namespace InstitutoDeIdiomas
{
    partial class frmConsultarPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarPago));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BTNBUSCARPORDNI = new System.Windows.Forms.Button();
            this.GRIDVIEWALUMDNI = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTCONSDNI = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GRIDVIEWALUMNNOM = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTCONNOMBRE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IMGALUMNCONS = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.GRIDVIEWPAGOSCONS = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.GRIDVIEWOTROSPAGOS = new System.Windows.Forms.DataGridView();
            this.GRIDVIEWMATRICULA = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWALUMDNI)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWALUMNNOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGALUMNCONS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWPAGOSCONS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWOTROSPAGOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWMATRICULA)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 213);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BTNBUSCARPORDNI);
            this.tabPage1.Controls.Add(this.GRIDVIEWALUMDNI);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TXTCONSDNI);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 184);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BUSCAR POR D.N.I.";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BTNBUSCARPORDNI
            // 
            this.BTNBUSCARPORDNI.Location = new System.Drawing.Point(378, 35);
            this.BTNBUSCARPORDNI.Name = "BTNBUSCARPORDNI";
            this.BTNBUSCARPORDNI.Size = new System.Drawing.Size(123, 23);
            this.BTNBUSCARPORDNI.TabIndex = 5;
            this.BTNBUSCARPORDNI.Text = "BUSCAR";
            this.BTNBUSCARPORDNI.UseVisualStyleBackColor = true;
            this.BTNBUSCARPORDNI.Click += new System.EventHandler(this.BTNBUSCARPORDNI_Click);
            // 
            // GRIDVIEWALUMDNI
            // 
            this.GRIDVIEWALUMDNI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEWALUMDNI.Location = new System.Drawing.Point(6, 64);
            this.GRIDVIEWALUMDNI.Name = "GRIDVIEWALUMDNI";
            this.GRIDVIEWALUMDNI.ReadOnly = true;
            this.GRIDVIEWALUMDNI.RowTemplate.Height = 24;
            this.GRIDVIEWALUMDNI.Size = new System.Drawing.Size(895, 113);
            this.GRIDVIEWALUMDNI.TabIndex = 4;
            this.GRIDVIEWALUMDNI.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDVIEWALUMNDNI_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "INGRESA EL D.N.I. DEL ALUMNO";
            // 
            // TXTCONSDNI
            // 
            this.TXTCONSDNI.Location = new System.Drawing.Point(6, 36);
            this.TXTCONSDNI.Name = "TXTCONSDNI";
            this.TXTCONSDNI.Size = new System.Drawing.Size(365, 22);
            this.TXTCONSDNI.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GRIDVIEWALUMNNOM);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.TXTCONNOMBRE);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 184);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BUSCAR POR NOMBRE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GRIDVIEWALUMNNOM
            // 
            this.GRIDVIEWALUMNNOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEWALUMNNOM.Location = new System.Drawing.Point(6, 64);
            this.GRIDVIEWALUMNNOM.Name = "GRIDVIEWALUMNNOM";
            this.GRIDVIEWALUMNNOM.ReadOnly = true;
            this.GRIDVIEWALUMNNOM.RowTemplate.Height = 24;
            this.GRIDVIEWALUMNNOM.Size = new System.Drawing.Size(895, 113);
            this.GRIDVIEWALUMNNOM.TabIndex = 3;
            this.GRIDVIEWALUMNNOM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDVIEWALUMNNOM_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "INGRESA LOS APELLIDOS Y NOMBRES DEL ALUMNO";
            // 
            // TXTCONNOMBRE
            // 
            this.TXTCONNOMBRE.Location = new System.Drawing.Point(6, 36);
            this.TXTCONNOMBRE.Name = "TXTCONNOMBRE";
            this.TXTCONNOMBRE.Size = new System.Drawing.Size(546, 22);
            this.TXTCONNOMBRE.TabIndex = 1;
            this.TXTCONNOMBRE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXTBUSCARPORNOMBRE_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENIDO AL MODULO DE CONSULTA DE PAGOS DE ALUMNOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "EMPIEZA BUSCANDO AL ALUMNO QUE QUIERAS CONSULTAR SUS PAGOS";
            // 
            // IMGALUMNCONS
            // 
            this.IMGALUMNCONS.Location = new System.Drawing.Point(933, 100);
            this.IMGALUMNCONS.Name = "IMGALUMNCONS";
            this.IMGALUMNCONS.Size = new System.Drawing.Size(186, 187);
            this.IMGALUMNCONS.TabIndex = 3;
            this.IMGALUMNCONS.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(15, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 2);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(658, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "AQUI SE MUESTRAN TODOS LOS RECIBOS DEL ALUMNO SELECCIONA PARA MOSTRAR DETALLE";
            // 
            // GRIDVIEWPAGOSCONS
            // 
            this.GRIDVIEWPAGOSCONS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GRIDVIEWPAGOSCONS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEWPAGOSCONS.Location = new System.Drawing.Point(12, 339);
            this.GRIDVIEWPAGOSCONS.Name = "GRIDVIEWPAGOSCONS";
            this.GRIDVIEWPAGOSCONS.ReadOnly = true;
            this.GRIDVIEWPAGOSCONS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GRIDVIEWPAGOSCONS.RowTemplate.Height = 24;
            this.GRIDVIEWPAGOSCONS.Size = new System.Drawing.Size(610, 123);
            this.GRIDVIEWPAGOSCONS.TabIndex = 6;
            this.GRIDVIEWPAGOSCONS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDVIEWPAGOSCONS_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "DETALLE DEL PAGO";
            // 
            // GRIDVIEWOTROSPAGOS
            // 
            this.GRIDVIEWOTROSPAGOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEWOTROSPAGOS.Location = new System.Drawing.Point(16, 533);
            this.GRIDVIEWOTROSPAGOS.Name = "GRIDVIEWOTROSPAGOS";
            this.GRIDVIEWOTROSPAGOS.RowTemplate.Height = 24;
            this.GRIDVIEWOTROSPAGOS.Size = new System.Drawing.Size(654, 185);
            this.GRIDVIEWOTROSPAGOS.TabIndex = 8;
            // 
            // GRIDVIEWMATRICULA
            // 
            this.GRIDVIEWMATRICULA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEWMATRICULA.Location = new System.Drawing.Point(715, 533);
            this.GRIDVIEWMATRICULA.Name = "GRIDVIEWMATRICULA";
            this.GRIDVIEWMATRICULA.ReadOnly = true;
            this.GRIDVIEWMATRICULA.RowTemplate.Height = 24;
            this.GRIDVIEWMATRICULA.Size = new System.Drawing.Size(693, 185);
            this.GRIDVIEWMATRICULA.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "PAGOS EN GENERAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(715, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "PAGOS DE MATRICULAS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(715, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "XXXXXXX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(715, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(413, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "NOMBRE DEL TRABAJADOR QUE REGISTRO EL PAGO";
            // 
            // frmConsultarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1457, 755);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GRIDVIEWMATRICULA);
            this.Controls.Add(this.GRIDVIEWOTROSPAGOS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GRIDVIEWPAGOSCONS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IMGALUMNCONS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR PAGO";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWALUMDNI)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWALUMNNOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMGALUMNCONS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWPAGOSCONS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWOTROSPAGOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWMATRICULA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GRIDVIEWALUMDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTCONSDNI;
        private System.Windows.Forms.DataGridView GRIDVIEWALUMNNOM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTCONNOMBRE;
        private System.Windows.Forms.PictureBox IMGALUMNCONS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GRIDVIEWPAGOSCONS;
        private System.Windows.Forms.Button BTNBUSCARPORDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView GRIDVIEWOTROSPAGOS;
        private System.Windows.Forms.DataGridView GRIDVIEWMATRICULA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}