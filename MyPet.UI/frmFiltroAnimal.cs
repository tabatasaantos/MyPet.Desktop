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
    public partial class frmFiltroAnimal : Form
    {
        public frmFiltroAnimal()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdAnimal.Text))
            {
                AtualizarGrid(Convert.ToInt32(txtIdAnimal.Text), txtNomeAnimal.Text, Convert.ToInt32(txtTipoAnimal.Text), txtDescricaoAnimal.Text);
            }
            else
            {
                AtualizarGrid(null, txtNomeAnimal.Text, null, txtDescricaoAnimal.Text);

            }
        }

        //string de conexão sql

        SqlConnection sqlConexao = null;
        private string stringConexao = "Data Source=TABATA-PC\\SQLEXPRESS; Initial Catalog=DB_MYPET; User Id=sa; Password=barne;";
        private string sqlCommando = string.Empty;
        int id = 0;
        public frmAnimal meuFormOrigem;

        //criando função para obter tipos direto do banco de dados
        public List<Tipo> ObterAnimais(int? id, string nome, int? idTipo, string descricao)
        {
            List<Tipo> retorno = new List<Tipo>();
            SqlCommand cmd = new SqlCommand();

            string filtro = " WHERE ID > 0 ";

            if (id > 0)
            {
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                filtro = filtro + " AND ID = @ID ";
            }
            if (!string.IsNullOrEmpty(nome))
            {
                cmd.Parameters.Add("@NOME", SqlDbType.VarChar).Value = $"%{nome}%";
                filtro = filtro + " AND NOME LIKE @NOME ";
            }
            if (idTipo > 0)
            {
                cmd.Parameters.Add("@ID_TIPO", SqlDbType.Int).Value = " AND ID_TIPO = @ID";
            }
            //if (!string.IsNullOrEmpty(descricao))
            //{
            //    cmd.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = $"%{descricao}%";
            //    filtro = filtro + " AND DESCRICAO LIKE @DESCRICAO";
            //}

            sqlConexao = new SqlConnection(stringConexao);
            using (cmd.Connection = sqlConexao)
            {
                try
                {
                    sqlConexao.Open();
                    cmd.CommandText = "SELECT * FROM TB_ANIMAL " + filtro;

                    using (cmd)
                    {
                        using (DbDataReader dbReader = cmd.ExecuteReader())
                        {
                            while (dbReader.Read())
                            {
                                Tipo dto = new Tipo();
                                dto.Id = Convert.ToInt32(dbReader["ID"].ToString());
                                dto.Nome = dbReader["NOME"].ToString();
                                dto.idTipo = Convert.ToInt32(dbReader["ID_TIPO"].ToString());
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


        private void AtualizarGrid(int? id, string nome, int? idTipo, string descricao)
        {
            dgvAnimal.DataSource = ObterAnimais(id, nome, idTipo, descricao);
        }

        private void dgvAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            meuFormOrigem.txtIdAnimal = dgvAnimal[0, dgvAnimal.CurrentRow.Index].Value.ToString();
            meuFormOrigem.txtNomeAnimal.Text = dgvAnimal[1, dgvAnimal.CurrentRow.Index].Value.ToString();
            meuFormOrigem.txtTipoAnimal = dgvAnimal[2, dgvAnimal.CurrentRow.Index].Value.ToString();
            meuFormOrigem.txtDescricao.Text = dgvAnimal[3, dgvAnimal.CurrentRow.Index].Value.ToString();
            this.Close();
        }

        private void frmFiltroAnimal_Load(object sender, EventArgs e)
        {

        }
    }
}
