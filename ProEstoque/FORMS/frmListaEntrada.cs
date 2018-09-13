using ProEstoque.CONTROL;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProEstoque.FORMS
{
    public partial class frmListaEntrada : Form
    {
        private int codigo;
        private string descricao;
        private List<ModelRegistro> dt = new List<ModelRegistro>();

        public frmListaEntrada(int codigo, string descricao)
        {
            InitializeComponent();
            gridListaEntrada.AutoGenerateColumns = false;
            this.codigo = codigo;
            this.descricao = descricao;
            
        }

        private void frmListaEntrada_Load(object sender, EventArgs e)
        {
            try
            {
                ControlRegistro control = new ControlRegistro();

                dt = control.CalculaPercentual(0,codigo, 1);
                PreencheGrid();
                MontaGrafico();
                LabelInformacao();

                labelDescricao.Text = "HISTORICO DE ENTRADA DO PRODUTO: "+ descricao;
                ModelRegistro aux = control.CustoMedio(codigo);
                labelSaldo.Text = "SALDO ESTOQUE: " + Convert.ToString(aux.quantidade);
                labelCustoMedio.Text = "CUSTO MÉDIO ATUAL R$ " + Convert.ToString(aux.custoMedio);
                labelUltimoValor.Text = "ULTIMO PREÇO UNITARIO R$: " + Convert.ToString(gridListaEntrada.Rows[gridListaEntrada.Rows.Count - 1].Cells[3].Value);
            }
            catch
            {

            }
        }

        private void MontaGrafico()
        {
            grafico.Series.Clear();

            grafico.Titles.Add("Variação de preço");
            Series series = grafico.Series.Add("R$");
            series.ChartType = SeriesChartType.SplineArea;
            series.Color = Color.Red;
            series.IsValueShownAsLabel = true;
            foreach (var item in dt)
            {
                series.Points.AddXY(item.dataOperacao, item.valorUnitario);
            }
        }

        private void PreencheGrid()
        {
            gridListaEntrada.DataSource = null;
            gridListaEntrada.DataSource = dt;          
            gridListaEntrada.ClearSelection();
            gridListaEntrada.AllowUserToAddRows = false;
        }

        private void LabelInformacao()
        {
            labelCustoMedio.Visible = true;
            labelSaldo.Visible = true;
            labelUltimoValor.Visible = true;
        }   

        private void LimpaGrid()
        {
            gridListaEntrada.DataSource = null;
            gridListaEntrada.Refresh();
        }

        private void gridListaEntrada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int codigo_fornecedor = Convert.ToInt32(gridListaEntrada.CurrentRow.Cells[0].Value.ToString());
                string descricao = gridListaEntrada.CurrentRow.Cells[1].Value.ToString();

                frmBuscaEntradaFornecedor fornecedor = new frmBuscaEntradaFornecedor(codigo_fornecedor, codigo, descricao);
                fornecedor.ShowDialog();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCalculadoraPorcentagem calc = new frmCalculadoraPorcentagem();
            calc.ShowDialog();
        }

        private void frmListaEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            //apaga o texto ao apertar o botao ESC
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
