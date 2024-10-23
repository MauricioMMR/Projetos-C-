namespace IPVA
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.lbl_Informe_seu_Estado = new System.Windows.Forms.Label();
            this.lbl_Informe_Tipo = new System.Windows.Forms.Label();
            this.rdb_Passeio = new System.Windows.Forms.RadioButton();
            this.rdb_Caminhonete = new System.Windows.Forms.RadioButton();
            this.lbl_Informe_o_valor = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.rdb_Moto = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IPVA.Properties.Resources.download_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(298, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 163);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Items.AddRange(new object[] {
            "RS",
            "SC",
            "PR",
            "SP",
            "RJ",
            "ES",
            "MG",
            "BA",
            "SE",
            "AL",
            "PE",
            "PB",
            "RN",
            "CE",
            "PI",
            "MA",
            "AP",
            "PA",
            "AM",
            "RO",
            "RR",
            "AC",
            "MT",
            "MS",
            "GO",
            "DF",
            "TO"});
            this.cmb_Estado.Location = new System.Drawing.Point(75, 255);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(131, 21);
            this.cmb_Estado.TabIndex = 1;
            this.cmb_Estado.Text = "Selecione";
            // 
            // lbl_Informe_seu_Estado
            // 
            this.lbl_Informe_seu_Estado.AutoSize = true;
            this.lbl_Informe_seu_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Informe_seu_Estado.Location = new System.Drawing.Point(72, 211);
            this.lbl_Informe_seu_Estado.Name = "lbl_Informe_seu_Estado";
            this.lbl_Informe_seu_Estado.Size = new System.Drawing.Size(137, 18);
            this.lbl_Informe_seu_Estado.TabIndex = 2;
            this.lbl_Informe_seu_Estado.Text = "Informe seu Estado";
            // 
            // lbl_Informe_Tipo
            // 
            this.lbl_Informe_Tipo.AutoSize = true;
            this.lbl_Informe_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Informe_Tipo.Location = new System.Drawing.Point(309, 211);
            this.lbl_Informe_Tipo.Name = "lbl_Informe_Tipo";
            this.lbl_Informe_Tipo.Size = new System.Drawing.Size(174, 18);
            this.lbl_Informe_Tipo.TabIndex = 3;
            this.lbl_Informe_Tipo.Text = "Informe  o tipo do veiculo";
            // 
            // rdb_Passeio
            // 
            this.rdb_Passeio.AutoSize = true;
            this.rdb_Passeio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Passeio.Location = new System.Drawing.Point(325, 255);
            this.rdb_Passeio.Name = "rdb_Passeio";
            this.rdb_Passeio.Size = new System.Drawing.Size(130, 20);
            this.rdb_Passeio.TabIndex = 4;
            this.rdb_Passeio.TabStop = true;
            this.rdb_Passeio.Text = "Carro de Passeio";
            this.rdb_Passeio.UseVisualStyleBackColor = true;
            // 
            // rdb_Caminhonete
            // 
            this.rdb_Caminhonete.AutoSize = true;
            this.rdb_Caminhonete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Caminhonete.Location = new System.Drawing.Point(325, 281);
            this.rdb_Caminhonete.Name = "rdb_Caminhonete";
            this.rdb_Caminhonete.Size = new System.Drawing.Size(180, 20);
            this.rdb_Caminhonete.TabIndex = 5;
            this.rdb_Caminhonete.TabStop = true;
            this.rdb_Caminhonete.Text = "Caminhonetes e Utilitarios";
            this.rdb_Caminhonete.UseVisualStyleBackColor = true;
            // 
            // lbl_Informe_o_valor
            // 
            this.lbl_Informe_o_valor.AutoSize = true;
            this.lbl_Informe_o_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Informe_o_valor.Location = new System.Drawing.Point(551, 211);
            this.lbl_Informe_o_valor.Name = "lbl_Informe_o_valor";
            this.lbl_Informe_o_valor.Size = new System.Drawing.Size(182, 18);
            this.lbl_Informe_o_valor.TabIndex = 6;
            this.lbl_Informe_o_valor.Text = "Informe  o valor do veiculo\r\n";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(563, 256);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(149, 20);
            this.txt_Valor.TabIndex = 7;
            this.txt_Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(275, 369);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(256, 50);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Calcular IPVA";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // rdb_Moto
            // 
            this.rdb_Moto.AutoSize = true;
            this.rdb_Moto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Moto.Location = new System.Drawing.Point(325, 307);
            this.rdb_Moto.Name = "rdb_Moto";
            this.rdb_Moto.Size = new System.Drawing.Size(101, 20);
            this.rdb_Moto.TabIndex = 9;
            this.rdb_Moto.TabStop = true;
            this.rdb_Moto.Text = "Motocicletas";
            this.rdb_Moto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdb_Moto);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.lbl_Informe_o_valor);
            this.Controls.Add(this.rdb_Caminhonete);
            this.Controls.Add(this.rdb_Passeio);
            this.Controls.Add(this.lbl_Informe_Tipo);
            this.Controls.Add(this.lbl_Informe_seu_Estado);
            this.Controls.Add(this.cmb_Estado);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "IPVA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.Label lbl_Informe_seu_Estado;
        private System.Windows.Forms.Label lbl_Informe_Tipo;
        private System.Windows.Forms.RadioButton rdb_Passeio;
        private System.Windows.Forms.RadioButton rdb_Caminhonete;
        private System.Windows.Forms.Label lbl_Informe_o_valor;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.RadioButton rdb_Moto;
    }
}

