using InstitutoDeIdiomas.ReportForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDeIdiomas
{
    public partial class frmMainMenu : Form
    {
        String idCodigo;
        String nombreUsuario;
        public frmMainMenu(String id, String nombre)
        {
            InitializeComponent();
            TXTBIENBUSER.Text = nombre;
            TXTCODUSER.Text = id;
            idCodigo = id;
            nombreUsuario = nombre;
        }

        private void REGISTRARMENU_Click(object sender, EventArgs e)
        {
            new frmRegistrarAlumnos(idCodigo).Show();
        }

        private void REGISTRARPAGOMENU_Click(object sender, EventArgs e)
        {
            new frmCrearPago(idCodigo).Show();
        }

        private void CONSULTARMENU_Click(object sender, EventArgs e)
        {
            new frmConsultarAlumno(idCodigo).Show();
        }

        private void GENERALCONSMENU_Click(object sender, EventArgs e)
        {
            new frmConsultarPago().Show();
        }

        private void cREARPAGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new Form1().Show();
        }

        private void crearGrupo_Click(object sender, EventArgs e)
        {
            new frmCrearGrupo().Show();
        }

        private void agregarAlumnosAGrupo_Click(object sender, EventArgs e)
        {
            new frmVerGrupoAgregarAlumno(1).Show();
        }

        private void cREARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistrar forma = new frmRegistrar();
            forma.Show();
        }
        

        private void verGrupo_Click(object sender, EventArgs e)
        {
            new frmVerGrupoAgregarAlumno(2).Show();
        }

        private void FICHAMATRICULATOOL_Click(object sender, EventArgs e)
        {
            new frmGenerarFichaMatricula().Show();
        }

        private void DEUDORESCONSMENU_Click(object sender, EventArgs e)
        {
            new frmConsultarDeudores().Show();
        }

        private void REPORTEMENUTOOL_Click(object sender, EventArgs e)
        {
            new frmRptReporte().Show();
        }

        private void ACTUALIZAROPTIONMENU_Click(object sender, EventArgs e)
        {
            new frmActualizarAlumno().Show();
        }
    }
}
