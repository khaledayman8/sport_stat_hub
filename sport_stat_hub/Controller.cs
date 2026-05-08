using System;
using System.Data;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            string connString =
            @"Data Source=DESKTOP-SJMB0TS;Initial Catalog=SportHubDB;Integrated Security=True"; dbMan = new DBManager(connString);
        }

        public void TerminateConnection()
        {
            // nothing required now (connections are auto-closed)
        }
        public DataTable AthleteLogin(int id, string password)
        {
            string query = $"SELECT * FROM Athlete WHERE AthleteID = {id} AND Password = '{password}'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable CoachLogin(int id, string password)
        {
            string query = $"SELECT * FROM Coach WHERE CoachID = {id} AND Password = '{password}'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable MedicalLogin(int id, string password)
        {
            string query = $"SELECT * FROM MedicalStaff WHERE StaffID = {id} AND Password = '{password}'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAthleteByID(int id)
        {
            string query = $"SELECT AthleteName, Height, Weight FROM Athlete WHERE AthleteID = {id}";
            return dbMan.ExecuteReader(query);
        }
        public int UpdateHeight(int id, int height)
        {
            string query = $"UPDATE Athlete SET Height = {height} WHERE AthleteID = {id}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateWeight(int id, int weight)
        {
            string query = $"UPDATE Athlete SET Weight = {weight} WHERE AthleteID = {id}";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetFullAthleteStats(int id)
        {
            string query = @"
            SELECT 
                A.AthleteID,
                A.AthleteName,
                T.TeamName,
                A.TotalAssists,

                JSON_VALUE(PS.StatData, '$.goals') AS Goals,
                JSON_VALUE(PS.StatData, '$.minutes_played') AS MinutesPlayed,
                JSON_VALUE(PS.StatData, '$.yellow_cards') AS YellowCards

            FROM Athlete A
            JOIN Team T ON A.TeamID = T.TeamID
            LEFT JOIN PerformanceStatistics PS 
                ON A.AthleteID = PS.AthleteID
            WHERE A.AthleteID = " + id;

            return dbMan.ExecuteReader(query);
        }
    }
}