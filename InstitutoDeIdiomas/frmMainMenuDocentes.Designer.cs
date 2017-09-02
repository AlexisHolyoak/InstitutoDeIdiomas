namespace InstitutoDeIdiomas
{
    partial class frmMainMenuDocentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenuDocentes));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nOTASToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.REGISTROAUXMENU = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTBIENBUSER = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTCODUSER = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOTASToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nOTASToolStripMenuItem1
            // 
            this.nOTASToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.REGISTROAUXMENU});
            this.nOTASToolStripMenuItem1.Name = "nOTASToolStripMenuItem1";
            this.nOTASToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.nOTASToolStripMenuItem1.Text = "NOTAS";
            // 
            // REGISTROAUXMENU
            // 
            this.REGISTROAUXMENU.Name = "REGISTROAUXMENU";
            this.REGISTROAUXMENU.Size = new System.Drawing.Size(180, 22);
            this.REGISTROAUXMENU.Text = "REGISTRO AUXILIAR";
            this.REGISTROAUXMENU.Click += new System.EventHandler(this.REGISTROAUXMENU_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 512);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bienvenid@";
            // 
            // TXTBIENBUSER
            // 
            this.TXTBIENBUSER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TXTBIENBUSER.AutoSize = true;
            this.TXTBIENBUSER.Location = new System.Drawing.Point(76, 512);
            this.TXTBIENBUSER.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TXTBIENBUSER.Name = "TXTBIENBUSER";
            this.TXTBIENBUSER.Size = new System.Drawing.Size(56, 13);
            this.TXTBIENBUSER.TabIndex = 3;
            this.TXTBIENBUSER.Text = "USUARIO";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(761, 512);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo";
            // 
            // TXTCODUSER
            // 
            this.TXTCODUSER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTCODUSER.AutoSize = true;
            this.TXTCODUSER.Location = new System.Drawing.Point(819, 512);
            this.TXTCODUSER.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TXTCODUSER.Name = "TXTCODUSER";
            this.TXTCODUSER.Size = new System.Drawing.Size(35, 13);
            this.TXTCODUSER.TabIndex = 5;
            this.TXTCODUSER.Text = "label4";
            // 
            // frmMainMenuDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 533);
            this.Controls.Add(this.TXTCODUSER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTBIENBUSER);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainMenuDocentes";
            this.Text = "MENU PRINCIPAL DE DOCENTES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nOTASToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem REGISTROAUXMENU;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label TXTBIENBUSER;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TXTCODUSER;
    }
}