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
    public partial class frmRptListaDePagos : Form
    {
        DataTable tabledata;
        DataTable alumno;
        public frmRptListaDePagos(DataTable dt,DataTable dtal)
        {
            InitializeComponent();
            tabledata = dt;
            alumno = dtal;
        }

        private void frmRptListaDePagos_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("dsListado",tabledata);
            ReportDataSource rds1 = new ReportDataSource("dsAlumno", alumno);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
    }
}
