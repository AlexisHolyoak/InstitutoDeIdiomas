using InstitutoDeIdiomas.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDeIdiomas.ReportForms
{
    public partial class frmRptFichaMatricula : Form
    {
        string _apellidos, _nombres, _dni, _sexo, _fechanacimiento, _edad, _gradoinstruccion, _telefono, _celular,
            _correo, _direccion, _distrito, _provincia, _departamento, _idioma, _nivel, _ciclo, _fecha, _resposable, _numerorecibo,
            _monto, _modalidad, _observaciones,_codigoAlumno;
        DataTable dtfoto;
        public frmRptFichaMatricula(string apellidos, string nombres, string dni, string sexo, string fechanacimiento, string edad, string gradoinstruccion,
            string telefono, string celular, string correo, string direccion, string distrito, string provincia, string departamento, string idioma,
            string nivel, string ciclo, string fecha, string responsable, string numerorecibo, string monto, string modalidad,DataTable dtalupic, string observaciones, string codigoAlumno)
        {
            InitializeComponent();
            _apellidos = apellidos;
            _nombres = nombres;
            _dni = dni;
            _sexo = sexo;
            _fechanacimiento = fechanacimiento;
            _edad = edad;
            _gradoinstruccion = gradoinstruccion;
            _telefono = telefono;
            _celular = celular;
            _correo = correo;
            _direccion = direccion;
            _distrito = distrito;
            _provincia = provincia;
            _departamento = departamento;
            _idioma = idioma;
            _nivel = nivel;
            _ciclo = ciclo;
            _fecha = fecha;
            _resposable = responsable;
            _numerorecibo = numerorecibo;
            _monto = monto;
            _modalidad = modalidad;
            dtfoto = dtalupic;
            _observaciones = observaciones;
            _codigoAlumno = codigoAlumno;
        }

        private void frmRptFichaMatricula_Load(object sender, EventArgs e)
        {
            
            ReportDataSource rds = new ReportDataSource("dsImagenesDelAlumnado", dtfoto);
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[] {
                new Microsoft.Reporting.WinForms.ReportParameter("pApellidos",_apellidos),
                new Microsoft.Reporting.WinForms.ReportParameter("pNombres",_nombres),
                new Microsoft.Reporting.WinForms.ReportParameter("pDNI",_dni),
                new Microsoft.Reporting.WinForms.ReportParameter("pSexo", _sexo),
                new Microsoft.Reporting.WinForms.ReportParameter("pFechaNacimiento",_fechanacimiento),
                new Microsoft.Reporting.WinForms.ReportParameter("pEdad",_edad),
                new Microsoft.Reporting.WinForms.ReportParameter("pGradoInstruccion",_gradoinstruccion),
                new Microsoft.Reporting.WinForms.ReportParameter("pTelefono",_telefono),
                new Microsoft.Reporting.WinForms.ReportParameter("pCelular",_celular),
                new Microsoft.Reporting.WinForms.ReportParameter("pCorreo",_correo),
                new Microsoft.Reporting.WinForms.ReportParameter("pDireccion",_direccion),
                new Microsoft.Reporting.WinForms.ReportParameter("pDistrito",_distrito),
                new Microsoft.Reporting.WinForms.ReportParameter("pProvincia",_provincia),
                new Microsoft.Reporting.WinForms.ReportParameter("pDepartamento",_departamento),
                new Microsoft.Reporting.WinForms.ReportParameter("pIdioma",_idioma),
                new Microsoft.Reporting.WinForms.ReportParameter("pNivel",_nivel),
                new Microsoft.Reporting.WinForms.ReportParameter("pCiclo",_ciclo),
                new Microsoft.Reporting.WinForms.ReportParameter("pFecha",_fecha),
                new Microsoft.Reporting.WinForms.ReportParameter("pResponsable",_resposable),
                new Microsoft.Reporting.WinForms.ReportParameter("pNumeroRecibo",_numerorecibo),
                new Microsoft.Reporting.WinForms.ReportParameter("pMonto",_monto),
                new Microsoft.Reporting.WinForms.ReportParameter("pModalidad",_modalidad),
                new Microsoft.Reporting.WinForms.ReportParameter("pObservaciones",_observaciones),
                new Microsoft.Reporting.WinForms.ReportParameter("pCodigoAlumno",_codigoAlumno)
            };            
            this.FICHAMATRICULARPT.LocalReport.SetParameters(para);
            this.FICHAMATRICULARPT.LocalReport.DataSources.Add(rds);
            this.FICHAMATRICULARPT.LocalReport.DisplayName = _apellidos+" "+_nombres;
            this.FICHAMATRICULARPT.RefreshReport();
            
        }
    }
}
