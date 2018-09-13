namespace ProEstoque
{
    partial class frmSaida
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCategoriaSaida = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbProdutoLimpeza = new System.Windows.Forms.RadioButton();
            this.rbMateriaPrima = new System.Windows.Forms.RadioButton();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.rbEmbalagem = new System.Windows.Forms.RadioButton();
            this.cbTipoProduto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dataOperacao = new System.Windows.Forms.DateTimePicker();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbCategoriaSaida);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rbProdutoLimpeza);
            this.panel1.Controls.Add(this.rbMateriaPrima);
            this.panel1.Controls.Add(this.labelSaldo);
            this.panel1.Controls.Add(this.rbEmbalagem);
            this.panel1.Controls.Add(this.cbTipoProduto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnPesquisa);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.dataOperacao);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.txtCodProduto);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(9, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 346);
            this.panel1.TabIndex = 1;
            // 
            // cbCategoriaSaida
            // 
            this.cbCategoriaSaida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaSaida.FormattingEnabled = true;
            this.cbCategoriaSaida.Location = new System.Drawing.Point(390, 210);
            this.cbCategoriaSaida.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategoriaSaida.Name = "cbCategoriaSaida";
            this.cbCategoriaSaida.Size = new System.Drawing.Size(328, 23);
            this.cbCategoriaSaida.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Categoria de saida:";
            // 
            // rbProdutoLimpeza
            // 
            this.rbProdutoLimpeza.AutoSize = true;
            this.rbProdutoLimpeza.Location = new System.Drawing.Point(416, 37);
            this.rbProdutoLimpeza.Name = "rbProdutoLimpeza";
            this.rbProdutoLimpeza.Size = new System.Drawing.Size(132, 19);
            this.rbProdutoLimpeza.TabIndex = 29;
            this.rbProdutoLimpeza.TabStop = true;
            this.rbProdutoLimpeza.Text = "Produto de limpeza";
            this.rbProdutoLimpeza.UseVisualStyleBackColor = true;
            // 
            // rbMateriaPrima
            // 
            this.rbMateriaPrima.AutoSize = true;
            this.rbMateriaPrima.Location = new System.Drawing.Point(281, 37);
            this.rbMateriaPrima.Name = "rbMateriaPrima";
            this.rbMateriaPrima.Size = new System.Drawing.Size(103, 19);
            this.rbMateriaPrima.TabIndex = 28;
            this.rbMateriaPrima.TabStop = true;
            this.rbMateriaPrima.Text = "Matéria Prima";
            this.rbMateriaPrima.UseVisualStyleBackColor = true;
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.ForeColor = System.Drawing.Color.Blue;
            this.labelSaldo.Location = new System.Drawing.Point(36, 318);
            this.labelSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(52, 18);
            this.labelSaldo.TabIndex = 24;
            this.labelSaldo.Text = "label9";
            // 
            // rbEmbalagem
            // 
            this.rbEmbalagem.AutoSize = true;
            this.rbEmbalagem.Location = new System.Drawing.Point(162, 38);
            this.rbEmbalagem.Name = "rbEmbalagem";
            this.rbEmbalagem.Size = new System.Drawing.Size(93, 19);
            this.rbEmbalagem.TabIndex = 27;
            this.rbEmbalagem.TabStop = true;
            this.rbEmbalagem.Text = "Embalagem";
            this.rbEmbalagem.UseVisualStyleBackColor = true;
            // 
            // cbTipoProduto
            // 
            this.cbTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProduto.FormattingEnabled = true;
            this.cbTipoProduto.Location = new System.Drawing.Point(20, 210);
            this.cbTipoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoProduto.Name = "cbTipoProduto";
            this.cbTipoProduto.Size = new System.Drawing.Size(328, 23);
            this.cbTipoProduto.TabIndex = 3;
            this.cbTipoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTipoProduto_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Categoria de produto:";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::ProEstoque.Properties.Resources.Search_icon;
            this.btnPesquisa.Location = new System.Drawing.Point(97, 33);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(40, 27);
            this.btnPesquisa.TabIndex = 21;
            this.btnPesquisa.TabStop = false;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtQuantidade);
            this.panel2.Location = new System.Drawing.Point(20, 113);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 63);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "QUANTIDADE*:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(18, 27);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(123, 21);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidade_KeyDown);
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data saida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProEstoque.Properties.Resources.Close_2_icon;
            this.btnCancelar.Location = new System.Drawing.Point(620, 272);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 67);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::ProEstoque.Properties.Resources.Actions_document_edit_icon;
            this.btnEditar.Location = new System.Drawing.Point(499, 272);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 67);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.TabStop = false;
            this.btnEditar.Text = "LANÇAMENTOS";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::ProEstoque.Properties.Resources.Save_icon;
            this.btnSalvar.Location = new System.Drawing.Point(390, 272);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 67);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dataOperacao
            // 
            this.dataOperacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataOperacao.Location = new System.Drawing.Point(606, 35);
            this.dataOperacao.Margin = new System.Windows.Forms.Padding(2);
            this.dataOperacao.Name = "dataOperacao";
            this.dataOperacao.Size = new System.Drawing.Size(112, 21);
            this.dataOperacao.TabIndex = 6;
            this.dataOperacao.TabStop = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDescricao.Location = new System.Drawing.Point(17, 79);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(707, 21);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.TabStop = false;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(17, 37);
            this.txtCodProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(76, 21);
            this.txtCodProduto.TabIndex = 0;
            this.txtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProduto_KeyDown);
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(692, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "ESC sair";
            // 
            // frmSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 384);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAIDA";
            this.Load += new System.EventHandler(this.frmSaida_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSaida_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dataOperacao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTipoProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbProdutoLimpeza;
        private System.Windows.Forms.RadioButton rbMateriaPrima;
        private System.Windows.Forms.RadioButton rbEmbalagem;
        private System.Windows.Forms.ComboBox cbCategoriaSaida;
        private System.Windows.Forms.Label label6;
    }
}