using System.Drawing;

namespace MusicApp
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.BtnClose = new System.Windows.Forms.Button();
            this.plContainer = new System.Windows.Forms.Panel();
            this.plFase = new System.Windows.Forms.Panel();
            this.lblFalas = new System.Windows.Forms.Label();
            this.pbNarrador = new System.Windows.Forms.PictureBox();
            this.BtnVoltarFases = new System.Windows.Forms.PictureBox();
            this.plMultiplayer = new System.Windows.Forms.Panel();
            this.BtnFicarDisponivel = new System.Windows.Forms.Button();
            this.BtnVoltarMenuMultiplayer = new System.Windows.Forms.PictureBox();
            this.LblMultiplayer = new System.Windows.Forms.Label();
            this.plAbout = new System.Windows.Forms.Panel();
            this.LblAbout = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            this.BtnVoltarAbout = new System.Windows.Forms.PictureBox();
            this.plAchievement = new System.Windows.Forms.Panel();
            this.LblAchievement = new System.Windows.Forms.Label();
            this.BtnVoltarAchievement = new System.Windows.Forms.PictureBox();
            this.plSettings = new System.Windows.Forms.Panel();
            this.LblSettings = new System.Windows.Forms.Label();
            this.LblVolume = new System.Windows.Forms.Label();
            this.TrackBarVolume = new System.Windows.Forms.TrackBar();
            this.BtnVoltarSettings = new System.Windows.Forms.PictureBox();
            this.plMenu = new System.Windows.Forms.Panel();
            this.LblMenu = new System.Windows.Forms.Label();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnJogar = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnMultiplayer = new System.Windows.Forms.Button();
            this.BtnAchievement = new System.Windows.Forms.Button();
            this.plFases = new System.Windows.Forms.Panel();
            this.BtnVoltarMenuFases = new System.Windows.Forms.PictureBox();
            this.BtnFase6 = new System.Windows.Forms.Button();
            this.BtnFase5 = new System.Windows.Forms.Button();
            this.BtnFase4 = new System.Windows.Forms.Button();
            this.BtnFase3 = new System.Windows.Forms.Button();
            this.BtnFase2 = new System.Windows.Forms.Button();
            this.BtnFase1 = new System.Windows.Forms.Button();
            this.LblFases = new System.Windows.Forms.Label();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.plContainer.SuspendLayout();
            this.plFase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNarrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarFases)).BeginInit();
            this.plMultiplayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarMenuMultiplayer)).BeginInit();
            this.plAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarAbout)).BeginInit();
            this.plAchievement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarAchievement)).BeginInit();
            this.plSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarSettings)).BeginInit();
            this.plMenu.SuspendLayout();
            this.plFases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarMenuFases)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnClose.BackgroundImage = global::MusicApp.Properties.Resources.close;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(870, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(25, 25);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.TabStop = false;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // plContainer
            // 
            this.plContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plContainer.BackColor = System.Drawing.Color.Black;
            this.plContainer.BackgroundImage = global::MusicApp.Properties.Resources.background;
            this.plContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.plContainer.Controls.Add(this.plFase);
            this.plContainer.Controls.Add(this.plMultiplayer);
            this.plContainer.Controls.Add(this.plAbout);
            this.plContainer.Controls.Add(this.plAchievement);
            this.plContainer.Controls.Add(this.plSettings);
            this.plContainer.Controls.Add(this.plMenu);
            this.plContainer.Controls.Add(this.plFases);
            this.plContainer.Location = new System.Drawing.Point(0, 25);
            this.plContainer.Name = "plContainer";
            this.plContainer.Size = new System.Drawing.Size(899, 451);
            this.plContainer.TabIndex = 4;
            // 
            // plFase
            // 
            this.plFase.BackColor = System.Drawing.Color.Transparent;
            this.plFase.Controls.Add(this.lblFalas);
            this.plFase.Controls.Add(this.pbNarrador);
            this.plFase.Controls.Add(this.BtnVoltarFases);
            this.plFase.Location = new System.Drawing.Point(0, 0);
            this.plFase.Name = "plFase";
            this.plFase.Size = new System.Drawing.Size(900, 450);
            this.plFase.TabIndex = 12;
            // 
            // lblFalas
            // 
            this.lblFalas.BackColor = System.Drawing.Color.White;
            this.lblFalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalas.Location = new System.Drawing.Point(7, 349);
            this.lblFalas.Name = "lblFalas";
            this.lblFalas.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lblFalas.Size = new System.Drawing.Size(629, 92);
            this.lblFalas.TabIndex = 19;
            this.lblFalas.Text = "Falas";
            this.lblFalas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbNarrador
            // 
            this.pbNarrador.BackColor = System.Drawing.Color.Transparent;
            this.pbNarrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbNarrador.Location = new System.Drawing.Point(642, 110);
            this.pbNarrador.Name = "pbNarrador";
            this.pbNarrador.Size = new System.Drawing.Size(258, 340);
            this.pbNarrador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNarrador.TabIndex = 18;
            this.pbNarrador.TabStop = false;
            // 
            // BtnVoltarFases
            // 
            this.BtnVoltarFases.BackColor = System.Drawing.Color.Transparent;
            this.BtnVoltarFases.BackgroundImage = global::MusicApp.Properties.Resources.back;
            this.BtnVoltarFases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoltarFases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltarFases.Location = new System.Drawing.Point(10, 10);
            this.BtnVoltarFases.Name = "BtnVoltarFases";
            this.BtnVoltarFases.Size = new System.Drawing.Size(40, 40);
            this.BtnVoltarFases.TabIndex = 17;
            this.BtnVoltarFases.TabStop = false;
            this.BtnVoltarFases.Click += new System.EventHandler(this.BtnVoltarFases_Click);
            // 
            // plMultiplayer
            // 
            this.plMultiplayer.BackColor = System.Drawing.Color.Transparent;
            this.plMultiplayer.Controls.Add(this.BtnFicarDisponivel);
            this.plMultiplayer.Controls.Add(this.BtnVoltarMenuMultiplayer);
            this.plMultiplayer.Controls.Add(this.LblMultiplayer);
            this.plMultiplayer.Location = new System.Drawing.Point(0, 0);
            this.plMultiplayer.Name = "plMultiplayer";
            this.plMultiplayer.Size = new System.Drawing.Size(900, 450);
            this.plMultiplayer.TabIndex = 13;
            // 
            // BtnFicarDisponivel
            // 
            this.BtnFicarDisponivel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnFicarDisponivel.FlatAppearance.BorderSize = 0;
            this.BtnFicarDisponivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(124)))), ((int)(((byte)(1)))));
            this.BtnFicarDisponivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFicarDisponivel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFicarDisponivel.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnFicarDisponivel.Location = new System.Drawing.Point(571, 163);
            this.BtnFicarDisponivel.Name = "BtnFicarDisponivel";
            this.BtnFicarDisponivel.Size = new System.Drawing.Size(225, 65);
            this.BtnFicarDisponivel.TabIndex = 20;
            this.BtnFicarDisponivel.Text = "Ficar Disponível";
            this.BtnFicarDisponivel.UseVisualStyleBackColor = true;
            this.BtnFicarDisponivel.Click += new System.EventHandler(this.BtnFicarDisponivel_Click);
            // 
            // BtnVoltarMenuMultiplayer
            // 
            this.BtnVoltarMenuMultiplayer.BackgroundImage = global::MusicApp.Properties.Resources.back;
            this.BtnVoltarMenuMultiplayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoltarMenuMultiplayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltarMenuMultiplayer.Location = new System.Drawing.Point(15, 15);
            this.BtnVoltarMenuMultiplayer.Name = "BtnVoltarMenuMultiplayer";
            this.BtnVoltarMenuMultiplayer.Size = new System.Drawing.Size(52, 50);
            this.BtnVoltarMenuMultiplayer.TabIndex = 19;
            this.BtnVoltarMenuMultiplayer.TabStop = false;
            this.BtnVoltarMenuMultiplayer.Click += new System.EventHandler(this.BtnVoltarMenuMultiplayer_Click);
            // 
            // LblMultiplayer
            // 
            this.LblMultiplayer.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMultiplayer.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblMultiplayer.Location = new System.Drawing.Point(3, 40);
            this.LblMultiplayer.Name = "LblMultiplayer";
            this.LblMultiplayer.Size = new System.Drawing.Size(895, 81);
            this.LblMultiplayer.TabIndex = 18;
            this.LblMultiplayer.Text = "Multiplayer";
            this.LblMultiplayer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // plAbout
            // 
            this.plAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plAbout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plAbout.Controls.Add(this.label1);
            this.plAbout.Controls.Add(this.LblAbout);
            this.plAbout.Controls.Add(this.LblInfo);
            this.plAbout.Controls.Add(this.BtnVoltarAbout);
            this.plAbout.Location = new System.Drawing.Point(804, 7);
            this.plAbout.Name = "plAbout";
            this.plAbout.Size = new System.Drawing.Size(321, 346);
            this.plAbout.TabIndex = 10;
            // 
            // LblAbout
            // 
            this.LblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAbout.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblAbout.Location = new System.Drawing.Point(50, 9);
            this.LblAbout.Name = "LblAbout";
            this.LblAbout.Size = new System.Drawing.Size(268, 44);
            this.LblAbout.TabIndex = 6;
            this.LblAbout.Text = "Sobre o Jogo";
            this.LblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblInfo
            // 
            this.LblInfo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblInfo.Location = new System.Drawing.Point(16, 55);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(290, 241);
            this.LblInfo.TabIndex = 2;
            this.LblInfo.Text = resources.GetString("LblInfo.Text");
            this.LblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnVoltarAbout
            // 
            this.BtnVoltarAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVoltarAbout.BackgroundImage")));
            this.BtnVoltarAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoltarAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltarAbout.Location = new System.Drawing.Point(3, 9);
            this.BtnVoltarAbout.Name = "BtnVoltarAbout";
            this.BtnVoltarAbout.Size = new System.Drawing.Size(45, 45);
            this.BtnVoltarAbout.TabIndex = 1;
            this.BtnVoltarAbout.TabStop = false;
            this.BtnVoltarAbout.Click += new System.EventHandler(this.BtnVoltarAbout_Click);
            // 
            // plAchievement
            // 
            this.plAchievement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plAchievement.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plAchievement.Controls.Add(this.LblAchievement);
            this.plAchievement.Controls.Add(this.BtnVoltarAchievement);
            this.plAchievement.Location = new System.Drawing.Point(352, 379);
            this.plAchievement.Name = "plAchievement";
            this.plAchievement.Size = new System.Drawing.Size(255, 224);
            this.plAchievement.TabIndex = 9;
            // 
            // LblAchievement
            // 
            this.LblAchievement.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAchievement.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblAchievement.Location = new System.Drawing.Point(50, 9);
            this.LblAchievement.Name = "LblAchievement";
            this.LblAchievement.Size = new System.Drawing.Size(202, 43);
            this.LblAchievement.TabIndex = 5;
            this.LblAchievement.Text = "Conquistas";
            this.LblAchievement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnVoltarAchievement
            // 
            this.BtnVoltarAchievement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVoltarAchievement.BackgroundImage")));
            this.BtnVoltarAchievement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoltarAchievement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltarAchievement.Location = new System.Drawing.Point(3, 9);
            this.BtnVoltarAchievement.Name = "BtnVoltarAchievement";
            this.BtnVoltarAchievement.Size = new System.Drawing.Size(45, 45);
            this.BtnVoltarAchievement.TabIndex = 1;
            this.BtnVoltarAchievement.TabStop = false;
            this.BtnVoltarAchievement.Click += new System.EventHandler(this.BtnVoltarAchievement_Click);
            // 
            // plSettings
            // 
            this.plSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plSettings.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plSettings.Controls.Add(this.LblSettings);
            this.plSettings.Controls.Add(this.LblVolume);
            this.plSettings.Controls.Add(this.TrackBarVolume);
            this.plSettings.Controls.Add(this.BtnVoltarSettings);
            this.plSettings.Location = new System.Drawing.Point(91, 379);
            this.plSettings.Name = "plSettings";
            this.plSettings.Size = new System.Drawing.Size(255, 224);
            this.plSettings.TabIndex = 11;
            // 
            // LblSettings
            // 
            this.LblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSettings.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblSettings.Location = new System.Drawing.Point(50, 11);
            this.LblSettings.Name = "LblSettings";
            this.LblSettings.Size = new System.Drawing.Size(202, 41);
            this.LblSettings.TabIndex = 4;
            this.LblSettings.Text = "Configurações";
            this.LblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblVolume
            // 
            this.LblVolume.AutoSize = true;
            this.LblVolume.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVolume.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblVolume.Location = new System.Drawing.Point(27, 82);
            this.LblVolume.Name = "LblVolume";
            this.LblVolume.Size = new System.Drawing.Size(111, 32);
            this.LblVolume.TabIndex = 2;
            this.LblVolume.Text = "Volume: ";
            // 
            // TrackBarVolume
            // 
            this.TrackBarVolume.Location = new System.Drawing.Point(33, 117);
            this.TrackBarVolume.Maximum = 100;
            this.TrackBarVolume.Name = "TrackBarVolume";
            this.TrackBarVolume.Size = new System.Drawing.Size(198, 45);
            this.TrackBarVolume.TabIndex = 1;
            this.TrackBarVolume.Value = 50;
            this.TrackBarVolume.Scroll += new System.EventHandler(this.TrackBarVolume_Scroll);
            // 
            // BtnVoltarSettings
            // 
            this.BtnVoltarSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVoltarSettings.BackgroundImage")));
            this.BtnVoltarSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoltarSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltarSettings.Location = new System.Drawing.Point(3, 9);
            this.BtnVoltarSettings.Name = "BtnVoltarSettings";
            this.BtnVoltarSettings.Size = new System.Drawing.Size(45, 45);
            this.BtnVoltarSettings.TabIndex = 0;
            this.BtnVoltarSettings.TabStop = false;
            this.BtnVoltarSettings.Click += new System.EventHandler(this.BtnVoltarSettings_Click);
            // 
            // plMenu
            // 
            this.plMenu.BackColor = System.Drawing.Color.Transparent;
            this.plMenu.Controls.Add(this.LblMenu);
            this.plMenu.Controls.Add(this.BtnSettings);
            this.plMenu.Controls.Add(this.BtnJogar);
            this.plMenu.Controls.Add(this.BtnAbout);
            this.plMenu.Controls.Add(this.BtnMultiplayer);
            this.plMenu.Controls.Add(this.BtnAchievement);
            this.plMenu.Location = new System.Drawing.Point(0, 0);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(900, 450);
            this.plMenu.TabIndex = 7;
            // 
            // LblMenu
            // 
            this.LblMenu.BackColor = System.Drawing.Color.Transparent;
            this.LblMenu.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblMenu.Location = new System.Drawing.Point(2, 50);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(896, 81);
            this.LblMenu.TabIndex = 6;
            this.LblMenu.Text = "Musicologia";
            this.LblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSettings.BackgroundImage = global::MusicApp.Properties.Resources.settings;
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(124)))), ((int)(((byte)(1)))));
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Location = new System.Drawing.Point(393, 339);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(32, 32);
            this.BtnSettings.TabIndex = 0;
            this.BtnSettings.UseVisualStyleBackColor = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnJogar
            // 
            this.BtnJogar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnJogar.FlatAppearance.BorderSize = 0;
            this.BtnJogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(124)))), ((int)(((byte)(1)))));
            this.BtnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJogar.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJogar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnJogar.Location = new System.Drawing.Point(289, 185);
            this.BtnJogar.Name = "BtnJogar";
            this.BtnJogar.Size = new System.Drawing.Size(312, 62);
            this.BtnJogar.TabIndex = 5;
            this.BtnJogar.Text = "Jogar";
            this.BtnJogar.UseVisualStyleBackColor = false;
            this.BtnJogar.Click += new System.EventHandler(this.BtnJogar_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnAbout.BackgroundImage = global::MusicApp.Properties.Resources.info;
            this.BtnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAbout.FlatAppearance.BorderSize = 0;
            this.BtnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(124)))), ((int)(((byte)(1)))));
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Location = new System.Drawing.Point(469, 339);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(32, 32);
            this.BtnAbout.TabIndex = 1;
            this.BtnAbout.UseVisualStyleBackColor = false;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnMultiplayer
            // 
            this.BtnMultiplayer.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnMultiplayer.FlatAppearance.BorderSize = 0;
            this.BtnMultiplayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(124)))), ((int)(((byte)(1)))));
            this.BtnMultiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiplayer.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplayer.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnMultiplayer.Location = new System.Drawing.Point(341, 255);
            this.BtnMultiplayer.Name = "BtnMultiplayer";
            this.BtnMultiplayer.Size = new System.Drawing.Size(210, 50);
            this.BtnMultiplayer.TabIndex = 4;
            this.BtnMultiplayer.Text = "Multiplayer";
            this.BtnMultiplayer.UseVisualStyleBackColor = false;
            this.BtnMultiplayer.Click += new System.EventHandler(this.BtnMultiplayer_Click);
            // 
            // BtnAchievement
            // 
            this.BtnAchievement.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnAchievement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAchievement.BackgroundImage")));
            this.BtnAchievement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAchievement.FlatAppearance.BorderSize = 0;
            this.BtnAchievement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(124)))), ((int)(((byte)(1)))));
            this.BtnAchievement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAchievement.Location = new System.Drawing.Point(431, 339);
            this.BtnAchievement.Name = "BtnAchievement";
            this.BtnAchievement.Size = new System.Drawing.Size(32, 32);
            this.BtnAchievement.TabIndex = 2;
            this.BtnAchievement.UseVisualStyleBackColor = false;
            this.BtnAchievement.Click += new System.EventHandler(this.BtnAchievement_Click);
            // 
            // plFases
            // 
            this.plFases.BackColor = System.Drawing.Color.Transparent;
            this.plFases.Controls.Add(this.BtnVoltarMenuFases);
            this.plFases.Controls.Add(this.BtnFase6);
            this.plFases.Controls.Add(this.BtnFase5);
            this.plFases.Controls.Add(this.BtnFase4);
            this.plFases.Controls.Add(this.BtnFase3);
            this.plFases.Controls.Add(this.BtnFase2);
            this.plFases.Controls.Add(this.BtnFase1);
            this.plFases.Controls.Add(this.LblFases);
            this.plFases.Location = new System.Drawing.Point(0, 0);
            this.plFases.Name = "plFases";
            this.plFases.Size = new System.Drawing.Size(900, 450);
            this.plFases.TabIndex = 8;
            // 
            // BtnVoltarMenuFases
            // 
            this.BtnVoltarMenuFases.BackgroundImage = global::MusicApp.Properties.Resources.back;
            this.BtnVoltarMenuFases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoltarMenuFases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltarMenuFases.Location = new System.Drawing.Point(15, 15);
            this.BtnVoltarMenuFases.Name = "BtnVoltarMenuFases";
            this.BtnVoltarMenuFases.Size = new System.Drawing.Size(52, 50);
            this.BtnVoltarMenuFases.TabIndex = 16;
            this.BtnVoltarMenuFases.TabStop = false;
            this.BtnVoltarMenuFases.Click += new System.EventHandler(this.BtnVoltarMenuFases_Click);
            // 
            // BtnFase6
            // 
            this.BtnFase6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnFase6.FlatAppearance.BorderSize = 0;
            this.BtnFase6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(124)))), ((int)(((byte)(1)))));
            this.BtnFase6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFase6.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFase6.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnFase6.Location = new System.Drawing.Point(571, 289);
            this.BtnFase6.Name = "BtnFase6";
            this.BtnFase6.Size = new System.Drawing.Size(207, 88);
            this.BtnFase6.TabIndex = 15;
            this.BtnFase6.Text = "Fase 6";
            this.BtnFase6.UseVisualStyleBackColor = true;
            // 
            // BtnFase5
            // 
            this.BtnFase5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnFase5.FlatAppearance.BorderSize = 0;
            this.BtnFase5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(124)))), ((int)(((byte)(1)))));
            this.BtnFase5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFase5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFase5.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnFase5.Location = new System.Drawing.Point(341, 289);
            this.BtnFase5.Name = "BtnFase5";
            this.BtnFase5.Size = new System.Drawing.Size(207, 88);
            this.BtnFase5.TabIndex = 14;
            this.BtnFase5.Text = "Fase 5";
            this.BtnFase5.UseVisualStyleBackColor = true;
            // 
            // BtnFase4
            // 
            this.BtnFase4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnFase4.FlatAppearance.BorderSize = 0;
            this.BtnFase4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(124)))), ((int)(((byte)(1)))));
            this.BtnFase4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFase4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFase4.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnFase4.Location = new System.Drawing.Point(108, 289);
            this.BtnFase4.Name = "BtnFase4";
            this.BtnFase4.Size = new System.Drawing.Size(207, 88);
            this.BtnFase4.TabIndex = 13;
            this.BtnFase4.Text = "Fase 4";
            this.BtnFase4.UseVisualStyleBackColor = true;
            // 
            // BtnFase3
            // 
            this.BtnFase3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnFase3.FlatAppearance.BorderSize = 0;
            this.BtnFase3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(124)))), ((int)(((byte)(1)))));
            this.BtnFase3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFase3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFase3.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnFase3.Location = new System.Drawing.Point(571, 163);
            this.BtnFase3.Name = "BtnFase3";
            this.BtnFase3.Size = new System.Drawing.Size(207, 88);
            this.BtnFase3.TabIndex = 12;
            this.BtnFase3.Text = "Fase 3";
            this.BtnFase3.UseVisualStyleBackColor = true;
            // 
            // BtnFase2
            // 
            this.BtnFase2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnFase2.FlatAppearance.BorderSize = 0;
            this.BtnFase2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(124)))), ((int)(((byte)(1)))));
            this.BtnFase2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFase2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFase2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnFase2.Location = new System.Drawing.Point(341, 163);
            this.BtnFase2.Name = "BtnFase2";
            this.BtnFase2.Size = new System.Drawing.Size(207, 88);
            this.BtnFase2.TabIndex = 11;
            this.BtnFase2.Text = "Fase 2";
            this.BtnFase2.UseVisualStyleBackColor = true;
            // 
            // BtnFase1
            // 
            this.BtnFase1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnFase1.FlatAppearance.BorderSize = 0;
            this.BtnFase1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(124)))), ((int)(((byte)(1)))));
            this.BtnFase1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFase1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFase1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnFase1.Location = new System.Drawing.Point(108, 163);
            this.BtnFase1.Name = "BtnFase1";
            this.BtnFase1.Size = new System.Drawing.Size(207, 88);
            this.BtnFase1.TabIndex = 10;
            this.BtnFase1.Text = "Fase 1";
            this.BtnFase1.UseVisualStyleBackColor = true;
            // 
            // LblFases
            // 
            this.LblFases.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFases.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblFases.Location = new System.Drawing.Point(3, 40);
            this.LblFases.Name = "LblFases";
            this.LblFases.Size = new System.Drawing.Size(895, 81);
            this.LblFases.TabIndex = 8;
            this.LblFases.Text = "Fases";
            this.LblFases.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMinimize.BackgroundImage = global::MusicApp.Properties.Resources.minimize;
            this.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Location = new System.Drawing.Point(842, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(25, 25);
            this.BtnMinimize.TabIndex = 0;
            this.BtnMinimize.TabStop = false;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(34, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jogo desenvolvido por Caio Rosa e Nicholas Patapoff em C#.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(899, 474);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.plContainer);
            this.Controls.Add(this.BtnMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musicologia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMenu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMenu_MouseUp);
            this.plContainer.ResumeLayout(false);
            this.plFase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNarrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarFases)).EndInit();
            this.plMultiplayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarMenuMultiplayer)).EndInit();
            this.plAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarAbout)).EndInit();
            this.plAchievement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarAchievement)).EndInit();
            this.plSettings.ResumeLayout(false);
            this.plSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarSettings)).EndInit();
            this.plMenu.ResumeLayout(false);
            this.plFases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarMenuFases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel plContainer;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnJogar;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button BtnMultiplayer;
        private System.Windows.Forms.Button BtnAchievement;
        private System.Windows.Forms.Panel plMenu;
        private System.Windows.Forms.Panel plFases;
        private System.Windows.Forms.Label LblFases;
        private System.Windows.Forms.Button BtnFase5;
        private System.Windows.Forms.Button BtnFase4;
        private System.Windows.Forms.Button BtnFase3;
        private System.Windows.Forms.Button BtnFase2;
        private System.Windows.Forms.Button BtnFase1;
        private System.Windows.Forms.Button BtnFase6;
        private System.Windows.Forms.Panel plSettings;
        private System.Windows.Forms.Panel plAbout;
        private System.Windows.Forms.Panel plAchievement;
        private System.Windows.Forms.PictureBox BtnVoltarMenuFases;
        private System.Windows.Forms.PictureBox BtnVoltarAbout;
        private System.Windows.Forms.PictureBox BtnVoltarAchievement;
        private System.Windows.Forms.PictureBox BtnVoltarSettings;
        private System.Windows.Forms.Panel plFase;
        private System.Windows.Forms.PictureBox BtnVoltarFases;
        private System.Windows.Forms.TrackBar TrackBarVolume;
        private System.Windows.Forms.PictureBox pbNarrador;
        private System.Windows.Forms.Label lblFalas;
        private System.Windows.Forms.Panel plMultiplayer;
        private System.Windows.Forms.PictureBox BtnVoltarMenuMultiplayer;
        private System.Windows.Forms.Label LblMultiplayer;
        private System.Windows.Forms.Button BtnFicarDisponivel;
        private System.Windows.Forms.Label LblVolume;
        private System.Windows.Forms.Label LblAbout;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Label LblAchievement;
        private System.Windows.Forms.Label LblSettings;
        private System.Windows.Forms.Label label1;
    }
}