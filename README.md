# Swagger Test Project - REST API

## Description
The **Swagger Test Project** is a backend-focused **REST API** developed to practice and demonstrate API design, controller structure, and automated background processing.

The project exposes multiple endpoints using **GET** and **POST** methods, is fully documented via **Swagger**, and stores all data in a **Supabase database**.  
Additionally, **Hangfire** is integrated to execute automated background jobs and test processes using cron schedules.

## Project Scope
The API manages three core domains:
- **Customers**
- **Orders**
- **Products**

Each domain is handled through its own controller and service logic.

## Tech Stack
- **C# (.NET Web API)**
- **Swagger / OpenAPI**
- **Supabase**
- **Hangfire**
- RESTful API principles
- Dependency Injection

## Running the Project

1. Configure Supabase connection settings
2. Start the API project
3. Open Swagger UI in the browser
4. Test endpoints using GET and POST methods
5. Monitor background jobs via Hangfire Dashboard

### Project Versions
- dotnet version: 10.0.102
- target framework: net9.0

- Key NuGet packages:
  - Hangfire 1.8.20
  - Microsoft.AspNetCore.Mvc.NewtonsoftJson 9.0.6
  - Supabase 1.1.1
  - Swashbuckle.AspNetCore 8.1.4

### Screenshots


<img width="1835" height="1205" alt="Swagger1" src="https://github.com/user-attachments/assets/df979106-3fac-42f9-a476-a3324356ac62" />


<img width="1826" height="705" alt="Swagger2" src="https://github.com/user-attachments/assets/00bb1a3b-9f9b-4c54-800a-4b33532964a0" />
