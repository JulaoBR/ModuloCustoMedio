using ProEstoque.MODEL;
using System;
using System.Data;
using System.Data.SQLite;

namespace ProEstoque.DAO
{
    public class DAOProduto
    {
        //ATRIBUTO PRIVADO
        private Conexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOProduto(Conexao cx)
        {
            this.conexao = cx;
        }

        //METODO DE INSERIR NO BANCO OS DADOS DO USUARIO
        public bool Inserir(ModelProduto modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO produto(pro_descricao, pro_categoria, pro_unidade_medida, pro_estoque_minimo, pro_data_operacao)" +
                    "VALUES (@descricao, @categoria, @medida, @estMinimo, @dtOperacao)";
                cmd.Parameters.AddWithValue("@descricao", modelo.descricao);
                cmd.Parameters.AddWithValue("@categoria", modelo.categoria);
                cmd.Parameters.AddWithValue("@medida", modelo.unidade_medida);
                cmd.Parameters.AddWithValue("@estMinimo", modelo.estoque_minimo);
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

        public bool InserirProdutoFornecedor(ModelFornecedor modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO produto_fornecedor(pro_cod, for_cod)" +
                    "VALUES (@produto, @fornecedor)";
                cmd.Parameters.AddWithValue("@produto", modelo.codProduto);
                cmd.Parameters.AddWithValue("@fornecedor", modelo.for_cod);

                conexao.Conectar();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InserirTipoProduto(ModelTipoProduto modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO produto_tipo_produto(pro_cod, tipo_cod)" +
                    "VALUES (@produto, @tipo)";
                cmd.Parameters.AddWithValue("@produto", modelo.pro_cod);
                cmd.Parameters.AddWithValue("@tipo", modelo.tipo_cod);

                conexao.Conectar();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }

        //METODO DE INSERIR NO BANCO OS DADOS DO USUARIO
        public bool Update(ModelProduto modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE produto SET pro_descricao = @descricao, pro_categoria = @categoria, pro_unidade_medida = @medida, pro_estoque_minimo = @estMinimo WHERE pro_cod = @cod";
                cmd.Parameters.AddWithValue("@descricao", modelo.descricao);
                cmd.Parameters.AddWithValue("@categoria", modelo.categoria);
                cmd.Parameters.AddWithValue("@medida", modelo.unidade_medida);
                cmd.Parameters.AddWithValue("@estMinimo", modelo.estoque_minimo);
                cmd.Parameters.AddWithValue("@cod", modelo.codProduto);

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

        public DataTable BuscaDados(string codigo, string descricao, string categotia)      //BUSCA POR ID
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT pro_cod 'CODIGO', pro_descricao 'DESCRIÇÃO', pro_categoria 'CATEGORIA', pro_unidade_medida 'MEDIDA', pro_estoque_minimo 'QTD MINIMA', pro_data_operacao 'DATA CADASTRO' FROM produto WHERE pro_cod  LIKE '%" + codigo+ "%' AND pro_descricao LIKE '%" + descricao + "%' AND pro_categoria LIKE '%" + categotia + "%'", conexao.StringConexao))
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

        public DataTable BuscaDados()      //BUSCA POR ID
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT pro_cod , pro_descricao,  pro_categoria , pro_unidade_medida , pro_estoque_minimo , pro_data_operacao FROM produto ", conexao.StringConexao))
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

        public DataTable BuscaProduto(int codigo)      
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT pro_cod , pro_descricao ,pro_categoria, pro_unidade_medida, pro_estoque_minimo, pro_data_operacao  FROM produto WHERE pro_cod = '"+codigo+"' ", conexao.StringConexao))
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

        public int BuscaUltimoId()      //BUSCA POR ID
        {
            DataTable tb = new DataTable();
            int retorno = 0;
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT pro_cod FROM produto ORDER BY pro_cod DESC  LIMIT 1", conexao.StringConexao))
                {
                    da.Fill(tb);
                    conexao.Desconectar();
                   
                    retorno = Convert.ToInt32(tb.Rows[0]["pro_cod"].ToString());

                    return retorno;
                }
            }
            catch
            {
                return 0;
            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "DELETE FROM produto WHERE pro_cod = @registro;";
                cmd.Parameters.AddWithValue("@registro", codigo);

                conexao.Conectar();
                cmd.ExecuteNonQuery();

            }
            catch
            {

            }
            finally
            {
                conexao.Desconectar();
            }
        }

        //METODO PARA RETORNAR SE JA EXISTE UM PRODUTO CADASTRATO
        public object VerificaProduto(int valor)
        {
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT pro_cod FROM produto WHERE pro_cod = @Id;";
                cmd.Parameters.AddWithValue("@Id", valor);
                try
                {
                    conexao.Conectar();
                    return cmd.ExecuteScalar();
                }
                catch
                {
                    return null;
                }
                finally
                {
                    conexao.Desconectar();
                }
            }

        }
    }
}
