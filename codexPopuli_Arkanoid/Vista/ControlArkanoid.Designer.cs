using System.ComponentModel;

namespace codexPopuli_Arkanoid
{
    partial class ControlArkanoid
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
            this.components = new System.ComponentModel.Container();
            this.cpbPlayer = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.cpbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // cpbPlayer
            // 
            this.cpbPlayer.Location = new System.Drawing.Point(22, 397);
            this.cpbPlayer.Name = "cpbPlayer";
            this.cpbPlayer.Size = new System.Drawing.Size(162, 32);
            this.cpbPlayer.TabIndex = 0;
            this.cpbPlayer.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ControlArkanoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.cpbPlayer);
            this.Name = "ControlArkanoid";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.ControlArkanoid_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlArkanoid_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlArkanoid_MouseMove);
            ((System.ComponentModel.ISupportInitialize) (this.cpbPlayer)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox cpbPlayer;
        private System.Windows.Forms.Timer timer1;

        #endregion
    }
}