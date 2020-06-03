using System;
using System.Windows.Forms;
using codexPopuli_Arkanoid.Modelo;

namespace codexPopuli_Arkanoid
{
    public partial class frmPlayer : Form
    {
        public frmPlayer()
        {
            InitializeComponent();
        }
        
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
                    MessageBox.Show("Todo listo para jugar!", "Arkanoid",
                        MessageBoxButtons.OK);
                    frmGame juego = new frmGame(player);
                    juego.Show();
                    this.Hide();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("El usuario no existe");
            }
        }
        
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
    }
}