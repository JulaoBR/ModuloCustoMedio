using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEstoque.DAO
{
    public class DAOCotacao
    {
        //ATRIBUTO PRIVADO
        private Conexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOCotacao(Conexao cx)
        {
            this.conexao = cx;
        }

        public bool Inserir(ModelPedido modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO cotacao(cot_for_cod, cot_data_pedido, cot_data_prevista, cot_contato, cot_forma_pagamento, cot_condicao_pagamento, cot_observacao, cot_valor_frete, cot_status)" +
                    "VALUES (@forCod, @pedido, @prevista, @contato, @pagamento, @condicao, @observacao, @frete, @status)";
                cmd.Parameters.AddWithValue("@forCod", modelo.for_cod);
                cmd.Parameters.AddWithValue("@pedido", modelo.ped_data_pedido);
                cmd.Parameters.AddWithValue("@prevista", modelo.ped_data_prevista);
                cmd.Parameters.AddWithValue("@contato", modelo.ped_contato);
                cmd.Parameters.AddWithValue("@pagamento", modelo.ped_forma_pagamento);
                cmd.Parameters.AddWithValue("@condicao", modelo.ped_condicao_pagamento);
                cmd.Parameters.AddWithValue("@observacao", modelo.ped_observacao);
                cmd.Parameters.AddWithValue("@frete", modelo.ped_valor_frete);
                cmd.Parameters.AddWithValue("@status", modelo.status);

                conexao.Conectar();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        //INSERE NA TABELA COTACAO PRODUTO
        public bool InserirEntrada(ModelRegistro modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO cotacao_produto(cot_cod, pro_cod, quantidade, valorUnitario)" +
                    "VALUES (@cotCod, @proCod, @quantidade, @valorUnitario)";
                cmd.Parameters.AddWithValue("@cotCod", modelo.cat_cod); //usando outro atributo para atribuir o valor aqui
                cmd.Parameters.AddWithValue("@proCod", modelo.codProduto);
                cmd.Parameters.AddWithValue("@quantidade", modelo.quantidade);
                cmd.Parameters.AddWithValue("@valorUnitario", modelo.valorUnitario);

                conexao.Conectar();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public bool Update(ModelPedido modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE cotacao SET cot_data_pedido = @pedido, cot_data_prevista = @prevista, cot_contato = @contato, cot_forma_pagamento = @pagamento, cot_observacao = @observacao, cot_quantidade = @quantidade, cot_valor_unitario = @valor, cot_valor_frete = @frete";

                cmd.Parameters.AddWithValue("@pedido", modelo.ped_data_pedido);
                cmd.Parameters.AddWithValue("@prevista", modelo.ped_data_prevista);
                cmd.Parameters.AddWithValue("@contato", modelo.ped_contato);
                cmd.Parameters.AddWithValue("@pagamento", modelo.ped_forma_pagamento);
                cmd.Parameters.AddWithValue("@observacao", modelo.ped_observacao);
                cmd.Parameters.AddWithValue("@quantidade", modelo.ped_quantidade);
                cmd.Parameters.AddWithValue("@valor", modelo.ped_valor_unitario);
                cmd.Parameters.AddWithValue("@frete", modelo.ped_valor_frete);

                cmd.Parameters.AddWithValue("@pedCod", modelo.ped_cod);

                conexao.Conectar();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public int BuscaUltimoId()
        {
            DataTable tb = new DataTable();
            int retorno = 0;
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT cot_cod FROM cotacao ORDER BY cot_cod DESC  LIMIT 1", conexao.StringConexao))
                {
                    da.Fill(tb);
                    conexao.Desconectar();

                    retorno = Convert.ToInt32(tb.Rows[0]["cot_cod"].ToString());

                    return retorno;
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
