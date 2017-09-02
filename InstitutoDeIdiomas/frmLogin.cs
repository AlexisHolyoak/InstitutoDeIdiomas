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
    public partial class frmLogin : Form
    {
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        
        public frmLogin()
        {
            InitializeComponent();
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
        }
      
        private void BTNREGISTRAR_Click(object sender, EventArgs e)
        {
            frmRegistrar forma = new frmRegistrar();
            forma.Show();
        }

        public void login()
        {
            BORRAR_MENSAJE_ERROR();
            if (VALIDAR_NO_VACIOS())
            {
                //HANDLE LOGIN EVENT
                try
                {
                    _SqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("iniciar_sesion", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@usuario", TXTUSUARIO.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@password", TXTPASSWORD.Text.Trim()));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        this.Hide();
                        if (dt.Rows[0][3].ToString() == "ADMINISTRADOR")
                        {
                            String nombre = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1] + " " + dt.Rows[0][2];
                            String id = dt.Rows[0][4].ToString();
                            new frmMainMenu(id, nombre).Show();
                            this.Hide();
                        }
                        if (dt.Rows[0][3].ToString() == "SECRETARIO")
                        {
                            String nombre = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1] + " " + dt.Rows[0][2];
                            String id = dt.Rows[0][4].ToString();
                            new frmMainMenu(id, nombre).Show();
                            this.Hide();
                        }
                        if (dt.Rows[0][3].ToString() == "PROFESOR")
                        {
                            String nombre = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1] + " " + dt.Rows[0][2];
                            String id = dt.Rows[0][4].ToString();
                            new frmMainMenuDocentes(id).Show();
                            this.Hide();
                        }
                    }
                    else {
                        MessageBox.Show("El usuario no existe");
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
                //AFTER LOGIN CLEAN TEXT
                LIMPIAR_DATA_LOGIN();
            }
        }

        private void BTNLOGIN_Click(object sender, EventArgs e)
        {
            login();
            
        }
        private bool VALIDAR_NO_VACIOS()
        {
            bool ok = true;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox txt = ctrl as TextBox;
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        ok = false;
                        ERROREMPTYTXTLOGIN.SetError(txt, "INGRESA DATO");
                    }
                }                
            }
            return ok;
        }
        private void BORRAR_MENSAJE_ERROR()
        {
            foreach (Control cr in this.Controls)
            {
                ERROREMPTYTXTLOGIN.SetError(cr, null);
            }
        }
        private void LIMPIAR_DATA_LOGIN()
        {
            foreach (Control cr in this.Controls)
            {
                if (cr is TextBox)
                {
                    TextBox txt = cr as TextBox;
                    txt.Text = null;
                }                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                      
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
                this.Hide();
            }
        }
    }
}
