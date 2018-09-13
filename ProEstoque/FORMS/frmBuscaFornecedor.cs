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
    public partial class frmBuscaFornecedor : Form
    {
        public int codigo = 0;

        public frmBuscaFornecedor()
        {
            InitializeComponent();
            gridFornecedor.AutoGenerateColumns = false;
        }

        private void frmBuscaFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                ControlFornecedor control = new ControlFornecedor();
                PreencheGrid(control.BuscaDados(txtDescricao.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PreencheGrid(List<ModelFornecedor> dt)
        {
            try
            {
                gridFornecedor.DataSource = null;
                gridFornecedor.Refresh();
                gridFornecedor.DataSource = dt;
                gridFornecedor.ClearSelection();
                gridFornecedor.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = Convert.ToInt32(gridFornecedor.CurrentRow.Cells[0].Value.ToString());

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                frmBuscaFornecedor_Load(sender, e);
            }
            catch
            {

            }
        }
    }
}
