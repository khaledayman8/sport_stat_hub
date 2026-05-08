using System;
using System.Data;
using System.Data.SqlClient;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            string connString =
            @"Data Source=DESKTOP-SJMB0TS;Initial Catalog=Sports_Hub;Integrated Security=True"; dbMan = new DBManager(connString);
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

        public DataTable GetAthleteProfile(int id)
        {
            string query = @"
            SELECT 
                A.AthleteID,
                A.AthleteName,
                T.TeamName,
                L.LeagueName,
                A.Height,
                A.Weight,
                A.TotalAssists,
                ISNULL(SUM(P.Goals), 0) AS TotalGoals
            FROM Athlete A
            JOIN Team T 
                ON A.TeamID = T.TeamID
            JOIN League L 
                ON T.LeagueID = L.LeagueID
            LEFT JOIN PerformanceStatistics P
                ON A.AthleteID = P.AthleteID
            WHERE A.AthleteID = " + id + @"
            GROUP BY 
                A.AthleteID,
                A.AthleteName,
                T.TeamName,
                L.LeagueName,
                A.Height,
                A.Weight,
                A.TotalAssists";

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
                M.MatchID,
                M.MatchDate,
                T1.TeamName AS HomeTeam,
                T2.TeamName AS AwayTeam,
                P.Goals,
                P.Assists,
                P.YellowCards,
                P.MinutesPlayed
            FROM Athlete A
            JOIN PerformanceStatistics P 
                ON A.AthleteID = P.AthleteID
            JOIN Match M 
                ON P.MatchID = M.MatchID
            JOIN Team T1 
                ON M.HomeTeamID = T1.TeamID
            JOIN Team T2 
                ON M.AwayTeamID = T2.TeamID
            WHERE A.AthleteID = " + id;

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetPreviousMatches(int id)
        {
            string query = @"
            SELECT 
                M.MatchID,
                M.MatchDate,

                T1.TeamName AS HomeTeam,
                T2.TeamName AS AwayTeam,

                M.HomeTeamPoints,
                M.AwayTeamPoints,

                S.StadiumName,

                P.Goals,
                P.Assists,
                P.MinutesPlayed,
                P.YellowCards,

                CASE 
                    WHEN M.WinnerTeamID IS NULL THEN 'Draw'
                    WHEN M.WinnerTeamID = M.HomeTeamID THEN T1.TeamName + ' Won'
                    ELSE T2.TeamName + ' Won'
                END AS MatchResult

            FROM Athlete_Plays_In_Match AP

            JOIN Match M 
                ON AP.MatchID = M.MatchID

            JOIN Team T1 
                ON M.HomeTeamID = T1.TeamID

            JOIN Team T2 
                ON M.AwayTeamID = T2.TeamID

            JOIN Stadium S 
                ON M.StadiumID = S.StadiumID

            LEFT JOIN PerformanceStatistics P
                ON M.MatchID = P.MatchID
                AND AP.AthleteID = P.AthleteID

            WHERE AP.AthleteID = " + id + @"
            AND M.MatchDate < GETDATE()

            ORDER BY M.MatchDate DESC";

            return dbMan.ExecuteReader(query);
        }
        public DataTable GetUpcomingMatches(int id)
        {
            string query = @"
            SELECT 
                M.MatchID,
                M.MatchDate,

                T1.TeamName AS HomeTeam,
                T2.TeamName AS AwayTeam,

                S.StadiumName,

                DATEDIFF(DAY, GETDATE(), M.MatchDate) 
                AS DaysLeft

            FROM Athlete_Plays_In_Match AP

            JOIN Match M 
                ON AP.MatchID = M.MatchID

            JOIN Team T1 
                ON M.HomeTeamID = T1.TeamID

            JOIN Team T2 
                ON M.AwayTeamID = T2.TeamID

            JOIN Stadium S 
                ON M.StadiumID = S.StadiumID

            WHERE AP.AthleteID = " + id + @"
            AND M.MatchDate >= GETDATE()

            ORDER BY M.MatchDate ASC";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAthleteTraining(int id)
        {
            string query = @"
            SELECT 
                TS.SessionID,
                TS.SessionDate,
                T.TeamName
            FROM Athlete_Attends_Training AT
            JOIN TrainingSessions TS 
                ON AT.SessionID = TS.SessionID
            JOIN Team T 
                ON TS.TeamID = T.TeamID
            WHERE AT.AthleteID = " + id + @"
            ORDER BY TS.SessionDate DESC";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAthleteInjuries(int id)
        {
            string query = @"
            SELECT 
                I.RecordID,
                I.Details,
                I.Status,
                I.DateIncurred,
                I.EstimatedReturn,
                M.StaffName
            FROM InjuryRecord I
            JOIN MedicalStaff M 
                ON I.StaffID = M.StaffID
            WHERE I.AthleteID = " + id + @"
            ORDER BY I.DateIncurred DESC";

            return dbMan.ExecuteReader(query);
        }
    }
}