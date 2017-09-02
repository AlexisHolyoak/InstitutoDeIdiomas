using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDeIdiomas
{
    public partial class frmActualizarAlumno : Form
    {
        private TextBox TXTALUSEARCH;
        private Label label2;
        private DataGridView GVALUMNOS;
        private Button BTNACTUALIZAR;
        private Label LBLIDPERSONA;
        private Label label1;
        MsSqlConnection configurarConexion = new MsSqlConnection();
        private TextBox TXTEDAD;
        private Label label12;
        private Label label11;
        private TextBox TXTTELEFONO;
        private TextBox TXTCELULAR;
        private Label label10;
        private TextBox TXTCORREO;
        private Label label9;
        private DateTimePicker DTNACIMIENTO;
        private Label label8;
        private Button BTNFOTO;
        private ComboBox CBSEXO;
        private Label label7;
        private Label label6;
        private TextBox TXTDNI;
        private Label label5;
        private TextBox TXTNOMBRE;
        private PictureBox ALUMNOIMAGE;
        private Label label4;
        private TextBox TXTMATERNO;
        private Label label3;
        private TextBox TXTPATERNO;
        private Button BTNGUARDAR;
        public static SqlConnection _SqlConnection = new SqlConnection();
        public frmActualizarAlumno()
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            ALUMNOIMAGE.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarAlumno));
            this.TXTALUSEARCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GVALUMNOS = new System.Windows.Forms.DataGridView();
            this.BTNACTUALIZAR = new System.Windows.Forms.Button();
            this.LBLIDPERSONA = new System.Windows.Forms.Label();
            this.TXTEDAD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TXTTELEFONO = new System.Windows.Forms.TextBox();
            this.TXTCELULAR = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TXTCORREO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DTNACIMIENTO = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.BTNFOTO = new System.Windows.Forms.Button();
            this.CBSEXO = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.ALUMNOIMAGE = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTMATERNO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTPATERNO = new System.Windows.Forms.TextBox();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVALUMNOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALUMNOIMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTALUSEARCH
            // 
            this.TXTALUSEARCH.Location = new System.Drawing.Point(13, 72);
            this.TXTALUSEARCH.Name = "TXTALUSEARCH";
            this.TXTALUSEARCH.Size = new System.Drawing.Size(389, 22);
            this.TXTALUSEARCH.TabIndex = 0;
            this.TXTALUSEARCH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXTALUSEARCH_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENIDO AL MODULO DE ACTUALIZACION DE DATOS DEL ALUMNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa nombres del alumno a buscar";
            // 
            // GVALUMNOS
            // 
            this.GVALUMNOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVALUMNOS.Location = new System.Drawing.Point(16, 101);
            this.GVALUMNOS.Name = "GVALUMNOS";
            this.GVALUMNOS.RowTemplate.Height = 24;
            this.GVALUMNOS.Size = new System.Drawing.Size(386, 413);
            this.GVALUMNOS.TabIndex = 3;
            this.GVALUMNOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVALUMNOS_CellClick);
            // 
            // BTNACTUALIZAR
            // 
            this.BTNACTUALIZAR.Location = new System.Drawing.Point(757, 476);
            this.BTNACTUALIZAR.Name = "BTNACTUALIZAR";
            this.BTNACTUALIZAR.Size = new System.Drawing.Size(162, 38);
            this.BTNACTUALIZAR.TabIndex = 26;
            this.BTNACTUALIZAR.Text = "ACTUALIZAR";
            this.BTNACTUALIZAR.UseVisualStyleBackColor = true;
            this.BTNACTUALIZAR.Click += new System.EventHandler(this.BTNACTUALIZAR_Click);
            // 
            // LBLIDPERSONA
            // 
            this.LBLIDPERSONA.AutoSize = true;
            this.LBLIDPERSONA.Location = new System.Drawing.Point(421, 496);
            this.LBLIDPERSONA.Name = "LBLIDPERSONA";
            this.LBLIDPERSONA.Size = new System.Drawing.Size(53, 17);
            this.LBLIDPERSONA.TabIndex = 27;
            this.LBLIDPERSONA.Text = "XXXXX";
            // 
            // TXTEDAD
            // 
            this.TXTEDAD.Enabled = false;
            this.TXTEDAD.Location = new System.Drawing.Point(592, 283);
            this.TXTEDAD.Name = "TXTEDAD";
            this.TXTEDAD.ReadOnly = true;
            this.TXTEDAD.Size = new System.Drawing.Size(183, 22);
            this.TXTEDAD.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(538, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 68;
            this.label12.Text = "EDAD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(818, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 67;
            this.label11.Text = "TELEFONO";
            // 
            // TXTTELEFONO
            // 
            this.TXTTELEFONO.Location = new System.Drawing.Point(908, 374);
            this.TXTTELEFONO.Name = "TXTTELEFONO";
            this.TXTTELEFONO.ReadOnly = true;
            this.TXTTELEFONO.Size = new System.Drawing.Size(183, 22);
            this.TXTTELEFONO.TabIndex = 66;
            // 
            // TXTCELULAR
            // 
            this.TXTCELULAR.Location = new System.Drawing.Point(590, 374);
            this.TXTCELULAR.Name = "TXTCELULAR";
            this.TXTCELULAR.ReadOnly = true;
            this.TXTCELULAR.Size = new System.Drawing.Size(183, 22);
            this.TXTCELULAR.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(514, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 64;
            this.label10.Text = "CELULAR";
            // 
            // TXTCORREO
            // 
            this.TXTCORREO.Location = new System.Drawing.Point(591, 346);
            this.TXTCORREO.Name = "TXTCORREO";
            this.TXTCORREO.ReadOnly = true;
            this.TXTCORREO.Size = new System.Drawing.Size(500, 22);
            this.TXTCORREO.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 17);
            this.label9.TabIndex = 62;
            this.label9.Text = "CORREO ELECTRONICO";
            // 
            // DTNACIMIENTO
            // 
            this.DTNACIMIENTO.Enabled = false;
            this.DTNACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTNACIMIENTO.Location = new System.Drawing.Point(592, 255);
            this.DTNACIMIENTO.Name = "DTNACIMIENTO";
            this.DTNACIMIENTO.ShowUpDown = true;
            this.DTNACIMIENTO.Size = new System.Drawing.Size(330, 22);
            this.DTNACIMIENTO.TabIndex = 61;
            this.DTNACIMIENTO.ValueChanged += new System.EventHandler(this.DTNACIMIENTO_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "FECHA DE NACIMIENTO";
            // 
            // BTNFOTO
            // 
            this.BTNFOTO.Enabled = false;
            this.BTNFOTO.Location = new System.Drawing.Point(926, 304);
            this.BTNFOTO.Name = "BTNFOTO";
            this.BTNFOTO.Size = new System.Drawing.Size(165, 36);
            this.BTNFOTO.TabIndex = 59;
            this.BTNFOTO.Text = "CAMBIAR FOTO";
            this.BTNFOTO.UseVisualStyleBackColor = true;
            this.BTNFOTO.Click += new System.EventHandler(this.BTNFOTO_Click);
            // 
            // CBSEXO
            // 
            this.CBSEXO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSEXO.Enabled = false;
            this.CBSEXO.FormattingEnabled = true;
            this.CBSEXO.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CBSEXO.Location = new System.Drawing.Point(592, 225);
            this.CBSEXO.Name = "CBSEXO";
            this.CBSEXO.Size = new System.Drawing.Size(329, 24);
            this.CBSEXO.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "SEXO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "D.N.I.";
            // 
            // TXTDNI
            // 
            this.TXTDNI.Location = new System.Drawing.Point(591, 197);
            this.TXTDNI.Name = "TXTDNI";
            this.TXTDNI.ReadOnly = true;
            this.TXTDNI.Size = new System.Drawing.Size(330, 22);
            this.TXTDNI.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "NOMBRES";
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(591, 169);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.ReadOnly = true;
            this.TXTNOMBRE.Size = new System.Drawing.Size(330, 22);
            this.TXTNOMBRE.TabIndex = 53;
            // 
            // ALUMNOIMAGE
            // 
            this.ALUMNOIMAGE.Location = new System.Drawing.Point(926, 112);
            this.ALUMNOIMAGE.Name = "ALUMNOIMAGE";
            this.ALUMNOIMAGE.Size = new System.Drawing.Size(165, 186);
            this.ALUMNOIMAGE.TabIndex = 52;
            this.ALUMNOIMAGE.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "APELLIDO MATERNO";
            // 
            // TXTMATERNO
            // 
            this.TXTMATERNO.Location = new System.Drawing.Point(590, 140);
            this.TXTMATERNO.Name = "TXTMATERNO";
            this.TXTMATERNO.ReadOnly = true;
            this.TXTMATERNO.Size = new System.Drawing.Size(330, 22);
            this.TXTMATERNO.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "APELLIDO PATERNO";
            // 
            // TXTPATERNO
            // 
            this.TXTPATERNO.Location = new System.Drawing.Point(590, 112);
            this.TXTPATERNO.Name = "TXTPATERNO";
            this.TXTPATERNO.ReadOnly = true;
            this.TXTPATERNO.Size = new System.Drawing.Size(330, 22);
            this.TXTPATERNO.TabIndex = 48;
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Enabled = false;
            this.BTNGUARDAR.Location = new System.Drawing.Point(928, 476);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(162, 38);
            this.BTNGUARDAR.TabIndex = 70;
            this.BTNGUARDAR.Text = "GUARDAR";
            this.BTNGUARDAR.UseVisualStyleBackColor = true;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // frmActualizarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 534);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.TXTEDAD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TXTTELEFONO);
            this.Controls.Add(this.TXTCELULAR);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TXTCORREO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DTNACIMIENTO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BTNFOTO);
            this.Controls.Add(this.CBSEXO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTDNI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.ALUMNOIMAGE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTMATERNO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTPATERNO);
            this.Controls.Add(this.LBLIDPERSONA);
            this.Controls.Add(this.BTNACTUALIZAR);
            this.Controls.Add(this.GVALUMNOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTALUSEARCH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmActualizarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR ALUMNO";
            ((System.ComponentModel.ISupportInitialize)(this.GVALUMNOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALUMNOIMAGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TXTALUSEARCH_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscarAlumnoApellido", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@txt", TXTALUSEARCH.Text.Trim()));
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                dt.Clear();

                da.Fill(dt);


                GVALUMNOS.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                _SqlConnection.Close();
            }
        }

        private void GVALUMNOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < GVALUMNOS.RowCount - 1)
            {
                DataGridViewRow row = this.GVALUMNOS.Rows[e.RowIndex];
                String dni = row.Cells[3].Value.ToString();               
                try {
                    DataTable dt = new DataTable();
                    SqlCommand comando = new SqlCommand("buscarPersona", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@dni", dni));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    byte[] img = (byte[])(dt.Rows[0][7]);
                    if (img == null)
                    {
                        ALUMNOIMAGE.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        ALUMNOIMAGE.Image = Image.FromStream(ms);
                    }
                    LBLIDPERSONA.Text = dt.Rows[0][0].ToString();
                    TXTPATERNO.Text = dt.Rows[0][1].ToString();
                    TXTMATERNO.Text = dt.Rows[0][2].ToString();
                    TXTNOMBRE.Text = dt.Rows[0][3].ToString();
                    TXTEDAD.Text = dt.Rows[0][4].ToString();
                    DTNACIMIENTO.Value = DateTime.Parse(dt.Rows[0][5].ToString());
                    TXTCORREO.Text = dt.Rows[0][6].ToString();
                    TXTTELEFONO.Text = dt.Rows[0][8].ToString();
                    TXTCELULAR.Text = dt.Rows[0][9].ToString();
                    if (dt.Rows[0][10].ToString() == "MASCULINO")
                    {
                        CBSEXO.SelectedIndex = 0;
                    }
                    else {
                        CBSEXO.SelectedIndex = 1;
                    }
                    TXTDNI.Text = dt.Rows[0][11].ToString();
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BTNACTUALIZAR_Click(object sender, EventArgs e)
        {
            HABILITARCONTROLES();
        }
        private void HABILITARCONTROLES() {
            TXTPATERNO.ReadOnly = false;
            TXTMATERNO.ReadOnly = false;
            TXTNOMBRE.ReadOnly = false;
            TXTDNI.ReadOnly = false;
            CBSEXO.Enabled = true;
            DTNACIMIENTO.Enabled = true;
            TXTCORREO.ReadOnly = false;
            TXTCELULAR.ReadOnly = false;
            TXTTELEFONO.ReadOnly = false;
            BTNGUARDAR.Enabled = true;
            BTNFOTO.Enabled = true;
            BTNACTUALIZAR.Enabled = false;
        }
        private void DESHABILITARCONTROLES() {
            TXTPATERNO.ReadOnly = true;
            TXTMATERNO.ReadOnly = true;
            TXTNOMBRE.ReadOnly = true;
            TXTDNI.ReadOnly = true;
            CBSEXO.Enabled = false;
            DTNACIMIENTO.Enabled = false;
            TXTCORREO.ReadOnly = true;
            TXTCELULAR.ReadOnly = true;
            TXTTELEFONO.ReadOnly = true;
            BTNGUARDAR.Enabled = false;
            BTNFOTO.Enabled = false;
            BTNACTUALIZAR.Enabled = true ;
        }
        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {            
            try {
                SqlCommand comando = new SqlCommand("actualizarPersona", _SqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                comando.Parameters.Add(new SqlParameter("@id", LBLIDPERSONA.Text.ToString()));
                comando.Parameters.Add(new SqlParameter("@paterno", TXTPATERNO.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@dni", TXTDNI.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@nombre", TXTNOMBRE.Text.Trim()));              
                comando.Parameters.Add(new SqlParameter("@materno", TXTMATERNO.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@sexo", CBSEXO.SelectedItem.ToString()));
                comando.Parameters.Add(new SqlParameter("@edad", TXTEDAD.Text.Trim()));                                                
                comando.Parameters.Add(new SqlParameter("@celular", TXTCELULAR.Text.Trim()));               
                comando.Parameters.Add(new SqlParameter("@telefono", TXTTELEFONO.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@correo", TXTCORREO.Text.Trim()));
                comando.Parameters.Add(new SqlParameter("@nacimiento", DTNACIMIENTO.Value));
                comando.Parameters.Add("@foto", System.Data.SqlDbType.Image);
                //asignando el valor de la imagen
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                //se guarda la imagen en el buffer
                ALUMNOIMAGE.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //se extraen los bytes del buffer para asignarlos como valor para el parametro
                comando.Parameters["@foto"].Value = ms.GetBuffer();
                comando.ExecuteNonQuery();
                DESHABILITARCONTROLES();
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
                MessageBox.Show("REGISTRO ACTUALIZADO");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTNFOTO_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ALUMNOIMAGE.SizeMode = PictureBoxSizeMode.StretchImage;
                ALUMNOIMAGE.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void DTNACIMIENTO_ValueChanged(object sender, EventArgs e)
        {
            if (DTNACIMIENTO.Value < DateTime.Today)
            {
                //CODIGO USADO PARA CALCULAR LA EDAD AUTOMATICAMENTE
                TXTEDAD.Text = (DateTime.Today.AddTicks(-DTNACIMIENTO.Value.Ticks).Year - 1).ToString();
            }
            else
            {
                DTNACIMIENTO.Value = DateTime.Today;
            }
        }
    }
}
