using InstitutoDeIdiomas.ReportForms;
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
    public partial class frmAsignarAlumnosToGroup : Form
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        String codigoGrupo, codigoAlumno;
        int id;
        DataTable dtListaAlumnos = new DataTable();
        public frmAsignarAlumnosToGroup(int id)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            cargarDatosGrupo(id);
            cargarAlumnoGrupo(id);
            this.id = id;
        }
        public void cargarAlumnoGrupo(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_alumno_grupo", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idGrupo", id));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dtListaAlumnos = dt.Copy();
                dataGridViewAlumnoGrupo.DataSource = dt;
                dataGridViewAlumnoGrupo.Columns["NOMBRE"].Width =153;
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ "cargarAlumnoGrupo");
            }
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
                txtIdioma.Text = row2[1].ToString();
                txtNivel.Text = row2[2].ToString();
                txtCiclo.Text = row2[3].ToString();
                txtSalon.Text = row2[4].ToString();
                txtHorario.Text = row2[5].ToString();
                txtHorario2.Text = row2[6].ToString();
                txtDocente.Text = row2[8].ToString();
                codigoGrupo = row2["idGrupo"].ToString();

                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                txtBuscarDni.Enabled = true;
                txtBuscarApellido.Enabled = true;
                dataGridViewAlumno.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public int verificarAlumnoGrupo(String codAlu, String codGrupo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("verificar_alumno_grupo", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idalumno", codigoAlumno));
                cmd.Parameters.Add(new SqlParameter("@idgrupo", codigoGrupo));
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                if (dt.Rows.Count == 0)
                {
                    return 0;
                }
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void txtBuscarDni_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String d = txtBuscarDni.Text;
                if (d.Equals(""))
                {
                    d = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
                }
                SqlCommand cmd = new SqlCommand("buscar_alumno_grupo_dni", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@dni", d));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewAlumno.DataSource = dt;

                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                txtBuscarApellido.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int v = verificarAlumnoGrupo(codigoAlumno, codigoGrupo);
                if (v == 0)
                {
                    SqlCommand cmd = new SqlCommand("insert_alumno_grupo", _SqlConnection);
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    cmd.Parameters.Add(new SqlParameter("@idalumno", codigoAlumno));
                    cmd.Parameters.Add(new SqlParameter("@idgrupo", codigoGrupo));
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    MessageBox.Show("EL ALUMNO FUE ASIGNADO CORRECTAMENTE");
                    cargarAlumnoGrupo(id);
                }
                else if (v == 1)
                {
                    MessageBox.Show("EL ALUMNO YA PERTENECE A ESTE GRUPO");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewAlumno.Rows[e.RowIndex];
                //String idpersona = row.Cells["idpersona"].Value.ToString();
                //SqlCommand cmd = new SqlCommand("obtener_idalumno", _SqlConnection);
                //if (cmd.Connection.State == ConnectionState.Closed)
                //{
                //    cmd.Connection.Open();
                //}
                //cmd.Parameters.Add(new SqlParameter("@idpersona", idpersona));
                //cmd.CommandType = CommandType.StoredProcedure;
                //DataTable dt = new DataTable();
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //da.Fill(dt);
                codigoAlumno= row.Cells["CODIGO ALUMNO"].Value.ToString();
                //if (cmd.Connection.State == ConnectionState.Open)
                //{
                //    cmd.Connection.Close();
                //}
                btnAgregar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRelacionAlumnos_Click(object sender, EventArgs e)
        {
            dtListaAlumnos.Columns[0].ColumnName = "codigo";
            dtListaAlumnos.Columns[1].ColumnName = "nombre";
            dtListaAlumnos.Columns.Add("numero");
            for (int i = 0; i < dtListaAlumnos.Rows.Count; i++)
            {
                dtListaAlumnos.Rows[i]["numero"] = i + 1 + "";
            }
            using (frmRptRelacionAlumnos frm = new frmRptRelacionAlumnos(dtListaAlumnos, txtIdioma.Text, txtNivel.Text, txtCiclo.Text,
                txtDocente.Text, txtSalon.Text, txtHorario.Text, txtHorario2.Text))
            {
                frm.ShowDialog();
            }
        }

        private void txtBuscarApellido_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String d = txtBuscarApellido.Text;
                if (d.Equals(""))
                {
                    d = "wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww";
                }
                SqlCommand cmd = new SqlCommand("buscar_alumno_grupo_apellido", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@apellido", d));
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewAlumno.DataSource = dt;
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                txtBuscarDni.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
