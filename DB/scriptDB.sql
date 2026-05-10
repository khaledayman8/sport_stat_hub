/* ========================================================================
   SportsHub Master Database Script - FINAL CLEANED VERSION
   ======================================================================== */

USE master;
GO

-- =============================================
-- 1. RESET DATABASE
-- =============================================
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'Sports_Hub')
BEGIN
    ALTER DATABASE Sports_Hub SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE Sports_Hub;
END
GO

CREATE DATABASE Sports_Hub;
GO

USE Sports_Hub;
GO

-- =============================================
-- 2. CREATE TABLES (Parent to Child Order)
-- =============================================

CREATE TABLE League (
    LeagueID INT PRIMARY KEY,
    LeagueName VARCHAR(100) NOT NULL,
    Country VARCHAR(100),    
    Division VARCHAR(100)    
);

CREATE TABLE Stadium (
    StadiumID INT PRIMARY KEY,
    StadiumName VARCHAR(100) NOT NULL,
    Location VARCHAR(100),
    Capacity INT 
);

CREATE TABLE Team (
    TeamID INT PRIMARY KEY,
    TeamName VARCHAR(100) NOT NULL,
    LeagueID INT,
    City VARCHAR(100),
    TotalWins INT DEFAULT 0,
    TotalGoals INT DEFAULT 0,
    CleanSheets INT DEFAULT 0,
    MatchesPlayed INT DEFAULT 0,
    WinRate AS (CAST(TotalWins AS DECIMAL(5,2)) / NULLIF(MatchesPlayed, 0)) * 100,
    GoalsPerGame AS (CAST(TotalGoals AS DECIMAL(5,2)) / NULLIF(MatchesPlayed, 0)),
    FOREIGN KEY (LeagueID) REFERENCES League(LeagueID)
);

CREATE TABLE Athlete (
    AthleteID INT PRIMARY KEY,
    AthleteName VARCHAR(100) NOT NULL,
    TeamID INT,
    Position VARCHAR(50), -- Integrated from ALTER
    Height DECIMAL(5,2),
    Weight DECIMAL(5,2),
    [Password] VARCHAR(255),
    TotalAssists INT DEFAULT 0,
    FOREIGN KEY (TeamID) REFERENCES Team(TeamID)
);

CREATE TABLE Coach (
    CoachID INT PRIMARY KEY,
    CoachName VARCHAR(100) NOT NULL,
    LeagueID INT,
    TeamID INT, -- Integrated from ALTER
    [Password] VARCHAR(255),
    LicenseLevel VARCHAR(50),
    TacticsPreference VARCHAR(100),
    FOREIGN KEY (LeagueID) REFERENCES League(LeagueID),
    FOREIGN KEY (TeamID) REFERENCES Team(TeamID)
);

CREATE TABLE MedicalStaff (
    StaffID INT PRIMARY KEY,
    StaffName VARCHAR(100) NOT NULL,
    LeagueID INT,
    CertificationID VARCHAR(50), -- Integrated from ALTER
    [Password] VARCHAR(255),
    Specialty VARCHAR(100),
    FOREIGN KEY (LeagueID) REFERENCES League(LeagueID)
);

CREATE TABLE Admin (
    AdminID INT PRIMARY KEY,
    AdminName VARCHAR(100) NOT NULL,
    [Password] VARCHAR(255) NOT NULL
);

-- Operational Tables with IDENTITY(1,1)
CREATE TABLE Contract (
    ContractID INT PRIMARY KEY IDENTITY(1,1),
    Terms TEXT,
    AthleteID INT NULL,
    CoachID INT NULL,
    WeeklySalary DECIMAL(10, 2) DEFAULT 0,
    FOREIGN KEY (AthleteID) REFERENCES Athlete(AthleteID),
    FOREIGN KEY (CoachID) REFERENCES Coach(CoachID),
    CONSTRAINT CHK_Contract_Target CHECK (
        (AthleteID IS NOT NULL AND CoachID IS NULL) OR 
        (AthleteID IS NULL AND CoachID IS NOT NULL)
    )
);

CREATE TABLE TrainingSessions (
    SessionID INT PRIMARY KEY IDENTITY(1,1),
    SessionDate DATETIME,
    TeamID INT,
    FOREIGN KEY (TeamID) REFERENCES Team(TeamID)
);

CREATE TABLE Match (
    MatchID INT PRIMARY KEY IDENTITY(1,1),
    MatchDate DATETIME,
    StadiumID INT,
    HomeTeamID INT,
    AwayTeamID INT,
    HomeTeamPoints INT DEFAULT 0,
    AwayTeamPoints INT DEFAULT 0,
    WinnerTeamID INT,
    Attendance INT DEFAULT 0, 
    FOREIGN KEY (StadiumID) REFERENCES Stadium(StadiumID),
    FOREIGN KEY (HomeTeamID) REFERENCES Team(TeamID),
    FOREIGN KEY (AwayTeamID) REFERENCES Team(TeamID),
    FOREIGN KEY (WinnerTeamID) REFERENCES Team(TeamID)
);

