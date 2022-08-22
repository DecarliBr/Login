
namespace Login
{
    partial class FRM_Principal
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
            this.LBL_Principal = new System.Windows.Forms.Label();
            this.LBL_UsuarioPrincipal = new System.Windows.Forms.Label();
            this.LBL_SenhaPrincipal = new System.Windows.Forms.Label();
            this.TXT_UsuarioPrincipal = new System.Windows.Forms.TextBox();
            this.TXT_SenhaPrincipal = new System.Windows.Forms.TextBox();
            this.BTN_EntrarPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Principal
            // 
            this.LBL_Principal.AutoSize = true;
            this.LBL_Principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Principal.Location = new System.Drawing.Point(145, 9);
            this.LBL_Principal.Name = "LBL_Principal";
            this.LBL_Principal.Size = new System.Drawing.Size(86, 33);
            this.LBL_Principal.TabIndex = 0;
            this.LBL_Principal.Text = "Login";
            // 
            // LBL_UsuarioPrincipal
            // 
            this.LBL_UsuarioPrincipal.AutoSize = true;
            this.LBL_UsuarioPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UsuarioPrincipal.Location = new System.Drawing.Point(13, 103);
            this.LBL_UsuarioPrincipal.Name = "LBL_UsuarioPrincipal";
            this.LBL_UsuarioPrincipal.Size = new System.Drawing.Size(74, 24);
            this.LBL_UsuarioPrincipal.TabIndex = 1;
            this.LBL_UsuarioPrincipal.Text = "Usuario";
            // 
            // LBL_SenhaPrincipal
            // 
            this.LBL_SenhaPrincipal.AutoSize = true;
            this.LBL_SenhaPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LBL_SenhaPrincipal.Location = new System.Drawing.Point(22, 165);
            this.LBL_SenhaPrincipal.Name = "LBL_SenhaPrincipal";
            this.LBL_SenhaPrincipal.Size = new System.Drawing.Size(65, 24);
            this.LBL_SenhaPrincipal.TabIndex = 2;
            this.LBL_SenhaPrincipal.Text = "Senha";
            // 
            // TXT_UsuarioPrincipal
            // 
            this.TXT_UsuarioPrincipal.Location = new System.Drawing.Point(93, 107);
            this.TXT_UsuarioPrincipal.Name = "TXT_UsuarioPrincipal";
            this.TXT_UsuarioPrincipal.Size = new System.Drawing.Size(257, 20);
            this.TXT_UsuarioPrincipal.TabIndex = 3;
            // 
            // TXT_SenhaPrincipal
            // 
            this.TXT_SenhaPrincipal.Location = new System.Drawing.Point(93, 169);
            this.TXT_SenhaPrincipal.Name = "TXT_SenhaPrincipal";
            this.TXT_SenhaPrincipal.Size = new System.Drawing.Size(257, 20);
            this.TXT_SenhaPrincipal.TabIndex = 4;
            // 
            // BTN_EntrarPrincipal
            // 
            this.BTN_EntrarPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BTN_EntrarPrincipal.Location = new System.Drawing.Point(280, 211);
            this.BTN_EntrarPrincipal.Name = "BTN_EntrarPrincipal";
            this.BTN_EntrarPrincipal.Size = new System.Drawing.Size(70, 34);
            this.BTN_EntrarPrincipal.TabIndex = 5;
            this.BTN_EntrarPrincipal.Text = "Entrar";
            this.BTN_EntrarPrincipal.UseVisualStyleBackColor = true;
            this.BTN_EntrarPrincipal.Click += new System.EventHandler(this.BTN_EntrarPrincipal_Click);
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 280);
            this.Controls.Add(this.BTN_EntrarPrincipal);
            this.Controls.Add(this.TXT_SenhaPrincipal);
            this.Controls.Add(this.TXT_UsuarioPrincipal);
            this.Controls.Add(this.LBL_SenhaPrincipal);
            this.Controls.Add(this.LBL_UsuarioPrincipal);
            this.Controls.Add(this.LBL_Principal);
            this.Name = "FRM_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Principal;
        private System.Windows.Forms.Label LBL_UsuarioPrincipal;
        private System.Windows.Forms.Label LBL_SenhaPrincipal;
        private System.Windows.Forms.TextBox TXT_UsuarioPrincipal;
        private System.Windows.Forms.TextBox TXT_SenhaPrincipal;
        private System.Windows.Forms.Button BTN_EntrarPrincipal;
    }
}

