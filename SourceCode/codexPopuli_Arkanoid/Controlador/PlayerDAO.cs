using System;
using System.Data;
using System.Windows.Forms;

namespace codexPopuli_Arkanoid.Modelo
{
    public static class PlayerDAO
    {
        public static Player GetPlayer(string nickname)
        {
            //Crear y ejecutar consulta
            string sql = string.Format(
                "SELECT * FROM player WHERE nickname = '{0}';",
                nickname);
            DataTable dt = ConnectionDB.ExecuteQuery(sql);
            //Guardar datos de consulta
            Player p = new Player();
            foreach (DataRow fila in dt.Rows)
            {
                p.nickname = fila[0].ToString();
            }
            //Regresar datos
            return p;
        }

        public static void CreatePlayer(string nickname)
        {
            //Crear y ejecutar NonQuery
                string sql = string.Format(
                    "INSERT INTO player(nickname) VALUES ('{0}');",
                    nickname);
                ConnectionDB.ExecuteNonQuery(sql);
        }
    }
}