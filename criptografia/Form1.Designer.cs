namespace criptografia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.btn_criptografar = new System.Windows.Forms.Button();
            this.btn_descriptografar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key/Token";
            // 
            // txt_Input
            // 
            this.txt_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Input.Location = new System.Drawing.Point(168, 35);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(250, 26);
            this.txt_Input.TabIndex = 2;
            // 
            // txt_Key
            // 
            this.txt_Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Key.Location = new System.Drawing.Point(168, 96);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(250, 26);
            this.txt_Key.TabIndex = 3;
            // 
            // txt_Output
            // 
            this.txt_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Output.Location = new System.Drawing.Point(44, 161);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(374, 31);
            this.txt_Output.TabIndex = 4;
            // 
            // btn_criptografar
            // 
            this.btn_criptografar.Location = new System.Drawing.Point(44, 211);
            this.btn_criptografar.Name = "btn_criptografar";
            this.btn_criptografar.Size = new System.Drawing.Size(147, 44);
            this.btn_criptografar.TabIndex = 5;
            this.btn_criptografar.Text = "CRIPTOGRAFAR";
            this.btn_criptografar.UseVisualStyleBackColor = true;
            this.btn_criptografar.Click += new System.EventHandler(this.btn_criptografar_Click);
            // 
            // btn_descriptografar
            // 
            this.btn_descriptografar.Location = new System.Drawing.Point(271, 211);
            this.btn_descriptografar.Name = "btn_descriptografar";
            this.btn_descriptografar.Size = new System.Drawing.Size(147, 44);
            this.btn_descriptografar.TabIndex = 6;
            this.btn_descriptografar.Text = "DESCRIPTOGRAFAR";
            this.btn_descriptografar.UseVisualStyleBackColor = true;
            this.btn_descriptografar.Click += new System.EventHandler(this.btn_descriptografar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 267);
            this.Controls.Add(this.btn_descriptografar);
            this.Controls.Add(this.btn_criptografar);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.txt_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.Button btn_criptografar;
        private System.Windows.Forms.Button btn_descriptografar;
    }
}

