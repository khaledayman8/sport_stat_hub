/* SportsHub Master Database Script
   Final Refined Version
*/

USE master;
GO

-- Drop the database if it already exists so we can start fresh
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
-- 1. PARENT TABLES (No Foreign Keys)
-- =============================================

CREATE TABLE League (
    LeagueID INT PRIMARY KEY,
    LeagueName VARCHAR(100) NOT NULL
);

CREATE TABLE Stadium (
    StadiumID INT PRIMARY KEY,
    StadiumName VARCHAR(100) NOT NULL,
    Location VARCHAR(100)
);

-- =============================================
-- 2. PRIMARY ENTITIES
-- =============================================

CREATE TABLE Team (
    TeamID INT PRIMARY KEY,
    TeamName VARCHAR(100) NOT NULL,
    LeagueID INT,
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
    [Password] VARCHAR(255),
    LicenseLevel VARCHAR(50),
    TacticsPreference VARCHAR(100),
    FOREIGN KEY (LeagueID) REFERENCES League(LeagueID)
);

CREATE TABLE MedicalStaff (
    StaffID INT PRIMARY KEY,
    StaffName VARCHAR(100) NOT NULL,
    LeagueID INT,
    [Password] VARCHAR(255),
    Specialty VARCHAR(100),
    FOREIGN KEY (LeagueID) REFERENCES League(LeagueID)
);

-- =============================================
-- 3. OPERATIONAL & TRANSACTIONAL TABLES
-- =============================================

CREATE TABLE Contract (
    ContractID INT PRIMARY KEY,
    Terms TEXT,
    AthleteID INT NULL, -- Allowed NULL for individual contracts
    CoachID INT NULL,   -- Allowed NULL for individual contracts
    FOREIGN KEY (AthleteID) REFERENCES Athlete(AthleteID),
    FOREIGN KEY (CoachID) REFERENCES Coach(CoachID),
    CONSTRAINT CHK_Contract_Target CHECK (
        (AthleteID IS NOT NULL AND CoachID IS NULL) OR 
        (AthleteID IS NULL AND CoachID IS NOT NULL)
    )
);

CREATE TABLE TrainingSessions (
    SessionID INT PRIMARY KEY,
    SessionDate DATETIME,
    TeamID INT,
    FOREIGN KEY (TeamID) REFERENCES Team(TeamID)
);

CREATE TABLE Match (
    MatchID INT PRIMARY KEY,
    MatchDate DATETIME,
    StadiumID INT,
    HomeTeamID INT,
    AwayTeamID INT,
    HomeTeamPoints INT,
    AwayTeamPoints INT,
    WinnerTeamID INT,
    FOREIGN KEY (StadiumID) REFERENCES Stadium(StadiumID),
    FOREIGN KEY (HomeTeamID) REFERENCES Team(TeamID),
    FOREIGN KEY (AwayTeamID) REFERENCES Team(TeamID),
    FOREIGN KEY (WinnerTeamID) REFERENCES Team(TeamID)
);

-- =============================================
-- 4. SPECIALIZED RECORDS (Weak Entities)
-- =============================================

CREATE TABLE InjuryRecord (
    RecordID INT PRIMARY KEY,
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
    StatID INT PRIMARY KEY,
    MatchID INT,
    AthleteID INT,
    Goals INT DEFAULT 0,
    Assists INT DEFAULT 0,
    YellowCards INT DEFAULT 0,
    MinutesPlayed INT DEFAULT 0,
    FOREIGN KEY (MatchID) REFERENCES Match(MatchID),
    FOREIGN KEY (AthleteID) REFERENCES Athlete(AthleteID)
);

-- =============================================
-- 5. JUNCTION TABLES (Many-to-Many)
-- =============================================

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
-- 6. VIEWS
-- =============================================

CREATE VIEW Team_Standings AS
SELECT 
    TeamName,
    TotalWins,
    TotalGoals,
    MatchesPlayed,
    WinRate,
    GoalsPerGame
FROM Team;
GO

-- =============================================
-- 7. DATA POPULATION
-- =============================================

INSERT INTO League VALUES (1, 'Global Elite League');

INSERT INTO Stadium VALUES 
(1, 'Cairo International Stadium', 'Cairo'),
(2, 'Port Said Stadium', 'Port Said'),
(3, 'Borg El Arab Stadium', 'Alexandria');

INSERT INTO Team (TeamID, TeamName, LeagueID, TotalWins, TotalGoals, MatchesPlayed, CleanSheets) VALUES 
(1, 'Thunder Strikers', 1, 8, 25, 10, 3),
(2, 'Shadow Knights', 1, 4, 12, 10, 1),
(3, 'Cyber Phantoms', 1, 6, 18, 10, 2),
(4, 'Golden Eagles', 1, 2, 8, 10, 0),
(5, 'Iron Giants', 1, 9, 30, 10, 5);


INSERT INTO Coach (CoachID, CoachName, LeagueID, LicenseLevel, TacticsPreference) VALUES 
(1, 'Hassan Shehata', 1, 'Pro', 'Attacking 4-3-3'),
(2, 'Manuel Jose', 1, 'Elite', 'Counter-Attack');



