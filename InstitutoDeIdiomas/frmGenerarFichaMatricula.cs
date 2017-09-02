using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstitutoDeIdiomas.ReportForms;
using System.IO;

namespace InstitutoDeIdiomas
{
    public partial class frmGenerarFichaMatricula : Form
    {
        private Label label1;
        private DataGridView dataGridView1;
        private Button BTNGENERAR;
        private DataGridView dataGridView2;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox TXTBUSCALUMN;
        public static SqlConnection _SqlConnection = new SqlConnection();
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox TXTOBSERVACION;
        private ErrorProvider errorProvider1;
        private IContainer components;
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public frmGenerarFichaMatricula()
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
             pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerarFichaMatricula));
            this.TXTBUSCALUMN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTNGENERAR = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTOBSERVACION = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTBUSCALUMN
            // 
            this.TXTBUSCALUMN.Location = new System.Drawing.Point(12, 49);
            this.TXTBUSCALUMN.Name = "TXTBUSCALUMN";
            this.TXTBUSCALUMN.Size = new System.Drawing.Size(543, 22);
            this.TXTBUSCALUMN.TabIndex = 0;
            this.TXTBUSCALUMN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXTBUSCALUMN_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "BUSCAR ALUMNO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewNombres_CellClick);
            // 
            // BTNGENERAR
            // 
            this.BTNGENERAR.Location = new System.Drawing.Point(580, 610);
            this.BTNGENERAR.Name = "BTNGENERAR";
            this.BTNGENERAR.Size = new System.Drawing.Size(266, 34);
            this.BTNGENERAR.TabIndex = 3;
            this.BTNGENERAR.Text = "GENERAR FICHA DE MATRICULA";
            this.BTNGENERAR.UseVisualStyleBackColor = true;
            this.BTNGENERAR.Click += new System.EventHandler(this.BTNGENERAR_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 291);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(831, 122);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewMatriculas_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "MATRICULAS REALIZADAS POR EL ALUMNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "CODIGO DE MATRICULA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(673, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "XXXXXXX";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(675, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 191);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 586);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID ALUMNO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 585);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "XXX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(763, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "XXXX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(675, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "CODIGO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(710, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "ESCRIBE UNA OBSERVACION PARA LA MATRICULA QUE ESTAS POR GENERAR (menos de 240 car" +
    "acteres)";
            // 
            // TXTOBSERVACION
            // 
            this.TXTOBSERVACION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTOBSERVACION.Enabled = false;
            this.TXTOBSERVACION.Location = new System.Drawing.Point(15, 446);
            this.TXTOBSERVACION.Multiline = true;
            this.TXTOBSERVACION.Name = "TXTOBSERVACION";
            this.TXTOBSERVACION.Size = new System.Drawing.Size(831, 98);
            this.TXTOBSERVACION.TabIndex = 15;
            this.TXTOBSERVACION.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXTOBSERVACION_KeyUp);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmGenerarFichaMatricula
            // 
            this.ClientSize = new System.Drawing.Size(874, 673);
            this.Controls.Add(this.TXTOBSERVACION);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BTNGENERAR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTBUSCALUMN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGenerarFichaMatricula";
            this.Text = "GENERAR FICHA DE MATRICULA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TXTBUSCALUMN_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscarAlumnoApellido", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@txt", TXTBUSCALUMN.Text.Trim()));

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                dt.Clear();

                da.Fill(dt);


               dataGridView1.DataSource = dt;
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
        private void GridViewNombres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount - 1)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                String dni = row.Cells[3].Value.ToString();               
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand comando = new SqlCommand("small_buscar_pordni", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@dni", dni));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    byte[] img = (byte[])(dt.Rows[0][4]);
                    if (img == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    //LBLTIPOALUMN.Text = dt.Rows[0][6].ToString();
                    label7.Text = dt.Rows[0][7].ToString();
                    label6.Text = dt.Rows[0][8].ToString();
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                    CARGAR_MATRICULAS(Convert.ToInt32(label6.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void CARGAR_MATRICULAS(int id) {
            try
            {
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("relacion_matriculas", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idalumno", id));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
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
        private void GridViewMatriculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView2.RowCount - 1)
            {
                limpiarError();
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                String codigo = row.Cells[0].Value.ToString();
                label4.Text = codigo;
                TXTOBSERVACION.Enabled = true;
            }
        }
        string dni, nom, ape, sex, eda, grad, tlf, cel, fotooo, email, naci, dep, dire, dist, prov,observaciones;

        private void TXTOBSERVACION_KeyUp(object sender, KeyEventArgs e)
        {
            validar();
        }
        private bool validar() {
            bool ok = true;
            if (TXTOBSERVACION.Text.Length >= 240)
            {
                errorProvider1.SetError(TXTOBSERVACION, "EL TEXTO DEBE TENER MENOS DE 240 CARACTERES");
                ok = false;
            }
            else {
                errorProvider1.SetError(TXTOBSERVACION, null);
            }
            if (label4.Text == "XXXXXXX") {
                errorProvider1.SetError(label2, "SELECCIONA UNA DE LAS MATRICULAS DEL CUADRO INFERIOR");
                ok = false;
            }
            return ok;
        }
        private void limpiarError() {
            errorProvider1.SetError(label2, null);
        }
        string idioma, nivel, ciclo, modalidad, fechamat, monto, recibo, encargado,personaencargo;
        DataTable studentpic;
        string codigoAlumno;
        private void BTNGENERAR_Click(object sender, EventArgs e)
        {          
            if (TXTOBSERVACION.Text.ToString().Trim() != "")
            {
                observaciones = TXTOBSERVACION.Text.ToString().Trim();
            }
            else {
                observaciones = "-";
            }

            string idalumno = label6.Text;
            string idmatricula = label4.Text;
            //------------------------------
            if (validar())
            {
                TXTOBSERVACION.Enabled = false;
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand comando = new SqlCommand("detalle_alumno_por_id", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@id", idalumno));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    dni = dt.Rows[0][0].ToString();
                    nom = dt.Rows[0][1].ToString();
                    ape = dt.Rows[0][2].ToString();
                    sex = dt.Rows[0][3].ToString();
                  
                    grad = dt.Rows[0][5].ToString();
                    tlf = dt.Rows[0][6].ToString();
                    cel = dt.Rows[0][7].ToString();
                    email = dt.Rows[0][9].ToString();
                    naci = Convert.ToDateTime(dt.Rows[0][10]).ToString("dd/MM/yy");
                    //eda = dt.Rows[0][4].ToString();
                    eda = (DateTime.Today.AddTicks(-Convert.ToDateTime(dt.Rows[0][10]).Ticks).Year - 1).ToString();
                    dep = dt.Rows[0][11].ToString();
                    dire = dt.Rows[0][12].ToString();
                    dist = dt.Rows[0][13].ToString();
                    prov = dt.Rows[0][14].ToString();
                    codigoAlumno = dt.Rows[0][15].ToString();
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    studentpic = new DataTable();
                    SqlCommand comando = new SqlCommand("buscar_foto_alumno", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@id", idalumno));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(studentpic);
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand comando = new SqlCommand("mostrar_detalle_matricula_por_id", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@id", idmatricula));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    idioma = dt.Rows[0][0].ToString();
                    nivel = dt.Rows[0][1].ToString();
                    modalidad = dt.Rows[0][2].ToString();
                    ciclo = dt.Rows[0][3].ToString();
                    fechamat = dt.Rows[0][4].ToString();
                    monto = dt.Rows[0][5].ToString();
                    recibo = dt.Rows[0][6].ToString();
                    encargado = dt.Rows[0][7].ToString();
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try {
                    DataTable dt = new DataTable();
                    SqlCommand comando = new SqlCommand("mostrar_trabajador", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@idtrabajador", encargado));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    personaencargo = dt.Rows[0][0].ToString();
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                cargar_reporte(dni, nom, ape, sex, eda, grad, tlf, cel, email, naci, dep, dire, dist, prov, idioma, nivel, modalidad, ciclo, fechamat, monto, personaencargo, recibo,studentpic,observaciones,codigoAlumno);
            }
           
        }
        private void cargar_reporte(string dni, string nom, string ape, string sex, string eda, string grad,string tlf, string cel,string email,string naci,string dep,string dire,string dist,string prov,string idioma,string nivel,string modalidad,string ciclo,string fecha,string monto,string responsable,string recibo,DataTable dt,string obs,string codAl) {
            using (frmRptFichaMatricula frm = new frmRptFichaMatricula(ape, nom, dni, sex, naci, eda, grad, tlf, cel, email, dire, dist, prov, dep, idioma, nivel, ciclo, fecha, responsable, recibo, monto, modalidad,dt,obs,codAl)) {
                frm.ShowDialog();                
            }
        }
    }
}
