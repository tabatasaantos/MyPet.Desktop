using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPet.UI
{
    public partial class frmCampanha : Form
    {
        public frmCampanha()
        {
            InitializeComponent();
        }

        private void frmCampanha_Load(object sender, EventArgs e)
        {
            btnIncluir.Focus();
        }

        public void PreparaInclusaoCampanha()
        {
            btnIncluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            txtIDCampanha.Text = "[AUTOMATICO]";
            txtIDAnimalCampanha.Text = "[AUTOMATICO]";
            txtIDResponsavelCampanha.Text = "[AUTOMATICO]";
            txtValorCampanha.Focus();
            btnIncluir.Enabled = true;
        }
        public void LimparCamposCampanha()
        {
            txtIDCampanha.Clear();
            txtIDAnimalCampanha.Clear();
            txtIDResponsavelCampanha.Clear();
            txtValorCampanha.Clear();
            mskDataInicialCampanha.Clear();
            mskDataFinalCampanha.Clear();
            txtSituacaoCampanha.Clear();
            txtDescricaoCampanha.Clear();
            btnIncluir.Enabled = true;
            txtValorCampanha.Focus();
        }

        public void AposSalvarCampanha()
        {
            MessageBox.Show("Registro Salvo");
            LimparCamposCampanha();
            PreparaInclusaoCampanha();
        }

        public void AposExcluirCampanha()
        {

        }
        public void AposCancelarCampanha()
        {
            LimparCamposCampanha();
            frmCampanha_Load(null, null);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            PreparaInclusaoCampanha();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AposSalvarCampanha();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AposCancelarCampanha();
        }

    }
}
