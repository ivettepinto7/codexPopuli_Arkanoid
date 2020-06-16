﻿using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace codexPopuli_Arkanoid
{
    public partial class ControlMenu : UserControl
    {
        private SoundPlayer sound;
        public ControlMenu()
        {
            InitializeComponent();
            
            //Establecer el archivo de audio
            sound = new SoundPlayer();
            sound.SoundLocation = "../../Resources/MenuSong.wav";
            this.BackgroundImage = Image.FromFile("../../Resources/MenuPrincipal.png");
        }
        //Boton que abre una ventana para ingresar usuario y jugar
        private void BttnPlay_Click(object sender, EventArgs e)
        {
            ControlPlayer Player = new ControlPlayer();
            ((frmGame)this.Parent).ShowControl(Player);

        }
        private void BttnScores_Click(object sender, EventArgs e)
        {
                    sound.Stop();
                    ControlTop10 top = new ControlTop10();
                    ((frmGame)this.Parent).ShowControl(top);
        }
        private void BttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ControlMenu_Load(object sender, EventArgs e)
                {
                    sound.PlayLooping();
                    
                }
        
                //Boton que reproduce la música
                private void BttnSoundOn_Click(object sender, EventArgs e)
                {
                    sound.Play();
                    sound.PlayLooping();
                }
        
                //Boton que detiene la música
                private void BttnSoundOf_Click(object sender, EventArgs e)
                {
                    sound.Stop();
                }
    }
}