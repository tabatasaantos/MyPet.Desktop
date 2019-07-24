using MyPet.UI.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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
            dgvTipos.AutoGenerateColumns = false;
            AtualizarGrid();
            this.Focus();
        }

        //string de conexão sql

        SqlConnection sqlConexao = null;

        // passando o caminho do SQL 

        private string stringConexao = "Data Source=TABATA-PC\\SQLEXPRESS; Initial Catalog=DB_MYPET; User Id=sa; Password=barne;";

        private string sqlCommando = string.Empty;
        int id = 0;

        // criando funções
        public void PreparaInclusao()
        {
            btnIncluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            txtIDEspecie.Text = "[AUTOMÁTICO]";
            btnIncluir.Enabled = true;
            txtDescricaoEspecie.Enabled = false;
            txtCaracteristicaEspecie.Enabled = false;
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
            LimparCampos();
            PreparaInclusao();
            AtualizarGrid();
            txtDescricaoEspecie.Enabled = true;
            txtCaracteristicaEspecie.Enabled = true;
            btnSalvar.Enabled = true;
            txtDescricaoEspecie.Focus();
        }

        public void AposExcluir()
        {

        }
        public void AposCancelar()
        {
            if (string.IsNullOrEmpty(txtDescricaoEspecie.Text))
            {
                this.Close();
            }
            else
            {
                LimparCampos();
                PreparaInclusao();
            }

            frmEspecie_Load(null, null);

        }

        private bool Validacao()
        {
            string caracteristica = txtCaracteristicaEspecie.Text;
            string descricao = txtDescricaoEspecie.Text;

            if (caracteristica == string.Empty || descricao == string.Empty)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        private void AposIncluir()
        {
            txtCaracteristicaEspecie.Enabled = true;
            txtDescricaoEspecie.Enabled = true;
            txtDescricaoEspecie.Focus();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            PreparaInclusao();
            AposIncluir();
        }

        //criando eventos

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtIDEspecie.Text == "[AUTOMÁTICO]")
            {
                ExecutaNoBanco("I");
            }
            else 
            {
                ExecutaNoBanco("A");
            }   
        }

        private void ExecutaNoBanco(string tipoOperacao)
        {
            // chamar o metodo que salva no banco

            if (Validacao() == false)
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtDescricaoEspecie.Focus();
                return;
            }

            if (tipoOperacao == "I")
            {
                sqlCommando = "INSERT TB_TIPO (DESCRICAO, CARACTERISTICAS) VALUES (@DESCRICAO, @CARACTERISTICAS)";
            }
            else if (tipoOperacao == "A")
            {
                sqlCommando = "UPDATE TB_TIPO SET DESCRICAO = @DESCRICAO, CARACTERISTICAS = @CARACTERISTICAS WHERE ID = @ID";
            }
            else if (tipoOperacao == "D")
            {
                sqlCommando = "DELETE TB_TIPO WHERE ID = @ID";
            }

            //outra maneira de fazer:
            //if (txtIDEspecie.Text == "[AUTOMÁTICO]")
            //{
            //    sqlCommando = "INSERT TB_TIPO (DESCRICAO, CARACTERISTICAS) VALUES (@DESCRICAO, @CARACTERISTICAS)";
            //}
            //else if (txtIDEspecie.Text != "[AUTOMÁTICO]")
            //{
            //    sqlCommando = "UPDATE TB_TIPO SET DESCRICAO = @DESCRICAO, CARACTERISTICAS = @CARACTERISTICAS WHERE ID = @ID";
            //}

            //chamando string de conexão

            sqlConexao = new SqlConnection(stringConexao);

            SqlCommand comando = new SqlCommand(sqlCommando, sqlConexao);

            //passando parâmetros
            comando.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = txtDescricaoEspecie.Text;
            comando.Parameters.Add("@CARACTERISTICAS", SqlDbType.VarChar).Value = txtCaracteristicaEspecie.Text;
            int.TryParse(txtIDEspecie.Text, out id);
            comando.Parameters.Add("@ID", SqlDbType.Int).Value = id;

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

        //criando função para obter tipos direto do banco de dados

        public List<Tipo> ObterTipos()
        {
            List<Tipo> retorno = new List<Tipo>();
            SqlCommand cmd = new SqlCommand();
            sqlConexao = new SqlConnection(stringConexao);
            using (cmd.Connection = sqlConexao)
            {
                try
                {
                    sqlConexao.Open();
                    cmd.CommandText = "SELECT * FROM TB_TIPO ";
                    using (cmd)
                    {
                        using (DbDataReader dbReader = cmd.ExecuteReader())
                        {
                            while (dbReader.Read())
                            {
                                Tipo dto = new Tipo();
                                dto.Id = (Convert.ToInt32(dbReader["ID"].ToString()));
                                dto.Descricao = dbReader["DESCRICAO"].ToString();
                                dto.Caracteristicas = dbReader["CARACTERISTICAS"].ToString();
                                retorno.Add(dto);
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
            return retorno;
        }

        //fim

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExecutaNoBanco("D"); 
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // AtualizarGrid();

            //frmFiltroEspecie frm = new frmFiltroEspecie();
            //frm.Show();

            frmFiltroEspecie meuFormBusca = new frmFiltroEspecie();
            meuFormBusca.meuFormOrigem = this;
            meuFormBusca.Show();

        }

        private void AtualizarGrid()
        {
            dgvTipos.DataSource = ObterTipos();
        }

        //criando o evento da grid

        private void dgvTipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtIDEspecie.Text = dgvTipos[0, dgvTipos.CurrentRow.Index].Value.ToString();
            //txtDescricaoEspecie.Text = dgvTipos[1, dgvTipos.CurrentRow.Index].Value.ToString();
            //txtCaracteristicaEspecie.Text = dgvTipos[2, dgvTipos.CurrentRow.Index].Value.ToString();

            txtCaracteristicaEspecie.Enabled = true;
            txtDescricaoEspecie.Enabled = true;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;
            dgvTipos.ReadOnly = true;
        }

        // criando evento para atalho no teclado na tela 2 de espécie
        //criando um caminho da origem para a busca

        private void frmEspecie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmFiltroEspecie meuFormBusca = new frmFiltroEspecie();
                meuFormBusca.meuFormOrigem = this;
                meuFormBusca.Show();
            }
        }
    }
}
