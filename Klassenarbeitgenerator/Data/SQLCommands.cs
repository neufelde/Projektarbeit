using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Klassenarbeitgenerator.Data
{
    class SQLCommands
    {
        public SQLCommands()
        {
            using (conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=[ftp.strato.de];Database=[DB2546344];User id=ftp_dani@daniel-ibach.de;Password=sHg87$43bD;";
            }
        }

        private SqlConnection conn;
        private SqlCommand sqlCommand;

        public void AddTaskToDatabase(string name, int schwierigkeitsgrad, string thema, string fach, string aufgabentext, DateTime erstelldatum, Image bild)
        {
            sqlCommand = new SqlCommand("INSERT INTO Aufgabe (Name) VALUES (@Testname)");
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = conn;
            sqlCommand.Parameters.AddWithValue("@Testname", "Hallo Welt");
            conn.Open();
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateTaskInDatabase(string name)
        {

        }

        public void DeleteTaskFromDatabase(string name)
        {
            conn.Open();
            sqlCommand.CommandText = "DELETE FROM Aufgabe WHERE word = @Name";
            sqlCommand.Parameters.AddWithValue("@Name", name);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }


    }
}
