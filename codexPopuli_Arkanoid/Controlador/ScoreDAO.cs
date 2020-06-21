using System;
using System.Data;
using System.Windows.Forms;

namespace codexPopuli_Arkanoid.Modelo
{
    public class ScoreDAO
    {
        public static DataTable GetTop10()
        {
            
            DataTable scores = null;
            try
            {
                //Crear consulta y guardar datos
                string sql = string.Format(
                    "SELECT nickname, score FROM score ORDER BY score desc LIMIT 10;");
                scores = ConnectionDB.ExecuteQuery(sql);
            }
            catch (Exception e)
            {
                //Mostrar mensaje de error
                MessageBox.Show(e.Message, 
                    "Arkanoid", MessageBoxButtons.OK);
                throw;
            }

            return scores;
        }

        public static void AddScore(int nscore, string nickname)
        {
            try
            {
                //Crear consulta y agregar puntaje
                string sql = string.Format("INSERT INTO score(score , nickname)" +  
                "VALUES ({0} , '{1}');",  nscore , nickname);
                ConnectionDB.ExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                //Mostrar mensaje de error
                MessageBox.Show(e.Message, 
                    "Arkanoid", MessageBoxButtons.OK);
                throw;
            }
        }
    }
}