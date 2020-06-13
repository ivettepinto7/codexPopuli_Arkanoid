using System;
using System.Media;
using System.Windows.Forms;

namespace codexPopuli_Arkanoid
{
    public partial class Form1 : Form
    {
        private SoundPlayer sound;
        public Form1()
        {
            InitializeComponent();
            
            //Maximizar pantalla
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized; 
            
            //Establecer el archivo de audio
            sound = new SoundPlayer();
            sound.SoundLocation = "../../Resources/MenuSong.wav";
        }
        
        //Boton que abre una ventana para ingresar usuario y jugar
        private void bttnPlay_Click(object sender, EventArgs e)
        {
            frmPlayer Player = new frmPlayer();
            this.Hide();
            Player.ShowDialog();
        }
        
        //Boton que muestra el Top 10 de los puntajes
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

        //Boton que reproduce la música
        private void bttnSoundOn_Click(object sender, EventArgs e)
        {
            sound.Play();
            sound.PlayLooping();
        }

        //Boton que detiene la música
        private void bttnSoundOf_Click(object sender, EventArgs e)
        {
            sound.Stop();
        }
    }
}