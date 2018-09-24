namespace ProEstoque
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalDeProdutoUtilizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridProduto = new System.Windows.Forms.DataGridView();
            this.ped_data_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_unidade_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ped_data_prevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControle = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPermissao = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnListaPedidos = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnListaItens = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçãoToolStripMenuItem,
            this.relatoriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1036, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustesToolStripMenuItem,
            this.cadastroFornecedorToolStripMenuItem,
            this.cadastroProdutosToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Enabled = false;
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configurações";
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            this.ajustesToolStripMenuItem.Click += new System.EventHandler(this.ajustesToolStripMenuItem_Click);
            // 
            // cadastroFornecedorToolStripMenuItem
            // 
            this.cadastroFornecedorToolStripMenuItem.Image = global::ProEstoque.Properties.Resources.Actions_list_add_user_icon;
            this.cadastroFornecedorToolStripMenuItem.Name = "cadastroFornecedorToolStripMenuItem";
            this.cadastroFornecedorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cadastroFornecedorToolStripMenuItem.Text = "Cadastro fornecedor";
            this.cadastroFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadastroFornecedorToolStripMenuItem_Click);
            // 
            // cadastroProdutosToolStripMenuItem
            // 
            this.cadastroProdutosToolStripMenuItem.Image = global::ProEstoque.Properties.Resources.Box_icon;
            this.cadastroProdutosToolStripMenuItem.Name = "cadastroProdutosToolStripMenuItem";
            this.cadastroProdutosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cadastroProdutosToolStripMenuItem.Text = "Cadastro Produtos";
            this.cadastroProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroProdutosToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalDeProdutoUtilizadosToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // totalDeProdutoUtilizadosToolStripMenuItem
            // 
            this.totalDeProdutoUtilizadosToolStripMenuItem.Name = "totalDeProdutoUtilizadosToolStripMenuItem";
            this.totalDeProdutoUtilizadosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.totalDeProdutoUtilizadosToolStripMenuItem.Text = "Total de produto utilizados";
            this.totalDeProdutoUtilizadosToolStripMenuItem.Click += new System.EventHandler(this.totalDeProdutoUtilizadosToolStripMenuItem_Click);
            // 
            // gridProduto
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gridProduto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ped_data_pedido,
            this.pro_descricao,
            this.for_descricao,
            this.reg_quantidade,
            this.pro_unidade_medida,
            this.ped_data_prevista});
            this.gridProduto.GridColor = System.Drawing.SystemColors.Control;
            this.gridProduto.Location = new System.Drawing.Point(6, 46);
            this.gridProduto.Name = "gridProduto";
            this.gridProduto.ReadOnly = true;
            this.gridProduto.RowHeadersVisible = false;
            this.gridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProduto.Size = new System.Drawing.Size(818, 494);
            this.gridProduto.TabIndex = 11;
            this.gridProduto.TabStop = false;
            // 
            // ped_data_pedido
            // 
            this.ped_data_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ped_data_pedido.DataPropertyName = "ped_data_pedido";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ped_data_pedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.ped_data_pedido.HeaderText = "DT PEDIDO";
            this.ped_data_pedido.Name = "ped_data_pedido";
            this.ped_data_pedido.ReadOnly = true;
            this.ped_data_pedido.Width = 90;
            // 
            // pro_descricao
            // 
            this.pro_descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pro_descricao.DataPropertyName = "pro_descricao";
            this.pro_descricao.HeaderText = "PRODUTO";
            this.pro_descricao.Name = "pro_descricao";
            this.pro_descricao.ReadOnly = true;
            // 
            // for_descricao
            // 
            this.for_descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.for_descricao.DataPropertyName = "for_descricao";
            this.for_descricao.HeaderText = "FORNECEDOR";
            this.for_descricao.Name = "for_descricao";
            this.for_descricao.ReadOnly = true;
            this.for_descricao.Width = 200;
            // 
            // reg_quantidade
            // 
            this.reg_quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reg_quantidade.DataPropertyName = "ped_quantidade";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.reg_quantidade.DefaultCellStyle = dataGridViewCellStyle3;
            this.reg_quantidade.HeaderText = "QTD";
            this.reg_quantidade.Name = "reg_quantidade";
            this.reg_quantidade.ReadOnly = true;
            this.reg_quantidade.Width = 80;
            // 
            // pro_unidade_medida
            // 
            this.pro_unidade_medida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pro_unidade_medida.DataPropertyName = "unidade_medida";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.pro_unidade_medida.DefaultCellStyle = dataGridViewCellStyle4;
            this.pro_unidade_medida.HeaderText = "UNIDADE";
            this.pro_unidade_medida.Name = "pro_unidade_medida";
            this.pro_unidade_medida.ReadOnly = true;
            this.pro_unidade_medida.Width = 80;
            // 
            // ped_data_prevista
            // 
            this.ped_data_prevista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ped_data_prevista.DataPropertyName = "ped_data_prevista";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ped_data_prevista.DefaultCellStyle = dataGridViewCellStyle5;
            this.ped_data_prevista.HeaderText = "ENT. PREVISTA";
            this.ped_data_prevista.Name = "ped_data_prevista";
            this.ped_data_prevista.ReadOnly = true;
            this.ped_data_prevista.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gridProduto);
            this.panel1.Location = new System.Drawing.Point(197, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 575);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(471, 557);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Pedidos dentro do prazo";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(443, 558);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(22, 14);
            this.panel4.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Digite o nome do produto:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(157, 20);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(658, 20);
            this.txtDescricao.TabIndex = 21;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pedidos do dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Pedidos atrasados";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(244, 558);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(22, 14);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(15, 558);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(22, 14);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "PEDIDOS";
            // 
            // panelControle
            // 
            this.panelControle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControle.Controls.Add(this.label5);
            this.panelControle.Controls.Add(this.button3);
            this.panelControle.Controls.Add(this.txtPermissao);
            this.panelControle.Location = new System.Drawing.Point(11, 427);
            this.panelControle.Name = "panelControle";
            this.panelControle.Size = new System.Drawing.Size(161, 100);
            this.panelControle.TabIndex = 0;
            this.panelControle.TabStop = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Digite a senha:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Acessar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPermissao
            // 
            this.txtPermissao.Location = new System.Drawing.Point(17, 25);
            this.txtPermissao.Name = "txtPermissao";
            this.txtPermissao.Size = new System.Drawing.Size(117, 20);
            this.txtPermissao.TabIndex = 0;
            this.txtPermissao.UseSystemPasswordChar = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(11, 553);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(159, 23);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.Text = "Atualizar dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(13, 585);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(159, 23);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnListaPedidos
            // 
            this.btnListaPedidos.Enabled = false;
            this.btnListaPedidos.Image = global::ProEstoque.Properties.Resources.list_icon;
            this.btnListaPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaPedidos.Location = new System.Drawing.Point(13, 335);
            this.btnListaPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnListaPedidos.Name = "btnListaPedidos";
            this.btnListaPedidos.Size = new System.Drawing.Size(157, 62);
            this.btnListaPedidos.TabIndex = 14;
            this.btnListaPedidos.TabStop = false;
            this.btnListaPedidos.Text = "PEDIDOS";
            this.btnListaPedidos.UseVisualStyleBackColor = true;
            this.btnListaPedidos.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnPedido
            // 
            this.btnPedido.Enabled = false;
            this.btnPedido.Image = global::ProEstoque.Properties.Resources.Order_icon1;
            this.btnPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.Location = new System.Drawing.Point(11, 26);
            this.btnPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(159, 62);
            this.btnPedido.TabIndex = 6;
            this.btnPedido.TabStop = false;
            this.btnPedido.Text = "PEDIDO / COTAÇÃO";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnListaItens
            // 
            this.btnListaItens.Enabled = false;
            this.btnListaItens.Image = global::ProEstoque.Properties.Resources.list_icon;
            this.btnListaItens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaItens.Location = new System.Drawing.Point(13, 256);
            this.btnListaItens.Margin = new System.Windows.Forms.Padding(2);
            this.btnListaItens.Name = "btnListaItens";
            this.btnListaItens.Size = new System.Drawing.Size(157, 62);
            this.btnListaItens.TabIndex = 3;
            this.btnListaItens.TabStop = false;
            this.btnListaItens.Text = "ESTOQUE";
            this.btnListaItens.UseVisualStyleBackColor = true;
            this.btnListaItens.Click += new System.EventHandler(this.btnListaItens_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.Enabled = false;
            this.btnSaida.Image = global::ProEstoque.Properties.Resources.Actions_list_remove_icon;
            this.btnSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaida.Location = new System.Drawing.Point(11, 178);
            this.btnSaida.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(159, 62);
            this.btnSaida.TabIndex = 2;
            this.btnSaida.TabStop = false;
            this.btnSaida.Text = "SAIDA";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Enabled = false;
            this.btnEntrada.Image = global::ProEstoque.Properties.Resources.Actions_list_add_icon;
            this.btnEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrada.Location = new System.Drawing.Point(11, 100);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(159, 62);
            this.btnEntrada.TabIndex = 1;
            this.btnEntrada.TabStop = false;
            this.btnEntrada.Text = "ENTRADA";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 614);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnListaPedidos);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControle);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnListaItens);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1052, 652);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelControle.ResumeLayout(false);
            this.panelControle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Button btnListaItens;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.DataGridView gridProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnListaPedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelControle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPermissao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_data_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_unidade_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_data_prevista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalDeProdutoUtilizadosToolStripMenuItem;
    }
}

