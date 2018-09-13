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
    public class DAOTipoProduto
    {
        //ATRIBUTO PRIVADO
        private Conexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOTipoProduto(Conexao cx)
        {
            this.conexao = cx;
        }

        //METODO DE INSERIR NO BANCO OS DADOS DO USUARIO
        public bool Inserir(ModelTipoProduto modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO tipo_produto(tipo_descricao)" +
                    "VALUES (@descricao)";
                cmd.Parameters.AddWithValue("@descricao", modelo.tipo_descricao);

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
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT tipo_cod, tipo_descricao FROM tipo_produto ORDER BY tipo_descricao", conexao.StringConexao))
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

        public DataTable BuscaTipoProdutoPorId(int codigo)
        {
            DataTable tb = new DataTable();
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT A.tipo_cod, B.tipo_descricao FROM produto_tipo_produto AS A JOIN tipo_produto AS B WHERE A.tipo_cod = B.tipo_cod AND A.pro_cod = '" + codigo + "' ", conexao.StringConexao))
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
