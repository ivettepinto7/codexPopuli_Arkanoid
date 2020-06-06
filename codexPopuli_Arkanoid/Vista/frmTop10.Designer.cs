using System.ComponentModel;

namespace codexPopuli_Arkanoid
{
    partial class frmTop10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTop10));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvScoresTop10 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnSoundOff = new System.Windows.Forms.Button();
            this.bttnSoundOn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dgvScoresTop10)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("AR DARLING", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOP 10";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvScoresTop10
            // 
            this.dgvScoresTop10.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvScoresTop10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScoresTop10.Location = new System.Drawing.Point(85, 117);
            this.dgvScoresTop10.Name = "dgvScoresTop10";
            this.dgvScoresTop10.Size = new System.Drawing.Size(249, 268);
            this.dgvScoresTop10.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bttnSoundOff);
            this.groupBox1.Controls.Add(this.bttnSoundOn);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sound";
            // 
            // bttnSoundOff
            // 
            this.bttnSoundOff.Font = new System.Drawing.Font("AR DARLING", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnSoundOff.ForeColor = System.Drawing.Color.Black;
            this.bttnSoundOff.Location = new System.Drawing.Point(63, 16);
            this.bttnSoundOff.Name = "bttnSoundOff";
            this.bttnSoundOff.Size = new System.Drawing.Size(52, 30);
            this.bttnSoundOff.TabIndex = 1;
            this.bttnSoundOff.Text = "OFF";
            this.bttnSoundOff.UseVisualStyleBackColor = true;
            this.bttnSoundOff.Click += new System.EventHandler(this.bttnSoundOf_Click);
            // 
            // bttnSoundOn
            // 
            this.bttnSoundOn.Font = new System.Drawing.Font("AR DARLING", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bttnSoundOn.ForeColor = System.Drawing.Color.Black;
            this.bttnSoundOn.Location = new System.Drawing.Point(6, 16);
            this.bttnSoundOn.Name = "bttnSoundOn";
            this.bttnSoundOn.Size = new System.Drawing.Size(51, 30);
            this.bttnSoundOn.TabIndex = 0;
            this.bttnSoundOn.Text = "ON";
            this.bttnSoundOn.UseVisualStyleBackColor = true;
            this.bttnSoundOn.Click += new System.EventHandler(this.bttnSoundOn_Click);
            // 
            // frmTop10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvScoresTop10);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTop10";
            this.Text = "frmTop10";
            this.Load += new System.EventHandler(this.frmTop10_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dgvScoresTop10)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bttnSoundOff;
        private System.Windows.Forms.Button bttnSoundOn;
        private System.Windows.Forms.DataGridView dgvScoresTop10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}