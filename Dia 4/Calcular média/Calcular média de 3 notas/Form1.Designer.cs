namespace Calcular_média_de_3_notas
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
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum3 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.txtnum1.Location = new System.Drawing.Point(172, 140);
            this.txtnum1.Multiline = true;
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(110, 36);
            this.txtnum1.TabIndex = 0;
            this.txtnum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnum2
            // 
            this.txtnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.txtnum2.Location = new System.Drawing.Point(333, 140);
            this.txtnum2.Multiline = true;
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(110, 36);
            this.txtnum2.TabIndex = 1;
            this.txtnum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnum3
            // 
            this.txtnum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.txtnum3.Location = new System.Drawing.Point(489, 140);
            this.txtnum3.Multiline = true;
            this.txtnum3.Name = "txtnum3";
            this.txtnum3.Size = new System.Drawing.Size(110, 36);
            this.txtnum3.TabIndex = 2;
            this.txtnum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Lime;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.btnOK.Location = new System.Drawing.Point(333, 298);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(110, 47);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Calcular";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtnum3);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Name = "Form1";
            this.Text = "Calcular média de 3 notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum3;
        private System.Windows.Forms.Button btnOK;
    }
}

