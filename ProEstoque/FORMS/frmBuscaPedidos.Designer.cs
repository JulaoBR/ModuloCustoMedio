namespace ProEstoque.FORMS
{
    partial class frmBuscaPedidos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gridProduto = new System.Windows.Forms.DataGridView();
            this.msgExcluir = new System.Windows.Forms.Label();
            this.ped_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidade_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ped_data_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ped_data_prevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ped_observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ped_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Location = new System.Drawing.Point(9, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 63);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Image = global::ProEstoque.Properties.Resources.Actions_edit_find_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(816, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "BUSCAR ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descricao:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(6, 32);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(509, 20);
            this.txtDescricao.TabIndex = 6;
            // 
            // gridProduto
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProduto.BackgroundColor = System.Drawing.Color.White;
            this.gridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ped_cod,
            this.pro_descricao,
            this.for_descricao,
            this.reg_quantidade,
            this.unidade_medida,
            this.ped_data_pedido,
            this.ped_data_prevista,
            this.ped_observacao,
            this.ped_status});
            this.gridProduto.GridColor = System.Drawing.Color.White;
            this.gridProduto.Location = new System.Drawing.Point(9, 83);
            this.gridProduto.Margin = new System.Windows.Forms.Padding(2);
            this.gridProduto.MultiSelect = false;
            this.gridProduto.Name = "gridProduto";
            this.gridProduto.ReadOnly = true;
            this.gridProduto.RowHeadersVisible = false;
            this.gridProduto.RowTemplate.Height = 24;
            this.gridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProduto.Size = new System.Drawing.Size(922, 408);
            this.gridProduto.TabIndex = 4;
            this.gridProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProduto_CellDoubleClick);
            // 
            // msgExcluir
            // 
            this.msgExcluir.AutoSize = true;
            this.msgExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgExcluir.ForeColor = System.Drawing.Color.Red;
            this.msgExcluir.Location = new System.Drawing.Point(9, 497);
            this.msgExcluir.Name = "msgExcluir";
            this.msgExcluir.Size = new System.Drawing.Size(15, 15);
            this.msgExcluir.TabIndex = 6;
            this.msgExcluir.Text = "..";
            // 
            // ped_cod
            // 
            this.ped_cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ped_cod.DataPropertyName = "ped_cod";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ped_cod.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.reg_quantidade.DefaultCellStyle = dataGridViewCellStyle3;
            this.reg_quantidade.HeaderText = "QTD";
            this.reg_quantidade.Name = "reg_quantidade";
            this.reg_quantidade.ReadOnly = true;
            this.reg_quantidade.Width = 80;
            // 
            // unidade_medida
            // 
            this.unidade_medida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.unidade_medida.DataPropertyName = "unidade_medida";
            this.unidade_medida.HeaderText = "UNIDADE";
            this.unidade_medida.Name = "unidade_medida";
            this.unidade_medida.ReadOnly = true;
            this.unidade_medida.Width = 80;
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
            // frmBuscaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 523);
            this.Controls.Add(this.msgExcluir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridProduto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscaPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEDIDOS";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridView gridProduto;
        private System.Windows.Forms.Label msgExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidade_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_data_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_data_prevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_status;
    }
}