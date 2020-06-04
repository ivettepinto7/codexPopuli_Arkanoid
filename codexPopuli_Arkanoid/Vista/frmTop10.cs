using System;
using System.Windows.Forms;
using codexPopuli_Arkanoid.Modelo;

namespace codexPopuli_Arkanoid
{
    public partial class frmTop10 : Form
    {
        public frmTop10()
        {
            InitializeComponent();
        }

        private void frmTop10_Load(object sender, EventArgs e)
        {
            dgvScoresTop10.DataSource = null;
            dgvScoresTop10.DataSource = ScoreDAO.GetTop10();
        }
    }
}