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
            this.lbNome = new System.Windows.Forms.Label();
            this.TabCtrl = new System.Windows.Forms.TabControl();
            this.TabPgLogin = new System.Windows.Forms.TabPage();
            this.LblEsqueci = new System.Windows.Forms.Label();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtLogPassword = new System.Windows.Forms.TextBox();
            this.TxtLogEmail = new System.Windows.Forms.TextBox();
            this.TabPgCadastro = new System.Windows.Forms.TabPage();
            this.lblPWError = new System.Windows.Forms.Label();
            this.TxtCadEmail = new System.Windows.Forms.TextBox();
            this.TxtCadConfPass = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.TxtCadPassword = new System.Windows.Forms.TextBox();
            this.TxtCadUsername = new System.Windows.Forms.TextBox();
            this.plName.SuspendLayout();
            this.TabCtrl.SuspendLayout();
            this.TabPgLogin.SuspendLayout();
            this.TabPgCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // plName
            // 
            this.plName.BackColor = System.Drawing.SystemColors.Highlight;
            this.plName.Controls.Add(this.lbNome);
            this.plName.Dock = System.Windows.Forms.DockStyle.Top;
            this.plName.Location = new System.Drawing.Point(0, 0);
            this.plName.Name = "plName";
            this.plName.Size = new System.Drawing.Size(352, 59);
            this.plName.TabIndex = 3;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(107, 9);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(162, 42);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Musicologia";
            // 
            // TabCtrl
            // 
            this.TabCtrl.Controls.Add(this.TabPgLogin);
            this.TabCtrl.Controls.Add(this.TabPgCadastro);
            this.TabCtrl.Location = new System.Drawing.Point(3, 89);
            this.TabCtrl.Name = "TabCtrl";
            this.TabCtrl.SelectedIndex = 0;
            this.TabCtrl.Size = new System.Drawing.Size(340, 318);
            this.TabCtrl.TabIndex = 6;
            // 
            // TabPgLogin
            // 
            this.TabPgLogin.Controls.Add(this.LblEsqueci);
            this.TabPgLogin.Controls.Add(this.LblCadastro);
            this.TabPgLogin.Controls.Add(this.BtnLogin);
            this.TabPgLogin.Controls.Add(this.TxtLogPassword);
            this.TabPgLogin.Controls.Add(this.TxtLogEmail);
            this.TabPgLogin.Location = new System.Drawing.Point(4, 22);
            this.TabPgLogin.Name = "TabPgLogin";
            this.TabPgLogin.Padding = new System.Windows.Forms.Padding(3);
            this.TabPgLogin.Size = new System.Drawing.Size(332, 292);
            this.TabPgLogin.TabIndex = 0;
            this.TabPgLogin.Text = "Login";
            this.TabPgLogin.UseVisualStyleBackColor = true;
            // 
            // LblEsqueci
            // 
            this.LblEsqueci.AutoSize = true;
            this.LblEsqueci.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEsqueci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblEsqueci.Location = new System.Drawing.Point(186, 203);
            this.LblEsqueci.Name = "LblEsqueci";
            this.LblEsqueci.Size = new System.Drawing.Size(110, 12);
            this.LblEsqueci.TabIndex = 10;
            this.LblEsqueci.Text = "Esqueci a senha";
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblCadastro.Location = new System.Drawing.Point(56, 203);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(124, 12);
            this.LblCadastro.TabIndex = 9;
            this.LblCadastro.Text = "Não possui conta?";
            this.LblCadastro.Click += new System.EventHandler(this.LblCadastro_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(58, 163);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(240, 35);
            this.BtnLogin.TabIndex = 8;
            this.BtnLogin.Text = "Entrar";
            this.BtnLogin.UseVisualStyleBackColor = true;
            // 
            // TxtLogPassword
            // 
            this.TxtLogPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLogPassword.Location = new System.Drawing.Point(58, 118);
            this.TxtLogPassword.Name = "TxtLogPassword";
            this.TxtLogPassword.Size = new System.Drawing.Size(238, 26);
            this.TxtLogPassword.TabIndex = 7;
            this.TxtLogPassword.Enter += new System.EventHandler(this.TxtLogPassword_Enter);
            this.TxtLogPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLogPassword_KeyPress);
            this.TxtLogPassword.Leave += new System.EventHandler(this.TxtLogPassword_Leave);
            // 
            // TxtLogEmail
            // 
            this.TxtLogEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLogEmail.Location = new System.Drawing.Point(58, 86);
            this.TxtLogEmail.MaxLength = 50;
            this.TxtLogEmail.Name = "TxtLogEmail";
            this.TxtLogEmail.Size = new System.Drawing.Size(238, 26);
            this.TxtLogEmail.TabIndex = 6;
            this.TxtLogEmail.Enter += new System.EventHandler(this.TxtLogEmail_Enter);
            this.TxtLogEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLogEmail_KeyPress);
            this.TxtLogEmail.Leave += new System.EventHandler(this.TxtLogEmail_Leave);
            // 
            // TabPgCadastro
            // 
            this.TabPgCadastro.Controls.Add(this.lblPWError);
            this.TabPgCadastro.Controls.Add(this.TxtCadEmail);
            this.TabPgCadastro.Controls.Add(this.TxtCadConfPass);
            this.TabPgCadastro.Controls.Add(this.BtnCadastrar);
            this.TabPgCadastro.Controls.Add(this.TxtCadPassword);
            this.TabPgCadastro.Controls.Add(this.TxtCadUsername);
            this.TabPgCadastro.Location = new System.Drawing.Point(4, 22);
            this.TabPgCadastro.Name = "TabPgCadastro";
            this.TabPgCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.TabPgCadastro.Size = new System.Drawing.Size(332, 292);
            this.TabPgCadastro.TabIndex = 1;
            this.TabPgCadastro.Text = "Cadastro";
            this.TabPgCadastro.UseVisualStyleBackColor = true;
            // 
            // lblPWError
            // 
            this.lblPWError.AutoSize = true;
            this.lblPWError.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPWError.Location = new System.Drawing.Point(247, 87);
            this.lblPWError.Name = "lblPWError";
            this.lblPWError.Size = new System.Drawing.Size(54, 36);
            this.lblPWError.TabIndex = 18;
            this.lblPWError.Text = "Senhas \r\n não \r\nbatem!";
            this.lblPWError.Visible = false;
            // 
            // TxtCadEmail
            // 
            this.TxtCadEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadEmail.Location = new System.Drawing.Point(25, 65);
            this.TxtCadEmail.MaxLength = 50;
            this.TxtCadEmail.Name = "TxtCadEmail";
            this.TxtCadEmail.Size = new System.Drawing.Size(201, 26);
            this.TxtCadEmail.TabIndex = 17;
            // 
            // TxtCadConfPass
            // 
            this.TxtCadConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadConfPass.Location = new System.Drawing.Point(25, 129);
            this.TxtCadConfPass.Name = "TxtCadConfPass";
            this.TxtCadConfPass.Size = new System.Drawing.Size(201, 26);
            this.TxtCadConfPass.TabIndex = 16;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(25, 166);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(201, 35);
            this.BtnCadastrar.TabIndex = 15;
            this.BtnCadastrar.Text = "Cadastrar e Entrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            // 
            // TxtCadPassword
            // 
            this.TxtCadPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadPassword.Location = new System.Drawing.Point(25, 97);
            this.TxtCadPassword.Name = "TxtCadPassword";
            this.TxtCadPassword.Size = new System.Drawing.Size(201, 26);
            this.TxtCadPassword.TabIndex = 14;
            // 
            // TxtCadUsername
            // 
            this.TxtCadUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadUsername.Location = new System.Drawing.Point(25, 25);
            this.TxtCadUsername.MaxLength = 50;
            this.TxtCadUsername.Name = "TxtCadUsername";
            this.TxtCadUsername.Size = new System.Drawing.Size(201, 26);
            this.TxtCadUsername.TabIndex = 13;
            this.TxtCadUsername.Enter += new System.EventHandler(this.TxtCadUsername_Enter);
            this.TxtCadUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCadUsername_KeyPress);
            this.TxtCadUsername.Leave += new System.EventHandler(this.TxtCadUsername_Leave);
            // 
            // FrmMain
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(352, 420);
            this.Controls.Add(this.TabCtrl);
            this.Controls.Add(this.plName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicApp";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.plName.ResumeLayout(false);
            this.plName.PerformLayout();
            this.TabCtrl.ResumeLayout(false);
            this.TabPgLogin.ResumeLayout(false);
            this.TabPgLogin.PerformLayout();
            this.TabPgCadastro.ResumeLayout(false);
            this.TabPgCadastro.PerformLayout();
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
        private System.Windows.Forms.TabControl TabCtrl;
        private System.Windows.Forms.TabPage TabPgLogin;
        private System.Windows.Forms.Label LblEsqueci;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtLogPassword;
        private System.Windows.Forms.TextBox TxtLogEmail;
        private System.Windows.Forms.TabPage TabPgCadastro;
        private System.Windows.Forms.Label lblPWError;
        private System.Windows.Forms.TextBox TxtCadEmail;
        private System.Windows.Forms.TextBox TxtCadConfPass;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.TextBox TxtCadPassword;
        private System.Windows.Forms.TextBox TxtCadUsername;
    }
}

