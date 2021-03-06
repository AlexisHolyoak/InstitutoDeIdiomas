﻿using System;
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
    public partial class frmRegistrarAlumnos : Form
    {
        string[] departamentos = { "AMAZONAS", "ANCASH",
                "APURIMAC", "AREQUIPA", "AYACUCHO", "CAJAMARCA",
                "CUSCO", "HUANCAVELICA","HUANUCO", "ICA", "JUNIN",
                "LA LIBERTAD", "LAMBAYEQUE", "LIMA", "LORETO", "MADRE DE DIOS", "MOQUEGUA",
                "PASCO", "PIURA", "PUNO", "SAN MARTIN", "TACNA", "TUMBES", "UCAYALI"};
        MsSqlConnection configurarConexion = new MsSqlConnection();
        public static SqlConnection _SqlConnection = new SqlConnection();
        public frmRegistrarAlumnos(String id)
        {
            InitializeComponent();
            cargarComboBoxDepartamentos(this.CBDEPARTAMENTOSALU);
            _SqlConnection.ConnectionString = configurarConexion._ConnectionString;
        }
        private void RBALUPARTICULAR_CheckedChanged(object sender, EventArgs e)
        {
            PANELFAUSTINO.Visible = false;
            PANELPARTICULAR.Visible = true;
            
        }        
        private void RBALUFAUSTINIANO_CheckedChanged(object sender, EventArgs e)
        {
            PANELFAUSTINO.Visible = true;
            PANELPARTICULAR.Visible = false;            
            try {
                
                SqlCommand cmd = new SqlCommand("listar_facultades", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                CBFACULTADALU.DisplayMember = "facultad";
                CBFACULTADALU.DataSource = dt;
                if (cmd.Connection.State == ConnectionState.Open) {
                    cmd.Connection.Close();
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                
            }
        }
        //KEYLISTENER QUE VERIFICA LA SELECCION DE UNA FACULTAD Y MUESTRA ESCUELAS
        private void CBFACULTADALU_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox combobox = (ComboBox)sender;
            //convierte de tipo DATA ROW VIEW TO STRING
            String selectedFacultad = ((DataRowView)CBFACULTADALU.SelectedItem)["facultad"].ToString();                                              
            try
            {                               
                SqlCommand cmd = new SqlCommand("listar_escuelas", _SqlConnection);
                if (cmd.Connection.State == ConnectionState.Closed)
                {
                    cmd.Connection.Open();
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@facultad", selectedFacultad));
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                if (cmd.Connection.State == ConnectionState.Closed) {
                    cmd.Connection.Open();
                }
                da.Fill(dt);
                CBESCUELAALU.DisplayMember = "escuela";
                CBESCUELAALU.DataSource = dt;
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
              
            }
        }
          private void RBCOLEGIOALU_CheckedChanged(object sender, EventArgs e)
        {
            CBCENTRODEESTUDIOS.DataSource = null;
            LBLCENTROESTUDIOS.Text = "COLEGIO";
            LBLCENTROESTUDIOS.Visible = true;
            CBCENTRODEESTUDIOS.Visible = true;
            BTNAGREGARCENTROESTUDIO.Visible = true;
            try
            {
                
                SqlCommand comando = new SqlCommand("lista_colegios",_SqlConnection);
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                CBCENTRODEESTUDIOS.DisplayMember = "nombreColegio";
                CBCENTRODEESTUDIOS.DataSource = dt;
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {               
            }
        }
        //RADIO BUTTON PARA CARGAR UNIVERSIDADES
        private void RBUNIVERSIDADALU_CheckedChanged(object sender, EventArgs e)
        {
            LBLCENTROESTUDIOS.Text = "UNIVERSIDAD";
            LBLCENTROESTUDIOS.Visible = true;
            CBCENTRODEESTUDIOS.Visible = true;
            CBCENTRODEESTUDIOS.DataSource = null;
            BTNAGREGARCENTROESTUDIO.Visible = true;
            try
            {
                SqlCommand comando = new SqlCommand("listar_universidad", _SqlConnection);
                if (comando.Connection.State == ConnectionState.Closed)
                {
                    comando.Connection.Open();
                }
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                CBCENTRODEESTUDIOS.DisplayMember = "nombreUniversidad";
                CBCENTRODEESTUDIOS.DataSource = dt;
                if (comando.Connection.State == ConnectionState.Open)
                {
                    comando.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
            }
        }
        private void RBNINGUNOALU_CheckedChanged(object sender, EventArgs e)
        {
            LBLCENTROESTUDIOS.Text = "NINGUNO";
            LBLCENTROESTUDIOS.Visible = false;
            CBCENTRODEESTUDIOS.Visible = false;
            CBCENTRODEESTUDIOS.Text = null;
            CBCENTRODEESTUDIOS.DataSource = null;
            BTNAGREGARCENTROESTUDIO.Visible = false;
        }
        //KEYLISTENER QUE VERIFICA EL INGRESO DE NUMEROS
        public void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsUpper(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 22)
            {
                e.Handled = true;
            }
        }
        //KEYLISTENER QUE VERIFICA EL INGRESO DE LETRAS
        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TIMEPICKERNACIMIENTOALU_ValueChanged(object sender, EventArgs e)
        {
            if (TIMEPICKERNACIMIENTOALU.Value < DateTime.Today)
            {
                //CODIGO USADO PARA CALCULAR LA EDAD AUTOMATICAMENTE
                TXTEDADALU.Text = (DateTime.Today.AddTicks(-TIMEPICKERNACIMIENTOALU.Value.Ticks).Year - 1).ToString();
            }
            else {
                TIMEPICKERNACIMIENTOALU.Value = DateTime.Today;
            }                        
        }
        //CARGAR TODOS LOS DEPARTAMENTOS
        private void cargarComboBoxDepartamentos(ComboBox combo)
        {
            for (int i = 0; i < departamentos.Length; i++)
            {
                combo.Items.Add(departamentos[i]);
            }
        }
        //METODO PARA CARGAR PROVINCIAS SEGUN EL DEPARTAMENTO SELECCIONADO
        private void CBDEPARTAMENTOSALU_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = (ComboBox)sender;
            this.CBDISTRITOALU.Items.Clear();
            string selectedDepartamento = (string)CBDEPARTAMENTOSALU.SelectedItem;
            if (selectedDepartamento.Equals("AMAZONAS"))
            {
                string[] region = { "CHACHAPOYAS", "BAGUA", "BONGARA", "CONDORCANQUI", "LUYA", "RODRIGUEZ DE MENDOZA", "UTCUBAMBA" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("ANCASH"))
            {
                string[] region = { "AIJA", "ANTONIO RAYMONDI", "ASUNCION", "BOLOGNESI", "CARHUAZ", "CARLOS F. FITZCARRALD", "CASMA", "CORONGO", "HUARI", "HUARMEY", "HUAYLAS", "MARISCAL LUZURIAGA", "OCROS", "PALLASCA", "POMABAMBA", "RECUAY", "SANTA", "SIHUAS", "YUNGAY" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("APURIMAC"))
            {
                string[] region = { "ABANCAY", "ANDAHUAYLAS", "ANTABAMBA", "AYMARAES", "CHINCHEROS", "COTABAMBAS", "GRAU" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("AREQUIPA"))
            {
                string[] region = { "AREQUIPA", "CAMANA", "CARAVELI", "CASTILLA", "CAYLLOMA", "CONDESUYOS", "ISLAY", "LA UNION" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("AYACUCHO"))
            {
                string[] region = { "CANGALLO", "HUANTA", "HUANCASANCOS", "HUAMANGA", "LA MAR", "LUCANAS", "PARINACOCHAS", "PAUCAR DEL SARA SARA", "SUCRE", "VICTOR FAJARDO", "VILCAS HUAMAN" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("CAJAMARCA"))
            {
                string[] region = { "CAJABAMBA", "CAJAMARCA", "CELENDIN", "CHOTA", "CONTUMAZA", "CUTERVO", "HUALGAYOC", "JAEN", "SAN IGNACIO", "SAN MARCOS", "SAN MIGUEL", "SAN PABLO", "SANTA CRUZ" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("CUSCO"))
            {
                string[] region = { "ACOMAYO", "ANTA", "CALCA", "CANAS", "CANCHIS", "LA CONVENCION", "CUSCO", "CHUMBIVILCAS", "ESPINAR", "PARURO", "PAUCARTAMBO", "QUISPICANCHIS", "URUBAMBA" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("HUANCAVELICA"))
            {
                string[] region = { "ACOBAMBA", "ANGARAES", "CASTROVIRREYNA", "CHURCAMPA", "HUANCAVELICA", "HUAYTARA", "TAYACAJA" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("HUANUCO"))
            {
                string[] region = { "AMBO", "DOS DE MAYO", "HUACAYBAMBA", "HUAMALIES", "HUANUCO", "LEONCIO PRADO", "PACHITEA", "PUERTO INCA" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("ICA"))
            {
                string[] region = { "CHINCHA", "ICA", "NAZCA", "PALPA", "PISCO" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("JUNIN"))
            {
                string[] region = { "CHANCHAMAYO", "CHUPACA", "CONCEPCION", "HUANCAYO", "JAUJA", "JUNIN", "SATIPO", "TARMA", "YAULI" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("LA LIBERTAD"))
            {
                string[] region = { "ASCOPE", "BOLIVAR", "CHEPEN", "GRAN CHIMU", "JULCAN", "OTUZCO", "PACASMAYO", "PATAZ", "SANCHEZ CARRION", "SANTIAGO DE CHUCO", "TRUJILLO", "VIRU" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("LAMBAYEQUE"))
            {
                string[] region = { "CHICLAYO", "FERREÑAFE", "LAMBAYEQUE" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("LIMA"))
            {
                string[] region = { "BARRANCA", "CAJATAMBO", "CANTA", "CAÑETE", "HUARAL", "HUAROCHIRI", "HUAURA", "LIMA", "OYON", "YAUYOS" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("LORETO"))
            {
                string[] region = { "ALTO AMAZONAS", "DATEM DEL MARAÑON", "LORETO", "MCAL. RAMON CASTILLA", "MAYNAS", "REQUENA", "UCAYALI" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("MADRE DE DIOS"))
            {
                string[] region = { "MANU", "TAHUAMANU", "TAMBOPATA" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("MOQUEGUA"))
            {
                string[] region = { "GENERAL SANCHEZ CERRO", "ILO", "MARISCAL NIETO" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("PASCO"))
            {
                string[] region = { "DANIEL A. CARRION", "OXAPAMPA", "PASCO" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("PIURA"))
            {
                string[] region = { "AYABACA", "HUANCABAMBA", "MORROPON", "PAITA", "PIURA", "SECHURA", "SULLANA", "TALARA" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("PUNO"))
            {
                string[] region = { "AZANGARO", "CARABAYA", "CHUCUITO", "EL COLLAO", "HUANCANE", "LAMPA", "MELGAR", "MOHO", "PUNO", "SAN ANTONIO DE PUTINA", "SAN ROMAN", "SANDIA", "YUNGUYO" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("SAN MARTIN"))
            {
                string[] region = { "BELLAVISTA", "EL DORADO", "HUALLAGA", "LAMAS", "MARISCAL CACERES", "MOYOBAMBA", "PICOTA", "RIOJA", "SAN MARTIN", "TOCACHE" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("TACNA"))
            {
                string[] region = { "CANDARAVE", "JORGE BASADRE", "TACNA", "TARATA" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("TUMBES"))
            {
                string[] region = { "CONTRALMIERANTE VILLAR", "TUMBES", "ZARUMILLA" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
            if (selectedDepartamento.Equals("UCAYALI"))
            {
                string[] region = { "ATALAYA", "CORONEL PORTILLO", "PADRE ABAD", "PURUS" };
                cargarComboBox(this.CBPROVINCIAALU, region);
            }
        }
        //METODO PARA CARGAR DISTRITOS SEGUN LA PROVINCIA SELECCIONADA
        private void CBPROVINCIASALU_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = (ComboBox)sender;
            string selectedProvincia = (string)CBPROVINCIAALU.SelectedItem;
            //AMAZONAS
            if (selectedProvincia.Equals("CHACHAPOYAS"))
            {
                string[] distrito = { "CHACHAPOYAS", "ASUNCION", "BALSAS", "CHETO", "CHILIQUIN", "CHUQUIBAMBA", "GRANADA", "HUANCAS", "LA JALCA", "LEIMEBAMBA", "LEVANTO", "MAGDALENA", "MARISCAL CASTILLA", "MOLINOPAMPA", "MONTEVIDEO", "OLLEROS", "QUINJALCA", "SAN FRANCISCO DE DAGUAS", "SAN ISIDRO DE MAINO", "SOLOCO", "SONCHE" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("BAGUA"))
            {
                string[] distrito = { "LA PECA", "ARAMANGO", "COPALLIN", "EL PARCO", "IMAZA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("BONGARA"))
            {
                string[] distrito = { "JUMBILLA", "CHISQUILLA", "CHURUJA", "COROSHA", "CUISPES", "FLORIDA", "JAZAN", "RECTA", "SAN CARLOS", "SHIPASBAMBA", "VALERA", "YAMBRASBAMBA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CONDORCANQUI"))
            {
                string[] distrito = { "NIEVA", "EL CENEPA", "RIO SANTIAGO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("LUYA"))
            {
                string[] distrito = { "LAMUD", "CAMPORREDONDO", "COCABAMBA", "COLCAMAR", "CONILA", "INGUILPATA", "LONGUITA", "LONYA CHICO", "LUYA", "LUYA VIEJO", "MARIA", "OCALLI", "OCUMAL", "PISUQUIA", "PROVIDENCIA", "SAN CRISTOBAL", "SAN FRANCISCO DEL YESO", "SAN JERONIMO", "SAN JUAN DE LOPECANCHA", "SANTA CATALINA", "SANTO TOMAS", "TINGO", "TRITA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("RODRIGUEZ DE MENDOZA"))
            {
                string[] distrito = { "SAN NICOLAS", "CHIRIMOTO", "COCHAMAL", "HUAMBO", "LIMABAMBA", "LONGAR", "MARISCAL BENAVIDES", "MILPUC", "OMIA", "SANTA ROSA", "TOTORA", "VISTA ALEGRE" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("UTCUBAMBA"))
            {
                string[] distrito = { "BAGUA GRANDE", "CAJARURO", "CUMBA", "EL MILAGRO", "JAMALCA", "LONYA GRANDE", "YAMON" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            //ANCASH
            if (selectedProvincia.Equals("HUARAZ"))
            {
                string[] distrito = { "HUARAZ", "COCHABAMBA", "COLCABAMBA", "HUANCHAY", "JANGAS", "LA LIBERTAD", "OLLEROS", "PAMPAS", "PARIACOTO", "PIRA", "TARICA", "INDEPENDENCIA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("AIJA"))
            {
                string[] distrito = { "AIJA", "CORIS", "HUACLLAN", "LA MERCED", "SUCCHA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("ANTONIO RAYMONDI"))
            {
                string[] distrito = { "LLAMELLIN", "ACZO", "CHACCHO", "CHINGAS", "MIRGAS", "SAN JUAN DE RONTOY" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("ASUNCION"))
            {
                string[] distrito = { "CHACAS", "ACOCHACA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("BOLOGNESI"))
            {
                string[] distrito = { "CHIQUIAN", "ABELARDO PARDO LEZAMETA", "ANTONIO RAYMONDI", "AQUIA", "CAJACAY", "CANIS", "COLQUIOC", "HUALLANCA", "HUASTA", "HUAYLLACAYAN", "LA PRIMAVERA", "MANGAS", "PACLLON", "S. MGEL DE CORPANQUI", "TICLLOS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CARHUAZ"))
            {
                string[] distrito = { "CARHUAZ", "ACOPAMPA", "AMASHCA", "ANTA", "ATAQUERO", "MARCARA", "PARIAHUANCA", "SAN MIGUEL DE ACO", "SHILLA", "TINCO", "YUNGAR" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CARLOS F. FITZCARRALD"))
            {
                string[] distrito = { "SAN LUIS", "SAN NICOLAS", "YAUYA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CASMA"))
            {
                string[] distrito = { "CASMA", "BUENA VISTA ALTA", "COMANDANTE NOEL", "YAUTAN" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CORONGO"))
            {
                string[] distrito = { "CORONGO", "ACO", "BAMBAS", "CUSCA", "LA PAMPA", "YANAC", "YUPAN" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("HUARI"))
            {
                string[] distrito = { "HUARI", "ANRA", "CAJAY", "CHAVIN DE HUANTAR", "HUACACHI", "HUACCHIS", "HUACHIS", "HUANTAR", "MASIN", "PAUCAS", "PONTO", "RAHUAPAMPA", "RAPAYAN", "SAN MARCOS", "SAN PEDRO DE CHANA", "UCO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("HUARMEY"))
            {
                string[] distrito = { "HUARMEY", "COCHAPETI", "CULEBRAS", "HUAYAN", "MALVAS", };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("HUAYLAS"))
            {
                string[] distrito = { "CARAZ", "HUALLANCA", "HUATA", "HUAYLAS", "MATO", "PAMPAROMAS", "PUEBLO LIBRE", "SANTA CRUZ", "SANTO TORIBIO", "YURACMARCA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("MARISCAL LUZURIAGA"))
            {
                string[] distrito = { "PISCOBAMBA", "CASCA", "ELEAZAR GUZMAN BARRON", "FIDEL OLIVAS ESCUDERO", "LLAMA", "LLUMPA", "LUCMA", "MUSGA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("OCROS"))
            {
                string[] distrito = { "OCROS", "ACAS", "CAJAMARQUILLA", "CARHUAPAMPA", "COCHAS", "CONGAS", "LLIPA", "SAN CRISTOBAL DE RAJAN", "SAN PEDRO", "SANTIAGO DE CHILCAS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("PALLASCA"))
            {
                string[] distrito = { "CABANA", "BOLOGNESI", "CONCHUCOS", "HUACASCHUQUE", "HUANDOVAL", "LACABAMBA", "LLAPO", "PALLASCA", "PAMPAS", "SANTA ROSA", "TAUCA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("POMABAMBA"))
            {
                string[] distrito = { "POMABAMBA", "HUAYLLAN", "PAROBAMBA", "QUINUABAMBA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("RECUAY"))
            {
                string[] distrito = { "RECUAY", "CATAC", "COTAPARACO", "HUAYLLAPAMPA", "LLACLLIN", "MARCA", "PAMPAS CHICO", "PARARIN", "TAPACOCHA", "TICAPAMPA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("SANTA"))
            {
                string[] distrito = { "CHIMBOTE", "CACERES DEL PERU", "COISHCO", "MACATE", "MORO", "NEPEÑA", "SAMANCO", "SANTA", "NUEVO CHIMBOTE" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("SIHUAS"))
            {
                string[] distrito = { "SIHUAS", "ACOBAMBA", "ALFONSO UGARTE", "CASHAPAMPA", "CHINGALPO", "HUAYLLABAMBA", "QUICHES", "RAGASH", "SAN JUAN", "SICSIBAMBA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("YUNGAY"))
            {
                string[] distrito = { "YUNGAY", "CASCAPARA", "MANCOS", "MATACOTO", "QUILLO", "RANRAHIRCA", "SHUPLUY", "YANAMA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            //APURIMAC
            if (selectedProvincia.Equals("ABANCAY"))
            {
                string[] distrito = { "ABANCAY", "CHACOCHE", "CIRCA", "CURAHUASI", "HUANIPACA", "LAMBRAMA", "PICHIRHUA", "SAN PEDRO DE CACHORA", "TAMBURCO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("ANTABAMBA"))
            {
                string[] distrito = { "ANTABAMBA", "EL ORO", "HUAQUIRCA", "JUAN ESPINOZA MEDRANO", "OROPESA", "PACHACONAS", "SABAINO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("AYMARAES"))
            {
                string[] distrito = { "CHALHUANCA", "CAPAYA", "CARAYBAMBA", "CHAPIMARCA", "COLCABAMBA", "COTARUSE", "HUAYLLO", "JUSTO APU SAHUARAURA", "LUCRE", "POCOHUANCA", "SAN JUAN DE CHACÑA", "SAÑAYCA", "SORAYA", "TAPAIRIHUA", "TINTAY", "TORAYA", "YANACA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("COTABAMBAS"))
            {
                string[] distrito = { "TAMBOBAMBA", "COTABAMBAS", "COYLLURQUI", "HAQUIRA", "MARA", "CHALLHUAHUACHO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("GRAU"))
            {
                string[] distrito = { "CHUQUIBAMBILLA", "CURPAHUASI", "GAMARRA", "HUAYLLATI", "MAMARA", "MICAELA BASTIDAS", "PATAYPAMPA", "PROGRESO", "SAN ANTONIO", "SANTA ROSA", "TURPAY", "VILCABAMBA", "VIRUNDO", "CURASCO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CHINCHEROS"))
            {
                string[] distrito = { "CHINCHEROS", "ANCO-HUALLO", "COCHARCAS", "HUACCANA", "OCOBAMBA", "ONGOY", "URANMARCA", "RANRACANCHA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("ANDAHUAYLAS"))
            {
                string[] distrito = { "ANDAHUAYLAS", "ANDARAPA", "CHIARA", "HUANCARAMA", "HUANCARAY", "HUAYANA", "KISHUARA", "PACOBAMBA", "PACUCHA", "PAMPACHIRI", "POMACOCHA", "SAN ANTONIO DE CACHI", "SAN JERONIMO", "SAN MIGUEL DE CHACCRAMPA", "SANTA MARIA DE CHICMO", "TALAVERA", "TUMAY HUARACA", "TURPO", "KAQUIABAMBA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            //AREQUIPA
            if (selectedProvincia.Equals("AREQUIPA"))
            {
                string[] distrito = {"AREQUIPA","ALTO SELVA ALEGRE","CAYMA","CERRO COLORADO","CHARACATO","CHIGUATA","JACOBO HUNTER","LA JOYA","MARIANO MELGAR","MIRAFLORES","MOLLEBAYA","PAUCARPATA","POCSI","POLOBAYA","QUEQUEÑA","SABANDIA","SACHACA","SAN JUAN DE SIGUAS","SAN JUAN DE TARUCANI","SANTA ISABEL DE SIGUAS","SANTA RITA DE SIGUAS","SOCABAYA","TIABAYA","UCHUMAYO","VITOR","YANAHUARA","YARABAMBA","YURA","JOSE LUIS BUSTAMANTE Y RIVERO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CAMANA"))
            {
                string[] distrito = { "CAMANA","JOSE MARIA QUIMPER","MARIANO NICOLAS VALCARCEL","MARISCAL CACERES","NICOLAS DE PIEROLA","OCOÑA","QUILCA","SAMUEL PASTOR"};
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CARAVELI"))
            {
                string[] distrito = {"CARAVELI","ACARI","ATICO","ATIQUIPA","BELLA UNION","CAHUACHO","CHALA","CHAPARRA","HUANUHUANU","JAQUI","LOMAS","QUICACHA","YAUCA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CASTILLA"))
            {
                string[] distrito = { "APLAO","ANDAGUA","AYO","CHACHAS","CHILCAYMARCA","CHOCO","HUANCARQUI","MACHAGUAY","ORCOPAMPA","PAMPACOLCA","TIPAN","UÑON","URACA","VIRACO"};
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CAYLLOMA"))
            {
                string[] distrito = { "CHIVAY","ACHOMA","CABANACONDE","CALLALLI","CAYLLOMA","COPORAQUE","HUAMBO","HUANCA","ICHUPAMPA","LARI","LLUTA","MACA","MADRIGAL","SAN ANTONIO DE CHUCA","SIBAYO","TAPAY","TISCO","TUTI","YANQUE"};
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CONDESUYOS"))
            {
                string[] distrito = { "CHUQUIBAMBA","ANDARAY","CAYARANI","CHICHAS","IRAY","RIO GRANDE","SALAMANCA","YANAQUIHUA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("ISLAY"))
            {
                string[] distrito = {"MOLLENDO","COCACHACRA","DEAN VALDIVIA","ISLAY","MEJIA","PUNTA DE BOMBON" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("LA UNION"))
            {
                string[] distrito = {"COTAHUASI","ALCA","CHARCANA","HUAYNACOTAS","PAMPAMARCA","PUYCA","QUECHUALLA","SAYLA","TAURIA","TOMEPAMPA","TORO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            //AYACUCHO
            if (selectedProvincia.Equals("CANGALLO"))
            {
                string[] distrito = { "CANGALLO", "CHUSCHI", "LOS MOROCHUCOS", "MARIA PARADO DE BELLIDO", "PARAS", "TOTOS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("HUANTA"))
            {
                string[] distrito = { "HUANTA", "HAYAHUANCO", "HUAMANGUILLA", "IGUAIN", "LURICOCHA", "SANTILLANA", "SIVIA", };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("HUANCASANCOS"))
            {
                string[] distrito = { "SANCOS", "CARAPO", "SACSAMARCA", "SANTIAGO DE LUCANAMARCA", };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("HUAMANGA"))
            {
                string[] distrito = { "AYACUCHO", "ACOCRO", "ACOS VINCHOS", "CARMEN ALTO", "CHIARA", "OCROS", "PACAYCASA", "QUINUA", "SAN JOSE DE TICLLAS", "SAN JUAN BAUTISTA", "SANTIAGO DE PISCHA", "SOCOS", "TAMBILLO", "VINCHOS", "JESUS NAZARENO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("LA MAR"))
            {
                string[] distrito = { "SAN MIGUEL", "ANCO", "AYNA", "CHILCAS", "CHUNGUI", "LUIS CARRANZA", "TAMBO", "SANTA ROSA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("LUCANAS"))
            {
                string[] distrito = { "PUQUIO", "AUCARA", "CABANA", "CARMEN SALCEDO", "CHAVIÑA", "CHIPAO", "HUAC-HUAS", "LARAMATE", "LEONCIO PRADO", "LLAUTA", "LUCANAS", "OCAÑA", "OTOCA", "SAISA", "SAN CRISTOBAL", "SAN JUAN", "SAN PEDRO", "SAN PEDRO DE PALCO", "SANCOS", "SANTA ANA DE HUAYCAHUACHO", "SANTA LUCIA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("PARINACOCHAS"))
            {
                string[] distrito = { "CORACORA", "CHUMPI", "CORONEL CASTAÑEDA", "PACAPAUSA", "PULLO", "PUYUSCA", "SAN FRANCISCO DE RAVACAYCO", "UPAHUACHO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("PAUCAR DEL SARA"))
            {
                string[] distrito = { "PAUSA", "COLTA", "CORCULLA", "LAMPA", "MARCABAMBA", "OYOLO", "PARARCA", "SAN JAVIER DEL ALPABAMBA", "SAN JOSE DE USHUA", "SARA SARA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("SUCRE"))
            {
                string[] distrito = { "QUEROBAMBA", "BELEN", "CHALCOS", "CHILCAYOC", "HUACAÑA", "MORCOLLA", "PAICO", "	SAN PEDRO DE LARCAY", "SAN SALVADOR DE QUIJE", "SANTIAGO DE PAUCARAY", "SORAS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("VICTOR FAJARDO"))
            {
                string[] distrito = { "HUANCAPI", "ALCAMENCA", "APONGO", "ASQUIPATA", "CANARIA", "CAYARA", "COLCA", "HUAMANQUIQUIA", "HUANCARAYLLA", "HUAYA", "SARHUA", "VILCANCHOS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("VILCAS HUAMAN"))
            {
                string[] distrito = { "VILCAS HUAMAN", "ACCOMARCA", "CARHUANCA", "CONCEPCION", "HUAMBALPA", "INDEPENDENCIA", "SAURAMA", "VISCHONGO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //CAJAMARCA
            if (selectedProvincia.Equals("SAN IGNACIO"))
            {
                string[] distrito = { "SAN IGNACIO", "CHIRINOS", "HUARANGO", "LA COIPA", "NAMBALLE", "SAN JOSE DE LOURDES", "TABACONAS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("JAEN"))
            {
                string[] distrito = { "JAEN", "BELLAVISTA", "CHONTALI", "COLASAY", "HUABAL", "LAS PIRIAS", "POMAHUACA", "PUCARA", "SALLIQUE", "SAN FELIPE", "SAN JOSE DEL ALTO", "SANTA ROSA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CUTERVO"))
            {
                string[] distrito = { "CUTERVO", "CALLAYUC", "CHOROS", "CUJILLO", "LA RAMADA", "PIMPINGOS", "QUEROCOTILLO", "SAN ANDRES DE CUTERVO", "SAN JUAN DE CUTERVO", "SAN LUIS DE LUCMA", "SANTA CRUZ", "SANTO DOMINGO DE LA CAPILLA", "SANTO TOMAS", "SOCOTA", "TORIBIO CASANOVA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CHOTA"))
            {
                string[] distrito = { "CHOTA", "ANGUIA", "CHADIN", "CHIGUIRIP", "CHIMBAN", "COCHABAMBA", "CONCHAN", "HUAMBOS", "LAJAS", "LLAMA", "MIRACOSTA", "PACCHA", "PION", "QUEROCOTO", "SAN JUAN DE LICUPIS", "TACABAMBA", "TOCMOCHE", "CHOROPAMPA", "CHALAMARCA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("SANTA CRUZ"))
            {
                string[] distrito = { "SANTA CRUZ", "ANDABAMBA", "CATACHE", "CHANCAYBAÑOS", "LA ESPERANZA", "NINABAMBA", "PULAN", "SAUCEPAMPA", "SEXI", "UTICYACU", "YAUYUCAN" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("HUALGAYOC"))
            {
                string[] distrito = { "BAMBAMARCA", "CHUGUR", "HUALGAYOC" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CELENDIN"))
            {
                string[] distrito = { "CELENDIN", "CHUMUCH", "CORTEGANA", "HUASMIN", "JORGE CHAVEZ", "JOSE GALVEZ", "MIGUEL IGLESIAS", "OXAMARCA", "SOROCHUCO", "SUCRE", "UTCO", "LA LIBERTAD DE PALLAN" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("SAN PABLO"))
            {
                string[] distrito = { "SAN PABLO", "SAN BERNARDINO", "SAN LUIS", "TUMBADEN" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("SAN MIGUEL"))
            {
                string[] distrito = { "SAN MIGUEL", "BOLIVAR", "CALQUIS", "CATILLUC", "EL PRADO", "LA FLORIDA", "LLAPA", "NANCHOC", "NIEPOS", "SAN GREGORIO", "SAN SILVESTRE DE COCHAN", "TONGOD", "UNION AGUA BLANCA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CONTUMAZA"))
            {
                string[] distrito = { "CONTUMAZA", "CHILETE", "CUPISNIQUE", "GUZMANGO", "SAN BENITO", "SANTA CRUZ DE TOLED", "TANTARICA", "YONAN" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CAJAMARCA"))
            {
                string[] distrito = { "CAJAMARCA", "ASUNCION", "CHETILLA", "COSPAN", "ENCAÑADA", "JESUS", "LLACANORA", "LOS BAÑOS DEL INCA", "MAGDALENA", "MATARA", "NAMORA", "SAN JUAN" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CAJABAMBA"))
            {
                string[] distrito = { "CAJABAMBA", "CACHACHI", "CONDEBAMBA", "SITACOCHA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("SAN MARCOS"))
            {
                string[] distrito = { "PEDRO GALVEZ", "EDUARDO VILLANUEVA", "GREGORIO PITA", "ICHOCAN", "JOSE MANUEL QUIROZ", "JOSE SABOGAL", "CHANCAY" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //CUSCO
            if (selectedProvincia.Equals("CUSCO"))
            {
                string[] distrito = { "CUSCO", "CCORCA", "POROY", "SAN JERONIMO", "SAN SEBASTIAN", "SANTIAGO", "SAYLLA", "WANCHAQ" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("ACOMAYO"))
            {
                string[] distrito = { "ACOMAYO", "ACOPIA", "ACOS", "MOSOC LLACTA", "POMACANCHI", "RONDOCAN", "SANGARARA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("ANTA"))
            {
                string[] distrito = { "ANTA", "ANCAHUASI", "CACHIMAYO", "CHINCHAYPUJIO", "HUAROCONDO", "LIMATAMBO", "MOLLEPATA", "PUCYURA", "ZURITE" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CALCA"))
            {
                string[] distrito = { "CALCA", "COYA", "LAMAY", "LARES", "PISAC", "SAN SALVADOR", "TARAY", "YANATILE" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CANAS"))
            {
                string[] distrito = { "YANAOCA", "CHECCA", "KUNTURKANKI", "LANGUI", "LAYO", "PAMPAMARCA", "QUEHUE", "TUPAC AMARU" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CANCHIS"))
            {
                string[] distrito = { "SICUANI", "CHECACUPE", "COMBAPATA", "MARANGANI", "PITUMARCA", "SAN PABLO", "SAN PEDRO", "TINTA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CHUMBIVILCAS"))
            {
                string[] distrito = { "SANTO TOMAS", "CAPACMARCA", "CHAMACA", "COLQUEMARCA", "LIVITACA", "LLUSCO", "QUIÑOTA", "VELILLE" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("ESPINAR"))
            {
                string[] distrito = { "ESPINAR", "CONDOROMA", "COPORAQUE", "OCORURO", "PALLPATA", "PICHIGUA", "SUYCKUTAMBO", "ALTO PICHIGUA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("LA CONVENCION"))
            {
                string[] distrito = { "SANTA ANA", "ECHARATE", "HUAYOPATA", "MARANURA", "OCOBAMBA", "QUELLOUNO", "QUIMBIRI", "SANTA TERESA", "VILCABAMBA", "PICHARI" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("PARURO"))
            {
                string[] distrito = { "PARURO", "ACCHA", "CCAPI", "COLCHA", "HUANOQUITE", "OMACHA", "PACCARITAMBO", "PILLPINTO", "YAURISQUE" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("PAUCARTAMBO"))
            {
                string[] distrito = { "PAUCARTAMBO", "CAICAY", "CHALLABAMBA", "CHALLABAMBA", "HUANCARANI", "KOSÑIPATA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("QUISPICANCHI"))
            {
                string[] distrito = { "URCOS", "ANDAHUAYLILLAS", "CAMANTI", "CCARHUAYO", "CCATCA", "CUSIPATA", "HUARO", "LUCRE", "MARCAPATA", "OCONGATE", "OROPESA", "QUIQUIJANA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("URUBAMBA"))
            {
                string[] distrito = { "URUBAMBA", "CHINCHERO", "HUAYLLABAMBA", "MACHUPICCHU", "MARAS", "OLLANTAYTAMBO", "YUCAY" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //HUANCAVELICA
            if (selectedProvincia.Equals("HUANCAVELICA"))
            {
                string[] distrito = { "HUANCAVELICA", "ACOBAMBILLA", "ACORIA", "CONAYCA", "CUENCA", "	HUACHOCOLPA", "HUAYLLAHUARA", "IZCUCHACA", "LARIA", "MANTA", "MARISCAL CACERES", "MOYA", "NUEVO OCCORO", "PALCA", "PALCA", "VILCA", "YAULI", "ASCENCION" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("ACOBAMBA"))
            {
                string[] distrito = { "ACOBAMBA", "ANDABAMBA", "ANTA", "CAJA", "MARCAS", "PAUCARA", "POMACOCHA", "ROSARIO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("ANGARAES"))
            {
                string[] distrito = { "LIRCAY", "ANCHONGA", "CALLANMARCA", "CCOCHACCASA", "CHINCHO", "CONGALLA", "HUANCA-HUANCA", "HUAYLLAY GRANDE", "JULCAMARCA", "SAN ANTONIO DE ANTAPARCO", "SANTO TOMAS DE PATA", "SECCLLA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CASTROVIRREYNA"))
            {
                string[] distrito = { "CASTROVIRREYNA", "ARMA", "AURAHUA", "CAPILLAS", "CHUPAMARCA", "COCAS", "HUACHOS", "HUAMATAMBO", "MOLLEPAMPA", "SAN JUAN", "SANTA ANA", "TANTARA", "TICRAPO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CHURCAMPA"))
            {
                string[] distrito = { "CHURCAMPA", "ANCO", "CHINCHIHUASI", "EL CARMEN", "LA MERCED", "LOCROJA", "PACHAMARCA", "PAUCARBAMBA", "SAN MIGUEL DE MAYOCC", "SAN PEDRO DE CORIS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("HUAYTARA"))
            {
                string[] distrito = { "HUAYTARA", "AYAVI", "CORDOVA", "HUAYACUNDO ARMA", "LARAMARCA", "OCOYO", "PILPICHACA", "QUERCO", "QUITO-ARMA", "SAN ANTONIO DE CUSICANCHA", "SAN FRANCISCO DE SANGAYAICO", "SAN ISIDRO", "SANTIAGO DE CHOCORVOS", "SANTIAGO DE QUIRAHUARA", "SANTO DOMINGO DE CAPILLAS", "TAMBO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("TAYACAJA"))
            {
                string[] distrito = { "PAMPAS", "ACOSTAMBO", "ACRAQUIA", "AHUAYCHA", "COLCABAMBA", "DANIEL HERNANDEZ", "HUACHOCOLPA", "HUANDO", "HUARIBAMBA", "ÑAHUIMPUQUIO", "PAZOS", "QUISHUAR", "SALCABAMBA", "SALCAHUASI", "SAN MARCOS DE ROCCHAC", "SURCUBAMBA", "TINTAY PUNCU" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //HUANUCO
            if (selectedProvincia.Equals("HUANUCO"))
            {
                string[] distrito = { "HUANUCO", "AMARILIS", "CHINCHAO", "CHURUBAMBA", "MARGOS", "QUISQUI", "SAN FRANCISCO DE CAYRAN", "SAN PEDRO DE CHAULAN", "SANTA MARIA DEL VALLE", "YARUMAYO", "PILLCO MARCA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("AMBO"))
            {
                string[] distrito = { "AMBO", "CAYNA", "COLPAS", "CONCHAMARCA", "HUACAR", "SAN FRANCISCO", "SAN RAFAEL", "TOMAY KICHWA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("DOS DE MAYO"))
            {
                string[] distrito = { "LA UNION", "CHUQUIS", "MARIAS", "PACHAS", "QUIVILLA", "RIPAN", "SHUNQUI", "SILLAPATA", "YANAS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("HUACAYBAMBA"))
            {
                string[] distrito = { "HUACAYBAMBA", "CANCHABAMBA", "COCHABAMBA", "PINRA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("HUAMALIES"))
            {
                string[] distrito = { "LLATA", "ARANCAY", "CHAVIN DE PARIARCA", "JACAS GRANDE", "JIRCAN", "MIRAFLORES", "MONZON", "PUNCHAO", "PUÑOS", "SINGA", "TANTAMAYO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("LEONCIO PRADO"))
            {
                string[] distrito = { "RUPA-RUPA", "DANIEL ALOMIA ROBLES", "HERMILIO VALDIZAN", "JOSE CRESPO Y CASTILLO", "LUYANDO", "MARIANO DAMASO BERAUN" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("MARAÑON"))
            {
                string[] distrito = { "HUACRACHUCO", "CHOLON", "SAN BUENAVENTURA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("PACHITEA"))
            {
                string[] distrito = { "PANAO", "CHAGLLA", "MOLINO", "UMARI" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("PUERTO INCA"))
            {
                string[] distrito = { "PUERTO INCA", "CODO DEL POZUZO", "HONORIA", "TOURNAVISTA", "YUYAPICHIS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("LAURICOCHA"))
            {
                string[] distrito = { "JESUS", "BAÑOS", "JIVIA", "QUEROPALCA", "RONDOS", "SAN FRANCISCO DE ASIS", "SAN MIGUEL DE CAURI" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("YAROWILCA"))
            {
                string[] distrito = { "CHAVINILLO", "CAHUAC", "CHACABAMBA", "CHUPAN", "JACAS CHICO", "OBAS", "PAMPAMARCA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //ICA
            if (selectedProvincia.Equals("ICA"))
            {
                string[] distrito = { "ICA", "LA TINGUIÑA", "LOS AQUIJES", "OCUCAJE", "PACHACUTEC", "PARCONA", "PUEBLO NUEVO", "SALAS", "SAN JOSE DE LOS MOLINOS", "SAN JUAN BAUTISTA", "SANTIAGO", "SUBTANJALLA", "TATE", "YAUCA DEL ROSARIO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CHINCHA"))
            {
                string[] distrito = { "CHINCHA ALTA", "ALTO LARAN", "CHAVIN", "CHINCHA BAJA", "EL CARMEN", "GROCIO PRADO", "PUEBLO NUEVO", "SAN JUAN DE YANAC", "SAN PEDRO DE HUACARPANA", "SUNAMPE", "TAMBO DE MORA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("NAZCA"))
            {
                string[] distrito = { "NAZCA", "CHANGUILLO", "EL INGENIO", "MARCONA", "VISTA ALEGRE" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("PALPA"))
            {
                string[] distrito = { "PALPA", "LLIPATA", "RIO GRANDE", "SANTA CRUZ", "TIBILLO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("PISCO"))
            {
                string[] distrito = { "PISCO", "HUANCANO", "HUMAY", "INDEPENDENCIA", "PARACAS", "SAN ANDRES", "SAN CLEMENTE", "TUPAC AMARU INCA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //JUNIN
            if (selectedProvincia.Equals("HUANCAYO"))
            {
                string[] distrito = { "HUANCAYO", "CARHUACALLANGA", "CHACAPAMPA", "CHICCHE", "CHILCA", "CHONGOS ALTO", "CHUPURO", "COLCA", "CULLHUAS", "EL TAMBO", "HUACRAPUQUIO", "HUALHUAS", "HUANCAN", "HUASICANCHA", "HUAYUCACHI", "INGENIO", "PARIAHUANCA", "PILCOMAYO", "PUCARA", "QUICHUAY", "QUILCAS", "SAN AGUSTIN", "SAN JERONIMO DE TUNAN", "SAÑO", "SANTO DOMINGO DE ACOBAMBA", "SAPALLANGA", "SICAYA", "VIQUES" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CHANCHAMAYO"))
            {
                string[] distrito = { "CHANCHAMAYO", "PERENE", "PICHANAQUI", "SAN LUIS DE SHUARO", "SAN RAMON", "VITOC" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CONCEPCION"))
            {
                string[] distrito = { "CONCEPCION", "ACO", "ANDAMARCA", "CHAMBARA", "COCHAS", "COMAS", "HEROINAS TOLEDO", "MANZANARES", "MARISCAL CASTILLA", "MATAHUASI", "MITO", "NUEVE DE JULIO", "ORCOTUNA", "SAN JOSE DE QUERO", "SANTA ROSA DE OCOPA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("JUNIN"))
            {
                string[] distrito = { "JUNIN", "CARHUAMAYO", "ONDORES", "ULCUMAYO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("SATIPO"))
            {
                string[] distrito = { "SATIPO", "COVIRIALI", "LLAYLLA", "MAZAMARI", "PAMPA HERMOSA", "PANGOA", "RIO NEGRO", "RIO TAMBO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("JAUJA"))
            {
                string[] distrito = { "JAUJA", "ACOLLA", "APATA", "ATAURA", "CANCHAYLLO", "CURICACA", "EL MANTARO", "HUAMALI", "HUARIPAMPA", "HUERTAS", "JANJAILLO", "JULCAN", "LEONOR ORDOÑEZ", "LLOCLLAPAMPA", "MARCO", "MASMA", "MASMA CHICCHE", "MOLINOS", "MONOBAMBA", "MUQUI", "MUQUIYAUYO", "PACA", "PACCHA", "PANCAN", "PARCO", "POMACANCHA", "RICRAN", "SAN LORENZO", "SAN PEDRO DE CHUNAN", "SAUSA", "SINCOS", "TUNAN MARCA", "YAULI", "YAUYOS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("TARMA"))
            {
                string[] distrito = { "TARMA", "ACOBAMBA", "HUARICOLCA", "HUASAHUASI", "LA UNION", "PALCA", "PALCAMAYO", "SAN PEDRO DE CAJAS", "TAPO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("YAULI"))
            {
                string[] distrito = { "LA OROYA", "CHACAPALPA", "HUAY-HUAY", "MARCAPOMACOCHA", "MOROCOCHA", "PACCHA", "SANTA BARBARA DE CARHUACAYAN", "SANTA ROSA DE SACCO", "SUITUCANCHA", "YAULI" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CHUPACA"))
            {
                string[] distrito = { "CHUPACA", "AHUAC", "CHONGOS BAJO", "HUACHAC", "HUAMANCACA CHICO", "SAN JUAN DE YSCOS", "SAN JUAN DE JARPA", "TRES DE DICIEMBRE", "YANACANCHA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //LA LIBERTAD
            if (selectedProvincia.Equals("TRUJILLO"))
            {
                string[] distrito = { "TRUJILLO", "EL PORVENIR", "FLORENCIA DE MORA", "HUANCHACO", "LA ESPERANZA", "LAREDO", "MOCHE", "POROTO", "SALAVERRY", "SIMBAL", "VICTOR LARCO HERRERA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("ASCOPE"))
            {
                string[] distrito = { "ASCOPE", "CHICAMA", "CHOCOPE", "MAGDALENA DE CAO", "PAIJAN", "RAZURI", "SANTIAGO DE CAO", "CASA GRANDE" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("BOLIVAR"))
            {
                string[] distrito = { "BOLIVAR", "BAMBAMARCA", "CONDORMARCA", "LONGOTEA", "UCHUMARCA", "UCUNCHA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CHEPEN"))
            {
                string[] distrito = { "CHEPEN", "PACANGA", "PUEBLO NUEVO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("JULCAN"))
            {
                string[] distrito = { "JULCAN", "CALAMARCA", "CARABAMBA", "HUASO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("OTUZCO"))
            {
                string[] distrito = { "OTUZCO", "AGALLPAMPA", "CHARAT", "HUARANCHAL", "LA CUESTA", "MACHE", "PARANDAY", "SALPO", "SINSICAP", "USQUIL" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("GRAN CHIMU"))
            {
                string[] distrito = { "CASCAS", "LUCMA", "MARMOT", "SAYAPULLO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("VIRU"))
            {
                string[] distrito = { "VIRU", "CHAO", "GUADALUPITO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("PACASMAYO"))
            {
                string[] distrito = { "SAN PEDRO DE LLOC", "GUADALUPE", "JEQUETEPEQUE", "PACASMAYO", "SAN JOSE" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("PATAZ"))
            {
                string[] distrito = { "TAYABAMBA", "BULDIBUYO", "CHILLIA", "HUANCASPATA", "HUAYLILLAS", "HUAYO", "ONGON", "PARCOY", "PATAZ", "PIAS", "SANTIAGO DE CHALLAS", "TAURIJA", "URPAY" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("SANCHEZ CARRION"))
            {
                string[] distrito = { "HUAMACHUCO", "CHUGAY", "COCHORCO", "CURGOS", "MARCABAL", "SANAGORAN", "SARIN", "SARTIMBAMBA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("SANTIAGO DE CHUCO"))
            {
                string[] distrito = { "SANTIAGO DE CHUCO", "ANGASMARCA", "CACHICADAN", "MOLLEBAMBA", "MOLLEPATA", "QUIRUVILCA", "SANTA CRUZ DE CHUCA", "SITABAMBA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //LAMBAYEQUE
            if (selectedProvincia.Equals("CHICLAYO"))
            {
                string[] distrito = { "CHICLAYO", "CHONGOYAPE", "ETEN", "ETEN PUERTO", "JOSE LEONARDO ORTIZ", "LA VICTORIA", "LAGUNAS", "MONSEFU", "NUEVA ARICA", "OYOTUN", "PICSI", "PIMENTEL", "REQUE", "SANTA ROSA", "SAÑA", "SANTA ROSA", "CAYALTI", "PATAPO", "POMALCA", "PUCALA", "TUMAN" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("FERREÑAFE"))
            {
                string[] distrito = { "FERREÑAFE", "CAÑARIS", "INCAHUASI", "MANUEL ATONIO MESONES MURO", "PITIPO", "PUEBLO NUEVO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("LAMBAYEQUE"))
            {
                string[] distrito = { "LAMBAYEQUE", "CHOCHOPE", "ILLIMO", "JAYANCA", "MOCHUMI", "MORROPE", "MOTUPE", "OLMOS", "PACORA", "SALAS", "SAN JOSE", "TUCUME" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //LIMA  
            if (selectedProvincia.Equals("LIMA"))
            {
                string[] distrito = { "LIMA", "ANCON", "ATE", "BARRANCO", "BREÑA", "CARABAYLLO", "CHACLACAYO", "CHORRILLOS", "CIENEGUILLA", "COMAS", "EL AGUSTINO", "INDEPENDENCIA", "JESUS MARIA", "LA MOLINA", "LA VICTORIA", "LINCE", "LOS OLIVOS", "LURIGANCHO", "LURIN", "MAGDALENA DEL MAR", "MAGDALENA VIEJA", "MIRAFLORES", "PACHACAMAC", "PUCUSANA", "PUENTE PIEDRA", "PUNTA HERMOSA", "PUNTA NEGRA", "RIMAC", "SAN BARTOLO", "SAN BORJA", "SAN ISIDRO", "SAN JUAN DE LURIGANCHO", "SAN JUAN DE MIRAFLORES", "SAN LUIS", "SAN MARTIN DE PORRES", "SAN MIGUEL", "SANTA ANITA", "SANTA MARIA DEL MAR", "SANTA ROSA", "SANTIAGO DE SURCO", "SURQUILLO", "VILLA EL SALVADOR", "VILLA MARIA DEL TRIUNFO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("BARRANCA"))
            {
                string[] distrito = { "BARRANCA", "PARAMONGA", "PATIVILCA", "SUPE", "SUPE PUERTO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CAJATAMBO"))
            {
                string[] distrito = { "CAJATAMBO", "COPA", "GORGOR", "HUANCAPON", "MANAS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CAÑETE"))
            {
                string[] distrito = { "SAN VICENTE DE CAÑETE", "ASIA", "CALANGO", "CERRO AZUL", "CHILCA", "COAYLLO", "IMPERIAL", "LUNAHUANA", "MALA", "NUEVO IMPERIAL", "PACARAN", "QUILMANA", "SAN ANTONIO", "SAN LUIS", "SANTA CRUZ DE FLORES", "ZUÑIGA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CANTA"))
            {
                string[] distrito = { "CANTA", "ARAHUAY", "HUAMANTANGA", "HUAROS", "LACHAQUI", "SAN BUENAVENTURA", "SANTA ROSA DE QUIVES" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("HUARAL"))
            {
                string[] distrito = { "HUARAL", "ATAVILLOS ALTO", "ATAVILLOS ALTO", "AUCALLAMA", "CHANCAY", "IHUARI", "LAMPIAN", "PACARAOS", "SAN MIGUEL DE ACOS", "SANTA CRUZ DE ANDAMARCA", "SUMBILCA", "VEINTISIETE DE NOVIEMBRE" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("HUAROCHIRI"))
            {
                string[] distrito = { "MATUCANA", "ANTIOQUIA", "CALLAHUANCA", "CARAMPOMA", "CHICLA", "CUENCA", "HUACHUPAMPA", "HUANZA", "HUAROCHIRI", "LAHUAYTAMBO", "LANGA", "LARAOS", "MARIATANA", "RICARDO PALMA", "SAN ANDRES DE TUPICOCHA", "SAN ANTONIO", "SAN BARTOLOME", "SAN DAMIAN", "SAN JUAN DE IRIS", "SAN JUAN DE TANTARANCHE", "SAN LORENZO DE QUINTI", "SAN MATEO", "SAN MATEO DE OTAO", "SAN PEDRO DE CASTA", "SAN PEDRO DE HUANCAYRE", "SANGALLAYA", "SANTA CRUZ DE COCACHACRA", "SANTA EULALIA", "SANTIAGO DE ANCHUCAYA", "SANTIAGO DE TUNA", "SANTO DOMINGO DE LOS OLLEROS", "SURCO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("HUAURA"))
            {
                string[] distrito = { "HUACHO", "AMBAR", "CALETA DE CARQUIN", "CHECRAS", "HUALMAY", "HUAURA", "LEONCIO PRADO", "PACCHO", "SANTA LEONOR", "SANTA MARIA", "SAYAN", "VEGUETA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("OYON"))
            {
                string[] distrito = { "OYON", "ANDAJES", "CAUJUL", "COCHAMARCA", "NAVAN", "PACHANGARA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("YAUYOS"))
            {
                string[] distrito = { "YAUYOS", "ALIS", "AYAUCA", "AYAVIRI", "AZANGARO", "CACRA", "CARANIA", "CATAHUASI", "CHOCOS", "COCHAS", "COLONIA", "HONGOS", "HUAMPARA", "HUANCAYA", "HUANGASCAR", "HUANTAN", "HUAÑEC", "LARAOS", "LINCHA", "MADEAN", "MIRAFLORES", "OMAS", "PUTINZA", "QUINCHES", "QUINOCAY", "SAN JOAQUIN", "SAN PEDRO DE PILAS", "TANTA", "TAURIPAMPA", "TOMAS", "TUPE", "VIÑAC", "VITIS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CALLAO"))
            {
                string[] distrito = { "CALLAO", "BELLAVISTA", "CARMEN DE LA LEGUA REYNOSO", "LA PERLA", "LA PUNTA", "VENTANILLA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //LORETO
            if (selectedProvincia.Equals("MAYNAS"))
            {
                string[] distrito = { "IQUITOS", "ALTO NANAY", "FERNANDO LORES", "INDIANA", "LAS AMAZONAS", "MAZAN", "NAPO", "PUNCHANA", "PUTUMAYO", "TORRES CAUSANA", "BELEN", "SAN JUAN BAUTISTA", "TENIENTE MANUEL CAVERO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("ALTO AMAZONAS"))
            {
                string[] distrito = { "YURIMAGUAS", "BALSAPUERTO", "JEBEROS", "LAGUNAS", "SANTA CRUZ", "TENIENTE CESAR LOPEZ ROJAS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("DATEM DEL MARAÑON"))
            {
                string[] distrito = { "BARRANCA", "CAHUAPANAS", "MANSERICHE", "MORONA", "PASTAZA", "ANDOAS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("LORETO"))
            {
                string[] distrito = { "NAUTA", "PARINARI", "TIGRE", "TROMPETEROS", "URARINAS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("MARISCAL RAMON CASTILLA"))
            {
                string[] distrito = { "RAMON CASTILLA", "PEBAS", "YAVARI", "SAN PABLO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("REQUENA"))
            {
                string[] distrito = { "REQUENA", "ALTO TAPICHE", "CAPELO", "EMILIO SAN MARTIN", "MAQUIA", "PUINAHUA", "SAQUENA", "SOPLIN", "TAPICHE", "YAQUERANA", "JENARO HERRERA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("UCAYALI"))
            {
                string[] distrito = { "CONTAMANA", "INAHUAYA", "PADRE MARQUEZ", "PAMPA HERMOSA", "SARAYACU", "VARGAS GUERRA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //MADRE DE DIOS
            if (selectedProvincia.Equals("TAMBOPATA"))
            {
                string[] distrito = { "TAMBOPATA", "INAMBARI", "LAS PIEDRAS", "LABERINTO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("MANU"))
            {
                string[] distrito = { "FITZCARRALD", "MANU", "MADRE DE DIOS", "HEUPETUHE" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("TAHUAMANU"))
            {
                string[] distrito = { "IÑAPARI", "IBERIA", "TAHUAMANU" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //MOQUEGUA
            if (selectedProvincia.Equals("MARISCAL NIETO"))
            {
                string[] distrito = { "MOQUEGUA", "CARUMAS", "CUCHUMBAYA", "SAMEGUA", "SAN CRISTOBAL", "TORATA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("GENERAL SANCHEZ CERRO"))
            {
                string[] distrito = { "OMATE", "CHOJATA", "COALAQUE", "ICHUÑA", "LA CAPILLA", "LLOQUE", "MATALAQUE", "PUQUINA", "QUINISTAQUILLAS", "UBINAS", "YUNGA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("ILO"))
            {
                string[] distrito = { "ILO", "EL ALGARROBAL", "PACOCHA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //PASCO
            if (selectedProvincia.Equals("PASCO"))
            {
                string[] distrito = { "CHAUPIMARCA", "HUACHON", "HUARIACA", "HUAYLLAY", "NINACACA", "PALLANCHACRA", "PAUCARTAMBO", "SAN FCO.DE ASIS DE YARUSYACAN", "SIMON BOLIVAR", "TICLACAYAN", "TINYAHUARCO", "VICCO", "YANACANCHA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("DANIEL ALCIDES CARRION"))
            {
                string[] distrito = { "YANAHUANCA", "CHACAYAN", "GOYLLARISQUIZGA", "PAUCAR", "SAN PEDRO DE PILLAO", "SANTA ANA DE TUSI", "TAPUC", "VILCABAMBA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("OXAPAMPA"))
            {
                string[] distrito = { "OXAPAMPA", "CHONTABAMBA", "HUANCABAMBA", "PALCAZU", "POZUZO", "PUERTO BERMUDEZ", "VILLA RICA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //PIURA
            if (selectedProvincia.Equals("PIURA"))
            {
                string[] distrito = { "PIURA", "CASTILLA", "CATACAOS", "CURA MORI", "EL TALLAN", "LA ARENA", "LA UNION", "LAS LOMAS", "TAMBO GRANDE" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("AYABACA"))
            {
                string[] distrito = { "AYABACA", "FRIAS", "JILILI", "LAGUNAS", "MONTERO", "PACAIPAMPA", "PAIMAS", "SAPILLICA", "SICCHEZ", "SUYO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("HUANCABAMBA"))
            {
                string[] distrito = { "HUANCABAMBA", "CANCHAQUE", "EL CARMEN DE LA FRONTERA", "HUARMACA", "LALAQUIZ", "SAN MIGUEL DE EL FAIQUE", "SONDOR", "SONDORILLO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("PAITA"))
            {
                string[] distrito = { "PAITA", "AMOTAPE", "ARENAL", "COLAN", "LA HUACA", "TAMARINDO", "VICHAYAL" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("MORROPON"))
            {
                string[] distrito = { "CHULUCANAS", "BUENOS AIRES", "CHALACO", "LA MATANZA", "MORROPON", "SALITRAL", "SAN JUAN DE BIGOTE", "SANTA CATALINA DE MOSSA", "SANTO DOMINGO", "YAMANGO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("SECHURA"))
            {
                string[] distrito = { "SECHURA", "BELLAVISTA LA UNION", "BERNAL", "CRISTO NOS VALGA", "RINCONADA LLICUAR", "VICE" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("SULLANA"))
            {
                string[] distrito = { "SULLANA", "BELLAVISTA", "IGNACIO ESCUDERO", "LANCONES", "MARCAVELICA", "MIGUEL CHECA", "QUERECOTILLO", "SALITRAL" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("TALARA"))
            {
                string[] distrito = { "PARIÑAS", "EL ALTO", "LA BREA", "LOBITOS", "LOS ORGANOS", "MANCORA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //PUNO
            if (selectedProvincia.Equals("PUNO"))
            {
                string[] distrito = { "PUNO", "ACORA", "AMANTANI", "ATUNCOLLA", "CAPACHICA", "CHUCUITO", "COATA", "HUATA", "MAÑAZO", "PAUCARCOLLA", "PICHACANI", "PLATERIA", "SAN ANTONIO", "TIQUILLACA", "VILQUE" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("AZANGARO"))
            {
                string[] distrito = { "AZANGARO", "ACHAYA", "ARAPA", "ASILLO", "CAMINACA", "CHUPA", "JOSE DOMINGO CHOQUEHUANCA", "MUÑANI", "POTONI", "SAMAN", "SAN ANTON", "SAN JOSE", "SAN JUAN DE SALINAS", "SANTIAGO DE PUPUJA", "TIRAPATA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CARABAYA"))
            {
                string[] distrito = { "MACUSANI", "AJOYANI", "AYAPATA", "COASA", "CORANI", "CRUCERO", "ITUATA", "OLLACHEA", "SAN GABAN", "USICAYOS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CHUCUITO"))
            {
                string[] distrito = { "JULI", "DESAGUADERO", "HUACULLANI", "KELLUYO", "PISACOMA", "POMATA", "ZEPITA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("EL COLLAO"))
            {
                string[] distrito = { "ILAVE", "CAPAZO", "PILCUYO", "SANTA ROSA", "CONDURIRI" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("HUANCANE"))
            {
                string[] distrito = { "HUANCANE", "COJATA", "HUATASANI", "INCHUPALLA", "PUSI", "ROSASPATA", "TARACO", "VILQUE CHICO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("LAMPA"))
            {
                string[] distrito = { "LAMPA", "CABANILLA", "CALAPUJA", "NICASIO", "OCUVIRI", "PALCA", "PARATIA", "PUCARA", "SANTA LUCIA", "VILAVILA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("MELGAR"))
            {
                string[] distrito = { "AYAVIRI", "ANTAUTA", "CUPI", "LLALLI", "MACARI", "NUÑOA", "ORURILLO", "SANTA ROSA", "UMACHIRI" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("MOHO"))
            {
                string[] distrito = { "MOHO", "CONIMA", "HUAYRAPATA", "TILALI" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("SAN ANTONIO DE PUTINA"))
            {
                string[] distrito = { "PUTINA", "ANANEA", "PEDRO VILCA APAZA", "QUILCAPUNCU", "SINA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("SAN ROMAN"))
            {
                string[] distrito = { "JULIACA", "CABANA", "CABANILLAS", "CARACOTO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("SANDIA"))
            {
                string[] distrito = { "SANDIA", "CUYOCUYO", "LIMBANI", "PATAMBUCO", "PHARA", "QUIACA", "SAN JUAN DEL ORO", "YANAHUAYA", "ALTO INAMBARI" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("YUNGUYO"))
            {
                string[] distrito = { "YUNGUYO", "ANAPIA", "COPANI", "CUTURAPI", "OLLARAYA", "TINICACHI", "UNICACHI" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //SAN MARTIN
            if (selectedProvincia.Equals("BELLAVISTA"))
            {
                string[] distrito = { "BELLAVISTA", "ALTO BIAVO", "BAJO BIAVO", "HUALLAGA", "SAN PABLO", "SAN RAFAEL" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("HUALLAGA"))
            {
                string[] distrito = { "SAPOSOA", "ALTO SAPOSOA", "EL ESLABON", "PISCOYACU", "SACANCHE", "TINGO DE SAPOA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("LAMAS"))
            {
                string[] distrito = { "LAMAS", "ALONSO DE ALVARA", "BARRANQUITA", "CAYNARACHI", "CUÑUMBUQUI", "PINTO RECODO", "RUMISAPA", "SAN ROQUE DE CUMBAZA", "SHANAO", "TABALOSOS", "ZAPATERO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("MARISCAL CACERES"))
            {
                string[] distrito = { "JUANJUI", "CAMPANILLA", "HUICUNGO", "PACHIZA", "PAJARILLO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("MOYOBAMBA"))
            {
                string[] distrito = { "MOYOBAMBA", "CALZADDA", "HABANA", "JEPELACIO", "SORITOR", "YANTALO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("PICOTA"))
            {
                string[] distrito = { "PICOTA", "BUENOS AIRES", "CASPISAPA", "PILLUANA", "PUCACACA", "SAN CRISTOBAL", "	SAN HILARION", "SHAMBOYACU", "TINGO DE PONASA", "TRES UNIDOS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("RIOJA"))
            {
                string[] distrito = { "RIOJA", "AWAJUN", "ELIAS SOPLIN VARGAS", "NUEVA CAJAMARCA", "PARDO MIGUEL", "POSIC", "SAN FERNANDO", "YORONGOS", "YURACYACU" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("SAN MARTIN"))
            {
                string[] distrito = { "TARAPOTO", "ALBERTO LEVEAU", "CACATACHI", "CHAZUTA", "CHIPURANA", "EL PORVENIR", "HUMBAYOC", "JUAN GUERRA", "LA BANDA DE SHILCAYO", "MORALES", "PAPAPLAYA", "SAN ANTONIO", "SAUCE", "SHAPAJA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("TOCACHE"))
            {
                string[] distrito = { "TOCACHE", "NUEVO PROGRESO", "POLVORA", "SHUNTE", "UCHIZA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("EL DORADO"))
            {
                string[] distrito = { "SAN JOSE DE SISA", "AGUA BLANCA", "SAN MARTIN", "SANTA ROSA", "SHATOJA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //TACNA
            if (selectedProvincia.Equals("TACNA"))
            {
                string[] distrito = { "TACNA", "ALTO DE LA ALIANZA", "CALANA", "INCLAN", "PACHIA", "PALCA", "POCOLLAY", "SAMA", "CIUDAD NUEVA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("CANDARAVE"))
            {
                string[] distrito = { "CANDARAVE", "CAIRANI", "CAMILACA", "CURIBAYA", "HUANUARA", "QUILAHUANI" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("JORGE BASADRE"))
            {
                string[] distrito = { "LOCUMBA", "ILABAYA", "ITE" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("TARATA"))
            {
                string[] distrito = { "TARATA", "CHUCATAMANI", "ESTIQUE", "ESTIQUE-PAMPA", "SITAJARA", "SUSAPAYA", "TARUCACHI", "TICACO" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //TUMBES
            if (selectedProvincia.Equals("CONTRALMIERANTE VILLAR"))
            {
                string[] distrito = { "ZORRITOS", "CASITAS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("TUMBES"))
            {
                string[] distrito = { "TUMBES", "CORRALES", "LA CRUZ", "PAMPAS DE HOSPITAL", "SAN JACINTO", "SAN JUAN DE LA VIRGEN" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("ZARUMILLA"))
            {
                string[] distrito = { "ZARUMILLA", "AGUAS VERDES", "MATAPALO", "PAPAYAL" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }

            //UCAYALI
            if (selectedProvincia.Equals("CORONEL PORTILLO"))
            {
                string[] distrito = { "CALLARIA", "CAMPOVERDE", "IPARIA", "MASISEA", "YARINACOCHA", "NUEVA REQUENA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("ATALAYA"))
            {
                string[] distrito = { "RAYMONDI", "SEPAHUA", "TAHUANIA", "YURUA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("PADRE ABAD"))
            {
                string[] distrito = { "PADRE ABAD", "IRAZOLA", "CURIMANA" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }
            if (selectedProvincia.Equals("PURUS"))
            {
                string[] distrito = { "PURUS" };
                cargarComboBox(this.CBDISTRITOALU, distrito);
            }




        }
        //METODO PARA LLENAR LOS ELEMENTOS DE UN ARREGLO A UN COMBOBOX
        private void cargarComboBox(ComboBox combo, string[] arreglo)
        {
            combo.Items.Clear();
            for (int i = 0; i < arreglo.Length; i++)
            {
                combo.Items.Add(arreglo[i]);
            }
        }
        //BOTON PARA CARGAR Y PREVISUALIZAR IMAGEN
        private void BTNFOTOALU_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FOTOALUMNO.SizeMode = PictureBoxSizeMode.StretchImage;
                FOTOALUMNO.Image = Image.FromFile(dialog.FileName);
            }
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
                        ERRORCAMPOSVACIOS.SetError(txt, "INGRESA DATO");
                    }
                }
                if (ctrl is ComboBox)
                {
                    ComboBox cb = ctrl as ComboBox;
                    if (string.IsNullOrEmpty(cb.Text))
                    {
                        ok = false;
                        ERRORCAMPOSVACIOS.SetError(cb, "SELECCIONA UNA OPCION");
                    }
                }
            }
            if (TXTDNIALU.Text.Trim().Length != 8) {
                ok = false;
                ERRORCAMPOSVACIOS.SetError(TXTDNIALU, "EL DNI TIENE 8 DIGITOS");
            }
            if (TXTTLFALU.Text.Trim().Length != 7) {
                ok = false;
                ERRORCAMPOSVACIOS.SetError(TXTTLFALU, "EL TELEFONO TIENE 7 DIGITOS");
            }
            if (TXTCELUALU.Text.Trim().Length != 9) {
                ok = false;
                ERRORCAMPOSVACIOS.SetError(TXTCELUALU, "EL CELULAR TIENE 9 DIGITOS");
            }
            if (RBMASCULINOALU.Checked == false && RBFEMENINOALU.Checked == false)
            {
                ok = false;
                ERRORCAMPOSVACIOS.SetError(panel1, "SELECCIONA SEXO");
            }
            if (FOTOALUMNO.Image == null)
            {
                ok = false;
                ERRORCAMPOSVACIOS.SetError(BTNFOTOALU, "INGRESA LA FOTO DEL TRABAJADOR");
            }
            if (RBALUPARTICULAR.Checked == true) {                
                if (RBUNIVERSIDADALU.Checked == false && RBCOLEGIOALU.Checked == false && RBNINGUNOALU.Checked == false) {
                    ok = false;
                    ERRORCAMPOSVACIOS.SetError(label20, "SELECCIONA UNA DE LAS OPCIONES");
                }
                if (RBUNIVERSIDADALU.Checked == true || RBCOLEGIOALU.Checked == true) {
                    if (string.IsNullOrEmpty(CBCENTRODEESTUDIOS.Text)) {
                        ok = false;
                        ERRORCAMPOSVACIOS.SetError(CBCENTRODEESTUDIOS, "SELECCIONE EL CENTRO DE ESTUDIO");
                    }
                }                
            }
            if (RBALUFAUSTINIANO.Checked == true) {
                if (string.IsNullOrEmpty(CBFACULTADALU.Text))
                {
                    ok = false;
                    ERRORCAMPOSVACIOS.SetError(CBFACULTADALU, "SELECCIONA LA FACULTAD");
                }
                if (string.IsNullOrEmpty(CBESCUELAALU.Text))
                {
                    ok = false;
                    ERRORCAMPOSVACIOS.SetError(CBESCUELAALU, "SELECCIONA LA ESCUELA ACADEMICA");
                }
            }
            if (RBALUFAUSTINIANO.Checked == false && RBALUPARTICULAR.Checked == false) {
                ok = false;
                ERRORCAMPOSVACIOS.SetError(panel2, "SELECCIONA UNA OPCION");
            }
            if (TXTDNIALU.Text.Length == 8) {
                try {
                    SqlCommand cmd = new SqlCommand("verificar_dni", _SqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (cmd.Connection.State == ConnectionState.Closed)
                    {
                        cmd.Connection.Open();
                    }
                    cmd.Parameters.Add(new SqlParameter("@dni", TXTDNIALU.Text));
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {                        
                        if (dt.Rows[0][0].ToString() == "1") {
                            ok = false;
                            ERRORCAMPOSVACIOS.SetError(TXTDNIALU, "ESTE NUMERO DE DNI YA EXISTE!!!");
                        }                            
                    }
                    if (cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                    }
                } catch (Exception ex) { }
            }
            return ok;
        }
        //BORRAR MENSAJES DE ERROR
        private void BORRAR_MENSAJE_ERROR()
        {
            foreach (Control cr in this.Controls)
            {
                ERRORCAMPOSVACIOS.SetError(cr, null);
            }
            ERRORCAMPOSVACIOS.SetError(label20, null);
        }        
        private void BTNGUARDARALU_Click(object sender, EventArgs e)
        {
            BORRAR_MENSAJE_ERROR();
            if (VALIDAR_NO_VACIOS()) {                                                  
                try
                {                            
                    SqlCommand comando = new SqlCommand("insert_alumno", _SqlConnection);
                    comando.CommandType = CommandType.StoredProcedure;                    
                    if (comando.Connection.State == ConnectionState.Closed)
                    {
                        comando.Connection.Open();
                    }                    
                    var TIPOALUMNOCHOSEN = panel2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                    var SEXOCHOSEN = panel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                    String tipoAlumno = TIPOALUMNOCHOSEN.Text;
                    String sexoAlumno = SEXOCHOSEN.Text;
                            
                    comando.Parameters.Add(new SqlParameter("@tipoAlumno", tipoAlumno));
                    comando.Parameters.Add(new SqlParameter("@dni", TXTDNIALU.Text.Trim()));
                    comando.Parameters.Add(new SqlParameter("@nombre", TXTNOMBRESALU.Text.Trim()));
                    comando.Parameters.Add(new SqlParameter("@apaterno", TXTPATERNOALU.Text.Trim()));
                    comando.Parameters.Add(new SqlParameter("@amaterno", TXTMATERNOALU.Text.Trim()));
                    comando.Parameters.Add(new SqlParameter("@distrito", CBDISTRITOALU.SelectedItem.ToString()));
                    comando.Parameters.Add(new SqlParameter("@provincia", CBPROVINCIAALU.SelectedItem.ToString()));
                    comando.Parameters.Add(new SqlParameter("@direccion", TXTDIRECCIONALU.Text.Trim()));
                    comando.Parameters.Add(new SqlParameter("@departamento", CBDEPARTAMENTOSALU.SelectedItem.ToString()));
                    comando.Parameters.Add(new SqlParameter("@procedencia", TXTPROCEDENCIAALU.Text.Trim()));
                    comando.Parameters.Add(new SqlParameter("@sexo", sexoAlumno));
                    comando.Parameters.Add(new SqlParameter("@celular", TXTCELUALU.Text.Trim()));
                    comando.Parameters.Add(new SqlParameter("@edad", TXTEDADALU.Text));
                    comando.Parameters.Add(new SqlParameter("@gradoinstruccion", CBINSTRUCCIONALU.SelectedItem.ToString()));
                    comando.Parameters.Add(new SqlParameter("@telefono", TXTTLFALU.Text.Trim()));
                    comando.Parameters.Add(new SqlParameter("@correoelectronico", TXTCORREOALU.Text.Trim()));
                    comando.Parameters.Add(new SqlParameter("@fechanacimiento", TIMEPICKERNACIMIENTOALU.Value));
                    if (PANELFAUSTINO.Visible == true)
                    {
                        String FACULTAD = ((DataRowView)CBFACULTADALU.SelectedItem)["facultad"].ToString();
                        String ESCUELA =  ((DataRowView)CBESCUELAALU.SelectedItem)["escuela"].ToString();
                        comando.Parameters.Add(new SqlParameter("@facultad", FACULTAD));
                        comando.Parameters.Add(new SqlParameter("@escuela", ESCUELA));
                    }                                    
                    if (PANELPARTICULAR.Visible == true)
                    {
                        if (RBCOLEGIOALU.Checked == true)
                        {
                            String COLEGIO = ((DataRowView)CBCENTRODEESTUDIOS.SelectedItem)["nombreColegio"].ToString();
                            comando.Parameters.Add(new SqlParameter("@nombreColegio", COLEGIO));                            
                        }
                        if (RBUNIVERSIDADALU.Checked == true)
                        {
                            String UNIVERSIDAD = ((DataRowView)CBCENTRODEESTUDIOS.SelectedItem)["nombreUniversidad"].ToString();
                            comando.Parameters.Add(new SqlParameter("@nombreUniversidad", UNIVERSIDAD));                            
                        }                        
                    }                   
                    comando.Parameters.Add("@foto", System.Data.SqlDbType.Image);                    
                    //asignando el valor de la imagen
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    //se guarda la imagen en el buffer
                    FOTOALUMNO.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //se extraen los bytes del buffer para asignarlos como valor para el parametro
                    comando.Parameters["@foto"].Value = ms.GetBuffer();
                    comando.ExecuteNonQuery();                    
                    LIMPIAR_DATA_REGISTRO();                    
                     if (comando.Connection.State == ConnectionState.Open)
                    {
                        comando.Connection.Close();
                    }
                    MessageBox.Show("Registro guardado");         
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally {
                  
                }
            }
        }
        private void LIMPIAR_DATA_REGISTRO()
        {
            foreach (Control cr in this.Controls)
            {
                if (cr is TextBox)
                {
                    TextBox txt = cr as TextBox;
                    txt.Text = null;
                }
            }
            RBFEMENINOALU.Checked = false;
            RBMASCULINOALU.Checked = false;
            FOTOALUMNO.Image = null;
            /*
            var TIPOALUMNOCHOSEN = panel2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            TIPOALUMNOCHOSEN.Checked = false;
            var LUGARCHOSEN = PANELPARTICULAR.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            LUGARCHOSEN.Checked = false;
            */
        }
        private void BTNAGREGARCENTROESTUDIO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximante");
        }
    }
}
