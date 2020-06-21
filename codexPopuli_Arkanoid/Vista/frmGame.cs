using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using codexPopuli_Arkanoid.Modelo;

namespace codexPopuli_Arkanoid
{
    public partial class frmGame : Form
    {
        private NewControl currentControl;
        public frmGame()
        {
            InitializeComponent();
            
            //Maximizar pantalla
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            pcbPlayer.Hide();
        }
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        //Verificación para salir de aplicación
        private void frmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", 
                "Arkanoid", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        //cerrar aplicación
        private void frmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //cargar form
        private void frmGame_Load(object sender, EventArgs e)
        {
            //agregar "controlador" para userControl
            currentControl= new ControlMenu();
            currentControl.Dock = DockStyle.Fill;
            Controls.Add(currentControl);
            currentControl.Width = Width;
            currentControl.Height = Height;
        }
        //Método para cambio de userControl
        public void ChangeControl(NewControl newControl) 
        {
            if(newControl == null)
            {
                throw new ArgumentNullException("newControl");
            }
            //remover userControl actual
            if(currentControl != null) 
            { 
                this.Controls.Remove(currentControl);
            }
            //Crear nuevo userControl y definir dimensiones
            currentControl = newControl;
            currentControl.Width = Width;
            currentControl.Height = Height;
            //agregar userControl
            this.Controls.Add(newControl);
        }
        //Método definir userControl a cambiar
        public void ShowControl(NewControl control) 
        {
            //cambiando currentUserControl
            this.ChangeControl(control);
        }
    }
}