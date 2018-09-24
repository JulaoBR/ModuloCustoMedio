using ProEstoque.CONTROL;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProEstoque.FORMS
{
    public partial class frmListaItens : Form
    {
        private List<ModelRegistro> ListaRegistro = new List<ModelRegistro>();

        public frmListaItens()
        {
            InitializeComponent();
            gridListaItens.AutoGenerateColumns = false;
        }

        private void frmListaItens_Load(object sender, EventArgs e)
        {
                      
        }

        private void gridListaItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PreencheGrid(List<ModelRegistro> dt)
        {
            gridListaItens.DataSource = null;
            gridListaItens.DataSource = dt;
            ColorirCelulaEstoque(dt);
            gridListaItens.ClearSelection();
            gridListaItens.AllowUserToAddRows = false;
        }

        //METODO PARA COLORIR AS LINHAS DO GRID ESTOQUE
        private void ColorirCelulaEstoque(List<ModelRegistro> dt)
        {
            int cont = 0;
            int i = 0;
            foreach (var item in dt)
            {
                //VERIFICA ESTOQUE SEGURANCA
                if (item.quantidade < item.estoque_seguranca)
                {
                    DataGridViewRow row = gridListaItens.Rows[i];
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    cont++;
                }

                //VERIFICA ESTOQUE MINIMO
                if (item.quantidade < item.estoque_minimo)
                {
                    DataGridViewRow row = gridListaItens.Rows[i];
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.BackColor = Color.Red;
                    cont++;
                }

                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ControlRegistro control = new ControlRegistro();

                checkBox2.Checked = false;

                gridListaItens.DataSource = null;
                gridListaItens.Refresh();

                ListaRegistro = control.CalculaSaldo(txtCodProduto.Text, txtDescricao.Text, cbCategoria.Text);

                PreencheGrid(ListaRegistro);
            }
            catch
            {

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                PreencheGrid(ControlRegistro.BuscaProdutoEstoqueMinimo(ListaRegistro));
            }
            else
            {
                PreencheGrid(ListaRegistro);
            }
        }

        private void txtCodProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void frmListaItens_KeyDown(object sender, KeyEventArgs e)
        {
            //apaga o texto ao apertar o botao ESC
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void gridListaItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = Convert.ToInt32(gridListaItens.CurrentRow.Cells[0].Value.ToString());
            string descricao = gridListaItens.CurrentRow.Cells[1].Value.ToString();
            decimal qtd_minima = Convert.ToDecimal(gridListaItens.CurrentRow.Cells[3].Value.ToString());
            decimal qtd_saldo = Convert.ToDecimal(gridListaItens.CurrentRow.Cells[4].Value.ToString());

            labelInformacao.Text = "";
            labelInformacao2.Text = "";

            if (qtd_saldo < qtd_minima)
            {
                ControlPedido control = new ControlPedido();
                var produto = control.BuscaPedidoNaoRecebido(codigo);

                if (produto == null)
                {
                    labelInformacao.Text = "NÃO FOI ENCONTRADO NEM UM PEDIDO PARA ESTE PRODUTO";
                }
                else
                {
                    labelInformacao.Text = "PEDIDO DE REPOSIÇÃO JA FOI EFETUADO COM O FORNECEDOR: " + produto.for_descricao;
                    labelInformacao2.Text = "DATA PEDIDO: " + produto.ped_data_pedido.ToShortDateString() + "   -   ENTREGA PREVISTA: " + produto.ped_data_prevista.ToShortDateString() + "    -   QUANTIDADE: " + produto.ped_quantidade + " " + produto.unidade_medida;
                }
            }
            else
            {
                labelInformacao.Text = "O PRODUTO " + descricao + " NÃO ESTA NA ZONA DE ESTOQUE MINIMO";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(gridListaItens.CurrentRow.Cells[0].Value.ToString());
                string descricao = gridListaItens.CurrentRow.Cells[1].Value.ToString();

                frmListaEntrada lista = new frmListaEntrada(codigo, descricao);
                lista.ShowDialog();
            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(gridListaItens.CurrentRow.Cells[0].Value.ToString());
                frmConsumoMedio consumo = new frmConsumoMedio(codigo);
                consumo.ShowDialog();
            }
            catch
            {
                throw;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(gridListaItens.CurrentRow.Cells[0].Value.ToString());
                frmVisualizarPedido pedido = new frmVisualizarPedido(codigo);
                pedido.ShowDialog();
            }
            catch
            {
                throw;
            }
            
        }
    }
}
