# WebMedApp

ASP.NET Core Web API structured with the CQRS pattern using MediatR, with separate Swagger documents for admin and client endpoints.

## Features

- Commands and queries separated into feature folders (`Features/Student/Commands`, `Features/Student/Queries`)
- MediatR request handlers for each use case
- Two Swagger/OpenAPI documents: `admin-v1` and `client-v1`
- Entity Framework Core with PostgreSQL and migrations

## Tech stack

.NET 10 · ASP.NET Core Web API · MediatR · Entity Framework Core · PostgreSQL · Swagger

## Running locally

1. Set `ConnectionStrings:DefaultConnection` in `WebMedApp/appsettings.json`.
2. Apply migrations: `dotnet ef database update --project WebMedApp`
3. Run: `dotnet run --project WebMedApp`
4. Open Swagger at `/swagger` and switch between the Client and Admin documents.
