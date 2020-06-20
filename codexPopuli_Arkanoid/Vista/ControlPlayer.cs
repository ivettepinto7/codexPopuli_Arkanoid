﻿using System;
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
            this.BackgroundImage = Image.FromFile("../../Resources/fondoUsuario.png");
        }
        
        //Si el nombre existe en la BD empezar juego.
        private void BttnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                var player = PlayerDAO.GetPlayer(txtNickname.Text);
                if (player.nickname.Equals(""))
                {
                    MessageBox.Show("El usuario no se encuentra registrado\n Presione agregar.",
                        "Arkanoid", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"Todo listo para jugar {player.nickname}!", "Arkanoid",
                        MessageBoxButtons.OK);
                    ControlArkanoid cont = new ControlArkanoid(player);
                    this.ActiveControl = null;
                    ((frmGame)this.Parent).ShowControl(cont);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un error "+exception.Message, 
                    "Arkanoid", MessageBoxButtons.OK);
            }
        }

        //Si el nombre no existe en la BD crear jugador
        private void BttnAddPlayer_Click(object sender, EventArgs e)
        {
            if (txtNickname.Text.Length >= 3)
            {
                try
                {
                    PlayerDAO.CreatePlayer(txtNickname.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("El usuario ya existe! "+exception.Message, 
                        "Arkanoid", MessageBoxButtons.OK);
                    throw;
                }
            }
            else
                MessageBox.Show(
                    "Coloque un nickname válido.","Arkanoid", MessageBoxButtons.OK);
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