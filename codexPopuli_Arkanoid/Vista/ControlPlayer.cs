using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using codexPopuli_Arkanoid.Modelo;

namespace codexPopuli_Arkanoid
{
    public partial class ControlPlayer : NewControl
    {
        //private Player player;
        private SoundPlayer sound;
        public ControlPlayer()
        {
            InitializeComponent();
            //Establecer archivo de audio
            sound = new SoundPlayer();
            sound.SoundLocation = "../../Resources/MenuSong.wav";
            //Establecer fondo de pantalla
            this.BackgroundImage = Image.FromFile("../../Resources/fondoUsuario.png");
        }
        
        //boton para iniciar juego.
        private void BttnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtener datos de usuario
                var player = PlayerDAO.GetPlayer(txtNickname.Text);
                //Verificar si el usuario existe
                if (player.nickname.Equals(""))
                    throw new UserNotFoundException("El usuario no se encuentra registrado\n Presione agregar.");
                else
                {
                    MessageBox.Show($"Todo listo para jugar {player.nickname}!", "Arkanoid",
                        MessageBoxButtons.OK);
                    ControlArkanoid cont = new ControlArkanoid(player);
                    this.ActiveControl = null;
                    ((frmGame)this.Parent).ShowControl(cont);
                }
            }
            //capturar excepción
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, 
                    "Arkanoid", MessageBoxButtons.OK);
            }
        }

        //Boton crear usuario
        private void BttnAddPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificar formato correcto del nickname
                switch (txtNickname.Text)
                {
                    case string aux when aux.Length > 15:
                        throw new ExceededMaxCharactersException("No se puede introducir un nick de mas de 15 car");
                    case string aux when aux.Trim().Length ==0:
                        throw new EmptyNicknameException("Necesita ingresar un Nickname");
                    case string aux when aux.Trim().Length <3:
                        throw new InvalidNicknameFormatException("Nickname de 3 letras o más");
                    default:
                        PlayerDAO.CreatePlayer(txtNickname.Text);
                        break;
                }

            }
            //Capturar excepciones
            catch(InvalidNicknameFormatException ex)
            {
                MessageBox.Show(ex.Message, 
                    "Arkanoid", MessageBoxButtons.OK);
            }
            catch(ExceededMaxCharactersException ex)
            {
                MessageBox.Show(ex.Message, 
                    "Arkanoid", MessageBoxButtons.OK);
            }
            catch(EmptyNicknameException ex)
            {
                MessageBox.Show(ex.Message, 
                    "Arkanoid", MessageBoxButtons.OK);
            }
            
            
        }

        //Activar sonido
        private void BttnSoundOn_Click(object sender, EventArgs e)
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