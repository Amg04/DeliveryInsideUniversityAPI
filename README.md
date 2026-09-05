# Delivery Inside University API

## Overview
Delivery Inside University API is an ASP.NET Core Web API designed to manage and facilitate delivery operations within a university campus.

The system provides APIs for managing delivery-related operations while following a structured architecture that promotes separation of concerns, maintainability, and testability.

🌍 **[Live Public API Documentation (Swagger)](https://deliveryapi.runasp.net/index.html)**

## Features
- Manage university delivery operations
- RESTful API endpoints
- Business logic separated from data access
- Repository-based data access
- Unit testing using MSTest
- Swagger/OpenAPI API documentation
- Clean separation of application layers

## Architecture
The project follows an N-Tier Architecture to ensure separation of concerns and maintainability:

```text
Delivery Inside University 
│   
├── ProjectAPI                  └── Presentation Layer
│   └── ASP.NET Core Web API Controllers
│
├── BAL                         └── Business Access Layer
│   └── Business Logic & Services
│
├── DAL                         └── Data Access Layer
│   └── DbContext & Repositories
│
├── Utilities                   └── Shared Utilities & Helpers
│   
└── ProjectAPI.Tests            └── Unit Tests
    └── MSTest
```

## Technologies Used
- C#
- .NET 8.0
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- MSTest
- Swagger / OpenAPI
- Git & GitHub

## Getting Started

### Prerequisites
Before running the project, make sure you have:
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- SQL Server

### Clone the Repository
```bash
git clone https://github.com/Amg04/DeliveryInsideUniversityAPI
cd DeliveryInsideUniversityAPI
```

### Configuration

The application uses Environment Variables to store sensitive configuration such as database connection strings and secrets.

Make sure to configure the required environment variables before running the application.

Example:

```text
ConnectionStrings__CS=YOUR_DATABASE_CONNECTION_STRING
```

### Database Setup
The project uses Entity Framework Core migrations. Update your database using:
```bash
cd ProjectAPI
dotnet ef database update
```

### Build
From the root directory:
```bash
dotnet build
```

### Run Tests
To execute the unit tests:
```bash
dotnet test
```

### Run the Application
Navigate to the API project:
```bash
cd ProjectAPI
dotnet run
```
The API will be available at the URL shown in the terminal.

## API Documentation
The project uses Swagger/OpenAPI for API documentation and testing.
- **Locally:** After running the application, open the Swagger URL displayed by the application, for example: `https://localhost:<port>/swagger`
- **Live:** [Swagger Documentation](https://deliveryapi.runasp.net/index.html)

## Testing
Unit tests are implemented using MSTest and are located in the `ProjectAPI.Tests` project.

Run all tests with:
```bash
dotnet test
```

## Project Structure
```text
/
├── ProjectAPI/
├── BAL/
├── DAL/
├── Utilities/
├── ProjectAPI.Tests/
└── README.md
```

## Author
**Ahmed Ghalwash**
- Computer Science Graduate — Faculty of Computers and Information, Mansoura University
- .NET Backend Developer

## License
This project is for educational and portfolio purposes.
