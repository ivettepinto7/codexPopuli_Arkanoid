using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using codexPopuli_Arkanoid.Modelo;

namespace codexPopuli_Arkanoid
{
    public partial class frmGame : Form
    {
        //private Player player;
        private CustomPictureBox[,]cpb;
        private PictureBox ball;
        public frmGame(/*Player player*/)
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            //this.player = player;
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

        private void frmGame_Load(object sender, EventArgs e)
        {
            pcbPlayer.BackgroundImage= Image.FromFile("../../img/Player.png");
            pcbPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            
            pcbPlayer.Top = (Height - pcbPlayer.Height) - 80; pcbPlayer.Left = (Width/2) - (pcbPlayer.Width/2);
            
            ball = new PictureBox();
            ball.Width= ball.Height= 20;
            ball.BackgroundImage=Image.FromFile("../../Img/Ball.png");
            ball.BackgroundImageLayout= ImageLayout.Stretch;


            ball.Top = pcbPlayer.Top - ball.Height;
            ball.Left= pcbPlayer.Left + (pcbPlayer.Width/2)- (ball.Width/2);
            LoadTiles();
        }

        private void LoadTiles()
        {
            int xAxis = 10;
            int yAxis = 5;
            int pbHeight = (int)(Height * 0.3)/yAxis;
            int pbWidth = (Width-(xAxis-5))/xAxis;
            
            cpb = new CustomPictureBox[yAxis , xAxis];
            for(int i =0; i<yAxis;i++){
                for (int j = 0; j < xAxis; j++)
                {
                    cpb[i,j]= new CustomPictureBox();
                    
                    if (i == 0)
                        cpb[i, j].Golpes = 2;
                    else
                        cpb[i, j].Golpes = 1;
                    cpb[i,j].Height= pbHeight;
                    cpb[i,j].Width= pbWidth;
                    
                    //posiciones
                    cpb[i,j].Left= j*pbWidth;
                    cpb[i,j].Top= i*pbHeight;

                    if (i==1)
                        cpb[i,j].BackgroundImage= Image.FromFile("../../Img/blinded.png");    
                    else
                        cpb[i,j].BackgroundImage= Image.FromFile("../../Img/"+ GRN() +".png");
                    cpb[i,j].BackgroundImageLayout= ImageLayout.Stretch;
                    cpb[i,j].Tag="tileTag";
                    
                    Controls.Add(cpb[i,j]);

                }
            }
        }

        private int GRN()
        {
            return new Random().Next(1,8);
        }

        private void frmGame_MouseMove(object sender, MouseEventArgs e)
        {
            if(!DatosJuego.juegoIniciado){
                if (e.X < Width - pcbPlayer.Width)
                {
                    pcbPlayer = e.X;
                    ball
                }
            }else{
                if (e.X < (Width - (pcbPlayer.Width/2)) && e.X > pcbPlayer.Width/2)
                                pcbPlayer.Left = e.X - (pcbPlayer.Width / 2);
                        
            }
            
        }
    }
}