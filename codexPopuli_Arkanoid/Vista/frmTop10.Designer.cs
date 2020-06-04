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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvScoresTop10 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.dgvScoresTop10)).BeginInit();
            this.SuspendLayout();
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("AR DARLING", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOP 10";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dgvScoresTop10.BackgroundColor = System.Drawing.Color.Red;
            this.dgvScoresTop10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScoresTop10.Location = new System.Drawing.Point(65, 118);
            this.dgvScoresTop10.Name = "dgvScoresTop10";
            this.dgvScoresTop10.Size = new System.Drawing.Size(249, 268);
            this.dgvScoresTop10.TabIndex = 1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.dgvScoresTop10);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTop10";
            this.Text = "frmTop10";
            this.Load += new System.EventHandler(this.frmTop10_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dgvScoresTop10)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvScoresTop10;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}