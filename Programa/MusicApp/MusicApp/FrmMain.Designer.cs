namespace MusicApp
{
    partial class FrmMain
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.plName = new System.Windows.Forms.Panel();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.PlCadastro = new System.Windows.Forms.Panel();
            this.LblLogin = new System.Windows.Forms.Label();
            this.lblPWError = new System.Windows.Forms.Label();
            this.TxtCadEmail = new System.Windows.Forms.TextBox();
            this.TxtCadConfPass = new System.Windows.Forms.TextBox();
            this.TxtCadPassword = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.TxtCadUsername = new System.Windows.Forms.TextBox();
            this.PlLogin = new System.Windows.Forms.Panel();
            this.LblEsqueci = new System.Windows.Forms.Label();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtLogPassword = new System.Windows.Forms.TextBox();
            this.TxtLogEmail = new System.Windows.Forms.TextBox();
            this.LblAvisoLogin = new System.Windows.Forms.Label();
            this.LblAvisoCadastro = new System.Windows.Forms.Label();
            this.plName.SuspendLayout();
            this.PlCadastro.SuspendLayout();
            this.PlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // plName
            // 
            this.plName.BackColor = System.Drawing.SystemColors.Highlight;
            this.plName.Controls.Add(this.BtnMin);
            this.plName.Controls.Add(this.BtnClose);
            this.plName.Controls.Add(this.lbNome);
            this.plName.Dock = System.Windows.Forms.DockStyle.Top;
            this.plName.Location = new System.Drawing.Point(0, 0);
            this.plName.Name = "plName";
            this.plName.Size = new System.Drawing.Size(431, 69);
            this.plName.TabIndex = 3;
            // 
            // BtnMin
            // 
            this.BtnMin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMin.BackgroundImage = global::MusicApp.Properties.Resources.minimize;
            this.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Location = new System.Drawing.Point(372, 0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(24, 24);
            this.BtnMin.TabIndex = 0;
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnClose.BackgroundImage = global::MusicApp.Properties.Resources.close;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnClose.Location = new System.Drawing.Point(402, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(24, 24);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(107, 6);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(219, 57);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Musicologia";
            // 
            // PlCadastro
            // 
            this.PlCadastro.BackColor = System.Drawing.Color.Transparent;
            this.PlCadastro.Controls.Add(this.LblAvisoCadastro);
            this.PlCadastro.Controls.Add(this.LblLogin);
            this.PlCadastro.Controls.Add(this.lblPWError);
            this.PlCadastro.Controls.Add(this.TxtCadEmail);
            this.PlCadastro.Controls.Add(this.TxtCadConfPass);
            this.PlCadastro.Controls.Add(this.TxtCadPassword);
            this.PlCadastro.Controls.Add(this.BtnCadastrar);
            this.PlCadastro.Controls.Add(this.TxtCadUsername);
            this.PlCadastro.Location = new System.Drawing.Point(36, 87);
            this.PlCadastro.Name = "PlCadastro";
            this.PlCadastro.Size = new System.Drawing.Size(360, 291);
            this.PlCadastro.TabIndex = 5;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Underline);
            this.LblLogin.Location = new System.Drawing.Point(112, 227);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(131, 12);
            this.LblLogin.TabIndex = 31;
            this.LblLogin.Text = "Já tenho uma conta";
            this.LblLogin.Click += new System.EventHandler(this.LblLogin_Click);
            // 
            // lblPWError
            // 
            this.lblPWError.AutoSize = true;
            this.lblPWError.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPWError.Location = new System.Drawing.Point(284, 98);
            this.lblPWError.Name = "lblPWError";
            this.lblPWError.Size = new System.Drawing.Size(54, 36);
            this.lblPWError.TabIndex = 30;
            this.lblPWError.Text = "Senhas \r\n não \r\nbatem!";
            this.lblPWError.Visible = false;
            // 
            // TxtCadEmail
            // 
            this.TxtCadEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadEmail.Location = new System.Drawing.Point(77, 76);
            this.TxtCadEmail.MaxLength = 50;
            this.TxtCadEmail.Name = "TxtCadEmail";
            this.TxtCadEmail.Size = new System.Drawing.Size(201, 26);
            this.TxtCadEmail.TabIndex = 29;
            this.TxtCadEmail.Enter += new System.EventHandler(this.TxtCadEmail_Enter);
            this.TxtCadEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCadEmail_KeyPress);
            this.TxtCadEmail.Leave += new System.EventHandler(this.TxtCadEmail_Leave);
            // 
            // TxtCadConfPass
            // 
            this.TxtCadConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadConfPass.Location = new System.Drawing.Point(77, 140);
            this.TxtCadConfPass.Name = "TxtCadConfPass";
            this.TxtCadConfPass.Size = new System.Drawing.Size(201, 26);
            this.TxtCadConfPass.TabIndex = 28;
            this.TxtCadConfPass.Enter += new System.EventHandler(this.TxtCadConfPass_Enter);
            this.TxtCadConfPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCadConfPass_KeyPress);
            this.TxtCadConfPass.Leave += new System.EventHandler(this.TxtCadConfPass_Leave);
            // 
            // TxtCadPassword
            // 
            this.TxtCadPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadPassword.Location = new System.Drawing.Point(77, 108);
            this.TxtCadPassword.Name = "TxtCadPassword";
            this.TxtCadPassword.Size = new System.Drawing.Size(201, 26);
            this.TxtCadPassword.TabIndex = 26;
            this.TxtCadPassword.Enter += new System.EventHandler(this.TxtCadPassword_Enter);
            this.TxtCadPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCadPassword_KeyPress);
            this.TxtCadPassword.Leave += new System.EventHandler(this.TxtCadPassword_Leave);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(77, 177);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(201, 35);
            this.BtnCadastrar.TabIndex = 27;
            this.BtnCadastrar.Text = "Cadastrar e Entrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // TxtCadUsername
            // 
            this.TxtCadUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadUsername.Location = new System.Drawing.Point(77, 44);
            this.TxtCadUsername.MaxLength = 50;
            this.TxtCadUsername.Name = "TxtCadUsername";
            this.TxtCadUsername.Size = new System.Drawing.Size(201, 26);
            this.TxtCadUsername.TabIndex = 25;
            this.TxtCadUsername.Enter += new System.EventHandler(this.TxtCadUsername_Enter);
            this.TxtCadUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCadUsername_KeyPress);
            this.TxtCadUsername.Leave += new System.EventHandler(this.TxtCadUsername_Leave);
            // 
            // PlLogin
            // 
            this.PlLogin.BackColor = System.Drawing.Color.Transparent;
            this.PlLogin.Controls.Add(this.LblAvisoLogin);
            this.PlLogin.Controls.Add(this.LblEsqueci);
            this.PlLogin.Controls.Add(this.LblCadastro);
            this.PlLogin.Controls.Add(this.BtnLogin);
            this.PlLogin.Controls.Add(this.TxtLogPassword);
            this.PlLogin.Controls.Add(this.TxtLogEmail);
            this.PlLogin.Location = new System.Drawing.Point(36, 87);
            this.PlLogin.Name = "PlLogin";
            this.PlLogin.Size = new System.Drawing.Size(360, 291);
            this.PlLogin.TabIndex = 6;
            // 
            // LblEsqueci
            // 
            this.LblEsqueci.AutoSize = true;
            this.LblEsqueci.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEsqueci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblEsqueci.Location = new System.Drawing.Point(191, 198);
            this.LblEsqueci.Name = "LblEsqueci";
            this.LblEsqueci.Size = new System.Drawing.Size(110, 12);
            this.LblEsqueci.TabIndex = 20;
            this.LblEsqueci.Text = "Esqueci a senha";
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblCadastro.Location = new System.Drawing.Point(59, 198);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(124, 12);
            this.LblCadastro.TabIndex = 19;
            this.LblCadastro.Text = "Não possui conta?";
            this.LblCadastro.Click += new System.EventHandler(this.LblCadastro_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(61, 139);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(240, 35);
            this.BtnLogin.TabIndex = 18;
            this.BtnLogin.Text = "Entrar";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtLogPassword
            // 
            this.TxtLogPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLogPassword.Location = new System.Drawing.Point(61, 94);
            this.TxtLogPassword.Name = "TxtLogPassword";
            this.TxtLogPassword.Size = new System.Drawing.Size(238, 26);
            this.TxtLogPassword.TabIndex = 17;
            this.TxtLogPassword.Enter += new System.EventHandler(this.TxtLogPassword_Enter);
            this.TxtLogPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLogPassword_KeyPress);
            this.TxtLogPassword.Leave += new System.EventHandler(this.TxtLogPassword_Leave);
            // 
            // TxtLogEmail
            // 
            this.TxtLogEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLogEmail.Location = new System.Drawing.Point(61, 62);
            this.TxtLogEmail.MaxLength = 50;
            this.TxtLogEmail.Name = "TxtLogEmail";
            this.TxtLogEmail.Size = new System.Drawing.Size(238, 26);
            this.TxtLogEmail.TabIndex = 16;
            this.TxtLogEmail.Enter += new System.EventHandler(this.TxtLogEmail_Enter);
            this.TxtLogEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLogEmail_KeyPress);
            this.TxtLogEmail.Leave += new System.EventHandler(this.TxtLogEmail_Leave);
            // 
            // LblAvisoLogin
            // 
            this.LblAvisoLogin.AutoSize = true;
            this.LblAvisoLogin.Location = new System.Drawing.Point(88, 20);
            this.LblAvisoLogin.Name = "LblAvisoLogin";
            this.LblAvisoLogin.Size = new System.Drawing.Size(33, 13);
            this.LblAvisoLogin.TabIndex = 21;
            this.LblAvisoLogin.Text = "Aviso";
            this.LblAvisoLogin.Visible = false;
            // 
            // LblAvisoCadastro
            // 
            this.LblAvisoCadastro.AutoSize = true;
            this.LblAvisoCadastro.Location = new System.Drawing.Point(153, 16);
            this.LblAvisoCadastro.Name = "LblAvisoCadastro";
            this.LblAvisoCadastro.Size = new System.Drawing.Size(33, 13);
            this.LblAvisoCadastro.TabIndex = 32;
            this.LblAvisoCadastro.Text = "Aviso";
            this.LblAvisoCadastro.Visible = false;
            // 
            // FrmMain
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(431, 394);
            this.Controls.Add(this.PlLogin);
            this.Controls.Add(this.PlCadastro);
            this.Controls.Add(this.plName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.plName.ResumeLayout(false);
            this.plName.PerformLayout();
            this.PlCadastro.ResumeLayout(false);
            this.PlCadastro.PerformLayout();
            this.PlLogin.ResumeLayout(false);
            this.PlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>

        #endregion

        private System.Windows.Forms.Panel plName;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel PlCadastro;
        private System.Windows.Forms.Label lblPWError;
        private System.Windows.Forms.TextBox TxtCadEmail;
        private System.Windows.Forms.TextBox TxtCadConfPass;
        private System.Windows.Forms.TextBox TxtCadPassword;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.TextBox TxtCadUsername;
        private System.Windows.Forms.Panel PlLogin;
        private System.Windows.Forms.Label LblEsqueci;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtLogPassword;
        private System.Windows.Forms.TextBox TxtLogEmail;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblAvisoCadastro;
        private System.Windows.Forms.Label LblAvisoLogin;
    }
}

