
namespace Projeto_Sistema.Apresentacao
{
    partial class Cadastro
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
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_Email_Cadastro = new System.Windows.Forms.Label();
            this.Lbl_SENHA_Cadastro = new System.Windows.Forms.Label();
            this.Txt_NOME_Cadastro = new System.Windows.Forms.TextBox();
            this.Txt_SENHA_Cadastro = new System.Windows.Forms.TextBox();
            this.Txt_EMAIL_Cadastro = new System.Windows.Forms.TextBox();
            this.Btn_CONCLUIR_Cadastro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Location = new System.Drawing.Point(170, 29);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(52, 20);
            this.Lbl_Nome.TabIndex = 0;
            this.Lbl_Nome.Text = "NOME";
            // 
            // Lbl_Email_Cadastro
            // 
            this.Lbl_Email_Cadastro.AutoSize = true;
            this.Lbl_Email_Cadastro.Location = new System.Drawing.Point(171, 131);
            this.Lbl_Email_Cadastro.Name = "Lbl_Email_Cadastro";
            this.Lbl_Email_Cadastro.Size = new System.Drawing.Size(51, 20);
            this.Lbl_Email_Cadastro.TabIndex = 1;
            this.Lbl_Email_Cadastro.Text = "EMAIL";
            // 
            // Lbl_SENHA_Cadastro
            // 
            this.Lbl_SENHA_Cadastro.AutoSize = true;
            this.Lbl_SENHA_Cadastro.Location = new System.Drawing.Point(165, 230);
            this.Lbl_SENHA_Cadastro.Name = "Lbl_SENHA_Cadastro";
            this.Lbl_SENHA_Cadastro.Size = new System.Drawing.Size(57, 20);
            this.Lbl_SENHA_Cadastro.TabIndex = 2;
            this.Lbl_SENHA_Cadastro.Text = "SENHA";
            this.Lbl_SENHA_Cadastro.Click += new System.EventHandler(this.label3_Click);
            // 
            // Txt_NOME_Cadastro
            // 
            this.Txt_NOME_Cadastro.Location = new System.Drawing.Point(44, 71);
            this.Txt_NOME_Cadastro.Name = "Txt_NOME_Cadastro";
            this.Txt_NOME_Cadastro.Size = new System.Drawing.Size(301, 27);
            this.Txt_NOME_Cadastro.TabIndex = 3;
            this.Txt_NOME_Cadastro.TextChanged += new System.EventHandler(this.Txt_NOME_Cadastro_TextChanged);
            // 
            // Txt_SENHA_Cadastro
            // 
            this.Txt_SENHA_Cadastro.Location = new System.Drawing.Point(44, 275);
            this.Txt_SENHA_Cadastro.Name = "Txt_SENHA_Cadastro";
            this.Txt_SENHA_Cadastro.Size = new System.Drawing.Size(301, 27);
            this.Txt_SENHA_Cadastro.TabIndex = 4;
            // 
            // Txt_EMAIL_Cadastro
            // 
            this.Txt_EMAIL_Cadastro.Location = new System.Drawing.Point(44, 174);
            this.Txt_EMAIL_Cadastro.Name = "Txt_EMAIL_Cadastro";
            this.Txt_EMAIL_Cadastro.Size = new System.Drawing.Size(301, 27);
            this.Txt_EMAIL_Cadastro.TabIndex = 4;
            // 
            // Btn_CONCLUIR_Cadastro
            // 
            this.Btn_CONCLUIR_Cadastro.Location = new System.Drawing.Point(60, 355);
            this.Btn_CONCLUIR_Cadastro.Name = "Btn_CONCLUIR_Cadastro";
            this.Btn_CONCLUIR_Cadastro.Size = new System.Drawing.Size(94, 29);
            this.Btn_CONCLUIR_Cadastro.TabIndex = 5;
            this.Btn_CONCLUIR_Cadastro.Text = "CONCLUIR";
            this.Btn_CONCLUIR_Cadastro.UseVisualStyleBackColor = true;
            this.Btn_CONCLUIR_Cadastro.Click += new System.EventHandler(this.Btn_CONCLUIR_Cadastro_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(388, 416);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_CONCLUIR_Cadastro);
            this.Controls.Add(this.Txt_EMAIL_Cadastro);
            this.Controls.Add(this.Txt_SENHA_Cadastro);
            this.Controls.Add(this.Txt_NOME_Cadastro);
            this.Controls.Add(this.Lbl_SENHA_Cadastro);
            this.Controls.Add(this.Lbl_Email_Cadastro);
            this.Controls.Add(this.Lbl_Nome);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_Email_Cadastro;
        private System.Windows.Forms.Label Lbl_SENHA_Cadastro;
        private System.Windows.Forms.TextBox Txt_NOME_Cadastro;
        private System.Windows.Forms.TextBox Txt_SENHA_Cadastro;
        private System.Windows.Forms.TextBox Txt_EMAIL_Cadastro;
        private System.Windows.Forms.Button Btn_CONCLUIR_Cadastro;
        private System.Windows.Forms.Button button2;
    }
}