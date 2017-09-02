namespace InstitutoDeIdiomas
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.TXTBIENBUSER = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTCODUSER = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aLUMNOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.REGISTRARMENU = new System.Windows.Forms.ToolStripMenuItem();
            this.CONSULTARMENU = new System.Windows.Forms.ToolStripMenuItem();
            this.ACTUALIZAROPTIONMENU = new System.Windows.Forms.ToolStripMenuItem();
            this.pAGOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.REGISTRARPAGOMENU = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.GENERALCONSMENU = new System.Windows.Forms.ToolStripMenuItem();
            this.DEUDORESCONSMENU = new System.Windows.Forms.ToolStripMenuItem();
            this.gRUPOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearGrupo = new System.Windows.Forms.ToolStripMenuItem();
            this.verGrupo = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAlumnosAGrupo = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cREARToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FICHAMATRICULATOOL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXTBIENBUSER
            // 
            this.TXTBIENBUSER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TXTBIENBUSER.AutoSize = true;
            this.TXTBIENBUSER.Location = new System.Drawing.Point(124, 498);
            this.TXTBIENBUSER.Name = "TXTBIENBUSER";
            this.TXTBIENBUSER.Size = new System.Drawing.Size(70, 17);
            this.TXTBIENBUSER.TabIndex = 0;
            this.TXTBIENBUSER.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bienvenid@";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(881, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo";
            // 
            // TXTCODUSER
            // 
            this.TXTCODUSER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTCODUSER.AutoSize = true;
            this.TXTCODUSER.Location = new System.Drawing.Point(939, 498);
            this.TXTCODUSER.Name = "TXTCODUSER";
            this.TXTCODUSER.Size = new System.Drawing.Size(46, 17);
            this.TXTCODUSER.TabIndex = 3;
            this.TXTCODUSER.Text = "label4";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLUMNOSToolStripMenuItem,
            this.pAGOSToolStripMenuItem,
            this.gRUPOSToolStripMenuItem,
            this.uSUARIOSToolStripMenuItem,
            this.rEPORTESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aLUMNOSToolStripMenuItem
            // 
            this.aLUMNOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.REGISTRARMENU,
            this.CONSULTARMENU,
            this.ACTUALIZAROPTIONMENU});
            this.aLUMNOSToolStripMenuItem.Name = "aLUMNOSToolStripMenuItem";
            this.aLUMNOSToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.aLUMNOSToolStripMenuItem.Text = "ALUMNOS";
            // 
            // REGISTRARMENU
            // 
            this.REGISTRARMENU.Name = "REGISTRARMENU";
            this.REGISTRARMENU.Size = new System.Drawing.Size(170, 26);
            this.REGISTRARMENU.Text = "REGISTRAR";
            this.REGISTRARMENU.Click += new System.EventHandler(this.REGISTRARMENU_Click);
            // 
            // CONSULTARMENU
            // 
            this.CONSULTARMENU.Name = "CONSULTARMENU";
            this.CONSULTARMENU.Size = new System.Drawing.Size(170, 26);
            this.CONSULTARMENU.Text = "CONSULTAR";
            this.CONSULTARMENU.Click += new System.EventHandler(this.CONSULTARMENU_Click);
            // 
            // ACTUALIZAROPTIONMENU
            // 
            this.ACTUALIZAROPTIONMENU.Name = "ACTUALIZAROPTIONMENU";
            this.ACTUALIZAROPTIONMENU.Size = new System.Drawing.Size(170, 26);
            this.ACTUALIZAROPTIONMENU.Text = "ACTUALIZAR";
            this.ACTUALIZAROPTIONMENU.Click += new System.EventHandler(this.ACTUALIZAROPTIONMENU_Click);
            // 
            // pAGOSToolStripMenuItem
            // 
            this.pAGOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.REGISTRARPAGOMENU,
            this.cONSULTARToolStripMenuItem2});
            this.pAGOSToolStripMenuItem.Name = "pAGOSToolStripMenuItem";
            this.pAGOSToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.pAGOSToolStripMenuItem.Text = "PAGOS";
            // 
            // REGISTRARPAGOMENU
            // 
            this.REGISTRARPAGOMENU.Name = "REGISTRARPAGOMENU";
            this.REGISTRARPAGOMENU.Size = new System.Drawing.Size(165, 26);
            this.REGISTRARPAGOMENU.Text = "REGISTRAR";
            this.REGISTRARPAGOMENU.Click += new System.EventHandler(this.REGISTRARPAGOMENU_Click);
            // 
            // cONSULTARToolStripMenuItem2
            // 
            this.cONSULTARToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GENERALCONSMENU,
            this.DEUDORESCONSMENU});
            this.cONSULTARToolStripMenuItem2.Name = "cONSULTARToolStripMenuItem2";
            this.cONSULTARToolStripMenuItem2.Size = new System.Drawing.Size(165, 26);
            this.cONSULTARToolStripMenuItem2.Text = "CONSULTAR";
            // 
            // GENERALCONSMENU
            // 
            this.GENERALCONSMENU.Name = "GENERALCONSMENU";
            this.GENERALCONSMENU.Size = new System.Drawing.Size(160, 26);
            this.GENERALCONSMENU.Text = "ESPECIFICO";
            this.GENERALCONSMENU.Click += new System.EventHandler(this.GENERALCONSMENU_Click);
            // 
            // DEUDORESCONSMENU
            // 
            this.DEUDORESCONSMENU.Name = "DEUDORESCONSMENU";
            this.DEUDORESCONSMENU.Size = new System.Drawing.Size(160, 26);
            this.DEUDORESCONSMENU.Text = "GENERAL";
            this.DEUDORESCONSMENU.Click += new System.EventHandler(this.DEUDORESCONSMENU_Click);
            // 
            // gRUPOSToolStripMenuItem
            // 
            this.gRUPOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearGrupo,
            this.verGrupo,
            this.agregarAlumnosAGrupo});
            this.gRUPOSToolStripMenuItem.Name = "gRUPOSToolStripMenuItem";
            this.gRUPOSToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.gRUPOSToolStripMenuItem.Text = "GRUPOS";
            // 
            // crearGrupo
            // 
            this.crearGrupo.Name = "crearGrupo";
            this.crearGrupo.Size = new System.Drawing.Size(290, 26);
            this.crearGrupo.Text = "CREAR";
            this.crearGrupo.Click += new System.EventHandler(this.crearGrupo_Click);
            // 
            // verGrupo
            // 
            this.verGrupo.Name = "verGrupo";
            this.verGrupo.Size = new System.Drawing.Size(290, 26);
            this.verGrupo.Text = "VER";
            this.verGrupo.Click += new System.EventHandler(this.verGrupo_Click);
            // 
            // agregarAlumnosAGrupo
            // 
            this.agregarAlumnosAGrupo.Name = "agregarAlumnosAGrupo";
            this.agregarAlumnosAGrupo.Size = new System.Drawing.Size(290, 26);
            this.agregarAlumnosAGrupo.Text = "AGREGAR ALUMNOS A GRUPO";
            this.agregarAlumnosAGrupo.Click += new System.EventHandler(this.agregarAlumnosAGrupo_Click);
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cREARToolStripMenuItem1});
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            // 
            // cREARToolStripMenuItem1
            // 
            this.cREARToolStripMenuItem1.Name = "cREARToolStripMenuItem1";
            this.cREARToolStripMenuItem1.Size = new System.Drawing.Size(129, 26);
            this.cREARToolStripMenuItem1.Text = "CREAR";
            this.cREARToolStripMenuItem1.Click += new System.EventHandler(this.cREARToolStripMenuItem1_Click);
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FICHAMATRICULATOOL});
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            // 
            // FICHAMATRICULATOOL
            // 
            this.FICHAMATRICULATOOL.Name = "FICHAMATRICULATOOL";
            this.FICHAMATRICULATOOL.Size = new System.Drawing.Size(231, 26);
            this.FICHAMATRICULATOOL.Text = "FICHA DE MATRICULA";
            this.FICHAMATRICULATOOL.Click += new System.EventHandler(this.FICHAMATRICULATOOL_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(997, 524);
            this.Controls.Add(this.TXTCODUSER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTBIENBUSER);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "MENU PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label TXTBIENBUSER;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TXTCODUSER;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aLUMNOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem REGISTRARMENU;
        private System.Windows.Forms.ToolStripMenuItem CONSULTARMENU;
        private System.Windows.Forms.ToolStripMenuItem pAGOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem REGISTRARPAGOMENU;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem GENERALCONSMENU;
        private System.Windows.Forms.ToolStripMenuItem DEUDORESCONSMENU;
        private System.Windows.Forms.ToolStripMenuItem gRUPOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearGrupo;
        private System.Windows.Forms.ToolStripMenuItem verGrupo;
        private System.Windows.Forms.ToolStripMenuItem agregarAlumnosAGrupo;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cREARToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FICHAMATRICULATOOL;
        private System.Windows.Forms.ToolStripMenuItem ACTUALIZAROPTIONMENU;
    }
}