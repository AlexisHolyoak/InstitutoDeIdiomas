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
    public partial class frmCrearPago : Form
    {
        String idcodigo;
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        public frmCrearPago(String codigo)
        {
            InitializeComponent();
            idcodigo = codigo;
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
            FOTOALUMNOAPAGAR.SizeMode = PictureBoxSizeMode.StretchImage;
            LBLUSUENCARGADODEPAGO.Text = idcodigo;
        }      
        private void CBLISTBOX_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void BTNGUARDARPAGO_Click(object sender, EventArgs e)
        {
            LIMPIAR_ERRORES();
            if (VALIDAR_MATRICULA()&&VALIDAR_PAGO()) {
                try
                {                   
                    SqlCommand cmd = new SqlCommand("crear_nuevo_pago", _SqlConnection);
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@numero_recibo", TXTNUMERORECIBO.Text.Trim().ToString()));
                    cmd.Parameters.Add(new SqlParameter("@fecha", FECHARECIBO.Value));
                    cmd.Parameters.Add(new SqlParameter("@codigo_alumno", LBLCODIGOALUMN.Text.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@idtrabajador", idcodigo));
                    cmd.ExecuteNonQuery();
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    if (CBPAGARMATRICULA.CheckState == CheckState.Checked) {
                        PAGAR_MATRICULA();
                    }
                    GUARDAR_OTROS_PAGOS();
                    MessageBox.Show("PAGO REALIZADO CON EXITO");
                    LIMPIAR_DATOS();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }               
            }
        }
       
        private void PAGAR_MATRICULA() {
            var rbmod = GBMODALIDADMATRICULA.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var rbidi = GBIDIOMA.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var rbniv = GBNIVEL.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            string mod = rbmod.Text.ToString();
            string idio = rbidi.Text.ToString();
            string niv = rbniv.Text.ToString();
            string cic = NUMCICLO.Value.ToString();
            try
            {
                SqlCommand cmd = new SqlCommand("crear_detalle_matricula", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@idioma", idio));
                cmd.Parameters.Add(new SqlParameter("@nivel",niv));
                cmd.Parameters.Add(new SqlParameter("@modalidad",   mod));
                cmd.Parameters.Add(new SqlParameter("@ciclo", cic));
                cmd.Parameters.Add(new SqlParameter("@fecha", DateTime.Now));
                cmd.Parameters.Add(new SqlParameter("@numero_recibo", TXTNUMERORECIBO.Text.Trim().ToString()));
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }            
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void GUARDAR_OTROS_PAGOS() {
            foreach (DataGridViewRow r in GRIDVIEWTIPOSPAGOS.Rows)
            {
                DataGridViewCheckBoxCell ck = r.Cells["SELECCIONAR"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(ck.Value))
                {
                    int idpago = Convert.ToInt32(r.Cells[0].Value.ToString());
                    try
                    {
                        SqlCommand cmd = new SqlCommand("crear_detalle_pago", _SqlConnection);
                        if (cmd.Connection.State == ConnectionState.Closed)
                        {
                            cmd.Connection.Open();
                        }
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@idtipo", idpago));
                        cmd.Parameters.Add(new SqlParameter("@numerorecibo", TXTNUMERORECIBO.Text.Trim().ToString()));

                        cmd.ExecuteNonQuery();
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
        }
        private void LIMPIAR_DATOS()
        {
            TXTMONTO.Text = "0";
            TXTNUMERORECIBO.Text = "";
            CBPAGARMATRICULA.CheckState = CheckState.Unchecked;
        }
        private bool VALIDAR_MATRICULA()
        {
            bool ok = true;
            if (PANELMATRICULA.Enabled == true) {            
            if (RBMATREGULAR.Checked == false && RBMATUBICACION.Checked == false)
            {
                ok = false;
                MISSINGDATA.SetError(GBMODALIDADMATRICULA, "SELECCIONA UNA MODALIDAD");
            }
            if (RBINGLES.Checked == false && RBITALIANO.Checked == false && RBFRANCES.Checked == false && RBPORTUGUES.Checked == false && RBALEMAN.Checked == false && RBQUECHUA.Checked == false && RBCHINO.Checked == false && RBOTRO.Checked == false)
            {
                ok = false;
                MISSINGDATA.SetError(GBIDIOMA, "SELECCIONA UN IDIOMA");
            }
            if (RBBASICO.Checked == false && RBINTERMEDIO.Checked == false && RBAVANZADO.Checked == false)
            {
                ok = false;
                MISSINGDATA.SetError(GBNIVEL, "SELECCIONA UN NIVEL");
            }
        }
            return ok;
        }
        private bool VALIDAR_PAGO() {
            bool ok = true;
            if (TXTMONTO.Text.ToString() == "0") {
                MISSINGDATA.SetError(TXTMONTO, "EL MONTO A GUARDAR NO PUEDE SER CERO");
                ok = false;
            }
            if (TXTNUMERORECIBO.Text.Trim().ToString() == ""&& TXTNUMERORECIBO.ReadOnly==false) {
                MISSINGDATA.SetError(TXTMONTO, "INGRESA UN NUMERO DE RECIBO");
                ok = false;
            }
            if (TXTNUMERORECIBO.Text.Trim() != "") {
                try
                {
                    SqlCommand cmd = new SqlCommand("verificar_recibo", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    cmd.Parameters.Add(new SqlParameter("@numrecibo", TXTNUMERORECIBO.Text));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            ok = false;
                            MISSINGDATA.SetError(TXTNUMERORECIBO, "ESTE NUMERO DE RECIBO YA HA SIDO REGISTRADO!!!");
                        }
                    }
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
            
            return ok;
        }
        private void LIMPIAR_ERRORES() {
            MISSINGDATA.SetError(GBMODALIDADMATRICULA, null);
            MISSINGDATA.SetError(GBIDIOMA, null);
            MISSINGDATA.SetError(GBNIVEL, null);
        }
        private void LISTBOXRAZONES_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //CARGA EL GRID VIEW EN LA CONSULTA DE NOMBRES CON LISTENER POR TECLEADO
        private void TXTNOMBRESBUSCA_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscarAlumnoApellido", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@txt", TXTINGNOMBRE.Text.Trim()));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                GRIDVIEWCONSALUPAGO.DataSource = dt;
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
        //CARGA EL GRID VIEW EN LA CONSULTA POR DNI
        private void btnBuscarPorDni_Click(object sender, EventArgs e)
        {
            try
            {
                _SqlConnection.Open();
                SqlCommand cmd = new SqlCommand("buscarPorDNI", _SqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@dni", TXTINGDNI.Text.Trim()));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GRIDVIEWCONSALUPAGO.DataSource = dt;
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
        //LISTENER PARA LA CONSULTA DE PERSONAS EN EL GRIDVIEW
        private void GridViewNombres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < GRIDVIEWCONSALUPAGO.RowCount - 1)
            {
                DataGridViewRow row = this.GRIDVIEWCONSALUPAGO.Rows[e.RowIndex];
                String dni = row.Cells[3].Value.ToString();
                CBPAGARMATRICULA.Enabled = true;
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
                        FOTOALUMNOAPAGAR.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        FOTOALUMNOAPAGAR.Image = Image.FromStream(ms);
                    }
                    LBLTIPOALUMN.Text = dt.Rows[0][6].ToString();
                    LBLCODIGOALUMN.Text = dt.Rows[0][7].ToString();
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
        //IDENTIFICA EL TIPO DE ALUMNO DEL LABEL LBLTIPOALUMN Y CARGA EL GRIDVIEW CON LOS MONTOS Y PAGOS CORRESPONDIENTES
        private void LBLTIPOALUMN_TextChanged(object sender, EventArgs e)
        {
            GRIDVIEWTIPOSPAGOS.DataSource = null;
            GRIDVIEWTIPOSPAGOS.Columns.Clear();
            GRIDVIEWTIPOSPAGOS.Rows.Clear();

            if (LBLTIPOALUMN.Text == "FAUSTINIANO") {
                try
                {
                    DataGridViewCheckBoxColumn dgvcbc = new DataGridViewCheckBoxColumn();
                    dgvcbc.HeaderCell.Value = "SELECCIONAR";
                    dgvcbc.Name = "SELECCIONAR";
                    dgvcbc.ReadOnly = false;
                    SqlCommand cmd = new SqlCommand("cargar_tipos_pagos_faustinianos", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GRIDVIEWTIPOSPAGOS.DataSource = dt;
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    GRIDVIEWTIPOSPAGOS.Columns["ID"].ReadOnly = true;
                    GRIDVIEWTIPOSPAGOS.Columns["ID"].Width = 40;
                    GRIDVIEWTIPOSPAGOS.Columns["RAZON"].ReadOnly = true;
                    GRIDVIEWTIPOSPAGOS.Columns["RAZON"].Width = 300;
                    GRIDVIEWTIPOSPAGOS.Columns["MONTO"].ReadOnly = true;
                    GRIDVIEWTIPOSPAGOS.Columns["MONTO"].Width = 50;
                    GRIDVIEWTIPOSPAGOS.Columns.Add(dgvcbc);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (LBLTIPOALUMN.Text == "PARTICULAR")
            {
                try
                {
                    DataGridViewCheckBoxColumn dgvcbc = new DataGridViewCheckBoxColumn();
                    dgvcbc.HeaderCell.Value = "SELECCIONAR";
                    dgvcbc.Name = "SELECCIONAR";
                    dgvcbc.ReadOnly = false;
                    SqlCommand cmd = new SqlCommand("cargar_tipos_pagos_particulares", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GRIDVIEWTIPOSPAGOS.DataSource = dt;
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                    GRIDVIEWTIPOSPAGOS.Columns["ID"].ReadOnly = true;
                    GRIDVIEWTIPOSPAGOS.Columns["ID"].Width = 40;
                    GRIDVIEWTIPOSPAGOS.Columns["RAZON"].ReadOnly = true;
                    GRIDVIEWTIPOSPAGOS.Columns["RAZON"].Width = 300;
                    GRIDVIEWTIPOSPAGOS.Columns["MONTO"].ReadOnly = true;
                    GRIDVIEWTIPOSPAGOS.Columns["MONTO"].Width = 50;
                    GRIDVIEWTIPOSPAGOS.Columns.Add(dgvcbc);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //CONTROLA EL CAMBIO DEL CHECBOX DENTRO DEL GRIDVIEW
        private void dgvStandingOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double monto = 0;
            CALCULAR_MONTO_A_PAGAR();
            if (GRIDVIEWTIPOSPAGOS.Columns[e.ColumnIndex].Name == "SELECCIONAR" && GRIDVIEWTIPOSPAGOS.CurrentCell is DataGridViewCheckBoxCell)
            {
                bool isChecked = (bool)GRIDVIEWTIPOSPAGOS[e.ColumnIndex, e.RowIndex].EditedFormattedValue;
                monto = Convert.ToDouble(GRIDVIEWTIPOSPAGOS[2, e.RowIndex].Value.ToString());              
                if (isChecked == true)
                {
                   
                }               
                GRIDVIEWTIPOSPAGOS.EndEdit();
            }
        }     
        //CONCLUSION DE LA EDICION DEL DATAGRIDVIEW
        private void dgvStandingOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            GRIDVIEWTIPOSPAGOS.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        //VERIFICA QUE LA CELDA SELECCIONADA SEA DE TIPO CHECKBOX
        private void dgvStandingOrder_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (GRIDVIEWTIPOSPAGOS.CurrentCell is DataGridViewCheckBoxCell)
            {
                GRIDVIEWTIPOSPAGOS.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        //EVENTOS DEL CHECBOX PARA PAGAR LA MTRICULA
        private void CBPAGARMATRICULA_CheckedChanged(object sender, EventArgs e)
        {                     
            if (CBPAGARMATRICULA.CheckState == CheckState.Checked)
            {      
                PANELMATRICULA.Enabled = true;
            }
            else {
                LIMPIAR_ERRORES();
                PANELMATRICULA.Enabled = false;
            }
        }
        private void TXTMONTO_TextChanged(object sender, EventArgs e)
        {
            if (TXTMONTO.Text.ToString() != "0") {
                TXTNUMERORECIBO.Enabled = true;
                FECHARECIBO.Enabled = true;
            }
            if (TXTMONTO.Text.ToString() == "0")
            {
                TXTNUMERORECIBO.Enabled = false;
                FECHARECIBO.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void btnEditarMonto_Click(object sender, EventArgs e)
        {
            TXTMONTO.Enabled = true;
            TXTMONTO.ReadOnly = false;
        }
        //KEYLISTENER QUE VERIFICA EL INGRESO DE NUMEROS
        public void SoloNumeros(object sender, KeyPressEventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            CALCULAR_MONTO_A_PAGAR();
        }
        private void CALCULAR_MONTO_A_PAGAR() {
            double monto = 0;            
            foreach (DataGridViewRow r in GRIDVIEWTIPOSPAGOS.Rows)
            {            
                DataGridViewCheckBoxCell ck = r.Cells["SELECCIONAR"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(ck.Value))
                {
                    double cantidad = Convert.ToDouble(r.Cells[2].Value.ToString());
                    monto = monto + cantidad;
                }             
            }
            if (CBPAGARMATRICULA.CheckState == CheckState.Checked) {
                monto = monto + 20;
            }                                                                                                    
            TXTMONTO.Text = "" + monto;
        }
    }
}