CREATE TABLE InjuryRecord (
    RecordID INT PRIMARY KEY IDENTITY(1,1),
    Details TEXT,
    StaffID INT,
    AthleteID INT,
    Status VARCHAR(20) DEFAULT 'Active',
    DateIncurred DATE,
    EstimatedReturn DATE,
    FOREIGN KEY (StaffID) REFERENCES MedicalStaff(StaffID),
    FOREIGN KEY (AthleteID) REFERENCES Athlete(AthleteID)
);

CREATE TABLE PerformanceStatistics (
    StatID INT PRIMARY KEY IDENTITY(1,1),
    MatchID INT,
    AthleteID INT,
    Goals INT DEFAULT 0,
    Assists INT DEFAULT 0,
    YellowCards INT DEFAULT 0,
    MinutesPlayed INT DEFAULT 0,
    FOREIGN KEY (MatchID) REFERENCES Match(MatchID),
    FOREIGN KEY (AthleteID) REFERENCES Athlete(AthleteID)
);

CREATE TABLE Athlete_Attends_Training (
    AthleteID INT,
    SessionID INT,
    PRIMARY KEY (AthleteID, SessionID),
    FOREIGN KEY (AthleteID) REFERENCES Athlete(AthleteID),
    FOREIGN KEY (SessionID) REFERENCES TrainingSessions(SessionID)
);

CREATE TABLE Athlete_Plays_In_Match (
    AthleteID INT,
    MatchID INT,
    PRIMARY KEY (AthleteID, MatchID),
    FOREIGN KEY (AthleteID) REFERENCES Athlete(AthleteID),
    FOREIGN KEY (MatchID) REFERENCES Match(MatchID)
);
GO

-- =============================================
-- 3. VIEWS & PROCEDURES
-- =============================================

CREATE VIEW v_AdminStats AS
SELECT 
    (SELECT COUNT(*) FROM Athlete) AS TotalAthletes,
    (SELECT COUNT(*) FROM Team) AS TotalTeams,
    (SELECT COUNT(*) FROM League) AS TotalLeagues,
    (SELECT ISNULL(AVG(WeeklySalary),0) FROM Contract) AS AvgSalary,
    (SELECT COUNT(*) FROM InjuryRecord WHERE Status = 'Active') AS ActiveInjuries,
    (SELECT COUNT(*) FROM Stadium) AS TotalStadiums,
    (SELECT COUNT(*) FROM Contract) AS TotalContracts,
    (SELECT COUNT(*) FROM Match) AS TotalMatches,
    (SELECT MAX(Capacity) FROM Stadium) AS MaxCapacity; 
GO

CREATE PROCEDURE sp_ChangeUserPassword 
    @TableType VARCHAR(20), 
    @ID INT, 
    @NewPass VARCHAR(255) 
AS
BEGIN
    IF @TableType = 'Athlete' UPDATE Athlete SET [Password] = @NewPass WHERE AthleteID = @ID;
    IF @TableType = 'Coach' UPDATE Coach SET [Password] = @NewPass WHERE CoachID = @ID;
END;
GO

-- =============================================
-- 4. DATA POPULATION
-- =============================================

INSERT INTO League VALUES (1, 'Global Elite League', 'International', 'Division 1');

INSERT INTO Stadium (StadiumID, StadiumName, Location, Capacity) VALUES 
(1, 'Cairo International Stadium', 'Cairo', 75000),
(2, 'Port Said Stadium', 'Port Said', 18000),
(3, 'Borg El Arab Stadium', 'Alexandria', 86000);

INSERT INTO Team (TeamID, TeamName, LeagueID, City, TotalWins, TotalGoals, MatchesPlayed, CleanSheets) VALUES 
(1, 'Thunder Strikers', 1, 'Cairo', 8, 25, 10, 3),
(2, 'Shadow Knights', 1, 'London', 4, 12, 10, 1),
(3, 'Cyber Phantoms', 1, 'Tokyo', 6, 18, 10, 2),
(4, 'Golden Eagles', 1, 'New York', 2, 8, 10, 0),
(5, 'Iron Giants', 1, 'Berlin', 9, 30, 10, 5);

INSERT INTO Admin (AdminID, AdminName, [Password]) VALUES (1, 'MasterAdmin', 'admin123');

