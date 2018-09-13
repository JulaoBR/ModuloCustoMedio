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
    public partial class frmOpcaoRelatorio : Form
    {
        public frmOpcaoRelatorio()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            frmReportViewer re = new frmReportViewer();
            re.ShowDialog();
        }
    }
}
