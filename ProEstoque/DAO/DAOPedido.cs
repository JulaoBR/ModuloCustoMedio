using ProEstoque.MODEL;
using System;
using System.Data;
using System.Data.SQLite;

namespace ProEstoque.DAO
{
    public class DAOPedido
    {
        //ATRIBUTO PRIVADO
        private Conexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOPedido(Conexao cx)
        {
            this.conexao = cx;
        }

        public bool Inserir(ModelPedido modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO pedido(ped_for_cod, ped_data_pedido, ped_data_prevista, ped_contato, ped_forma_pagamento, ped_condicao_pagamento, ped_observacao, ped_status)" +
                    "VALUES (@forCod, @pedido, @prevista, @contato, @pagamento, @condicao, @observacao, @status)";
                cmd.Parameters.AddWithValue("@forCod", modelo.for_cod);
                cmd.Parameters.AddWithValue("@pedido", modelo.ped_data_pedido);
                cmd.Parameters.AddWithValue("@prevista", modelo.ped_data_prevista);
                cmd.Parameters.AddWithValue("@contato", modelo.ped_contato);
                cmd.Parameters.AddWithValue("@pagamento", modelo.ped_forma_pagamento);
                cmd.Parameters.AddWithValue("@condicao", modelo.ped_condicao_pagamento);
                cmd.Parameters.AddWithValue("@observacao", modelo.ped_observacao);
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

        public bool InserirPedidoRegistro(int pedCod, int regCod)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO pedido_registro(ped_cod, reg_cod)" +
                    "VALUES (@pedCod, @regCod)";
                cmd.Parameters.AddWithValue("@pedCod", pedCod);
                cmd.Parameters.AddWithValue("@regCod", regCod);

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
                cmd.CommandText = "UPDATE pedido SET ped_data_pedido = @pedido, ped_data_prevista = @prevista, ped_contato = @contato, ped_forma_pagamento = @pagamento, ped_observacao = @observacao ";
                cmd.Parameters.AddWithValue("@regCod", modelo.reg_cod);
                cmd.Parameters.AddWithValue("@pedido", modelo.ped_data_pedido);
                cmd.Parameters.AddWithValue("@prevista", modelo.ped_data_prevista);
                cmd.Parameters.AddWithValue("@contato", modelo.ped_contato);
                cmd.Parameters.AddWithValue("@pagamento", modelo.ped_forma_pagamento);
                cmd.Parameters.AddWithValue("@observacao", modelo.ped_observacao);

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

        public bool UpdateRecebimento(ModelPedido modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE pedido SET ped_data_entrega = @entrega, ped_status = @status WHERE ped_cod = @codPed ";
                cmd.Parameters.AddWithValue("@status", modelo.status);
                cmd.Parameters.AddWithValue("@entrega", modelo.ped_data_entrega);

                cmd.Parameters.AddWithValue("@codPed", modelo.ped_cod);

                conexao.Conectar();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable BuscaDadosPedido(int codigo)  
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.ped_cod, B.for_descricao, A.ped_data_pedido, A.ped_data_prevista, A.ped_data_entrega, A.ped_contato, A.ped_forma_pagamento, A.ped_condicao_pagamento, A.ped_observacao, A.ped_status FROM pedido AS A JOIN fornecedor AS B WHERE A.ped_for_cod = B.for_cod AND A.ped_cod = '"+ codigo +"' ", conexao.StringConexao))
                {
                    da.Fill(tb);
                    conexao.Desconectar();
                    return tb;
                }
            }
            catch
            {
                return tb;
            }
        }

