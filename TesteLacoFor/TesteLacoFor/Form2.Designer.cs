namespace TesteLacoFor
{
    partial class Form2
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
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.CboAno = new System.Windows.Forms.ComboBox();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.lblTiulo1 = new System.Windows.Forms.Label();
            this.lblTiulo3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(21, 107);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(126, 18);
            this.lblTitulo2.TabIndex = 0;
            this.lblTitulo2.Text = "Selecione o Ano:";
            // 
            // CboAno
            // 
            this.CboAno.FormattingEnabled = true;
            this.CboAno.Location = new System.Drawing.Point(153, 108);
            this.CboAno.Name = "CboAno";
            this.CboAno.Size = new System.Drawing.Size(104, 21);
            this.CboAno.TabIndex = 1;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(84, 167);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(106, 35);
            this.BtnVoltar.TabIndex = 2;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // lblTiulo1
            // 
            this.lblTiulo1.AutoSize = true;
            this.lblTiulo1.BackColor = System.Drawing.Color.Transparent;
            this.lblTiulo1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiulo1.Location = new System.Drawing.Point(52, 21);
            this.lblTiulo1.Name = "lblTiulo1";
            this.lblTiulo1.Size = new System.Drawing.Size(170, 22);
            this.lblTiulo1.TabIndex = 3;
            this.lblTiulo1.Text = "Testando o Laço ";
            // 
            // lblTiulo3
            // 
            this.lblTiulo3.AutoSize = true;
            this.lblTiulo3.BackColor = System.Drawing.Color.Transparent;
            this.lblTiulo3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiulo3.Location = new System.Drawing.Point(108, 52);
            this.lblTiulo3.Name = "lblTiulo3";
            this.lblTiulo3.Size = new System.Drawing.Size(60, 22);
            this.lblTiulo3.TabIndex = 4;
            this.lblTiulo3.Text = "While";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.lblTiulo3);
            this.Controls.Add(this.lblTiulo1);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.CboAno);
            this.Controls.Add(this.lblTitulo2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem vindos ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.ComboBox CboAno;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Label lblTiulo1;
        private System.Windows.Forms.Label lblTiulo3;
    }
}