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
    public partial class frmAnimal : Form
    {
        public frmAnimal()
        {
            InitializeComponent();
        }

        private void frmAnimal_Load(object sender, EventArgs e)
        {
            btnIncluir.Focus();
        }

        public void PreparaInclusao()
        {
            btnIncluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            txtIDAnimal.Text = "[AUTOMATICO]";
            txtNomeAnimal.Focus();
            btnIncluir.Enabled = true;
        }
        public void LimparCampos()
        {
            txtIDAnimal.Clear();
            txtNomeAnimal.Clear();
            cmbTipoAnimal.Select();
            txtIdadeAnimal.Clear();
            txtCorAnimal.Clear();
            txtTamanhoAnimal.Clear();
            txtPesoAnimal.Clear();
            txtRacaAnimal.Clear();
            btnIncluir.Enabled = true;
            txtNomeAnimal.Focus();
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
            frmAnimal_Load(null, null);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            PreparaInclusao();   
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AposSalvar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AposCancelar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
   