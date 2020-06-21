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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnPlay = new System.Windows.Forms.Button();
            this.bttnScores = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnSoundOf = new System.Windows.Forms.Button();
            this.bttnSoundOn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.bttnPlay, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bttnScores, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttnExit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 461);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttnSoundOf);
            this.groupBox1.Controls.Add(this.bttnSoundOn);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sound";
            // 
            // bttnSoundOf
            // 
            this.bttnSoundOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnSoundOf.ForeColor = System.Drawing.Color.Black;
            this.bttnSoundOf.Location = new System.Drawing.Point(63, 16);
            this.bttnSoundOf.Name = "bttnSoundOf";
            this.bttnSoundOf.Size = new System.Drawing.Size(52, 30);
            this.bttnSoundOf.TabIndex = 1;
            this.bttnSoundOf.Text = "OFF";
            this.bttnSoundOf.UseVisualStyleBackColor = true;
            this.bttnSoundOf.Click += new System.EventHandler(this.BttnSoundOf_Click);
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
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ControlMenu";
            this.Size = new System.Drawing.Size(800, 461);
            this.Load += new System.EventHandler(this.ControlMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnPlay;
        private System.Windows.Forms.Button bttnScores;
        private System.Windows.Forms.Button bttnSoundOf;
        private System.Windows.Forms.Button bttnSoundOn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}