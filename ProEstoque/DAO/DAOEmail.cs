using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEstoque.DAO
{
    public class DAOEmail
    {
        //ATRIBUTO PRIVADO
        private Conexao conexao;

        //CONSTRUTOR DA CLASSE
        public DAOEmail(Conexao cx)
        {
            this.conexao = cx;
        }

       
        public bool Update(int codigo ,int indicador)
        {
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE envio_email SET env_indicador = @envIndicador WHERE pro_cod = @cod";
                cmd.Parameters.AddWithValue("@envIndicador", indicador);
                cmd.Parameters.AddWithValue("@cod", codigo);

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

        public int BuscaIndicador(int codigo)      //BUSCA POR ID
        {
            DataTable tb = new DataTable();
            int retorno = 0;
            try
            {

                using (SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT env_indicador FROM envio_email WHERE pro_cod = '"+codigo+"'", conexao.StringConexao))
                {
                    da.Fill(tb);
                    conexao.Desconectar();

                    retorno = Convert.ToInt32(tb.Rows[0]["env_indicador"].ToString());

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
