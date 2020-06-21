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
            //Agrega métodos al delegate
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
            //Configuración de barra jugador
            cpbPlayer.BackgroundImage= Image.FromFile("../../img/Player.png");
            cpbPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            cpbPlayer.Top = Height - cpbPlayer.Height - 80; cpbPlayer.Left = (Width/2) - (cpbPlayer.Width/2);
            //Configuración de bola
            ball = new PictureBox();
            ball.Width= ball.Height= 20;
            ball.BackgroundImage=Image.FromFile("../../img/Ball.png");
            ball.BackgroundImageLayout= ImageLayout.Stretch;
            ball.Top = cpbPlayer.Top - ball.Height;
            ball.Left= cpbPlayer.Left + cpbPlayer.Width/2 - ball.Width/2;
            Controls.Add((ball));
            //Cargar bloques y panel
            LoadTiles();
            LoadPanel();
        }

        //Encargada de lo contenido en el panel, panel, corazones y puntaje.
        private void LoadPanel()
        {
            //Configuración de Panel
            scoreLifePanel = new Panel();
            scoreLifePanel.Width = Width;
            scoreLifePanel.Height = (int) (Height * 0.08);
            scoreLifePanel.Top = scoreLifePanel.Left = 0;
            scoreLifePanel.BackColor = Color.CadetBlue;
            scoreLifePanel.ForeColor = Color.Black;
            //Agregar panel
            Controls.Add(scoreLifePanel);
            //asignación a hearts
            hearts = new PictureBox[GameData.Lives];
            //Configuración de corazones (vidas) en panel
            for (int i = 0; i < GameData.Lives; i++)
            {
                hearts[i] = new PictureBox();
                hearts[i].Width = hearts[i].Height = 40;
                hearts[i].BackgroundImage = Image.FromFile("../../img/Heart.png");
                hearts[i].BackgroundImageLayout = ImageLayout.Stretch;
                hearts[i].Top = scoreLifePanel.Top + (hearts[0].Height / 4);
                hearts[i].Left = hearts[i].Width * i + 1;
                hearts[i].Tag = "heartTag";
                //Agregar corazón
                scoreLifePanel.Controls.Add(hearts[i]);
            }
            
            //Configuración etiqueta de puntaje
            lblScore = new Label();
            lblScore.ForeColor = Color.White;
            lblScore.Text = GameData.GameScore.ToString();
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            lblScore.Font = new Font("Carlito" , 25f);
            lblScore.Left = Width - 100;
            lblScore.Height = scoreLifePanel.Height;
            //Agregar etiqueta de puntaje
            scoreLifePanel.Controls.Add(lblScore);
        }
        //Cargar bloques
        private void LoadTiles()
        {
            //establecer ejes y dimensiones para bloques
            int xAxis = 10,yAxis = 5;
            int pbHeight = (int)(Height * 0.3)/yAxis;
            int pbWidth = (Width-(xAxis-5))/xAxis;
            cpb = new CustomPictureBox[yAxis , xAxis];
            for(int i =0; i<yAxis;i++){
                for (int j = 0; j < xAxis; j++)
                {
                    //crear bloque
                    cpb[i,j]= new CustomPictureBox();
                    //Definir nivel del bloque            
                    if (i == 1)
                        cpb[i, j].Hits = 2;
                    else
                        cpb[i, j].Hits = 1;
                    //definir alto y ancho de bloque
                    cpb[i,j].Height= pbHeight;
                    cpb[i,j].Width= pbWidth;
                    //posiciones
                    cpb[i,j].Left= j*pbWidth;
                    cpb[i,j].Top= i*pbHeight + (int) (Height * 0.1);
                    //Definir sprite para bloque
                    if (i==1)
                        cpb[i,j].BackgroundImage= Image.FromFile("../../img/blinded.png");    
                    else
                        cpb[i,j].BackgroundImage= Image.FromFile("../../img/"+ GRN() +".png");
                    //configurar imagen y tag
                    cpb[i,j].BackgroundImageLayout= ImageLayout.Stretch;
                    cpb[i,j].Tag="tileTag";
                    //Agregar bloque
                    Controls.Add(cpb[i,j]);
            
                }
            }
        }
        //Generar numero aleatorio
        private int GRN()
        {
            return new Random().Next(1,8);
        }
        
        //Controlar movimiento de bloque
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
            try
            {
                if (!GameData.GameStarted)
                {
                    switch (e.KeyCode)
                    {
                        //Verificar tecla presionada
                        case Keys.Space:
                            GameData.GameStarted = true;
                            timer1.Start();
                            break;
                        default:
                            throw new WrongKeyPressedException("Presione Space para iniciar el juego");
                    }
                }
            }
            catch(WrongKeyPressedException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Evento Tick del timer
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Verificar que ha iniciado el juego
            if (!GameData.GameStarted)
                return;
            //Invocar delegate
            BallMovement?.Invoke();
        }
        
        //Maneja la trayectoria y ocurrencias de la pelota.
        private void BounceBall()
        {
            //Verificar si bola sale del limite inferior
            if (ball.Bottom > Height)
            {
                GameData.Lives--;
                scoreLifePanel.Controls.Remove(hearts[GameData.Lives]);
                hearts[GameData.Lives] = null;
                GameData.GameStarted = false;
                timer1.Stop();
                CheckLife();
            }
            //Verificar si bola sale del limite superior
            if (ball.Top < 0)
            {
                GameData.DirY = -GameData.DirY;
            }
            //Verificar limites laterales
            if(ball.Left<=0||ball.Right>=Width){
                GameData.DirX= -GameData.DirX;
                return;
            }
            //Verificar bola rebotando en barra del usuario
            if (ball.Bounds.IntersectsWith(cpbPlayer.Bounds))
            {
                GameData.DirY = -GameData.DirY;
            }
            //Verificar si bola golpea algun bloque
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (cpb[i,j] != null && ball.Bounds.IntersectsWith(cpb[i, j].Bounds))
                    {
                        //Reducir "Vida" del bloque
                        cpb[i,j].Hits--;
                        //Cambiar Sprite para nivel blindado
                        if (i ==1)
                        {
                            cpb[i,j].BackgroundImage= Image.FromFile("../../img/broken.png");
                        }
                        //Sumar puntaje si golpea bloque
                        GameData.GameScore += 3;
                        //Detruir bloque si ya no tiene "vidas"
                        if(cpb[i,j].Hits == 0)
                        {
                            Controls.Remove(cpb[i, j]);
                            cpb[i, j] = null;
                            lblScore.Text = GameData.GameScore.ToString();
                            CheckGame();
                        }
                        //Cambiar sentido bola
                        GameData.DirY= -GameData.DirY;
                        return;
                    }
                }
            }
        }
        //Mover Bola
        private void MoveBall()
        {
            ball.Left+= GameData.DirX;
            ball.Top+= GameData.DirY;
        }

        //Revisa las vidas restantes del jugador y reposiciona los elementos.
        private void CheckLife()
        {
            //Verificar vidas de usuario
            if (GameData.Lives == 0)
            {
                MessageBox.Show("Juego terminado.",
                    "Arkanoid", MessageBoxButtons.OK);
                //Reiniciar datos para permitir juego nuevo
                ControlMenu menu = new ControlMenu();
                GameData.Lives = 3;
                GameData.GameScore = 0;
                //cambiar de userControl
                ((frmGame) this.Parent).ShowControl(menu);
            }
            else
            {
                //Reiniciar posición de bola
                cpbPlayer.Top = Height - cpbPlayer.Height - 80; cpbPlayer.Left = (Width/2) - (cpbPlayer.Width/2);
                ball.Top = cpbPlayer.Top - ball.Height;
                ball.Left= cpbPlayer.Left + cpbPlayer.Width/2 - ball.Width/2;
                ball.BringToFront();
            }
        }

        //Revisa los bloques restantes y finaliza el juego.
        private void CheckGame()
        {
            //Verificar que no hayan más bloques
            if (GameData.GameScore == 180)
            {
                //detener timer
                timer1.Stop();
                //Agregar puntaje
                ScoreDAO.AddScore(GameData.GameScore * GameData.Lives , player.nickname);
                MessageBox.Show("Felicidades ha completado el juego.",
                    "Arkanoid", MessageBoxButtons.OK);
                //Cambiar de menu
                ControlMenu menu = new ControlMenu();
                //Reiniciar valores de juego para permitir juego nuevo
                GameData.Lives = 3;
                GameData.GameScore = 0;
                //Cambiar de userControl
                ((frmGame) this.Parent).ShowControl(menu);
            }
        }
    }
}