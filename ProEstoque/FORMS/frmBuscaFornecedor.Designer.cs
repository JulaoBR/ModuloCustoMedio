namespace ProEstoque.FORMS
{
    partial class frmBuscaFornecedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gridFornecedor = new System.Windows.Forms.DataGridView();
            this.for_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.for_prazo_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 63);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descricao:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(6, 30);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(471, 20);
            this.txtDescricao.TabIndex = 6;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // gridFornecedor
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridFornecedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridFornecedor.BackgroundColor = System.Drawing.Color.White;
            this.gridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.for_cod,
            this.for_descricao,
            this.for_email,
            this.for_prazo_entrega});
            this.gridFornecedor.GridColor = System.Drawing.Color.White;
            this.gridFornecedor.Location = new System.Drawing.Point(9, 76);
            this.gridFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.gridFornecedor.MultiSelect = false;
            this.gridFornecedor.Name = "gridFornecedor";
            this.gridFornecedor.ReadOnly = true;
            this.gridFornecedor.RowHeadersVisible = false;
            this.gridFornecedor.RowTemplate.Height = 24;
            this.gridFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFornecedor.Size = new System.Drawing.Size(922, 436);
            this.gridFornecedor.TabIndex = 2;
            this.gridFornecedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFornecedor_CellDoubleClick);
            // 
            // for_cod
            // 
            this.for_cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.for_cod.DataPropertyName = "for_cod";
            this.for_cod.HeaderText = "#";
            this.for_cod.Name = "for_cod";
            this.for_cod.ReadOnly = true;
            this.for_cod.Width = 70;
            // 
            // for_descricao
            // 
            this.for_descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.for_descricao.DataPropertyName = "for_descricao";
            this.for_descricao.HeaderText = "FORNECEDOR";
            this.for_descricao.Name = "for_descricao";
            this.for_descricao.ReadOnly = true;
            // 
            // for_email
            // 
            this.for_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.for_email.DataPropertyName = "for_email";
            this.for_email.HeaderText = "E-MAIL";
            this.for_email.Name = "for_email";
            this.for_email.ReadOnly = true;
            this.for_email.Width = 250;
            // 
            // for_prazo_entrega
            // 
            this.for_prazo_entrega.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.for_prazo_entrega.DataPropertyName = "for_prazo_entrega";
            this.for_prazo_entrega.HeaderText = "PRAZO DE ENTREGA (DIAS)";
            this.for_prazo_entrega.Name = "for_prazo_entrega";
            this.for_prazo_entrega.ReadOnly = true;
            this.for_prazo_entrega.Width = 180;
            // 
            // frmBuscaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridFornecedor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCA FORNECEDOR";
            this.Load += new System.EventHandler(this.frmBuscaFornecedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridView gridFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn for_prazo_entrega;
    }
}