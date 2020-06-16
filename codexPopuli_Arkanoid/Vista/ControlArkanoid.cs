using System;
using System.Drawing;
using System.Windows.Forms;
using codexPopuli_Arkanoid.Modelo;

namespace codexPopuli_Arkanoid
{
    public partial class ControlArkanoid : UserControl
    {
    private Player player;
            private CustomPictureBox[,]cpb;
            private PictureBox ball;
            private delegate void AccionesPelota();
            private readonly AccionesPelota  MovimientoPelota;
        public ControlArkanoid(Player jug)
        {
            InitializeComponent();
            pcbPlayer.Show();
            MovimientoPelota = RebotarPelota;
            MovimientoPelota += MoverPelota;
            this.player= jug;
            
        }
        private void ControlArkanoid_Load(object sender, EventArgs e)
                {
                    pcbPlayer.BackgroundImage= Image.FromFile("../../img/Player.png");
                    pcbPlayer.BackgroundImageLayout = ImageLayout.Stretch;
                    
                    pcbPlayer.Top = (this.Height - pcbPlayer.Height) - 80; pcbPlayer.Left = (Width/2) - (pcbPlayer.Width/2);
                    
                    ball = new PictureBox();
                    ball.Width= ball.Height= 20;
                    ball.BackgroundImage=Image.FromFile("../../img/Ball.png");
                    ball.BackgroundImageLayout= ImageLayout.Stretch;
        
        
                    ball.Top = pcbPlayer.Top - ball.Height;
                    ball.Left= pcbPlayer.Left + (pcbPlayer.Width/2)- (ball.Width/2);
                    Controls.Add((ball));
                    LoadTiles();
                    timer1.Start();
                }
        
                private void LoadTiles()
                {
                    int xAxis = 10,yAxis = 5;
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
                                cpb[i,j].BackgroundImage= Image.FromFile("../../img/blinded.png");    
                            else
                                cpb[i,j].BackgroundImage= Image.FromFile("../../img/"+ GRN() +".png");
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
        
                private void ControlArkanoid_MouseMove(object sender, MouseEventArgs e)
                {
                    if(!DatosJuego.juegoIniciado){
                        if (e.X < (Width - (pcbPlayer.Width/2)) && e.X > pcbPlayer.Width/2){
                                           pcbPlayer.Left = e.X - (pcbPlayer.Width / 2);
                            ball.Left= pcbPlayer.Left + (pcbPlayer.Width/2) - (ball.Width/2);
                        }
                    }else{
                        if (e.X < (Width - (pcbPlayer.Width/2)) && e.X > pcbPlayer.Width/2)
                            pcbPlayer.Left = e.X - (pcbPlayer.Width / 2);
                                
                    }
                    
                }
        
                private void  ControlArkanoid_KeyDown(object sender, KeyEventArgs e)
                {
                    if(e.KeyCode== Keys.Space)
                        DatosJuego.juegoIniciado= true;
                }
        
                private void Timer1_Tick(object sender, EventArgs e)
                {
                    if (!DatosJuego.juegoIniciado)
                        return;

                    MovimientoPelota?.Invoke();
                }
        
                private void RebotarPelota()
                {
                    if(ball.Bottom >Height)
                        Application.Exit();
                    if(ball.Left<=0||ball.Right>=Width){
                        DatosJuego.dirX= -DatosJuego.dirX;
                        return;
                    }
        
                    if (ball.Bounds.IntersectsWith(pcbPlayer.Bounds))
                    {
                        DatosJuego.dirY = -DatosJuego.dirY;
                    }
                        
                    for (int i = 4; i >= 0; i--)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (ball.Bounds.IntersectsWith(cpb[i, j].Bounds))
                            {
                                cpb[i,j].Golpes--;
                                if (cpb[i, j].Golpes == 0)
                                    Controls.Remove(cpb[i, j]);
                                
                                DatosJuego.dirY= -DatosJuego.dirY;
                            return;
                            }
                        }
                    }
                }

                private void MoverPelota()
                {
                     ball.Left+= DatosJuego.dirX;
                     ball.Top+= DatosJuego.dirY;
                }
    }
}