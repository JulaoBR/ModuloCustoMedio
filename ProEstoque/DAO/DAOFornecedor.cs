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
    public class DAOFornecedor
    {
        //ATRIBUTO PRIVADO
        private Conexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOFornecedor(Conexao cx)
        {
            this.conexao = cx;
        }

        //METODO DE INSERIR NO BANCO OS DADOS DO USUARIO
        public bool Inserir(ModelFornecedor modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO fornecedor(for_descricao, for_email, for_prazo_entrega)" +
                    "VALUES (@descricao, @email, @prazo)";
                cmd.Parameters.AddWithValue("@descricao", modelo.for_descricao);
                cmd.Parameters.AddWithValue("@email", modelo.for_email);
                cmd.Parameters.AddWithValue("@prazo", modelo.for_prazo_entrega);

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

        public bool Update(ModelFornecedor modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE fornecedor SET for_descricao = @descricao, for_email = @email, for_prazo_entrega = @prazo WHERE for_cod = @cod";
                cmd.Parameters.AddWithValue("@descricao", modelo.for_descricao);
                cmd.Parameters.AddWithValue("@email", modelo.for_email);
                cmd.Parameters.AddWithValue("@prazo", modelo.for_prazo_entrega);
                cmd.Parameters.AddWithValue("@cod", modelo.for_cod);

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


        public DataTable BuscaDados()      
        {
            DataTable tb = new DataTable();
            try
            {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT for_cod, for_descricao FROM fornecedor ORDER BY for_descricao", conexao.StringConexao))
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

        public DataTable BuscaDados(string descricao)
        {
            DataTable tb = new DataTable();
            try
            {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT for_cod, for_descricao, for_email, for_prazo_entrega FROM fornecedor  WHERE for_descricao LIKE '%"+descricao+"%' ORDER BY for_descricao", conexao.StringConexao))
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

        public DataTable BuscaFornecedorPorId(int codigo)
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.for_cod, B.for_descricao FROM produto_fornecedor AS A JOIN fornecedor AS B WHERE A.for_cod = B.for_cod AND A.pro_cod = '" + codigo + "' ", conexao.StringConexao))
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

        public DataTable BuscaFornecedorUmFornecedor(int codigo)
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT for_cod, for_descricao, for_email, for_prazo_entrega FROM fornecedor  WHERE for_cod = '" + codigo + "' ", conexao.StringConexao))
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
    }
}
