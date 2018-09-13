using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProEstoque.CONTROL
{
    public class ControlFormatacao
    {
        public static void Formatacao(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                {
                    n = "";
                }
                n = n.PadLeft(1, '0');
                if (n.Length > 1 & n.Substring(0, 1) == "0")
                {
                    n = n.Substring(1, n.Length - 1);
                }
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;

            }
            catch
            {
                MessageBox.Show("Operação invalida", "Operação invalida!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void ApagaCampo(ref TextBox txt)
        {
            txt.Clear();
        }

        public static void FormataData(ref TextBox txt)
        {
            switch (txt.Text.Length)
            {
                case 0:
                    txt.Text = "";
                    break;
                case 2:
                    txt.Text = txt.Text + "/";
                    txt.SelectionStart = 4;
                    break;
                case 5:
                    txt.Text = txt.Text + "/";
                    txt.SelectionStart = 9;
                    break;
            }
        }
    }
}
