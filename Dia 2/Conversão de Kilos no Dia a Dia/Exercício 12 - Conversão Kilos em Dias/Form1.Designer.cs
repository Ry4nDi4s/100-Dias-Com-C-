namespace Exercício_12___Conversão_Kilos_em_Dias
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
            this.btnGrande = new System.Windows.Forms.Button();
            this.txtconsumo = new System.Windows.Forms.TextBox();
            this.btnmedia = new System.Windows.Forms.Button();
            this.btnpequena = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGrande
            // 
            this.btnGrande.BackColor = System.Drawing.Color.Green;
            this.btnGrande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnGrande.Location = new System.Drawing.Point(12, 119);
            this.btnGrande.Name = "btnGrande";
            this.btnGrande.Size = new System.Drawing.Size(241, 50);
            this.btnGrande.TabIndex = 0;
            this.btnGrande.Text = "Marmita Grande";
            this.btnGrande.UseVisualStyleBackColor = false;
            this.btnGrande.Click += new System.EventHandler(this.btnGrande_Click);
            // 
            // txtconsumo
            // 
            this.txtconsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.txtconsumo.Location = new System.Drawing.Point(290, 328);
            this.txtconsumo.Multiline = true;
            this.txtconsumo.Name = "txtconsumo";
            this.txtconsumo.Size = new System.Drawing.Size(217, 48);
            this.txtconsumo.TabIndex = 1;
            // 
            // btnmedia
            // 
            this.btnmedia.BackColor = System.Drawing.Color.Green;
            this.btnmedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnmedia.Location = new System.Drawing.Point(277, 119);
            this.btnmedia.Name = "btnmedia";
            this.btnmedia.Size = new System.Drawing.Size(230, 50);
            this.btnmedia.TabIndex = 2;
            this.btnmedia.Text = "Marmita Média";
            this.btnmedia.UseVisualStyleBackColor = false;
            this.btnmedia.Click += new System.EventHandler(this.btnmedia_Click);
            // 
            // btnpequena
            // 
            this.btnpequena.BackColor = System.Drawing.Color.Green;
            this.btnpequena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpequena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnpequena.Location = new System.Drawing.Point(531, 119);
            this.btnpequena.Name = "btnpequena";
            this.btnpequena.Size = new System.Drawing.Size(257, 50);
            this.btnpequena.TabIndex = 3;
            this.btnpequena.Text = "Marmita Pequena";
            this.btnpequena.UseVisualStyleBackColor = false;
            this.btnpequena.Click += new System.EventHandler(this.btnpequena_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label1.Location = new System.Drawing.Point(108, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantas gramas você consome no almoço e janta?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label2.Location = new System.Drawing.Point(633, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "500g";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label3.Location = new System.Drawing.Point(360, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "750g";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label4.Location = new System.Drawing.Point(90, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "1,1Kg";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpequena);
            this.Controls.Add(this.btnmedia);
            this.Controls.Add(this.txtconsumo);
            this.Controls.Add(this.btnGrande);
            this.Name = "Form1";
            this.Text = "Exercício 12 - Conversão Kilos em Dias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrande;
        private System.Windows.Forms.TextBox txtconsumo;
        private System.Windows.Forms.Button btnmedia;
        private System.Windows.Forms.Button btnpequena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

