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
            this.plFases = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.plMenu = new System.Windows.Forms.Panel();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnJogar = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnPraticar = new System.Windows.Forms.Button();
            this.BtnAchievement = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnMaximize = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.plContainer.SuspendLayout();
            this.plFases.SuspendLayout();
            this.plMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // plContainer
            // 
            this.plContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plContainer.Controls.Add(this.plFases);
            this.plContainer.Location = new System.Drawing.Point(0, 24);
            this.plContainer.Name = "plContainer";
            this.plContainer.Size = new System.Drawing.Size(597, 338);
            this.plContainer.TabIndex = 4;
            // 
            // plFases
            // 
            this.plFases.Controls.Add(this.plMenu);
            this.plFases.Controls.Add(this.label2);
            this.plFases.Location = new System.Drawing.Point(3, 0);
            this.plFases.Name = "plFases";
            this.plFases.Size = new System.Drawing.Size(585, 332);
            this.plFases.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(588, 81);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fases";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // plMenu
            // 
            this.plMenu.Controls.Add(this.LblName);
            this.plMenu.Controls.Add(this.BtnSettings);
            this.plMenu.Controls.Add(this.BtnJogar);
            this.plMenu.Controls.Add(this.BtnAbout);
            this.plMenu.Controls.Add(this.BtnPraticar);
            this.plMenu.Controls.Add(this.BtnAchievement);
            this.plMenu.Controls.Add(this.button4);
            this.plMenu.Location = new System.Drawing.Point(0, 3);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(588, 335);
            this.plMenu.TabIndex = 7;
            // 
            // LblName
            // 
            this.LblName.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(0, 17);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(588, 81);
            this.LblName.TabIndex = 6;
            this.LblName.Text = "Musicologia";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackgroundImage = global::MusicApp.Properties.Resources.settings;
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Location = new System.Drawing.Point(329, 282);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(32, 32);
            this.BtnSettings.TabIndex = 0;
            this.BtnSettings.UseVisualStyleBackColor = true;
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
            this.BtnAbout.Location = new System.Drawing.Point(290, 282);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(32, 32);
            this.BtnAbout.TabIndex = 1;
            this.BtnAbout.UseVisualStyleBackColor = true;
            // 
            // BtnPraticar
            // 
            this.BtnPraticar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPraticar.Location = new System.Drawing.Point(183, 198);
            this.BtnPraticar.Name = "BtnPraticar";
            this.BtnPraticar.Size = new System.Drawing.Size(204, 34);
            this.BtnPraticar.TabIndex = 4;
            this.BtnPraticar.Text = "Praticar";
            this.BtnPraticar.UseVisualStyleBackColor = true;
            // 
            // BtnAchievement
            // 
            this.BtnAchievement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAchievement.BackgroundImage")));
            this.BtnAchievement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAchievement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAchievement.Location = new System.Drawing.Point(252, 282);
            this.BtnAchievement.Name = "BtnAchievement";
            this.BtnAchievement.Size = new System.Drawing.Size(32, 32);
            this.BtnAchievement.TabIndex = 2;
            this.BtnAchievement.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(214, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 32);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnClose.BackgroundImage = global::MusicApp.Properties.Resources.close;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(565, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(24, 24);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.TabStop = false;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximize.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMaximize.BackgroundImage = global::MusicApp.Properties.Resources.maximize;
            this.BtnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.Location = new System.Drawing.Point(537, 0);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(24, 24);
            this.BtnMaximize.TabIndex = 0;
            this.BtnMaximize.TabStop = false;
            this.BtnMaximize.UseVisualStyleBackColor = false;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMinimize.BackgroundImage = global::MusicApp.Properties.Resources.minimize;
            this.BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.Location = new System.Drawing.Point(509, 0);
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
            this.ClientSize = new System.Drawing.Size(594, 362);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnMaximize);
            this.Controls.Add(this.plContainer);
            this.Controls.Add(this.BtnMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musicologia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.plContainer.ResumeLayout(false);
            this.plFases.ResumeLayout(false);
            this.plMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel plContainer;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnMaximize;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnJogar;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button BtnPraticar;
        private System.Windows.Forms.Button BtnAchievement;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel plMenu;
        private System.Windows.Forms.Panel plFases;
        private System.Windows.Forms.Label label2;
    }
}