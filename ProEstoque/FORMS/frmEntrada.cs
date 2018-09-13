using ProEstoque.CONTROL;
using ProEstoque.FORMS;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmEntrada : Form
    {

        private decimal frete = 0;
        private decimal val_total = 0;
        private decimal quantidade = 0;
        private decimal aux = 0;
        private List<ModelRegistro> listaRegistro;

        public frmEntrada()
        {
            InitializeComponent();
            gridProduto.AutoGenerateColumns = false;
        }

        private void frmEntrada_Load(object sender, EventArgs e)
        {        
            LimpaCampoProduto();          
        }

       
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModelPedido pedido = new ModelPedido();
                ModelRegistro registro = new ModelRegistro();
                ControlRegistro control = new ControlRegistro();
                ControlPedido control2 = new ControlPedido();
                foreach (var item in listaRegistro)
                {
                    ModelRegistro aux;
                    //recebe valores do custo medio e saldo atual
                    aux = control.CustoMedio2(item.codProduto, item.valorTotal, item.quantidade);
                    item.custoMedio = aux.custoMedio;
                    item.saldo = aux.quantidade;
                    item.dataOperacao = Convert.ToDateTime(dataOperacao.Text);
                    item.reg_status = 1;
                }
                pedido.ped_cod = Convert.ToInt32(txtCodPedido.Text);
                pedido.status = 1;
                pedido.ped_data_entrega = Convert.ToDateTime(dataOperacao.Text);

                control2.UpdateRecebimento(pedido, listaRegistro);

                LimpaCampoProduto();
                LimpaFornecedor();
                gridProduto.DataSource = null;
                listaRegistro.Clear();              
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpaCampoProduto()
        {
            txtCodRegistro.Clear();
            txtProduto.Clear();
            txtQuantidade.Clear();
            txtFrete.Clear();
            txtValorUnitario.Clear();
            txtValorTotal.Clear();
            labelTotal.Text = "";
        }

        private void LimpaFornecedor()
        {
            txtDescricao.Clear();
            txtContato.Clear();
            txtDataPedido.Clear();
            txtDataPrevista.Clear();
            txtObservacao.Clear();
            txtCodPedido.Clear();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaDados busca = new frmBuscaDados();
                busca.ShowDialog();

                if (busca.codigo != 0)
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PreencheCampos(int codigo)
        {
            try
            {
                ControlProduto control = new ControlProduto();
                ModelProduto produto = new ModelProduto();
                produto = control.BuscaProduto(codigo);

                txtCodPedido.Text = Convert.ToString(produto.codProduto);
                txtDescricao.Text = produto.descricao;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CalculaTotal()
        {
            try
            {
                aux = 0;
                quantidade = Convert.ToDecimal(txtQuantidade.Text);
                frete = Convert.ToDecimal(txtFrete.Text);
                val_total = Convert.ToDecimal(txtValorTotal.Text);


                aux = (val_total + frete) / quantidade;
             
                txtValorUnitario.Text = String.Format("{0:F3}", aux);
            }
            catch
            {
                quantidade = 0;
                frete = 0;
                val_total = 0;
                txtValorUnitario.Clear();
            }
        }

        private void LabelInformacao()
        {
            labelTotal.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampoProduto();
            LimpaFornecedor();

            listaRegistro.Clear();
            gridProduto.DataSource = null;
            gridProduto.Refresh();
        }

        private void CarregaInformacoes()
        {
            try
            {
                decimal aux = 0;
                foreach (var item in listaRegistro)
                {
                    aux += item.valorTotal;
                }

                labelTotal.Text = "VALOR TOTAL: " + String.Format("{0:C2}", aux);
            }
            catch
            {

            }
        }

 
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtFrete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmBuscaTodosPedidos entrada = new frmBuscaTodosPedidos();
            entrada.ShowDialog();
        }


        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtFrete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void frmEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            //apaga o texto ao apertar o botao ESC
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cbFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                txtQuantidade.Focus();
            }
        }

        private void txtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlPedido control = new ControlPedido();
            frmBuscaPedidos pedido = new frmBuscaPedidos(0, 0);
            pedido.ShowDialog();

            if (pedido.codigo != 0)
            {
                txtCodPedido.Text = Convert.ToString(pedido.codigo);
                PreencheFornecedor(control.BuscaDadosPedido(pedido.codigo));
                listaRegistro = control.BuscaRegistroEntradaPedido(pedido.codigo);
                CarregaInformacoes();
                PreencheGrid();
            }
        }

        private void PreencheGrid()
        {
            gridProduto.DataSource = null;
            gridProduto.DataSource = listaRegistro;
            gridProduto.ClearSelection();
            gridProduto.AllowUserToAddRows = false;
        }


        private void PreencheFornecedor(ModelPedido modelo)
        {
            txtDescricao.Text = modelo.for_descricao;
            txtDataPedido.Text = modelo.ped_data_pedido.ToString("dd/MM/yyyy");
            txtDataPrevista.Text = modelo.ped_data_prevista.ToString("dd/MM/yyyy");
            txtContato.Text = modelo.ped_contato;
            txtObservacao.Text = modelo.ped_observacao;
        }

        private void gridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(gridProduto["reg_cod", e.RowIndex].Value);
                var registro = listaRegistro.Single(x => x.reg_cod == codigo);

                PreencheCampoProduto(registro);
                CalculaTotal();                       
            }
            catch
            {
                //sem tratamento
            }
        }

        private void AtualizaLista()
        {
            foreach (var item in listaRegistro)
            {
                if (item.reg_cod == Convert.ToUInt32(txtCodRegistro.Text))
                {
                    item.valorFrete = frete;
                    item.valorTotal = val_total + frete;
                    item.quantidade = quantidade;
                    item.valorUnitario = Convert.ToDecimal(txtValorUnitario.Text);

                    PreencheGrid();
                }
            }
        }

        private void PreencheCampoProduto(ModelRegistro modelo)
        {
            txtCodRegistro.Text = modelo.reg_cod.ToString();
            txtProduto.Text = modelo.descricao;
            txtQuantidade.Text = modelo.quantidade.ToString();
            txtFrete.Text = modelo.valorFrete.ToString();
            txtValorUnitario.Text = modelo.valorUnitario.ToString();
            txtValorTotal.Text = modelo.valorTotal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtQuantidade.Text != "" && txtFrete.Text != "" && txtValorTotal.Text != "")
            {
                CalculaTotal();
                AtualizaLista();
                LimpaCampoProduto();
            }
            else
            {
                MessageBox.Show("Valores invalidos","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
