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
    public partial class frmEspecie : Form
    {
        public frmEspecie()
        {
            InitializeComponent();
        }

        private void frmEspecie_Load(object sender, EventArgs e)
        {
            btnIncluir.Focus();
        }

        public void PreparaInclusao()
        {
            btnIncluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            txtIDEspecie.Text = "[AUTOMATICO]";
            txtDescricaoEspecie.Focus();
            btnIncluir.Enabled = true;
        }
        public void LimparCampos()
        {
            txtIDEspecie.Clear();
            txtDescricaoEspecie.Clear();
            txtCaracteristicaEspecie.Clear();
            btnIncluir.Enabled = true;
            txtDescricaoEspecie.Focus();
        }

        public void AposSalvar()
        {
            MessageBox.Show("Registro Salvo");
            LimparCampos();
            PreparaInclusao();
        }

        public void AposExcluir()
        {

        }
        public void AposCancelar()
        {
            LimparCampos();
            frmEspecie_Load(null, null);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            PreparaInclusao();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // chamar o metodo que salkva no banco

            //chamar o metodo que prepara a tela
            AposSalvar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AposCancelar();
        }
    }
}
