using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyPet.UI
{
    public partial class frmAnimal : Form
    {
        public frmAnimal()
        {
            InitializeComponent();
            txtCorAnimal.Enabled = false;
            txtDescricao.Enabled = false;
            txtIdadeAnimal.Enabled = false;
            txtNomeAnimal.Enabled = false;
            txtPesoAnimal.Enabled = false;
            txtRacaAnimal.Enabled = false;
            txtTamanhoAnimal.Enabled = false;
            txtTipo.Enabled = false;
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
            btnIncluir.Enabled = true;
            txtCorAnimal.Enabled = true;
            txtIdadeAnimal.Enabled = true;
            txtNomeAnimal.Enabled = true;
            txtPesoAnimal.Enabled = true;
            txtRacaAnimal.Enabled = true;
            txtTamanhoAnimal.Enabled = true;
            txtTipo.Enabled = true;
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
            txtNomeAnimal.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            sqlCommando = "INSERT TB_ANIMAL (NOME, ID_TIPO, IDADE, COR, TAMANHO, PESO, RACA) VALUES (@NOME, @ID_TIPO, @IDADE, @COR, @TAMANHO, @PESO, @RACA)";

            sqlConexao = new SqlConnection(stringConexao);

            SqlCommand comando = new SqlCommand(sqlCommando, sqlConexao);

            comando.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            int.TryParse(txtIDAnimal.Text, out id);
            comando.Parameters.Add("@NOME", SqlDbType.VarChar).Value = txtNomeAnimal.Text;
            comando.Parameters.Add("@ID_TIPO", SqlDbType.Int).Value = Convert.ToInt64(txtTipo.Text);
           //comando.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = txtDescricao.Text;
            comando.Parameters.Add("@IDADE", SqlDbType.Int).Value = Convert.ToInt64(txtIdadeAnimal.Text);
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
            dgvAnimal.DataSource = 
        }

        
        //esse evento é disparado toda vez que o texto é alterado
        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            
        }

        //esse evento muda o foco quando pressionado o tab

        private void txtTipo_Validated(object sender, EventArgs e)
        {
            // criando conexão com o banco de dados para usar o banco com select simples
            SqlCommand cmd = new SqlCommand();
            sqlConexao = new SqlConnection(stringConexao);
            using (cmd.Connection = sqlConexao)
            {
                try
                {
                    sqlConexao.Open();
                    cmd.CommandText = "SELECT DESCRICAO FROM TB_TIPO WHERE ID = @ID";
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(txtTipo.Text);
                    using (cmd)
                    {
                        using (DbDataReader dbReader = cmd.ExecuteReader())
                        {
                            while (dbReader.Read())
                            {
                                txtDescricao.Text = dbReader["DESCRICAO"].ToString();
                            }
                        }
                    }
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

        }

        private void dgvAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdadeAnimal.Text = dgvAnimal[0, dgvAnimal.CurrentRow.Index].Value.ToString();
            txtNomeAnimal.Text = dgvAnimal[1, dgvAnimal.CurrentRow.Index].Value.ToString();
            txtTipo.Text = dgvAnimal[2, dgvAnimal.CurrentRow.Index].Value.ToString();
            txtDescricao.Text = dgvAnimal[3, dgvAnimal.CurrentRow.Index].Value.ToString();
            txtIdadeAnimal.Text = dgvAnimal[4, dgvAnimal.CurrentRow.Index].Value.ToString();
            txtCorAnimal.Text = dgvAnimal[5, dgvAnimal.CurrentRow.Index].Value.ToString();
            txtTamanhoAnimal.Text = dgvAnimal[6, dgvAnimal.CurrentRow.Index].Value.ToString();
            txtPesoAnimal.Text = dgvAnimal[7, dgvAnimal.CurrentRow.Index].Value.ToString();
            txtRacaAnimal.Text = dgvAnimal[8, dgvAnimal.CurrentRow.Index].Value.ToString();

            dgvAnimal.ReadOnly = true;
        }
    }
}
   