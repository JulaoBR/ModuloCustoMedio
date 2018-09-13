using ProEstoque.CONTROL;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProEstoque.FORMS
{
    public partial class frmBuscaPedidos : Form
    {
        public int codigo = 0;
        private int opcao = 0;
        private int opcaoDeletar = 0;

        public frmBuscaPedidos(int opcao, int opcaoDeletar)
        {
            InitializeComponent();
            this.opcao = opcao;
            this.opcaoDeletar = opcaoDeletar;
            gridProduto.AutoGenerateColumns = false;          
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            try
            {
                if (opcaoDeletar == 0)
                {
                    msgExcluir.Text = "DE UM DUPLO CLIQUE EM CIMA DO ITEM QUE SE DESEJA DAR ENTRADA";
                }
                else
                {
                    msgExcluir.Text = "DE UM DUPLO CLIQUE EM CIMA DO ITEM QUE SE DESEJA EXCLUIR";
                }

                ControlPedido pedido = new ControlPedido(txtDescricao.Text);
                PreencheGrid(pedido.BuscaDados(opcao));

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
            ColorirCelulaEstoque(dt);
            gridProduto.AllowUserToAddRows = false;
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
                }
                else if (item.ped_data_prevista > DateTime.Now.Date)
                {
                    DataGridViewRow row = gridProduto.Rows[i];
                    row.DefaultCellStyle.BackColor = Color.White;
                    cont++;
                }

                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmPedidos_Load(sender, e);
            }
            catch
            {

            }
        }

        private void gridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (opcaoDeletar == 0)
                {
                    codigo = Convert.ToInt32(gridProduto.Rows[e.RowIndex].Cells[0].Value);

                    this.Close();
                }else if (opcaoDeletar == 1)
                {
                    //Comando que questiona ao usuário se relamente deseja sair do programa
                    DialogResult result = MessageBox.Show("Deseja excluir o item " + gridProduto.CurrentRow.Cells[1].Value.ToString() + "?",
                       "EXCLUIR O ITEM: " + gridProduto.CurrentRow.Cells[1].Value.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (result == DialogResult.Yes)
                    {
                        codigo = Convert.ToInt32(gridProduto.Rows[e.RowIndex].Cells[0].Value);

                        var pedido = new ControlPedido();                      
                        pedido.ExcluiPedido(codigo);
                        frmPedidos_Load(sender, e);
                    }
                }              
            }
        }
    }
}
