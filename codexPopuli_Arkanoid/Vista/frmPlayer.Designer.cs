using System.ComponentModel;

namespace codexPopuli_Arkanoid
{
    partial class frmPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayer));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.bttnAddPlayer = new System.Windows.Forms.Button();
            this.bttnPlay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnSoundOff = new System.Windows.Forms.Button();
            this.bttnSoundOn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNickname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bttnAddPlayer, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttnPlay, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(163, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 150);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNickname
            // 
            this.txtNickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtNickname, 2);
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
            this.bttnAddPlayer.Click += new System.EventHandler(this.bttnAddPlayer_Click);
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
            this.bttnPlay.Click += new System.EventHandler(this.bttnPlay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bttnSoundOff);
            this.groupBox1.Controls.Add(this.bttnSoundOn);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 144);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sound";
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
            this.bttnSoundOff.Click += new System.EventHandler(this.bttnSoundOff_Click);
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
            this.bttnSoundOn.Click += new System.EventHandler(this.bttnSoundOn_Click);
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlayer";
            this.Text = "frmPlayer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPlayer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPlayer_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bttnAddPlayer;
        private System.Windows.Forms.Button bttnPlay;
        private System.Windows.Forms.Button bttnSoundOff;
        private System.Windows.Forms.Button bttnSoundOn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtNickname;

        #endregion
    }
}