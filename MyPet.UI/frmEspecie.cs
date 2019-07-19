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
        }

        //string de conexão sql

        SqlConnection sqlConexao = null;
        private string stringConexao = "Data Source=TABATA-PC\\SQLEXPRESS; Initial Catalog=DB_MYPET; User Id=sa; Password=barne;";
        private string sqlCommando = string.Empty;


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
            btnSalvar.Enabled = false;
            PreparaInclusao();
            btnSalvar.Enabled = false;
            AtualizarGrid();
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

        //parametros


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // chamar o metodo que salkva no banco

            if (txtIDEspecie.Text == "[AUTOMÁTICO]")
            {
                sqlCommando = "INSERT TB_TIPO (DESCRICAO, CARACTERISTICAS) VALUES (@DESCRICAO, @CARACTERISTICAS)";
            }
            else if (txtIDEspecie.Text != "[AUTOMÁTICO]")
            {
                sqlCommando = "UPDATE TB_TIPO SET DESCRICAO = @DESCRICAO, CARACTERISTICAS = @CARACTERISTICAS WHERE ID = @ID";
            }

            sqlConexao = new SqlConnection(stringConexao);

            SqlCommand comando = new SqlCommand(sqlCommando, sqlConexao);

            comando.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = txtDescricaoEspecie.Text;
            comando.Parameters.Add("@CARACTERISTICAS", SqlDbType.VarChar).Value = txtCaracteristicaEspecie.Text;
            comando.Parameters.Add("@ID", SqlDbType.Int).Value = txtIDEspecie.Text;

            try
            {
                sqlConexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("CADASTRO EFETUADO COM SUCESSO!");
                //chamar o metodo que prepara a tela
                AposSalvar();
            }
            
            catch(Exception ex)
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid ()
        {
            dgvTipos.DataSource = ObterTipos();
        }


        private void dgvTipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDEspecie.Text = dgvTipos[0, dgvTipos.CurrentRow.Index].Value.ToString();
            txtDescricaoEspecie.Text = dgvTipos[1, dgvTipos.CurrentRow.Index].Value.ToString();
            txtCaracteristicaEspecie.Text = dgvTipos[2, dgvTipos.CurrentRow.Index].Value.ToString();

            dgvTipos.ReadOnly = true;
        }
    }
}
