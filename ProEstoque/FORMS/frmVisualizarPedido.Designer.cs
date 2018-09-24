namespace ProEstoque.FORMS
{
    partial class frmVisualizarPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prazoEntrega = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.contato = new System.Windows.Forms.Label();
            this.nomeFornecedor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.formaPagamento = new System.Windows.Forms.Label();
            this.condicaoPagamento = new System.Windows.Forms.Label();
            this.dataPrevista = new System.Windows.Forms.Label();
            this.dataPedido = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridProduto = new System.Windows.Forms.DataGridView();
            this.reg_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorFrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.prazoEntrega);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.contato);
            this.groupBox1.Controls.Add(this.nomeFornecedor);
            this.groupBox1.Location = new System.Drawing.Point(13, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS FORNECEOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "PRAZO ENTREGA EM DIAS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "EMAIL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CONTATO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FORNECEDOR:";
            // 
            // prazoEntrega
            // 
            this.prazoEntrega.AutoSize = true;
            this.prazoEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prazoEntrega.Location = new System.Drawing.Point(453, 94);
            this.prazoEntrega.Name = "prazoEntrega";
            this.prazoEntrega.Size = new System.Drawing.Size(51, 16);
            this.prazoEntrega.TabIndex = 3;
            this.prazoEntrega.Text = "label1";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(16, 94);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(51, 16);
            this.email.TabIndex = 2;
            this.email.Text = "label1";
            // 
            // contato
            // 
            this.contato.AutoSize = true;
            this.contato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contato.Location = new System.Drawing.Point(451, 43);
            this.contato.Name = "contato";
            this.contato.Size = new System.Drawing.Size(51, 16);
            this.contato.TabIndex = 1;
            this.contato.Text = "label1";
            // 
            // nomeFornecedor
            // 
            this.nomeFornecedor.AutoSize = true;
            this.nomeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeFornecedor.Location = new System.Drawing.Point(14, 43);
            this.nomeFornecedor.Name = "nomeFornecedor";
            this.nomeFornecedor.Size = new System.Drawing.Size(51, 16);
            this.nomeFornecedor.TabIndex = 0;
            this.nomeFornecedor.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObservacao);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.formaPagamento);
            this.groupBox2.Controls.Add(this.condicaoPagamento);
            this.groupBox2.Controls.Add(this.dataPrevista);
            this.groupBox2.Controls.Add(this.dataPedido);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DADOS PEDIDO";
            // 
            // txtObservacao
            // 
            this.txtObservacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtObservacao.Location = new System.Drawing.Point(20, 140);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.ReadOnly = true;
            this.txtObservacao.Size = new System.Drawing.Size(629, 39);
            this.txtObservacao.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "OBSERVAÇÃO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(454, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "FORMA PAGAMENTO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "CONDIÇÃO PAGAMENTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "ENTREGA PREVISTA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "DATA PEDIDO:";
            // 
            // formaPagamento
            // 
            this.formaPagamento.AutoSize = true;
            this.formaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formaPagamento.Location = new System.Drawing.Point(454, 92);
            this.formaPagamento.Name = "formaPagamento";
            this.formaPagamento.Size = new System.Drawing.Size(51, 16);
            this.formaPagamento.TabIndex = 8;
            this.formaPagamento.Text = "label1";
            // 
            // condicaoPagamento
            // 
            this.condicaoPagamento.AutoSize = true;
            this.condicaoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condicaoPagamento.Location = new System.Drawing.Point(17, 92);
            this.condicaoPagamento.Name = "condicaoPagamento";
            this.condicaoPagamento.Size = new System.Drawing.Size(51, 16);
            this.condicaoPagamento.TabIndex = 7;
            this.condicaoPagamento.Text = "label1";
            // 
            // dataPrevista
            // 
            this.dataPrevista.AutoSize = true;
            this.dataPrevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPrevista.Location = new System.Drawing.Point(454, 41);
            this.dataPrevista.Name = "dataPrevista";
            this.dataPrevista.Size = new System.Drawing.Size(51, 16);
            this.dataPrevista.TabIndex = 5;
            this.dataPrevista.Text = "label1";
            // 
            // dataPedido
            // 
            this.dataPedido.AutoSize = true;
            this.dataPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPedido.Location = new System.Drawing.Point(17, 41);
            this.dataPedido.Name = "dataPedido";
            this.dataPedido.Size = new System.Drawing.Size(51, 16);
            this.dataPedido.TabIndex = 4;
            this.dataPedido.Text = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridProduto);
            this.groupBox3.Location = new System.Drawing.Point(13, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(668, 141);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DADOS PRODUTOS";
            // 
            // gridProduto
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProduto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reg_cod,
            this.descricao,
            this.reg_quantidade,
            this.valorUnitario,
            this.valorFrete,
            this.valorTotal});
            this.gridProduto.GridColor = System.Drawing.SystemColors.Control;
            this.gridProduto.Location = new System.Drawing.Point(6, 22);
            this.gridProduto.Name = "gridProduto";
            this.gridProduto.RowHeadersVisible = false;
            this.gridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProduto.Size = new System.Drawing.Size(656, 113);
            this.gridProduto.TabIndex = 29;
            // 
            // reg_cod
            // 
            this.reg_cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reg_cod.DataPropertyName = "reg_cod";
            this.reg_cod.HeaderText = "#";
            this.reg_cod.Name = "reg_cod";
            this.reg_cod.ReadOnly = true;
            this.reg_cod.Width = 60;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "PRODUTO";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // reg_quantidade
            // 
            this.reg_quantidade.DataPropertyName = "quantidade";
            this.reg_quantidade.HeaderText = "QTD";
            this.reg_quantidade.Name = "reg_quantidade";
            this.reg_quantidade.ReadOnly = true;
            // 
            // valorUnitario
            // 
            this.valorUnitario.DataPropertyName = "valorUnitario";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.valorUnitario.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorUnitario.HeaderText = "VL UNI";
            this.valorUnitario.Name = "valorUnitario";
            this.valorUnitario.ReadOnly = true;
            // 
            // valorFrete
            // 
            this.valorFrete.DataPropertyName = "valorFrete";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.valorFrete.DefaultCellStyle = dataGridViewCellStyle3;
            this.valorFrete.HeaderText = "FRETE";
            this.valorFrete.Name = "valorFrete";
            this.valorFrete.ReadOnly = true;
            // 
            // valorTotal
            // 
            this.valorTotal.DataPropertyName = "valorTotal";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.valorTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.valorTotal.HeaderText = "TOTAL";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(617, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "ESC Sair";
            // 
            // frmVisualizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVisualizarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VISUALIZAÇÃO DO PEDIDO";
            this.Load += new System.EventHandler(this.frmVisualizarPedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label prazoEntrega;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label contato;
        private System.Windows.Forms.Label nomeFornecedor;
        private System.Windows.Forms.Label condicaoPagamento;
        private System.Windows.Forms.Label dataPrevista;
        private System.Windows.Forms.Label dataPedido;
        private System.Windows.Forms.Label formaPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorFrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}