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

namespace InstitutoDeIdiomas
{
    public partial class frmRegistroAuxiliar : Form
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        int idGrupo;
        public frmRegistroAuxiliar(int id)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            this.idGrupo = id;
            cargarDatosGrupo(id);
            cargarAlumnosGrupo(id);
            cargarAsistencia();
            btnFinalizar.Visible = true;
        }
        public void cargarDatosGrupo(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_grupo_seleccion", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idGrupo", id));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataRow row2 = dt.Rows[0];
                if (!DBNull.Value.Equals(row2["horaInicio"]))
                {
                    String datime = Convert.ToDateTime(row2["horaInicio"]).ToString("HH:mm tt");
                    row2["horaInicio"] = datime;
                }
                if (!DBNull.Value.Equals(row2["horaFinal"]))
                {
                    String datime = Convert.ToDateTime(row2["horaFinal"]).ToString("HH:mm tt");
                    row2["horaFinal"] = datime;
                }
                if (!DBNull.Value.Equals(row2["fechaInicio"]))
                {
                    String datime = Convert.ToDateTime(row2["fechaInicio"]).ToString("dd/MM/yyyy");
                    row2["fechaInicio"] = datime;
                }
                txtIdioma.Text = row2[1].ToString();
                txtNivel.Text = row2[2].ToString();
                txtCiclo.Text = row2[3].ToString();
                txtSalon.Text = row2[4].ToString();
                txtHoraInicio.Text = row2[5].ToString();
                txtHoraFinal.Text = row2[6].ToString();
                txtInicioCurso.Text = row2[7].ToString();
                

                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                //txtFechaHoy.Text = Convert.ToDateTime(DateTime.Now).ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cargarAlumnosGrupo(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_alumno_grupo_nota", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idGrupo", id));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvwAlumnos.DataSource = dt;
                dgvwAlumnos.Columns["Nombre"].Width = 230;
                dgvwAlumnos.Columns["idAlumnoGrupo"].Visible = false;
                dgvwAlumnos.Columns["Nombre"].ReadOnly = true;
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cargarAsistencia()
        {
            try{
                DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
                cmb.HeaderCell.Value = "ASISTENCIA";
                cmb.Name = "ASISTENCIA";
                SqlCommand cmd = new SqlCommand("listar_tipo_asistencia", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cmb.DataSource = dt;
                cmb.DisplayMember = "nombreAsistencia";
                cmb.ValueMember = "idTipoAsistencia";
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                dgvwAlumnos.Columns.Add(cmb);
                btnFinalizar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public int verificarAsistencia()
        {
            try{
                for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                {
                    dgvwAlumnos.Rows[i].Cells["ASISTENCIA"].Value.ToString();
                }
                return 1;
            }catch(Exception ex){
                MessageBox.Show("Tienes que completar todos los campos de asistencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        private void BTNSAVEREGAUX_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("ESTA FINALIZANDO LA SESION DE HOY CON ESTE GRUPO, NO PODRÁ AGREGAR MÁS NOTAS \n ¿DESEAS CONTINUAR?", "ADVERTENCIA", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void LIMPIAR_ERRORES() {
            ERRORESREGAUX.SetError(txtCriterio, null);
            ERRORESREGAUX.SetError(cmbTipoNota, null);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int x = verificarAsistencia();
            if (x == 1)
            {
                try
                {
                    for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                    {
                        String idAlumnoGrupo = dgvwAlumnos.Rows[i].Cells["idAlumnoGrupo"].Value.ToString();
                        String idTipoAsistencia = dgvwAlumnos.Rows[i].Cells["ASISTENCIA"].Value.ToString();
                        SqlCommand cmd = new SqlCommand("insertar_asistencia", _SqlConnection);
                        if (cmd.Connection.State == ConnectionState.Closed)
                        {
                            cmd.Connection.Open();
                        }
                        cmd.Parameters.Add(new SqlParameter("@idAlumnoGrupo", idAlumnoGrupo));
                        cmd.Parameters.Add(new SqlParameter("@idTipoAsistencia", idTipoAsistencia));
                        cmd.Parameters.Add(new SqlParameter("@fecha", dtpFechaClase.Value));
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                        if (cmd.Connection.State == ConnectionState.Open)
                        {
                            cmd.Connection.Close();
                        }
                    }
                    dgvwAlumnos.Columns["ASISTENCIA"].ReadOnly = true;
                    MessageBox.Show("ASISTENCIA REGISTRADA");
                    validarTipoAsistencia();
                    btnFinalizar.Visible = false;
                    txtCriterio.Enabled = true;
                    cmbTipoNota.Enabled = true;
                    btnTerminarClase.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+"FINASISTENCIA");
                }
            }
        }

        private void cmbTipoNota_TextChanged(object sender, EventArgs e)
        {
            btnAgregarCriterio.Enabled = true;
        }

        private void btnAgregarCriterio_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCriterio.Equals(""))
                {
                    MessageBox.Show("El criterio de la nota no puede estar en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                    columna.Name = cmbTipoNota.Text;
                    columna.HeaderText = cmbTipoNota.Text;
                    dgvwAlumnos.Columns.Add(columna);
                    dgvwAlumnos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    if (cmbTipoNota.Text == "READING")
                    {
                        btnFinReading.Visible = true;
                    }
                    if (cmbTipoNota.Text == "WRITING")
                    {
                        btnFinWriting.Visible = true;
                    }
                    if (cmbTipoNota.Text == "LISTENING")
                    {
                        btnFinListening.Visible = true;
                    }
                    if (cmbTipoNota.Text == "SPEAKING")
                    {
                        btnFinSpeaking.Visible = true;
                    }
                    if (cmbTipoNota.Text == "USE OF ENGLISH")
                    {
                        btnFinUseOfEnglish.Visible = true;
                    }
                    validarFaltas();
                    validarJustificaciones();
                    btnAgregarCriterio.Enabled = false;
                    cmbTipoNota.Enabled = false;
                    txtCriterio.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void validarFaltas()
        {
            try
            {
                for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                {
                    int idTipoAsistencia = (int)dgvwAlumnos.Rows[i].Cells["ASISTENCIA"].Value;
                    if (idTipoAsistencia == 2)
                    {
                        dgvwAlumnos.Rows[i].Cells[3].Value = "0";
                        dgvwAlumnos.Rows[i].Cells[3].ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"FALTA");
            }
        }

        public void validarJustificaciones()
        {
            try
            {
                for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                {
                    int idTipoAsistencia = (int)dgvwAlumnos.Rows[i].Cells["ASISTENCIA"].Value;
                    if (idTipoAsistencia == 3)
                    {
                        dgvwAlumnos.Rows[i].Cells[3].Value = "-1";
                        dgvwAlumnos.Rows[i].Cells[3].ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"JUSTIF");
            }
        }

        public void validarTipoAsistencia()
        {
            try
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[dgvwAlumnos.DataSource];
                cm.SuspendBinding();
                for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                {
                    int idTipoAsistencia = (int)dgvwAlumnos.Rows[i].Cells["ASISTENCIA"].Value;
                    if (idTipoAsistencia == 3)
                    {
                        
                        dgvwAlumnos.Rows[i].Visible=false;
                    }
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message+"VALIDARASISTE");
            }
        }

        public int verificarNota()
        {
            try
            {
                for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                {
                    int nota = Convert.ToInt32(dgvwAlumnos.Rows[i].Cells[3].Value);
                    if (nota > 20 || nota < -1)
                    {
                        MessageBox.Show("La nota debe ser de 0 a 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                }
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "verificarnota");
                return 0;
            }
        }

        public int verificarVacios()
        {
            try
            {
                for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                {
                    String nota = Convert.ToString(dgvwAlumnos.Rows[i].Cells[3].Value);
                    if (nota.Equals(""))
                    {
                        MessageBox.Show("Debe completar todas las notas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                }
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
                return 0;
            }
        }

        public void finNota()
        {
            dgvwAlumnos.Columns.RemoveAt(3);
            cmbTipoNota.Enabled = true;
            txtCriterio.Enabled = true;
            txtCriterio.Text = null;
            cmbTipoNota.SelectedItem = null;
            btnAgregarCriterio.Enabled = false;
        }

        private void btnFinSpeaking_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarVacios() == 1)
                {
                    if (verificarNota() == 1)
                    {
                        for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                        {
                            String idAlumnoGrupo = dgvwAlumnos.Rows[i].Cells["idAlumnoGrupo"].Value.ToString();
                            String nota = dgvwAlumnos.Rows[i].Cells["Speaking"].Value.ToString();
                            SqlCommand cmd = new SqlCommand("insert_speaking", _SqlConnection);
                            if (cmd.Connection.State == ConnectionState.Closed)
                            {
                                cmd.Connection.Open();
                            }
                            cmd.Parameters.Add(new SqlParameter("@idAlumnoGrupo", idAlumnoGrupo));
                            cmd.Parameters.Add(new SqlParameter("@criterio", txtCriterio.Text));
                            cmd.Parameters.Add(new SqlParameter("@nota", nota));
                            cmd.Parameters.Add(new SqlParameter("@fecha", dtpFechaClase.Value));
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            if (cmd.Connection.State == ConnectionState.Open)
                            {
                                cmd.Connection.Close();
                            }
                        }
                        MessageBox.Show("NOTAS DE SPEAKING REGISTRADAS");
                        btnFinSpeaking.Visible = false;
                        finNota();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinUseOfEnglish_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarVacios() == 1)
                {
                    if (verificarNota() == 1)
                    {
                        for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                        {
                            String idAlumnoGrupo = dgvwAlumnos.Rows[i].Cells["idAlumnoGrupo"].Value.ToString();
                            String nota = dgvwAlumnos.Rows[i].Cells["Use of english"].Value.ToString();
                            SqlCommand cmd = new SqlCommand("insert_use_of_english", _SqlConnection);
                            if (cmd.Connection.State == ConnectionState.Closed)
                            {
                                cmd.Connection.Open();
                            }
                            cmd.Parameters.Add(new SqlParameter("@idAlumnoGrupo", idAlumnoGrupo));
                            cmd.Parameters.Add(new SqlParameter("@criterio", txtCriterio.Text));
                            cmd.Parameters.Add(new SqlParameter("@nota", nota));
                            cmd.Parameters.Add(new SqlParameter("@fecha", dtpFechaClase.Value));
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            if (cmd.Connection.State == ConnectionState.Open)
                            {
                                cmd.Connection.Close();
                            }
                        }
                        MessageBox.Show("NOTAS DE USE OF ENGLISH REGISTRADAS");
                        btnFinUseOfEnglish.Visible = false;
                        finNota();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinListening_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarVacios() == 1)
                {
                    if (verificarNota() == 1)
                    {
                        for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                        {
                            String idAlumnoGrupo = dgvwAlumnos.Rows[i].Cells["idAlumnoGrupo"].Value.ToString();
                            String nota = dgvwAlumnos.Rows[i].Cells["Listening"].Value.ToString();
                            SqlCommand cmd = new SqlCommand("insert_listening", _SqlConnection);
                            if (cmd.Connection.State == ConnectionState.Closed)
                            {
                                cmd.Connection.Open();
                            }
                            cmd.Parameters.Add(new SqlParameter("@idAlumnoGrupo", idAlumnoGrupo));
                            cmd.Parameters.Add(new SqlParameter("@criterio", txtCriterio.Text));
                            cmd.Parameters.Add(new SqlParameter("@nota", nota));
                            cmd.Parameters.Add(new SqlParameter("@fecha", dtpFechaClase.Value));
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            if (cmd.Connection.State == ConnectionState.Open)
                            {
                                cmd.Connection.Close();
                            }
                        }
                        MessageBox.Show("NOTAS DE LISTENING REGISTRADAS");
                        btnFinListening.Visible = false;
                        finNota();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinWriting_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarVacios() == 1)
                {
                    if (verificarNota() == 1)
                    {
                        for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                        {
                            String idAlumnoGrupo = dgvwAlumnos.Rows[i].Cells["idAlumnoGrupo"].Value.ToString();
                            String nota = dgvwAlumnos.Rows[i].Cells["Writing"].Value.ToString();
                            SqlCommand cmd = new SqlCommand("insert_writing", _SqlConnection);
                            if (cmd.Connection.State == ConnectionState.Closed)
                            {
                                cmd.Connection.Open();
                            }
                            cmd.Parameters.Add(new SqlParameter("@idAlumnoGrupo", idAlumnoGrupo));
                            cmd.Parameters.Add(new SqlParameter("@criterio", txtCriterio.Text));
                            cmd.Parameters.Add(new SqlParameter("@nota", nota));
                            cmd.Parameters.Add(new SqlParameter("@fecha", dtpFechaClase.Value));
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            if (cmd.Connection.State == ConnectionState.Open)
                            {
                                cmd.Connection.Close();
                            }
                        }
                        MessageBox.Show("NOTAS DE WRITING REGISTRADAS");
                        btnFinWriting.Visible = false;
                        finNota();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinReading_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarVacios() == 1)
                {
                    if (verificarNota() == 1)
                    {
                        for (int i = 0; i < dgvwAlumnos.RowCount; i++)
                        {
                            String idAlumnoGrupo = dgvwAlumnos.Rows[i].Cells["idAlumnoGrupo"].Value.ToString();
                            String nota = dgvwAlumnos.Rows[i].Cells["Reading"].Value.ToString();
                            SqlCommand cmd = new SqlCommand("insert_reading", _SqlConnection);
                            if (cmd.Connection.State == ConnectionState.Closed)
                            {
                                cmd.Connection.Open();
                            }
                            cmd.Parameters.Add(new SqlParameter("@idAlumnoGrupo", idAlumnoGrupo));
                            cmd.Parameters.Add(new SqlParameter("@criterio", txtCriterio.Text));
                            cmd.Parameters.Add(new SqlParameter("@nota", nota));
                            cmd.Parameters.Add(new SqlParameter("@fecha", dtpFechaClase.Value));
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.ExecuteNonQuery();
                            if (cmd.Connection.State == ConnectionState.Open)
                            {
                                cmd.Connection.Close();
                            }
                        }
                        MessageBox.Show("NOTAS DE READING REGISTRADAS");
                        btnFinReading.Visible = false;
                        finNota();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