-- Consolidated Athlete Inserts with Positions
INSERT INTO Athlete (AthleteID, AthleteName, TeamID, Position, TotalAssists, Height, Weight, [Password]) VALUES 
(101, 'Liam Smith', 1, 'Forward', 5, 180.5, 75.0, 'Pass123'),
(201, 'Cris brat', 1, 'Midfielder', 5, 180.5, 75.0, 'Pass123'),
(301, 'Felo 3mad', 1, 'Defender', 5, 189.5, 95.0, 'Pasyys1423'),
(401, 'Kemo nagy', 1, 'Goalkeeper', 5, 170.5, 85.0, 'Pasuus1623'),
(501, 'Daniel Thompson', 5, 'Forward', 10, 188.0, 82.0, 'Secure456');

-- Consolidated Medical Staff Inserts with Certifications
INSERT INTO MedicalStaff (StaffID, StaffName, LeagueID, CertificationID, [Password], Specialty) VALUES 
(1, 'Dr. Mohamed Abd-elfatah', 1, 'CERT-999', 'Mo2026', 'Monologist'),
(2, 'Dr. Hassan mohamed', 1, 'CERT-002', 'Hoss2026', 'Hebtomonologist');

-- Consolidated Coach Inserts with TeamIDs (Added missing Coach 2)
INSERT INTO Coach (CoachID, CoachName, LeagueID, TeamID, LicenseLevel, TacticsPreference, [Password]) VALUES 
(1, 'Hassan Shehata', 1, 1, 'Pro', 'Attacking 4-3-3', 'coach123'),
(2, 'Marcel Koller', 1, 2, 'Pro', 'Balanced', 'coach456');

INSERT INTO Contract (Terms, AthleteID, WeeklySalary) VALUES 
('5-Year Contract', 101, 50000);

-- Match Data (IDs auto-generate 1, 2, 3)
INSERT INTO Match (MatchDate, StadiumID, HomeTeamID, AwayTeamID, HomeTeamPoints, AwayTeamPoints, WinnerTeamID)
VALUES 
(DATEADD(day, -10, GETDATE()), 1, 1, 2, 3, 1, 1), -- Match 1: Team 1 won
(DATEADD(day, -5, GETDATE()), 2, 3, 1, 2, 0, 3),  -- Match 2: Team 1 lost
(DATEADD(day, 5, GETDATE()), 1, 1, 4, 0, 0, NULL); -- Match 3: Upcoming

-- Performance Data
INSERT INTO PerformanceStatistics (MatchID, AthleteID, Goals, Assists, MinutesPlayed)
VALUES 
(1, 101, 2, 1, 90), -- Liam Smith: 2 goals
(1, 501, 1, 0, 90), 
(2, 101, 1, 0, 90); -- Liam Smith: 1 goal (Total 3)

-- Injury Data
INSERT INTO InjuryRecord (Details, StaffID, AthleteID, Status, DateIncurred, EstimatedReturn) 
VALUES 
('Hamstring Strain', 1, 101, 'Active', DATEADD(day, -15, GETDATE()), DATEADD(day, 5, GETDATE())),
('Broken Ankle', 2, 201, 'Active', DATEADD(day, -40, GETDATE()), DATEADD(day, -10, GETDATE())), -- OVERDUE!
('Muscle Fatigue', 1, 301, 'Recovered', DATEADD(day, -20, GETDATE()), DATEADD(day, -2, GETDATE())), -- CLEARED
('ACL Tear', 2, 401, 'Active', DATEADD(day, -3, GETDATE()), DATEADD(day, 180, GETDATE())); -- NEW THIS MONTH

-- Training Sessions & Junction Table Data
INSERT INTO TrainingSessions (SessionDate, TeamID) 
VALUES 
(DATEADD(day, -1, GETDATE()), 1), 
(DATEADD(day, -1, GETDATE()), 2);

INSERT INTO Athlete_Attends_Training (AthleteID, SessionID)
SELECT A.AthleteID, T.SessionID FROM Athlete A INNER JOIN TrainingSessions T ON A.TeamID = T.TeamID;
GO

-- =============================================
-- 5. FINAL VERIFICATION QUERIES
-- =============================================
SELECT 'Current Injured' as Stat, COUNT(*) as Value FROM InjuryRecord WHERE Status = 'Active';
SELECT 'Overdue' as Stat, COUNT(*) as Value FROM InjuryRecord WHERE Status = 'Active' AND EstimatedReturn < GETDATE();
SELECT 'Total Wins Team 1' as Stat, TotalWins FROM Team WHERE TeamID = 1;
SELECT 'Coach Assignments' as Stat, CoachName, TeamID FROM Coach;
GO

INSERT INTO Athlete_Plays_In_Match (AthleteID, MatchID)
VALUES
(101, 1),
(101, 2),
(501, 1);