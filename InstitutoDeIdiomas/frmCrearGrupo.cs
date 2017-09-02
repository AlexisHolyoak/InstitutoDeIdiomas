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
    public partial class frmCrearGrupo : Form
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        public frmCrearGrupo()
        {
            
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            listaIdioma();
            listaNivel();
            listaSalon();
            listarProfesor();
            listarDia();
            dtmHoraInicio.Format = DateTimePickerFormat.Custom;
            dtmHoraFinal.Format = DateTimePickerFormat.Custom;
            dtmHoraInicio.CustomFormat = "HH:mm" ;
            dtmHoraFinal.CustomFormat = "HH:mm";
        }

        public void listaIdioma()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("listar_idioma", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cmbIdioma.DisplayMember = "nombreIdioma";
                cmbIdioma.DataSource = dt;
                cmbIdioma.ValueMember = "idIdioma";
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

        public void listaNivel()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("listar_nivel", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cmbNivel.DisplayMember = "nombreNivel";
                cmbNivel.DataSource = dt;
                cmbNivel.ValueMember = "idNivel";
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

        public void listaSalon()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("listar_salon", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cmbSalon.DisplayMember = "nombreSalon";
                cmbSalon.DataSource = dt;
                cmbSalon.ValueMember = "idSalon";
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

        public void listarProfesor()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_profesor", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cmbProfesor.DisplayMember = "NomProf";
                cmbProfesor.DataSource = dt;
                cmbProfesor.ValueMember = "idtrabajador";
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

        public void listarDia()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("listar_dia", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                clbHorario.DisplayMember = "idDia";
                clbHorario.DataSource = dt;
                clbHorario.ValueMember = "nombreDia";

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

        public int ultimoGrupo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select_last_group", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow row = dt.Rows[0];
                int id = (int)row["idGrupo"];
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }

        public void GuardarDias()
        {
            try
            {
                foreach (DataRowView drv in clbHorario.CheckedItems)
                {
                    int dia = (int)drv["idDia"];
                    int ultimGrupo = ultimoGrupo();
                    SqlCommand cmd = new SqlCommand("insert_horario", _SqlConnection);
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    cmd.Parameters.Add(new SqlParameter("@idGrupo", ultimGrupo));
                    cmd.Parameters.Add(new SqlParameter("@idDia", dia));
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            try
            {

                int idioma = (int)((DataRowView)cmbIdioma.SelectedItem)["idIdioma"];
                int nivel = (int)((DataRowView)cmbNivel.SelectedItem)["idNivel"];
                int salon = (int)((DataRowView)cmbSalon.SelectedItem)["idSalon"];
                int profesor = (int)((DataRowView)cmbProfesor.SelectedItem)["idtrabajador"];
                
                SqlCommand cmd = new SqlCommand("insert_grupo", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@idtrabajador", profesor));
                cmd.Parameters.Add(new SqlParameter("@horaInicio", dtmHoraInicio.Value));
                cmd.Parameters.Add(new SqlParameter("@horaFinal", dtmHoraFinal.Value));
                cmd.Parameters.Add(new SqlParameter("@fechaInicio", dtFechaInicio.Value));
                cmd.Parameters.Add(new SqlParameter("@fechaFinal", dtFechaFinal.Value));
                cmd.Parameters.Add(new SqlParameter("@idIdioma", idioma));
                cmd.Parameters.Add(new SqlParameter("@idNivel", nivel));
                cmd.Parameters.Add(new SqlParameter("@ciclo", numCiclo.Value));
                cmd.Parameters.Add(new SqlParameter("@idSalon", salon));
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                GuardarDias();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                MessageBox.Show("GRUPO CREADO SATISFACTORIAMENTE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
