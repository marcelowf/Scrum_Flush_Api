# Scrum Poker API 🃏
> **Status: Developing** ⚠️
###### About the Project
This API is a free and open-source tool designed to facilitate agile estimation, planning sessions in a Scrum environment and also provides a robust platform for teams to engage in collaborative estimation sessions using Scrum Poker, also known as Planning Poker.

###### Features
- **Session Management**: Create, manage, and participate in Scrum Poker sessions.
- **Team Collaboration**: Allow multiple users to join and participate in estimation sessions.
- **Sprint & Card Management**: Organize sprints and manage cards used during estimation rounds.
- **Voting Mechanism**: Enable users to vote on cards and record their estimates.
- **Historical Data**: Track and store historical data of sessions, votes, and sprints.
- **Analytics**: Perform analysis on data from teams, sessions, and individual votes.


###### Technology Stack
This API is built with **C#**, leveraging its features for a scalable and maintainable codebase. I used **Swagger** to create comprehensive documentation and interactive exploration of the API. **Entity Framework** simplifies database interactions and management with **SQL Server**, and the design follows **Domain-Driven Design (DDD)** principles to ensure a well-structured and cohesive system.

<table>
    <tr>
        <td>DotNet</td>
        <td>Entity Framework</td>
        <td>SQL Server</td>
    </tr>
    <tr>
        <td>8.0</td>
        <td>8.0</td>
        <td>19</td>
    </tr>
</table>

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
   
    Fork the [Scrum Poker API repository](https://github.com/marcelowf/Scrum-Poker-API) to your own GitHub account.

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
