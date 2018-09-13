namespace ProEstoque.FORMS
{
    partial class frmListaItens
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
            this.gridListaItens = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque_minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidade_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.labelInformacao = new System.Windows.Forms.Label();
            this.labelInformacao2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaItens)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridListaItens
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridListaItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListaItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListaItens.BackgroundColor = System.Drawing.Color.White;
            this.gridListaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListaItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.pro_categoria,
            this.estoque_minimo,
            this.quantidade,
            this.unidade_medida,
            this.valorUnitario,
            this.valorTotal});
            this.gridListaItens.GridColor = System.Drawing.Color.White;
            this.gridListaItens.Location = new System.Drawing.Point(12, 113);
            this.gridListaItens.Name = "gridListaItens";
            this.gridListaItens.ReadOnly = true;
            this.gridListaItens.RowHeadersVisible = false;
            this.gridListaItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListaItens.Size = new System.Drawing.Size(1015, 488);
            this.gridListaItens.TabIndex = 0;
            this.gridListaItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListaItens_CellClick);
            this.gridListaItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListaItens_CellDoubleClick);
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codigo.DataPropertyName = "codProduto";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 65;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "DESCRIÇÃO";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 315;
            // 
            // pro_categoria
            // 
            this.pro_categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pro_categoria.DataPropertyName = "categoria";
            this.pro_categoria.HeaderText = "CATEGORIA";
            this.pro_categoria.Name = "pro_categoria";
            this.pro_categoria.ReadOnly = true;
            this.pro_categoria.Width = 140;
            // 
            // estoque_minimo
            // 
            this.estoque_minimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estoque_minimo.DataPropertyName = "estoque_minimo";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.estoque_minimo.DefaultCellStyle = dataGridViewCellStyle2;
            this.estoque_minimo.HeaderText = "EST. MINIMO";
            this.estoque_minimo.Name = "estoque_minimo";
            this.estoque_minimo.ReadOnly = true;
            this.estoque_minimo.Width = 120;
            // 
            // quantidade
            // 
            this.quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.quantidade.DataPropertyName = "quantidade";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.quantidade.DefaultCellStyle = dataGridViewCellStyle3;
            this.quantidade.HeaderText = "SALDO ESTOQUE";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 125;
            // 
            // unidade_medida
            // 
            this.unidade_medida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.unidade_medida.DataPropertyName = "unidade_medida";
            this.unidade_medida.HeaderText = "MEDIDA";
            this.unidade_medida.Name = "unidade_medida";
            this.unidade_medida.ReadOnly = true;
            this.unidade_medida.Width = 80;
            // 
            // valorUnitario
            // 
            this.valorUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valorUnitario.DataPropertyName = "valorUnitario";
            dataGridViewCellStyle4.Format = "C3";
            dataGridViewCellStyle4.NullValue = null;
            this.valorUnitario.DefaultCellStyle = dataGridViewCellStyle4;
            this.valorUnitario.HeaderText = "CUSTO MÉDIO";
            this.valorUnitario.Name = "valorUnitario";
            this.valorUnitario.ReadOnly = true;
            this.valorUnitario.Width = 115;
            // 
            // valorTotal
            // 
            this.valorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valorTotal.DataPropertyName = "valorTotal";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.valorTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.valorTotal.HeaderText = "TOTAL";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCodProduto);
            this.panel1.Controls.Add(this.cbCategoria);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 94);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(938, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "ESC sair";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "LISTA DE TODOS OS ITENS";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(696, 62);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(175, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "ITENS COM ESTOQUE BAIXO";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Image = global::ProEstoque.Properties.Resources.Actions_edit_find_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(900, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "BUSCAR ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(693, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descricao:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo:";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(12, 26);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(95, 20);
            this.txtCodProduto.TabIndex = 2;
            this.txtCodProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProduto_KeyDown);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "EMBALAGEM",
            "MATÉRIA PRIMA",
            "PRODUTOS HIGIENE E LIMPEZA"});
            this.cbCategoria.Location = new System.Drawing.Point(696, 25);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(305, 21);
            this.cbCategoria.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(125, 25);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(516, 20);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyDown);
            // 
            // labelInformacao
            // 
            this.labelInformacao.AutoSize = true;
            this.labelInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformacao.ForeColor = System.Drawing.Color.Blue;
            this.labelInformacao.Location = new System.Drawing.Point(12, 618);
            this.labelInformacao.Name = "labelInformacao";
            this.labelInformacao.Size = new System.Drawing.Size(15, 15);
            this.labelInformacao.TabIndex = 2;
            this.labelInformacao.Text = "..";
            // 
            // labelInformacao2
            // 
            this.labelInformacao2.AutoSize = true;
            this.labelInformacao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformacao2.ForeColor = System.Drawing.Color.Blue;
            this.labelInformacao2.Location = new System.Drawing.Point(12, 638);
            this.labelInformacao2.Name = "labelInformacao2";
            this.labelInformacao2.Size = new System.Drawing.Size(15, 15);
            this.labelInformacao2.TabIndex = 3;
            this.labelInformacao2.Text = "..";
            // 
            // frmListaItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 662);
            this.Controls.Add(this.labelInformacao2);
            this.Controls.Add(this.labelInformacao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridListaItens);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE ITENS";
            this.Load += new System.EventHandler(this.frmListaItens_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmListaItens_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridListaItens)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridListaItens;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque_minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidade_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
        private System.Windows.Forms.Label labelInformacao;
        private System.Windows.Forms.Label labelInformacao2;
    }
}