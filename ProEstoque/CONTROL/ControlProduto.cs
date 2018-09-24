using ProEstoque.DAO;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProEstoque.CONTROL
{
    public class ControlProduto
    {
        private static Conexao cx = new Conexao(ClasseConexao.StringConexao);
        private DAOProduto dao = new DAOProduto(cx);

        public ControlProduto()
        {

        }

        public bool Inserir(ModelProduto produto, List<ModelFornecedor> listaFornecedor, List<ModelTipoProduto> listaTipoProduto)
        {
            try
            {
                if (produto.descricao != string.Empty || produto.categoria != string.Empty || listaFornecedor.Count == 0  || listaTipoProduto.Count == 0) {

                    dao.Inserir(produto);

                    int retorno = BuscaUltimoId();

                    foreach (var item in listaFornecedor)
                    {
                        ModelFornecedor model = new ModelFornecedor();

                        model.codProduto = retorno;
                        model.for_cod = item.for_cod;

                        dao.InserirProdutoFornecedor(model);
                    }

                    foreach (var item in listaTipoProduto)
                    {
                        ModelTipoProduto model = new ModelTipoProduto();

                        model.pro_cod = retorno;
                        model.tipo_cod = item.tipo_cod;

                        dao.InserirTipoProduto(model);
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Update(ModelProduto produto)
        {
            try
            {
                if (produto.descricao != string.Empty || produto.categoria != string.Empty )
                {
                    dao.Update(produto);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public DataTable BuscaDados(string codigo, string descricao, string categotia)
        {
            try
            {
                return dao.BuscaDados(codigo,  descricao, categotia);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable BuscaDados()
        {
            try
            {
                return dao.BuscaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public ModelProduto BuscaProduto(int codigo)
        {
            try
            {
                ModelProduto produto = new ModelProduto();
                DataTable dt = dao.BuscaProduto(codigo);

                produto.codProduto = Convert.ToInt32(dt.Rows[0]["pro_cod"].ToString());
                produto.descricao = dt.Rows[0]["pro_descricao"].ToString();
                produto.categoria = dt.Rows[0]["pro_categoria"].ToString();
                produto.unidade_medida = dt.Rows[0]["pro_unidade_medida"].ToString();
                produto.estoque_minimo = Convert.ToDecimal(dt.Rows[0]["pro_estoque_minimo"].ToString());
                if (dt.Rows[0]["pro_estoque_seguranca"].ToString() != "")
                    produto.estoque_seguranca = Convert.ToDecimal(dt.Rows[0]["pro_estoque_seguranca"].ToString());
                else
                    produto.estoque_seguranca = 0;
                produto.dataOperacao = Convert.ToDateTime(dt.Rows[0]["pro_data_operacao"].ToString());

                return produto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                dao.Excluir(codigo);
            }
            catch
            {

            }
        }

        public int BuscaUltimoId()
        {
            try
            {
                int retorno = dao.BuscaUltimoId();

                if (retorno == 0)
                {
                    MessageBox.Show("Erro ao buscar codigo do fornecedor", "Atenção", MessageBoxButtons.OK , MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    return retorno;
                }
            }
            catch
            {
                return 0;
            }
        }

        public object VerificaProduto(int valor)
        {
            try
            {
                return dao.VerificaProduto(valor);
            }
            catch
            {
                return null;
            }
        }
    }
}
