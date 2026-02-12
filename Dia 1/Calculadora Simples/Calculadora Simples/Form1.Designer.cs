namespace Calculadora_Simples
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
            this.btnMais = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDivi = new System.Windows.Forms.Button();
            this.lblSimbolos = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.8F);
            this.btnMais.Location = new System.Drawing.Point(99, 274);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(119, 51);
            this.btnMais.TabIndex = 0;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.BtnMais_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtnum1.Location = new System.Drawing.Point(151, 106);
            this.txtnum1.Multiline = true;
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(107, 44);
            this.txtnum1.TabIndex = 1;
            this.txtnum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnum2
            // 
            this.txtnum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txtnum2.Location = new System.Drawing.Point(337, 106);
            this.txtnum2.Multiline = true;
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(107, 44);
            this.txtnum2.TabIndex = 2;
            this.txtnum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.8F);
            this.btnMenos.Location = new System.Drawing.Point(241, 274);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(119, 51);
            this.btnMenos.TabIndex = 3;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click_1);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.8F);
            this.btnMulti.Location = new System.Drawing.Point(391, 274);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(119, 51);
            this.btnMulti.TabIndex = 4;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDivi
            // 
            this.btnDivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.8F);
            this.btnDivi.Location = new System.Drawing.Point(533, 274);
            this.btnDivi.Name = "btnDivi";
            this.btnDivi.Size = new System.Drawing.Size(119, 51);
            this.btnDivi.TabIndex = 5;
            this.btnDivi.Text = "/";
            this.btnDivi.UseVisualStyleBackColor = true;
            this.btnDivi.Click += new System.EventHandler(this.btnDivi_Click);
            // 
            // lblSimbolos
            // 
            this.lblSimbolos.AutoSize = true;
            this.lblSimbolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.lblSimbolos.Location = new System.Drawing.Point(291, 115);
            this.lblSimbolos.Name = "lblSimbolos";
            this.lblSimbolos.Size = new System.Drawing.Size(0, 26);
            this.lblSimbolos.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Firebrick;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.btnOK.Location = new System.Drawing.Point(311, 358);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 51);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "CLEAR";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label2.Location = new System.Drawing.Point(461, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "=";
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.lblResultados.Location = new System.Drawing.Point(528, 114);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(27, 29);
            this.lblResultados.TabIndex = 9;
            this.lblResultados.Text = "?";
            this.lblResultados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSimbolos);
            this.Controls.Add(this.btnDivi);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.btnMais);
            this.Name = "Form1";
            this.Text = "Calculadora Simples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDivi;
        private System.Windows.Forms.Label lblSimbolos;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultados;
    }
}

