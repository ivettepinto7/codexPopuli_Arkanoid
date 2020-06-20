using System;
using System.Drawing;
using System.Windows.Forms;
using codexPopuli_Arkanoid.Modelo;

namespace codexPopuli_Arkanoid
{
    public partial class ControlArkanoid : NewControl
    {
        private Player player;
        private Panel scoreLifePanel;
        private CustomPictureBox[,]cpb;
        private PictureBox ball;
        private PictureBox[] hearts;
        private Label lblScore;
        private delegate void BallActions();
        private readonly BallActions  BallMovement;
        
        public ControlArkanoid(Player jug)
        {
            InitializeComponent();
            BallMovement = BounceBall;
            BallMovement += MoveBall;
            player = jug;
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
        
        //Inicializa y establece cada elemento.
        private void ControlArkanoid_Load(object sender, EventArgs e)
        {
            cpbPlayer.BackgroundImage= Image.FromFile("../../img/Player.png");
            cpbPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            cpbPlayer.Top = Height - cpbPlayer.Height - 80; cpbPlayer.Left = (Width/2) - (cpbPlayer.Width/2);
            
            ball = new PictureBox();
            ball.Width= ball.Height= 20;
            ball.BackgroundImage=Image.FromFile("../../img/Ball.png");
            ball.BackgroundImageLayout= ImageLayout.Stretch;
            ball.Top = cpbPlayer.Top - ball.Height;
            ball.Left= cpbPlayer.Left + cpbPlayer.Width/2 - ball.Width/2;
            Controls.Add((ball));
            
            LoadTiles();
            LoadPanel();
        }

        //Encargada de lo contenido en el panel, panel, corazones y puntaje.
        private void LoadPanel()
        {
            scoreLifePanel = new Panel();
            scoreLifePanel.Width = Width;
            scoreLifePanel.Height = (int) (Height * 0.08);
            scoreLifePanel.Top = scoreLifePanel.Left = 0;
            scoreLifePanel.BackColor = Color.CadetBlue;
            scoreLifePanel.ForeColor = Color.Black;
            
            Controls.Add(scoreLifePanel);

            
            hearts = new PictureBox[GameData.Lifes];
            for (int i = 0; i < GameData.Lifes; i++)
            {
                hearts[i] = new PictureBox();
                hearts[i].Width = hearts[i].Height = 40;
                hearts[i].BackgroundImage = Image.FromFile("../../img/Heart.png");
                hearts[i].BackgroundImageLayout = ImageLayout.Stretch;
                hearts[i].Top = scoreLifePanel.Top + (hearts[0].Height / 4);
                hearts[i].Left = hearts[i].Width * i + 1;
                hearts[i].Tag = "heartTag";
                
                scoreLifePanel.Controls.Add(hearts[i]);
            }
            
            
            lblScore = new Label();
            lblScore.ForeColor = Color.White;
            lblScore.Text = GameData.GameScore.ToString();
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            lblScore.Font = new Font("Carlito" , 25f);
            lblScore.Left = Width - 100;
            lblScore.Height = scoreLifePanel.Height;

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
                                
                    if (i == 1)
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
        
        //Iniciar el juego con space.
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

            BallMovement?.Invoke();
        }
        
        //Maneja la trayectoria y ocurrencias de la pelota.
        private void BounceBall()
        {
            if (ball.Bottom > Height)
            {
                GameData.Lifes--;
                scoreLifePanel.Controls.Remove(hearts[GameData.Lifes]);
                hearts[GameData.Lifes] = null;
                GameData.GameStarted = false;
                timer1.Stop();
                CheckLife();
            }
            
            if (ball.Top < 0)
            {
                GameData.DirY = -GameData.DirY;
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
                        if (i ==1)
                        {
                            cpb[i,j].BackgroundImage= Image.FromFile("../../img/broken.png");
                        }
                        // si la pelota golpea la linea de blinded cambiar a shattered
                        GameData.GameScore += 3;
                        
                        if(cpb[i,j].Hits == 0)
                        {
                            Controls.Remove(cpb[i, j]);
                            cpb[i, j] = null;
                            lblScore.Text = GameData.GameScore.ToString();
                            CheckGame();
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

        //Revisa las vidas restantes del jugador y reposiciona los elementos.
        private void CheckLife()
        {
            if (GameData.Lifes == 0)
            {
                MessageBox.Show("Juego terminado.",
                    "Arkanoid", MessageBoxButtons.OK);
                ControlMenu menu = new ControlMenu();
                GameData.Lifes = 3;
                GameData.GameScore = 0;
                ((frmGame) this.Parent).ShowControl(menu);
            }
            else
            {
                cpbPlayer.Top = Height - cpbPlayer.Height - 80; cpbPlayer.Left = (Width/2) - (cpbPlayer.Width/2);
                ball.Top = cpbPlayer.Top - ball.Height;
                ball.Left= cpbPlayer.Left + cpbPlayer.Width/2 - ball.Width/2;
                ball.BringToFront();
            }
        }

        //Revisa los bloques restantes y finaliza el juego.
        private void CheckGame()
        {
            if (GameData.GameScore == 180)
            {
                timer1.Stop();
                ScoreDAO.AddScore(GameData.GameScore * GameData.Lifes , player.nickname);
                MessageBox.Show("Felicidades ha completado el juego.",
                    "Arkanoid", MessageBoxButtons.OK);
                ControlMenu menu = new ControlMenu();
                ((frmGame) this.Parent).ShowControl(menu);
            }
        }
    }
}