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
