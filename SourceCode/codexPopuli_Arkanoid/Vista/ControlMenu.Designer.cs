using System.ComponentModel;

namespace codexPopuli_Arkanoid
{
    partial class ControlMenu
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
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.bttnPlay = new System.Windows.Forms.Button();
            this.bttnScores = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            this.bttnSoundOff = new System.Windows.Forms.Button();
            this.bttnSoundOn = new System.Windows.Forms.Button();
            this.tlpMenu.SuspendLayout();
            this.gpbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMenu
            // 
            this.tlpMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMenu.BackColor = System.Drawing.Color.Transparent;
            this.tlpMenu.ColumnCount = 3;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMenu.Controls.Add(this.bttnPlay, 1, 1);
            this.tlpMenu.Controls.Add(this.bttnScores, 1, 2);
            this.tlpMenu.Controls.Add(this.bttnExit, 1, 3);
            this.tlpMenu.Controls.Add(this.gpbMenu, 0, 0);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenu.Location = new System.Drawing.Point(0, 0);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 4;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMenu.Size = new System.Drawing.Size(800, 461);
            this.tlpMenu.TabIndex = 0;
            // 
            // bttnPlay
            // 
            this.bttnPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnPlay.BackColor = System.Drawing.Color.White;
            this.bttnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnPlay.ForeColor = System.Drawing.Color.Black;
            this.bttnPlay.Location = new System.Drawing.Point(273, 187);
            this.bttnPlay.Name = "bttnPlay";
            this.bttnPlay.Size = new System.Drawing.Size(252, 72);
            this.bttnPlay.TabIndex = 0;
            this.bttnPlay.Text = "JUGAR";
            this.bttnPlay.UseVisualStyleBackColor = false;
            this.bttnPlay.Click += new System.EventHandler(this.BttnPlay_Click);
            // 
            // bttnScores
            // 
            this.bttnScores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnScores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnScores.BackColor = System.Drawing.Color.White;
            this.bttnScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnScores.ForeColor = System.Drawing.Color.Black;
            this.bttnScores.Location = new System.Drawing.Point(269, 279);
            this.bttnScores.Name = "bttnScores";
            this.bttnScores.Size = new System.Drawing.Size(260, 71);
            this.bttnScores.TabIndex = 1;
            this.bttnScores.Text = "PUNTAJES";
            this.bttnScores.UseVisualStyleBackColor = false;
            this.bttnScores.Click += new System.EventHandler(this.BttnScores_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnExit.BackColor = System.Drawing.Color.White;
            this.bttnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnExit.ForeColor = System.Drawing.Color.Red;
            this.bttnExit.Location = new System.Drawing.Point(272, 371);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(254, 60);
            this.bttnExit.TabIndex = 2;
            this.bttnExit.Text = "SALIR";
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.BttnExit_Click);
            // 
            // gpbMenu
            // 
            this.gpbMenu.Controls.Add(this.bttnSoundOff);
            this.gpbMenu.Controls.Add(this.bttnSoundOn);
            this.gpbMenu.ForeColor = System.Drawing.Color.White;
            this.gpbMenu.Location = new System.Drawing.Point(3, 3);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Size = new System.Drawing.Size(121, 52);
            this.gpbMenu.TabIndex = 3;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "Sound";
            // 
            // bttnSoundOff
            // 
            this.bttnSoundOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnSoundOff.ForeColor = System.Drawing.Color.Black;
            this.bttnSoundOff.Location = new System.Drawing.Point(63, 16);
            this.bttnSoundOff.Name = "bttnSoundOff";
            this.bttnSoundOff.Size = new System.Drawing.Size(52, 30);
            this.bttnSoundOff.TabIndex = 1;
            this.bttnSoundOff.Text = "OFF";
            this.bttnSoundOff.UseVisualStyleBackColor = true;
            this.bttnSoundOff.Click += new System.EventHandler(this.BttnSoundOff_Click);
            // 
            // bttnSoundOn
            // 
            this.bttnSoundOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnSoundOn.ForeColor = System.Drawing.Color.Black;
            this.bttnSoundOn.Location = new System.Drawing.Point(6, 16);
            this.bttnSoundOn.Name = "bttnSoundOn";
            this.bttnSoundOn.Size = new System.Drawing.Size(51, 30);
            this.bttnSoundOn.TabIndex = 0;
            this.bttnSoundOn.Text = "ON";
            this.bttnSoundOn.UseVisualStyleBackColor = true;
            this.bttnSoundOn.Click += new System.EventHandler(this.BttnSoundOn_Click);
            // 
            // ControlMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tlpMenu);
            this.Name = "ControlMenu";
            this.Size = new System.Drawing.Size(800, 461);
            this.Load += new System.EventHandler(this.ControlMenu_Load);
            this.tlpMenu.ResumeLayout(false);
            this.gpbMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnPlay;
        private System.Windows.Forms.Button bttnScores;
        private System.Windows.Forms.Button bttnSoundOff;
        private System.Windows.Forms.Button bttnSoundOn;
        private System.Windows.Forms.GroupBox gpbMenu;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;

        #endregion
    }
}