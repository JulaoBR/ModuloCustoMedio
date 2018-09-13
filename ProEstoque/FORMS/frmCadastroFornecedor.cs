using ProEstoque.CONTROL;
using ProEstoque.MODEL;
using System;
using System.Windows.Forms;

namespace ProEstoque.FORMS
{
    public partial class frmCadastroFornecedor : Form
    {
        //0 = novo 1 = editar
        private int opcao = 0;

        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModelFornecedor model = new ModelFornecedor();
                ControlFornecedor control = new ControlFornecedor();

                model.for_descricao = txtDescricao.Text;
                model.for_email = txtEmail.Text;
                if(txtPrazoEntrega.Text != "")
                    model.for_prazo_entrega = Convert.ToInt32(txtPrazoEntrega.Text);

                if(opcao == 0)
                    if (!control.Inserir(model))
                        MessageBox.Show("Verifique os campos digitados!");

                if (opcao == 1)
                {
                    model.for_cod = Convert.ToInt32(txtCodFornecedor.Text);
                    if (!control.Update(model))
                        MessageBox.Show("Verifique os campos digitados!");
                }

                LimpaCampo();
            }
            catch
            {
                MessageBox.Show("Verifique os campos digitados!");
            }
        }

        private void LimpaCampo()
        {
            txtDescricao.Clear();
            txtCodFornecedor.Clear();
            txtPrazoEntrega.Clear();
            txtEmail.Clear();

            txtDescricao.Focus();
            opcao = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlFornecedor control = new ControlFornecedor();
                frmBuscaFornecedor frmFormecedor = new frmBuscaFornecedor();
                frmFormecedor.ShowDialog();

                if(frmFormecedor.codigo != 0)
                {
                    opcao = 1;
                    var fornecedor = control.BuscaFornecedorUmFornecedor(frmFormecedor.codigo);

                    txtCodFornecedor.Text = Convert.ToString(fornecedor.for_cod);
                    txtDescricao.Text = fornecedor.for_descricao;
                    txtEmail.Text = fornecedor.for_email;
                    txtPrazoEntrega.Text = Convert.ToString(fornecedor.for_prazo_entrega);
                }
            }
            catch
            {

            }
        }
    }
}
