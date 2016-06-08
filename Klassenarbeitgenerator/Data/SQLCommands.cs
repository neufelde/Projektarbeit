using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SqlClient;

namespace Klassenarbeitgenerator.Data
{
    class SQLCommands
    {
        public SQLCommands()
        {
            using (conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=[ftp.strato.de];Database=[DB2546344];User id=ftp_dani@daniel-ibach.de;Password=sHg87$43bD;";
                conn.Open();
            }
        }

        private SqlConnection conn;

        public void AddToDatabase(string name, int schwierigkeitsgrad, string thema, string fach, string aufgabentext, DateTime erstelldatum, Image bild)
        {
            conn.CreateCommand();
        }
    }
}
