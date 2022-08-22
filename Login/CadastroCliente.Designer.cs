
namespace Login
{
    partial class FRM_CadastroCliente
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
            this.LBL_NomeCadastro = new System.Windows.Forms.Label();
            this.LBL_SenhaCadastro = new System.Windows.Forms.Label();
            this.LBL_TituloCadastro = new System.Windows.Forms.Label();
            this.TXT_NomeCadastro = new System.Windows.Forms.TextBox();
            this.TXT_SenhaCadastro = new System.Windows.Forms.TextBox();
            this.BTN_CadastrarCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_NomeCadastro
            // 
            this.LBL_NomeCadastro.AutoSize = true;
            this.LBL_NomeCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LBL_NomeCadastro.Location = new System.Drawing.Point(51, 77);
            this.LBL_NomeCadastro.Name = "LBL_NomeCadastro";
            this.LBL_NomeCadastro.Size = new System.Drawing.Size(62, 24);
            this.LBL_NomeCadastro.TabIndex = 0;
            this.LBL_NomeCadastro.Text = "Nome";
            // 
            // LBL_SenhaCadastro
            // 
            this.LBL_SenhaCadastro.AutoSize = true;
            this.LBL_SenhaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LBL_SenhaCadastro.Location = new System.Drawing.Point(48, 139);
            this.LBL_SenhaCadastro.Name = "LBL_SenhaCadastro";
            this.LBL_SenhaCadastro.Size = new System.Drawing.Size(65, 24);
            this.LBL_SenhaCadastro.TabIndex = 1;
            this.LBL_SenhaCadastro.Text = "Senha";
            // 
            // LBL_TituloCadastro
            // 
            this.LBL_TituloCadastro.AutoSize = true;
            this.LBL_TituloCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.LBL_TituloCadastro.Location = new System.Drawing.Point(173, 9);
            this.LBL_TituloCadastro.Name = "LBL_TituloCadastro";
            this.LBL_TituloCadastro.Size = new System.Drawing.Size(100, 26);
            this.LBL_TituloCadastro.TabIndex = 2;
            this.LBL_TituloCadastro.Text = "Cadastro";
            // 
            // TXT_NomeCadastro
            // 
            this.TXT_NomeCadastro.Location = new System.Drawing.Point(119, 81);
            this.TXT_NomeCadastro.Name = "TXT_NomeCadastro";
            this.TXT_NomeCadastro.Size = new System.Drawing.Size(260, 20);
            this.TXT_NomeCadastro.TabIndex = 3;
            // 
            // TXT_SenhaCadastro
            // 
            this.TXT_SenhaCadastro.Location = new System.Drawing.Point(119, 143);
            this.TXT_SenhaCadastro.Name = "TXT_SenhaCadastro";
            this.TXT_SenhaCadastro.Size = new System.Drawing.Size(260, 20);
            this.TXT_SenhaCadastro.TabIndex = 4;
            // 
            // BTN_CadastrarCadastro
            // 
            this.BTN_CadastrarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BTN_CadastrarCadastro.Location = new System.Drawing.Point(278, 189);
            this.BTN_CadastrarCadastro.Name = "BTN_CadastrarCadastro";
            this.BTN_CadastrarCadastro.Size = new System.Drawing.Size(101, 38);
            this.BTN_CadastrarCadastro.TabIndex = 5;
            this.BTN_CadastrarCadastro.Text = "Cadastrar";
            this.BTN_CadastrarCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTN_CadastrarCadastro.UseVisualStyleBackColor = true;
            this.BTN_CadastrarCadastro.Click += new System.EventHandler(this.BTN_CadastrarCadastro_Click);
            // 
            // FRM_CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 264);
            this.Controls.Add(this.BTN_CadastrarCadastro);
            this.Controls.Add(this.TXT_SenhaCadastro);
            this.Controls.Add(this.TXT_NomeCadastro);
            this.Controls.Add(this.LBL_TituloCadastro);
            this.Controls.Add(this.LBL_SenhaCadastro);
            this.Controls.Add(this.LBL_NomeCadastro);
            this.Name = "FRM_CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_NomeCadastro;
        private System.Windows.Forms.Label LBL_SenhaCadastro;
        private System.Windows.Forms.Label LBL_TituloCadastro;
        private System.Windows.Forms.TextBox TXT_NomeCadastro;
        private System.Windows.Forms.TextBox TXT_SenhaCadastro;
        private System.Windows.Forms.Button BTN_CadastrarCadastro;
    }
}