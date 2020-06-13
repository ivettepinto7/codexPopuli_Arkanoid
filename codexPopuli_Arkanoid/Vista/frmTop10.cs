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
            Height = ClientSize.Height;
                        Width = ClientSize.Width;
                        WindowState = FormWindowState.Maximized;
            sound = new SoundPlayer();
            sound.SoundLocation = "../../Resources/MenuSong.wav";
        }

        private void frmTop10_Load(object sender, EventArgs e)
        {
            sound.PlayLooping();
            dgvScoresTop10.DataSource = null;
            dgvScoresTop10.DataSource = ScoreDAO.GetTop10();
        }
        
        private void bttnSoundOn_Click_1(object sender, EventArgs e)
                {
                    sound.PlayLooping();
                }

        private void bttnSoundOff_Click(object sender, EventArgs e)
        {
            sound.Stop();
        }
    }
}