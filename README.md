Gamovida
Steps to Set Up SQL Server in Docker Install Docker: If you don’t already have Docker installed, you can download and install it from the official Docker website.

Run SQL Server Docker Container: You can pull the official Microsoft SQL Server image from Docker Hub and run it in a container.

Open a terminal (Command Prompt or PowerShell on Windows, Terminal on macOS/Linux) and run the following commands:

Pull the latest SQL Server image:

bash Copy docker pull mcr.microsoft.com/mssql/server

Run SQL Server in a Docker container:

bash Copy docker run -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=YourPassword123' -p 1433:1433 --name sql_server_container -d mcr.microsoft.com/mssql/server

![image](https://github.com/user-attachments/assets/ea378818-c1a4-473c-8f15-f10aad5080c3)


![image](https://github.com/user-attachments/assets/ef8a1276-e993-4b68-a10d-485080482182)


Once connected, open a New Query window and execute the following SQL script to create the UG database and People table. This script will safely drop and recreate them if they already exist.


CREATE DATABASE CarDatabase;
GO

USE CarDatabase;
GO

CREATE TABLE Cars (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Model NVARCHAR(255) NOT NULL,
    Weight FLOAT NOT NULL,
    Speed INT NOT NULL
);
GO

To see the cars:
USE CarDatabase;
SELECT * FROM Cars;

(Command Line (sqlcmd): If you have sqlcmd installed, you can run it from your terminal:
Bash

sqlcmd -S localhost,1433 -U sa -P YourPassword123 -d CarDatabase -Q "SELECT * FROM Cars;")



Set up the C# Project in Visual Studio Create a New C# Windows Forms App (.NET Framework) project in Visual Studio. Choose the "Windows Forms App (.NET Framework)" template. Name your project LashaMurgvaLominadzeShraieri.Quiz3 to match the namespaces. Ensure the target .NET Framework is 4.7.2 or later (or whatever you initially used). Add NuGet Package: In Visual Studio, right-click your project in Solution


![image](https://github.com/user-attachments/assets/126f9388-ccb2-4f52-90fa-44cb70052b0d)
Explorer. Select Manage NuGet Packages...

![image](https://github.com/user-attachments/assets/6ebba413-31fa-4875-b409-5adb510d2bbc)
