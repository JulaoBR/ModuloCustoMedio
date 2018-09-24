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
    public partial class frmConsumoMedio : Form
    {

        private int codigoProduto = 0;
        private int totalDias = 0;

        public frmConsumoMedio(int codigo)
        {
            InitializeComponent();
            this.codigoProduto = codigo;
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlRegistro control = new ControlRegistro();

                TimeSpan date = Convert.ToDateTime(data2.SelectionStart.ToString()) - Convert.ToDateTime(data1.SelectionStart.ToString());
                totalDias = date.Days;

                AtualizaInfo(control.BuscaConsumoMedio(codigoProduto, data1.SelectionStart.ToString(), data2.SelectionStart.ToString()));
            }
            catch
            {
                MessageBox.Show("Erro ao carregar os dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void AtualizaInfo(ModelConsumoMedeio modelo)
        {
            nomeProduto.Text = modelo.pro_descricao;
            mediaTotal.Text = "Consumo médio no periodo de "+ totalDias+" dias é: " +modelo.media_total.ToString();
        }
    }
}
