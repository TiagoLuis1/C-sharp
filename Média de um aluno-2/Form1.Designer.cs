namespace _16__Média_aluno
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(14, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(82, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do aluno:";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(57, 65);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(39, 13);
            this.lblN1.TabIndex = 1;
            this.lblN1.Text = "Nota 1";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(57, 109);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(39, 13);
            this.lblN2.TabIndex = 2;
            this.lblN2.Text = "Nota 2";
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Location = new System.Drawing.Point(57, 153);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(39, 13);
            this.lblN3.TabIndex = 3;
            this.lblN3.Text = "Nota 3";
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(118, 201);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(100, 23);
            this.btnResultado.TabIndex = 4;
            this.btnResultado.Text = "Calcule a média";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(51, 271);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(36, 13);
            this.lblMedia.TabIndex = 5;
            this.lblMedia.Text = "Media";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(32, 337);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(118, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(118, 58);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 20);
            this.txtN1.TabIndex = 8;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(118, 102);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 20);
            this.txtN2.TabIndex = 9;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(118, 146);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(100, 20);
            this.txtN3.TabIndex = 10;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(118, 264);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 20);
            this.txtMedia.TabIndex = 11;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(118, 330);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

