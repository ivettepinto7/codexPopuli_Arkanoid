using System.ComponentModel;

namespace codexPopuli_Arkanoid
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.pcbPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pcbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbPlayer
            // 
            this.pcbPlayer.Location = new System.Drawing.Point(22, 397);
            this.pcbPlayer.Name = "pcbPlayer";
            this.pcbPlayer.Size = new System.Drawing.Size(162, 32);
            this.pcbPlayer.TabIndex = 0;
            this.pcbPlayer.TabStop = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcbPlayer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGame";
            this.Text = "frmGame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmGame_MouseMove);
            ((System.ComponentModel.ISupportInitialize) (this.pcbPlayer)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pcbPlayer;

        #endregion
    }
}