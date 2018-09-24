using ProEstoque.CONTROL;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ProEstoque.FORMS
{
    public partial class frmPedido : Form
    {

        private decimal valor = 0;
        private decimal quantidade = 0;
        private decimal frete = 0;
        private decimal total = 0;
        private int opcao = 0; // 1 = pedido e 2 = cotação
        private List<ModelRegistro> listaRegistro = new List<ModelRegistro>();
        private ModelPedido modeloPedido = new ModelPedido();

        public frmPedido()
        {
            InitializeComponent();
            grid.AutoGenerateColumns = false;
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            CarregaFornecedor();
            CarregaProduto();
            AtualizaNumeroPedido();
        }

        private void AtualizaNumeroPedido()
        {
            ControlPedido pedido = new ControlPedido();
            txtIdPedido.Text = "Nº 0" + (pedido.BuscaUltimoIdPedido() + 1);
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void maskedTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void radioButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void radioButton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void radioButton3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void CarregaFornecedor()
        {
            try
            {
                ControlFornecedor control = new ControlFornecedor();

                cbFornecedor.DataSource = control.BuscaDados();
                cbFornecedor.DisplayMember = "for_descricao";
                cbFornecedor.ValueMember = "for_cod";
                cbFornecedor.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os fornecedores: " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CarregaProduto()
        {
            try
            {
                ControlProduto control = new ControlProduto();

                cbProduto.DataSource = control.BuscaDados();
                cbProduto.DisplayMember = "pro_descricao";
                cbProduto.ValueMember = "pro_cod";
                cbProduto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os fornecedores: " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CalculaTotal()
        {
            try
            {
                total = (quantidade * valor) + frete;

                txtTotal.Text = String.Format("{0:F3}", total);
            }
            catch
            {

            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                quantidade = Convert.ToDecimal(txtQuantidade.Text);
                CalculaTotal();
            }
            catch
            {
                quantidade = 0;
                CalculaTotal();
            }
        }

        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valor = Convert.ToDecimal(txtValorUnitario.Text);
                CalculaTotal();
            }
            catch
            {
                valor = 0;
                CalculaTotal();
            }
        }

        private void txtValorFrete_TextChanged(object sender, EventArgs e)
        {
            try
            {
                frete = Convert.ToDecimal(txtValorFrete.Text);
                CalculaTotal();
            }
            catch
            {
                frete = 0;
                CalculaTotal();
            }
        }

        private void AdicionaRegistroLista()
        {
            try
            {

                ModelRegistro registro = new ModelRegistro();

                registro.codProduto = Convert.ToInt32(cbProduto.SelectedValue);
                registro.for_cod = Convert.ToInt32(cbFornecedor.SelectedValue);
                registro.descricao = cbProduto.Text;
                registro.quantidade = Convert.ToDecimal(txtQuantidade.Text);
                registro.valorUnitario = valor;
                registro.valorFrete = frete;
                registro.valorTotal = total;
                registro.dataOperacao = Convert.ToDateTime(txtDataPedido.Text);

                registro.reg_status = 0;

                if (VerificaListaTipo(Convert.ToInt32(cbProduto.SelectedValue)))
                {
                    listaRegistro.Add(registro);

                    PreencheGrid();
                }
                else
                {
                    MessageBox.Show("Tipo de produto ja foi selecionado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                // MessageBox.Show("Erro ao adicionar fornecedor!");
            }
        }

        private bool VerificaListaTipo(int codigo)
        {
            try
            {
                foreach (var item in listaRegistro)
                {
                    if (item.codProduto == codigo)
                        return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void PreencheGrid()
        {
            grid.DataSource = null;
            grid.DataSource = listaRegistro;
            grid.ClearSelection();
            grid.AllowUserToAddRows = false;
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            AdicionaRegistroLista();
            LimpaProduto();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int codigo = Convert.ToInt32(grid.Rows[e.RowIndex].Cells[0].Value);

                    foreach (var item in listaRegistro)
                    {
                        if (codigo == item.codProduto)
                        {
                            //Comando que questiona ao usuário se relamente deseja sair do programa
                            DialogResult result = MessageBox.Show("Deseja remover este item?",
                               "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                listaRegistro.Remove(item);
                                PreencheGrid();
                            }
                        }
                    }
                }
            }
            catch
            {
                //tratamento sem necessidade
            }
        }

        private void LimpaProduto()
        {
            txtQuantidade.Clear();
            txtValorFrete.Clear();
            txtTotal.Clear();
            txtValorUnitario.Clear();
            txtTotal.Clear();
            cbProduto.SelectedIndex = -1;
        }

        private void LimpaFornecedor()
        {
            txtContato.Clear();
            cbFornecedor.SelectedIndex = 0;
            cbFormaPagamento.SelectedIndex = -1;
            txtFormaPagamento.Clear();
            txtObservacao.Clear();

            grid.DataSource = null;
            grid.Refresh();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlPedido pedido = new ControlPedido();
                modeloPedido.ped_cod = pedido.BuscaUltimoIdPedido() + 1;

                modeloPedido.ped_data_pedido = Convert.ToDateTime(txtDataPedido.Text);
                modeloPedido.ped_data_prevista = Convert.ToDateTime(txtDataPrevista.Text);
                modeloPedido.ped_contato = txtContato.Text;
                modeloPedido.ped_forma_pagamento = txtFormaPagamento.Text;
                modeloPedido.for_descricao = cbFornecedor.Text;
                modeloPedido.for_cod = Convert.ToInt32(cbFornecedor.SelectedValue);
                modeloPedido.ped_observacao = txtObservacao.Text;
                modeloPedido.status = 0;

                modeloPedido.for_email = txtEmail.Text;
                modeloPedido.for_prazo_entrega = Convert.ToInt32(txtPrazo.Text);

                modeloPedido.ped_condicao_pagamento = cbFormaPagamento.Text;

                switch (opcao)
                {
                    case 1:
                        SalvaPedido();
                        break;
                    case 2:
                        modeloPedido.ped_valor_frete = frete;
                        SalvarCotacao();
                        break;
                    default:
                        MessageBox.Show("Selecione uma opção: PEDIDO ou COTAÇÃO", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }              
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SalvarCotacao()
        {
            ControlCotacao cotacao = new ControlCotacao();
            if (cotacao.Inserir(modeloPedido, listaRegistro))
            {               
                LimpaProduto();
                LimpaFornecedor();
                ZeraTudo();
                listaRegistro.Clear();
                this.Refresh();
                rbCotacao.Checked = false;
            }
            else
            {
                MessageBox.Show("Confira os campos digitados", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void SalvaPedido()
        {
            ControlPedido pedido = new ControlPedido();
            if (pedido.Inserir(modeloPedido, listaRegistro))
            {
                //Comando que questiona ao usuário se relamente deseja sair do programa
                DialogResult result = MessageBox.Show("Deseja imprimir a formalização?",
                   "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ImprimirPedido();
                }
                LimpaProduto();
                LimpaFornecedor();
                ZeraTudo();
                listaRegistro.Clear();
                AtualizaNumeroPedido();
                this.Refresh();
                rbPedido.Checked = false;
            }
            else
            {
                MessageBox.Show("Confira os campos digitados", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaFornecedor();
            LimpaProduto();
            ZeraTudo();
            listaRegistro.Clear();
            AtualizaNumeroPedido();
            this.Refresh();
        }

        private void ImprimirPedido()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            PrintPreviewDialog objPrintPreview = new PrintPreviewDialog();
            var _with1 = objPrintPreview;
            _with1.Document = pd;
            _with1.WindowState = FormWindowState.Maximized;
            _with1.PrintPreviewControl.Zoom = 1;
            _with1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            ImprimirPedido re = new ImprimirPedido(sender, e);
            re.Relatorio(modeloPedido, listaRegistro);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ControlPedido control = new ControlPedido();
            frmBuscaPedidos pedido = new frmBuscaPedidos(0, 1);
            pedido.ShowDialog();
        }

        private void cbFornecedor_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                ControlFornecedor control = new ControlFornecedor();
                var fornecedor = control.BuscaFornecedorUmFornecedor(Convert.ToInt32(cbFornecedor.SelectedValue));

                txtEmail.Text = fornecedor.for_email;
                txtPrazo.Text = Convert.ToString(fornecedor.for_prazo_entrega);

                var aux = Convert.ToDateTime(txtDataPedido.Text);

                while (i < fornecedor.for_prazo_entrega)
                {
                    switch (aux.DayOfWeek)
                    {
                        case DayOfWeek.Saturday:
                            aux = aux.AddDays(2);
                            break;

                        case DayOfWeek.Sunday:
                            aux = aux.AddDays(1);
                            break;

                        default:
                            aux = aux.AddDays(1);
                            if(ControlPedido.VerificaFeriado(aux) == true)
                                i++;
                            break;
                    }
                    i++;
                }

                txtDataPrevista.Text = aux.ToString();
            }
            catch
            {

            }
        }

        private void ZeraTudo()
        {
            valor = 0;
            quantidade = 0;
            frete = 0;
            total = 0;
        }

        private void frmPedido_KeyDown(object sender, KeyEventArgs e)
        {
            //apaga o texto ao apertar o botao ESC
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void rbPedido_CheckedChanged(object sender, EventArgs e)
        {
            opcao = 1;
        }

        private void rbCotacao_CheckedChanged(object sender, EventArgs e)
        {
            opcao = 2;
        }
    }
 }


