namespace ProEstoque.FORMS
{
    partial class frmBuscaEntradaFornecedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelUltimoValor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.gridListaEntrada = new System.Windows.Forms.DataGridView();
            this.reg_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_valor_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPorcentual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_custo_medio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_valor_frete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_data_operacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUltimoValor
            // 
            this.labelUltimoValor.AutoSize = true;
            this.labelUltimoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUltimoValor.ForeColor = System.Drawing.Color.Red;
            this.labelUltimoValor.Location = new System.Drawing.Point(13, 551);
            this.labelUltimoValor.Name = "labelUltimoValor";
            this.labelUltimoValor.Size = new System.Drawing.Size(57, 20);
            this.labelUltimoValor.TabIndex = 15;
            this.labelUltimoValor.Text = "label1";
            this.labelUltimoValor.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(742, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "HISTORICO DE COMPRAS";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescricao.ForeColor = System.Drawing.Color.Red;
            this.labelDescricao.Location = new System.Drawing.Point(12, 11);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(76, 25);
            this.labelDescricao.TabIndex = 13;
            this.labelDescricao.Text = "label1";
            // 
            // gridListaEntrada
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridListaEntrada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListaEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListaEntrada.BackgroundColor = System.Drawing.Color.White;
            this.gridListaEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListaEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reg_cod,
            this.reg_quantidade,
            this.reg_valor_unitario,
            this.valorPorcentual,
            this.reg_custo_medio,
            this.reg_valor_frete,
            this.reg_valor_total,
            this.reg_data_operacao});
            this.gridListaEntrada.GridColor = System.Drawing.Color.White;
            this.gridListaEntrada.Location = new System.Drawing.Point(13, 65);
            this.gridListaEntrada.Name = "gridListaEntrada";
            this.gridListaEntrada.RowHeadersVisible = false;
            this.gridListaEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListaEntrada.Size = new System.Drawing.Size(971, 476);
            this.gridListaEntrada.TabIndex = 12;
            // 
            // reg_cod
            // 
            this.reg_cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reg_cod.DataPropertyName = "fornecedor";
            this.reg_cod.HeaderText = "FORNECEDOR";
            this.reg_cod.Name = "reg_cod";
            this.reg_cod.ReadOnly = true;
            this.reg_cod.Width = 260;
            // 
            // reg_quantidade
            // 
            this.reg_quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reg_quantidade.DataPropertyName = "quantidade";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.reg_quantidade.DefaultCellStyle = dataGridViewCellStyle2;
            this.reg_quantidade.HeaderText = "QUANTIDADE";
            this.reg_quantidade.Name = "reg_quantidade";
            this.reg_quantidade.ReadOnly = true;
            this.reg_quantidade.Width = 110;
            // 
            // reg_valor_unitario
            // 
            this.reg_valor_unitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reg_valor_unitario.DataPropertyName = "valorUnitario";
            dataGridViewCellStyle3.Format = "C3";
            dataGridViewCellStyle3.NullValue = null;
            this.reg_valor_unitario.DefaultCellStyle = dataGridViewCellStyle3;
            this.reg_valor_unitario.HeaderText = "VALOR UNITARIO";
            this.reg_valor_unitario.Name = "reg_valor_unitario";
            this.reg_valor_unitario.ReadOnly = true;
            this.reg_valor_unitario.Width = 130;
            // 
            // valorPorcentual
            // 
            this.valorPorcentual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valorPorcentual.DataPropertyName = "valorPorcentual";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.valorPorcentual.DefaultCellStyle = dataGridViewCellStyle4;
            this.valorPorcentual.HeaderText = "DIFERENÇA %";
            this.valorPorcentual.Name = "valorPorcentual";
            this.valorPorcentual.ReadOnly = true;
            this.valorPorcentual.Width = 130;
            // 
            // reg_custo_medio
            // 
            this.reg_custo_medio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reg_custo_medio.DataPropertyName = "custoMedio";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "C3";
            dataGridViewCellStyle5.NullValue = null;
            this.reg_custo_medio.DefaultCellStyle = dataGridViewCellStyle5;
            this.reg_custo_medio.HeaderText = "CUSTO MÉDIO";
            this.reg_custo_medio.Name = "reg_custo_medio";
            this.reg_custo_medio.ReadOnly = true;
            this.reg_custo_medio.Width = 120;
            // 
            // reg_valor_frete
            // 
            this.reg_valor_frete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reg_valor_frete.DataPropertyName = "valorFrete";
            dataGridViewCellStyle6.Format = "C3";
            dataGridViewCellStyle6.NullValue = null;
            this.reg_valor_frete.DefaultCellStyle = dataGridViewCellStyle6;
            this.reg_valor_frete.HeaderText = "FRETE";
            this.reg_valor_frete.Name = "reg_valor_frete";
            this.reg_valor_frete.ReadOnly = true;
            this.reg_valor_frete.Width = 110;
            // 
            // reg_valor_total
            // 
            this.reg_valor_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reg_valor_total.DataPropertyName = "valorTotal";
            dataGridViewCellStyle7.Format = "C3";
            dataGridViewCellStyle7.NullValue = null;
            this.reg_valor_total.DefaultCellStyle = dataGridViewCellStyle7;
            this.reg_valor_total.HeaderText = "VALOR TOTAL";
            this.reg_valor_total.Name = "reg_valor_total";
            this.reg_valor_total.ReadOnly = true;
            this.reg_valor_total.Width = 120;
            // 
            // reg_data_operacao
            // 
            this.reg_data_operacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reg_data_operacao.DataPropertyName = "dataOperacao";
            dataGridViewCellStyle8.Format = "G";
            dataGridViewCellStyle8.NullValue = null;
            this.reg_data_operacao.DefaultCellStyle = dataGridViewCellStyle8;
            this.reg_data_operacao.HeaderText = "DATA";
            this.reg_data_operacao.Name = "reg_data_operacao";
            this.reg_data_operacao.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Image = global::ProEstoque.Properties.Resources.calculator_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(507, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "CALCULAR DIFERENÇA PERCENTUAL";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBuscaEntradaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelUltimoValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.gridListaEntrada);
            this.Name = "frmBuscaEntradaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HISTORICO DO FORNECEDOR";
            this.Load += new System.EventHandler(this.frmBuscaEntradaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListaEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUltimoValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.DataGridView gridListaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_valor_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPorcentual;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_custo_medio;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_valor_frete;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_valor_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_data_operacao;
        private System.Windows.Forms.Button button1;
    }
}