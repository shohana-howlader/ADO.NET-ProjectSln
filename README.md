# ADO.NET Project Solution

This repository contains a project showcasing the use of ADO.NET for database interaction in a .NET application. The project demonstrates various database operations such as CRUD (Create, Read, Update, Delete) using ADO.NET in a structured and efficient way.

## Table of Contents
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Database Setup](#database-setup)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Features
- Basic CRUD operations (Create, Read, Update, Delete) using ADO.NET.
- Uses SqlConnection, SqlCommand, and SqlDataReader for database interaction.
- Proper use of parameterized queries to prevent SQL injection.
- Structured error handling using try-catch blocks.
- Logging database operations.
- Simple user interface for interacting with the database.

## Technologies Used
- **ADO.NET** - For database access and operations.
- **C#** - Main programming language.
- **SQL Server** - Backend database.
- **.NET Framework / .NET Core** - Application framework.

## Getting Started

### Prerequisites
- Visual Studio (2019 or later) or any other IDE supporting .NET.
- SQL Server or any other compatible database server.
- Basic knowledge of C# and ADO.NET.

### Installation
1. Clone this repository to your local machine:
   ```bash
   git clone https://github.com/shohana-howlader/ADO.NET-ProjectSln.git
   ```
2. Open the solution file (`.sln`) in Visual Studio.
3. Restore NuGet packages (if any).
4. Build the solution.

### Database Setup
1. Make sure you have SQL Server installed and running.
2. Create a new database for the project.
3. Execute the SQL scripts located in the `Database` folder to set up the necessary tables and stored procedures.
4. Update the connection string in the `appsettings.json` or `Web.config` file with your SQL Server instance details.

Example:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DATABASE;Trusted_Connection=True;"
}
```

## Usage
1. Run the application from Visual Studio.
2. The application provides a simple user interface to interact with the database, allowing you to:
   * Add new records.
   * View existing records.
   * Update records.
   * Delete records.

## Contributing
Contributions are welcome! Please fork this repository and submit a pull request if you have any improvements or bug fixes.

## License
This project is licensed under the MIT License - see the LICENSE file for details.
