
namespace PIMIII
{
    partial class CadastrarHotel
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
            System.Windows.Forms.Label cpf_gerenteLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.mtxtUf = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtRua = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCidade = new System.Windows.Forms.MaskedTextBox();
            this.mtxtBairro = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.bntEnviar = new System.Windows.Forms.Button();
            cpf_gerenteLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cpf_gerenteLabel
            // 
            cpf_gerenteLabel.AutoSize = true;
            cpf_gerenteLabel.Location = new System.Drawing.Point(54, 69);
            cpf_gerenteLabel.Name = "cpf_gerenteLabel";
            cpf_gerenteLabel.Size = new System.Drawing.Size(64, 13);
            cpf_gerenteLabel.TabIndex = 39;
            cpf_gerenteLabel.Text = "cpf gerente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(54, 95);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 13);
            label1.TabIndex = 40;
            label1.Text = "hotel bairro:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(54, 121);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(68, 13);
            label3.TabIndex = 41;
            label3.Text = "hotel cidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(54, 152);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(71, 13);
            label4.TabIndex = 42;
            label4.Text = "hotel numero:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(54, 178);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 13);
            label5.TabIndex = 43;
            label5.Text = "hotel rua:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(54, 204);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(74, 13);
            label6.TabIndex = 44;
            label6.Text = "hotel telefone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(54, 230);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(45, 13);
            label7.TabIndex = 45;
            label7.Text = "hotel uf:";
            // 
            // mtxtUf
            // 
            this.mtxtUf.Location = new System.Drawing.Point(137, 223);
            this.mtxtUf.Mask = "LL";
            this.mtxtUf.Name = "mtxtUf";
            this.mtxtUf.Size = new System.Drawing.Size(19, 20);
            this.mtxtUf.TabIndex = 52;
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(137, 197);
            this.mtxtTelefone.Mask = "(00) 00000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(88, 20);
            this.mtxtTelefone.TabIndex = 51;
            this.mtxtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtxtRua
            // 
            this.mtxtRua.Location = new System.Drawing.Point(137, 171);
            this.mtxtRua.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtRua.Name = "mtxtRua";
            this.mtxtRua.Size = new System.Drawing.Size(249, 20);
            this.mtxtRua.TabIndex = 50;
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.Location = new System.Drawing.Point(137, 145);
            this.mtxtNumero.Mask = "CCCC";
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(32, 20);
            this.mtxtNumero.TabIndex = 49;
            // 
            // mtxtCidade
            // 
            this.mtxtCidade.Location = new System.Drawing.Point(137, 114);
            this.mtxtCidade.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtCidade.Name = "mtxtCidade";
            this.mtxtCidade.Size = new System.Drawing.Size(249, 20);
            this.mtxtCidade.TabIndex = 48;
            // 
            // mtxtBairro
            // 
            this.mtxtBairro.Location = new System.Drawing.Point(137, 88);
            this.mtxtBairro.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtBairro.Name = "mtxtBairro";
            this.mtxtBairro.Size = new System.Drawing.Size(249, 20);
            this.mtxtBairro.TabIndex = 47;
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtCpf.Location = new System.Drawing.Point(137, 62);
            this.mtxtCpf.Mask = "000,000,000-00";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(88, 20);
            this.mtxtCpf.TabIndex = 46;
            this.mtxtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // bntEnviar
            // 
            this.bntEnviar.Location = new System.Drawing.Point(335, 292);
            this.bntEnviar.Name = "bntEnviar";
            this.bntEnviar.Size = new System.Drawing.Size(82, 55);
            this.bntEnviar.TabIndex = 38;
            this.bntEnviar.Text = "Enviar";
            this.bntEnviar.UseVisualStyleBackColor = true;
            this.bntEnviar.Click += new System.EventHandler(this.bntEnviar_Click);
            // 
            // CadastrarHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtxtUf);
            this.Controls.Add(this.mtxtTelefone);
            this.Controls.Add(this.mtxtRua);
            this.Controls.Add(this.mtxtNumero);
            this.Controls.Add(this.mtxtCidade);
            this.Controls.Add(this.mtxtBairro);
            this.Controls.Add(this.mtxtCpf);
            this.Controls.Add(cpf_gerenteLabel);
            this.Controls.Add(label1);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(label6);
            this.Controls.Add(label7);
            this.Controls.Add(this.bntEnviar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarHotel";
            this.Text = "CadastrarHotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtUf;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.MaskedTextBox mtxtRua;
        private System.Windows.Forms.MaskedTextBox mtxtNumero;
        private System.Windows.Forms.MaskedTextBox mtxtCidade;
        private System.Windows.Forms.MaskedTextBox mtxtBairro;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
        private System.Windows.Forms.Button bntEnviar;
    }
}