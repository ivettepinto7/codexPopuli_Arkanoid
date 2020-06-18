using System;
using System.Drawing;
using System.Windows.Forms;
using codexPopuli_Arkanoid.Modelo;

namespace codexPopuli_Arkanoid
{
    public partial class ControlArkanoid : UserControl
    {
        private Player player;
        private Panel scoreLifePanel = new Panel();
        private CustomPictureBox[,]cpb;
        private PictureBox ball;// = new PictureBox();
        private PictureBox[] hearts = new PictureBox[3];
        private Label lblScore = new Label();
        private delegate void BallActions();
        private readonly BallActions  BallMovment;
        
        public ControlArkanoid(Player jug)
        {
            InitializeComponent();
            BallMovment = BounceBall;
            BallMovment += MoveBall;
            this.player= jug;
        }
        
        private void ControlArkanoid_Load(object sender, EventArgs e)
        {
            LoadPlayer();
            LoadBall();
            LoadTiles();
            LoadPanel();
        }

        private void LoadPlayer()
        {
            cpbPlayer.Show();
            cpbPlayer.BackgroundImage= Image.FromFile("../../img/Player.png");
            cpbPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            cpbPlayer.Top = (this.Height - cpbPlayer.Height) - 80; cpbPlayer.Left = (Width/2) - (cpbPlayer.Width/2);
        }
        
        private void LoadBall()
        {
            ball = new PictureBox();
            ball.Width= ball.Height= 20;
            ball.BackgroundImage=Image.FromFile("../../img/Ball.png");
            ball.BackgroundImageLayout= ImageLayout.Stretch;
            
            ball.Top = cpbPlayer.Top - ball.Height;
            ball.Left= cpbPlayer.Left + (cpbPlayer.Width/2)- (ball.Width/2);
            Controls.Add((ball));
        }

        //Funcion encargada de lo contenido en el panel, panel, corazones y puntaje
        private void LoadPanel()
        {
            scoreLifePanel = new Panel();
            scoreLifePanel.BackColor = Color.CadetBlue;
            scoreLifePanel.ForeColor = Color.Black;
            scoreLifePanel.Width = Width;
            scoreLifePanel.Height = (int) (Height * 0.08);
            scoreLifePanel.Top = scoreLifePanel.Left = 0;
            
            Controls.Add(scoreLifePanel);

            for (int i = 0; i < GameData.Lifes; i++)
            {
                hearts[i] = new PictureBox();
                hearts[i].BackgroundImage = Image.FromFile("../../img/Heart.png");
                hearts[i].BackgroundImageLayout = ImageLayout.Stretch;
                hearts[i].Width = hearts[i].Height = 40;
                hearts[i].Top = scoreLifePanel.Top + (hearts[0].Height / 4);
                switch (i)
                {
                    case 0:
                        hearts[0].Left = Width / 2 - 60;
                        break;
                    case 1:
                        hearts[1].Left = Width / 2 - 20;
                        break;
                    case 2:
                        hearts[2].Left = Width / 2 + 20;
                        break;
                }
                hearts[i].Tag = "heartTag";
                
                scoreLifePanel.Controls.Add(hearts[i]);
            }
            
            lblScore = new Label();
            lblScore.ForeColor = Color.White;
            lblScore.Text = GameData.GameScore.ToString();
            lblScore.Font = new Font("Carlito" , 25f);
            lblScore.Left = Width - 100;
            lblScore.Height = scoreLifePanel.Height;
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            
            scoreLifePanel.Controls.Add(lblScore);
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
                        cpb[i, j].Hits = 2;
                    else
                        cpb[i, j].Hits = 1;
                    cpb[i,j].Height= pbHeight;
                    cpb[i,j].Width= pbWidth;
                                
                    //posiciones
                    cpb[i,j].Left= j*pbWidth;
                    cpb[i,j].Top= i*pbHeight + (int) (Height * 0.1);
            
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
            if(!GameData.GameStarted)
            {
                if (e.X < (Width - (cpbPlayer.Width/2)) && e.X > cpbPlayer.Width/2)
                {
                    cpbPlayer.Left = e.X - (cpbPlayer.Width / 2);
                    ball.Left= cpbPlayer.Left + (cpbPlayer.Width/2) - (ball.Width/2);
                }
            }
            else
            {
                if (e.X < (Width - (cpbPlayer.Width/2)) && e.X > cpbPlayer.Width/2)
                    cpbPlayer.Left = e.X - (cpbPlayer.Width / 2);
            }
        }
        
        private void  ControlArkanoid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                GameData.GameStarted = true;
                timer1.Start();
            }
        }
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!GameData.GameStarted)
                return;

            BallMovment?.Invoke();
        }
        
        private void BounceBall()
        {
            if (ball.Top < 0)
            {
                GameData.DirY = -GameData.DirY;
            }
            
            if (ball.Bottom > Height)
            {
                GameData.Lifes--;
                scoreLifePanel.Controls.Remove(hearts[GameData.Lifes]);
                GameData.GameStarted = false;
                timer1.Stop();
                //pcbPlayer.Hide();
                LifeCheck();
            }
            
            if(ball.Left<=0||ball.Right>=Width){
                GameData.DirX= -GameData.DirX;
                return;
            }
            
            if (ball.Bounds.IntersectsWith(cpbPlayer.Bounds))
            {
                GameData.DirY = -GameData.DirY;
            }
                            
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (cpb[i,j] != null && ball.Bounds.IntersectsWith(cpb[i, j].Bounds))
                    {
                        cpb[i,j].Hits--;
                        
                        if(cpb[i,j].Hits == 0)
                        {
                            Controls.Remove(cpb[i, j]);
                            cpb[i, j] = null;
                            GameData.GameScore += 3;
                            lblScore.Text = GameData.GameScore.ToString();
                        }
                        
                                    
                        GameData.DirY= -GameData.DirY;
                        return;
                    }
                }
            }
        }

        private void MoveBall()
        {
            ball.Left+= GameData.DirX;
            ball.Top+= GameData.DirY;
        }

        private void LifeCheck()
        {
            if (GameData.Lifes == 0)
            {
                Application.Exit();
            }
            else
            {
                LoadPlayer();
                LoadBall();
            }
        }
    }
}