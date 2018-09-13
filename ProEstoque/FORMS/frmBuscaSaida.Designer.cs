namespace ProEstoque.FORMS
{
    partial class frmBuscaSaida
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
            this.gridProduto = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtData2 = new System.Windows.Forms.DateTimePicker();
            this.txtData1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoProduto = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.reg_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_unidade_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_data_operacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridProduto
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProduto.BackgroundColor = System.Drawing.Color.White;
            this.gridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reg_cod,
            this.pro_descricao,
            this.tipo_descricao,
            this.reg_quantidade,
            this.pro_unidade_medida,
            this.reg_data_operacao});
            this.gridProduto.GridColor = System.Drawing.Color.White;
            this.gridProduto.Location = new System.Drawing.Point(6, 78);
            this.gridProduto.Margin = new System.Windows.Forms.Padding(2);
            this.gridProduto.MultiSelect = false;
            this.gridProduto.Name = "gridProduto";
            this.gridProduto.ReadOnly = true;
            this.gridProduto.RowHeadersVisible = false;
            this.gridProduto.RowTemplate.Height = 24;
            this.gridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProduto.Size = new System.Drawing.Size(922, 434);
            this.gridProduto.TabIndex = 8;
            this.gridProduto.TabStop = false;
            this.gridProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProduto_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbTipoProduto);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Location = new System.Drawing.Point(6, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 66);
            this.panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtData2);
            this.groupBox1.Controls.Add(this.txtData1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(323, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 45);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um periodo";
            // 
            // txtData2
            // 
            this.txtData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData2.Location = new System.Drawing.Point(142, 16);
            this.txtData2.Name = "txtData2";
            this.txtData2.Size = new System.Drawing.Size(106, 20);
            this.txtData2.TabIndex = 20;
            // 
            // txtData1
            // 
            this.txtData1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData1.Location = new System.Drawing.Point(6, 17);
            this.txtData1.Name = "txtData1";
            this.txtData1.Size = new System.Drawing.Size(106, 20);
            this.txtData1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "à";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Image = global::ProEstoque.Properties.Resources.Actions_edit_find_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(816, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "BUSCAR ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo do produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descricao:";
            // 
            // cbTipoProduto
            // 
            this.cbTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProduto.FormattingEnabled = true;
            this.cbTipoProduto.Items.AddRange(new object[] {
            "",
            "EMBALAGEM",
            "MATÉRIA PRIMA",
            "PRODUTOS HIGIENE E LIMPEZA"});
            this.cbTipoProduto.Location = new System.Drawing.Point(608, 32);
            this.cbTipoProduto.Name = "cbTipoProduto";
            this.cbTipoProduto.Size = new System.Drawing.Size(198, 21);
            this.cbTipoProduto.TabIndex = 3;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(2, 32);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(315, 20);
            this.txtDescricao.TabIndex = 0;
            // 
            // reg_cod
            // 
            this.reg_cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reg_cod.DataPropertyName = "reg_cod";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.reg_cod.DefaultCellStyle = dataGridViewCellStyle2;
            this.reg_cod.HeaderText = "#";
            this.reg_cod.Name = "reg_cod";
            this.reg_cod.ReadOnly = true;
            this.reg_cod.Width = 80;
            // 
            // pro_descricao
            // 
            this.pro_descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pro_descricao.DataPropertyName = "descricao";
            this.pro_descricao.HeaderText = "PRODUTO";
            this.pro_descricao.Name = "pro_descricao";
            this.pro_descricao.ReadOnly = true;
            // 
            // tipo_descricao
            // 
            this.tipo_descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tipo_descricao.DataPropertyName = "tipo_descricao";
            this.tipo_descricao.HeaderText = "GRUPO";
            this.tipo_descricao.Name = "tipo_descricao";
            this.tipo_descricao.ReadOnly = true;
            this.tipo_descricao.Width = 150;
            // 
            // reg_quantidade
            // 
            this.reg_quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reg_quantidade.DataPropertyName = "quantidade";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            this.reg_quantidade.DefaultCellStyle = dataGridViewCellStyle3;
            this.reg_quantidade.HeaderText = "QUANTIDADE";
            this.reg_quantidade.Name = "reg_quantidade";
            this.reg_quantidade.ReadOnly = true;
            this.reg_quantidade.Width = 90;
            // 
            // pro_unidade_medida
            // 
            this.pro_unidade_medida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pro_unidade_medida.DataPropertyName = "unidade_medida";
            this.pro_unidade_medida.HeaderText = "MEDIDA";
            this.pro_unidade_medida.Name = "pro_unidade_medida";
            this.pro_unidade_medida.ReadOnly = true;
            this.pro_unidade_medida.Width = 80;
            // 
            // reg_data_operacao
            // 
            this.reg_data_operacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reg_data_operacao.DataPropertyName = "dataOperacao";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.reg_data_operacao.DefaultCellStyle = dataGridViewCellStyle4;
            this.reg_data_operacao.HeaderText = "DATA SAIDA";
            this.reg_data_operacao.Name = "reg_data_operacao";
            this.reg_data_operacao.ReadOnly = true;
            // 
            // frmBuscaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridProduto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscaSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCA DA SAIDAS";
            this.Load += new System.EventHandler(this.frmBuscaSaida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtData2;
        private System.Windows.Forms.DateTimePicker txtData1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoProduto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_unidade_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_data_operacao;
    }
}