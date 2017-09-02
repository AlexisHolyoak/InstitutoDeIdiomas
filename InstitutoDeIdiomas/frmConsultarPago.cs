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
    public partial class frmConsultarPago : Form
    {
        public static SqlConnection _SqlConnection = new SqlConnection();
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public frmConsultarPago()
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            IMGALUMNCONS.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void BTNBUSCARPORDNI_Click(object sender, EventArgs e)
        {
            try
            {
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscarPorDNI", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@dni", TXTCONSDNI.Text.Trim()));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GRIDVIEWALUMDNI.DataSource = dt;
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
        private void TXTBUSCARPORNOMBRE_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscarAlumnoApellido", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@txt", TXTCONNOMBRE.Text.Trim()));

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                dt.Clear();

                da.Fill(dt);


                GRIDVIEWALUMNNOM.DataSource = dt;
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
        //SE ACTIVA CUANDO LA BUSQUEDA SE REALIZA POR NOMBRES Y APELLIDOS DEVUELVE LA IMAGEN DEL ALUMNO
        //Params Row from Grid
        //Returns Imagen en Bytes
        private void GRIDVIEWALUMNNOM_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.RowIndex < GRIDVIEWALUMNNOM.RowCount - 1) {
                DataGridViewRow row = this.GRIDVIEWALUMNNOM.Rows[e.RowIndex];
                String dni = row.Cells[3].Value.ToString();
                try {
                    DataTable dt = new DataTable();                    
                    SqlCommand comando = new SqlCommand("buscar_foto", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }                    
                    comando.Parameters.Add(new SqlParameter("@dni", dni));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    byte[] img = (byte[])(dt.Rows[0][0]);
                    if (img == null)
                    {
                        IMGALUMNCONS.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        IMGALUMNCONS.Image = Image.FromStream(ms);
                    }
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("listar_pagos", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    cmd.Parameters.Add(new SqlParameter("@dni", dni));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    GRIDVIEWPAGOSCONS.DataSource = dt;

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
        }
        private void GRIDVIEWALUMNDNI_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.RowIndex < GRIDVIEWALUMDNI.RowCount - 1)
            {
                
                DataGridViewRow row = this.GRIDVIEWALUMDNI.Rows[e.RowIndex];
                String dni = row.Cells[3].Value.ToString();
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand comando = new SqlCommand("buscar_foto", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@dni", dni));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);                    
                    byte[] img = (byte[])(dt.Rows[0][0]);
                    if (img == null)
                    {
                        IMGALUMNCONS.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        IMGALUMNCONS.Image = Image.FromStream(ms);
                    }
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
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand("listar_pagos", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    cmd.Parameters.Add(new SqlParameter("@dni", dni));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    GRIDVIEWPAGOSCONS.DataSource = dt;
                    
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message); 
                }
            }
        }
        private void GRIDVIEWPAGOSCONS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < GRIDVIEWPAGOSCONS.RowCount - 1) {
                DataGridViewRow row = this.GRIDVIEWPAGOSCONS.Rows[e.RowIndex];
                String numrecibo = row.Cells[0].Value.ToString();
                int idtrabajador = Convert.ToInt32(row.Cells[2].Value.ToString());
                try {
                    DataTable dt = new DataTable();
                    SqlCommand comando = new SqlCommand("mostrar_detalle_pagos", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@numrecibo", numrecibo));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    GRIDVIEWOTROSPAGOS.DataSource = dt;
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand comando = new SqlCommand("mostrar_trabajador", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@idtrabajador", idtrabajador));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    label9.Text = dt.Rows[0][0].ToString();
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
                    DataTable dt = new DataTable();
                    SqlCommand comando = new SqlCommand("mostrar_detalle_matricula", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }
                    comando.Parameters.Add(new SqlParameter("@numrecibo", numrecibo));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    GRIDVIEWMATRICULA.DataSource = dt;
                    if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
