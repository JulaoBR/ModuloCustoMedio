using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEstoque.CONTROL
{
    public class ControlPermissao
    {

        public ControlPermissao()
        {

        }

        // retorno 0 = acesso negado
        // retorno 1 = acesso estoque
        // retorno 2 = acesso geral
        public static int ControleAcesso(string senha)
        {
            if (senha.Equals("ESTOQUE"))
            {
                return 1 ;
            }
            else if(senha.Equals("lott@2018"))
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
