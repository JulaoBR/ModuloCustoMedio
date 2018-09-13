using ProEstoque.DAO;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProEstoque.CONTROL
{
    public class ControlFornecedor
    {
        private static Conexao cx = new Conexao(ClasseConexao.StringConexao);
        private DAOFornecedor dao = new DAOFornecedor(cx);

        public ControlFornecedor()
        {

        }

        public bool Inserir(ModelFornecedor fornecedor)
        {
            try
            {
                if (fornecedor.descricao != string.Empty)
                {
                    dao.Inserir(fornecedor);
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

        public bool Update(ModelFornecedor fornecedor)
        {
            try
            {
                if (fornecedor.for_descricao != string.Empty || fornecedor.for_email != string.Empty || fornecedor.for_prazo_entrega == 0)
                {
                    dao.Update(fornecedor);
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

        public DataTable BuscaDados()
        {
            try
            {
                DataTable dt = dao.BuscaDados();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public List<ModelFornecedor> BuscaDados(string descricao)
        {
            try
            {
                DataTable dt = dao.BuscaDados(descricao);
                List<ModelFornecedor> lista = new List<ModelFornecedor>();

                foreach (DataRow item in dt.Rows)
                {
                    ModelFornecedor fornecedor = new ModelFornecedor();

                    fornecedor.for_cod = Convert.ToInt32(item["for_cod"].ToString());
                    fornecedor.for_descricao = item["for_descricao"].ToString();
                    fornecedor.for_email = item["for_email"].ToString();
                    if (item["for_prazo_entrega"].ToString() != "")
                        fornecedor.for_prazo_entrega = Convert.ToInt32(item["for_prazo_entrega"].ToString());

                    lista.Add(fornecedor);

                }

                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable BuscaFornecedorId(int codigo)
        {
            try
            {
                DataTable dt = dao.BuscaFornecedorPorId(codigo);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public List<ModelFornecedor> BuscaFornecedorIdLista(int codigo)
        {
            try
            {
                DataTable dt = dao.BuscaFornecedorPorId(codigo);
                List<ModelFornecedor> lista = new List<ModelFornecedor>();

                foreach (DataRow item in dt.Rows)
                {
                    ModelFornecedor fornecedor = new ModelFornecedor();

                    fornecedor.for_cod = Convert.ToInt32(item["for_cod"].ToString());
                    fornecedor.for_descricao = item["for_descricao"].ToString();

                    lista.Add(fornecedor);

                }

                return lista;
            }
            catch
            {
                return null;
            }
        }

        public ModelFornecedor BuscaFornecedorUmFornecedor(int codigo)
        {
            try
            {
                ModelFornecedor modelo = new ModelFornecedor();
                DataTable dt = dao.BuscaFornecedorUmFornecedor(codigo);

                modelo.for_cod = Convert.ToInt32(dt.Rows[0]["for_cod"].ToString());
                modelo.for_descricao = dt.Rows[0]["for_descricao"].ToString();
                modelo.for_email = dt.Rows[0]["for_email"].ToString();
                if(dt.Rows[0]["for_prazo_entrega"].ToString() != "")
                    modelo.for_prazo_entrega = Convert.ToInt32(dt.Rows[0]["for_prazo_entrega"].ToString());


                return modelo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
    }
}
