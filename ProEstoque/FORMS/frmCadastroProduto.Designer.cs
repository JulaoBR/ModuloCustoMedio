namespace ProEstoque
{
    partial class frmCadastroProduto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupTipoProduto = new System.Windows.Forms.GroupBox();
            this.gridProduto = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTipoProduto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.groupFornecedor = new System.Windows.Forms.GroupBox();
            this.gridFornecedor = new System.Windows.Forms.DataGridView();
            this.for_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dataOperacao = new System.Windows.Forms.DateTimePicker();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtEstoqueSeguranca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescricao = new ProEstoque.CONTROL.txtControle();
            this.panel1.SuspendLayout();
            this.groupTipoProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).BeginInit();
            this.groupFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupTipoProduto);
            this.panel1.Controls.Add(this.groupFornecedor);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbUnidadeMedida);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbCategoria);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.dataOperacao);
            this.panel1.Controls.Add(this.txtCodProduto);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(6, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 514);
            this.panel1.TabIndex = 1;
            // 
            // groupTipoProduto
            // 
            this.groupTipoProduto.Controls.Add(this.gridProduto);
            this.groupTipoProduto.Controls.Add(this.cbTipoProduto);
            this.groupTipoProduto.Controls.Add(this.label7);
            this.groupTipoProduto.Controls.Add(this.btnAddProduto);
            this.groupTipoProduto.Location = new System.Drawing.Point(381, 167);
            this.groupTipoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.groupTipoProduto.Name = "groupTipoProduto";
            this.groupTipoProduto.Padding = new System.Windows.Forms.Padding(2);
            this.groupTipoProduto.Size = new System.Drawing.Size(347, 234);
            this.groupTipoProduto.TabIndex = 25;
            this.groupTipoProduto.TabStop = false;
            this.groupTipoProduto.Text = "Adicionar tipo de produto";
            // 
            // gridProduto
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.gridProduto.Location = new System.Drawing.Point(4, 80);
            this.gridProduto.Margin = new System.Windows.Forms.Padding(2);
            this.gridProduto.Name = "gridProduto";
            this.gridProduto.RowHeadersVisible = false;
            this.gridProduto.RowTemplate.Height = 24;
            this.gridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProduto.Size = new System.Drawing.Size(331, 149);
            this.gridProduto.TabIndex = 21;
            this.gridProduto.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tipo_cod";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tipo_descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "DESCRIÇÃO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // cbTipoProduto
            // 
            this.cbTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProduto.FormattingEnabled = true;
            this.cbTipoProduto.Location = new System.Drawing.Point(4, 46);
            this.cbTipoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoProduto.Name = "cbTipoProduto";
            this.cbTipoProduto.Size = new System.Drawing.Size(254, 23);
            this.cbTipoProduto.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tipo de produto";
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddProduto.Image = global::ProEstoque.Properties.Resources.Box_icon;
            this.btnAddProduto.Location = new System.Drawing.Point(264, 46);
            this.btnAddProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(71, 21);
            this.btnAddProduto.TabIndex = 8;
            this.btnAddProduto.UseVisualStyleBackColor = false;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // groupFornecedor
            // 
            this.groupFornecedor.Controls.Add(this.gridFornecedor);
            this.groupFornecedor.Controls.Add(this.cbFornecedor);
            this.groupFornecedor.Controls.Add(this.label3);
            this.groupFornecedor.Controls.Add(this.btnAdd);
            this.groupFornecedor.Location = new System.Drawing.Point(10, 167);
            this.groupFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.groupFornecedor.Name = "groupFornecedor";
            this.groupFornecedor.Padding = new System.Windows.Forms.Padding(2);
            this.groupFornecedor.Size = new System.Drawing.Size(366, 234);
            this.groupFornecedor.TabIndex = 24;
            this.groupFornecedor.TabStop = false;
            this.groupFornecedor.Text = "Adicionar fornecedores";
            // 
            // gridFornecedor
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridFornecedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.for_cod,
            this.for_descricao});
            this.gridFornecedor.Location = new System.Drawing.Point(4, 80);
            this.gridFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.gridFornecedor.Name = "gridFornecedor";
            this.gridFornecedor.RowHeadersVisible = false;
            this.gridFornecedor.RowTemplate.Height = 24;
            this.gridFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFornecedor.Size = new System.Drawing.Size(331, 149);
            this.gridFornecedor.TabIndex = 21;
            this.gridFornecedor.TabStop = false;
            this.gridFornecedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFornecedor_CellDoubleClick);
            // 
            // for_cod
            // 
            this.for_cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.for_cod.DataPropertyName = "for_cod";
            this.for_cod.HeaderText = "ID";
            this.for_cod.Name = "for_cod";
            this.for_cod.ReadOnly = true;
            this.for_cod.Width = 50;
            // 
            // for_descricao
            // 
            this.for_descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.for_descricao.DataPropertyName = "for_descricao";
            this.for_descricao.HeaderText = "DESCRIÇÃO";
            this.for_descricao.Name = "for_descricao";
            this.for_descricao.ReadOnly = true;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(4, 46);
            this.cbFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(254, 23);
            this.cbFornecedor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fornecedores";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdd.Image = global::ProEstoque.Properties.Resources.Actions_list_add_user_icon;
            this.btnAdd.Location = new System.Drawing.Point(264, 46);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 21);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::ProEstoque.Properties.Resources.Save_icon;
            this.btnSalvar.Location = new System.Drawing.Point(297, 442);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 67);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Unidade medida:";
            // 
            // cbUnidadeMedida
            // 
            this.cbUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidadeMedida.FormattingEnabled = true;
            this.cbUnidadeMedida.Items.AddRange(new object[] {
            " ",
            "CX",
            "LT",
            "FD",
            "KG",
            "ML",
            "UN",
            "PCT"});
            this.cbUnidadeMedida.Location = new System.Drawing.Point(309, 127);
            this.cbUnidadeMedida.Name = "cbUnidadeMedida";
            this.cbUnidadeMedida.Size = new System.Drawing.Size(198, 23);
            this.cbUnidadeMedida.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEstoqueSeguranca);
            this.groupBox1.Controls.Add(this.txtEstoqueMinimo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(516, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 101);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definição do estoque minimo";
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(90, 32);
            this.txtEstoqueMinimo.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(97, 21);
            this.txtEstoqueMinimo.TabIndex = 3;
            this.txtEstoqueMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueMinimo_KeyPress_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            " ",
            "EMBALAGEM",
            "MATÉRIA PRIMA",
            "PRODUTOS HIGIENE E LIMPEZA"});
            this.cbCategoria.Location = new System.Drawing.Point(10, 127);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(280, 23);
            this.cbCategoria.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data entrada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProEstoque.Properties.Resources.Close_2_icon;
            this.btnCancelar.Location = new System.Drawing.Point(624, 442);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 67);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::ProEstoque.Properties.Resources.delete_file_icon;
            this.btnExcluir.Location = new System.Drawing.Point(516, 441);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(104, 67);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::ProEstoque.Properties.Resources.Actions_document_edit_icon;
            this.btnEditar.Location = new System.Drawing.Point(405, 441);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(104, 67);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.TabStop = false;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dataOperacao
            // 
            this.dataOperacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataOperacao.Location = new System.Drawing.Point(606, 35);
            this.dataOperacao.Margin = new System.Windows.Forms.Padding(2);
            this.dataOperacao.Name = "dataOperacao";
            this.dataOperacao.Size = new System.Drawing.Size(119, 21);
            this.dataOperacao.TabIndex = 6;
            this.dataOperacao.TabStop = false;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(10, 37);
            this.txtCodProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.ReadOnly = true;
            this.txtCodProduto.Size = new System.Drawing.Size(76, 21);
            this.txtCodProduto.TabIndex = 0;
            this.txtCodProduto.TabStop = false;
            // 
            // txtEstoqueSeguranca
            // 
            this.txtEstoqueSeguranca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtEstoqueSeguranca.Location = new System.Drawing.Point(90, 68);
            this.txtEstoqueSeguranca.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstoqueSeguranca.Name = "txtEstoqueSeguranca";
            this.txtEstoqueSeguranca.Size = new System.Drawing.Size(97, 21);
            this.txtEstoqueSeguranca.TabIndex = 4;
            this.txtEstoqueSeguranca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueSeguranca_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Segurança:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Minimo:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(10, 80);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(497, 21);
            this.txtDescricao.TabIndex = 0;
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 534);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupTipoProduto.ResumeLayout(false);
            this.groupTipoProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).EndInit();
            this.groupFornecedor.ResumeLayout(false);
            this.groupFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dataOperacao;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbUnidadeMedida;
        private CONTROL.txtControle txtDescricao;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridFornecedor;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_descricao;
        private System.Windows.Forms.TextBox txtEstoqueMinimo;
        private System.Windows.Forms.GroupBox groupTipoProduto;
        private System.Windows.Forms.DataGridView gridProduto;
        private System.Windows.Forms.ComboBox cbTipoProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.GroupBox groupFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEstoqueSeguranca;
    }
}