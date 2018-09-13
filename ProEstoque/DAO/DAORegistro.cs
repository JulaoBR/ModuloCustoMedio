using System;
using ProEstoque.MODEL;
using System.Data.SQLite;
using System.Data;

namespace ProEstoque.DAO
{
    public class DAORegistro
    {
        //ATRIBUTO PRIVADO
        private Conexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAORegistro(Conexao cx)
        {
            this.conexao = cx;
        }

        public bool InserirEntrada(ModelRegistro modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO registro_entrada(pro_cod, for_cod, reg_quantidade, reg_valor_unitario, reg_valor_frete, reg_valor_total, reg_status)" +
                    "VALUES (@proCod, @forCod, @quantidade, @vlUnitario, @vlFrete, @vlTotal, @status)";
                cmd.Parameters.AddWithValue("@proCod", modelo.codProduto);
                cmd.Parameters.AddWithValue("@quantidade", modelo.quantidade);
                cmd.Parameters.AddWithValue("@vlUnitario", modelo.valorUnitario);
                cmd.Parameters.AddWithValue("@forCod", modelo.for_cod);
                cmd.Parameters.AddWithValue("@vlFrete", modelo.valorFrete);
                cmd.Parameters.AddWithValue("@vlTotal", modelo.valorTotal);
                cmd.Parameters.AddWithValue("@status", modelo.reg_status);

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

        public bool InserirSaida(ModelRegistro modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO registro_saida(pro_cod, tipo_cod, cat_cod, reg_quantidade, reg_valor_unitario, reg_valor_total, reg_data_operacao)" +
                    "VALUES (@proCod, @tipoCod, @catCod, @quantidade, @vlUnitario, @vlTotal, @dtOperacao)";
                cmd.Parameters.AddWithValue("@proCod", modelo.codProduto);
                cmd.Parameters.AddWithValue("@tipoCod", modelo.tipo_cod);
                cmd.Parameters.AddWithValue("@catCod", modelo.cat_cod);
                cmd.Parameters.AddWithValue("@quantidade", modelo.quantidade);
                cmd.Parameters.AddWithValue("@vlUnitario", modelo.valorUnitario);
                cmd.Parameters.AddWithValue("@vlTotal", modelo.valorTotal);
                cmd.Parameters.AddWithValue("@dtOperacao", modelo.dataOperacao);

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

        public bool UpdateRecebimento(ModelRegistro modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE registro_entrada SET reg_quantidade = @quantidade, reg_valor_unitario = @vlUnitario, reg_custo_medio = @custo, reg_saldo = @saldo, reg_valor_frete = @vlFrete, reg_valor_total = @vlTotal, reg_data_operacao = @dataOperacao, reg_status = @status WHERE reg_cod = @cod";
                cmd.Parameters.AddWithValue("@quantidade", modelo.quantidade);
                cmd.Parameters.AddWithValue("@vlUnitario", modelo.valorUnitario);
                cmd.Parameters.AddWithValue("@custo", modelo.custoMedio);
                cmd.Parameters.AddWithValue("@saldo", modelo.saldo);
                cmd.Parameters.AddWithValue("@vlFrete", modelo.valorFrete);
                cmd.Parameters.AddWithValue("@vlTotal", modelo.valorTotal);
                cmd.Parameters.AddWithValue("@dataOperacao", modelo.dataOperacao);
                cmd.Parameters.AddWithValue("@status", modelo.reg_status);
                cmd.Parameters.AddWithValue("@cod",modelo.reg_cod);

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


        public bool ExcluiRegistroSaida(int codigo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "DELETE FROM registro_saida WHERE reg_cod = @codigo;";
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

        public bool ExcluiRegistroEntrada(int codigo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "DELETE FROM registro_entrada WHERE reg_cod = @codigo;";
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

        public DataTable LocalizarUltimaEntrada(string descricao)//BUSCA POR ID
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.reg_cod, A.reg_quantidade, A.reg_valor_unitario, A.reg_valor_porcentual, A.reg_custo_medio, A.reg_saldo, A.reg_valor_frete, A.reg_valor_total, A.reg_data_operacao FROM registro_entrada AS A JOIN produto AS B WHERE A.pro_cod = B.pro_cod AND B.pro_descricao LIKE '%" + descricao + "%' AND reg_status = 1 ORDER BY reg_cod DESC LIMIT 1", conexao.StringConexao))
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

        public DataTable LocalizarEntrada(int Id)      //BUSCA POR ID
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.reg_cod, B.for_cod, B.for_descricao, A.reg_quantidade, A.reg_valor_unitario, A.reg_custo_medio, A.reg_saldo, A.reg_valor_frete, A.reg_valor_total, A.reg_data_operacao FROM registro_entrada AS A JOIN fornecedor AS B WHERE A.for_cod = B.for_cod AND A.pro_cod = '" + Id + "'AND reg_status = 1", conexao.StringConexao))
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

        public DataTable LocalizarEntradaFornecedor(int produto, int fornecedor)      //BUSCA POR ID
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.reg_cod, B.for_cod, B.for_descricao, A.reg_quantidade, A.reg_valor_unitario, A.reg_custo_medio, A.reg_saldo, A.reg_valor_frete, A.reg_valor_total, A.reg_data_operacao FROM registro_entrada AS A JOIN fornecedor AS B WHERE A.for_cod = B.for_cod AND B.for_cod = '" + fornecedor + "' AND A.pro_cod = '"+produto+ "' AND reg_status = 1", conexao.StringConexao))
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

        public DataTable LocalizarEntradaTodosFornecedores(string descricao)      //BUSCA POR ID
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.reg_cod, A.reg_quantidade, A.reg_valor_unitario, A.reg_custo_medio, A.reg_saldo, A.reg_valor_frete, A.reg_valor_total, A.reg_data_operacao FROM registro_entrada AS A JOIN produto AS B WHERE A.pro_cod = B.pro_cod AND B.pro_descricao LIKE '%" + descricao + "%' AND reg_status = 1", conexao.StringConexao))
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

        public DataTable LocalizarSaida(int Id)      //BUSCA POR ID
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT reg_cod, pro_cod, reg_quantidade, reg_valor_unitario, reg_valor_total, reg_data_operacao FROM registro_saida  WHERE pro_cod = '" + Id + "'", conexao.StringConexao))
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

        public DataTable BuscaDados(string descricao, string categotia, string data)      //BUSCA POR ID
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.reg_cod, B.pro_descricao, C.for_descricao, A.reg_quantidade, A.reg_valor_unitario, A.reg_custo_medio, A.reg_saldo, A.reg_valor_frete, A.reg_valor_total, A.reg_data_operacao FROM registro_entrada AS A JOIN produto AS B JOIN fornecedor AS C WHERE A.pro_cod = B.pro_cod AND A.for_cod = C.for_cod AND B.pro_descricao LIKE '%" + descricao + "%' AND B.pro_categoria LIKE '%" + categotia + "%' AND A.reg_data_operacao LIKE '%"+data+ "%' AND reg_status = 1", conexao.StringConexao))
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

        public DataTable BuscaDadosSaida(string descricao, string categotia, string data1, string data2)      //BUSCA POR ID
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.reg_cod, B.pro_descricao, C.tipo_descricao, A.reg_quantidade, B.pro_unidade_medida, A.reg_valor_unitario,  A.reg_valor_total, A.reg_data_operacao FROM registro_saida AS A JOIN produto AS B JOIN tipo_produto AS C WHERE A.pro_cod = B.pro_cod AND A.tipo_cod = C.tipo_cod AND B.pro_descricao LIKE '%" + descricao + "%' AND C.tipo_descricao LIKE '%" + categotia + "%' AND A.reg_data_operacao BETWEEN '" + data1 + "' AND '" + data2 + "'", conexao.StringConexao))
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

        public int BuscaUltimoId() 
        {
            DataTable tb = new DataTable();
            int retorno = 0;
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT reg_cod FROM registro_saida ORDER BY reg_cod DESC  LIMIT 1", conexao.StringConexao))
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

        public int BuscaUltimoIdEntrada()
        {
            DataTable tb = new DataTable();
            int retorno = 0;
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT reg_cod FROM registro_entrada ORDER BY reg_cod DESC  LIMIT 1", conexao.StringConexao))
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
    }
}
