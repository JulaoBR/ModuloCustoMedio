using System;
using System.Data.SQLite;

namespace ProEstoque.DAO
{
    public class Conexao
    {
        //ATRIBUTOS PRIVADOS
        private String _stringConexao;
        private SQLiteConnection _conexao;

        //CONSTRUTOR
        public Conexao(String dadosConexao)
        {
            this._conexao = new SQLiteConnection();
            this._stringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        //PROPRIEDADE PARA OS ATRIBUTOS PRIVADOS
        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        //PROPRIEDADE SQLITE CONEXAO 
        public SQLiteConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }

        //METODO DE CONECTAR NO BANCO
        public void Conectar()
        {
            if (_conexao != null)
            {
                _conexao.Close();
            }

            try
            {
                this._conexao.Open();
            }
            catch
            {
                //MessageBox.Show("Erro Na conexao com o banco!! " + erro);
            }

        }

        //METODO DE DESCONECTAR DO BANCO
        public void Desconectar()
        {

            try
            {
                this._conexao.Close();
            }
            catch
            {
                //MessageBox.Show("Erro ao desconectar do banco!! " + erro);
            }

        }
    }
}
