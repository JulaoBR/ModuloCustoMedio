using ProEstoque.CONTROL;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProEstoque.FORMS
{
    public partial class frmBuscaSaida : Form
    {
        public frmBuscaSaida()
        {
            InitializeComponent();
            gridProduto.AutoGenerateColumns = false;
            CarregaTipoProduto();
        }

        private void CarregaTipoProduto()
        {
            try
            {
                ControlTipoProduto control = new ControlTipoProduto();

                cbTipoProduto.DataSource = control.BuscaDados();
                cbTipoProduto.DisplayMember = "tipo_descricao";
                cbTipoProduto.ValueMember = "tipo_cod";
                cbTipoProduto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os tipos de produto: " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PreencheGrid(List<ModelRegistro> dt)
        {
            gridProduto.DataSource = null;
            gridProduto.DataSource = dt;
            gridProduto.ClearSelection();
            gridProduto.AllowUserToAddRows = false;
        }

        private void frmBuscaSaida_Load(object sender, EventArgs e)
        {
            try
            {
                ControlRegistro control = new ControlRegistro();

                PreencheGrid(control.BuscaDadosSaida(txtDescricao.Text, cbTipoProduto.Text, txtData1.Text, txtData2.Text));
            }
            catch
            {
                MessageBox.Show("Erro ao carregar os dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(gridProduto.CurrentRow.Cells[0].Value.ToString());

                //Comando que questiona ao usuário se relamente deseja sair do programa
                DialogResult result = MessageBox.Show("Deseja excluir o item " + gridProduto.CurrentRow.Cells[1].Value.ToString() + "?",
                   "EXCLUIR O ITEM: " + gridProduto.CurrentRow.Cells[1].Value.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    var controle = new ControlRegistro();
                    controle.ExcluiRegistroSaida(codigo);
                    frmBuscaSaida_Load(sender, e);
                }

            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscaSaida_Load(sender, e);
        }
    }
}
