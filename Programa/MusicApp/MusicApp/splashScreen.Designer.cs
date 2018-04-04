namespace MusicApp
{
    partial class SplashScreen
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
            this.pgbLoading = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pgbLoading
            // 
            this.pgbLoading.Location = new System.Drawing.Point(2, 162);
            this.pgbLoading.Name = "pgbLoading";
            this.pgbLoading.Size = new System.Drawing.Size(441, 23);
            this.pgbLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbLoading.TabIndex = 0;
            this.pgbLoading.UseWaitCursor = true;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MusicApp.Properties.Resources.loading;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 188);
            this.Controls.Add(this.pgbLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splashScreen";
            this.UseWaitCursor = true;
            this.Shown += new System.EventHandler(this.SplashScreen_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbLoading;
    }
}