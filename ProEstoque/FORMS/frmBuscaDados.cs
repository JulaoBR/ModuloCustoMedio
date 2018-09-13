using ProEstoque.CONTROL;
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
    public partial class frmBuscaDados : Form
    {
        private int opcao = 0;
        public int codigo = 0;

        public frmBuscaDados()
        {
            InitializeComponent();
        }

        public frmBuscaDados(int opcao)
        {
            this.opcao = opcao;
            InitializeComponent();
        }

        private void frmBuscaDados_Load(object sender, EventArgs e)
        {
            try
            {

                if (opcao == 1)
                    cbCategoria.Text = "EMBALAGEM";
                if (opcao == 2)
                    cbCategoria.Text = "MATÉRIA PRIMA";
                if (opcao == 3)
                    cbCategoria.Text = "PRODUTOS HIGIENE E LIMPEZA";

                ControlProduto control = new ControlProduto();
                PreencheGrid(control.BuscaDados(txtCodProduto.Text, txtDescricao.Text, cbCategoria.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = Convert.ToInt32(gridProduto.CurrentRow.Cells[0].Value.ToString());

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex,"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PreencheGrid(DataTable dt)
        {
            try
            {
                gridProduto.DataSource = null;
                gridProduto.Refresh();
                gridProduto.DataSource = dt;
                gridProduto.ClearSelection();
                gridProduto.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                opcao = 0;
                frmBuscaDados_Load(sender, e);
            }
            catch
            {

            }
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                frmBuscaDados_Load(sender, e);
            }
            catch
            {

            }
        }

        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                frmBuscaDados_Load(sender, e);
            }
            catch
            {

            }
        }
    }
}
