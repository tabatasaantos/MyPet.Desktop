using System;
using System.Data;
using System.Data.SqlClient;
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

        SqlConnection sqlConexao = null;
        private string stringConexao = "Data Source=TABATA-PC\\SQLEXPRESS; Initial Catalog=DB_MYPET; User Id=sa; Password=barne;";

        private string sqlCommando = string.Empty;
        int id = 0;


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
            txtTipo.Clear();
            txtDescricao.Clear();
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
            LimparCampos();
            PreparaInclusao();
        }

        public void AposExcluir()
        {

        }
        public void AposCancelar()
        {
            if (string.IsNullOrEmpty(txtNomeAnimal.Text))
            {
                this.Close();
            }
            else
            {
                LimparCampos();
                PreparaInclusao();
            }

            frmAnimal_Load(null, null);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            PreparaInclusao();   
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            sqlCommando = "INSERT TB_ANIMAL (NOME, ID_TIPO, IDADE, COR, TAMANHO, PESO, RACA) VALUES (@NOME, @ID_TIPO, @IDADE, @COR, @TAMANHO, @PESO, @RACA)";

            sqlConexao = new SqlConnection(stringConexao);

            SqlCommand comando = new SqlCommand(sqlCommando, sqlConexao);

            comando.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            int.TryParse(txtIDAnimal.Text, out id);
            comando.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtNomeAnimal.Text;
            comando.Parameters.Add("@ID_TIPO", SqlDbType.Int).Value = Convert.ToInt32(txtTipo.Text);
           // comando.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = txtDescricao.Text;
            comando.Parameters.Add("@IDADE", SqlDbType.Int).Value = Convert.ToInt32(txtIdadeAnimal.Text);
            comando.Parameters.Add("@COR", SqlDbType.VarChar).Value = txtCorAnimal.Text;
            comando.Parameters.Add("@TAMANHO", SqlDbType.Decimal).Value = Convert.ToDecimal(txtTamanhoAnimal.Text);
            comando.Parameters.Add("@PESO", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPesoAnimal.Text);
            comando.Parameters.Add("@RACA", SqlDbType.VarChar).Value = txtRacaAnimal.Text;

            try
            {
                sqlConexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("OPERAÇÃO CONCLUÍDA COM SUCESSO!", "CONCLUÍDO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //chama o metodo que prepara a tela
                AposSalvar();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlConexao.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AposCancelar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        
        //esse evento é disparado toda vez que o texto é alterado
        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            
        }

        //esse evento muda o foco quando pressionado o tab

        private void txtTipo_Validated(object sender, EventArgs e)
        {
            txtDescricao.Text = txtTipo.Text + " O  que veio do banco";
        }
    }
}
   