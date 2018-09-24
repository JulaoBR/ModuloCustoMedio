namespace ProEstoque.FORMS
{
    partial class frmConsumoMedio
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
            this.data1 = new System.Windows.Forms.MonthCalendar();
            this.data2 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mediaTotal = new System.Windows.Forms.Label();
            this.nomeProduto = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data1
            // 
            this.data1.Location = new System.Drawing.Point(12, 36);
            this.data1.Name = "data1";
            this.data1.TabIndex = 0;
            // 
            // data2
            // 
            this.data2.Location = new System.Drawing.Point(452, 36);
            this.data2.Name = "data2";
            this.data2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mediaTotal);
            this.panel1.Controls.Add(this.nomeProduto);
            this.panel1.Location = new System.Drawing.Point(12, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 209);
            this.panel1.TabIndex = 2;
            // 
            // mediaTotal
            // 
            this.mediaTotal.AutoSize = true;
            this.mediaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaTotal.Location = new System.Drawing.Point(16, 56);
            this.mediaTotal.Name = "mediaTotal";
            this.mediaTotal.Size = new System.Drawing.Size(18, 18);
            this.mediaTotal.TabIndex = 1;
            this.mediaTotal.Text = "..";
            // 
            // nomeProduto
            // 
            this.nomeProduto.AutoSize = true;
            this.nomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeProduto.Location = new System.Drawing.Point(16, 20);
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.Size = new System.Drawing.Size(18, 18);
            this.nomeProduto.TabIndex = 0;
            this.nomeProduto.Text = "..";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(508, 437);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 33);
            this.btnCarregar.TabIndex = 3;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(604, 437);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 33);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmConsumoMedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 485);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.data1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsumoMedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSUMO MÉDIO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar data1;
        private System.Windows.Forms.MonthCalendar data2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mediaTotal;
        private System.Windows.Forms.Label nomeProduto;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnLimpar;
    }
}