using System.ComponentModel;

namespace codexPopuli_Arkanoid
{
    partial class ControlTop10
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttnSoundOff = new System.Windows.Forms.Button();
            this.bttnSoundOn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvScoresTop10 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvScoresTop10)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvScoresTop10, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(407, 428);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttnSoundOff);
            this.groupBox1.Controls.Add(this.bttnSoundOn);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 52);
            this.groupBox1.TabIndex = 4;
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
            this.bttnSoundOn.Click += new System.EventHandler(this.BttnSoundOn_Click_1);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 64);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOP 10";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvScoresTop10
            // 
            this.dgvScoresTop10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScoresTop10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvScoresTop10.GridColor = System.Drawing.Color.Cyan;
            this.dgvScoresTop10.Location = new System.Drawing.Point(3, 131);
            this.dgvScoresTop10.Name = "dgvScoresTop10";
            this.dgvScoresTop10.Size = new System.Drawing.Size(401, 294);
            this.dgvScoresTop10.TabIndex = 6;
            // 
            // ControlTop10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "ControlTop10";
            this.Size = new System.Drawing.Size(407, 428);
            this.Load += new System.EventHandler(this.ControlTop10_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvScoresTop10)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bttnSoundOff;
        private System.Windows.Forms.Button bttnSoundOn;
        private System.Windows.Forms.DataGridView dgvScoresTop10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}