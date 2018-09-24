using ProEstoque.CONTROL;
using ProEstoque.FORMS;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmCadastroProduto : Form
    {
        private int opcao = 0;
        private List<ModelFornecedor> listaFornecedor = new List<ModelFornecedor>();
        private List<ModelTipoProduto> listaTipoProduto = new List<ModelTipoProduto>();

        public frmCadastroProduto()
        {
            InitializeComponent();
            gridFornecedor.AutoGenerateColumns = false;
            gridProduto.AutoGenerateColumns = false;
        }

        private void CarregaFornecedor()
        {
            try
            {
                ControlFornecedor control = new ControlFornecedor();

                cbFornecedor.DataSource = control.BuscaDados();
                cbFornecedor.DisplayMember = "for_descricao";
                cbFornecedor.ValueMember = "for_cod";
                cbFornecedor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os fornecedores: " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CarregaTipoProduto()
        {
            try
            {
                ControlTipoProduto control = new ControlTipoProduto();

                cbTipoProduto.DataSource = control.BuscaDados();
                cbTipoProduto.DisplayMember = "tipo_descricao";
                cbTipoProduto.ValueMember = "tipo_cod";
                cbTipoProduto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os categorias: " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            LimpaCampo();
            CarregaFornecedor();
            CarregaTipoProduto();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModelProduto produto = new ModelProduto();
                ControlProduto controle = new ControlProduto();

                if (opcao == 1)
                    produto.codProduto = Convert.ToInt32(txtCodProduto.Text);

                produto.descricao = txtDescricao.Text;
                produto.dataOperacao = Convert.ToDateTime(dataOperacao.Text);
                produto.categoria = cbCategoria.Text;
                produto.unidade_medida = cbUnidadeMedida.Text;
                produto.estoque_minimo = Convert.ToDecimal(txtEstoqueMinimo.Text);
                produto.estoque_seguranca = Convert.ToDecimal(txtEstoqueSeguranca.Text);

                switch (opcao)
                {
                    case 0:
                        if (!controle.Inserir(produto, listaFornecedor, listaTipoProduto))
                            MessageBox.Show("Verifique os campos digitados", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 1:
                        if (!controle.Update(produto))
                            MessageBox.Show("Verifique os campos digitados", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }

                LimpaCampo();
            }
            catch
            {
                MessageBox.Show("Verifique os campos digitados", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpaCampo()
        {
            opcao = 0;
            txtDescricao.Focus();

            listaFornecedor.Clear();
            listaTipoProduto.Clear();

            txtCodProduto.Clear();
            txtDescricao.Clear();
            txtEstoqueMinimo.Clear();
            txtEstoqueSeguranca.Clear();
            cbCategoria.SelectedIndex = -1;
            cbUnidadeMedida.SelectedIndex = -1;
            cbFornecedor.SelectedIndex = -1;
            cbCategoria.SelectedIndex = -1;

            gridFornecedor.DataSource = null;
            gridFornecedor.Refresh();

            gridProduto.DataSource = null;
            gridProduto.Refresh();

            btnExcluir.Enabled = false;

            groupFornecedor.Enabled = true;
            groupTipoProduto.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlProduto control = new ControlProduto();
                ControlFornecedor controlFornecedor = new ControlFornecedor();
                ControlTipoProduto controlTipo = new ControlTipoProduto();

                frmBuscaDados busca = new frmBuscaDados();
                busca.ShowDialog();

                if (busca.codigo != 0)
                {
                    groupFornecedor.Enabled = false;
                    groupTipoProduto.Enabled = false;
                    btnExcluir.Enabled = true;
                    opcao = 1;
                    ModelProduto modelo = control.BuscaProduto(busca.codigo);

                    txtCodProduto.Text = Convert.ToString(modelo.codProduto);
                    txtDescricao.Text = modelo.descricao;
                    txtEstoqueMinimo.Text = Convert.ToString(modelo.estoque_minimo);
                    txtEstoqueSeguranca.Text = Convert.ToString(modelo.estoque_seguranca);
                    cbCategoria.Text = modelo.categoria;
                    cbUnidadeMedida.Text = modelo.unidade_medida;

                    listaFornecedor = controlFornecedor.BuscaFornecedorIdLista(busca.codigo);
                    listaTipoProduto = controlTipo.BuscaTipoProdutoIdLista(busca.codigo);

                    PreencheGridFornecedor();
                    PreencheGridTipoProduto();

                }
            }
            catch
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void txtEstoqueMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Comando que questiona ao usuário se relamente deseja sair do programa
                DialogResult result = MessageBox.Show("Deseja excluir o item selecionado?",
                   "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ControlProduto control = new ControlProduto();
                    control.Excluir(Convert.ToInt32(txtCodProduto.Text));

                    LimpaCampo();
                }
            }
            catch
            {
                MessageBox.Show("Selecione um produto para realizar esta operação", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AdicionaFornecedorLista()
        {
            try
            {

                ModelFornecedor fornecedor = new ModelFornecedor();

                fornecedor.for_cod = Convert.ToInt32(cbFornecedor.SelectedValue);
                fornecedor.for_descricao = cbFornecedor.Text;

                if (VerificaListaFornecedor(Convert.ToInt32(cbFornecedor.SelectedValue)))
                {
                    listaFornecedor.Add(fornecedor);

                    PreencheGridFornecedor();
                }
                else
                {
                    MessageBox.Show("Fornecedor ja esta adicionado a este produto", "Atenção", MessageBoxButtons.OK , MessageBoxIcon.Information);
                }               
            }
            catch
            {
                MessageBox.Show("Erro ao adicionar fornecedor!");
            }
        }

        private void AdicionaTipoProdutoLista()
        {
            try
            {

                ModelTipoProduto tipo = new ModelTipoProduto();

                tipo.tipo_cod = Convert.ToInt32(cbTipoProduto.SelectedValue);
                tipo.tipo_descricao = cbTipoProduto.Text;

                if (VerificaListaTipo(Convert.ToInt32(cbTipoProduto.SelectedValue)))
                {
                    listaTipoProduto.Add(tipo);

                    PreencheGridTipoProduto();
                }
                else
                {
                    MessageBox.Show("Tipo de produto ja foi selecionado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao adicionar fornecedor!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdicionaFornecedorLista();
        }

        private void PreencheGridFornecedor()
        {
            gridFornecedor.DataSource = null;
            gridFornecedor.DataSource = listaFornecedor;
            gridFornecedor.ClearSelection();
            gridFornecedor.AllowUserToAddRows = false;
        }

        private void PreencheGridTipoProduto()
        {
            gridProduto.DataSource = null;
            gridProduto.DataSource = listaTipoProduto;
            gridProduto.ClearSelection();
            gridProduto.AllowUserToAddRows = false;
        }

        private bool VerificaListaFornecedor(int codigo)
        {
            try
            {
                foreach (var item in listaFornecedor)
                {
                    if (item.for_cod == codigo)
                        return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool VerificaListaTipo(int codigo)
        {
            try
            {
                foreach (var item in listaTipoProduto)
                {
                    if (item.tipo_cod == codigo)
                        return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void txtEstoqueMinimo_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            ControlFormatacao.Formatacao(ref txtEstoqueMinimo);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtEstoqueMinimo_CursorChanged(object sender, EventArgs e)
        {
            txtEstoqueMinimo.BackColor = Color.SkyBlue;
        }

        private void gridFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int codigo = Convert.ToInt32(gridFornecedor.Rows[e.RowIndex].Cells[0].Value);

                    foreach (var item in listaFornecedor)
                    {
                        if (codigo == item.for_cod)
                        {
                            //Comando que questiona ao usuário se relamente deseja sair do programa
                            DialogResult result = MessageBox.Show("Deseja remover este item?",
                               "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                listaFornecedor.Remove(item);
                                PreencheGridFornecedor();
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

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            AdicionaTipoProdutoLista();
        }

        private void txtEstoqueSeguranca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlFormatacao.Formatacao(ref txtEstoqueSeguranca);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }      
}
