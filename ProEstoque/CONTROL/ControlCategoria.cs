using ProEstoque.DAO;
using ProEstoque.MODEL;
using System.Data;

namespace ProEstoque.CONTROL
{
    public class ControlCategoria
    {
        private static Conexao cx = new Conexao(ClasseConexao.StringConexao);
        private DAOCategoria dao = new DAOCategoria(cx);

        public ControlCategoria()
        {

        }

        public bool Inserir(ModelCategoria modelo)
        {
            try
            {
                if (modelo.cat_descricao != string.Empty)
                {
                    dao.Inserir(modelo);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public DataTable BuscaDados()
        {
            try
            {
                DataTable dt = dao.BuscaDados();
                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
