using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using codexPopuli_Arkanoid.Properties;

namespace codexPopuli_Arkanoid
{
    public partial class Form1 : Form
    {
        private SoundPlayer sound;
        public Form1()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            sound = new SoundPlayer();
            sound.SoundLocation = "./Resources/MenuSong.wav";
        }

        private void bttnPlay_Click(object sender, EventArgs e)
        {
            frmPlayer Player = new frmPlayer();
            this.Hide();
            Player.ShowDialog();
        }
        
        private void bttnScores_Click(object sender, EventArgs e)
        {
            sound.Stop();
            frmTop10 top = new frmTop10();
            top.Show();
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", 
                "Arkanoid", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sound.PlayLooping();
            
        }

        private void bttnSoundOn_Click(object sender, EventArgs e)
        {
            sound.Play();
            sound.PlayLooping();
        }

        private void bttnSoundOf_Click(object sender, EventArgs e)
        {
            sound.Stop();
        }
    }
}