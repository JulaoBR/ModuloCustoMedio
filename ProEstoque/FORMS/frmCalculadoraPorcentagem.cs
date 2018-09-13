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
    public partial class frmCalculadoraPorcentagem : Form
    {
        public frmCalculadoraPorcentagem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal primeiro_valor = Convert.ToDecimal(txtValor1.Text);
                decimal segundo_valor = Convert.ToDecimal(txtValor2.Text);
                decimal aux = 0;
                decimal aux2 = 0;

                aux = segundo_valor - primeiro_valor;
                aux2 = aux / primeiro_valor;
                aux = aux2 * 100;

                txtResultado.Text = String.Format("{0:N2}", aux) + "%";

            }
            catch
            {
                MessageBox.Show("Digite os campos corretamente! ","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            txtValor1.Clear();
            txtValor2.Clear();

            txtValor1.Focus();
        }

        private void txtValor1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtValor2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
