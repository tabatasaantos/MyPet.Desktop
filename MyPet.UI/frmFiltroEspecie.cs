using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MyPet.UI.NewFolder1;
using System.Data.Common;

namespace MyPet.UI
{
    public partial class frmFiltroEspecie : Form
    {
        public frmFiltroEspecie()
        {
            InitializeComponent();
        }

        //criando o evento de filtro
        public frmEspecie meuFormOrigem;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDEspecie.Text))
            {
                AtualizarGrid(Convert.ToInt32(txtIDEspecie.Text), txtDescricaoEspecie.Text);
            }
            else
            {
                AtualizarGrid(null, txtDescricaoEspecie.Text);

            }
        }

        //string de conexão sql

        SqlConnection sqlConexao = null;
        private string stringConexao = "Data Source=TABATA-PC\\SQLEXPRESS; Initial Catalog=DB_MYPET; User Id=sa; Password=barne;";
        private string sqlCommando = string.Empty;
        int id = 0;

        //criando função para obter tipos direto do banco de dados
        public List<Tipo> ObterTipos(int? id, string descricao)
        {
            List<Tipo> retorno = new List<Tipo>();
            SqlCommand cmd = new SqlCommand();

            string filtro = " WHERE ID > 0 ";

            if (id > 0)
            {
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                filtro = filtro + " AND ID = @ID ";
            }
            if (!string.IsNullOrEmpty(descricao))
            {
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = $"%{descricao}%";
                filtro = filtro + " AND DESCRICAO LIKE @DESCRICAO ";
            }

            sqlConexao = new SqlConnection(stringConexao);
            using (cmd.Connection = sqlConexao)
            {
                try
                {
                    sqlConexao.Open();
                    cmd.CommandText = "SELECT * FROM TB_TIPO " + filtro;

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

        private void AtualizarGrid(int? id, string descricao)
        {
            dgvTipos.DataSource = ObterTipos(id, descricao);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void dgvTipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            meuFormOrigem.txtIDEspecie.Text = dgvTipos[0, dgvTipos.CurrentRow.Index].Value.ToString();
            meuFormOrigem.txtDescricaoEspecie.Text = dgvTipos[1, dgvTipos.CurrentRow.Index].Value.ToString();
            meuFormOrigem.txtCaracteristicaEspecie.Text = dgvTipos[2, dgvTipos.CurrentRow.Index].Value.ToString();
            this.Close();
        }

        private void frmFiltroEspecie_Load(object sender, EventArgs e)
        {

        }

       
    }
}
