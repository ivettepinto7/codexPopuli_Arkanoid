using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using codexPopuli_Arkanoid.Modelo;

namespace codexPopuli_Arkanoid
{
    public partial class ControlTop10 : UserControl
    {
    
        private SoundPlayer sound;
        public ControlTop10()
        {
            InitializeComponent();
            
            //Establecer el archivo de audio
            sound = new SoundPlayer();
            sound.SoundLocation = "../../Resources/MenuSong.wav";
            
            this.BackgroundImage = Image.FromFile("../../Resources/fondoTop10.png");
        }
        
        //Poblar el data grid view con los datos de la consulta
        private void ControlTop10_Load(object sender, EventArgs e)
        {
            sound.PlayLooping();
            dgvScoresTop10.DataSource = null;
            dgvScoresTop10.DataSource = ScoreDAO.GetTop10();
        }
        
        //Activar sonido
        private void BttnSoundOn_Click_1(object sender, EventArgs e)
        {
            sound.PlayLooping();
        }

        //Detener sonido
        private void BttnSoundOff_Click(object sender, EventArgs e)
        {
            sound.Stop();
        }
    }
}