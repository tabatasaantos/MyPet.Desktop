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
            
            dgvTipos.DataSource = ObterTipos();
        }

        //string de conexão sql

        SqlConnection sqlCon = null;
        private string strCon = "Data Source=TABATA-PC\\SQLEXPRESS; Initial Catalog=DB_MYPET; User Id=sa; Password=barne;";
        private string strSql = string.Empty;


        public void PreparaInclusao()
        {
            btnIncluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            txtIDEspecie.Text = "[AUTOMATICO]";
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



            strSql = "INSERT TB_TIPO (DESCRICAO, CARACTERISTICAS) VALUES (@DESCRICAO, @CARACTERISTICAS)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = txtDescricaoEspecie.Text;
            comando.Parameters.Add("@CARACTERISTICAS", SqlDbType.VarChar).Value = txtCaracteristicaEspecie.Text;

            try
            {
                sqlCon.Open();

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
                sqlCon.Close();
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
            sqlCon = new SqlConnection(strCon);
            using (cmd.Connection = sqlCon)
            {
                try
                {
                    sqlCon.Open();
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
                    sqlCon.Close();
                }
            }
            return retorno;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvTipos.DataSource = ObterTipos();
        }


    }
}
