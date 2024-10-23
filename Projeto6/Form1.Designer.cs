namespace Triangulo
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
            this.LblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.BtnMedida = new System.Windows.Forms.Button();
            this.btnValores = new System.Windows.Forms.Button();
            this.lblAnguloAlblAnguloA = new System.Windows.Forms.Label();
            this.lblAnguloB = new System.Windows.Forms.Label();
            this.lblAnguloC = new System.Windows.Forms.Label();
            this.txtAnguloA = new System.Windows.Forms.TextBox();
            this.txtAnguloB = new System.Windows.Forms.TextBox();
            this.txtAnguloC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblA.Location = new System.Drawing.Point(56, 136);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(145, 24);
            this.LblA.TabIndex = 0;
            this.LblA.Text = "Digite o Valor A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(305, 136);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(144, 24);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Digite o Valor B:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(558, 136);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(145, 24);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "Digite o Valor C:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(49, 179);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(169, 25);
            this.txtA.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(297, 179);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(169, 25);
            this.txtB.TabIndex = 4;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(545, 179);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(169, 25);
            this.txtC.TabIndex = 5;
            // 
            // BtnMedida
            // 
            this.BtnMedida.Location = new System.Drawing.Point(179, 351);
            this.BtnMedida.Name = "BtnMedida";
            this.BtnMedida.Size = new System.Drawing.Size(127, 30);
            this.BtnMedida.TabIndex = 6;
            this.BtnMedida.Text = "Classificar Medida";
            this.BtnMedida.UseVisualStyleBackColor = true;
            this.BtnMedida.Click += new System.EventHandler(this.BtnMedida_Click);
            // 
            // btnValores
            // 
            this.btnValores.Location = new System.Drawing.Point(442, 351);
            this.btnValores.Name = "btnValores";
            this.btnValores.Size = new System.Drawing.Size(127, 30);
            this.btnValores.TabIndex = 7;
            this.btnValores.Text = " Verificar Angulo";
            this.btnValores.UseVisualStyleBackColor = true;
            this.btnValores.Click += new System.EventHandler(this.btnValores_Click);
            // 
            // lblAnguloAlblAnguloA
            // 
            this.lblAnguloAlblAnguloA.AutoSize = true;
            this.lblAnguloAlblAnguloA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnguloAlblAnguloA.Location = new System.Drawing.Point(56, 225);
            this.lblAnguloAlblAnguloA.Name = "lblAnguloAlblAnguloA";
            this.lblAnguloAlblAnguloA.Size = new System.Drawing.Size(162, 24);
            this.lblAnguloAlblAnguloA.TabIndex = 8;
            this.lblAnguloAlblAnguloA.Text = "Digite o Angulo A:";
            // 
            // lblAnguloB
            // 
            this.lblAnguloB.AutoSize = true;
            this.lblAnguloB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnguloB.Location = new System.Drawing.Point(305, 225);
            this.lblAnguloB.Name = "lblAnguloB";
            this.lblAnguloB.Size = new System.Drawing.Size(161, 24);
            this.lblAnguloB.TabIndex = 9;
            this.lblAnguloB.Text = "Digite o Angulo B:";
            // 
            // lblAnguloC
            // 
            this.lblAnguloC.AutoSize = true;
            this.lblAnguloC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnguloC.Location = new System.Drawing.Point(541, 225);
            this.lblAnguloC.Name = "lblAnguloC";
            this.lblAnguloC.Size = new System.Drawing.Size(162, 24);
            this.lblAnguloC.TabIndex = 10;
            this.lblAnguloC.Text = "Digite o Angulo C:";
            // 
            // txtAnguloA
            // 
            this.txtAnguloA.Location = new System.Drawing.Point(49, 273);
            this.txtAnguloA.Multiline = true;
            this.txtAnguloA.Name = "txtAnguloA";
            this.txtAnguloA.Size = new System.Drawing.Size(169, 25);
            this.txtAnguloA.TabIndex = 11;
            // 
            // txtAnguloB
            // 
            this.txtAnguloB.Location = new System.Drawing.Point(297, 273);
            this.txtAnguloB.Multiline = true;
            this.txtAnguloB.Name = "txtAnguloB";
            this.txtAnguloB.Size = new System.Drawing.Size(169, 25);
            this.txtAnguloB.TabIndex = 12;
            // 
            // txtAnguloC
            // 
            this.txtAnguloC.Location = new System.Drawing.Point(545, 273);
            this.txtAnguloC.Multiline = true;
            this.txtAnguloC.Name = "txtAnguloC";
            this.txtAnguloC.Size = new System.Drawing.Size(169, 25);
            this.txtAnguloC.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAnguloC);
            this.Controls.Add(this.txtAnguloB);
            this.Controls.Add(this.txtAnguloA);
            this.Controls.Add(this.lblAnguloC);
            this.Controls.Add(this.lblAnguloB);
            this.Controls.Add(this.lblAnguloAlblAnguloA);
            this.Controls.Add(this.btnValores);
            this.Controls.Add(this.BtnMedida);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.LblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button BtnMedida;
        private System.Windows.Forms.Button btnValores;
        private System.Windows.Forms.Label lblAnguloAlblAnguloA;
        private System.Windows.Forms.Label lblAnguloB;
        private System.Windows.Forms.Label lblAnguloC;
        private System.Windows.Forms.TextBox txtAnguloA;
        private System.Windows.Forms.TextBox txtAnguloB;
        private System.Windows.Forms.TextBox txtAnguloC;
    }
}

