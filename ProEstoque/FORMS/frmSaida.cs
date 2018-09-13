using ProEstoque.CONTROL;
using ProEstoque.FORMS;
using ProEstoque.MODEL;
using System;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmSaida : Form
    {
        private decimal valor_total = 0;
        private decimal valor_unitario = 0;
        private decimal estoque_minimo = 0;
        private decimal saldo = 0;

        public frmSaida()
        {
            InitializeComponent();
        }

        private void frmSaida_Load(object sender, EventArgs e)
        {
            LimpaCampo();
            CarregaCategoriaSaida();
        }

        private void CarregaTipoProduto()
        {
            try
            {
                ControlTipoProduto control = new ControlTipoProduto();

                cbTipoProduto.DataSource = control.BuscaTipoProdutoId(Convert.ToInt32(txtCodProduto.Text));
                cbTipoProduto.DisplayMember = "tipo_descricao";
                cbTipoProduto.ValueMember = "tipo_cod";
                cbTipoProduto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os tipos de produto: " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CarregaCategoriaSaida()
        {
            try
            {
                ControlCategoria control = new ControlCategoria();

                cbCategoriaSaida.DataSource = control.BuscaDados();
                cbCategoriaSaida.DisplayMember = "cat_descricao";
                cbCategoriaSaida.ValueMember = "cat_cod";
                cbCategoriaSaida.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as categorias: " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModelRegistro registro = new ModelRegistro();
                ControlRegistro control = new ControlRegistro();

                registro.codProduto = Convert.ToInt32(txtCodProduto.Text);
                registro.tipo_cod = Convert.ToInt32(cbTipoProduto.SelectedValue);
                registro.cat_cod = Convert.ToInt32(cbCategoriaSaida.SelectedValue);
                registro.quantidade = Convert.ToDecimal(txtQuantidade.Text);
                registro.dataOperacao = Convert.ToDateTime(dataOperacao.Text);
                registro.descricao = txtDescricao.Text;

                registro.estoque_minimo = estoque_minimo;
                registro.saldo = saldo;
                
                if (control.InserirSaida(registro))
                {
                    ControlVerificaEstoque.VerificaEstoque(registro);
                }

                LimpaCampo();
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpaCampo()
        {
            txtCodProduto.Focus();

            txtCodProduto.Clear();
            txtDescricao.Clear();
            txtQuantidade.Clear();
            labelSaldo.Text = "";
            cbCategoriaSaida.SelectedIndex = -1;
            cbTipoProduto.DataSource = null;

            labelSaldo.Visible = false;

        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                int opc = 0;
                if (rbEmbalagem.Checked)
                    opc = 1;
                if (rbMateriaPrima.Checked)
                    opc = 2;
                if (rbProdutoLimpeza.Checked)
                    opc = 3;

                frmBuscaDados busca = new frmBuscaDados(opc);
                busca.ShowDialog();

                if (busca.codigo != 0)
                {
                    CarregaInformacoes(busca.codigo);
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

                estoque_minimo = produto.estoque_minimo;
                txtCodProduto.Text = Convert.ToString(produto.codProduto);
                txtDescricao.Text = produto.descricao;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Decimal aux = Convert.ToDecimal(txtQuantidade.Text);
                Decimal aux2 = valor_unitario;

                Decimal aux3 = aux * aux2;

                valor_total = aux3;
            }
            catch
            {
                valor_total = 0;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void LabelInformacao()
        {
            labelSaldo.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmBuscaSaida saida = new frmBuscaSaida();
            saida.ShowDialog();
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                CarregaInformacoes(Convert.ToInt32(txtCodProduto.Text));
            }
            catch
            {

            }
            
        }

        private void CarregaInformacoes(int codigo)
        {
            try
            {
                ControlProduto prod = new ControlProduto();
                if (prod.VerificaProduto(codigo) != null)
                {
                    ControlRegistro control = new ControlRegistro();
                    PreencheCampos(Convert.ToInt32(codigo));

                    ModelRegistro aux = control.CustoMedio(codigo);

                    CarregaTipoProduto();
                    LabelInformacao();
                    labelSaldo.Text = "SALDO EM ESTOQUE " + String.Format("{0:N3}", aux.quantidade);
                    saldo = aux.quantidade;
                    valor_unitario = aux.custoMedio;
                }
                else
                {
                    MessageBox.Show("Produto não cadastrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodProduto.Focus();
                    valor_unitario = 0;
                }
            }
            catch
            {

            }
        }

        private void txtCodProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                txtQuantidade.Focus();
            }
        }

        private void frmSaida_KeyDown(object sender, KeyEventArgs e)
        {
            //apaga o texto ao apertar o botao ESC
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                txtQuantidade.Focus();
            }
        }

        private void cbTipoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                txtQuantidade.Focus();
            }
        }
    }
}
