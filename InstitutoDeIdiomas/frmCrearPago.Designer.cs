namespace InstitutoDeIdiomas
{
    partial class frmCrearPago
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuscarPorDni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTINGDNI = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TXTINGNOMBRE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GRIDVIEWCONSALUPAGO = new System.Windows.Forms.DataGridView();
            this.FOTOALUMNOAPAGAR = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBLCODIGOALUMN = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PANELMATRICULA = new System.Windows.Forms.Panel();
            this.NUMCICLO = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.GBNIVEL = new System.Windows.Forms.GroupBox();
            this.RBAVANZADO = new System.Windows.Forms.RadioButton();
            this.RBINTERMEDIO = new System.Windows.Forms.RadioButton();
            this.RBBASICO = new System.Windows.Forms.RadioButton();
            this.GBIDIOMA = new System.Windows.Forms.GroupBox();
            this.RBOTRO = new System.Windows.Forms.RadioButton();
            this.RBCHINO = new System.Windows.Forms.RadioButton();
            this.RBQUECHUA = new System.Windows.Forms.RadioButton();
            this.RBALEMAN = new System.Windows.Forms.RadioButton();
            this.RBPORTUGUES = new System.Windows.Forms.RadioButton();
            this.RBFRANCES = new System.Windows.Forms.RadioButton();
            this.RBITALIANO = new System.Windows.Forms.RadioButton();
            this.RBINGLES = new System.Windows.Forms.RadioButton();
            this.GBMODALIDADMATRICULA = new System.Windows.Forms.GroupBox();
            this.RBMATUBICACION = new System.Windows.Forms.RadioButton();
            this.RBMATREGULAR = new System.Windows.Forms.RadioButton();
            this.TXTMONTO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTNUMERORECIBO = new System.Windows.Forms.TextBox();
            this.FECHARECIBO = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LBLUSUENCARGADODEPAGO = new System.Windows.Forms.Label();
            this.BTNGUARDARPAGO = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.LBLTIPOALUMN = new System.Windows.Forms.Label();
            this.MISSINGDATA = new System.Windows.Forms.ErrorProvider(this.components);
            this.GRIDVIEWTIPOSPAGOS = new System.Windows.Forms.DataGridView();
            this.CBPAGARMATRICULA = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWCONSALUPAGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FOTOALUMNOAPAGAR)).BeginInit();
            this.PANELMATRICULA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMCICLO)).BeginInit();
            this.GBNIVEL.SuspendLayout();
            this.GBIDIOMA.SuspendLayout();
            this.GBMODALIDADMATRICULA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MISSINGDATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWTIPOSPAGOS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(996, 81);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscarPorDni);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TXTINGDNI);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(988, 52);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BUSCAR POR DNI";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPorDni
            // 
            this.btnBuscarPorDni.Location = new System.Drawing.Point(600, 15);
            this.btnBuscarPorDni.Name = "btnBuscarPorDni";
            this.btnBuscarPorDni.Size = new System.Drawing.Size(109, 23);
            this.btnBuscarPorDni.TabIndex = 2;
            this.btnBuscarPorDni.Text = "BUSCAR";
            this.btnBuscarPorDni.UseVisualStyleBackColor = true;
            this.btnBuscarPorDni.Click += new System.EventHandler(this.btnBuscarPorDni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESA EL DNI";
            // 
            // TXTINGDNI
            // 
            this.TXTINGDNI.Location = new System.Drawing.Point(204, 16);
            this.TXTINGDNI.Name = "TXTINGDNI";
            this.TXTINGDNI.Size = new System.Drawing.Size(385, 22);
            this.TXTINGDNI.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TXTINGNOMBRE);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(988, 52);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BUSCAR POR NOMBRES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TXTINGNOMBRE
            // 
            this.TXTINGNOMBRE.Location = new System.Drawing.Point(204, 16);
            this.TXTINGNOMBRE.Name = "TXTINGNOMBRE";
            this.TXTINGNOMBRE.Size = new System.Drawing.Size(385, 22);
            this.TXTINGNOMBRE.TabIndex = 3;
            this.TXTINGNOMBRE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXTNOMBRESBUSCA_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "INGRESA EL NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "EMPIEZA BUSCANDO AL ALUMNO QUE DESEAS REGISTRAR SU PAGO";
            // 
            // GRIDVIEWCONSALUPAGO
            // 
            this.GRIDVIEWCONSALUPAGO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEWCONSALUPAGO.Location = new System.Drawing.Point(12, 183);
            this.GRIDVIEWCONSALUPAGO.Name = "GRIDVIEWCONSALUPAGO";
            this.GRIDVIEWCONSALUPAGO.ReadOnly = true;
            this.GRIDVIEWCONSALUPAGO.RowTemplate.Height = 24;
            this.GRIDVIEWCONSALUPAGO.Size = new System.Drawing.Size(990, 138);
            this.GRIDVIEWCONSALUPAGO.TabIndex = 3;
            this.GRIDVIEWCONSALUPAGO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewNombres_CellClick);
            // 
            // FOTOALUMNOAPAGAR
            // 
            this.FOTOALUMNOAPAGAR.Location = new System.Drawing.Point(1041, 72);
            this.FOTOALUMNOAPAGAR.Name = "FOTOALUMNOAPAGAR";
            this.FOTOALUMNOAPAGAR.Size = new System.Drawing.Size(185, 214);
            this.FOTOALUMNOAPAGAR.TabIndex = 4;
            this.FOTOALUMNOAPAGAR.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "REGISTRO DE PAGOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1033, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "CODIGO";
            // 
            // LBLCODIGOALUMN
            // 
            this.LBLCODIGOALUMN.AutoSize = true;
            this.LBLCODIGOALUMN.Location = new System.Drawing.Point(1132, 289);
            this.LBLCODIGOALUMN.Name = "LBLCODIGOALUMN";
            this.LBLCODIGOALUMN.Size = new System.Drawing.Size(89, 17);
            this.LBLCODIGOALUMN.TabIndex = 7;
            this.LBLCODIGOALUMN.Text = "XXXXXXXXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(462, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "SELECCIONE UNO O VARIOS DE LOS PAGOS QUE DESEA REALIZAR";
            // 
            // PANELMATRICULA
            // 
            this.PANELMATRICULA.Controls.Add(this.NUMCICLO);
            this.PANELMATRICULA.Controls.Add(this.label7);
            this.PANELMATRICULA.Controls.Add(this.GBNIVEL);
            this.PANELMATRICULA.Controls.Add(this.GBIDIOMA);
            this.PANELMATRICULA.Controls.Add(this.GBMODALIDADMATRICULA);
            this.PANELMATRICULA.Enabled = false;
            this.PANELMATRICULA.Location = new System.Drawing.Point(767, 401);
            this.PANELMATRICULA.Name = "PANELMATRICULA";
            this.PANELMATRICULA.Size = new System.Drawing.Size(535, 309);
            this.PANELMATRICULA.TabIndex = 9;
            // 
            // NUMCICLO
            // 
            this.NUMCICLO.Location = new System.Drawing.Point(402, 272);
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
            this.NUMCICLO.Size = new System.Drawing.Size(57, 22);
            this.NUMCICLO.TabIndex = 6;
            this.NUMCICLO.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "INGRESE CICLO";
            // 
            // GBNIVEL
            // 
            this.GBNIVEL.Controls.Add(this.RBAVANZADO);
            this.GBNIVEL.Controls.Add(this.RBINTERMEDIO);
            this.GBNIVEL.Controls.Add(this.RBBASICO);
            this.GBNIVEL.Location = new System.Drawing.Point(341, 38);
            this.GBNIVEL.Name = "GBNIVEL";
            this.GBNIVEL.Size = new System.Drawing.Size(163, 198);
            this.GBNIVEL.TabIndex = 3;
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
            this.GBIDIOMA.Location = new System.Drawing.Point(9, 111);
            this.GBIDIOMA.Name = "GBIDIOMA";
            this.GBIDIOMA.Size = new System.Drawing.Size(256, 183);
            this.GBIDIOMA.TabIndex = 2;
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
            // GBMODALIDADMATRICULA
            // 
            this.GBMODALIDADMATRICULA.Controls.Add(this.RBMATUBICACION);
            this.GBMODALIDADMATRICULA.Controls.Add(this.RBMATREGULAR);
            this.GBMODALIDADMATRICULA.Location = new System.Drawing.Point(3, 23);
            this.GBMODALIDADMATRICULA.Name = "GBMODALIDADMATRICULA";
            this.GBMODALIDADMATRICULA.Size = new System.Drawing.Size(332, 82);
            this.GBMODALIDADMATRICULA.TabIndex = 1;
            this.GBMODALIDADMATRICULA.TabStop = false;
            this.GBMODALIDADMATRICULA.Text = "SELECCIONE MODALIDAD DE MATRICULA";
            // 
            // RBMATUBICACION
            // 
            this.RBMATUBICACION.AutoSize = true;
            this.RBMATUBICACION.Location = new System.Drawing.Point(6, 49);
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
            this.RBMATREGULAR.Location = new System.Drawing.Point(6, 21);
            this.RBMATREGULAR.Name = "RBMATREGULAR";
            this.RBMATREGULAR.Size = new System.Drawing.Size(178, 21);
            this.RBMATREGULAR.TabIndex = 0;
            this.RBMATREGULAR.TabStop = true;
            this.RBMATREGULAR.Text = "MATRICULA REGULAR";
            this.RBMATREGULAR.UseVisualStyleBackColor = true;
            // 
            // TXTMONTO
            // 
            this.TXTMONTO.Location = new System.Drawing.Point(15, 755);
            this.TXTMONTO.Name = "TXTMONTO";
            this.TXTMONTO.ReadOnly = true;
            this.TXTMONTO.Size = new System.Drawing.Size(340, 22);
            this.TXTMONTO.TabIndex = 10;
            this.TXTMONTO.Text = "0";
            this.TXTMONTO.TextChanged += new System.EventHandler(this.TXTMONTO_TextChanged);
            this.TXTMONTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 735);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "MONTO A PAGAR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(485, 735);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "NUMERO DE RECIBO";
            // 
            // TXTNUMERORECIBO
            // 
            this.TXTNUMERORECIBO.Enabled = false;
            this.TXTNUMERORECIBO.Location = new System.Drawing.Point(486, 757);
            this.TXTNUMERORECIBO.Name = "TXTNUMERORECIBO";
            this.TXTNUMERORECIBO.Size = new System.Drawing.Size(301, 22);
            this.TXTNUMERORECIBO.TabIndex = 12;
            // 
            // FECHARECIBO
            // 
            this.FECHARECIBO.Enabled = false;
            this.FECHARECIBO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FECHARECIBO.Location = new System.Drawing.Point(892, 755);
            this.FECHARECIBO.Name = "FECHARECIBO";
            this.FECHARECIBO.ShowUpDown = true;
            this.FECHARECIBO.Size = new System.Drawing.Size(348, 22);
            this.FECHARECIBO.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(889, 735);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "FECHA DEL RECIBO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1018, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Codigo de sesión";
            // 
            // LBLUSUENCARGADODEPAGO
            // 
            this.LBLUSUENCARGADODEPAGO.AutoSize = true;
            this.LBLUSUENCARGADODEPAGO.Location = new System.Drawing.Point(1192, 9);
            this.LBLUSUENCARGADODEPAGO.Name = "LBLUSUENCARGADODEPAGO";
            this.LBLUSUENCARGADODEPAGO.Size = new System.Drawing.Size(62, 17);
            this.LBLUSUENCARGADODEPAGO.TabIndex = 17;
            this.LBLUSUENCARGADODEPAGO.Text = "XXXXXX";
            // 
            // BTNGUARDARPAGO
            // 
            this.BTNGUARDARPAGO.Location = new System.Drawing.Point(1023, 783);
            this.BTNGUARDARPAGO.Name = "BTNGUARDARPAGO";
            this.BTNGUARDARPAGO.Size = new System.Drawing.Size(217, 43);
            this.BTNGUARDARPAGO.TabIndex = 18;
            this.BTNGUARDARPAGO.Text = "GUARDAR PAGO";
            this.BTNGUARDARPAGO.UseVisualStyleBackColor = true;
            this.BTNGUARDARPAGO.Click += new System.EventHandler(this.BTNGUARDARPAGO_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1033, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "TIPO";
            // 
            // LBLTIPOALUMN
            // 
            this.LBLTIPOALUMN.AutoSize = true;
            this.LBLTIPOALUMN.Location = new System.Drawing.Point(1132, 306);
            this.LBLTIPOALUMN.Name = "LBLTIPOALUMN";
            this.LBLTIPOALUMN.Size = new System.Drawing.Size(89, 17);
            this.LBLTIPOALUMN.TabIndex = 20;
            this.LBLTIPOALUMN.Text = "XXXXXXXXX";
            this.LBLTIPOALUMN.TextChanged += new System.EventHandler(this.LBLTIPOALUMN_TextChanged);
            // 
            // MISSINGDATA
            // 
            this.MISSINGDATA.ContainerControl = this;
            // 
            // GRIDVIEWTIPOSPAGOS
            // 
            this.GRIDVIEWTIPOSPAGOS.AllowUserToAddRows = false;
            this.GRIDVIEWTIPOSPAGOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDVIEWTIPOSPAGOS.Location = new System.Drawing.Point(12, 401);
            this.GRIDVIEWTIPOSPAGOS.Name = "GRIDVIEWTIPOSPAGOS";
            this.GRIDVIEWTIPOSPAGOS.RowTemplate.Height = 24;
            this.GRIDVIEWTIPOSPAGOS.Size = new System.Drawing.Size(724, 271);
            this.GRIDVIEWTIPOSPAGOS.TabIndex = 21;
            // 
            // CBPAGARMATRICULA
            // 
            this.CBPAGARMATRICULA.AutoSize = true;
            this.CBPAGARMATRICULA.Enabled = false;
            this.CBPAGARMATRICULA.Location = new System.Drawing.Point(764, 374);
            this.CBPAGARMATRICULA.Name = "CBPAGARMATRICULA";
            this.CBPAGARMATRICULA.Size = new System.Drawing.Size(254, 21);
            this.CBPAGARMATRICULA.TabIndex = 22;
            this.CBPAGARMATRICULA.Text = "PAGAR MATRICULA DEL ALUMNO";
            this.CBPAGARMATRICULA.UseVisualStyleBackColor = true;
            this.CBPAGARMATRICULA.CheckedChanged += new System.EventHandler(this.CBPAGARMATRICULA_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 783);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 42);
            this.button1.TabIndex = 23;
            this.button1.Text = "CALCULAR MONTO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmCrearPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1332, 878);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CBPAGARMATRICULA);
            this.Controls.Add(this.GRIDVIEWTIPOSPAGOS);
            this.Controls.Add(this.LBLTIPOALUMN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BTNGUARDARPAGO);
            this.Controls.Add(this.LBLUSUENCARGADODEPAGO);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FECHARECIBO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TXTNUMERORECIBO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXTMONTO);
            this.Controls.Add(this.PANELMATRICULA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LBLCODIGOALUMN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FOTOALUMNOAPAGAR);
            this.Controls.Add(this.GRIDVIEWCONSALUPAGO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCrearPago";
            this.Text = "MODULO DE REGISTRO DE PAGOS";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWCONSALUPAGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FOTOALUMNOAPAGAR)).EndInit();
            this.PANELMATRICULA.ResumeLayout(false);
            this.PANELMATRICULA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMCICLO)).EndInit();
            this.GBNIVEL.ResumeLayout(false);
            this.GBNIVEL.PerformLayout();
            this.GBIDIOMA.ResumeLayout(false);
            this.GBIDIOMA.PerformLayout();
            this.GBMODALIDADMATRICULA.ResumeLayout(false);
            this.GBMODALIDADMATRICULA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MISSINGDATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDVIEWTIPOSPAGOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GRIDVIEWCONSALUPAGO;
        private System.Windows.Forms.PictureBox FOTOALUMNOAPAGAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTINGDNI;
        private System.Windows.Forms.TextBox TXTINGNOMBRE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLCODIGOALUMN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PANELMATRICULA;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NUMCICLO;
        private System.Windows.Forms.TextBox TXTMONTO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXTNUMERORECIBO;
        private System.Windows.Forms.DateTimePicker FECHARECIBO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LBLUSUENCARGADODEPAGO;
        private System.Windows.Forms.Button BTNGUARDARPAGO;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LBLTIPOALUMN;
        private System.Windows.Forms.Button btnBuscarPorDni;
        private System.Windows.Forms.ErrorProvider MISSINGDATA;
        private System.Windows.Forms.DataGridView GRIDVIEWTIPOSPAGOS;
        private System.Windows.Forms.CheckBox CBPAGARMATRICULA;
        private System.Windows.Forms.Button button1;
    }
}
