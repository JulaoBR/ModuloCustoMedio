using ProEstoque.CONTROL;
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

namespace ProEstoque.FORMS
{
    public partial class frmBuscaTodosPedidos : Form
    {
        private List<ModelPedido> dt = new List<ModelPedido>();

        public frmBuscaTodosPedidos()
        {
            InitializeComponent();
            gridPedido.AutoGenerateColumns = false;
        }

        private void frmBuscaEntrada_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {
                MessageBox.Show("Erro ao carregar os dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscaDados()
        {
            try
            {
                ControlPedido pedido;

                pedido = new ControlPedido(txtDescricao.Text);

                if(rbTodos.Checked)
                    dt = pedido.BuscaDados(2);

                if(rbNaoRecebido.Checked)
                    dt = pedido.BuscaDados(0);

                if(rbRecebido.Checked)
                    dt = pedido.BuscaDados(1);


                PreencheGrid();
            }
            catch
            {
                //sem tratamento
            }
        }

        private void PreencheGrid()
        {
            gridPedido.DataSource = null;
            gridPedido.DataSource = dt;
            gridPedido.ClearSelection();
            gridPedido.AllowUserToAddRows = false;
            ColorirCelulaEstoque(dt);
        }

        private void gridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                try
                {
                    

                }
                catch
                {

                }
            }
            catch
            {

            }
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
                    DataGridViewRow row = gridPedido.Rows[i];
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    cont++;
                }              
                else if (item.ped_data_prevista >= DateTime.Now.Date)
                {
                    DataGridViewRow row = gridPedido.Rows[i];
                    row.DefaultCellStyle.BackColor = Color.White;
                    cont++;
                }
                
                if (item.ped_status.Equals("RECEBIDO"))
                {
                    DataGridViewRow row = gridPedido.Rows[i];
                    row.DefaultCellStyle.BackColor = Color.Gold;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }

                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscaDados();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmBuscaTodosPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            //apaga o texto ao apertar o botao ESC
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


    }
}
