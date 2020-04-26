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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = $"My Pet - Versão: {GetVersion()}"; // mudando o texto e adicionando a versão
            this.WindowState = FormWindowState.Maximized; // maximiza a janela
        }

        public string GetVersion()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(); //função que retorna a função
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmEspecie especie = new frmEspecie(); //estanciando formespecie
            especie.StartPosition = FormStartPosition.CenterParent; //definindo posição central do filho dento do pai
            especie.MdiParent = this; // definindo formulario de especie como filho do formulario principal (this)
            //para que um formulatio possa ser o pai ele tem que ser definido através da prop IsMdiContainer
            especie.Show();

            especie.WindowState = FormWindowState.Maximized; //abrir a janela maximizado

            especie.MaximizeBox = false;
            especie.MinimizeBox = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAnimal animal = new frmAnimal();
            animal.StartPosition = FormStartPosition.CenterParent;
            animal.MdiParent = this;
            animal.Show();

            animal.WindowState = FormWindowState.Maximized;

            animal.MaximizeBox = false;
            animal.MinimizeBox = false;
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColaboradores colaborador = new frmColaboradores();
            colaborador.StartPosition = FormStartPosition.CenterParent;
            colaborador.MdiParent = this;
            colaborador.Show();

            colaborador.WindowState = FormWindowState.Maximized;

            colaborador.MaximizeBox = false;
            colaborador.MinimizeBox = false;
        }

        private void campanhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCampanha campanha = new frmCampanha();
            campanha.StartPosition = FormStartPosition.CenterParent;
            campanha.MdiParent = this;
            campanha.Show();

            campanha.WindowState = FormWindowState.Maximized;

            campanha.MaximizeBox = false;
            campanha.MinimizeBox = false;
        }
    }
}
