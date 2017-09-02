namespace InstitutoDeIdiomas
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.TXTUSUARIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTPASSWORD = new System.Windows.Forms.TextBox();
            this.BTNLOGIN = new System.Windows.Forms.Button();
            this.ERROREMPTYTXTLOGIN = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ERROREMPTYTXTLOGIN)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTUSUARIO
            // 
            this.TXTUSUARIO.Location = new System.Drawing.Point(33, 44);
            this.TXTUSUARIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTUSUARIO.Name = "TXTUSUARIO";
            this.TXTUSUARIO.Size = new System.Drawing.Size(271, 22);
            this.TXTUSUARIO.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONTRASEÑA";
            // 
            // TXTPASSWORD
            // 
            this.TXTPASSWORD.Location = new System.Drawing.Point(33, 122);
            this.TXTPASSWORD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTPASSWORD.Name = "TXTPASSWORD";
            this.TXTPASSWORD.Size = new System.Drawing.Size(271, 22);
            this.TXTPASSWORD.TabIndex = 3;
            this.TXTPASSWORD.UseSystemPasswordChar = true;
            // 
            // BTNLOGIN
            // 
            this.BTNLOGIN.Location = new System.Drawing.Point(371, 80);
            this.BTNLOGIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTNLOGIN.Name = "BTNLOGIN";
            this.BTNLOGIN.Size = new System.Drawing.Size(132, 38);
            this.BTNLOGIN.TabIndex = 4;
            this.BTNLOGIN.Text = "INICIAR SESIÓN";
            this.BTNLOGIN.UseVisualStyleBackColor = true;
            this.BTNLOGIN.Click += new System.EventHandler(this.BTNLOGIN_Click);
            // 
            // ERROREMPTYTXTLOGIN
            // 
            this.ERROREMPTYTXTLOGIN.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 178);
            this.Controls.Add(this.BTNLOGIN);
            this.Controls.Add(this.TXTPASSWORD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTUSUARIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIAR SESIÓN";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ERROREMPTYTXTLOGIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTUSUARIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTPASSWORD;
        private System.Windows.Forms.Button BTNLOGIN;
        private System.Windows.Forms.ErrorProvider ERROREMPTYTXTLOGIN;
    }
}

