using ProEstoque.DAO;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProEstoque.CONTROL
{
    public class ControlPedido
    {
        private static Conexao cx = new Conexao(ClasseConexao.StringConexao);
        private DAOPedido daoPedido = new DAOPedido(cx);
        private DAORegistro daoRegistro = new DAORegistro(cx);
        private DAOEmail daoEmail = new DAOEmail(cx);
        private DataTable tabela;
        private string descricao;
        private string data1;
        private string data2;

        public ControlPedido()
        {

        }

        public ControlPedido(string descricao)
        {
            this.descricao = descricao;
        }

        public bool Inserir(ModelPedido pedido, List<ModelRegistro> listaRegistro)
        {
            try
            {
                if (listaRegistro.Count > 0 && Convert.ToString(pedido.ped_data_pedido) != "" && Convert.ToString(pedido.ped_data_prevista) != "")
                {
                    //INSERE NA TABELA DE PEDIDO
                    daoPedido.Inserir(pedido);

                    //BUSCA ULTIMO ID DA TABELA PEDIDO
                    int ultimoId = daoPedido.BuscaUltimoId();

                    foreach (var item in listaRegistro)
                    {
                        var registro = new ModelRegistro();

                        registro.codProduto = item.codProduto;
                        registro.for_cod = item.for_cod;
                        registro.quantidade = item.quantidade;
                        registro.valorFrete = item.valorFrete;
                        registro.valorUnitario = item.valorUnitario;
                        registro.valorTotal = item.valorTotal;
                        registro.dataOperacao = item.dataOperacao;
                        registro.reg_status = item.reg_status;

                        //INSERE NA TABELA REGISTRO
                        daoRegistro.InserirEntrada(registro);

                        daoPedido.InserirPedidoRegistro(ultimoId, BuscaUltimoIdRegistro());
                    }

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

        public bool UpdateRecebimento(ModelPedido pedido, List<ModelRegistro> listaRegistro)
        {
            try
            {
                if (listaRegistro.Count > 0 && Convert.ToString(pedido.ped_data_pedido) != "" && Convert.ToString(pedido.ped_data_prevista) != "")
                {
                    //INSERE NA TABELA DE PEDIDO
                    daoPedido.UpdateRecebimento(pedido);

                    foreach (var item in listaRegistro)
                    {
                        var registro = new ModelRegistro();

                        registro.reg_cod = item.reg_cod;
                        registro.quantidade = item.quantidade;
                        registro.valorFrete = item.valorFrete;
                        registro.valorUnitario = item.valorUnitario;
                        registro.custoMedio = item.custoMedio;
                        registro.saldo = item.saldo;
                        registro.valorTotal = item.valorTotal;
                        registro.dataOperacao = item.dataOperacao;
                        registro.reg_status = item.reg_status;

                        //INSERE NA TABELA REGISTRO
                        daoRegistro.UpdateRecebimento(registro);
                        //ATUALIZA TABELA DE ENVIO DE EMAIL PARA 0 INDICANDO QUE O ESTOQUE ESTA NORMALIZADO
                        daoEmail.Update(registro.codProduto, 0);

                    }

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


        public int BuscaUltimoIdRegistro()
        {
            try
            {
                int retorno = daoRegistro.BuscaUltimoIdEntrada();

                if (retorno == 0)
                {
                    MessageBox.Show("Erro ao buscar codigo do fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                else
                {
                    return retorno;
                }
            }
            catch
            {
                return 0;
            }
        }

        public int BuscaUltimoIdPedido()
        {
            try
            {
                int retorno = daoPedido.BuscaUltimoId();

                if (retorno == 0)
                {
                    return 0;
                }
                else
                {
                    return retorno;
                }
            }
            catch
            {
                return 0;
            }
        }

        public List<ModelPedido> BuscaDados(int opcao)
        {
            try
            {
                if(opcao == 0)
                {
                    tabela = daoPedido.BuscaDadosNaoRecebidos(descricao);
                }else if(opcao == 1)
                {
                    tabela = daoPedido.BuscaDadosRecebidos(descricao);
                }else if(opcao == 2)
                {
                    tabela = daoPedido.BuscaTodosPedidos(descricao);
                }
                    
                var lista = new List<ModelPedido>();

                foreach (DataRow item in tabela.Rows)
                {
                    var modelo = new ModelPedido();

                    modelo.ped_cod = Convert.ToInt32(item["ped_cod"].ToString());
                    modelo.pro_descricao = item["pro_descricao"].ToString();
                    modelo.for_descricao = item["for_descricao"].ToString();
                    modelo.ped_data_pedido = Convert.ToDateTime(item["ped_data_pedido"].ToString());
                    modelo.ped_data_prevista = Convert.ToDateTime(item["ped_data_prevista"].ToString());                    
                    modelo.ped_observacao = item["ped_observacao"].ToString();
                    modelo.ped_quantidade = Convert.ToDecimal(item["reg_quantidade"].ToString());
                    modelo.unidade_medida = item["pro_unidade_medida"].ToString();

                    if (Convert.ToInt32(item["ped_status"].ToString()) == 0)
                    {
                        modelo.ped_status = "NÃO RECEBIDO";
                    }
                    else
                    {
                        modelo.ped_status = "RECEBIDO";
                        modelo.ped_data_entrega = Convert.ToDateTime(item["ped_data_entrega"].ToString());
                    }                  

                    lista.Add(modelo);
                }

                lista = lista.OrderBy(c => c.ped_data_prevista).ToList();

                return lista;
            }
            catch
            {
                return null;
            }
        }

        public void ExcluiPedido(int codigo)
        {
            try
            {
                var codRegistro = daoPedido.BuscaIdPedidoRegistro(codigo);

                daoPedido.ExcluiPedidoRegistro(codigo);
                daoPedido.ExcluiPedido(codigo);
                daoRegistro.ExcluiRegistroEntrada(codRegistro);
            }
            catch
            {
                MessageBox.Show("Erro na exclusão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public ModelPedido BuscaDadosPedido(int codigo)
        {
            try
            {
                ModelPedido modelo = new ModelPedido();
                DataTable dt = daoPedido.BuscaDadosPedido(codigo);

                modelo.ped_cod = Convert.ToInt32(dt.Rows[0]["ped_cod"].ToString());
                modelo.for_descricao = dt.Rows[0]["for_descricao"].ToString();
                modelo.ped_contato = dt.Rows[0]["ped_contato"].ToString();
                modelo.ped_data_pedido = Convert.ToDateTime(dt.Rows[0]["ped_data_pedido"].ToString());
                modelo.ped_data_prevista = Convert.ToDateTime(dt.Rows[0]["ped_data_prevista"].ToString());
                modelo.ped_forma_pagamento = dt.Rows[0]["ped_forma_pagamento"].ToString();
                modelo.ped_condicao_pagamento = dt.Rows[0]["ped_condicao_pagamento"].ToString();
                modelo.ped_observacao = dt.Rows[0]["ped_observacao"].ToString();
                if (Convert.ToInt32(dt.Rows[0]["ped_status"].ToString()) == 0)
                {
                    modelo.ped_status = "Não Recebido";
                }
                else
                {
                    modelo.ped_status = "Recebido";
                }


                if(dt.Rows[0]["ped_data_entrega"].ToString() != "")
                    modelo.ped_data_entrega = Convert.ToDateTime(dt.Rows[0]["ped_data_entrega"].ToString());

                return modelo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public ModelPedido BuscaPedidoNaoRecebido(int codigo)
        {
            try
            {
                ModelPedido modelo = new ModelPedido();
                DataTable dt = daoPedido.BuscaPedidoNaoRecebido(codigo);

                if (dt.Rows.Count == 0)
                    return null;

                modelo.ped_cod = Convert.ToInt32(dt.Rows[0]["ped_cod"].ToString());
                modelo.for_descricao = dt.Rows[0]["for_descricao"].ToString();
                modelo.ped_data_pedido = Convert.ToDateTime(dt.Rows[0]["ped_data_pedido"].ToString());
                modelo.ped_data_prevista = Convert.ToDateTime(dt.Rows[0]["ped_data_prevista"].ToString());
                modelo.ped_quantidade = Convert.ToDecimal(dt.Rows[0]["reg_quantidade"].ToString());
                modelo.unidade_medida = dt.Rows[0]["pro_unidade_medida"].ToString();
                modelo.ped_observacao = dt.Rows[0]["ped_observacao"].ToString();
                if (Convert.ToInt32(dt.Rows[0]["ped_status"].ToString()) == 0)
                {
                    modelo.ped_status = "Não Recebido";
                }
                else
                {
                    modelo.ped_status = "Recebido";
                }

                return modelo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public ModelPedido BuscaPedidoExibir(int codigo)
        {
            try
            {
                ModelPedido modelo = new ModelPedido();
                DataTable dt = daoPedido.BuscaPedidoExibir(codigo);

                if (dt.Rows.Count == 0)
                    return null;

                modelo.ped_cod = Convert.ToInt32(dt.Rows[0]["ped_cod"].ToString());
                modelo.for_descricao = dt.Rows[0]["for_descricao"].ToString();
                modelo.for_email = dt.Rows[0]["for_email"].ToString();
                modelo.ped_contato = dt.Rows[0]["ped_contato"].ToString();
                modelo.for_prazo_entrega = int.Parse(dt.Rows[0]["for_prazo_entrega"].ToString());
                modelo.ped_data_pedido = Convert.ToDateTime(dt.Rows[0]["ped_data_pedido"].ToString());
                modelo.ped_data_prevista = Convert.ToDateTime(dt.Rows[0]["ped_data_prevista"].ToString());
                modelo.ped_condicao_pagamento = dt.Rows[0]["ped_condicao_pagamento"].ToString();
                modelo.ped_forma_pagamento = dt.Rows[0]["ped_forma_pagamento"].ToString();
                modelo.ped_observacao = dt.Rows[0]["ped_observacao"].ToString();
                if (Convert.ToInt32(dt.Rows[0]["ped_status"].ToString()) == 0)
                {
                    modelo.ped_status = "Não Recebido";
                }
                else
                {
                    modelo.ped_status = "Recebido";
                }

                return modelo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public List<ModelRegistro> BuscaRegistroEntradaPedido(int codigo)
        {
            try
            {
                DataTable dt = daoPedido.BuscaRegistroEntradaPedido(codigo);
                List<ModelRegistro> lista = new List<ModelRegistro>();

                foreach (DataRow item in dt.Rows)
                {
                    ModelRegistro modelo = new ModelRegistro();

                    modelo.codProduto = Convert.ToInt32(item["pro_cod"].ToString());
                    modelo.reg_cod = Convert.ToInt32(item["reg_cod"].ToString());
                    modelo.descricao = item["pro_descricao"].ToString();
                    modelo.quantidade = Convert.ToDecimal(item["reg_quantidade"].ToString());
                    modelo.valorUnitario = Convert.ToDecimal(item["reg_valor_unitario"].ToString());
                    modelo.valorFrete = Convert.ToDecimal(item["reg_valor_frete"].ToString());
                    modelo.valorTotal = Convert.ToDecimal(item["reg_valor_total"].ToString());

                    lista.Add(modelo);

                }

                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }   

        public static bool VerificaFeriado(DateTime data)
        {
            List<DateTime> feriado = new List<DateTime>();

            feriado.Add(new DateTime(2018, 09, 07));
            feriado.Add(new DateTime(2018, 09, 14));
            feriado.Add(new DateTime(2018, 10, 12));
            feriado.Add(new DateTime(2018, 11, 02));
            feriado.Add(new DateTime(2018, 11, 15));
            feriado.Add(new DateTime(2018, 12, 25));

            foreach (var item in feriado)
            {
                if (item == data)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;    
        }
    }
}
