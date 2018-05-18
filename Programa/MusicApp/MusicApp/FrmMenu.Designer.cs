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
            this.plContainer = new System.Windows.Forms.Panel();
            this.plFase = new System.Windows.Forms.Panel();
            this.BtnVoltarFases = new System.Windows.Forms.PictureBox();
            this.LblSeila = new System.Windows.Forms.Label();
            this.plAbout = new System.Windows.Forms.Panel();
            this.BtnVoltarAbout = new System.Windows.Forms.PictureBox();
            this.plAchievement = new System.Windows.Forms.Panel();
            this.BtnVoltarAchievement = new System.Windows.Forms.PictureBox();
            this.plSettings = new System.Windows.Forms.Panel();
            this.TrackBarVolume = new System.Windows.Forms.TrackBar();
            this.BtnVoltarSettings = new System.Windows.Forms.PictureBox();
            this.plMenu = new System.Windows.Forms.Panel();
            this.LblMenu = new System.Windows.Forms.Label();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnJogar = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnPraticar = new System.Windows.Forms.Button();
            this.BtnAchievement = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.plFases = new System.Windows.Forms.Panel();
            this.BtnVoltarMenu = new System.Windows.Forms.PictureBox();
            this.BtnFase6 = new System.Windows.Forms.Button();
            this.BtnFase5 = new System.Windows.Forms.Button();
            this.BtnFase4 = new System.Windows.Forms.Button();
            this.BtnFase3 = new System.Windows.Forms.Button();
            this.BtnFase2 = new System.Windows.Forms.Button();
            this.BtnFase1 = new System.Windows.Forms.Button();
            this.LblFases = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.plContainer.SuspendLayout();
            this.plFase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarFases)).BeginInit();
            this.plAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarAbout)).BeginInit();
            this.plAchievement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarAchievement)).BeginInit();
            this.plSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarSettings)).BeginInit();
            this.plMenu.SuspendLayout();
            this.plFases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // plContainer
            // 
            this.plContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plContainer.Controls.Add(this.plFase);
            this.plContainer.Controls.Add(this.plAbout);
            this.plContainer.Controls.Add(this.plAchievement);
            this.plContainer.Controls.Add(this.plSettings);
            this.plContainer.Controls.Add(this.plMenu);
            this.plContainer.Controls.Add(this.plFases);
            this.plContainer.Location = new System.Drawing.Point(0, 23);
            this.plContainer.Name = "plContainer";
            this.plContainer.Size = new System.Drawing.Size(1106, 536);
            this.plContainer.TabIndex = 4;
            // 
            // plFase
            // 
            this.plFase.Controls.Add(this.BtnVoltarFases);
            this.plFase.Controls.Add(this.LblSeila);
            this.plFase.Location = new System.Drawing.Point(600, 31);
            this.plFase.Name = "plFase";
            this.plFase.Size = new System.Drawing.Size(594, 332);
            this.plFase.TabIndex = 12;
            // 
            // BtnVoltarFases
            // 
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
            // LblSeila
            // 
            this.LblSeila.AutoSize = true;
            this.LblSeila.Location = new System.Drawing.Point(177, 57);
            this.LblSeila.Name = "LblSeila";
            this.LblSeila.Size = new System.Drawing.Size(35, 13);
            this.LblSeila.TabIndex = 0;
            this.LblSeila.Text = "label1";
            // 
            // plAbout
            // 
            this.plAbout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plAbout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plAbout.Controls.Add(this.BtnVoltarAbout);
            this.plAbout.Location = new System.Drawing.Point(697, 265);
            this.plAbout.Name = "plAbout";
            this.plAbout.Size = new System.Drawing.Size(255, 224);
            this.plAbout.TabIndex = 10;
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
            this.plAchievement.Controls.Add(this.BtnVoltarAchievement);
            this.plAchievement.Location = new System.Drawing.Point(436, 265);
            this.plAchievement.Name = "plAchievement";
            this.plAchievement.Size = new System.Drawing.Size(255, 224);
            this.plAchievement.TabIndex = 9;
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
            this.plSettings.Controls.Add(this.TrackBarVolume);
            this.plSettings.Controls.Add(this.BtnVoltarSettings);
            this.plSettings.Location = new System.Drawing.Point(175, 265);
            this.plSettings.Name = "plSettings";
            this.plSettings.Size = new System.Drawing.Size(255, 224);
            this.plSettings.TabIndex = 11;
            // 
            // TrackBarVolume
            // 
            this.TrackBarVolume.Location = new System.Drawing.Point(30, 110);
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
            this.plMenu.Controls.Add(this.LblMenu);
            this.plMenu.Controls.Add(this.BtnSettings);
            this.plMenu.Controls.Add(this.BtnJogar);
            this.plMenu.Controls.Add(this.BtnAbout);
            this.plMenu.Controls.Add(this.BtnPraticar);
            this.plMenu.Controls.Add(this.BtnAchievement);
            this.plMenu.Controls.Add(this.button4);
            this.plMenu.Location = new System.Drawing.Point(0, 0);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(585, 332);
            this.plMenu.TabIndex = 7;
            // 
            // LblMenu
            // 
            this.LblMenu.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.Location = new System.Drawing.Point(2, 17);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(580, 81);
            this.LblMenu.TabIndex = 6;
            this.LblMenu.Text = "Musicologia";
            this.LblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackgroundImage = global::MusicApp.Properties.Resources.settings;
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Location = new System.Drawing.Point(215, 282);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(32, 32);
            this.BtnSettings.TabIndex = 0;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnJogar
            // 
            this.BtnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJogar.Location = new System.Drawing.Point(129, 133);
            this.BtnJogar.Name = "BtnJogar";
            this.BtnJogar.Size = new System.Drawing.Size(312, 57);
            this.BtnJogar.TabIndex = 5;
            this.BtnJogar.Text = "Jogar";
            this.BtnJogar.UseVisualStyleBackColor = true;
            this.BtnJogar.Click += new System.EventHandler(this.BtnJogar_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackgroundImage = global::MusicApp.Properties.Resources.info;
            this.BtnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Location = new System.Drawing.Point(291, 282);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(32, 32);
            this.BtnAbout.TabIndex = 1;
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnPraticar
            // 
            this.BtnPraticar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPraticar.Location = new System.Drawing.Point(181, 198);
            this.BtnPraticar.Name = "BtnPraticar";
            this.BtnPraticar.Size = new System.Drawing.Size(210, 34);
            this.BtnPraticar.TabIndex = 4;
            this.BtnPraticar.Text = "Praticar";
            this.BtnPraticar.UseVisualStyleBackColor = true;
            this.BtnPraticar.Click += new System.EventHandler(this.BtnMultiplayer_Click);
            // 
            // BtnAchievement
            // 
            this.BtnAchievement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAchievement.BackgroundImage")));
            this.BtnAchievement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAchievement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAchievement.Location = new System.Drawing.Point(253, 282);
            this.BtnAchievement.Name = "BtnAchievement";
            this.BtnAchievement.Size = new System.Drawing.Size(32, 32);
            this.BtnAchievement.TabIndex = 2;
            this.BtnAchievement.UseVisualStyleBackColor = true;
            this.BtnAchievement.Click += new System.EventHandler(this.BtnAchievement_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(329, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 32);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // plFases
            // 
            this.plFases.Controls.Add(this.BtnVoltarMenu);
            this.plFases.Controls.Add(this.BtnFase6);
            this.plFases.Controls.Add(this.BtnFase5);
            this.plFases.Controls.Add(this.BtnFase4);
            this.plFases.Controls.Add(this.BtnFase3);
            this.plFases.Controls.Add(this.BtnFase2);
            this.plFases.Controls.Add(this.BtnFase1);
            this.plFases.Controls.Add(this.LblFases);
            this.plFases.Location = new System.Drawing.Point(0, 0);
            this.plFases.Name = "plFases";
            this.plFases.Size = new System.Drawing.Size(585, 332);
            this.plFases.TabIndex = 8;
            // 
            // BtnVoltarMenu
            // 
            this.BtnVoltarMenu.BackgroundImage = global::MusicApp.Properties.Resources.back;
            this.BtnVoltarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVoltarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltarMenu.Location = new System.Drawing.Point(15, 15);
            this.BtnVoltarMenu.Name = "BtnVoltarMenu";
            this.BtnVoltarMenu.Size = new System.Drawing.Size(52, 50);
            this.BtnVoltarMenu.TabIndex = 16;
            this.BtnVoltarMenu.TabStop = false;
            this.BtnVoltarMenu.Click += new System.EventHandler(this.BtnVoltarMenu_Click);
            // 
            // BtnFase6
            // 
            this.BtnFase6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnFase6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFase6.Location = new System.Drawing.Point(387, 221);
            this.BtnFase6.Name = "BtnFase6";
            this.BtnFase6.Size = new System.Drawing.Size(109, 59);
            this.BtnFase6.TabIndex = 15;
            this.BtnFase6.Text = "Fase 6";
            this.BtnFase6.UseVisualStyleBackColor = false;
            // 
            // BtnFase5
            // 
            this.BtnFase5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnFase5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFase5.Location = new System.Drawing.Point(236, 221);
            this.BtnFase5.Name = "BtnFase5";
            this.BtnFase5.Size = new System.Drawing.Size(109, 59);
            this.BtnFase5.TabIndex = 14;
            this.BtnFase5.Text = "Fase 5";
            this.BtnFase5.UseVisualStyleBackColor = false;
            // 
            // BtnFase4
            // 
            this.BtnFase4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnFase4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFase4.Location = new System.Drawing.Point(75, 221);
            this.BtnFase4.Name = "BtnFase4";
            this.BtnFase4.Size = new System.Drawing.Size(109, 59);
            this.BtnFase4.TabIndex = 13;
            this.BtnFase4.Text = "Fase 4";
            this.BtnFase4.UseVisualStyleBackColor = false;
            // 
            // BtnFase3
            // 
            this.BtnFase3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnFase3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFase3.Location = new System.Drawing.Point(387, 116);
            this.BtnFase3.Name = "BtnFase3";
            this.BtnFase3.Size = new System.Drawing.Size(109, 59);
            this.BtnFase3.TabIndex = 12;
            this.BtnFase3.Text = "Fase 3";
            this.BtnFase3.UseVisualStyleBackColor = false;
            // 
            // BtnFase2
            // 
            this.BtnFase2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnFase2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFase2.Location = new System.Drawing.Point(236, 116);
            this.BtnFase2.Name = "BtnFase2";
            this.BtnFase2.Size = new System.Drawing.Size(109, 59);
            this.BtnFase2.TabIndex = 11;
            this.BtnFase2.Text = "Fase 2";
            this.BtnFase2.UseVisualStyleBackColor = false;
            // 
            // BtnFase1
            // 
            this.BtnFase1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnFase1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFase1.Location = new System.Drawing.Point(75, 116);
            this.BtnFase1.Name = "BtnFase1";
            this.BtnFase1.Size = new System.Drawing.Size(109, 59);
            this.BtnFase1.TabIndex = 10;
            this.BtnFase1.Text = "Fase 1";
            this.BtnFase1.UseVisualStyleBackColor = false;
            // 
            // LblFases
            // 
            this.LblFases.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFases.Location = new System.Drawing.Point(3, 16);
            this.LblFases.Name = "LblFases";
            this.LblFases.Size = new System.Drawing.Size(579, 81);
            this.LblFases.TabIndex = 8;
            this.LblFases.Text = "Fases";
            this.LblFases.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnClose.BackgroundImage = global::MusicApp.Properties.Resources.close;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(1077, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(24, 24);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.TabStop = false;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMinimize.BackgroundImage = global::MusicApp.Properties.Resources.minimize;
            this.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Location = new System.Drawing.Point(1049, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(24, 24);
            this.BtnMinimize.TabIndex = 0;
            this.BtnMinimize.TabStop = false;
            this.BtnMinimize.UseVisualStyleBackColor = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1106, 559);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.plContainer);
            this.Controls.Add(this.BtnMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musicologia";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMenu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMenu_MouseUp);
            this.plContainer.ResumeLayout(false);
            this.plFase.ResumeLayout(false);
            this.plFase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarFases)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.BtnVoltarMenu)).EndInit();
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
        private System.Windows.Forms.Button BtnPraticar;
        private System.Windows.Forms.Button BtnAchievement;
        private System.Windows.Forms.Button button4;
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
        private System.Windows.Forms.PictureBox BtnVoltarMenu;
        private System.Windows.Forms.PictureBox BtnVoltarAbout;
        private System.Windows.Forms.PictureBox BtnVoltarAchievement;
        private System.Windows.Forms.PictureBox BtnVoltarSettings;
        private System.Windows.Forms.Panel plFase;
        private System.Windows.Forms.Label LblSeila;
        private System.Windows.Forms.PictureBox BtnVoltarFases;
        private System.Windows.Forms.TrackBar TrackBarVolume;
    }
}