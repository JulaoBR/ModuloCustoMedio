using ProEstoque.DAO;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProEstoque.CONTROL
{
    public class ControlTipoProduto
    {
        private static Conexao cx = new Conexao(ClasseConexao.StringConexao);
        private DAOTipoProduto dao = new DAOTipoProduto(cx);

        public ControlTipoProduto()
        {

        }

        public bool Inserir(ModelTipoProduto tipo)
        {
            try
            {
                if (tipo.tipo_descricao != string.Empty)
                {
                    dao.Inserir(tipo);
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

        public DataTable BuscaTipoProdutoId(int codigo)
        {
            try
            {
                DataTable dt = dao.BuscaTipoProdutoPorId(codigo);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public List<ModelTipoProduto> BuscaTipoProdutoIdLista(int codigo)
        {
            try
            {
                DataTable dt = dao.BuscaTipoProdutoPorId(codigo);
                List<ModelTipoProduto> lista = new List<ModelTipoProduto>();

                foreach (DataRow item in dt.Rows)
                {
                    ModelTipoProduto tipo = new ModelTipoProduto();

                    tipo.tipo_cod = Convert.ToInt32(item["tipo_cod"].ToString());
                    tipo.tipo_descricao = item["tipo_descricao"].ToString();

                    lista.Add(tipo);

                }

                return lista;
            }
            catch
            {
                return null;
            }
        }
    }
}

