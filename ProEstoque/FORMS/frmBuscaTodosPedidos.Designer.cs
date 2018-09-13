namespace ProEstoque.FORMS
{
    partial class frmBuscaTodosPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gridPedido = new System.Windows.Forms.DataGridView();
            this.ped_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ped_data_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ped_data_prevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ped_data_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ped_observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ped_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rbRecebido = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbNaoRecebido = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbNaoRecebido);
            this.panel1.Controls.Add(this.rbTodos);
            this.panel1.Controls.Add(this.rbRecebido);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 63);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 52);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTRO PARA BUSCA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descricao do produto:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(9, 28);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(306, 20);
            this.txtDescricao.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(910, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ESC Sair";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Image = global::ProEstoque.Properties.Resources.Actions_edit_find_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(867, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "BUSCAR ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridPedido
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPedido.BackgroundColor = System.Drawing.Color.White;
            this.gridPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ped_cod,
            this.pro_descricao,
            this.for_descricao,
            this.reg_quantidade,
            this.ped_data_pedido,
            this.ped_data_prevista,
            this.ped_data_entrega,
            this.ped_observacao,
            this.ped_status});
            this.gridPedido.GridColor = System.Drawing.Color.White;
            this.gridPedido.Location = new System.Drawing.Point(9, 86);
            this.gridPedido.Margin = new System.Windows.Forms.Padding(2);
            this.gridPedido.MultiSelect = false;
            this.gridPedido.Name = "gridPedido";
            this.gridPedido.ReadOnly = true;
            this.gridPedido.RowHeadersVisible = false;
            this.gridPedido.RowTemplate.Height = 24;
            this.gridPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPedido.Size = new System.Drawing.Size(976, 456);
            this.gridPedido.TabIndex = 12;
            // 
            // ped_cod
            // 
            this.ped_cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ped_cod.DataPropertyName = "ped_cod";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ped_cod.DefaultCellStyle = dataGridViewCellStyle5;
            this.ped_cod.HeaderText = "Nº PEDIDO";
            this.ped_cod.Name = "ped_cod";
            this.ped_cod.ReadOnly = true;
            this.ped_cod.Width = 90;
            // 
            // pro_descricao
            // 
            this.pro_descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pro_descricao.DataPropertyName = "pro_descricao";
            this.pro_descricao.HeaderText = "PRODUTO";
            this.pro_descricao.Name = "pro_descricao";
            this.pro_descricao.ReadOnly = true;
            this.pro_descricao.Width = 300;
            // 
            // for_descricao
            // 
            this.for_descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.for_descricao.DataPropertyName = "for_descricao";
            this.for_descricao.HeaderText = "FORNECEDOR";
            this.for_descricao.Name = "for_descricao";
            this.for_descricao.ReadOnly = true;
            this.for_descricao.Width = 250;
            // 
            // reg_quantidade
            // 
            this.reg_quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reg_quantidade.DataPropertyName = "ped_quantidade";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.reg_quantidade.DefaultCellStyle = dataGridViewCellStyle6;
            this.reg_quantidade.HeaderText = "QTD";
            this.reg_quantidade.Name = "reg_quantidade";
            this.reg_quantidade.ReadOnly = true;
            this.reg_quantidade.Width = 80;
            // 
            // ped_data_pedido
            // 
            this.ped_data_pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ped_data_pedido.DataPropertyName = "ped_data_pedido";
            this.ped_data_pedido.HeaderText = "DT PEDIDO";
            this.ped_data_pedido.Name = "ped_data_pedido";
            this.ped_data_pedido.ReadOnly = true;
            // 
            // ped_data_prevista
            // 
            this.ped_data_prevista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ped_data_prevista.DataPropertyName = "ped_data_prevista";
            this.ped_data_prevista.HeaderText = "DT PREVISTA";
            this.ped_data_prevista.Name = "ped_data_prevista";
            this.ped_data_prevista.ReadOnly = true;
            this.ped_data_prevista.Width = 110;
            // 
            // ped_data_entrega
            // 
            this.ped_data_entrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ped_data_entrega.DataPropertyName = "ped_data_entrega";
            this.ped_data_entrega.HeaderText = "DT ENTREGA";
            this.ped_data_entrega.Name = "ped_data_entrega";
            this.ped_data_entrega.ReadOnly = true;
            this.ped_data_entrega.Width = 110;
            // 
            // ped_observacao
            // 
            this.ped_observacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ped_observacao.DataPropertyName = "ped_observacao";
            this.ped_observacao.HeaderText = "OBSERVAÇÃO";
            this.ped_observacao.Name = "ped_observacao";
            this.ped_observacao.ReadOnly = true;
            this.ped_observacao.Width = 164;
            // 
            // ped_status
            // 
            this.ped_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ped_status.DataPropertyName = "ped_status";
            this.ped_status.HeaderText = "STATUS";
            this.ped_status.Name = "ped_status";
            this.ped_status.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pedidos atrasados";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(9, 588);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(22, 14);
            this.panel2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Pedidos dentro do prazo";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSalmon;
            this.panel4.Location = new System.Drawing.Point(165, 588);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(22, 14);
            this.panel4.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Pedidos recebidos";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.Location = new System.Drawing.Point(383, 588);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(22, 14);
            this.panel5.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(473, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Pedidos dentro do prazo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(269, 556);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Pedidos recebidos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 556);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Pedidos atrasados";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(445, 557);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(22, 14);
            this.panel3.TabIndex = 29;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gold;
            this.panel6.Location = new System.Drawing.Point(241, 557);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(22, 14);
            this.panel6.TabIndex = 28;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.panel7.Location = new System.Drawing.Point(12, 557);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(22, 14);
            this.panel7.TabIndex = 27;
            // 
            // rbRecebido
            // 
            this.rbRecebido.AutoSize = true;
            this.rbRecebido.Location = new System.Drawing.Point(555, 26);
            this.rbRecebido.Name = "rbRecebido";
            this.rbRecebido.Size = new System.Drawing.Size(87, 17);
            this.rbRecebido.TabIndex = 22;
            this.rbRecebido.TabStop = true;
            this.rbRecebido.Text = "RECEBIDOS";
            this.rbRecebido.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(793, 26);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(63, 17);
            this.rbTodos.TabIndex = 23;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "TODOS";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbNaoRecebido
            // 
            this.rbNaoRecebido.AutoSize = true;
            this.rbNaoRecebido.Location = new System.Drawing.Point(668, 26);
            this.rbNaoRecebido.Name = "rbNaoRecebido";
            this.rbNaoRecebido.Size = new System.Drawing.Size(106, 17);
            this.rbNaoRecebido.TabIndex = 24;
            this.rbNaoRecebido.TabStop = true;
            this.rbNaoRecebido.Text = "NÃO RECEBIDO";
            this.rbNaoRecebido.UseVisualStyleBackColor = true;
            // 
            // frmBuscaTodosPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 574);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridPedido);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscaTodosPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCA DAS ENTRADAS";
            this.Load += new System.EventHandler(this.frmBuscaEntrada_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBuscaTodosPedidos_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_data_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_data_prevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_data_entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_status;
        private System.Windows.Forms.RadioButton rbNaoRecebido;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbRecebido;
    }
}