-- Inserting Medical Staff with their specialties and passwords
INSERT INTO MedicalStaff (StaffID, StaffName, LeagueID, [Password], Specialty)
VALUES 
(1, 'Dr. Mohamed Abd-elfatah', 1, 'Mo2026', 'Monologist'),
(2, 'Dr. Hassan mohamed', 1, 'Hoss2026', 'Hebtomonologist'),
(3, 'Dr. Kareem El-Sayed', 1, 'K@reem2026', 'Sports Nutritionist'),
(4, 'Dr. Mona Hassan', 1, 'Mona_H26', 'Physical Therapist'),
(5, 'Dr. Omar Farouk', 1, 'Omar_Physio', 'Cardiologist');



-- Example Athlete population with password and physicals
INSERT INTO Athlete (AthleteID, AthleteName, TeamID, TotalAssists, Height, Weight, [Password]) VALUES 
(101, 'Liam Smith', 1, 5, 180.5, 75.0, 'Pass123'),
(501, 'Daniel Thompson', 5, 10, 188.0, 82.0, 'Secure456');
-- Adding more athletes to fill the roster
INSERT INTO Athlete (AthleteID, AthleteName, TeamID, Height, Weight, [Password], TotalAssists) 
VALUES 
(201, 'William Davis', 2, 175.0, 70.5, 'ShadowPass!', 0), -- Added 0 here
(301, 'Henry Gonzalez', 3, 182.3, 78.0, 'CyberSecure99', 0), 
(401, 'Samuel Moore', 4, 179.2, 74.0, 'EagleEye2026', 0);

INSERT INTO Match (MatchID, MatchDate, StadiumID, HomeTeamID, AwayTeamID, HomeTeamPoints, AwayTeamPoints, WinnerTeamID)
VALUES 
-- Match 1: Used by William Davis (201)
(1, '2026-05-01 18:00:00', 1, 1, 2, 3, 1, 1), 

-- Match 2: Used by Daniel Thompson (501)
(2, '2026-05-02 20:00:00', 2, 5, 3, 1, 0, 5), 

-- Match 3: Used by Liam Smith (101)
(3, '2026-05-03 16:00:00', 3, 4, 1, 2, 2, NULL);


INSERT INTO TrainingSessions (SessionID, SessionDate, TeamID)
VALUES 
(1, '2026-05-10 09:00:00', 1), -- Team 1: Thunder Strikers
(2, '2026-05-10 11:00:00', 2), -- Team 2: Shadow Knights
(3, '2026-05-11 08:30:00', 5), -- Team 5: Iron Giants
(4, '2026-05-12 10:00:00', 3), -- Team 3: Cyber Phantoms
(5, '2026-05-13 15:00:00', 4); -- Team 4: Golden Eagles



INSERT INTO PerformanceStatistics (StatID, MatchID, AthleteID, Goals, MinutesPlayed) VALUES 
(1, 1, 101, 2, 90);


INSERT INTO InjuryRecord (RecordID, Details, StaffID, AthleteID, Status, DateIncurred, EstimatedReturn) VALUES 
(1, 'Hamstring Strain', 1, 101, 'Recovered', '2026-04-01', '2026-04-15'),
(2, 'ACL Tear', 2, 301, 'Active', '2026-05-01', '2026-11-01');


-- Linking Athletes to their respective training sessions
INSERT INTO Athlete_Attends_Training (AthleteID, SessionID) VALUES 
(101, 1), -- Liam Smith attending Session 1
(201, 2), -- William Davis attending Session 2
(301, 4), -- Henry Gonzalez attending Session 4
(401, 5), -- Samuel Moore attending Session 5
(501, 3); -- Daniel Thompson attending Session 3

-- Match performance for a few players
INSERT INTO PerformanceStatistics (StatID, MatchID, AthleteID, Goals, Assists, YellowCards, MinutesPlayed) VALUES 
(2, 2, 501, 1, 0, 1, 75), -- Daniel Thompson: 1 Goal, 1 Yellow Card
(3, 1, 201, 0, 1, 0, 90), -- William Davis: 1 Assist
(4, 3, 101, 0, 0, 0, 45); -- Liam Smith: Played half match


INSERT INTO Athlete_Plays_In_Match (AthleteID, MatchID) VALUES 
(101, 1), (201, 1), -- Players in Match 1
(501, 3), (101, 3); -- Players in Match 3


-- Professional Athlete Contracts (CoachID is NULL)
INSERT INTO Contract (ContractID, Terms, AthleteID, CoachID)
VALUES 
(1, '5-Year Professional Tier 1 - $1M/season', 101, NULL),
(2, '3-Year Rookie Development - $200k/season', 201, NULL),
(3, '4-Year Mid-Tier Contract - $450k/season', 301, NULL),
(4, '2-Year Performance-Based - $300k/season', 501, NULL);


-- Technical Management Contracts (AthleteID is NULL)
INSERT INTO Contract (ContractID, Terms, AthleteID, CoachID)
VALUES 
(10, 'Managerial Lead Contract - $2.5M/season', NULL, 1),
(11, 'Technical Director Agreement - $1.8M/season', NULL, 2);