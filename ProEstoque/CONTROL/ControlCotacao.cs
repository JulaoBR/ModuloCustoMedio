using ProEstoque.DAO;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEstoque.CONTROL
{
    public class ControlCotacao
    {
        private static Conexao cx = new Conexao(ClasseConexao.StringConexao);
        private DAOCotacao daoCotacao = new DAOCotacao(cx);

        private DataTable tabela;
        private string descricao;
        private string data1;
        private string data2;

        public ControlCotacao()
        {

        }

        public bool Inserir(ModelPedido pedido, List<ModelRegistro> listaRegistro)
        {
            try
            {
                if (listaRegistro.Count > 0 && Convert.ToString(pedido.ped_data_pedido) != "" && Convert.ToString(pedido.ped_data_prevista) != "")
                {
                    //INSERE NA TABELA DE PEDIDO
                    daoCotacao.Inserir(pedido);

                    //BUSCA ULTIMO ID DA TABELA PEDIDO
                    int ultimoId = daoCotacao.BuscaUltimoId();

                    foreach (var item in listaRegistro)
                    {
                        var registro = new ModelRegistro();

                        registro.codProduto = item.codProduto;
                        registro.cat_cod = ultimoId;
                        registro.quantidade = item.quantidade;
                        registro.valorUnitario = item.valorUnitario;

                        //INSERE NA TABELA REGISTRO
                        daoCotacao.InserirEntrada(registro);

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
    }
}
