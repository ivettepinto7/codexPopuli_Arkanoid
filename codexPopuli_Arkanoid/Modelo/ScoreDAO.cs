using System;
using System.Data;

namespace codexPopuli_Arkanoid.Modelo
{
    public class ScoreDAO
    {
        public static DataTable GetTop10()
        {
            DataTable scores = null;

            try
            {
                string sql = string.Format(
                    "SELECT nickname, score FROM score ORDER BY score desc LIMIT 10;");
                scores = ConnectionDB.ExecuteQuery(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return scores;
        } 
    }
}