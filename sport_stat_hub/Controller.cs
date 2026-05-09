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
            // Use "." to point to your local SQL Server. 
            // Added TrustServerCertificate=True to handle connection security.
            string connString = @"Data Source=.;Initial Catalog=Sports_Hub;Integrated Security=True;TrustServerCertificate=True";
            dbMan = new DBManager(connString);
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
        
        public DataTable AdminLogin(int id, string password)
        {
            string query = $"SELECT * FROM Admin WHERE AdminID = {id} AND Password = '{password}'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAllUsers()
        {
            // This query combines Role, ID, and Name from all 4 tables
            string query = @"
        SELECT 'Athlete' AS [Role], AthleteID AS [ID], AthleteName AS [Name] FROM Athlete
        UNION
        SELECT 'Coach', CoachID, CoachName FROM Coach
        UNION
        SELECT 'MedicalStaff', StaffID, StaffName FROM MedicalStaff
        UNION
        SELECT 'Admin', AdminID, AdminName FROM Admin
        ORDER BY [Role], [Name]";

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

        public DataTable GetCoachProfile(int coachId)
        {
            string query = $"SELECT CoachName, LicenseLevel, TacticsPreference FROM Coach WHERE CoachID = {coachId}";
            return dbMan.ExecuteReader(query);
        }

        public int UpdateCoachProfile(int id, string license, string tactics)
        {
            string query = $"UPDATE Coach SET LicenseLevel = '{license}', TacticsPreference = '{tactics}' WHERE CoachID = {id}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int ChangeCoachPassword(int id, string newPass)
        {
            string query = $"UPDATE Coach SET Password = '{newPass}' WHERE CoachID = {id}";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetMyTeamAthletes(int coachId)
        {

            string query = $@"SELECT A.AthleteName, A.Position, A.Height, A.Weight 
                      FROM Athlete A 
                      JOIN Team T ON A.TeamID = T.TeamID 
                      JOIN Coach C ON T.LeagueID = C.LeagueID 
                      WHERE C.CoachID = {coachId}";
            return dbMan.ExecuteReader(query);
        }
        public int GetTeamIDFromCoach(int coachId)
        {
          
            string query = "SELECT TeamID FROM Coach WHERE CoachID = " + coachId;

            object result = dbMan.ExecuteScalar(query);
            if (result != null && result != DBNull.Value)
                return Convert.ToInt32(result);

            return -1;
        }

        public int AddTrainingSession(int teamId, DateTime date)
        {

            string query = $"INSERT INTO TrainingSessions (SessionDate, TeamID) VALUES ('{date:yyyy-MM-dd HH:mm:ss}', {teamId})";
            return dbMan.ExecuteNonQuery(query);
        }

        public int RecordAthletePerformance(int matchId, int athleteId, int goals, int assists, int yellows, int mins)
        {
            string query = $@"INSERT INTO PerformanceStatistics (MatchID, AthleteID, Goals, Assists, YellowCards, MinutesPlayed) 
                      VALUES ({matchId}, {athleteId}, {goals}, {assists}, {yellows}, {mins})";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetTeamManagerialStats(int teamId)
        {


            string query = $@"
        SELECT 
            TotalWins, TotalGoals, CleanSheets, WinRate, GoalsPerGame, MatchesPlayed,
            (TotalWins * 3) as TotalPoints,
            (SELECT COUNT(*) FROM InjuryRecord WHERE Status = 'Active' AND AthleteID IN (SELECT AthleteID FROM Athlete WHERE TeamID = {teamId})) as InjuryCount,
            (SELECT SUM(TotalAssists) FROM Athlete WHERE TeamID = {teamId}) as TotalAssists
        FROM Team WHERE TeamID = {teamId}";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetTopScorers(int teamId)
        {
            string query = $@"SELECT A.AthleteName, SUM(P.Goals) as TotalGoals 
                      FROM Athlete A 
                      JOIN PerformanceStatistics P ON A.AthleteID = P.AthleteID 
                      WHERE A.TeamID = {teamId} 
                      GROUP BY A.AthleteName ORDER BY TotalGoals DESC";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetTeamInjuryList(int teamId)
        {
            string query = $@"SELECT A.AthleteName, I.Details, I.Status, I.EstimatedReturn 
                      FROM InjuryRecord I 
                      JOIN Athlete A ON I.AthleteID = A.AthleteID 
                      WHERE A.TeamID = {teamId}";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMatchesList()
        {
           
            string query = "SELECT MatchID, (CAST(MatchID AS VARCHAR) + ' - ' + CONVERT(VARCHAR, MatchDate, 111)) AS Display FROM Match";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAthletesList(int teamId)
        {
            string query = $"SELECT AthleteID, AthleteName FROM Athlete WHERE TeamID = {teamId}";
            return dbMan.ExecuteReader(query);
        }


        public DataTable GetMedicalProfile(int staffId)
        {
            string query = $"SELECT StaffName, Specialty, CertificationID FROM MedicalStaff WHERE StaffID = {staffId}";
            return dbMan.ExecuteReader(query);
        }
        public int AddInjuryRecord(int staffId, int athleteId, string type, string date, string returnDate, string details)
        {
            string query = $@"INSERT INTO InjuryRecord (Details, StaffID, AthleteID, Status, DateIncurred, EstimatedReturn) 
                      VALUES ('{details}', {staffId}, {athleteId}, 'Active', '{date}', '{returnDate}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetActiveInjuriesList()
        {
            
            string query = @"SELECT I.RecordID, (A.AthleteName + ' - ' + CAST(I.Details AS VARCHAR(MAX))) as Display 
                     FROM InjuryRecord I JOIN Athlete A ON I.AthleteID = A.AthleteID 
                     WHERE I.Status != 'Recovered'";
            return dbMan.ExecuteReader(query);
        }

        public int UpdateRecoveryStatus(int recordId, string newStatus, string notes)
        {
           
            string query = $"UPDATE InjuryRecord SET Status = '{newStatus}', Details = CAST(Details AS VARCHAR(MAX)) + ' | Update: ' + '{notes}' WHERE RecordID = {recordId}";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetMedicalManagerialStats()
        {
           
            string query = @"SELECT 
        (SELECT COUNT(*) FROM InjuryRecord WHERE Status = 'Active') as TotalInjured,
        (SELECT ISNULL(AVG(DATEDIFF(day, DateIncurred, EstimatedReturn)), 0) FROM InjuryRecord) as AvgRecovery,
        (SELECT TOP 1 CAST(Details AS VARCHAR(MAX)) FROM InjuryRecord GROUP BY CAST(Details AS VARCHAR(MAX)) ORDER BY COUNT(*) DESC) as CommonInjury,
        (SELECT COUNT(*) FROM InjuryRecord WHERE DateIncurred > DATEADD(month, -1, GETDATE())) as NewInjuries,
        (SELECT COUNT(*) FROM InjuryRecord WHERE Status = 'Recovered') as TotalCleared,
        (SELECT COUNT(*) FROM InjuryRecord WHERE EstimatedReturn < GETDATE() AND Status = 'Active') as Overdue,
        (SELECT COUNT(*) FROM Athlete) as TotalAthletes,
        (SELECT COUNT(*) FROM MedicalStaff) as StaffCount";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMedicalDetailedReport(string reportType)
        {
            string query = "";
            if (reportType == "Full Injury History")
                query = "SELECT A.AthleteName, I.Details, I.DateIncurred, I.Status FROM InjuryRecord I JOIN Athlete A ON I.AthleteID = A.AthleteID";
            else if (reportType == "Cleared Players List")
                query = "SELECT A.AthleteName, I.Details, I.DateIncurred FROM InjuryRecord I JOIN Athlete A ON I.AthleteID = A.AthleteID WHERE I.Status = 'Recovered'";
            else
                query = "SELECT A.AthleteName, I.EstimatedReturn FROM InjuryRecord I JOIN Athlete A ON I.AthleteID = A.AthleteID WHERE I.Status = 'Active'";

            return dbMan.ExecuteReader(query);
        }

        public int ChangeMedicalPassword(int id, string newPass)
        {
            string query = $"UPDATE MedicalStaff SET Password = '{newPass}' WHERE StaffID = {id}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DischargePlayer(int recordId)
        {
            string query = $"UPDATE InjuryRecord SET Status = 'Recovered' WHERE RecordID = {recordId}";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetFullTeamAttendance(int teamId)
        {
           
            string query = $@"
        SELECT 
            A.AthleteName AS [Player Name], 
            CONVERT(VARCHAR, TS.SessionDate, 111) AS [Session Date],
            T.TeamName AS [Team]
        FROM Athlete A
        JOIN Athlete_Attends_Training AT ON A.AthleteID = AT.AthleteID
        JOIN TrainingSessions TS ON AT.SessionID = TS.SessionID
        JOIN Team T ON A.TeamID = T.TeamID
        WHERE A.TeamID = {teamId}
        ORDER BY TS.SessionDate DESC, A.AthleteName ASC";

            return dbMan.ExecuteReader(query);
        }
    }
}