# Scrum Flush API 🃏

![Documentation Status](https://img.shields.io/badge/docs-up--to--date-brightgreen?style=for-the-badge)
![GitHub repo size](https://img.shields.io/github/repo-size/marcelowf/Scrum_Flush_Api?style=for-the-badge) 

###### 🚀 About the Project
This API is a free and open-source tool designed to streamline agile estimation and planning within Scrum environments. It allows teams to effortlessly create and manage Scrum Poker sessions, fostering real-time collaboration among multiple users. The API supports the organization of sprints and the management of estimation cards used during planning rounds. Users can vote on cards, capture their estimates, and track historical data for sessions, votes, and sprints. Additionally, it offers robust analytics features to gain insights into team performance and session outcomes, helping to improve the estimation process.

[![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/) [![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/en-us/sql-server) [![Docker](https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white)](https://www.docker.com/) [![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)](https://swagger.io/) [![Entity Framework](https://img.shields.io/badge/Entity_Framework-86B049?style=for-the-badge&logo=entity-framework&logoColor=white)](https://docs.microsoft.com/en-us/ef/) [![DDD](https://img.shields.io/badge/DDD-1B4F72?style=for-the-badge&logo=none&logoColor=white)](https://www.domainlanguage.com/ddd/)

## ♣️ Getting Started
🚩 In Development

## <span style="color:red;">♥️</span> Documentation
🚩 In Development

## ♠️ Structure

> #### User
* UserID (Primary Key, UniqueIdentifier)
* UserName (nvarchar(100))
* Email (nvarchar(255))
* PasswordHash (nvarchar(255))
* Role (nvarchar(50))
* Active (boolean)
* CreatedAt (datetime)
* UpdatedAt (datetime)
* DeletedAt (datetime, nullable)

> #### Team
* TeamID (Primary Key, UniqueIdentifier)
* TeamName (nvarchar(100))
* TeamLeader (Foreign Key -> UserID)
* Active (boolean)
* CreatedBy (Foreign Key -> UserID)
* CreatedAt (datetime)
* UpdatedBy (Foreign Key -> UserID, nullable)
* UpdatedAt (datetime, nullable)
* DeletedBy (Foreign Key -> UserID, nullable)
* DeletedAt (datetime, nullable)

> #### UserTeam
* UserTeamID (Primary Key, UniqueIdentifier)
* UserID (Foreign Key -> UserID)
* TeamID (Foreign Key -> TeamID)
* CreatedAt (datetime)
* UpdatedAt (datetime, nullable)
* DeletedAt (datetime, nullable)

> #### Sprint
* SprintID (Primary Key, UniqueIdentifier)
* SprintName (nvarchar(100))
* Description (nvarchar(500))
* Status (nvarchar(50))
* Active (boolean)
* CreatedBy (Foreign Key -> UserID)
* CreatedAt (datetime)
* UpdatedBy (Foreign Key -> UserID, nullable)
* UpdatedAt (datetime, nullable)
* DeletedBy (Foreign Key -> UserID, nullable)
* DeletedAt (datetime, nullable)

> #### Card
* CardID (Primary Key, UniqueIdentifier)
* SprintID (Foreign Key -> SprintID)
* CardName (nvarchar(100))
* Value (nvarchar(50))
* Description (nvarchar(1000))
* Active (boolean)
* CreatedBy (Foreign Key -> UserID)
* CreatedAt (datetime)
* UpdatedBy (Foreign Key -> UserID, nullable)
* UpdatedAt (datetime, nullable)
* DeletedBy (Foreign Key -> UserID, nullable)
* DeletedAt (datetime, nullable)

> #### Session
* SessionID (Primary Key, UniqueIdentifier)
* SprintID (Foreign Key -> SprintID)
* SessionName (nvarchar(100))
* Status (nvarchar(50))
* Active (boolean)
* CreatedBy (Foreign Key -> UserID)
* CreatedAt (datetime)
* UpdatedBy (Foreign Key -> UserID, nullable)
* UpdatedAt (datetime, nullable)
* DeletedBy (Foreign Key -> UserID, nullable)
* DeletedAt (datetime, nullable)

> #### Round
* RoundID (Primary Key, UniqueIdentifier)
* SessionID (Foreign Key -> SessionID)
* CardID (Foreign Key -> CardID)
* RoundValue (nvarchar(50))
* Active (boolean)
* CreatedAt (datetime)
* UpdatedAt (datetime, nullable)
* DeletedAt (datetime, nullable)

> #### Vote
* VoteID (Primary Key, UniqueIdentifier)
* RoundID (Foreign Key -> RoundID)
* UserID (Foreign Key -> UserID)
* CardID (Foreign Key -> CardID)
* SprintID (Foreign Key -> SprintID)
* VoteValue (nvarchar(50))
* VoteDate (datetime)
* CreatedAt (datetime)
* UpdatedAt (datetime, nullable)
* DeletedAt (datetime, nullable)

> #### History
* HistoryID (Primary Key, UniqueIdentifier)
* UserID (Foreign Key -> UserID)
* SessionID (Foreign Key -> SessionID)
* SprintID (Foreign Key -> SprintID)
* CardID (Foreign Key -> CardID)
* Action (nvarchar(100))
* Active (boolean)
* CreatedAt (datetime)
* UpdatedAt (datetime, nullable)
* DeletedAt (datetime, nullable)

> #### Analytic
🚩 In Development

## <span style="color:red;">♦️</span> Contributing & Contact

As an open-source project, we welcome contributions from the community to help improve the Scrum Poker API. To contribute, please follow these steps:

1. **Fork the Repository**
   
    Fork the [Scrum Poker API repository](https://github.com/marcelowf/Scrum_Flush_Api) to your own GitHub account.

2. **Clone Your Fork**
   
    Clone your forked repository to your local machine:
    ```bash
    git clone https://github.com/marcelowf/Scrum-Poker-API.git
    ```
    
3. **Create a Branch**
   
    Create a new branch for your changes:
    ```bash
    git checkout -b feature/your-feature
    ```

4. **Make Your Changes**
   
    Implement your changes or features and ensure that all tests pass.

5. **Commit Your Changes**
   
    Commit your changes with a descriptive message:
    ```bash
    git add .
    git commit -m "Add feature: your-feature"
    ```
6. **Push Your Branch**
   
    Push your changes to your forked repository:
    ```bash
    git push origin feature/your-feature
    ```
7. **Create a Pull Request**
    
    Open a pull request on the original repository, describing your changes and why they should be merged.

### If you have any questions, issues, or need support, please reach out to us at marcelowzorekfilho@gmail.com.
