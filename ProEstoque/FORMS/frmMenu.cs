using ProEstoque.CONTROL;
using ProEstoque.FORMS;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmMenu : Form
    {
        private List<ModelPedido> dt = new List<ModelPedido>();

        public frmMenu()
        {
            InitializeComponent();
            gridProduto.AutoGenerateColumns = false;

            txtPermissao.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroProduto cadastro = new frmCadastroProduto();
            cadastro.ShowDialog();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            frmEntrada entrada = new frmEntrada();
            entrada.ShowDialog();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            frmSaida saida = new frmSaida();
            saida.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ControlRegistro teste = new ControlRegistro();
            teste.CustoMedio(1);
        }

        private void btnListaItens_Click(object sender, EventArgs e)
        {
            frmListaItens lista = new frmListaItens();
            lista.ShowDialog();
        }

        private void btnAjuste_Click(object sender, EventArgs e)
        {
            frmAjuste ajuste = new frmAjuste();
            ajuste.ShowDialog();
        }

        private void cadastroFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor fornecedor = new frmCadastroFornecedor();
            fornecedor.ShowDialog();
        }

        private void cadastroProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto cadastro = new frmCadastroProduto();
            cadastro.ShowDialog();
        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjuste ajuste = new frmAjuste();
            ajuste.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido();
            pedido.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            try
            {
                ControlPedido pedido = new ControlPedido(txtDescricao.Text);
                dt = pedido.BuscaDados(0);
                PreencheGrid(dt);
            }
            catch
            {

            }
        }

        private void PreencheGrid(List<ModelPedido> dt)
        {
            gridProduto.DataSource = null;
            gridProduto.DataSource = dt;
            gridProduto.ClearSelection();
            gridProduto.AllowUserToAddRows = false;

            ColorirCelulaEstoque(dt);
        }

        //METODO PARA COLORIR AS LINHAS DO GRID ESTOQUE
        private void ColorirCelulaEstoque(List<ModelPedido> dt)
        {
            int cont = 0;
            int i = 0;
            foreach (var item in dt)
            {
                if (item.ped_data_prevista < DateTime.Now.Date)
                {
                    DataGridViewRow row = gridProduto.Rows[i];
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.BackColor = Color.Red;
                    cont++;
                }
                else if (item.ped_data_prevista.Equals(DateTime.Now.Date))
                {
                    DataGridViewRow row = gridProduto.Rows[i];
                    row.DefaultCellStyle.BackColor = Color.Gold;
                    cont++;
                } else if (item.ped_data_prevista > DateTime.Now.Date)
                {
                    DataGridViewRow row = gridProduto.Rows[i];
                    row.DefaultCellStyle.BackColor = Color.White;
                    cont++;
                }

                i++;
            }
        }

       private void NotificacaoPrazoEntrega()
        {
            foreach (var item in dt)
            {
                TimeSpan date = DateTime.Now - item.ped_data_prevista;
                int totalDias = date.Days;

                if (item.ped_data_prevista < DateTime.Now.Date)
                {
                    MessageBox.Show("O produto "+item.pro_descricao+" esta atrasado a " + totalDias + " dias.","", MessageBoxButtons.OK , MessageBoxIcon.Warning);
                }

                switch (totalDias)
                {
                    case 10:
                        MessageBox.Show("O produto " + item.pro_descricao + " atingiu " + totalDias + " dias, para ser entregue.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 5:
                        MessageBox.Show("O produto " + item.pro_descricao + " atingiu " + totalDias + " dias, para ser entregue.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenu_Load(sender, e);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmBuscaTodosPedidos pedido = new frmBuscaTodosPedidos();
            pedido.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var controle = ControlPermissao.ControleAcesso(txtPermissao.Text);

            switch (controle)
            {
                case 1:
                    btnEntrada.Enabled = true;
                    btnAtualizar.Enabled = true;

                    panelControle.Visible = false;
                    break;
                case 2:
                    btnSaida.Enabled = true;
                    btnListaPedidos.Enabled = true;
                    btnListaItens.Enabled = true;
                    btnPedido.Enabled = true;
                    btnEntrada.Enabled = true;
                    btnAtualizar.Enabled = true;
                    configuraçãoToolStripMenuItem.Enabled = true;

                    panelControle.Visible = false;
                    NotificacaoPrazoEntrega();
                    break;
                default:
                    MessageBox.Show("Acesso negado","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPermissao.Focus();
                    break;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            btnSaida.Enabled = false;
            btnListaPedidos.Enabled = false;
            btnListaItens.Enabled = false;
            btnPedido.Enabled = false;
            btnEntrada.Enabled = false;
            btnAtualizar.Enabled = false;
            configuraçãoToolStripMenuItem.Enabled = false;

            txtPermissao.Clear();
            panelControle.Visible = true;
            txtPermissao.Focus();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                frmMenu_Load(sender, e);
            }
            catch
            {

            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            frmReportViewer rp = new frmReportViewer();
            rp.ShowDialog();
        }

        private void totalDeProdutoUtilizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpcaoRelatorio opc = new frmOpcaoRelatorio();
            opc.ShowDialog();
        }
    }
}
