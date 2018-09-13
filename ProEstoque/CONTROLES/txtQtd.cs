using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProEstoque.CONTROLES
{
    public class txtQtd : TextBox
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
                Convert.ToDecimal(this.Text);
            }
            catch 
            {
                this.Text = "";
                MessageBox.Show("Quantidade Invalida!");
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

        protected  override void OnCreateControl()
        {
            //alinha oq for digitado no textbox
            base.OnCreateControl();
            this.TextAlign = HorizontalAlignment.Center;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (e.KeyChar == 8)
                return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
