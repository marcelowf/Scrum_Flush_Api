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
The **Scrum Flush API** has been built to be a powerful and flexible tool, focusing on development time optimization and ease of maintenance. Some of the practices adopted include:

- **Inheritance for CRUD Operations**: A strategy of inheritance has been applied to optimize the CRUD operations (Create, Read, Update, Delete). This prevents code duplication and ensures that changes to CRUD functionalities are centralized in a base class, which makes maintenance easier and promotes code reuse.

- **AutoMapper**: To simplify the transformation of objects between layers (e.g., between entities and DTOs), **AutoMapper** is used. This eliminates the need to manually map data, speeding up development and minimizing errors. It also allows easy integration with other applications and modules.

- **Migrations and Database Management Efficiency**: **Entity Framework** is used for managing migrations, ensuring that the database structure stays consistent with the code. This makes it easy to evolve the data structure without needing manual SQL scripts, ensuring compatibility with any model changes.

- **Inversion of Control (IoC)**: **Inversion of Control (IoC)** is implemented using a DI (Dependency Injection) container, allowing dependencies to be automatically injected into classes instead of being manually created. This improves testability, decouples the code, and provides flexibility, making it easier to extend the project.

- **Factory for SQLContext**: The **Factory** pattern is used to facilitate the configuration and initialization of the database context. This allows **SQLContext** instances to be created in a controlled and efficient manner without the need for complex manual configuration.

- **Automatic Filtering System in `GetAll` Methods**: To ensure flexibility in data retrieval, an automatic filtering system has been implemented. This allows users to filter query results with optional parameters without modifying the source code. This makes the API more flexible, especially when different front-end applications require specific filters.

- **Custom DTOs for Each Operation**: Different **DTOs (Data Transfer Objects)** are used for each operation (GET, POST, PUT, DELETE), ensuring that the API only provides the necessary data for each context. This optimizes communication between the front-end and back-end and improves performance, while also enabling clearer and more efficient integration.

- **Docker and Docker Compose**: The entire application is set up to run in **Docker** containers, facilitating deployment and scalability. **Docker Compose** is used to orchestrate the containers, allowing all necessary services (API, database, etc.) to be started with a single command. This simplifies configuration and ensures a consistent development environment for all developers.

- **Swagger Documentation Best Practices**: API documentation has been facilitated through the use of **Swagger**. With Swagger, interactive API documentation is available, showing all endpoints, their parameters, and example responses. This makes it easier for front-end developers and third parties to interact with the API.

## ♠️ Structure
The **Scrum Flush API** follows a well-defined layered architecture, following best development practices that facilitate maintainability, scalability, and collaboration between teams. Here's an overview of the application's layers:

### Application Layers

- **API**: This layer is responsible for exposing the HTTP endpoints that users will consume. It validates inputs, calls the appropriate services from the application layer, and returns results. This layer is highly decoupled from the other layers, ensuring that business logic and data access are encapsulated in their respective layers.

- **Application Service**: The application layer coordinates business operations, calls services from the **Service** layer, and applies necessary transformations (such as converting entities to DTOs). It acts as a bridge between the API and business logic, and it's also where application rules can be implemented.

- **Service**: This layer contains the business rules of the system. It encapsulates the more complex logic of the application and interacts directly with the **Repository** layer for data manipulation. The **Service** pattern is used to ensure that business logic is reusable and that each operation in the system is well encapsulated.

- **Core**: The core layer holds interfaces and abstractions that help organize the code and ensure that the system is decoupled. It allows for the separation of concerns and ensures that changes in one layer do not directly affect others.

- **Repository**: The **Repository** pattern is used to abstract data access. It handles persistence and retrieval of data, providing a consistent interface for the **Service** layer to interact with the data source (in this case, a SQL database). This centralizes data access logic, making it easier to manage.

- **Domain**: The domain layer is where the **entities** of the system and domain rules are defined. In this layer, entities represent the core concepts of the system, and they are designed to faithfully reflect the business rules. The data model is carefully structured to avoid redundancy and maintain data integrity.

### Benefits of Layered Architecture

The choice of a layered architecture brings several benefits to the project:

1. **Modularity and Reusability**: The separation of responsibilities across layers makes it easier to reuse code. Business logic and data access are decoupled from the API logic, making future changes and the addition of new features easier.

2. **Ease of Maintenance**: With well-defined layers, it's possible to modify one layer without impacting others, which simplifies maintenance and system evolution. Issues in one layer can be resolved without affecting the rest of the application.

3. **Decoupling**: Decoupling between layers is one of the main advantages of this architecture. Each layer has a single, clear responsibility, preventing circular dependencies that could complicate the project.

4. **Scalability**: This structure facilitates both vertical and horizontal scalability. Layers can be adapted and scaled independently, which is crucial when the system grows in terms of users or data volume.

5. **Testability**: Layered architecture makes unit and integration testing easier. Dependencies can be easily injected into classes, allowing testing to be done on each layer in isolation.

6. **Facilitates Collaborative Development**: Layered structure allows different teams to work on different areas of the project simultaneously. For example, the back-end team can focus on the domain and service layers, while the front-end team works on the API layer, without significant interference between them.

7. **Service Segregation**: This architecture also makes it easy to segregate the system into smaller, independent services. This makes it easier to implement microservices or isolate parts of the system for different development teams.

8. **Better Dependency Management**: Using IoC and DI (Dependency Injection) makes it easier to manage the system's dependencies, avoiding tight coupling and making the code more flexible and testable.

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
