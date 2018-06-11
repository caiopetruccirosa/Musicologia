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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.LblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.BackColor = System.Drawing.Color.Transparent;
            this.LblNome.Font = new System.Drawing.Font("Mistral", 56F);
            this.LblNome.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.LblNome.Location = new System.Drawing.Point(1, 1);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(521, 185);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Musicologia";
            this.LblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblNome.UseWaitCursor = true;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(523, 187);
            this.Controls.Add(this.LblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splashScreen";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label LblNome;
    }
}