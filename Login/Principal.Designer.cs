
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Principal));
            this.LBL_Principal = new System.Windows.Forms.Label();
            this.TXT_UsuarioPrincipal = new System.Windows.Forms.TextBox();
            this.TXT_SenhaPrincipal = new System.Windows.Forms.TextBox();
            this.BTN_EntrarPrincipal = new System.Windows.Forms.Button();
            this.BTN_CadastrarPrincipal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BTN_PrincipalX = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Principal
            // 
            this.LBL_Principal.AutoSize = true;
            this.LBL_Principal.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Principal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBL_Principal.Location = new System.Drawing.Point(462, 48);
            this.LBL_Principal.Name = "LBL_Principal";
            this.LBL_Principal.Size = new System.Drawing.Size(102, 39);
            this.LBL_Principal.TabIndex = 0;
            this.LBL_Principal.Text = "Login";
            // 
            // TXT_UsuarioPrincipal
            // 
            this.TXT_UsuarioPrincipal.Location = new System.Drawing.Point(427, 135);
            this.TXT_UsuarioPrincipal.Name = "TXT_UsuarioPrincipal";
            this.TXT_UsuarioPrincipal.Size = new System.Drawing.Size(234, 20);
            this.TXT_UsuarioPrincipal.TabIndex = 3;
            // 
            // TXT_SenhaPrincipal
            // 
            this.TXT_SenhaPrincipal.Location = new System.Drawing.Point(427, 197);
            this.TXT_SenhaPrincipal.Name = "TXT_SenhaPrincipal";
            this.TXT_SenhaPrincipal.Size = new System.Drawing.Size(234, 20);
            this.TXT_SenhaPrincipal.TabIndex = 4;
            this.TXT_SenhaPrincipal.UseSystemPasswordChar = true;
            this.TXT_SenhaPrincipal.TextChanged += new System.EventHandler(this.TXT_SenhaPrincipal_TextChanged);
            // 
            // BTN_EntrarPrincipal
            // 
            this.BTN_EntrarPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EntrarPrincipal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EntrarPrincipal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTN_EntrarPrincipal.Location = new System.Drawing.Point(591, 304);
            this.BTN_EntrarPrincipal.Name = "BTN_EntrarPrincipal";
            this.BTN_EntrarPrincipal.Size = new System.Drawing.Size(79, 34);
            this.BTN_EntrarPrincipal.TabIndex = 5;
            this.BTN_EntrarPrincipal.Text = "Entrar";
            this.BTN_EntrarPrincipal.UseVisualStyleBackColor = true;
            this.BTN_EntrarPrincipal.Click += new System.EventHandler(this.BTN_EntrarPrincipal_Click);
            // 
            // BTN_CadastrarPrincipal
            // 
            this.BTN_CadastrarPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CadastrarPrincipal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CadastrarPrincipal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTN_CadastrarPrincipal.Location = new System.Drawing.Point(391, 304);
            this.BTN_CadastrarPrincipal.Name = "BTN_CadastrarPrincipal";
            this.BTN_CadastrarPrincipal.Size = new System.Drawing.Size(115, 34);
            this.BTN_CadastrarPrincipal.TabIndex = 6;
            this.BTN_CadastrarPrincipal.Text = "Cadastrar";
            this.BTN_CadastrarPrincipal.UseVisualStyleBackColor = true;
            this.BTN_CadastrarPrincipal.UseWaitCursor = true;
            this.BTN_CadastrarPrincipal.Click += new System.EventHandler(this.BTN_CadastrarPrincipal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 394);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(391, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 31);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(390, 188);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // BTN_PrincipalX
            // 
            this.BTN_PrincipalX.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_PrincipalX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PrincipalX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BTN_PrincipalX.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTN_PrincipalX.Location = new System.Drawing.Point(665, 0);
            this.BTN_PrincipalX.Name = "BTN_PrincipalX";
            this.BTN_PrincipalX.Size = new System.Drawing.Size(34, 32);
            this.BTN_PrincipalX.TabIndex = 10;
            this.BTN_PrincipalX.Text = "X";
            this.BTN_PrincipalX.UseVisualStyleBackColor = false;
            this.BTN_PrincipalX.Click += new System.EventHandler(this.BTN_PrincipalX_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(335, 293);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(169, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Desenvolvido por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(169, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Henrique Decarli Tavares";
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 392);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BTN_PrincipalX);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_CadastrarPrincipal);
            this.Controls.Add(this.BTN_EntrarPrincipal);
            this.Controls.Add(this.TXT_SenhaPrincipal);
            this.Controls.Add(this.TXT_UsuarioPrincipal);
            this.Controls.Add(this.LBL_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Login";
            this.Load += new System.EventHandler(this.FRM_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Principal;
        private System.Windows.Forms.TextBox TXT_UsuarioPrincipal;
        private System.Windows.Forms.TextBox TXT_SenhaPrincipal;
        private System.Windows.Forms.Button BTN_EntrarPrincipal;
        private System.Windows.Forms.Button BTN_CadastrarPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BTN_PrincipalX;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