        public DataTable BuscaPedidoNaoRecebido(int codigo)
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.ped_cod, B.pro_descricao, E.for_descricao, D.reg_quantidade, B.pro_unidade_medida, A.ped_data_pedido, A.ped_data_prevista, A.ped_observacao, A.ped_status FROM pedido AS A JOIN produto AS B JOIN pedido_registro AS C JOIN registro_entrada AS D JOIN fornecedor AS E WHERE A.ped_cod = C.ped_cod AND B.pro_cod = D.pro_cod AND C.reg_cod = D.reg_cod AND D.for_cod = E.for_cod AND A.ped_status = 0 AND B.pro_cod = '"+codigo+"'", conexao.StringConexao))
                {
                    da.Fill(tb);
                    conexao.Desconectar();
                    return tb;
                }
            }
            catch
            {
                return tb;
            }
        }

        public DataTable BuscaRegistroEntradaPedido(int codigo)
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.reg_cod, A.pro_cod, B.pro_descricao, A.reg_quantidade, A.reg_valor_unitario, A.reg_valor_frete, A.reg_valor_total FROM registro_entrada AS A JOIN produto AS B JOIN pedido_registro AS C WHERE C.reg_cod = A.reg_cod AND B.pro_cod = A.pro_cod AND C.ped_cod = '"+codigo+"'", conexao.StringConexao))
                {
                    da.Fill(tb);
                    conexao.Desconectar();
                    return tb;
                }
            }
            catch(Exception ex)
            {
                return tb;
            }
        }

        public DataTable BuscaDadosNaoRecebidos(string descricao)
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.ped_cod, B.pro_descricao, E.for_descricao, D.reg_quantidade, B.pro_unidade_medida, A.ped_data_pedido, A.ped_data_prevista, A.ped_observacao, A.ped_status FROM pedido AS A JOIN produto AS B JOIN pedido_registro AS C JOIN registro_entrada AS D JOIN fornecedor AS E WHERE A.ped_cod = C.ped_cod AND B.pro_cod = D.pro_cod AND C.reg_cod = D.reg_cod AND D.for_cod = E.for_cod AND A.ped_status = 0 AND B.pro_descricao LIKE '%"+descricao+"%'", conexao.StringConexao))
                {
                    da.Fill(tb);
                    conexao.Desconectar();
                    return tb;
                }
            }
            catch 
            {
                return tb;
            }
        }

        public DataTable BuscaDadosRecebidos(string descricao)
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.ped_cod, B.pro_descricao, E.for_descricao, D.reg_quantidade, B.pro_unidade_medida, A.ped_data_pedido, A.ped_data_prevista, A.ped_data_entrega, A.ped_observacao, A.ped_status FROM pedido AS A JOIN produto AS B JOIN pedido_registro AS C JOIN registro_entrada AS D JOIN fornecedor AS E WHERE A.ped_cod = C.ped_cod AND B.pro_cod = D.pro_cod AND C.reg_cod = D.reg_cod AND D.for_cod = E.for_cod AND A.ped_status = 1 AND B.pro_descricao LIKE '%" + descricao + "%'", conexao.StringConexao))
                {
                    da.Fill(tb);
                    conexao.Desconectar();
                    return tb;
                }
            }
            catch
            {
                return tb;
            }
        }

        public DataTable BuscaTodosPedidos(string descricao)
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.ped_cod, B.pro_descricao, E.for_descricao, D.reg_quantidade, B.pro_unidade_medida, A.ped_data_pedido, A.ped_data_prevista, A.ped_data_entrega, A.ped_observacao, A.ped_status FROM pedido AS A JOIN produto AS B JOIN pedido_registro AS C JOIN registro_entrada AS D JOIN fornecedor AS E WHERE A.ped_cod = C.ped_cod AND B.pro_cod = D.pro_cod AND C.reg_cod = D.reg_cod AND D.for_cod = E.for_cod AND B.pro_descricao LIKE '%" + descricao+ "%' ", conexao.StringConexao))
                {
                    da.Fill(tb);
                    conexao.Desconectar();
                    return tb;
                }
            }
            catch(Exception ex)
            {
                return tb;
            }
        }

        public int BuscaUltimoId()    
        {
            DataTable tb = new DataTable();
            int retorno = 0;
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT ped_cod FROM pedido ORDER BY ped_cod DESC  LIMIT 1", conexao.StringConexao))
                {
                    da.Fill(tb);
                    conexao.Desconectar();

                    retorno = Convert.ToInt32(tb.Rows[0]["ped_cod"].ToString());

                    return retorno;
                }
            }
            catch
            {
                return 0;
            }
        }

        public int BuscaIdPedidoRegistro(int codPedido)
        {
            DataTable tb = new DataTable();
            int retorno = 0;
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT reg_cod FROM pedido_registro WHERE ped_cod = '"+codPedido+"'", conexao.StringConexao))
                {
                    da.Fill(tb);
                    conexao.Desconectar();

                    retorno = Convert.ToInt32(tb.Rows[0]["reg_cod"].ToString());

                    return retorno;
                }
            }
            catch
            {
                return 0;
            }
        }

        public bool ExcluiPedido(int codigo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "DELETE FROM pedido WHERE ped_cod = @codigo;";
                cmd.Parameters.AddWithValue("@codigo", codigo);

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

        public bool ExcluiPedidoRegistro(int codigo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "DELETE FROM pedido_registro WHERE ped_cod = @codigo;";
                cmd.Parameters.AddWithValue("@codigo", codigo);

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
    }
}
