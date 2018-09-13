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
    public partial class frmBuscaEntradaFornecedor : Form
    {

        private int codigo_fornecedor;
        private int codigo_produto;
        private string descricao;

        public frmBuscaEntradaFornecedor(int codigo_fornecedor, int codigo_produto, string descricao)
        {
            InitializeComponent();
            gridListaEntrada.AutoGenerateColumns = false;
            this.codigo_fornecedor = codigo_fornecedor;
            this.codigo_produto = codigo_produto;
            this.descricao = descricao;
        }

        private void frmBuscaEntradaFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                ControlRegistro control = new ControlRegistro();

                PreencheGrid(control.CalculaPercentual(codigo_fornecedor, codigo_produto, 2));

                LabelInformacao();

                labelDescricao.Text = "HISTORICO DO FORNECEDOR: " + descricao;
                ModelRegistro aux = control.CustoMedio(codigo_fornecedor);
                labelUltimoValor.Text = "ULTIMO PREÇO UNITARIO R$: " + Convert.ToString(gridListaEntrada.Rows[gridListaEntrada.Rows.Count - 1].Cells[2].Value);
            }
            catch
            {

            }
        }

        private void PreencheGrid(List<ModelRegistro> dt)
        {
            gridListaEntrada.DataSource = null;
            gridListaEntrada.DataSource = dt;
            gridListaEntrada.ClearSelection();
            gridListaEntrada.AllowUserToAddRows = false;
        }

        private void LabelInformacao()
        {
            labelUltimoValor.Visible = true;
        }

        private void LimpaGrid()
        {
            gridListaEntrada.DataSource = null;
            gridListaEntrada.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCalculadoraPorcentagem calc = new frmCalculadoraPorcentagem();
            calc.ShowDialog();
        }
    }
}
