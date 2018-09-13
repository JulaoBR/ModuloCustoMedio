using ProEstoque.DAO;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProEstoque.CONTROL
{
    public class ControlVerificaEstoque
    {
        private static Conexao cx = new Conexao(ClasseConexao.StringConexao);
        private static DAOEmail dao = new DAOEmail(cx);

        public ControlVerificaEstoque()
        {

        }

        public static void VerificaEstoque(ModelRegistro registro)
        {
            try
            {
                decimal saldo_novo = registro.saldo - registro.quantidade;
                
                if(saldo_novo < registro.estoque_minimo)
                {
                    var indicador = dao.BuscaIndicador(registro.codProduto);
                    // indicador for = 0 email nao enviado
                    // indicador for = 1 email ja enviado

                    if (indicador != 0)
                    {
                        MessageBox.Show("O produto " + registro.descricao + " entro na zona de abastecimento\n" + "Estoque minimo: " + registro.estoque_minimo + "\nEstoque atual: " + saldo_novo, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("O produto " + registro.descricao + " entro na zona de abastecimento \n" + " Estoque minimo: " + registro.estoque_minimo + "\nEstoque atual: " + saldo_novo, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ControlEmail.EnviaEmail(registro);
                        dao.Update(registro.codProduto, 1);
                    }                  
                }
                else
                {

                }
            }
            catch
            {

            }
        }
    }
}
