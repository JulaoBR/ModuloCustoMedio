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
    public partial class frmVisualizarPedido : Form
    {
        private int codigo = 0;
        private List<ModelRegistro> listaRegistro;

        public frmVisualizarPedido(int  codigo)
        {
            InitializeComponent();
            gridProduto.AutoGenerateColumns = false;
            this.codigo = codigo;
        }

        private void frmVisualizarPedido_Load(object sender, EventArgs e)
        {
            try
            {
                ControlPedido control = new ControlPedido();
                CarregaLabels(control.BuscaPedidoExibir(codigo));
            }
            catch
            {
                throw;
            }
        }

        private void CarregaLabels(ModelPedido modelo)
        {
            ControlPedido control = new ControlPedido();
            listaRegistro = control.BuscaRegistroEntradaPedido(modelo.ped_cod);
            PreencheGrid();

            nomeFornecedor.Text = modelo.for_descricao;
            contato.Text = modelo.ped_contato;
            email.Text = modelo.for_email;
            prazoEntrega.Text = modelo.for_prazo_entrega.ToString();
            dataPedido.Text = modelo.ped_data_pedido.ToString("dd/MM/yyyy");
            dataPrevista.Text = modelo.ped_data_pedido.ToString("dd/MM/yyyy");
            prazoEntrega.Text = modelo.for_prazo_entrega.ToString();
            condicaoPagamento.Text = modelo.ped_condicao_pagamento;
            formaPagamento.Text = modelo.ped_forma_pagamento;
            txtObservacao.Text = modelo.ped_observacao;
        }

        private void PreencheGrid()
        {
            gridProduto.DataSource = null;
            gridProduto.DataSource = listaRegistro;
            gridProduto.ClearSelection();
            gridProduto.AllowUserToAddRows = false;
        }
    }
}
