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
    public partial class frmPagarMatricula : Form
    {
        private frmRegistrarPago m_frm;
        public frmPagarMatricula(frmRegistrarPago frm)
        {
            InitializeComponent();
            m_frm = frm;
        }

        private void BTNMATCANCELAR_Click(object sender, EventArgs e)
        {
            UNCHECK_CB_MATRICULA();
            this.Close();           
            
        }

        private void BTNMATACEPTAR_Click(object sender, EventArgs e)
        {
            if (SELECCIONASTE_CAMPOS()) {
                var rbmod = GBMODALIDADMATRICULA.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                var rbidi = GBIDIOMA.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                var rbniv = GBNIVEL.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);                
                string mod = rbmod.Text.ToString();
                string idio = rbidi.Text.ToString();
                string niv = rbniv.Text.ToString();
                string cic = NUMCICLO.Value.ToString();
                m_frm.CARGARDATOS(mod, idio, niv, cic);
                this.Close();
                
            }
        }
        private bool SELECCIONASTE_CAMPOS() {
            bool ok = true;

            if (RBMATREGULAR.Checked == false && RBMATUBICACION.Checked == false) {
                ok = false;
                FALTACOMPLETARERROR.SetError(GBMODALIDADMATRICULA, "SELECCIONA UNA MODALIDAD");
            }
            if (RBINGLES.Checked == false && RBITALIANO.Checked == false && RBFRANCES.Checked == false && RBPORTUGUES.Checked == false && RBALEMAN.Checked == false && RBQUECHUA.Checked == false && RBCHINO.Checked == false && RBOTRO.Checked == false) {
                ok = false;
                FALTACOMPLETARERROR.SetError(GBIDIOMA, "SELECCIONA UN IDIOMA");
            }
            if (RBBASICO.Checked == false && RBINTERMEDIO.Checked == false && RBAVANZADO.Checked == false) {
                ok = false;
                FALTACOMPLETARERROR.SetError(GBNIVEL, "SELECCIONA UN NIVEL");
            }
            return ok;
        }
        private void UNCHECK_CB_MATRICULA() {
            m_frm.CBPAGARMATRICULA.CheckState = CheckState.Unchecked;
        }
    }
}
