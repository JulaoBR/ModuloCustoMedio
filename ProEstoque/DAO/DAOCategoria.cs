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
    public class DAOCategoria
    {
        //ATRIBUTO PRIVADO
        private Conexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOCategoria(Conexao cx)
        {
            this.conexao = cx;
        }

        //METODO DE INSERIR NO BANCO OS DADOS DO USUARIO
        public bool Inserir(ModelCategoria modelo)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO categoria_operacao(cat_descricao)" +
                    "VALUES (@descricao)";
                cmd.Parameters.AddWithValue("@descricao", modelo.cat_descricao);

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
                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT cat_cod, cat_descricao FROM categoria_operacao ORDER BY cat_descricao", conexao.StringConexao))
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
