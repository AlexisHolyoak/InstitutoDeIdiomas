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
    public partial class frmRptActaFinal : Form
    {
        DataTable _list;
        String ano, idioma, ciclo, docente, mes, nivel, aprobados, desaprobados, totalEstudiantes, diaActual, mesActual, anoActual;
        public frmRptActaFinal(DataTable dt, String _ano, String _idioma, String _ciclo, String _docente, String _mes,
            String _nivel, String _aprobados, String _desaprobados, String _totalEstudiantes)
        { 
            InitializeComponent();
            _list = dt;
            ano = _ano;
            idioma = _idioma;
            ciclo = _ciclo;
            docente = _docente;
            mes = _mes;
            nivel = _nivel;
            aprobados = _aprobados;
            desaprobados = _desaprobados;
            totalEstudiantes = _totalEstudiantes;
            diaActual = DateTime.Now.ToString("dd");
            mesActual = DateTime.Now.ToString("MMMMM");
            anoActual = DateTime.Now.ToString("yyyy");
        }

        private void frmRptActaFinal_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DataSet1", _list);
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
           {
                new Microsoft.Reporting.WinForms.ReportParameter("pAno",ano),
                new Microsoft.Reporting.WinForms.ReportParameter("pIdioma",idioma),
                new Microsoft.Reporting.WinForms.ReportParameter("pCiclo",ciclo),
                new Microsoft.Reporting.WinForms.ReportParameter("pDocente",docente),
                new Microsoft.Reporting.WinForms.ReportParameter("pMes",mes),
                new Microsoft.Reporting.WinForms.ReportParameter("pNivel",nivel),
                new Microsoft.Reporting.WinForms.ReportParameter("pAprobados",aprobados),
                new Microsoft.Reporting.WinForms.ReportParameter("pDesaprobados",desaprobados),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalEstudiantes",totalEstudiantes),
                new Microsoft.Reporting.WinForms.ReportParameter("pDiaActual",diaActual),
                new Microsoft.Reporting.WinForms.ReportParameter("pMesActual",mesActual),
                new Microsoft.Reporting.WinForms.ReportParameter("pAnoActual",anoActual)
           };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
