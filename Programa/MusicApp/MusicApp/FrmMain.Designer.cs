﻿namespace MusicApp
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
            this.LblNome = new System.Windows.Forms.Label();
            this.PlCadastro = new System.Windows.Forms.Panel();
            this.LblPWStrength = new System.Windows.Forms.Label();
            this.LblAvisoCadastro = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblPWErro = new System.Windows.Forms.Label();
            this.TxtCadEmail = new System.Windows.Forms.TextBox();
            this.TxtCadConfPass = new System.Windows.Forms.TextBox();
            this.TxtCadPassword = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.TxtCadUsername = new System.Windows.Forms.TextBox();
            this.PlLogin = new System.Windows.Forms.Panel();
            this.LblAvisoLogin = new System.Windows.Forms.Label();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtLogPassword = new System.Windows.Forms.TextBox();
            this.TxtLogEmail = new System.Windows.Forms.TextBox();
            this.TxtAux = new System.Windows.Forms.TextBox();
            this.plName.SuspendLayout();
            this.PlCadastro.SuspendLayout();
            this.PlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // plName
            // 
            this.plName.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.plName.Controls.Add(this.BtnMin);
            this.plName.Controls.Add(this.BtnClose);
            this.plName.Controls.Add(this.LblNome);
            this.plName.Dock = System.Windows.Forms.DockStyle.Top;
            this.plName.Location = new System.Drawing.Point(0, 0);
            this.plName.Name = "plName";
            this.plName.Size = new System.Drawing.Size(430, 69);
            this.plName.TabIndex = 3;
            // 
            // BtnMin
            // 
            this.BtnMin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMin.BackgroundImage = global::MusicApp.Properties.Resources.minimize;
            this.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Location = new System.Drawing.Point(372, 0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(24, 24);
            this.BtnMin.TabIndex = 0;
            this.BtnMin.TabStop = false;
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnClose.BackgroundImage = global::MusicApp.Properties.Resources.close;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnClose.Location = new System.Drawing.Point(402, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(24, 24);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.TabStop = false;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblNome.Location = new System.Drawing.Point(107, 6);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(219, 57);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Musicologia";
            // 
            // PlCadastro
            // 
            this.PlCadastro.BackColor = System.Drawing.Color.Transparent;
            this.PlCadastro.Controls.Add(this.LblPWStrength);
            this.PlCadastro.Controls.Add(this.LblAvisoCadastro);
            this.PlCadastro.Controls.Add(this.LblLogin);
            this.PlCadastro.Controls.Add(this.LblPWErro);
            this.PlCadastro.Controls.Add(this.TxtCadEmail);
            this.PlCadastro.Controls.Add(this.TxtCadConfPass);
            this.PlCadastro.Controls.Add(this.TxtCadPassword);
            this.PlCadastro.Controls.Add(this.BtnCadastrar);
            this.PlCadastro.Controls.Add(this.TxtCadUsername);
            this.PlCadastro.Location = new System.Drawing.Point(36, 82);
            this.PlCadastro.Name = "PlCadastro";
            this.PlCadastro.Size = new System.Drawing.Size(360, 291);
            this.PlCadastro.TabIndex = 5;
            // 
            // LblPWStrength
            // 
            this.LblPWStrength.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.LblPWStrength.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblPWStrength.Location = new System.Drawing.Point(39, 107);
            this.LblPWStrength.Name = "LblPWStrength";
            this.LblPWStrength.Size = new System.Drawing.Size(279, 16);
            this.LblPWStrength.TabIndex = 33;
            this.LblPWStrength.Text = "Força da senha";
            this.LblPWStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblPWStrength.Visible = false;
            // 
            // LblAvisoCadastro
            // 
            this.LblAvisoCadastro.ForeColor = System.Drawing.Color.Firebrick;
            this.LblAvisoCadastro.Location = new System.Drawing.Point(3, 4);
            this.LblAvisoCadastro.Name = "LblAvisoCadastro";
            this.LblAvisoCadastro.Size = new System.Drawing.Size(354, 24);
            this.LblAvisoCadastro.TabIndex = 32;
            this.LblAvisoCadastro.Text = "Aviso";
            this.LblAvisoCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LblAvisoCadastro.Visible = false;
            // 
            // LblLogin
            // 
            this.LblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblLogin.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Underline);
            this.LblLogin.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblLogin.Location = new System.Drawing.Point(41, 260);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(276, 21);
            this.LblLogin.TabIndex = 31;
            this.LblLogin.Text = "Já tenho uma conta";
            this.LblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblLogin.Click += new System.EventHandler(this.LblLogin_Click);
            // 
            // LblPWErro
            // 
            this.LblPWErro.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPWErro.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblPWErro.Location = new System.Drawing.Point(41, 155);
            this.LblPWErro.Name = "LblPWErro";
            this.LblPWErro.Size = new System.Drawing.Size(277, 12);
            this.LblPWErro.TabIndex = 30;
            this.LblPWErro.Text = "As senhas são diferentes!";
            this.LblPWErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblPWErro.Visible = false;
            // 
            // TxtCadEmail
            // 
            this.TxtCadEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadEmail.Location = new System.Drawing.Point(41, 75);
            this.TxtCadEmail.MaxLength = 50;
            this.TxtCadEmail.Name = "TxtCadEmail";
            this.TxtCadEmail.Size = new System.Drawing.Size(277, 26);
            this.TxtCadEmail.TabIndex = 6;
            this.TxtCadEmail.Enter += new System.EventHandler(this.TxtCadEmail_Enter);
            this.TxtCadEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCadEmail_KeyPress);
            this.TxtCadEmail.Leave += new System.EventHandler(this.TxtCadEmail_Leave);
            // 
            // TxtCadConfPass
            // 
            this.TxtCadConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadConfPass.Location = new System.Drawing.Point(41, 171);
            this.TxtCadConfPass.Name = "TxtCadConfPass";
            this.TxtCadConfPass.Size = new System.Drawing.Size(277, 26);
            this.TxtCadConfPass.TabIndex = 8;
            this.TxtCadConfPass.TextChanged += new System.EventHandler(this.TxtCadConfPass_TextChanged);
            this.TxtCadConfPass.Enter += new System.EventHandler(this.TxtCadConfPass_Enter);
            this.TxtCadConfPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCadConfPass_KeyPress);
            this.TxtCadConfPass.Leave += new System.EventHandler(this.TxtCadConfPass_Leave);
            // 
            // TxtCadPassword
            // 
            this.TxtCadPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadPassword.Location = new System.Drawing.Point(41, 125);
            this.TxtCadPassword.Name = "TxtCadPassword";
            this.TxtCadPassword.Size = new System.Drawing.Size(277, 26);
            this.TxtCadPassword.TabIndex = 7;
            this.TxtCadPassword.TextChanged += new System.EventHandler(this.TxtCadPassword_TextChanged);
            this.TxtCadPassword.Enter += new System.EventHandler(this.TxtCadPassword_Enter);
            this.TxtCadPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCadPassword_KeyPress);
            this.TxtCadPassword.Leave += new System.EventHandler(this.TxtCadPassword_Leave);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastrar.FlatAppearance.BorderSize = 0;
            this.BtnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(124)))), ((int)(((byte)(1)))));
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnCadastrar.Location = new System.Drawing.Point(41, 206);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(276, 46);
            this.BtnCadastrar.TabIndex = 9;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // TxtCadUsername
            // 
            this.TxtCadUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadUsername.Location = new System.Drawing.Point(41, 33);
            this.TxtCadUsername.MaxLength = 50;
            this.TxtCadUsername.Name = "TxtCadUsername";
            this.TxtCadUsername.Size = new System.Drawing.Size(277, 26);
            this.TxtCadUsername.TabIndex = 5;
            this.TxtCadUsername.Enter += new System.EventHandler(this.TxtCadUsername_Enter);
            this.TxtCadUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCadUsername_KeyPress);
            this.TxtCadUsername.Leave += new System.EventHandler(this.TxtCadUsername_Leave);
            // 
            // PlLogin
            // 
            this.PlLogin.BackColor = System.Drawing.Color.Transparent;
            this.PlLogin.Controls.Add(this.LblAvisoLogin);
            this.PlLogin.Controls.Add(this.LblCadastro);
            this.PlLogin.Controls.Add(this.BtnLogin);
            this.PlLogin.Controls.Add(this.TxtLogPassword);
            this.PlLogin.Controls.Add(this.TxtLogEmail);
            this.PlLogin.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.PlLogin.Location = new System.Drawing.Point(36, 82);
            this.PlLogin.Name = "PlLogin";
            this.PlLogin.Size = new System.Drawing.Size(360, 291);
            this.PlLogin.TabIndex = 6;
            // 
            // LblAvisoLogin
            // 
            this.LblAvisoLogin.ForeColor = System.Drawing.Color.Firebrick;
            this.LblAvisoLogin.Location = new System.Drawing.Point(3, 10);
            this.LblAvisoLogin.Name = "LblAvisoLogin";
            this.LblAvisoLogin.Size = new System.Drawing.Size(354, 25);
            this.LblAvisoLogin.TabIndex = 21;
            this.LblAvisoLogin.Text = "Aviso";
            this.LblAvisoLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LblAvisoLogin.Visible = false;
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblCadastro.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadastro.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblCadastro.Location = new System.Drawing.Point(113, 206);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(124, 12);
            this.LblCadastro.TabIndex = 19;
            this.LblCadastro.Text = "Não possui conta?";
            this.LblCadastro.Click += new System.EventHandler(this.LblCadastro_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(124)))), ((int)(((byte)(1)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnLogin.Location = new System.Drawing.Point(49, 147);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(260, 45);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Entrar";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtLogPassword
            // 
            this.TxtLogPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLogPassword.Location = new System.Drawing.Point(49, 101);
            this.TxtLogPassword.Name = "TxtLogPassword";
            this.TxtLogPassword.Size = new System.Drawing.Size(260, 26);
            this.TxtLogPassword.TabIndex = 2;
            this.TxtLogPassword.Enter += new System.EventHandler(this.TxtLogPassword_Enter);
            this.TxtLogPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLogPassword_KeyPress);
            this.TxtLogPassword.Leave += new System.EventHandler(this.TxtLogPassword_Leave);
            // 
            // TxtLogEmail
            // 
            this.TxtLogEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLogEmail.Location = new System.Drawing.Point(49, 60);
            this.TxtLogEmail.MaxLength = 50;
            this.TxtLogEmail.Name = "TxtLogEmail";
            this.TxtLogEmail.Size = new System.Drawing.Size(260, 26);
            this.TxtLogEmail.TabIndex = 1;
            this.TxtLogEmail.Enter += new System.EventHandler(this.TxtLogEmail_Enter);
            this.TxtLogEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLogEmail_KeyPress);
            this.TxtLogEmail.Leave += new System.EventHandler(this.TxtLogEmail_Leave);
            // 
            // TxtAux
            // 
            this.TxtAux.Location = new System.Drawing.Point(-10, -10);
            this.TxtAux.Name = "TxtAux";
            this.TxtAux.Size = new System.Drawing.Size(10, 20);
            this.TxtAux.TabIndex = 7;
            // 
            // FrmMain
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::MusicApp.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(430, 396);
            this.Controls.Add(this.TxtAux);
            this.Controls.Add(this.PlLogin);
            this.Controls.Add(this.PlCadastro);
            this.Controls.Add(this.plName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.plName.ResumeLayout(false);
            this.plName.PerformLayout();
            this.PlCadastro.ResumeLayout(false);
            this.PlCadastro.PerformLayout();
            this.PlLogin.ResumeLayout(false);
            this.PlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>

        #endregion

        private System.Windows.Forms.Panel plName;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel PlCadastro;
        private System.Windows.Forms.Label LblPWErro;
        private System.Windows.Forms.TextBox TxtCadEmail;
        private System.Windows.Forms.TextBox TxtCadConfPass;
        private System.Windows.Forms.TextBox TxtCadPassword;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.TextBox TxtCadUsername;
        private System.Windows.Forms.Panel PlLogin;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtLogPassword;
        private System.Windows.Forms.TextBox TxtLogEmail;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblAvisoCadastro;
        private System.Windows.Forms.Label LblAvisoLogin;
        private System.Windows.Forms.Label LblPWStrength;
        private System.Windows.Forms.TextBox TxtAux;
    }
}

