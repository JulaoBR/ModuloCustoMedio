using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProEstoque.CONTROLES
{
    public class txtMoeda : TextBox
    {
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = Color.SkyBlue;
            this.SelectAll();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = Color.White;

            //cuida da para digitar só numeros
            if (this.Text == "")
                return;

            //convert o digitado em decimal
            try
            {
                decimal valor = Convert.ToDecimal(this.Text.Replace("R$ ", ""));
                this.Text = String.Format("{0:c}", valor);
            }
            catch
            {
                this.Text = "";
                MessageBox.Show("Valor Invalida!");
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            //apaga o campo precionando o ESC
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "";
                e.SuppressKeyPress = true;
            }
        }

        protected override void OnCreateControl()
        {
            //alinha oq for digitado no textbox
            base.OnCreateControl();
            this.TextAlign = HorizontalAlignment.Center;
        }
    }
}
