using System;
using System.Data;
using System.Windows.Forms;

namespace codexPopuli_Arkanoid.Modelo
{
    public static class PlayerDAO
    {
        public static Player GetPlayer(string nickname)
        {
            string sql = string.Format(
                "SELECT * FROM player WHERE nickname = '{0}';",
                nickname);
            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            
            Player p = new Player();
            foreach (DataRow fila in dt.Rows)
            {
                p.nickname = fila[0].ToString();
            }

            return p;
        }

        public static void CreatePlayer(string nickname)
        {
            try
            {
                string sql = string.Format(
                    "INSERT INTO player(nickname) VALUES ('{0}');",
                    nickname);
                ConnectionDB.ExecuteNonQuery(sql);
                MessageBox.Show("Se ha agregado el jugador", "Arkanoid",
                    MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error "+e.Message, "Arkanoid",
                    MessageBoxButtons.OK);
            }
        }
    }
}