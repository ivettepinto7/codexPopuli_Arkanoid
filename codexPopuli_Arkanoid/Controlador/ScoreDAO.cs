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

        public static void AddScore(int nscore, string nickname)
        {
            try
            {
                string sql = string.Format("INSERT INTO score(score , nickname)" +  
                "VALUES ({0} , '{1}');",  nscore , nickname);
                ConnectionDB.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void UpdatePlayerScore(int nscore, string nickname)
        {
            try
            {
                string sql = string.Format(
                    "UPDATE public.score SET score={0}	WHERE nickname='{1}';",
                    nscore, nickname);
                
                ConnectionDB.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}