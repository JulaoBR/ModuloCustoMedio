namespace ProEstoque
{
    partial class frmEntrada
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodPedido = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDataPedido = new System.Windows.Forms.TextBox();
            this.txtDataPrevista = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.gridProduto = new System.Windows.Forms.DataGridView();
            this.reg_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorFrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCodRegistro = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtFrete = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dataOperacao = new System.Windows.Forms.DateTimePicker();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtCodPedido);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtDataPedido);
            this.panel1.Controls.Add(this.txtDataPrevista);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtObservacao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtContato);
            this.panel1.Controls.Add(this.gridProduto);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.dataOperacao);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(11, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 490);
            this.panel1.TabIndex = 0;
            // 
            // txtCodPedido
            // 
            this.txtCodPedido.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtCodPedido.ForeColor = System.Drawing.Color.White;
            this.txtCodPedido.Location = new System.Drawing.Point(17, 19);
            this.txtCodPedido.Name = "txtCodPedido";
            this.txtCodPedido.ReadOnly = true;
            this.txtCodPedido.Size = new System.Drawing.Size(91, 21);
            this.txtCodPedido.TabIndex = 39;
            this.txtCodPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(308, -2);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 15);
            this.label14.TabIndex = 38;
            this.label14.Text = "Data pedido";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(459, -2);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 15);
            this.label13.TabIndex = 37;
            this.label13.Text = "Data prevista";
            // 
            // txtDataPedido
            // 
            this.txtDataPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataPedido.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtDataPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDataPedido.ForeColor = System.Drawing.Color.White;
            this.txtDataPedido.Location = new System.Drawing.Point(311, 16);
            this.txtDataPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataPedido.Name = "txtDataPedido";
            this.txtDataPedido.ReadOnly = true;
            this.txtDataPedido.Size = new System.Drawing.Size(124, 21);
            this.txtDataPedido.TabIndex = 36;
            this.txtDataPedido.TabStop = false;
            this.txtDataPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDataPrevista
            // 
            this.txtDataPrevista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataPrevista.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtDataPrevista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDataPrevista.ForeColor = System.Drawing.Color.White;
            this.txtDataPrevista.Location = new System.Drawing.Point(462, 16);
            this.txtDataPrevista.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataPrevista.Name = "txtDataPrevista";
            this.txtDataPrevista.ReadOnly = true;
            this.txtDataPrevista.Size = new System.Drawing.Size(124, 21);
            this.txtDataPrevista.TabIndex = 35;
            this.txtDataPrevista.TabStop = false;
            this.txtDataPrevista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 89);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacao.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.ForeColor = System.Drawing.Color.White;
            this.txtObservacao.Location = new System.Drawing.Point(16, 106);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(2);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.ReadOnly = true;
            this.txtObservacao.Size = new System.Drawing.Size(718, 44);
            this.txtObservacao.TabIndex = 33;
            this.txtObservacao.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Contato:";
            // 
            // txtContato
            // 
            this.txtContato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContato.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContato.ForeColor = System.Drawing.Color.White;
            this.txtContato.Location = new System.Drawing.Point(549, 66);
            this.txtContato.Margin = new System.Windows.Forms.Padding(2);
            this.txtContato.Name = "txtContato";
            this.txtContato.ReadOnly = true;
            this.txtContato.Size = new System.Drawing.Size(176, 21);
            this.txtContato.TabIndex = 29;
            this.txtContato.TabStop = false;
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
            this.gridProduto.Location = new System.Drawing.Point(17, 253);
            this.gridProduto.Name = "gridProduto";
            this.gridProduto.RowHeadersVisible = false;
            this.gridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProduto.Size = new System.Drawing.Size(718, 159);
            this.gridProduto.TabIndex = 28;
            this.gridProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProduto_CellDoubleClick);
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
            // button1
            // 
            this.button1.Image = global::ProEstoque.Properties.Resources.Search_icon;
            this.button1.Location = new System.Drawing.Point(113, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 27);
            this.button1.TabIndex = 27;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Blue;
            this.labelTotal.Location = new System.Drawing.Point(17, 464);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(52, 18);
            this.labelTotal.TabIndex = 23;
            this.labelTotal.Text = "label9";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtCodRegistro);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtQuantidade);
            this.panel2.Controls.Add(this.txtFrete);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtProduto);
            this.panel2.Controls.Add(this.txtValorUnitario);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtValorTotal);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(17, 154);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 94);
            this.panel2.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 15);
            this.label15.TabIndex = 35;
            this.label15.Text = "Código";
            // 
            // txtCodRegistro
            // 
            this.txtCodRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtCodRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodRegistro.Location = new System.Drawing.Point(5, 16);
            this.txtCodRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodRegistro.Name = "txtCodRegistro";
            this.txtCodRegistro.ReadOnly = true;
            this.txtCodRegistro.Size = new System.Drawing.Size(95, 21);
            this.txtCodRegistro.TabIndex = 34;
            this.txtCodRegistro.TabStop = false;
            this.txtCodRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(574, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "RECALCULAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(5, 65);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(96, 21);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyDown);
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // txtFrete
            // 
            this.txtFrete.Location = new System.Drawing.Point(139, 66);
            this.txtFrete.Margin = new System.Windows.Forms.Padding(2);
            this.txtFrete.Name = "txtFrete";
            this.txtFrete.Size = new System.Drawing.Size(108, 21);
            this.txtFrete.TabIndex = 3;
            this.txtFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFrete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFrete_KeyDown);
            this.txtFrete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrete_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "VALOR FRETE (R$)*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "QUANTIDADE*:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, -1);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "Produto:";
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Location = new System.Drawing.Point(110, 16);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(443, 21);
            this.txtProduto.TabIndex = 31;
            this.txtProduto.TabStop = false;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtValorUnitario.Location = new System.Drawing.Point(574, 66);
            this.txtValorUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.ReadOnly = true;
            this.txtValorUnitario.Size = new System.Drawing.Size(102, 21);
            this.txtValorUnitario.TabIndex = 4;
            this.txtValorUnitario.TabStop = false;
            this.txtValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "VALOR TOTAL*:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.Color.White;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.ForeColor = System.Drawing.Color.Black;
            this.txtValorTotal.Location = new System.Drawing.Point(281, 65);
            this.txtValorTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(123, 22);
            this.txtValorTotal.TabIndex = 4;
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTotal_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "VALOR UNITARIO (R$)*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, -2);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data chegada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fornecedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nº PEDIDO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProEstoque.Properties.Resources.Close_2_icon;
            this.btnCancelar.Location = new System.Drawing.Point(634, 417);
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
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Image = global::ProEstoque.Properties.Resources.Save_icon;
            this.btnSalvar.Location = new System.Drawing.Point(526, 417);
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
            // dataOperacao
            // 
            this.dataOperacao.CustomFormat = "dd/mm/yyyy";
            this.dataOperacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataOperacao.Location = new System.Drawing.Point(604, 17);
            this.dataOperacao.Margin = new System.Windows.Forms.Padding(2);
            this.dataOperacao.Name = "dataOperacao";
            this.dataOperacao.Size = new System.Drawing.Size(124, 21);
            this.dataOperacao.TabIndex = 6;
            this.dataOperacao.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.ForeColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(14, 66);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(516, 21);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(692, 6);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "ESC sair";
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 524);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENTRADA";
            this.Load += new System.EventHandler(this.frmEntrada_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEntrada_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.DateTimePicker dataOperacao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.TextBox txtFrete;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDataPedido;
        private System.Windows.Forms.TextBox txtDataPrevista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorFrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCodRegistro;
        private System.Windows.Forms.TextBox txtCodPedido;
    }
}