namespace MusicApp
{
    partial class TrocaDeSenha
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
            this.lbNome = new System.Windows.Forms.Label();
            this.plName = new System.Windows.Forms.Panel();
            this.plName.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("PanRoman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbNome.Location = new System.Drawing.Point(107, 9);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(193, 35);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Musicologia";
            // 
            // plName
            // 
            this.plName.BackColor = System.Drawing.SystemColors.Highlight;
            this.plName.Controls.Add(this.lbNome);
            this.plName.Dock = System.Windows.Forms.DockStyle.Top;
            this.plName.Location = new System.Drawing.Point(0, 0);
            this.plName.Name = "plName";
            this.plName.Size = new System.Drawing.Size(384, 59);
            this.plName.TabIndex = 4;
            // 
            // TrocaDeSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 312);
            this.Controls.Add(this.plName);
            this.Name = "TrocaDeSenha";
            this.Text = "TrocaDeSenha";
            this.plName.ResumeLayout(false);
            this.plName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Panel plName;
    }
}