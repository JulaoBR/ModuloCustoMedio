using System;

namespace ProEstoque.DAO
{
    public class ClasseConexao
    {
        public static String StringConexao
        {
            get
            {
                return @"Data Source=.\BancoDados\banco.sqlite;Version=3;";
                //return @"Data Source = C:\BD_pro_estoque\banco.sqlite;Version=3;";
            }
        }
    }
}
