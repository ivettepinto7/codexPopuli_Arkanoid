using System;
using System.Windows.Forms;
using codexPopuli_Arkanoid.Modelo;
using System.Media;

namespace codexPopuli_Arkanoid
{
    public partial class frmTop10 : Form
    {
        private SoundPlayer sound;
        public frmTop10()
        {
            InitializeComponent();
            sound = new SoundPlayer();
            sound.SoundLocation = "C:/Users/ivett/Desktop/CloneProyectoPoo/codexPopuli_Arkanoid/codexPopuli_Arkanoid/Resoruces/MenuSong.wav";
        }

        private void frmTop10_Load(object sender, EventArgs e)
        {
            sound.PlayLooping();
            dgvScoresTop10.DataSource = null;
            dgvScoresTop10.DataSource = ScoreDAO.GetTop10();
        }

        private void bttnSoundOn_Click(object sender, EventArgs e)
        {
            sound.PlayLooping();
        }

        private void bttnSoundOf_Click(object sender, EventArgs e)
        {
            sound.Stop();
        }
    }
}