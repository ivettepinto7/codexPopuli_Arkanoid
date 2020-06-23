using System.ComponentModel;

namespace codexPopuli_Arkanoid
{
    partial class ControlPlayer
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
            this.tlpPlayer = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.bttnAddPlayer = new System.Windows.Forms.Button();
            this.bttnPlay = new System.Windows.Forms.Button();
            this.gpbPlayer = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.bttnSoundOff = new System.Windows.Forms.Button();
            this.bttnSoundOn = new System.Windows.Forms.Button();
            this.tlpPlayer.SuspendLayout();
            this.gpbPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPlayer
            // 
            this.tlpPlayer.BackColor = System.Drawing.Color.Transparent;
            this.tlpPlayer.ColumnCount = 3;
            this.tlpPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpPlayer.Controls.Add(this.lblPlayer, 1, 0);
            this.tlpPlayer.Controls.Add(this.txtNickname, 1, 1);
            this.tlpPlayer.Controls.Add(this.bttnAddPlayer, 1, 2);
            this.tlpPlayer.Controls.Add(this.bttnPlay, 2, 2);
            this.tlpPlayer.Controls.Add(this.gpbPlayer, 0, 0);
            this.tlpPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlayer.Location = new System.Drawing.Point(0, 0);
            this.tlpPlayer.Name = "tlpPlayer";
            this.tlpPlayer.RowCount = 3;
            this.tlpPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpPlayer.Size = new System.Drawing.Size(800, 450);
            this.tlpPlayer.TabIndex = 0;
            // 
            // lblPlayer
            // 
            this.tlpPlayer.SetColumnSpan(this.lblPlayer, 2);
            this.lblPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.White;
            this.lblPlayer.Location = new System.Drawing.Point(163, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(634, 150);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "USUARIO";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNickname
            // 
            this.txtNickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpPlayer.SetColumnSpan(this.txtNickname, 2);
            this.txtNickname.Location = new System.Drawing.Point(346, 215);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(268, 20);
            this.txtNickname.TabIndex = 1;
            // 
            // bttnAddPlayer
            // 
            this.bttnAddPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnAddPlayer.BackColor = System.Drawing.Color.White;
            this.bttnAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnAddPlayer.Location = new System.Drawing.Point(196, 340);
            this.bttnAddPlayer.Name = "bttnAddPlayer";
            this.bttnAddPlayer.Size = new System.Drawing.Size(248, 69);
            this.bttnAddPlayer.TabIndex = 2;
            this.bttnAddPlayer.Text = "AGREGAR";
            this.bttnAddPlayer.UseVisualStyleBackColor = false;
            this.bttnAddPlayer.Click += new System.EventHandler(this.BttnAddPlayer_Click);
            // 
            // bttnPlay
            // 
            this.bttnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnPlay.BackColor = System.Drawing.Color.White;
            this.bttnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnPlay.Location = new System.Drawing.Point(516, 340);
            this.bttnPlay.Name = "bttnPlay";
            this.bttnPlay.Size = new System.Drawing.Size(248, 69);
            this.bttnPlay.TabIndex = 3;
            this.bttnPlay.Text = "JUGAR";
            this.bttnPlay.UseVisualStyleBackColor = false;
            this.bttnPlay.Click += new System.EventHandler(this.BttnPlay_Click);
            // 
            // gpbPlayer
            // 
            this.gpbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.gpbPlayer.Controls.Add(this.btnReturn);
            this.gpbPlayer.Controls.Add(this.bttnSoundOff);
            this.gpbPlayer.Controls.Add(this.bttnSoundOn);
            this.gpbPlayer.ForeColor = System.Drawing.Color.White;
            this.gpbPlayer.Location = new System.Drawing.Point(3, 3);
            this.gpbPlayer.Name = "gpbPlayer";
            this.gpbPlayer.Size = new System.Drawing.Size(127, 118);
            this.gpbPlayer.TabIndex = 5;
            this.gpbPlayer.TabStop = false;
            this.gpbPlayer.Text = "Sound";
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(20, 61);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(94, 33);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Regresar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            // ControlPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tlpPlayer);
            this.Name = "ControlPlayer";
            this.Size = new System.Drawing.Size(800, 450);
            this.tlpPlayer.ResumeLayout(false);
            this.tlpPlayer.PerformLayout();
            this.gpbPlayer.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button bttnAddPlayer;
        private System.Windows.Forms.Button bttnPlay;
        private System.Windows.Forms.Button bttnSoundOff;
        private System.Windows.Forms.Button bttnSoundOn;
        private System.Windows.Forms.GroupBox gpbPlayer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.TableLayoutPanel tlpPlayer;
        private System.Windows.Forms.TextBox txtNickname;

        #endregion
    }
}