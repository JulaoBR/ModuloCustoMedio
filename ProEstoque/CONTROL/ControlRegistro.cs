using ProEstoque.DAO;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProEstoque.CONTROL
{
    public class ControlRegistro
    {
        private static Conexao cx = new Conexao(ClasseConexao.StringConexao);
        private DAORegistro dao = new DAORegistro(cx);

        public ControlRegistro()
        {

        }

        public void InserirEntrada(ModelRegistro modelo)
        {
            try
            {
                if (modelo.for_cod != 0 && modelo.codProduto != 0 && modelo.quantidade != 0 && modelo.valorUnitario != 0)
                {
                    dao.InserirEntrada(modelo);
                }else
                {
                    MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    
            }
            catch
            {

            }
        }

        public bool InserirSaida(ModelRegistro modelo)
        {
            if ( modelo.codProduto != 0 && modelo.quantidade != 0 && modelo.tipo_cod != 0 && modelo.cat_cod != 0)
            {
                dao.InserirSaida(modelo);
                return true;
            }else
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public void ExcluiRegistroSaida(int codigo)
        {
            try
            {
                if (dao.ExcluiRegistroSaida(codigo))
                {
                    MessageBox.Show("Excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro na exclusão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {

            }
        }

        public void ExcluiRegistroEntrada(int codigo)
        {
            try
            {
                if (dao.ExcluiRegistroEntrada(codigo))
                {
                    MessageBox.Show("Excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro na exclusão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {

            }
        }

        public DataTable LocalizaEntrada(int cod_produto)
        {
            try
            {
                return dao.LocalizarEntrada(cod_produto);
            }
            catch
            {
                return null;
            }
        }

        public DataTable LocalizaEntradaFornecedor(int cod_produto, int cod_fornecedor)
        {
            try
            {
                return dao.LocalizarEntradaFornecedor(cod_produto, cod_fornecedor);
            }
            catch
            {
                return null;
            }
        }

        public DataTable LocalizaEntradaTodosFornecedores(string descricao)
        {
            try
            {
                return dao.LocalizarEntradaTodosFornecedores(descricao);
            }
            catch
            {
                return null;
            }
        }

        public DataTable BuscaDados(string descricao, string categotia, string data)
        {
            try
            {
                return dao.BuscaDados(descricao, categotia, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public List<ModelRegistro> BuscaDadosSaida(string descricao, string categotia, string data1, string data2)
        {
            try
            {
                DateTime dt1 = Convert.ToDateTime(data1);
                DateTime dt2 = Convert.ToDateTime(data2);
                var aux1 = dt1.ToString("yyyy-MM-dd 00:00:00");
                var aux2 = dt2.ToString("yyyy-MM-dd 00:00:00");

                var tabela = dao.BuscaDadosSaida(descricao, categotia, aux1, aux2);
                var lista = new List<ModelRegistro>();

                if (tabela.Rows.Count > 0)
                {
                    foreach (DataRow row in tabela.Rows)
                    {
                        lista.Add(new ModelRegistro()
                        {
                            reg_cod = Convert.ToInt32(row["reg_cod"].ToString()),
                            descricao = row["pro_descricao"].ToString(),
                            tipo_descricao = row["tipo_descricao"].ToString(),
                            quantidade = Convert.ToDecimal(row["reg_quantidade"].ToString()),
                            unidade_medida = row["pro_unidade_medida"].ToString(),
                            valorUnitario = Convert.ToDecimal(row["reg_valor_unitario"].ToString()),
                            valorTotal = Convert.ToDecimal(row["reg_valor_total"].ToString()),
                            dataOperacao = Convert.ToDateTime(row["reg_data_operacao"].ToString())
                        });
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public List<ModelRegistro> CalculaPercentual(int cod_fornecedor, int cod_produto, int tipo_de_busca)
        {
            try
            {
                DataTable dtRegistro;

                if (tipo_de_busca == 1)
                {
                    dtRegistro = LocalizaEntrada(cod_produto);
                }
                else
                {
                    dtRegistro = LocalizaEntradaFornecedor(cod_produto, cod_fornecedor);
                }

                List<ModelRegistro> listaRegistro = new List<ModelRegistro>();

                decimal valorAnterior = 0, aux= 0, aux2 = 0;
                
;
                for(int index = 0; index < dtRegistro.Rows.Count; index++)
                {
                    ModelRegistro modelo = new ModelRegistro();

                    modelo.reg_cod = Convert.ToInt32(dtRegistro.Rows[index]["reg_cod"].ToString());
                    modelo.for_cod = Convert.ToInt32(dtRegistro.Rows[index]["for_cod"].ToString());
                    modelo.fornecedor = dtRegistro.Rows[index]["for_descricao"].ToString();
                    modelo.quantidade = Convert.ToDecimal(dtRegistro.Rows[index]["reg_quantidade"].ToString());
                    modelo.valorUnitario = Convert.ToDecimal(dtRegistro.Rows[index]["reg_valor_unitario"].ToString());
                    modelo.custoMedio = Convert.ToDecimal(dtRegistro.Rows[index]["reg_custo_medio"].ToString());
                    modelo.saldo = Convert.ToDecimal(dtRegistro.Rows[index]["reg_saldo"].ToString());
                    modelo.valorFrete = Convert.ToDecimal(dtRegistro.Rows[index]["reg_valor_frete"].ToString());
                    modelo.valorTotal = Convert.ToDecimal(dtRegistro.Rows[index]["reg_valor_total"].ToString());
                    modelo.dataOperacao = Convert.ToDateTime(dtRegistro.Rows[index]["reg_data_operacao"].ToString());

                    if (index == 0)
                    {
                        modelo.valorPorcentual = 0;
                        valorAnterior = modelo.valorUnitario;
                    }
                    else
                    {
                        aux = modelo.valorUnitario - valorAnterior;
                        aux2 = aux / valorAnterior;
                        aux = aux2 * 100;

                        modelo.valorPorcentual = aux;

                        valorAnterior = modelo.valorUnitario;

                        aux  = 0;
                        aux2 = 0;
                    }

                    listaRegistro.Add(modelo);
                }

                return listaRegistro;
            }
            catch
            {
                return null;
            }
        }

        public ModelRegistro CustoMedio(int cod_produto)
        {//metodo para calcular o custo medio individual de cada produto
            try
            {
                decimal TotalEntrada = 0;
                decimal TotalSaida = 0;
                decimal QuantidadeEntrada = 0;
                decimal QuantidadeSaida = 0;
                ModelRegistro registro = new ModelRegistro();

                DataTable entrada = dao.LocalizarEntrada(cod_produto);
                DataTable saida = dao.LocalizarSaida(cod_produto);

                foreach (DataRow item in entrada.Rows)
                {                  
                    TotalEntrada += Convert.ToDecimal(item["reg_valor_total"].ToString());
                    QuantidadeEntrada += Convert.ToDecimal(item["reg_quantidade"].ToString());
                }

                foreach (DataRow item in saida.Rows)
                {                  
                    TotalSaida += Convert.ToDecimal(item["reg_valor_total"].ToString());
                    QuantidadeSaida += Convert.ToDecimal(item["reg_quantidade"].ToString());
                }

                decimal saldo = Convert.ToDecimal(String.Format("{0:N3}", QuantidadeEntrada - QuantidadeSaida));

                if (QuantidadeEntrada == 0 && QuantidadeSaida == 0)
                    QuantidadeEntrada = 1;

                if (saldo <= 0)
                    QuantidadeEntrada = 1;

                decimal custo = (TotalEntrada - TotalSaida) / (QuantidadeEntrada - QuantidadeSaida);


                registro.quantidade = saldo;
                registro.custoMedio = Convert.ToDecimal(String.Format("{0:N3}", custo));

                return registro;
            }
            catch
            {
                return null;
            }
        }

        public ModelRegistro CustoMedio2(int cod_produto, decimal valor, decimal quantidade)
        {//metodo para calcular o custo medio para salvar junto com o registro de entrada 
            try
            {
                Decimal TotalEntrada = 0;
                Decimal TotalSaida = 0;
                Decimal QuantidadeEntrada = 0;
                Decimal QuantidadeSaida = 0;
                ModelRegistro registro = new ModelRegistro();

                DataTable entrada = dao.LocalizarEntrada(cod_produto);
                DataTable saida = dao.LocalizarSaida(cod_produto);

                foreach (DataRow item in entrada.Rows)
                {
                    TotalEntrada += Convert.ToDecimal(item["reg_valor_total"].ToString());
                    QuantidadeEntrada += Convert.ToDecimal(item["reg_quantidade"].ToString());
                }

                foreach (DataRow item in saida.Rows)
                {
                    TotalSaida += Convert.ToDecimal(item["reg_valor_total"].ToString());
                    QuantidadeSaida += Convert.ToDecimal(item["reg_quantidade"].ToString());
                }

                //recebe o novo valor e adiciona ao valor ja cadastrado
                TotalEntrada += valor;
                //recebe a nova quantidade 
                QuantidadeEntrada += quantidade;

                Decimal saldo = Convert.ToDecimal(String.Format("{0:N3}", QuantidadeEntrada - QuantidadeSaida));

                if (QuantidadeEntrada == 0 && QuantidadeSaida == 0)
                    QuantidadeEntrada = 1;

                Decimal custo = (TotalEntrada - TotalSaida) / (QuantidadeEntrada - QuantidadeSaida);


                registro.quantidade = saldo;
                registro.custoMedio = Convert.ToDecimal(String.Format("{0:N3}", custo));

                return registro;
            }
            catch
            {
                return null;
            }
        }

        public Decimal SaldoEstoque(int cod_produto)
        {
            try
            {
                Decimal QuantidadeEntrada = 0;
                Decimal QuantidadeSaida = 0;

                DataTable entrada = dao.LocalizarEntrada(cod_produto);
                DataTable saida = dao.LocalizarSaida(cod_produto);

                foreach (DataRow item in entrada.Rows)
                {
                    QuantidadeEntrada += Convert.ToDecimal(item["reg_quantidade"].ToString());
                }

                foreach (DataRow item in saida.Rows)
                {
                    QuantidadeSaida += Convert.ToDecimal(item["reg_quantidade"].ToString());
                }

                Decimal retorno = QuantidadeEntrada - QuantidadeSaida;

                return Convert.ToDecimal(String.Format("{0:N2}", retorno));
            }
            catch
            {
                return 0;
            }
        }

        public List<ModelRegistro> CalculaSaldo(string codigo, string descricao, string categotia)
        {
            try
            {
                ControlProduto controleProduto = new ControlProduto();
                //busa lista de produtos
                DataTable tbProduto = controleProduto.BuscaDados(codigo,  descricao, categotia);
                List<ModelRegistro> listaItens = new List<ModelRegistro>()
;
                foreach (DataRow item in tbProduto.Rows)
                {
                    ModelRegistro modelo = new ModelRegistro();


                    modelo.codProduto = Convert.ToInt32(item["CODIGO"].ToString());
                    modelo.descricao = item["DESCRIÇÃO"].ToString();
                    modelo.categoria = item["CATEGORIA"].ToString();
                    modelo.estoque_minimo = Convert.ToDecimal(item["QTD MINIMA"].ToString());
                    modelo.unidade_medida = item["MEDIDA"].ToString();

                    ModelRegistro aux = CustoMedio(modelo.codProduto);

                    modelo.quantidade = aux.quantidade;
                    modelo.valorUnitario = aux.custoMedio;
                    modelo.valorTotal = Convert.ToDecimal(String.Format("{0:N3}", modelo.quantidade * modelo.valorUnitario));

                    listaItens.Add(modelo);                   
                }

                return listaItens;
            }
            catch
            {
                return null;
            }
        }

        public static List<ModelRegistro> BuscaProdutoEstoqueMinimo(List<ModelRegistro> lista)
        {
            List<ModelRegistro> listaAux = new List<ModelRegistro>();

            foreach (var item in lista)
            {
                if (item.quantidade < item.estoque_minimo)
                {
                    listaAux.Add(item);
                }
            }

            return listaAux;
        }

        public int BuscaUltimoId()
        {
            try
            {
                int retorno = dao.BuscaUltimoId();

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


    }
}
