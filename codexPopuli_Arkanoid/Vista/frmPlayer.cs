using System;
using System.Media;
using System.Windows.Forms;
using codexPopuli_Arkanoid.Modelo;

namespace codexPopuli_Arkanoid
{
    public partial class frmPlayer : Form
    {
        //private Player player;
        private SoundPlayer sound;
        public frmPlayer(/*Player player*/)
        {
            InitializeComponent();
            
            //Maximizar pantalla
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            
            //Establecer archivo de audio
            sound = new SoundPlayer();
            sound.SoundLocation = "../../Resources/MenuSong.wav";
        }                    
        
        //Si el nombre existe en la BD empezar juego
        private void bttnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                var player = PlayerDAO.GetPlayer(txtNickname.Text);
                if (player.nickname.Equals(""))
                {
                    MessageBox.Show("Verifique los datos ingresados",
                        "Arkanoid", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"Todo listo para jugar {player.nickname}!", "Arkanoid",
                        MessageBoxButtons.OK);
                    frmGame juego = new frmGame(player);
                    juego.ShowDialog();
                    this.Hide();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un error", 
                    "Arkanoid", MessageBoxButtons.OK);
            }
        }


        //Si el nombre no existe en la BD crear jugador
        private void bttnAddPlayer_Click(object sender, EventArgs e)
        {
            if (txtNickname.Text.Length >= 5)
            {
                PlayerDAO.CreatePlayer(txtNickname.Text);
            }
            else
                MessageBox.Show(
                    "Ha ocurrido un error");
        }

        //Activar sonido
        private void bttnSoundOn_Click(object sender, EventArgs e)
        {
            sound.PlayLooping();
        }

        //Detener sonido
        private void bttnSoundOff_Click(object sender, EventArgs e)
        {
            sound.Stop();
        }
        
        private void frmPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", 
                "Arkanoid", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}