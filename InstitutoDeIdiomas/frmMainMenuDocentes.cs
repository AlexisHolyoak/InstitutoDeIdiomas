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
    public partial class frmMainMenuDocentes : Form
    {
        String id;
        public frmMainMenuDocentes(String id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void CREARGRUPOMENU_Click(object sender, EventArgs e)
        {
            frmCrearGrupo crearGrupo = new frmCrearGrupo();
            crearGrupo.Show();
        }

        private void REGISTROAUXMENU_Click(object sender, EventArgs e)
        {
            frmSeleccionarGrupo selectGrupo = new frmSeleccionarGrupo(id);
            selectGrupo.Show();
        }

        private void NOTASMENU_Click(object sender, EventArgs e)
        {

        }
    }
}
