using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using codexPopuli_Arkanoid.Modelo;

namespace codexPopuli_Arkanoid
{
    public partial class frmGame : Form
    {
        private Control currentControl;
        public frmGame()
        {
            InitializeComponent();
            
            //Maximizar pantalla
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            //this.player = player;
            pcbPlayer.Hide();
        }
        
        private void frmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", 
                "Arkanoid", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void frmGame_Load(object sender, EventArgs e)
        {
            currentControl= new ControlMenu();
            currentControl.Dock = DockStyle.Fill;
            Controls.Add(currentControl);
            currentControl.Width = Width;
            currentControl.Height = Height;
        }
        
        public void ChangeControl(Control newControl) 
        {
            if(newControl == null)
            {
                throw new ArgumentNullException("newControl");
            }
            
            if(currentControl != null) 
            { 
                this.Controls.Remove(currentControl);
            }
            currentControl = newControl;
            currentControl.Width = Width;
            currentControl.Height = Height;
            this.Controls.Add(newControl);
        }
        
        public void ShowControl(UserControl control) 
        {
            //cambiando currectUserControl
            this.ChangeControl(control);
        }
    }
}