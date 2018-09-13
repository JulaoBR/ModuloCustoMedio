using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProEstoque.CONTROL
{
    public class txtControle : TextBox
    {
        //quando recebe o focu muda a cor do textbox
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = Color.SkyBlue;
            //seleciona todo o conteudo
            this.SelectAll();
        }

        //quando perde o foco muda a cor para branco
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = Color.White;
        }

        //evento responsavel por apagar o texto do campo com o apertar do
        //botao ESC
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            //apaga o texto ao apertar o botao ESC
            if(e.KeyCode == Keys.Escape)
            {
                this.Text = "";
                //elimina o som realizado quando algo da errado
                e.SuppressKeyPress = true;
            }
        }
    }
}
