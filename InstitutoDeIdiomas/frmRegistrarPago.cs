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
    public partial class frmRegistrarPago : Form
    {
        String usuarioQueRegistro;
        MsSqlConnection configurarConexion = new MsSqlConnection();
        private string modalidadMatricula=null;
        private string idioma=null;
        private string nivel=null;
        private string ciclo=null;     
        public static SqlConnection _SqlConnection = new SqlConnection();
        public frmRegistrarPago(String id)
        {
            InitializeComponent();
            usuarioQueRegistro = id;
            TXTUSUENCARGADODEPAGO.Text = usuarioQueRegistro;
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            FOTOALUAPAGAR.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void BTNCARGARDNI_Click(object sender, EventArgs e)
        {
            DESACTIVAR_CASILLAS_DE_PAGO();
            BORRAR_MENSAJE_ERROR_DNI();
            if (VERIFICAR_INGRESO_DNI()) {
                try {
                    SqlCommand cmd = new SqlCommand("small_buscar_pordni", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cmd.Connection.State == ConnectionState.Closed) {
                        cmd.Connection.Open();                       
                    }
                    cmd.Parameters.Add(new SqlParameter("@dni", TXTDNIALUAPAGAR.Text.Trim()));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        TXTALUMNOAPAGAR.Text = "Nombre: " + dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
                        LBLEDADALUAPAGAR.Text = "Edad: "+ dt.Rows[0][3].ToString();
                        //ALGORITMMO PARA LEER UNA IMAGEN EN BYTE 
                        byte[] img = (byte[])(dt.Rows[0][4]);
                        if (img == null)
                        {
                            FOTOALUAPAGAR.Image = null;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            FOTOALUAPAGAR.Image = Image.FromStream(ms);
                        }
                        LBLDNIALUAPAGAR.Text = dt.Rows[0][5].ToString();
                        LBLTIPOALUMNO.Text = dt.Rows[0][6].ToString();
                        ACTIVAR_CASILLAS_DE_PAGO();
                    }
                    else {
                        MessageBox.Show("Alumno no encontrado.");
                        DESACTIVAR_CASILLAS_DE_PAGO();
                    }
                    if (cmd.Connection.State == ConnectionState.Open) {
                        cmd.Connection.Close();
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private bool VERIFICAR_INGRESO_DNI()
        {
            bool ok = true;
            if (TXTDNIALUAPAGAR.Text.Trim().Length != 8) {
                ok = false;
                DNITXTVACIO.SetError(TXTDNIALUAPAGAR, "EL DNI TIENE 8 DIGITOS");
            }
            if (TXTDNIALUAPAGAR.Text.Equals(null)) {
                ok = false;
                DNITXTVACIO.SetError(TXTDNIALUAPAGAR, "INGRESE UN DNI PARA EMPEZAR");
            }

                return ok;
        }
        private void BORRAR_MENSAJE_ERROR_DNI()
        {            
               DNITXTVACIO.SetError(TXTDNIALUAPAGAR, null);            
        }
        private void CBPAGARMATRICULA_CheckedChanged(object sender, EventArgs e)
        {
            if (CBPAGARMATRICULA.Checked == true) {
                frmPagarMatricula pagar = new frmPagarMatricula(this);
                pagar.ShowDialog();
            }
            if (CBPAGARMATRICULA.Checked == false) {
                modalidadMatricula = null;
                idioma = null;
                nivel = null;
                ciclo = null;           
            }
            CALCULARMONTO();
        }
        public void CARGARDATOS(string mod, string idio,string niv,string cic) {
            if (CBPAGARMATRICULA.CheckState == CheckState.Checked) {
                modalidadMatricula = mod;
                idioma = idio;
                nivel = niv;
                ciclo = cic;
            }
        }
        private void BTNGUARDARPAGO_Click(object sender, EventArgs e)
        {
            LIMPIAR_ERROR_DATOS_PAGO();
            if (VERIFICA_DATOS_PAGO()) {                                  
            try {
                SqlCommand cmd = new SqlCommand("insert_pago", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.Parameters.Add(new SqlParameter("@dni", LBLDNIALUAPAGAR.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@monto", TXTMONTOAPAGAR.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@recibo", TXTNUMRECIBO.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@fecha", TIMEPICKERFECHRECIBO.Value));
                cmd.Parameters.Add(new SqlParameter("@idusuario", usuarioQueRegistro));
                if (CBPAGARCARNET.CheckState == CheckState.Checked)
                {
                    cmd.Parameters.Add(new SqlParameter("@carnet", "CARNET"));
                }
                if (CBPAGARMENSUALIDAD.CheckState == CheckState.Checked)
                {
                    cmd.Parameters.Add(new SqlParameter("@mensualidad", "MENSUALIDAD"));
                }
                if (CBPAGARMATRICULA.CheckState == CheckState.Checked)
                {
                    cmd.Parameters.Add(new SqlParameter("@matricula", "MATRICULA"));
                    cmd.Parameters.Add(new SqlParameter("@modalidad", modalidadMatricula));
                    cmd.Parameters.Add(new SqlParameter("@nivel", nivel));
                    cmd.Parameters.Add(new SqlParameter("@ciclo", ciclo));
                    cmd.Parameters.Add(new SqlParameter("@idioma", idioma));
                }
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                DESACTIVAR_CASILLAS_DE_PAGO();
                MessageBox.Show("PAGO REALIZADO CON EXITO");
            } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
            }
            }
            string param1 = null;
            string param2 = null;
            string param3 = null;
            string param4 = null;
            if (CBPAGARMATRICULA.Checked == true) {
                param1 = modalidadMatricula;
                param2 = nivel;
                param3 = idioma;
                param4 = nivel;
            }           
            

        }
        private bool VERIFICA_DATOS_PAGO() {
            bool ok = true;
            if (TXTNUMRECIBO.Text == null) {
                ok = false;
                ERRORDEPAGOS.SetError(TXTNUMRECIBO, "INGRESA EL NUMERO DE RECIBO");

            }
            if (TXTNUMRECIBO.Text != null) {
                try {
                    SqlCommand cmd = new SqlCommand("verificar_recibo", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    cmd.Parameters.Add(new SqlParameter("@numrecibo", TXTNUMRECIBO.Text));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            ok = false;
                            ERRORDEPAGOS.SetError(TXTNUMRECIBO, "ESTE NUMERO DE RECIBO YA HA SIDO REGISTRADO!!!");
                        }
                    }
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            return ok;
        }
        private void LIMPIAR_ERROR_DATOS_PAGO() {
            ERRORDEPAGOS.SetError(TXTNUMRECIBO, null);
        }       
        //METODO PARA CALCULAR EL MONTO TOTAL IDENTIFICA TIPOS DE ALUMNOS  PARTICULAR O FAUSTINIANO    
        private void CALCULARMONTO()
        {
            int monto=0;
            int matricula=0;
            int carnet = 0;
            int mensualidad = 0;
            string tipo = null;
            int contenido = Convert.ToInt32(TXTMONTOAPAGAR.Text.ToString());
            if (CBPAGARMATRICULA.CheckState==CheckState.Checked) {
                matricula = 20;             
            }
            if (CBPAGARMATRICULA.CheckState == CheckState.Unchecked) {
                matricula = 0;
            }
            if (CBPAGARCARNET.CheckState == CheckState.Checked) {
                carnet = 10;
            }
            if (CBPAGARCARNET.CheckState == CheckState.Unchecked)
            {
                carnet = 0;
            }
            if (CBPAGARMENSUALIDAD.CheckState == CheckState.Checked) {
                if (CBPAGARMATRICULA.CheckState == CheckState.Checked) {
                    if (nivel != null)
                    {
                        if (LBLTIPOALUMNO.Text == "FAUSTINIANO")
                        {
                            if (nivel == "BASICO")
                            {
                                mensualidad = 80;
                            }
                            if (nivel == "INTERMEDIO")
                            {
                                mensualidad = 90;
                            }
                            if (nivel == "AVANZADO")
                            {
                                mensualidad = 100;
                            }
                        }
                        if (LBLTIPOALUMNO.Text == "PARTICULAR")
                        {
                            if (nivel == "BASICO")
                            {
                                mensualidad = 100;
                            }
                            if (nivel == "INTERMEDIO")
                            {
                                mensualidad = 110;
                            }
                            if (nivel == "AVANZADO")
                            {
                                mensualidad = 120;
                            }
                        }
                    }
                }
                else { 
                try {
                    SqlCommand cmd = new SqlCommand("buscar_nivel_tipo",_SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cmd.Connection.State == ConnectionState.Closed) {
                        cmd.Connection.Open();
                    }
                    cmd.Parameters.Add(new SqlParameter("@dni", LBLDNIALUAPAGAR.Text.ToString()));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        if (dt.Rows[0][1].ToString() == "FAUSTINIANO")
                        {
                            if (dt.Rows[0][0].ToString() == "BASICO") {
                                mensualidad = 80;
                            }
                            if (dt.Rows[0][0].ToString() == "INTERMEDIO") {
                                mensualidad = 90;
                            }
                            if (dt.Rows[0][0].ToString() == "AVANZADO") {
                                mensualidad = 100;
                            }
                        }
                        if (dt.Rows[0][1 ].ToString() == "PARTICULAR")
                        {
                            if (dt.Rows[0][0].ToString() == "BASICO")
                            {
                                mensualidad = 100;
                            }
                            if (dt.Rows[0][0].ToString() == "INTERMEDIO")
                            {
                                mensualidad = 110;
                            }
                            if (dt.Rows[0][0].ToString() == "AVANZADO")
                            {
                                mensualidad = 120;
                            }
                        }
                    }
                    else {
                            MessageBox.Show("Algo sucedio, verifica que has matriculado al alumno");  
                    }
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }                    
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                }
            }
            if (CBPAGARMENSUALIDAD.CheckState == CheckState.Unchecked) {
                mensualidad = 0;
            }
            monto = matricula + carnet+mensualidad;
            TXTMONTOAPAGAR.Text = Convert.ToString(monto);
        }
        //ACTIVA Y DESACTIVA CASILLAS DE PAGO
        private void ACTIVAR_CASILLAS_DE_PAGO() {
            CBPAGARMATRICULA.Enabled = true;
            CBPAGARCARNET.Enabled = true;
            CBPAGARMENSUALIDAD.Enabled = true;                    
            BTNGUARDARPAGO.Enabled = true;
            BTNCARGARDNI.Text = "BUSCAR OTRO D.N.I.";
            label7.Visible = true;
            label8.Visible = true;
            LBLTIPOALUMNO.Visible = true;
        }
        private void DESACTIVAR_CASILLAS_DE_PAGO()
        {
            CBPAGARMATRICULA.Enabled = false;
            CBPAGARCARNET.Enabled = false;
            CBPAGARMENSUALIDAD.Enabled = false;
            TXTNUMRECIBO.Enabled = false;
            TIMEPICKERFECHRECIBO.Enabled = false;
            BTNGUARDARPAGO.Enabled = false;
            TXTMONTOAPAGAR.Text = "0";
            TXTNUMRECIBO.Text = null;
            CBPAGARCARNET.Checked = false;
            CBPAGARMATRICULA.Checked = false;
            CBPAGARMENSUALIDAD.Checked = false;
            FOTOALUAPAGAR.Image = null;
            label7.Visible = false;
            label8.Visible = false;
            LBLEDADALUAPAGAR.Text=null;
            TXTALUMNOAPAGAR.Text = null;
            LBLDNIALUAPAGAR.Text = null;
            LBLTIPOALUMNO.Visible = false;
        }
        //CUANDO CAMBIA EL CHECKBOX DEFINE EL MONTO DE CARNET
        private void CBPAGARCARNET_CheckedChanged(object sender, EventArgs e)
        {
            if (CBPAGARCARNET.Checked == true) {
            }
            if (CBPAGARCARNET.Checked == false) {
            }
           CALCULARMONTO();
        }
        //CUANDO CAMBIA EL CHECKBOX DEFINE EL MONTO DE MENSUALIDAD
        private void CBPAGARMENSUALIDAD_CheckedChanged(object sender, EventArgs e)
        {
            CALCULARMONTO();
        }
        //VERIFICA SI EL MONTO TOTAL ES DIFERENTE DE CERO Y ACTIVA O DESACTIVA LAS CASILLAS DE PAGO
        private void TXTMONTOAPAGAR_TextChanged(object sender, EventArgs e)
        {
            if (TXTMONTOAPAGAR.Text.ToString() == "0") {
                TXTNUMRECIBO.Enabled = false;
                TIMEPICKERFECHRECIBO.Enabled = false;
                TXTNUMRECIBO.Text = null;
            }
            if (TXTMONTOAPAGAR.Text.ToString() != "0") {
                TXTNUMRECIBO.Enabled = true;
                TIMEPICKERFECHRECIBO.Enabled = true;
            }
        }
        //verifica que solo ingreses numeros en el dni
        public void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsUpper(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 22)
            {
                e.Handled = true;
            }
        }
        private void TIMEPICKERFECHRECIBO_ValueChanged(object sender, EventArgs e)
        {
            if (TIMEPICKERFECHRECIBO.Value > DateTime.Today)
            {
                //CODIGO USADO PARA RESTRINGIR EL INGRESO
                TIMEPICKERFECHRECIBO.Value = DateTime.Today;
            }            
        }
    }
}
