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
    public partial class frmConsultarAlumno : Form
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();

        DataSet resultados = new DataSet();
        public frmConsultarAlumno(String id)
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscarPorDNI", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@dni", txtDNI.Text.Trim()));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDNI.DataSource = dt;
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

        private void frmConsultarAlumno_Load(object sender, EventArgs e)
        {
            txtDNI.Focus();

        }

        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscarAlumnoApellido", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@txt", txtApellido.Text.Trim()));
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                dt.Clear();

                da.Fill(dt);


                dataGridViewApellido.DataSource = dt;
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

        private void dataGridViewDNI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewDNI.RowCount-1)
            {
                try
                {
                    DataTable dt = new DataTable();
                    DataGridViewRow row = this.dataGridViewDNI.Rows[e.RowIndex];
                    String dni = row.Cells[3].Value.ToString();
                    String tipo = row.Cells[4].Value.ToString();
                    _SqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("buscarTodo", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@dni", dni));
                    cmd.Parameters.Add(new SqlParameter("@tipoalu", tipo));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    DataGridViewRow rowo = dataGridView1.Rows[0];

                    TXTPATERNOALU.Text = rowo.Cells[0].Value.ToString();
                    TXTMATERNOALU.Text = rowo.Cells[1].Value.ToString();
                    TXTNOMBRESALU.Text = rowo.Cells[2].Value.ToString();
                    TXTDNIALU.Text = rowo.Cells[3].Value.ToString();
                    TXTSEXALU.Text = rowo.Cells[4].Value.ToString();
                    if (!DBNull.Value.Equals(rowo.Cells[5].Value))
                    {
                        TXTFECHANACIALU.Text = Convert.ToDateTime(rowo.Cells[5].Value).ToString("dd/MM/yy");
                    }
                        
                    TXTEDADALU.Text = rowo.Cells[6].Value.ToString();
                    FOTOALUMNO.Image = null;
                    if (!DBNull.Value.Equals(rowo.Cells[7].Value))
                    {
                        byte[] img = (byte[])(dt.Rows[0][7]);
                        if (img == null)
                        {
                            FOTOALUMNO.Image = null;
                        }
                        else
                        {
                            FOTOALUMNO.SizeMode = PictureBoxSizeMode.StretchImage;
                            MemoryStream ms = new MemoryStream(img);
                            FOTOALUMNO.Image = Image.FromStream(ms);
                        }
                    }


                    TXTCORREOALU.Text = rowo.Cells[8].Value.ToString();
                    TXTDEPALU.Text = rowo.Cells[9].Value.ToString();
                    TXTPROVINCIAALU.Text = rowo.Cells[10].Value.ToString();
                    TXTDISTRITOALU.Text = rowo.Cells[11].Value.ToString();
                    TXTPROCEDENCIAALU.Text = rowo.Cells[12].Value.ToString();
                    TXTDIRECCIONALU.Text = rowo.Cells[13].Value.ToString();
                    TXTGRADOINSTRUCCIONALU.Text = rowo.Cells[14].Value.ToString();
                    TXTCELUALU.Text = rowo.Cells[15].Value.ToString();
                    TXTTLFALU.Text = rowo.Cells[16].Value.ToString();
                    TXTTIPOALU.Text = rowo.Cells[17].Value.ToString();
                    if (rowo.Cells[17].Value.ToString() == "FAUSTINIANO")
                    {
                        PANELPARTICULAR.Visible = false;
                        PANELFAUSTINO.Visible = true;
                        TXTFACULTADALU.Visible = true;
                        TXTESCUELAALU.Visible = true;
                        TXTFACULTADALU.Text = rowo.Cells[18].Value.ToString();
                        TXTESCUELAALU.Text = rowo.Cells[19].Value.ToString();
                    }
                    else if (rowo.Cells[17].Value.ToString() == "PARTICULAR")
                    {
                        PANELFAUSTINO.Visible = false;
                        PANELPARTICULAR.Visible = true;
                        LBLCENTROESTUDIOS.Visible = true;
                        
                        if(rowo.Cells.Count >= 19)
                        {
                            TXTCOLEUNIALU.Visible = true;
                            LBLCENTROESTUDIOS.Text = rowo.Cells[18].Value.ToString();
                            if (LBLCENTROESTUDIOS.Text == "COLEGIO")
                            {
                                TXTCOLEUNIALU.Text = rowo.Cells[19].Value.ToString();
                            }
                            else if (LBLCENTROESTUDIOS.Text == "UNIVERSIDAD")
                            {
                                TXTCOLEUNIALU.Text = rowo.Cells[19].Value.ToString();
                            }
                        }
                        else
                        {
                            LBLCENTROESTUDIOS.Text = "NINGUNO";
                            txtColeUni.Visible = false;
                        }
                    }
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

        }

        private void dataGridViewApellido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewApellido.RowCount - 1)
            {
                try
                {
                    DataTable dt = new DataTable();
                    DataGridViewRow row = this.dataGridViewApellido.Rows[e.RowIndex];
                    String dni = row.Cells[3].Value.ToString();
                    String tipo = row.Cells[4].Value.ToString();
                    _SqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("buscarTodo", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@dni", dni));
                    cmd.Parameters.Add(new SqlParameter("@tipoalu", tipo));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    DataGridViewRow rowo = dataGridView1.Rows[0];

                    txtApePaterno.Text = rowo.Cells[0].Value.ToString();
                    txtApeMaterno.Text = rowo.Cells[1].Value.ToString();
                    txtNombres.Text = rowo.Cells[2].Value.ToString();
                    txtDni2.Text = rowo.Cells[3].Value.ToString();
                    txtSexo.Text = rowo.Cells[4].Value.ToString();
                    if (!DBNull.Value.Equals(rowo.Cells[5].Value))
                    {
                        txtFechaNaci.Text = Convert.ToDateTime(rowo.Cells[5].Value).ToString("dd/MM/yy");
                    }
                    txtEdad.Text = rowo.Cells[6].Value.ToString();
                    fotoimagen.Image = null;

                    if (!DBNull.Value.Equals(rowo.Cells[7].Value))
                    {
                        byte[] img = (byte[])(dt.Rows[0][7]);
                        if (img == null)
                        {
                            fotoimagen.Image = null;
                        }
                        else
                        {
                            fotoimagen.SizeMode = PictureBoxSizeMode.StretchImage;
                            MemoryStream ms = new MemoryStream(img);
                            fotoimagen.Image = Image.FromStream(ms);
                        }
                    }


                    txtCorreo.Text = rowo.Cells[8].Value.ToString();
                    txtDepartamento.Text = rowo.Cells[9].Value.ToString();
                    txtProvincia.Text = rowo.Cells[10].Value.ToString();
                    txtDistrito.Text = rowo.Cells[11].Value.ToString();
                    txtProcedencia.Text = rowo.Cells[12].Value.ToString();
                    txtDireccion.Text = rowo.Cells[13].Value.ToString();
                    txtGradoInstru.Text = rowo.Cells[14].Value.ToString();
                    txtCelular.Text = rowo.Cells[15].Value.ToString();
                    txtTelefono.Text = rowo.Cells[16].Value.ToString();
                    txtTipoAlu2.Text = rowo.Cells[17].Value.ToString();
                    if (rowo.Cells[17].Value.ToString() == "FAUSTINIANO")
                    {
                        panel1.Visible = false;
                        panel2.Visible = true;
                        txtFacultad.Visible = true;
                        txtEscuela.Visible = true;
                        txtFacultad.Text = rowo.Cells[18].Value.ToString();
                        txtEscuela.Text = rowo.Cells[19].Value.ToString();
                    }
                    else if (rowo.Cells[17].Value.ToString() == "PARTICULAR")
                    {
                        panel2.Visible = false;
                        panel1.Visible = true;
                        lblColeUni.Visible = true;
                        if (rowo.Cells.Count >= 19)
                        {
                            txtColeUni.Visible = true;
                            lblColeUni.Text = rowo.Cells[18].Value.ToString();
                            if (lblColeUni.Text == "COLEGIO")
                            {
                                txtColeUni.Text = rowo.Cells[19].Value.ToString();
                            }
                            else if (lblColeUni.Text == "UNIVERSIDAD")
                            {
                                txtColeUni.Text = rowo.Cells[19].Value.ToString();
                            }
                        }
                        else
                        {                        
                            lblColeUni.Text = "NINGUNO";
                            txtColeUni.Visible = false;
                        }
                    }
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

        }


    

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
