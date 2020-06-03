namespace codexPopuli_Arkanoid.Modelo
{
    public class Score
    {
        public int idScore { get; }
        public int score { get; set; }
        public string nickname { get; set; }

        public Score()
        {
            idScore = 0;
            score = 0;
            nickname = "";
        }
    }
}