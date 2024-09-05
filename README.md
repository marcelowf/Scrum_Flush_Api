# Scrum Flush API 🃏

![GitHub repo size](https://img.shields.io/github/repo-size/marcelowf/Scrum_Flush_Api?style=for-the-badge) 

#### 🚀 About the Project
This API is a free and open-source tool designed to streamline agile estimation and planning within Scrum environments. It allows teams to effortlessly create and manage Scrum Poker sessions, fostering real-time collaboration among multiple users. The API supports the organization of sprints and the management of estimation cards used during planning rounds. Users can vote on cards, capture their estimates, and track historical data for sessions, votes, and sprints. Additionally, it offers robust analytics features to gain insights into team performance and session outcomes, helping to improve the estimation process.

[![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/) [![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/en-us/sql-server) [![Docker](https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white)](https://www.docker.com/) [![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)](https://swagger.io/) [![Entity Framework](https://img.shields.io/badge/Entity_Framework-86B049?style=for-the-badge&logo=entity-framework&logoColor=white)](https://docs.microsoft.com/en-us/ef/) [![DDD](https://img.shields.io/badge/DDD-1B4F72?style=for-the-badge&logo=none&logoColor=white)](https://www.domainlanguage.com/ddd/)

## ♣️ Getting Started
#### Prerequisites
1. **SQL Server**: If you do not have SQL Server installed, you can download it from this [LINK](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads).
2. **Docker**: Make sure Docker is installed; you can download it from this [LINK](https://www.docker.com/get-started).

#### How to Run the Project
1. **Initialize Resources**
    Make sure that SQL Server is running and Docker is installed and functioning correctly. Also, ensure that the database connection string is properly configured in the `appsettings.json` file with your SQL Server credentials (username and password).

    - Check if SQL Server is Running: Open a terminal or PowerShell and run the following command:
    ```
    Get-Service -Name "MSSQL$<Your SQL Server instance Name>"
    ```

    - Check if Docker is Installed and Running: Open a terminal or PowerShell and run the following command:
    ```
    docker --version
    ```

2. **Run Migrations**
   Before starting the application, it is necessary to set up the database by applying migrations. From the main project directory, run the following command in PowerShell: 
   ```
   .\execute-migrations.ps1
   ```
3. **Start Docker Containers**
    After applying the migrations, while still in the project's root directory, run the following command to start the required Docker services: 
    ```
    .\execute-container.ps1
    ```
4. **Access the Swagger Interface**
    With all the services up and running, you can access the Swagger interface, which provides interactive API documentation, by navigating to the following [LINK](http://localhost:8080/swagger/index.html) in your browser.

## <span style="color:red;">♥️</span> Documentation
🚩 In Development

## ♠️ Structure
🚩 In Development

## <span style="color:red;">♦️</span> Contributing & Contact

As an open-source project, we welcome contributions from the community to help improve the Scrum Poker API. To contribute, please follow these steps:

1. **Fork** the [Scrum Poker API repository](https://github.com/marcelowf/Scrum_Flush_Api) to your own GitHub account and **Clone Your Fork** to your local machine:
    ```bash
    git clone https://github.com/marcelowf/Scrum-Poker-API.git
    ```

2. **Create a Branch** for your changes:
    ```bash
    git checkout -b feature/your-feature
    ```

3. **Implement Your Changes** or features and **Commit** with a descriptive message:
    ```bash
    git add .
    git commit -m "Add feature: your-feature"
    ```

4. **Push Your Changes** to your forked repository:
    ```bash
    git push origin feature/your-feature
    ```

5. **Create a Pull Request** on the original repository, describing your changes and why they should be merged.
___
#### If you have any questions, issues, or need support, please reach out to us at marcelowzorekfilho@gmail.com.
